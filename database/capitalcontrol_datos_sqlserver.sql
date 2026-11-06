-- ============================================================================
-- CapitalControl - Tablas de datos de la app (SQL Server)
-- Requiere que ya existan la base CapitalControl y la tabla dbo.usuarios.
-- OJO: si lo vuelves a ejecutar, borra las tablas y los datos guardados.
-- ============================================================================
USE CapitalControl;
GO

IF OBJECT_ID('dbo.transacciones') IS NOT NULL DROP TABLE dbo.transacciones;
IF OBJECT_ID('dbo.deudas')        IS NOT NULL DROP TABLE dbo.deudas;
IF OBJECT_ID('dbo.metas_ahorro')  IS NOT NULL DROP TABLE dbo.metas_ahorro;
IF OBJECT_ID('dbo.membresias')    IS NOT NULL DROP TABLE dbo.membresias;
IF OBJECT_ID('dbo.categorias')    IS NOT NULL DROP TABLE dbo.categorias;
GO

-- Categorías que aparecen en el formulario de transacciones (comunes a todos los usuarios)
CREATE TABLE dbo.categorias (
    id     INT IDENTITY(1,1) PRIMARY KEY,
    tipo   VARCHAR(10)  NOT NULL CHECK (tipo IN ('Ingreso','Gasto','Inversion')),
    nombre NVARCHAR(50) NOT NULL,
    CONSTRAINT uk_categorias UNIQUE (tipo, nombre)
);

-- Ingresos, gastos e inversiones del usuario
CREATE TABLE dbo.transacciones (
    id             INT IDENTITY(1,1) PRIMARY KEY,
    usuario_id     INT NOT NULL REFERENCES dbo.usuarios(id) ON DELETE CASCADE,
    tipo           VARCHAR(10)   NOT NULL CHECK (tipo IN ('Ingreso','Gasto','Inversion')),
    monto          DECIMAL(18,2) NOT NULL CHECK (monto > 0),
    categoria      NVARCHAR(50)  NOT NULL,
    descripcion    NVARCHAR(255) NOT NULL,
    fecha          DATE          NOT NULL,
    fecha_creacion DATETIME2     NOT NULL DEFAULT SYSDATETIME()
);
CREATE INDEX idx_transacciones_usuario ON dbo.transacciones (usuario_id, fecha);

-- Deudas y créditos (bancarios o personales)
CREATE TABLE dbo.deudas (
    id                INT IDENTITY(1,1) PRIMARY KEY,
    usuario_id        INT NOT NULL REFERENCES dbo.usuarios(id) ON DELETE CASCADE,
    acreedor          NVARCHAR(100) NOT NULL,
    es_banco          BIT           NOT NULL DEFAULT 1,
    total             DECIMAL(18,2) NOT NULL,
    pagado            DECIMAL(18,2) NOT NULL DEFAULT 0,
    fecha_vencimiento DATE          NOT NULL,
    tasa_interes      DECIMAL(9,4)  NOT NULL DEFAULT 0,
    fecha_creacion    DATETIME2     NOT NULL DEFAULT SYSDATETIME()
);
CREATE INDEX idx_deudas_usuario ON dbo.deudas (usuario_id);

-- Metas de ahorro
CREATE TABLE dbo.metas_ahorro (
    id             INT IDENTITY(1,1) PRIMARY KEY,
    usuario_id     INT NOT NULL REFERENCES dbo.usuarios(id) ON DELETE CASCADE,
    nombre         NVARCHAR(100) NOT NULL,
    categoria      NVARCHAR(50)  NULL,
    objetivo       DECIMAL(18,2) NOT NULL,
    actual         DECIMAL(18,2) NOT NULL DEFAULT 0,
    fecha_objetivo DATE          NOT NULL,
    color          VARCHAR(20)   NOT NULL DEFAULT 'blue',
    fecha_creacion DATETIME2     NOT NULL DEFAULT SYSDATETIME()
);
CREATE INDEX idx_metas_usuario ON dbo.metas_ahorro (usuario_id);

-- Membresías / suscripciones mensuales
CREATE TABLE dbo.membresias (
    id               INT IDENTITY(1,1) PRIMARY KEY,
    usuario_id       INT NOT NULL REFERENCES dbo.usuarios(id) ON DELETE CASCADE,
    nombre           NVARCHAR(100) NOT NULL,
    costo            DECIMAL(18,2) NOT NULL,
    dia_facturacion  INT           NOT NULL CHECK (dia_facturacion BETWEEN 1 AND 31),
    logo             NVARCHAR(20)  NULL,
    activa           BIT           NOT NULL DEFAULT 1,
    fecha_creacion   DATETIME2     NOT NULL DEFAULT SYSDATETIME()
);
CREATE INDEX idx_membresias_usuario ON dbo.membresias (usuario_id);
GO

INSERT INTO dbo.categorias (tipo, nombre) VALUES
 ('Ingreso',   N'Salario'),
 ('Ingreso',   N'Freelance'),
 ('Ingreso',   N'Ventas'),
 ('Ingreso',   N'Regalos'),
 ('Ingreso',   N'Otros'),
 ('Gasto',     N'Alimentación'),
 ('Gasto',     N'Transporte'),
 ('Gasto',     N'Vivienda'),
 ('Gasto',     N'Servicios'),
 ('Gasto',     N'Salud'),
 ('Gasto',     N'Educación'),
 ('Gasto',     N'Entretenimiento'),
 ('Gasto',     N'Ropa'),
 ('Gasto',     N'Otros'),
 ('Inversion', N'Acciones'),
 ('Inversion', N'CDT'),
 ('Inversion', N'Criptomonedas'),
 ('Inversion', N'Fondos'),
 ('Inversion', N'Otros');
GO
