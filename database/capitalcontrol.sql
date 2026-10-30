-- ============================================================================
-- CapitalControl - Esquema SQL para Registro y Login de Usuarios
-- Motor recomendado: MySQL 5.7+ / MariaDB 10.2+
-- Codificación: utf8mb4
-- Solo tablas (sin procedimientos almacenados)
-- ============================================================================

-- 1. Crear base de datos
CREATE DATABASE IF NOT EXISTS capitalcontrol
  CHARACTER SET utf8mb4
  COLLATE utf8mb4_unicode_ci;

USE capitalcontrol;

-- Desactivar chequeos de llaves foráneas temporalmente (útil para reejecutar)
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------------------------------------------------------
-- TABLA: roles
-- ----------------------------------------------------------------------------
DROP TABLE IF EXISTS roles;
CREATE TABLE roles (
    id          INT UNSIGNED NOT NULL AUTO_INCREMENT,
    nombre      VARCHAR(50)  NOT NULL COMMENT 'admin, cliente, vendedor, etc.',
    descripcion VARCHAR(255) DEFAULT NULL,
    fecha_creacion TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    PRIMARY KEY (id),
    UNIQUE KEY uk_roles_nombre (nombre)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- ----------------------------------------------------------------------------
-- TABLA: usuarios
-- ----------------------------------------------------------------------------
DROP TABLE IF EXISTS usuarios;
CREATE TABLE usuarios (
    id                  INT UNSIGNED NOT NULL AUTO_INCREMENT,
    uuid                CHAR(36)     NOT NULL COMMENT 'Identificador público único (UUID)',
    nombres             VARCHAR(100) NOT NULL,
    apellidos           VARCHAR(100) NOT NULL,
    email               VARCHAR(255) NOT NULL COMMENT 'Correo electrónico, usado para login',
    password_hash       VARCHAR(255) NOT NULL COMMENT 'Hash de la contraseña (bcrypt/argon2)',
    telefono            VARCHAR(30)  DEFAULT NULL,
    fecha_nacimiento    DATE         DEFAULT NULL,
    genero              ENUM('M','F','Otro','No especificado') DEFAULT 'No especificado',
    rol_id              INT UNSIGNED NOT NULL DEFAULT 2 COMMENT 'FK a roles (2 = cliente por defecto)',
    estado              ENUM('activo','inactivo','bloqueado','pendiente_verificacion') NOT NULL DEFAULT 'pendiente_verificacion',
    email_verificado    TINYINT(1)   NOT NULL DEFAULT 0,
    fecha_verificacion_email DATETIME DEFAULT NULL,
    token_verificacion_email VARCHAR(255) DEFAULT NULL COMMENT 'Token para verificar el correo',
    ultimo_acceso       DATETIME     DEFAULT NULL,
    intentos_fallidos   INT UNSIGNED NOT NULL DEFAULT 0,
    bloqueado_hasta     DATETIME     DEFAULT NULL COMMENT 'Hasta cuándo está bloqueado por fuerza bruta',
    fecha_creacion      TIMESTAMP    NOT NULL DEFAULT CURRENT_TIMESTAMP,
    fecha_actualizacion TIMESTAMP    NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
    PRIMARY KEY (id),
    UNIQUE KEY uk_usuarios_uuid (uuid),
    UNIQUE KEY uk_usuarios_email (email),
    KEY idx_usuarios_rol (rol_id),
    KEY idx_usuarios_estado (estado),
    CONSTRAINT fk_usuarios_rol FOREIGN KEY (rol_id) REFERENCES roles (id) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- ----------------------------------------------------------------------------
-- TABLA: sesiones (refresh tokens / sesiones activas)
-- ----------------------------------------------------------------------------
DROP TABLE IF EXISTS sesiones;
CREATE TABLE sesiones (
    id             INT UNSIGNED NOT NULL AUTO_INCREMENT,
    usuario_id     INT UNSIGNED NOT NULL,
    token          VARCHAR(512) NOT NULL COMMENT 'Refresh token o JWT de sesión',
    dispositivo    VARCHAR(255) DEFAULT NULL,
    ip             VARCHAR(45)  DEFAULT NULL COMMENT 'IPv4 o IPv6',
    user_agent     TEXT         DEFAULT NULL,
    fecha_creacion TIMESTAMP    NOT NULL DEFAULT CURRENT_TIMESTAMP,
    fecha_expiracion DATETIME   NOT NULL COMMENT 'Cuando expira la sesión',
    activo         TINYINT(1)   NOT NULL DEFAULT 1,
    PRIMARY KEY (id),
    UNIQUE KEY uk_sesiones_token (token(255)),
    KEY idx_sesiones_usuario (usuario_id),
    KEY idx_sesiones_expiracion (fecha_expiracion),
    CONSTRAINT fk_sesiones_usuario FOREIGN KEY (usuario_id) REFERENCES usuarios (id) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- ----------------------------------------------------------------------------
-- TABLA: tokens_reset (recuperación de contraseña / restablecimiento)
-- ----------------------------------------------------------------------------
DROP TABLE IF EXISTS tokens_reset;
CREATE TABLE tokens_reset (
    id             INT UNSIGNED NOT NULL AUTO_INCREMENT,
    usuario_id     INT UNSIGNED NOT NULL,
    token          VARCHAR(255) NOT NULL,
    usado          TINYINT(1)   NOT NULL DEFAULT 0,
    fecha_creacion TIMESTAMP    NOT NULL DEFAULT CURRENT_TIMESTAMP,
    fecha_expiracion DATETIME   NOT NULL,
    ip_solicitud   VARCHAR(45)  DEFAULT NULL,
    PRIMARY KEY (id),
    UNIQUE KEY uk_tokens_reset_token (token),
    KEY idx_tokens_reset_usuario (usuario_id),
    KEY idx_tokens_reset_expiracion (fecha_expiracion),
    CONSTRAINT fk_tokens_reset_usuario FOREIGN KEY (usuario_id) REFERENCES usuarios (id) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- ----------------------------------------------------------------------------
-- TABLA: intentos_login (auditoría y protección contra fuerza bruta)
-- ----------------------------------------------------------------------------
DROP TABLE IF EXISTS intentos_login;
CREATE TABLE intentos_login (
    id           INT UNSIGNED NOT NULL AUTO_INCREMENT,
    email        VARCHAR(255) NOT NULL,
    ip           VARCHAR(45)  DEFAULT NULL,
    exitoso      TINYINT(1)   NOT NULL DEFAULT 0,
    fecha        TIMESTAMP    NOT NULL DEFAULT CURRENT_TIMESTAMP,
    razon        VARCHAR(255) DEFAULT NULL COMMENT 'contraseña_incorrecta, usuario_inexistente, bloqueado, etc.',
    PRIMARY KEY (id),
    KEY idx_intentos_email (email),
    KEY idx_intentos_fecha (fecha)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Reactivar chequeos de llaves foráneas
SET FOREIGN_KEY_CHECKS = 1;

-- ----------------------------------------------------------------------------
-- DATOS DE EJEMPLO
-- ----------------------------------------------------------------------------
INSERT INTO roles (id, nombre, descripcion) VALUES
(1, 'admin', 'Administrador del sistema'),
(2, 'cliente', 'Usuario cliente estándar');

-- Usuario de ejemplo (contraseña en texto plano: CapitalControl123)
-- NOTA: En producción el hash se genera con bcrypt o argon2 en la aplicación,
-- nunca se guarda la contraseña en texto plano.
INSERT INTO usuarios (
    uuid, nombres, apellidos, email, password_hash, rol_id, estado, email_verificado
) VALUES (
    UUID(),
    'Usuario',
    'Demo',
    'demo@capitalcontrol.com',
    '$2y$10$92IXUNpkjO0rOQ5byMi.Ye4oKoEa3Ro9llC/.og/at2.uheWG/igi', -- bcrypt de "password"
    2,
    'activo',
    1
);

-- ============================================================================
-- FIN DEL SCRIPT
-- ============================================================================
