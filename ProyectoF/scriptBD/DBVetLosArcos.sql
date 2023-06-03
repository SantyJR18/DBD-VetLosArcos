/*
 * ER/Studio Data Architect SQL Code Generation
 * Project :      ModelosLosArcosBackup.DM1
 *
 * Date Created : Thursday, May 25, 2023 00:55:08
 * Target DBMS : Microsoft SQL Server 2017
 */

/* 
 * TABLE: Cliente 
 */

CREATE DATABASE DBLosArcos
GO

USE DBLosArcos

CREATE TABLE Cliente(
    idCliente           char(16)         NOT NULL,
    primerNombre        nvarchar(50)     NOT NULL,
    segundoNombre       nvarchar(50)     NULL,
    primerApellido      nvarchar(50)     NOT NULL,
    segundoApellido     nvarchar(50)     NULL,
    direccionCliente    nvarchar(150)    NULL,
    correoCliente       nvarchar(100)    NOT NULL,
    telefonoCliente     char(8)          NOT NULL,
    CONSTRAINT PK1 PRIMARY KEY NONCLUSTERED (idCliente)
)
go



IF OBJECT_ID('Cliente') IS NOT NULL
    PRINT '<<< CREATED TABLE Cliente >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Cliente >>>'
go

/* 
 * TABLE: Desparasitantes 
 */

CREATE TABLE Desparasitantes(
    idDesparasitante    int              IDENTITY(1,1),
    nombreDes           nvarchar(100)    NOT NULL,
    idMarcaDes          int              NOT NULL,
    CONSTRAINT PK13 PRIMARY KEY NONCLUSTERED (idDesparasitante)
)
go



IF OBJECT_ID('Desparasitantes') IS NOT NULL
    PRINT '<<< CREATED TABLE Desparasitantes >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Desparasitantes >>>'
go

/* 
 * TABLE: Diagnosticos 
 */

CREATE TABLE Diagnosticos(
    idDiag             int              IDENTITY(1,1),
    descripcionDiag    nvarchar(500)    NOT NULL,
    fechaDiag          datetime         NOT NULL,
    idExp              int              NOT NULL,
    CONSTRAINT PK9 PRIMARY KEY NONCLUSTERED (idDiag)
)
go



IF OBJECT_ID('Diagnosticos') IS NOT NULL
    PRINT '<<< CREATED TABLE Diagnosticos >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Diagnosticos >>>'
go

/* 
 * TABLE: Empleados 
 */

CREATE TABLE Empleados(
    idEmpleado            int             IDENTITY(1,1),
    usuario               nvarchar(50)    NOT NULL,
    contrasenia           nvarchar(50)    NOT NULL,
    primerNombreEmp       nvarchar(50)    NOT NULL,
    primerApellidoEmp     nvarchar(50)    NOT NULL,
    SegundoApellidoEmp    nvarchar(50)    NULL,
    fechaContratacion     datetime        NOT NULL,
    segundoNombreEmp      nvarchar(50)    NULL,
    idRol                 int             NOT NULL,
    CONSTRAINT PK18 PRIMARY KEY NONCLUSTERED (idEmpleado)
)
go



IF OBJECT_ID('Empleados') IS NOT NULL
    PRINT '<<< CREATED TABLE Empleados >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Empleados >>>'
go

/* 
 * TABLE: Empresa 
 */

CREATE TABLE Empresa(
    idEmp           int             IDENTITY(1,1),
    nombreEmp       nvarchar(50)    NOT NULL,
    direccionEmp    nvarchar(200)    NOT NULL,
    telEmp          char(8)         NOT NULL,
    rucEmp          char(20)        NOT NULL,
    CONSTRAINT PK21 PRIMARY KEY NONCLUSTERED (idEmp)
)
go



IF OBJECT_ID('Empresa') IS NOT NULL
    PRINT '<<< CREATED TABLE Empresa >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Empresa >>>'
go

/* 
 * TABLE: Especies 
 */

CREATE TABLE Especies(
    idEspecie        int             IDENTITY(1,1),
    nombreEspecie    nvarchar(50)    NOT NULL,
    CONSTRAINT PK5 PRIMARY KEY NONCLUSTERED (idEspecie)
)
go



IF OBJECT_ID('Especies') IS NOT NULL
    PRINT '<<< CREATED TABLE Especies >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Especies >>>'
go

/* 
 * TABLE: Expedientes 
 */

CREATE TABLE Expedientes(
    idExp               int         IDENTITY(1,1),
    fechaCreacionExp    datetime    NOT NULL,
    idPaciente          int         NOT NULL,
    CONSTRAINT PK8 PRIMARY KEY NONCLUSTERED (idExp)
)
go



IF OBJECT_ID('Expedientes') IS NOT NULL
    PRINT '<<< CREATED TABLE Expedientes >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Expedientes >>>'
