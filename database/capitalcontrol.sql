-- ============================================================================
-- CapitalControl - Esquema de autenticación (Microsoft SQL Server)
-- Ejecutar primero: database\capitalcontrol.sql
-- Después ejecutar: database\capitalcontrol_datos_sqlserver.sql
-- ============================================================================
IF DB_ID('CapitalControl') IS NULL
    CREATE DATABASE CapitalControl;
GO

USE CapitalControl;
GO

IF OBJECT_ID('dbo.intentos_login') IS NOT NULL DROP TABLE dbo.intentos_login;
IF OBJECT_ID('dbo.tokens_reset')   IS NOT NULL DROP TABLE dbo.tokens_reset;
IF OBJECT_ID('dbo.sesiones')       IS NOT NULL DROP TABLE dbo.sesiones;
IF OBJECT_ID('dbo.usuarios')       IS NOT NULL DROP TABLE dbo.usuarios;
IF OBJECT_ID('dbo.roles')          IS NOT NULL DROP TABLE dbo.roles;
GO

CREATE TABLE dbo.roles (
    id             INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    nombre         NVARCHAR(50)  NOT NULL,
    descripcion    NVARCHAR(255) NULL,
    fecha_creacion DATETIME2     NOT NULL DEFAULT SYSDATETIME(),
    CONSTRAINT uk_roles_nombre UNIQUE (nombre)
);
GO

CREATE TABLE dbo.usuarios (
    id                          INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    uuid                        UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
    nombres                     NVARCHAR(100) NOT NULL,
    apellidos                   NVARCHAR(100) NOT NULL DEFAULT N'',
    email                       NVARCHAR(255) NOT NULL,
    password_hash               VARCHAR(255) NOT NULL,
    telefono                    NVARCHAR(30) NULL,
    fecha_nacimiento            DATE NULL,
    genero                      NVARCHAR(20) NOT NULL DEFAULT N'No especificado',
    rol_id                      INT NOT NULL DEFAULT 2,
    estado                      VARCHAR(25) NOT NULL DEFAULT 'activo',
    email_verificado            BIT NOT NULL DEFAULT 1,
    fecha_verificacion_email    DATETIME2 NULL,
    token_verificacion_email    NVARCHAR(255) NULL,
    ultimo_acceso               DATETIME2 NULL,
    intentos_fallidos           INT NOT NULL DEFAULT 0,
    bloqueado_hasta             DATETIME2 NULL,
    fecha_creacion              DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
    fecha_actualizacion         DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
    CONSTRAINT uk_usuarios_uuid UNIQUE (uuid),
    CONSTRAINT uk_usuarios_email UNIQUE (email),
    CONSTRAINT fk_usuarios_rol FOREIGN KEY (rol_id) REFERENCES dbo.roles(id),
    CONSTRAINT ck_usuarios_estado CHECK (estado IN ('activo','inactivo','bloqueado','pendiente_verificacion'))
);
GO

CREATE INDEX idx_usuarios_estado ON dbo.usuarios (estado);
GO

CREATE TABLE dbo.sesiones (
    id               INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    usuario_id       INT NOT NULL REFERENCES dbo.usuarios(id) ON DELETE CASCADE,
    token            NVARCHAR(255) NOT NULL,
    dispositivo      NVARCHAR(255) NULL,
    ip               NVARCHAR(45) NULL,
    user_agent       NVARCHAR(MAX) NULL,
    fecha_creacion   DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
    fecha_expiracion DATETIME2 NOT NULL,
    activo           BIT NOT NULL DEFAULT 1,
    CONSTRAINT uk_sesiones_token UNIQUE (token)
);
GO

CREATE INDEX idx_sesiones_usuario ON dbo.sesiones (usuario_id);
GO

CREATE TABLE dbo.tokens_reset (
    id               INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    usuario_id       INT NOT NULL REFERENCES dbo.usuarios(id) ON DELETE CASCADE,
    token            NVARCHAR(255) NOT NULL,
    usado            BIT NOT NULL DEFAULT 0,
    fecha_creacion   DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
    fecha_expiracion DATETIME2 NOT NULL,
    ip_solicitud     NVARCHAR(45) NULL,
    CONSTRAINT uk_tokens_reset_token UNIQUE (token)
);
GO

CREATE TABLE dbo.intentos_login (
    id     INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    email  NVARCHAR(255) NOT NULL,
    ip     NVARCHAR(45) NULL,
    exitoso BIT NOT NULL DEFAULT 0,
    fecha  DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
    razon  NVARCHAR(255) NULL
);
GO

CREATE INDEX idx_intentos_email ON dbo.intentos_login (email);
GO

SET IDENTITY_INSERT dbo.roles ON;
INSERT INTO dbo.roles (id, nombre, descripcion) VALUES
    (1, N'admin',   N'Administrador del sistema'),
    (2, N'cliente', N'Usuario cliente estándar');
SET IDENTITY_INSERT dbo.roles OFF;
GO

INSERT INTO dbo.usuarios (nombres, apellidos, email, password_hash, rol_id, estado, email_verificado)
VALUES (N'Usuario', N'Demo', N'demo@capitalcontrol.com',
        '$2a$11$jEVoqeTyZzM.55lKjr5jjONlzNt0.a2RcrrlEUqTyKNaaqWnMrLQm', 1, 'activo', 1);
GO
