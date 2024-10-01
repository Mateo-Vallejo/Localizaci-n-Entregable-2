CREATE DATABASE db_Localizacion
GO

USE db_Localizacion
GO

CREATE TABLE Personas
(
	[Id] INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	[Cedula] NVARCHAR(20) NOT NULL,
	[Nombre] NVARCHAR(50) NOT NULL,
	[Edad] INT NOT NULL,
	[Activo] BIT
);
GO

INSERT INTO [Personas] ([Cedula],[Nombre],[Edad],[Activo])
VALUES ('1020333366','Samuel Garcia', 20, 1);

INSERT INTO [Personas] ([Cedula],[Nombre],[Edad],[Activo])
VALUES ('1044733299','Mateo Vallejo', 20, 1);

CREATE TABLE Localidades
(
	[Id] INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	[Pais] NVARCHAR(50) NOT NULL,
	[Estado] NVARCHAR(50) NOT NULL,
	[CodigoPostal] NVARCHAR(50) NOT NULL,
	[Ciudad] NVARCHAR(50) NOT NULL,
	[Barrio] NVARCHAR(50) NOT NULL,
	[Calle] NVARCHAR(50) NOT NULL,
	[Activo] BIT
);
GO

INSERT INTO [Localidades] ([Pais],[Estado],[CodigoPostal],[Ciudad],[Barrio],[Calle],[Activo])
VALUES ('Colombia','Antioquia','05001','Medellin','Villa Hermosa',' Cl. 54a #30-01,',1);

INSERT INTO [Localidades] ([Pais],[Estado],[CodigoPostal],[Ciudad],[Barrio],[Calle],[Activo])
VALUES ('Colombia','Antioquia','05002','Medellin','Robledo',' Calle 73 No. 76A – 354',1);

CREATE TABLE Ubicaciones
(
	[Id] INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	[Latitud] DECIMAL (9,6) NOT NULL,
	[Longitud] DECIMAL (9,6) NOT NULL,
	[Activo] BIT
);
GO

INSERT INTO [Ubicaciones] ([Latitud],[Longitud],[Activo])
VALUES (6.244922241492459, -75.55001051413606, 1);

INSERT INTO [Ubicaciones] ([Latitud],[Longitud],[Activo])
VALUES (6.27353842265629, -75.58852660198558, 1);

CREATE TABLE Imagenes
( 
	[Id] INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	[Url] NVARCHAR(2040) NOT NULL,
	[Activo] BIT
);
GO

INSERT INTO [Imagenes] ([Url],[Activo])
VALUES ('https://www.itm.edu.co//wp-content/uploads/noticias/fraternidad-2.jpg', 1);

INSERT INTO [Imagenes] ([Url],[Activo])
VALUES ('https://www.itm.edu.co//wp-content/uploads/campus/Robledo/fotos_campusRobledo00.jpg', 1);


CREATE TABLE DetallesImagenes
(
	[Id] INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	[Autor] NVARCHAR(50) NOT NULL,
	[Titulo] NVARCHAR(50) NOT NULL,
	[Fecha] DATE NOT NULL,
	[Detalles] NVARCHAR(2040),
	[Activo] BIT
);
GO

INSERT INTO [DetallesImagenes] ([Autor],[Titulo],[Fecha],[Detalles],[Activo])
VALUES ('ITM','SEDE FRATERNIDAD',GETDATE(),'Campus Universitario', 1);

INSERT INTO [DetallesImagenes] ([Autor],[Titulo],[Fecha],[Detalles],[Activo])
VALUES ('ITM', 'SEDE ROBLEDO',GETDATE(), 'Campus Universitario', 1);

CREATE TABLE Localizaciones
(
	[Id] INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	[personas] INT REFERENCES [Personas]([Id]),
	[localidades] INT REFERENCES [Localidades]([Id]),
	[ubicaciones] INT REFERENCES [Ubicaciones]([Id]),
	[imagenes] INT REFERENCES [Imagenes]([Id]),
	[detalles] INT REFERENCES [DetallesImagenes]([Id]),
	[Hora] TIME NOT NULL,
 	[Activo] BIT
);
GO

INSERT INTO [Localizaciones] ([personas],[localidades],[ubicaciones],[imagenes],[Detalles],[Hora],[Activo])
VALUES (1,1,1,1,1,GETDATE(),1);

INSERT INTO [Localizaciones] ([personas],[localidades],[ubicaciones],[imagenes],[Detalles],[Hora],[Activo])
VALUES (2,2,2,2,2,GETDATE(),1);


SELECT *
FROM [Personas] P
	INNER JOIN [Localizaciones] L ON P.Id = L.id;