go

/* 
 * TABLE: MarcasDesparasitantes 
 */

CREATE TABLE MarcasDesparasitantes(
    idMarcaDes        int             IDENTITY(1,1),
    nombreMarcaDes    nvarchar(50)    NOT NULL,
    CONSTRAINT PK12 PRIMARY KEY NONCLUSTERED (idMarcaDes)
)
go



IF OBJECT_ID('MarcasDesparasitantes') IS NOT NULL
    PRINT '<<< CREATED TABLE MarcasDesparasitantes >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE MarcasDesparasitantes >>>'
go

/* 
 * TABLE: MarcasVacunas 
 */

CREATE TABLE MarcasVacunas(
    idMarcaVac        int             IDENTITY(1,1),
    nombreMarcaVac    nvarchar(50)    NOT NULL,
    CONSTRAINT PK14 PRIMARY KEY NONCLUSTERED (idMarcaVac)
)
go



IF OBJECT_ID('MarcasVacunas') IS NOT NULL
    PRINT '<<< CREATED TABLE MarcasVacunas >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE MarcasVacunas >>>'
go

/* 
 * TABLE: Pacientes 
 */

CREATE TABLE Pacientes(
    idPaciente        int              IDENTITY(1,1),
    nombrePaciente    nvarchar(50)     NOT NULL,
    sexoPaciente      bit              DEFAULT 1 NOT NULL,
    fechaNac          datetime         NOT NULL,
    color             nvarchar(20)     NOT NULL,
    senPart           nvarchar(200)    NULL,
    idCliente         char(16)         NOT NULL,
    idEspecie         int              NOT NULL,
    idRaza            int              NOT NULL,
    CONSTRAINT PK6 PRIMARY KEY NONCLUSTERED (idPaciente)
)
go



IF OBJECT_ID('Pacientes') IS NOT NULL
    PRINT '<<< CREATED TABLE Pacientes >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Pacientes >>>'
go

/* 
 * TABLE: Razas 
 */

CREATE TABLE Razas(
    idRaza        int             IDENTITY(1,1),
    nombreRaza    nvarchar(50)    NOT NULL,
    CONSTRAINT PK3 PRIMARY KEY NONCLUSTERED (idRaza)
)
go



IF OBJECT_ID('Razas') IS NOT NULL
    PRINT '<<< CREATED TABLE Razas >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Razas >>>'
go

/* 
 * TABLE: RegistroDesparasitaciones 
 */

CREATE TABLE RegistroDesparasitaciones(
    idDesparasitacion       int         IDENTITY(1,1),
    fechaDesparasitacion    datetime    NOT NULL,
    idExp                   int         NOT NULL,
    idDesparasitante        int         NOT NULL,
    CONSTRAINT PK11 PRIMARY KEY NONCLUSTERED (idDesparasitacion)
)
go



IF OBJECT_ID('RegistroDesparasitaciones') IS NOT NULL
    PRINT '<<< CREATED TABLE RegistroDesparasitaciones >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE RegistroDesparasitaciones >>>'
go

/* 
 * TABLE: RegistroFacturas 
 */

CREATE TABLE RegistroFacturas(
    idFactura    int         IDENTITY(1,1),
    idCliente    char(16)    NOT NULL,
    CONSTRAINT PK17 PRIMARY KEY NONCLUSTERED (idFactura)
)
go



IF OBJECT_ID('RegistroFacturas') IS NOT NULL
    PRINT '<<< CREATED TABLE RegistroFacturas >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE RegistroFacturas >>>'
go

/* 
 * TABLE: RegistroServicios 
 */

CREATE TABLE RegistroServicios(
    idRegServicio    int         IDENTITY(1,1),
    fechaConsulta    datetime    NOT NULL,
    idCliente        char(16)    NOT NULL,
    idPaciente       int         NOT NULL,
    idServicio       int         NOT NULL,
    idFactura        int         NOT NULL,
    CONSTRAINT PK10 PRIMARY KEY NONCLUSTERED (idRegServicio)
)
go



IF OBJECT_ID('RegistroServicios') IS NOT NULL
    PRINT '<<< CREATED TABLE RegistroServicios >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE RegistroServicios >>>'
go

/* 
 * TABLE: RegistroVacunaciones 
 */

CREATE TABLE RegistroVacunaciones(
    idVacunacion       int         IDENTITY(1,1),
    fechaVacunacion    datetime    NOT NULL,
    idExp              int         NOT NULL,
    idVacuna           int         NOT NULL,
    CONSTRAINT PK16 PRIMARY KEY NONCLUSTERED (idVacunacion)
)
go



IF OBJECT_ID('RegistroVacunaciones') IS NOT NULL
    PRINT '<<< CREATED TABLE RegistroVacunaciones >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE RegistroVacunaciones >>>'
