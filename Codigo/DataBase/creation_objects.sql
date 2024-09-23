/*
Name   : ERP
Link   : https://github.com/DylanRodriguez22/Proyecto1_Bases1.git
Version: 22/09/2024
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

CREATE TABLE RRHH.Departamento ( -- Tabla catalogo_departamento
	nombre VARCHAR (20) PRIMARY KEY NOT NULL,
	codigo VARCHAR (10) NOT NULL
);

CREATE TABLE RRHH.Puesto ( -- Tabla catalogo_puesto_departamento
	nombre VARCHAR (150) PRIMARY KEY NOT NULL,
	nombreD_Departamento VARCHAR (20) NOT NULL,
	FOREIGN KEY (nombreD_Departamento) REFERENCES RRHH.Departamento(nombre)
);

CREATE TABLE RRHH.Usuario (
	cedula VARCHAR (20) PRIMARY KEY NOT NULL,
	nombrePuesto_Puesto VARCHAR (150),
	primerNombre VARCHAR (20) NOT NULL,
	segundoNombre VARCHAR (20) NOT NULL,
	primerApellido VARCHAR (20) NOT NULL,
	segundoApellido VARCHAR (20) NOT NULL,
	provincia VARCHAR (20) NOT NULL,
	canton VARCHAR (20) NOT NULL,
	distrito VARCHAR (20) NOT NULL,
	seniaExacta VARCHAR (100) NOT NULL,
	fechaRegistro DATE NOT NULL,
	fechaDeNacimiento DATE NOT NULL,
	salarioActual FLOAT NOT NULL,

	-- CREDENCIALES 
	usuario VARCHAR (15),
	contrasenia VARCHAR (15)
	FOREIGN KEY (nombrePuesto_Puesto) REFERENCES RRHH.Puesto(nombre)
	CONSTRAINT AK_Usuario UNIQUE(usuario)
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

/*
Creacion de tablas del schema Ventas
*/

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
	seniaExacta VARCHAR (100) NOT NULL
);

-- Tabla del multievaluado Telefonos
CREATE TABLE Ventas.TelefonosCliente (
	numeroTelefono VARCHAR (20) PRIMARY KEY NOT NULL,
	duenio_Cliente VARCHAR (20) NOT NULL,
	FOREIGN KEY (duenio_Cliente) REFERENCES Ventas.Cliente(cedula)
);

