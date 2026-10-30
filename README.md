# CapitalControl

Sistema de control de capital con módulos de registro y login de usuarios.

## Estructura del proyecto

```
CapitalControl/
├── README.md                 # Documentación general (este archivo)
├── database/
│   ├── capitalcontrol.sql    # Esquema SQL de registro y login
│   └── README.md             # Documentación de la base de datos
├── src/                      # Código fuente de la aplicación
├── public/                   # Archivos estáticos (HTML, CSS, JS)
└── ...
```

## Base de datos

El esquema de base de datos se encuentra en `database/capitalcontrol.sql` e incluye:

- `roles` — roles de usuario
- `usuarios` — cuentas de usuario, email único, hash de contraseña, estado, verificación de email
- `sesiones` — sesiones activas / refresh tokens con expiración
- `tokens_reset` — recuperación de contraseña
- `intentos_login` — auditoría de intentos de login

Para instalar la base de datos:

```bash
mysql -u tu_usuario -p < database/capitalcontrol.sql
```

## Inicio rápido

1. Clona o descarga el proyecto.
2. Importa el esquema SQL en tu servidor MySQL/MariaDB.
3. Configura la conexión a la base de datos en tu backend.
4. Inicia la aplicación.

## Tecnologías sugeridas

- Base de datos: MySQL 5.7+ o MariaDB 10.2+
- Backend: Node.js, Python, PHP, Java, etc.
- Hash de contraseñas: bcrypt o argon2 (nunca texto plano)

## Licencia

Uso interno del proyecto CapitalControl.
