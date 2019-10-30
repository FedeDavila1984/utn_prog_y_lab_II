USE [master]

CREATE DATABASE [mibasededatos]
GO
USE [mibasededatos]

CREATE TABLE personas (
  id int IDENTITY(1,1) NOT NULL,
  nombre varchar(50) NOT NULL,
  apellido varchar(50) NOT NULL,
  dni int NOT NULL
)

