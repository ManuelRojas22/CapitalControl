# CapitalControl - Base de Datos

Esquema SQL para la parte de **registro y login de usuarios** del sistema CapitalControl.

## Archivos

| Archivo | Descripción |
|---------|-------------|
| `capitalcontrol.sql` | Script SQL con todas las tablas y datos de ejemplo |

## Requisitos

- MySQL 5.7+ o MariaDB 10.2+
- Codificación `utf8mb4`

## Instalación

Ejecuta el script en tu servidor de base de datos:

```bash
mysql -u tu_usuario -p < database/capitalcontrol.sql
```

O desde la consola de MySQL:

```sql
SOURCE database/capitalcontrol.sql;
```

Esto creará la base de datos `capitalcontrol` y todas sus tablas.

## Tablas incluidas

| Tabla | Propósito |
|-------|-----------|
| `roles` | Roles de usuario (admin, cliente, etc.) |
| `usuarios` | Cuentas de usuario, email único, hash de contraseña, estado, verificación de email, intentos fallidos y bloqueo por fuerza bruta |
| `sesiones` | Sesiones activas / refresh tokens con fecha de expiración |
| `tokens_reset` | Tokens para recuperación/restablecimiento de contraseña |
| `intentos_login` | Auditoría de cada intento de login (exitoso o fallido) |

## Usuario de ejemplo

El script inserta un usuario de prueba:

- **Email:** `demo@capitalcontrol.com`
- **Contraseña:** `CapitalControl123` (el hash ya está incluido en el script)

> **Importante:** En producción nunca guardes contraseñas en texto plano. El campo `password_hash` debe almacenar el hash generado por tu aplicación (bcrypt, argon2, etc.).

## Flujo recomendado

1. **Registro:** Insertar en `usuarios` con el hash de la contraseña generado en el backend.
2. **Login:** Consultar el usuario por email en `usuarios`, verificar el hash de la contraseña en el backend y, si es correcto, crear una sesión en `sesiones`.
3. **Recuperación de contraseña:** Generar un token en `tokens_reset`, enviarlo por email y permitir el restablecimiento validando que no esté usado ni expirado.
4. **Seguridad:** Registrar intentos en `intentos_login` y bloquear la cuenta temporalmente tras varios fallos usando el campo `bloqueado_hasta` en `usuarios`.

## Notas

- El email es único (`uk_usuarios_email`).
- Cada usuario tiene un UUID público (`uk_usuarios_uuid`).
- Las relaciones usan claves foráneas con `ON DELETE CASCADE` y `ON UPDATE CASCADE`.
- No incluye procedimientos almacenados, solo tablas y datos de ejemplo.

## Licencia

Uso interno del proyecto CapitalControl.
