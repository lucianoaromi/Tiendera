SELECT IdVenta, TipoDocumento, NumeroDocumento, DocumentoCliente, ApellidoCliente, NombreCliente, MontoTotal, EstadoEntrega
FROM VENTA;
go

----------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE usp_ActualizarEstadoEntrega
(
    @IdVenta INT,          -- ID de la venta a actualizar
    @EstadoEntrega BIT,    -- Nuevo estado: 1 para "Entregado", 0 para "No entregado"
    @Resultado BIT OUTPUT, -- Indica si la operación fue exitosa
    @Mensaje VARCHAR(500) OUTPUT -- Mensaje en caso de error
)
AS
BEGIN
    BEGIN TRY
        -- Inicializamos los valores de salida
        SET @Resultado = 1;
        SET @Mensaje = 'Estado actualizado correctamente.';

        -- Actualizamos el estado de la venta
        UPDATE VENTA
        SET EstadoEntrega = @EstadoEntrega
        WHERE IdVenta = @IdVenta;

        -- Validamos si se encontró la venta
        IF @@ROWCOUNT = 0
        BEGIN
            SET @Resultado = 0;
            SET @Mensaje = 'Venta no encontrada.';
        END
    END TRY
    BEGIN CATCH
        -- En caso de error, devolvemos el mensaje del error
        SET @Resultado = 0;
        SET @Mensaje = ERROR_MESSAGE();
    END CATCH;
END;
GO


----------------------------------------------------------------------------------------------------------------


DECLARE @Resultado BIT;
DECLARE @Mensaje VARCHAR(500);

EXEC usp_ActualizarEstadoEntrega
    @IdVenta = 1,
    @EstadoEntrega = 0,
    @Resultado = @Resultado OUTPUT,
    @Mensaje = @Mensaje OUTPUT;

SELECT @Resultado AS Resultado, @Mensaje AS Mensaje;
go

----------------------------------------------------------------------------------------------------------------

DECLARE @Resultado BIT;
DECLARE @Mensaje VARCHAR(500);

EXEC usp_ActualizarEstadoEntrega
    @IdVenta = 3,
    @EstadoEntrega = 0,
    @Resultado = @Resultado OUTPUT,
    @Mensaje = @Mensaje OUTPUT;

SELECT @Resultado AS Resultado, @Mensaje AS Mensaje;
go


