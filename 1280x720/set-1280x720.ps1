Add-Type -TypeDefinition @"
using System;
using System.Runtime.InteropServices;

public class Display {
  [StructLayout(LayoutKind.Sequential, CharSet=CharSet.Ansi)]
  public struct DEVMODE {
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst=32)]
    public string dmDeviceName;
    public short  dmSpecVersion;
    public short  dmDriverVersion;
    public short  dmSize;
    public short  dmDriverExtra;
    public int    dmFields;

    public int dmPositionX;
    public int dmPositionY;
    public int dmDisplayOrientation;
    public int dmDisplayFixedOutput;

    public short dmColor;
    public short dmDuplex;
    public short dmYResolution;
    public short dmTTOption;
    public short dmCollate;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst=32)]
    public string dmFormName;
    public short dmLogPixels;
    public int dmBitsPerPel;
    public int dmPelsWidth;
    public int dmPelsHeight;
    public int dmDisplayFlags;
    public int dmDisplayFrequency;

    public int dmICMMethod;
    public int dmICMIntent;
    public int dmMediaType;
    public int dmDitherType;
    public int dmReserved1;
    public int dmReserved2;
    public int dmPanningWidth;
    public int dmPanningHeight;
  }

  [DllImport("user32.dll")]
  public static extern bool EnumDisplaySettings(string deviceName, int modeNum, ref DEVMODE devMode);

  [DllImport("user32.dll")]
  public static extern int ChangeDisplaySettings(ref DEVMODE devMode, int flags);

  public const int ENUM_CURRENT_SETTINGS = -1;

  public const int DM_PELSWIDTH  = 0x00080000;
  public const int DM_PELSHEIGHT = 0x00100000;

  public const int DISP_CHANGE_SUCCESSFUL = 0;

  public static void SetResolution(int width, int height) {
    DEVMODE dm = new DEVMODE();
    dm.dmDeviceName = new string(new char[32]);
    dm.dmFormName   = new string(new char[32]);
    dm.dmSize = (short)Marshal.SizeOf(typeof(DEVMODE));

    if(!EnumDisplaySettings(null, ENUM_CURRENT_SETTINGS, ref dm)) {
      throw new Exception("No se pudo leer la configuración actual del display.");
    }

    dm.dmPelsWidth = width;
    dm.dmPelsHeight = height;
    dm.dmFields = DM_PELSWIDTH | DM_PELSHEIGHT;

    int result = ChangeDisplaySettings(ref dm, 0);
    if(result != DISP_CHANGE_SUCCESSFUL) {
      throw new Exception("No se pudo aplicar 1280x720. Puede que tu monitor/GPU no soporte esa resolución (código: " + result + ").");
    }
  }
}
"@

try {
  [Display]::SetResolution(1280, 720)
  Write-Host "Resolución cambiada a 1280x720."
} catch {
  Write-Error $_
}