CREATE TABLE Ventas.Genero ( -- Tabla catalogo_Genero
	ID INT IDENTITY (1, 1) PRIMARY KEY,
	descripcion VARCHAR (10) NOT NULL,
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

CREATE TABLE Ventas.Tarea (
	ID INT IDENTITY (1, 1) PRIMARY KEY,
	IDCaso_Caso INT NOT NULL,
	descripcion VARCHAR (100) NOT NULL,
	etapa VARCHAR (25),
	FOREIGN KEY (IDCaso_Caso) REFERENCES Ventas.Caso(ID)
);

CREATE TABLE Ventas.Estado ( -- Tabla catalogo_Estado
	ID INT IDENTITY (1, 1) PRIMARY KEY,
	descripcion VARCHAR (20) NOT NULL
);

CREATE TABLE Ventas.Etapa ( -- Tabla catalogo_Etapa
	ID INT IDENTITY (1, 1) PRIMARY KEY,
	descripcion VARCHAR (20) NOT NULL
);

CREATE TABLE Ventas.Factura (
	ID INT IDENTITY (1, 1) PRIMARY KEY,
	responsable_Usuario VARCHAR (20) NOT NULL,
	comprador_Usuario VARCHAR (20) NOT NULL,
	fechaHora DATETIME NOT NULL,
	estado VARCHAR (15),
	motivoAnulacion VARCHAR (200) NOT NULL, -- En caso que la factura haya sido cancelada antes de su confirmación
	FOREIGN KEY (responsable_Usuario) REFERENCES RRHH.Usuario(cedula),
	FOREIGN KEY (comprador_Usuario) REFERENCES Ventas.Cliente(cedula)
);

CREATE TABLE Ventas.Salida (
	ID INT IDENTITY (1, 1) PRIMARY KEY,
	IDFactura_Factura INT NOT NULL,
	fechaHora DATETIME NOT NULL,
	FOREIGN KEY (IDFactura_Factura) REFERENCES Ventas.Factura(ID)
);

CREATE TABLE Produccion.Bodega (
	codigo VARCHAR (10) PRIMARY KEY NOT NULL,
	nombre VARCHAR (30) NOT NULL,
	provincia VARCHAR (20) NOT NULL,
	canton VARCHAR (20) NOT NULL,
	distrito VARCHAR (20) NOT NULL,
	seniaExacta VARCHAR (100) NOT NULL,
	toneladasCapacidad INT NOT NULL,
	espacioCubico INT NOT NULL
);

CREATE TABLE Produccion.Familia (
	codigo VARCHAR (10) PRIMARY KEY NOT NULL,
	nombre VARCHAR (30) NOT NULL,
	descripcion VARCHAR (150) NOT NULL,
	activo VARCHAR (10)
	CONSTRAINT AK_Nombre UNIQUE(nombre)
);

CREATE TABLE Produccion.FamiliaBodega (
	codigoF_Familia VARCHAR (10) NOT NULL,
	codigoB_Bodega VARCHAR (10) NOT NULL,
	FOREIGN KEY (codigoF_Familia) REFERENCES Produccion.Familia(codigo),
	FOREIGN KEY (codigoB_Bodega) REFERENCES Produccion.Bodega(codigo)
);

CREATE TABLE Produccion.Articulo (
	nombre VARCHAR (130) PRIMARY KEY NOT NULL, -- Darle libertad de nombre por desconocer la empresa objetivo
	codigoF_Familia VARCHAR (10) NOT NULL,
	codigo INT NOT NULL,
	precio INT NOT NULL,
	peso INT NOT NULL,
	descripcion VARCHAR (255) NOT NULL, -- Libertar de descripción de producto 
	marca VARCHAR (50) NOT NULL,
	activo VARCHAR (10),
	FOREIGN KEY (codigoF_Familia) REFERENCES Produccion.Familia(codigo),
	CONSTRAINT AK_Codigo UNIQUE(codigo) -- Los codigos de productos deben ser unicos a no ser que sean eliminados del sistema
);

CREATE TABLE Produccion.Movimiento (
	ID INT IDENTITY (1, 1) PRIMARY KEY,
	codigoOrigen_Bodega VARCHAR (10) NOT NULL,
	codigoDestino_Bodega VARCHAR (10) NOT NULL,
	responsable_Usuario VARCHAR (20) NOT NULL,
	fechaHora DATETIME NOT NULL,
	FOREIGN KEY (responsable_Usuario) REFERENCES RRHH.Usuario(cedula),
	FOREIGN KEY (codigoOrigen_Bodega) REFERENCES Produccion.Bodega (codigo),
	FOREIGN KEY (codigoDestino_Bodega) REFERENCES Produccion.Bodega (codigo)
);

-- Tabla para agregar lineas de productos (cantidad) independientes a un movimiento
CREATE TABLE Produccion.MovimientoArticulo (
	IDMovimiento_Movimiento INT NOT NULL,
	nombreA_Articulo VARCHAR (130) NOT NULL,
	cantidadArticulo INT NOT NULL,
	FOREIGN KEY (IDMovimiento_Movimiento) REFERENCES Produccion.Movimiento (ID),
	FOREIGN KEY (nombreA_Articulo) REFERENCES Produccion.Articulo(nombre)
);

CREATE TABLE Produccion.Entrada (
	ID INT IDENTITY (1, 1) PRIMARY KEY,
	codigoDestino_Bodega VARCHAR (10) NOT NULL,
	responsable_Usuario VARCHAR(20) NOT NULL,
	fechaHora DATETIME NOT NULL,
	FOREIGN KEY (responsable_Usuario) REFERENCES RRHH.Usuario (cedula),
	FOREIGN KEY (codigoDestino_Bodega) REFERENCES Produccion.Bodega(codigo)
);

CREATE TABLE Produccion.EntradaArticulo (
	IDEntrada_Entrada INT NOT NULL,
	nombreA_Articulo VARCHAR (130) NOT NULL,
	cantidadArticulo INT NOT NULL,
	FOREIGN KEY (nombreA_Articulo) REFERENCES Produccion.Articulo(nombre),
	FOREIGN KEY (IDEntrada_Entrada) REFERENCES Produccion.Entrada(ID)
);

CREATE TABLE Produccion.Inventario ( -- Esta tabla pertenece al schema de producción pero puede ser visualizada desde la venta
	codigoB_Bodega VARCHAR (10) NOT NULL,
	nombreA_Articulo VARCHAR (130) NOT NULL,
	cantidad INT NOT NULL,
	FOREIGN KEY (codigoB_Bodega) REFERENCES Produccion.Bodega(codigo),
	FOREIGN KEY (nombreA_Articulo) REFERENCES Produccion.Articulo(nombre)
);

-- Esta tabla es intermedia entre el esquema de ventas y produccion
CREATE TABLE Ventas.FacturaInventario (
	ID_Factura INT NOT NULL,
	nombreA_Articulo VARCHAR(130) NOT NULL,
	codigoB_Bodega VARCHAR (10) NOT NULL,
	cantidadProducto INT NOT NULL,
	FOREIGN KEY (ID_Factura) REFERENCES Ventas.Factura(ID),
	FOREIGN KEY (nombreA_Articulo) REFERENCES Produccion.Articulo(nombre),
	FOREIGN KEY (codigoB_Bodega) REFERENCES Produccion.Bodega(codigo)
);

CREATE TABLE Ventas.TipoCedula ( -- Tabla catalogo_tipoCedula
	ID INT IDENTITY (1, 1) PRIMARY KEY,
	tipo VARCHAR (50) NOT NULL
);