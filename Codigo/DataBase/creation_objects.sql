/*
Name   : ERP
Link   : https://github.com/DylanRodriguez22/Proyecto1_Bases1.git
Version: 20/09/2024
Autores: Yosimar Montenegro y Dylan Rodríguez
--------------------------------------------------------------------
*/

CREATE DATABASE ERP
GO

USE ERP
GO

CREATE SCHEMA Ventas
GO

CREATE SCHEMA Produccion
GO

CREATE SCHEMA RRHH -- Recursos humanos
GO

-- Creacion de tablas

CREATE TABLE RRHH.Departamento (
	nombre VARCHAR (150) PRIMARY KEY NOT NULL,
	codigo VARCHAR (10) NOT NULL
);

CREATE TABLE RRHH.Puesto (
	nombre VARCHAR (150) PRIMARY KEY NOT NULL,
	nombreD_Departamento VARCHAR (150) NOT NULL,
	salarioActual FLOAT
	FOREIGN KEY (nombreD_Departamento) REFERENCES RRHH.Departamento(nombre)
);

CREATE TABLE RRHH.Usuario (
	cedula VARCHAR (20) PRIMARY KEY NOT NULL,
	nombrePuesto_Puesto VARCHAR (150),
	primerNombre VARCHAR (20) NOT NULL,
	segundoNombre VARCHAR (20) NOT NULL,
	primerApellido VARCHAR (20) NOT NULL,
	segundoApellido VARCHAR (20) NOT NULL,
	genero VARCHAR (10) NOT NULL,
	provincia VARCHAR (20) NOT NULL,
	canton VARCHAR (20) NOT NULL,
	distrito VARCHAR (20) NOT NULL,
	seniaExacta VARCHAR (100) NOT NULL,
	FOREIGN KEY (nombrePuesto_Puesto) REFERENCES RRHH.Puesto(nombre)
);


CREATE TABLE RRHH.Pago (
	ID INT IDENTITY (1, 1) PRIMARY KEY,
	cedulaAdjudicado_Usuario VARCHAR (20) NOT NULL,
	montoJornadaRegular INT NOT NULL,
	montoHorasExtra INT,
	horasExtra TIME,
	jornadaRegular TIME NOT NULL,
	fechaHora DATETIME NOT NULL,
	FOREIGN KEY (cedulaAdjudicado_Usuario) REFERENCES RRHH.Usuario(cedula)
);

CREATE TABLE RRHH.HistoricoPuesto (
	ID INT IDENTITY (1, 1) PRIMARY KEY,
	puestoActual_Puesto VARCHAR (150) NOT NULL,
	cedulaU_Usuario VARCHAR (20) NOT NULL,
	fechaInicio DATE NOT NULL,
	fechaFin DATE NOT NULL,
	FOREIGN KEY (puestoActual_Puesto) REFERENCES RRHH.Puesto(nombre),
	FOREIGN KEY (cedulaU_Usuario) REFERENCES RRHH.Usuario(cedula)
);

CREATE TABLE RRHH.HistoricoSalario (
	ID INT IDENTITY (1, 1) PRIMARY KEY,
	IDHistorico_HistoricoPuesto INT NOT NULL,
	fechaInicio DATE NOT NULL,
	fechaFin DATE NOT NULL,
	monto INT NOT NULL,
	FOREIGN KEY (IDHistorico_HistoricoPuesto) REFERENCES RRHH.HistoricoPuesto (ID)
	
);

CREATE TABLE Ventas.Cliente (
	cedula VARCHAR (20) PRIMARY KEY NOT NULL,
	tipoCedula VARCHAR(10) NOT NULL,
	fax VARCHAR (20) NOT NULL,
	primerNombre VARCHAR (20) NOT NULL,
	segundoNombre VARCHAR (20),
	primerApellido VARCHAR (20),
	segundoApellido VARCHAR (20),
	genero VARCHAR (10) NOT NULL,
	provincia VARCHAR (20) NOT NULL,
	canton VARCHAR (20) NOT NULL,
	distrito VARCHAR (20) NOT NULL,
	seniaExacta VARCHAR (100) NOT NULL,
);
-- Tabla del multievaluado Telefonos
CREATE TABLE Ventas.TelefonosCliente (
	numeroTelefono VARCHAR (20) PRIMARY KEY NOT NULL,
	duenio_Cliente VARCHAR (20) NOT NULL,
	FOREIGN KEY (duenio_Cliente) REFERENCES Ventas.Cliente(cedula)
);

CREATE TABLE Ventas.Cotizacion (
	ID INT IDENTITY (1, 1) PRIMARY KEY,
	cedulaCotizador_Cliente VARCHAR (20) NOT NULL,
	cedulaEmpleado_Usuario VARCHAR (20) NOT NULL,
	montoTotal INT,
	fechaCierreProyectada DATE NOT NULL,
	fechaHora DATETIME NOT NULL
	FOREIGN KEY (cedulaCotizador_Cliente) REFERENCES Ventas.Cliente(cedula),
	FOREIGN KEY (cedulaEmpleado_Usuario) REFERENCES RRHH.Usuario(cedula)
);

CREATE TABLE Ventas.Caso (
	ID INT IDENTITY (1, 1) PRIMARY KEY,
	IDCotizacion_Cotización INT NOT NULL,
	estado VARCHAR (10) NOT NULL,
	descripcion VARCHAR (255) NOT NULL,
	motivo VARCHAR (120) NOT NULL,
	resultado VARCHAR (120),
	FOREIGN KEY (IDCotizacion_Cotización) REFERENCES Ventas.Cotizacion(ID)
);

CREATE TABLE Ventas.Factura (
	ID INT IDENTITY (1, 1) PRIMARY KEY,
	responsable_Usuario VARCHAR (20) NOT NULL,

);
