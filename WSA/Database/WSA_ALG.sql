USE tempdb
GO

--DROP DATABASE WS_ALG
-- Crear la base de datos


CREATE DATABASE WSA_ALG
GO

USE WSA_ALG
GO

--TABLAS

CREATE TABLE Cliente
(
	Cliente_Id INT NOT NULL IDENTITY,
	Cliente VARCHAR(70) NOT NULL,

	CONSTRAINT PK_Cliente_Cliente_Id
		PRIMARY KEY CLUSTERED (cliente_Id)
);
GO

CREATE TABLE Conductor
(
	Conductor_Id INT NOT NULL IDENTITY,
	Cliente VARCHAR(70) NOT NULL,

	CONSTRAINT PK_Conductor_Conductor_Id
		PRIMARY KEY CLUSTERED (Conductor_Id)
);
GO

CREATE TABLE Proveedor
(
	Proveedor_Id INT NOT NULL IDENTITY,
	Proveedor VARCHAR(70) NOT NULL,

	CONSTRAINT PK_Proveedor_Proveedor_Id
		PRIMARY KEY CLUSTERED (Proveedor_Id)
);
GO

CREATE TABLE Producto
(
	Producto_Id INT NOT NULL IDENTITY,
	Descripcion VARCHAR(80) NOT NULL,
	Precio DECIMAL(6,2) NOT NULL

	CONSTRAINT PK_Producto_Producto_Id
		PRIMARY KEY CLUSTERED (Producto_Id)
);
GO

CREATE TABLE Tipo_Usuario
(
	Tipo_Usuario_Id INT NOT NULL IDENTITY,
	Tipo_Usuario VARCHAR(25) NOT NULL

	CONSTRAINT PK_Tipo_Usuario_Tipo_Usuario_Id
		PRIMARY KEY CLUSTERED (Tipo_Usuario_Id)

);

CREATE TABLE Usuario
(
	Usuario_Id INT NOT NULL IDENTITY,
	Usuario VARCHAR(30) NOT NULL,
	Contrasena VARBINARY(MAX) NOT NULL,
	Tipo_Usuario_Id INT NOT NULL,
	Activo BIT NOT NULL

	CONSTRAINT PK_Usuario_Usuario_Id
		PRIMARY KEY CLUSTERED (Usuario_Id),

	CONSTRAINT FK_Usuario$Existe$Tipo_Usuario
		FOREIGN KEY (Tipo_Usuario_Id) REFERENCES Tipo_Usuario(Tipo_Usuario_Id),
);
GO

CREATE TABLE Bitacora
(
	Bitacora_Id INT NOT NULL IDENTITY,
	Usuario_Id INT NOT NULL,
	Usuario_PC VARCHAR(70) NOT NULL,
	Tipo_Accion VARCHAR(25) NOT NULL,
	Accion VARCHAR(200) NOT NULL,
	Fecha DATETIME NOT NULL

	CONSTRAINT PK_Bitacora_Bitacora_Id
		PRIMARY KEY CLUSTERED (Bitacora_ID),

	CONSTRAINT FK_Bitacora$Existe$Usuario
		FOREIGN KEY (Usuario_Id) REFERENCES Usuario(Usuario_Id),

);
GO

CREATE TABLE Barco
(
	Barco_Id INT NOT NULL IDENTITY,
	Descripcion VARCHAR(70) NOT NULL

	CONSTRAINT PK_Barco_Barco_Id
		PRIMARY KEY CLUSTERED (Barco_Id)

);
GO

CREATE TABLE Boleta
(
	Boleta_Id INT NOT NULL IDENTITY,
	Fecha_Entrada DATETIME NOT NULL,
	Fecha_Salida DATETIME NOT NULL,
	Placa_Cabezal VARCHAR(10) NOT NULL,
	Placa_Rastra VARCHAR(10) NOT NULL,
	Conductor_Id INT NULL,
	Cliente_Id INT NULL,
	Proveedor_Id INT NULL,
	Producto_Id INT NOT NULL,
	Peso_Ingreso FLOAT NULL,
	Unidades_Peso_Ingreso VARCHAR(4) NOT NULL,
	Cia_Transportista VARCHAR(25) NOT NULL,
	Envio_N VARCHAR(50) NULL,
	Peso_Salida FLOAT NULL,
	Unidades_Peso_Salida VARCHAR(4) NULL,
	Barco_Id INT NOT NULL,
	Usuario_Id INT NOT NULL,
	Estado BIT NOT NULL,
	Observaciones VARCHAR(200) NULL


	CONSTRAINT PK_Boleta_Boleta_Id
		PRIMARY KEY CLUSTERED (Boleta_Id),

	CONSTRAINT FK_Boleta$Existe$Conductor
		FOREIGN KEY (Conductor_Id) REFERENCES Conductor(Conductor_Id),

	CONSTRAINT FK_Boleta$Existe$Cliente
		FOREIGN KEY (Cliente_Id) REFERENCES Cliente(Cliente_Id),

	CONSTRAINT FK_Boleta$Existe$Proveedor
		FOREIGN KEY (Proveedor_Id) REFERENCES Proveedor(Proveedor_Id),

	CONSTRAINT FK_Boleta$Existe$Producto
		FOREIGN KEY (Producto_Id) REFERENCES Producto(Producto_Id),

	CONSTRAINT FK_Boleta$Existe$Usuario
		FOREIGN KEY (Usuario_Id) REFERENCES Usuario(Usuario_Id),

	CONSTRAINT FK_Boleta$Existe$Barco
		FOREIGN KEY (Barco_Id) REFERENCES Barco(Barco_Id)

);
GO

--PROCEDMIENTOS ALMACENADOS

CREATE PROCEDURE sp_Cliente
@Cliente_Id INT = NULL,
@Cliente VARCHAR(70) = NULL,
@valorBuscado VARCHAR(80)  = NULL,
@accion VARCHAR(50)

AS
BEGIN
	IF @accion = 'insertar'
	BEGIN
		INSERT INTO Cliente VALUES (@Cliente)
	END
	ELSE IF @accion = 'modificar'
	BEGIN
		UPDATE Cliente SET Cliente = @Cliente WHERE Cliente_Id = @Cliente_Id
	END

END
GO