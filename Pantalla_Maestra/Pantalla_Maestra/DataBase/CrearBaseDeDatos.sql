-- Si la base de datos ya existe, la elimina para empezar de forma limpia
IF DB_ID('bd_gestion') IS NOT NULL
BEGIN
    ALTER DATABASE bd_gestion SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE bd_gestion;
END
GO

-- Crea la base de datos
CREATE DATABASE bd_gestion;
GO

-- Cambia a la nueva base de datos para trabajar en ella
USE bd_gestion;
GO

-- Crea la tabla de Usuarios [cite: 50]
CREATE TABLE Usuarios (
    IdUsuario INT PRIMARY KEY IDENTITY(1,1),
    Usuario VARCHAR(50) NOT NULL UNIQUE,
    Contrasena VARCHAR(255) NOT NULL,
    Rol VARCHAR(50) NOT NULL
);
GO

-- Inserta los usuarios de ejemplo para los roles [cite: 3]
INSERT INTO Usuarios (Usuario, Contrasena, Rol) VALUES 
('admin', 'admin123', 'Administrador'),
('vendedor', 'vendedor123', 'Vendedor'),
('almacen', 'almacen123', 'Almacenista');
GO

-- Crea la tabla de Productos [cite: 49]
CREATE TABLE Productos (
    ProductoID INT PRIMARY KEY IDENTITY(1,1),
    Codigo VARCHAR(50) UNIQUE NOT NULL,
    Nombre VARCHAR(100) NOT NULL,
    Descripcion VARCHAR(255),
    Precio DECIMAL(18, 2) NOT NULL,
    Stock INT NOT NULL
);
GO

-- Crea la tabla de Clientes [cite: 49]
CREATE TABLE Clientes (
    ClienteID INT PRIMARY KEY IDENTITY(1,1),
    Documento VARCHAR(20) UNIQUE NOT NULL,
    Nombre VARCHAR(100) NOT NULL,
    Apellido VARCHAR(100),
    Direccion VARCHAR(200),
    Telefono VARCHAR(15)
);
GO

-- Crea la tabla de Empleados [cite: 49]
CREATE TABLE Empleados (
    EmpleadoID INT PRIMARY KEY IDENTITY(1,1),
    Documento VARCHAR(20) UNIQUE NOT NULL,
    Nombre VARCHAR(100) NOT NULL,
    Apellido VARCHAR(100),
    Puesto VARCHAR(50),
    FechaContratacion DATE
);
GO