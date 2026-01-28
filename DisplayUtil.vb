Imports System.Runtime.InteropServices

Public Module DisplayUtil

    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Ansi)>
    Public Structure DEVMODE
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=32)>
        Public dmDeviceName As String
        Public dmSpecVersion As Short
        Public dmDriverVersion As Short
        Public dmSize As Short
        Public dmDriverExtra As Short
        Public dmFields As Integer

        Public dmPositionX As Integer
        Public dmPositionY As Integer
        Public dmDisplayOrientation As Integer
        Public dmDisplayFixedOutput As Integer

        Public dmColor As Short
        Public dmDuplex As Short
        Public dmYResolution As Short
        Public dmTTOption As Short
        Public dmCollate As Short
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=32)>
        Public dmFormName As String
        Public dmLogPixels As Short
        Public dmBitsPerPel As Integer
        Public dmPelsWidth As Integer
        Public dmPelsHeight As Integer
        Public dmDisplayFlags As Integer
        Public dmDisplayFrequency As Integer

        Public dmICMMethod As Integer
        Public dmICMIntent As Integer
        Public dmMediaType As Integer
        Public dmDitherType As Integer
        Public dmReserved1 As Integer
        Public dmReserved2 As Integer
        Public dmPanningWidth As Integer
        Public dmPanningHeight As Integer
    End Structure

    <DllImport("user32.dll", CharSet:=CharSet.Ansi)>
    Private Function EnumDisplaySettings(deviceName As String, modeNum As Integer, ByRef devMode As DEVMODE) As Boolean
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Ansi)>
    Private Function ChangeDisplaySettings(ByRef devMode As DEVMODE, flags As Integer) As Integer
    End Function

    Private Const ENUM_CURRENT_SETTINGS As Integer = -1

    Private Const DM_PELSWIDTH As Integer = &H80000
    Private Const DM_PELSHEIGHT As Integer = &H100000

    Public Const DISP_CHANGE_SUCCESSFUL As Integer = 0
    Public Const DISP_CHANGE_RESTART As Integer = 1
    Public Const DISP_CHANGE_FAILED As Integer = -1
    Public Const DISP_CHANGE_BADMODE As Integer = -2
    Public Const DISP_CHANGE_NOTUPDATED As Integer = -3
    Public Const DISP_CHANGE_BADFLAGS As Integer = -4
    Public Const DISP_CHANGE_BADPARAM As Integer = -5

    Public Function GetCurrentDevMode() As DEVMODE
        Dim dm As New DEVMODE With {
            .dmDeviceName = New String(ChrW(0), 32),
            .dmFormName = New String(ChrW(0), 32)
        }
        dm.dmSize = CShort(Marshal.SizeOf(GetType(DEVMODE)))

        If Not EnumDisplaySettings(Nothing, ENUM_CURRENT_SETTINGS, dm) Then
            Throw New Exception("No se pudo leer la configuración actual del display.")
        End If

        Return dm
    End Function

    Public Function SetResolution(width As Integer, height As Integer) As Integer
        Dim dm As DEVMODE = GetCurrentDevMode()

        dm.dmPelsWidth = width
        dm.dmPelsHeight = height
        dm.dmFields = dm.dmFields Or (DM_PELSWIDTH Or DM_PELSHEIGHT)

        Return ChangeDisplaySettings(dm, 0)
    End Function

    Public Function Restore(original As DEVMODE) As Integer
        original.dmFields = original.dmFields Or (DM_PELSWIDTH Or DM_PELSHEIGHT)
        Return ChangeDisplaySettings(original, 0)
    End Function

End Module
