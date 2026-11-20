# CapitalControl - Base de Datos

Esquema de **Microsoft SQL Server** para CapitalControl: autenticación de usuarios y datos financieros.

## Archivos

| Archivo | Descripción |
|---------|-------------|
| `capitalcontrol.sql` | Base de datos, tablas de autenticación y datos de ejemplo |
| `capitalcontrol_datos_sqlserver.sql` | Tablas financieras y catálogo de categorías |

## Requisitos

- Microsoft SQL Server 2019+ o SQL Server Express
- Autenticación de Windows (`Integrated Security=True`) o permisos equivalentes
- `sqlcmd` (incluido con SQL Server / herramientas de cliente)

## Instalación

Ejecuta los scripts **en este orden**:

```powershell
sqlcmd -S . -E -i database\capitalcontrol.sql
sqlcmd -S . -E -i database\capitalcontrol_datos_sqlserver.sql
```

Para SQL Server Express:

```powershell
sqlcmd -S .\SQLEXPRESS -E -i database\capitalcontrol.sql
sqlcmd -S .\SQLEXPRESS -E -i database\capitalcontrol_datos_sqlserver.sql
```

También puedes abrirlos en SQL Server Management Studio (SSMS) y presionar **F5**.

## Tablas incluidas

| Script | Tabla | Propósito |
|--------|-------|-----------|
| `capitalcontrol.sql` | `roles` | Roles de usuario (admin, cliente) |
| `capitalcontrol.sql` | `usuarios` | Cuentas: email único, hash BCrypt, estado, verificación, intentos fallidos y bloqueo |
| `capitalcontrol.sql` | `sesiones` | Sesiones activas / refresh tokens con expiración |
| `capitalcontrol.sql` | `tokens_reset` | Tokens para recuperación de contraseña |
| `capitalcontrol.sql` | `intentos_login` | Auditoría de cada intento de login y su motivo |
| `datos_sqlserver.sql` | `categorias` | Catálogo compartido de ingresos, gastos e inversiones |
| `datos_sqlserver.sql` | `transacciones` | Ingresos, gastos e inversiones por usuario |
| `datos_sqlserver.sql` | `deudas` | Deudas y créditos con tasa de interés |
| `datos_sqlserver.sql` | `metas_ahorro` | Metas de ahorro con progreso y color |
| `datos_sqlserver.sql` | `membresias` | Suscripciones con día de facturación y estado |

## Usuario de ejemplo

- **Email:** `demo@capitalcontrol.com`
- **Contraseña:** `CapitalControl123`
- **Hash BCrypt:** incluido en el script (`$2a$11$...`)

> En producción nunca guardes contraseñas en texto plano. El campo `password_hash` se genera con `BCrypt.Net.BCrypt.HashPassword` en la aplicación.

## Flujo de autenticación

1. **Registro:** `Conexion.RegistrarUsuario` inserta en `usuarios` con hash BCrypt, rol cliente, estado `activo` y correo verificado.
2. **Login:** `Conexion.ValidarUsuario` busca por email, verifica el hash con BCrypt, actualiza `ultimo_acceso` y escribe en `intentos_login` dentro de una transacción.
3. **Bloqueo:** al tercer intento fallido se fija `bloqueado_hasta` en 15 minutos y el estado pasa a `bloqueado`.
4. **Carga de datos:** `BaseDatos.CargarDatosUsuario()` llena `AppData` desde las tablas financieras filtrando por `usuario_id`.

## Notas

- El email es único (`uk_usuarios_email`) y cada usuario tiene un UUID público (`uk_usuarios_uuid`).
- Las relaciones usan claves foráneas con `ON DELETE CASCADE`.
- `uuid`, `fecha_creacion` y `fecha_actualizacion` tienen valores por defecto.
- Los scripts eliminan y recrean tablas: **no los ejecutes sobre datos que quieras conservar**.

## Licencia

Uso interno del proyecto CapitalControl.