go

/* 
 * TABLE: Roles 
 */

CREATE TABLE Roles(
    idRol        int             IDENTITY(1,1),
    nombreRol    nvarchar(30)    NOT NULL,
    estadoRol    bit             DEFAULT 1 NOT NULL,
    CONSTRAINT PK19 PRIMARY KEY NONCLUSTERED (idRol)
)
go



IF OBJECT_ID('Roles') IS NOT NULL
    PRINT '<<< CREATED TABLE Roles >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Roles >>>'
go

/* 
 * TABLE: Servicios 
 */

CREATE TABLE Servicios(
    idServicio        int               IDENTITY(1,1),
    nombreServicio    nvarchar(30)      NOT NULL,
    costoServicio     decimal(10, 0)    NOT NULL,
    CONSTRAINT PK7 PRIMARY KEY NONCLUSTERED (idServicio)
)
go



IF OBJECT_ID('Servicios') IS NOT NULL
    PRINT '<<< CREATED TABLE Servicios >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Servicios >>>'
go

/* 
 * TABLE: Vacunas 
 */

CREATE TABLE Vacunas(
    idVacuna        int              IDENTITY(1,1),
    nombreVacuna    nvarchar(100)    NOT NULL,
    idMarcaVac      int              NOT NULL,
    CONSTRAINT PK15 PRIMARY KEY NONCLUSTERED (idVacuna)
)
go



IF OBJECT_ID('Vacunas') IS NOT NULL
    PRINT '<<< CREATED TABLE Vacunas >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Vacunas >>>'
go

/* 
 * TABLE: Desparasitantes 
 */

ALTER TABLE Desparasitantes ADD CONSTRAINT RefMarcasDesparasitantes29 
    FOREIGN KEY (idMarcaDes)
    REFERENCES MarcasDesparasitantes(idMarcaDes)
go


/* 
 * TABLE: Diagnosticos 
 */

ALTER TABLE Diagnosticos ADD CONSTRAINT RefExpedientes15 
    FOREIGN KEY (idExp)
    REFERENCES Expedientes(idExp)
go


/* 
 * TABLE: Empleados 
 */

ALTER TABLE Empleados ADD CONSTRAINT RefRoles24 
    FOREIGN KEY (idRol)
    REFERENCES Roles(idRol)
go


/* 
 * TABLE: Expedientes 
 */

ALTER TABLE Expedientes ADD CONSTRAINT RefPacientes5 
    FOREIGN KEY (idPaciente)
    REFERENCES Pacientes(idPaciente)
go


/* 
 * TABLE: Pacientes 
 */

ALTER TABLE Pacientes ADD CONSTRAINT RefEspecies2 
    FOREIGN KEY (idEspecie)
    REFERENCES Especies(idEspecie)
go

ALTER TABLE Pacientes ADD CONSTRAINT RefRazas4 
    FOREIGN KEY (idRaza)
    REFERENCES Razas(idRaza)
go

ALTER TABLE Pacientes ADD CONSTRAINT RefCliente1 
    FOREIGN KEY (idCliente)
    REFERENCES Cliente(idCliente)
go


/* 
 * TABLE: RegistroDesparasitaciones 
 */

ALTER TABLE RegistroDesparasitaciones ADD CONSTRAINT RefExpedientes14 
    FOREIGN KEY (idExp)
    REFERENCES Expedientes(idExp)
go

ALTER TABLE RegistroDesparasitaciones ADD CONSTRAINT RefDesparasitantes30 
    FOREIGN KEY (idDesparasitante)
    REFERENCES Desparasitantes(idDesparasitante)
go


/* 
 * TABLE: RegistroFacturas 
 */

ALTER TABLE RegistroFacturas ADD CONSTRAINT RefCliente16 
    FOREIGN KEY (idCliente)
    REFERENCES Cliente(idCliente)
go


/* 
 * TABLE: RegistroServicios 
 */

ALTER TABLE RegistroServicios ADD CONSTRAINT RefCliente6 
    FOREIGN KEY (idCliente)
    REFERENCES Cliente(idCliente)
go

ALTER TABLE RegistroServicios ADD CONSTRAINT RefPacientes7 
    FOREIGN KEY (idPaciente)
    REFERENCES Pacientes(idPaciente)
go

ALTER TABLE RegistroServicios ADD CONSTRAINT RefServicios8 
    FOREIGN KEY (idServicio)
    REFERENCES Servicios(idServicio)
go

ALTER TABLE RegistroServicios ADD CONSTRAINT RefRegistroFacturas26 
    FOREIGN KEY (idFactura)
    REFERENCES RegistroFacturas(idFactura)
go


/* 
 * TABLE: RegistroVacunaciones 
 */

ALTER TABLE RegistroVacunaciones ADD CONSTRAINT RefExpedientes13 
    FOREIGN KEY (idExp)
    REFERENCES Expedientes(idExp)
