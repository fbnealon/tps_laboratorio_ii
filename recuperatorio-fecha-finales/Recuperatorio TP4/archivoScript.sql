USE [pacientes_db]
GO
CREATE TABLE[dbo].[pacientes]
(
[id] [int] NULL,
[nombre] [varchar] (50) NULL,
[apellido] [varchar] (50) NULL,
[edad] [int] NULL,
[especialidad] [varchar] (50) NULL
) ON[PRIMARY]
GO