USE FADSA_PC
GO


CREATE PROCEDURE sp_Historico
@valorBuscado VARCHAR(80)  = NULL,
@fechaInicio DATETIME = NULL,@fechaFinal DATETIME = NULL,
@accion VARCHAR(50)

AS
BEGIN
	IF @accion = 'mostrar'
	BEGIN
		SELECT Boleta_Id 'Código de boleta', Fecha 'Fecha de entrada', Fecha_S 'Fecha de salida', Placa, Conductor_ID 'Código de conductor', Conductor, Cliente, Producto, CONCAT(Peso_I, ' ', Peso_I_U) 'Peso de ingreso',
		CONCAT(Peso_S, ' ', Peso_S_U) 'Peso de salida', CONCAT(Peso_N, ' ', Peso_N_U) 'Peso neto', Usuario_ID Usuario, Estado, Observacion 'Observación'
		FROM Blt_BoletaS
	END
	ELSE IF @accion = 'buscar'
	BEGIN
		SELECT Boleta_Id 'Código de boleta', Fecha 'Fecha de entrada', Fecha_S 'Fecha de salida', Placa, Conductor_ID 'Código de conductor', Conductor, Cliente, Producto, CONCAT(Peso_I, ' ', Peso_I_U) 'Peso de ingreso',
		CONCAT(Peso_S, ' ', Peso_S_U) 'Peso de salida', CONCAT(Peso_N, ' ', Peso_N_U) 'Peso neto', Usuario_ID Usuario, Estado, Observacion 'Observación'
		FROM Blt_BoletaS
		WHERE CONVERT(DATE, Fecha) BETWEEN @fechaInicio and @fechaFinal AND  
		CONCAT(Boleta_ID, ' ', Placa, ' ', Conductor_Id,' ', Conductor,' ', Cliente_ID,' ', Cliente,' ', Producto_ID,' ', Producto,' ', Usuario_ID ) LIKE CONCAT('%', @valorBuscado,'%')
	END
END
GO