go

ALTER TABLE RegistroVacunaciones ADD CONSTRAINT RefVacunas28 
    FOREIGN KEY (idVacuna)
    REFERENCES Vacunas(idVacuna)
go


/* 
 * TABLE: Vacunas 
 */

ALTER TABLE Vacunas ADD CONSTRAINT RefMarcasVacunas27 
    FOREIGN KEY (idMarcaVac)
    REFERENCES MarcasVacunas(idMarcaVac)
go


USE DBLosArcos

INSERT INTO Cliente(idCliente, primerNombre, segundoNombre, primerApellido, segundoApellido, direccionCliente, correoCliente, telefonoCliente)
VALUES
(N'001-280298-1003N', N'Norman', N'Santiago', N'Manzanares', N'Garcia', N'KM13 Carretera a Masaya, Villa Guadalupe', 
N'santiago.manzanares@gmail.com', N'88869701'),
(N'001-250602-2003J', N'Marco', N'Antonio', N'Ramirez', N'Solis', N'Colonia Centroamerica, Casa A-21', 
N'marco.antonio@gmail.com', N'88997645')

INSERT INTO Razas(nombreRaza)
VALUES
(N'Criollo'),
(N'Persa'),
(N'Pekingese'),
(N'Beagle'),
(N'Pastor alemán'),
(N'Gran danés')


INSERT INTO Especies(nombreEspecie)
VALUES
(N'canino'),
(N'felino')

INSERT INTO Pacientes(nombrePaciente, sexoPaciente, fechaNac, color, senPart, idCliente, idEspecie, idRaza)
VALUES
(N'Duke', 1, '01/01/2012', N'Café', N'Tiene problemas de Artritis', N'001-280298-1003N', 1, 1),
(N'Sabana', 0, '04/02/2011', N'Negra', N'Suele ser agresiva', N'001-250602-2003J', 2, 1)

INSERT INTO MarcasVacunas(nombreMarcaVac)
VALUES(N'Boehringer Ingelheim')

INSERT INTO Vacunas(nombreVacuna, idMarcaVac)
VALUES(N'Rabisin', 1)

INSERT INTO MarcasDesparasitantes(nombreMarcaDes)
VALUES(N'Frontline labs')

INSERT INTO Desparasitantes(nombreDes, idMarcaDes)
VALUES(N'Nexgard', 1)

INSERT INTO Expedientes(fechaCreacionExp, idPaciente)
VALUES
('06/07/2015', 1),
('08/09/2017', 2)


INSERT INTO RegistroVacunaciones(fechaVacunacion, idExp, idVacuna)
VALUES
('01/23/2023', 1, 2),
('01/24/2023', 2, 2)

INSERT INTO RegistroDesparasitaciones(fechaDesparasitacion, idExp, idDesparasitante)
VALUES
('01/23/2023', 1, 1),
('01/24/2023', 2, 1)

INSERT INTO Diagnosticos(descripcionDiag, fechaDiag, idExp)
VALUES(N'El perro tenia problema en su sistema urinario, se le recomendo seguir una dieta y tomar sus medicamentos', '01/23/2023', 1),
(N'La gata tenia problemas en sus encias, se le recomendaron antibioticos y comidas suaves', '01/24/2023', 2)

INSERT INTO Roles(nombreRol)
VALUES
(N'Recepcionista'),
(N'Médico veterinario')

INSERT INTO Empleados(usuario, contrasenia, primerNombreEmp, segundoNombreEmp, primerApellidoEmp, SegundoApellidoEmp, fechaContratacion, idRol)
VALUES
(N'Exec', N'12345', N'Norman', N'Santiago', N'Manzanares', N'Penia', '05/05/2018', 2),
(N'Durb', N'12345', N'Diego', N'José', N'Urbina', N'Reyes', '05/04/2013', 2),
(N'CSolis', N'12345', N'Camilo', N'Javier', N'Solís', N'Mejía', '10/21/2012', 1)


INSERT INTO Empresa(nombreEmp, direccionEmp, telEmp, rucEmp)
VALUES(N'Clínica veterinaria Los Arcos', N'Reparto Los Arcos. INFOM, 1C. Sur, 2C. Oeste casa, 12, Managua, 12029', N'82751784', N'K23124K1234124L1242D')

INSERT INTO Servicios(nombreServicio, costoServicio)
VALUES
(N'Consulta general', 15),
(N'Grooming', 20)

INSERT INTO RegistroFacturas(idCliente)
VALUES(N'001-280298-1003N'), (N'001-250602-2003J')

INSERT INTO RegistroServicios(fechaConsulta, idCliente, idPaciente, idServicio, idFactura)
VALUES('01/23/2023', N'001-280298-1003N', 1, 1, 2)