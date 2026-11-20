# CapitalControl

Aplicación de escritorio para Windows que te ayuda a controlar tus finanzas personales: transacciones, deudas y créditos, metas de ahorro y membresías, todo en un solo panel.

![.NET 8](https://img.shields.io/badge/.NET-8.0-512BD4?logo=dotnet)
![C#](https://img.shields.io/badge/lenguaje-C%23-239120?logo=csharp)
![Windows Forms](https://img.shields.io/badge/UI-Windows%20Forms-0078D4)
![SQL Server](https://img.shields.io/badge/DB-SQL%20Server-CC2927?logo=microsoftsqlserver)
![Estado](https://img.shields.io/badge/estado-en%20desarrollo-yellow)

## Tabla de contenidos

- [Características](#características)
- [Módulos](#módulos)
- [Tecnologías](#tecnologías)
- [Requisitos](#requisitos)
- [Instalación](#instalación)
- [Configuración](#configuración)
- [Uso](#uso)
- [Arquitectura](#arquitectura)
- [Estructura del proyecto](#estructura-del-proyecto)
- [Base de datos](#base-de-datos)
- [Seguridad](#seguridad)
- [Solución de problemas](#solución-de-problemas)
- [Preguntas frecuentes](#preguntas-frecuentes)
- [Hoja de ruta](#hoja-de-ruta)
- [Contribuir](#contribuir)
- [Licencia](#licencia)

## Características

- Registro e inicio de sesión de usuarios con contraseñas hasheadas con BCrypt.
- Bloqueo temporal y auditoría de intentos fallidos de inicio de sesión.
- Dashboard con el resumen de tu situación financiera.
- Registro de ingresos, gastos e inversiones.
- Gestión de deudas y créditos: crear, editar y pagar.
- Metas de ahorro con aportes progresivos.
- Control de membresías y suscripciones.
- Historial completo de movimientos.
- Datos persistentes en SQL Server.

## Módulos

| Módulo | Formularios | Qué permite hacer |
|--------|-------------|-------------------|
| Autenticación | `LoginForm`, `RegisterForm`, `AccesoForm` | Crear una cuenta e iniciar sesión |
| Menú | `MenuPForm` | Acceder a todos los módulos desde un único lugar |
| Panel principal | `MainForm`, `DashboardForm` | Navegar por la app y ver el resumen financiero |
| Transacciones | `TransactionForm` | Registrar ingresos, gastos e inversiones |
| Deudas y créditos | `DebtsCreditsForm`, `DebtEditForm`, `PayDebtForm` | Listar, editar y pagar deudas |
| Metas de ahorro | `SavingsGoalsForm`, `GoalEditForm`, `ContributeGoalForm` | Crear metas y aportar a ellas |
| Membresías | `MembershipsForm`, `MembershipEditForm` | Administrar suscripciones |
| Historial | `HistoryForm` | Consultar movimientos pasados |
| Usuarios | `UsuariosForm` | Crear, editar, cambiar rol/estado y eliminar usuarios |

## Tecnologías

| Área | Tecnología |
|------|------------|
| Lenguaje | C# |
| Framework | .NET 8 (`net8.0-windows`) |
| Interfaz | Windows Forms |
| Base de datos | Microsoft SQL Server (Express, 2019 o superior) |
| Proveedor ADO.NET | `Microsoft.Data.SqlClient` 7.1.1 |
| Hash de contraseñas | `BCrypt.Net-Next` 4.2.0 |
| IDE recomendado | Visual Studio 2022 |

## Requisitos

- Windows 10 u 11
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- Visual Studio 2022 (17.8 o superior) con la carga de trabajo **Desarrollo de escritorio de .NET**
- SQL Server 2019+ / SQL Server Express (instancia local `.` o `.\SQLEXPRESS`)
- Git

## Instalación

1. Clona el repositorio:

   ```bash
   git clone https://github.com/ManuelRojas22/CapitalControl.git
   cd CapitalControl
   ```

2. Crea la base de datos y las tablas ejecutando los dos scripts en orden:

   ```powershell
   sqlcmd -S . -E -i database\capitalcontrol.sql
   sqlcmd -S . -E -i database\capitalcontrol_datos_sqlserver.sql
   ```

   Si usas SQL Server Express, cambia `-S .` por `-S .\SQLEXPRESS`.

3. Configura la conexión (ver [Configuración](#configuración)).

4. Restaura dependencias, compila y ejecuta:

   ```bash
   dotnet restore
   dotnet build
   dotnet run
   ```

   También puedes abrir el proyecto en Visual Studio y presionar **F5**.

## Configuración

La conexión se define en `Conexion.cs` (`Conexion.CadenaConexion`):

| Parámetro | Valor por defecto |
|-----------|-------------------|
| Servidor | `.` (instancia local; usar `.\SQLEXPRESS` si aplica) |
| Base de datos | `CapitalControl` |
| Autenticación | `Integrated Security=True` (Windows Auth) |
| Certificado | `TrustServerCertificate=True` |

> **Recomendación:** no subas credenciales reales al repositorio. Si cambias a autenticación de SQL Server, usa variables de entorno o un archivo local excluido con `.gitignore`.

## Uso

1. Abre la aplicación. En la portada puedes entrar por **Iniciar sesión** o por **Área admin** (flujo `AccesoForm` → `MenuPForm`).
2. Inicia sesión con `demo@capitalcontrol.com` / `CapitalControl123`, o crea una cuenta desde **Registro**.
3. Desde el **Menú** o el **Dashboard** revisa tu resumen financiero.
4. Registra tus ingresos y gastos en **Transacciones**.
5. Agrega tus deudas en **Deudas y créditos** y regístralas como pagadas cuando corresponda.
6. Crea **Metas de ahorro** y aporta a ellas con el tiempo.
7. Registra tus **Membresías** para no olvidar pagos recurrentes.
8. Consulta el **Historial** para ver todos tus movimientos.
9. En **Usuarios** puedes crear cuentas, asignar roles y cambiar estados.

## Arquitectura

```
┌──────────────────────┐
│  Formularios (UI)    │  *.cs / *.Designer.cs / Controls/
└──────────┬───────────┘
           │  eventos NavigateRequested ("login", "app", "menu", ...)
┌──────────▼───────────┐
│  Services            │  Lógica de negocio y acceso a datos
└──────────┬───────────┘
           │
┌──────────▼───────────┐     ┌──────────────────────┐
│  Models              │◄───►│  SQL Server (dbo.*)  │
│  Entidades           │     │  Conexion / BaseDatos│
└──────────────────────┘     └──────────────────────┘
```

`Program.cs` centraliza la navegación: todos los formularios exponen `NavigateRequested` y ese controlador oculta/muestra la vista destino.

## Estructura del proyecto

```
CapitalControl/
├── database/                       # Scripts SQL Server
│   ├── capitalcontrol.sql          #roles, usuarios, sesiones, tokens e intentos
│   └── capitalcontrol_datos_sqlserver.sql  #categorías y datos financieros
├── Models/                         # Entidades del dominio
├── Services/                       # Lógica de negocio y acceso a datos
│   ├── AppData.cs
│   └── BaseDatos.cs
├── Controls/                       # Controles personalizados de la interfaz
├── Conexion.cs                     # Conexión, registro, login y auditoría
├── Complementos.cs                 # Utilidades y helpers
├── Fmt.cs                          # Formato de montos y fechas
├── Program.cs                      # Punto de entrada y navegación
├── MainForm.cs                     # Portada / landing
├── LoginForm.cs                    # Inicio de sesión
├── RegisterForm.cs                 # Registro
├── AccesoForm.cs                   # Acceso alternativo
├── MenuPForm.cs                    # Menú
├── UsuariosForm.cs                 # ABM de usuarios
├── DashboardForm.cs                # Resumen financiero
├── TransactionForm.cs              # Ingresos, gastos e inversiones
├── DebtsCreditsForm.cs             # Deudas y créditos
├── SavingsGoalsForm.cs             # Metas de ahorro
├── MembershipsForm.cs              # Membresías
├── HistoryForm.cs                  # Historial
└── CapitalControl.csproj
```

## Base de datos

| Script | Tablas |
|--------|--------|
| `database/capitalcontrol.sql` | `roles`, `usuarios`, `sesiones`, `tokens_reset`, `intentos_login` |
| `database/capitalcontrol_datos_sqlserver.sql` | `categorias`, `transacciones`, `deudas`, `metas_ahorro`, `membresias` |

Usuario de ejemplo: `demo@capitalcontrol.com` / `CapitalControl123` (el hash BCrypt ya está en el script).

Para reinstalar desde cero, vuelve a ejecutar los dos scripts; el primero elimina las tablas de autenticación y el segundo elimina las tablas financieras.

> Esto elimina todos los datos existentes.

## Seguridad

- Las contraseñas se almacenan como hash BCrypt, nunca en texto plano.
- Todas las consultas usan parámetros (`@email`, `@hash`, etc.), evitando inyección SQL.
- El correo es único (`uk_usuarios_email`).
- Cada fallo de login se registra en `intentos_login` con motivo (`usuario_inexistente`, `contrasena_incorrecta`, `bloqueado`).
- Después de 3 intentos fallidos, la cuenta queda bloqueada 15 minutos (`intentos_fallidos`, `bloqueado_hasta`).
- Los inicios de sesión correctos actualizan `ultimo_acceso` y reinician el contador.
- Las sesiones y los tokens de recuperación tienen fecha de expiración.
- No subas credenciales ni cadenas de conexión reales al repositorio.

## Solución de problemas

| Problema | Posible causa | Solución |
|----------|---------------|----------|
| No conecta a la base de datos | Servicio detenido o instancia distinta | Verifica SQL Server en `services.msc` y ajusta `Data Source` en `Conexion.cs` |
| `Login failed for user` | Autenticación de Windows sin permisos | Crea el usuario en SQL Server o usa `Integrated Security=True` |
| `Cannot open database "CapitalControl"` | No se ejecutaron los scripts | Ejecuta los dos scripts de `database/` con `sqlcmd` |
| Error de compilación por el SDK | Falta .NET 8 | Instala el SDK y revisa con `dotnet --version` |
| El diseñador de formularios no abre | Falta la carga de trabajo de escritorio | Instálala desde el instalador de Visual Studio |
| La cuenta se bloquea al probar | 3 intentos fallidos acumulados | Espera 15 min o limpia `intentos_fallidos`/`bloqueado_hasta` en SQL Server |

## Preguntas frecuentes

**¿Funciona en Linux o macOS?**
No. Usa Windows Forms (`net8.0-windows`), así que requiere Windows.

**¿Mis datos se envían a internet?**
No. Todo se guarda en la base de datos local que tú configuras.

**¿Puedo usar otro motor de base de datos?**
Es posible, pero tendrías que adaptar `Conexion.cs`, `BaseDatos.cs`, el proveedor NuGet y los scripts SQL.

**¿Qué diferencia hay entre `LoginForm` y `AccesoForm`?**
Ambos validan con el mismo servicio (`Conexion.ValidarUsuario`). `LoginForm` es la vista de la portada; `AccesoForm` es el flujo heredado que después abre `MenuPForm`.

## Hoja de ruta

- [x] Unificar el esquema a SQL Server
- [x] Parametrizar el acceso a datos y auditar intentos de login
- [x] Integrar los formularios de acceso, menú y usuarios
- [ ] Mover la cadena de conexión fuera del código
- [ ] Reportes y gráficos por período
- [ ] Exportar datos a CSV / Excel
- [ ] Recordatorios de pagos y vencimientos
- [ ] Categorías y presupuestos mensuales
- [ ] Recuperación de contraseña desde la interfaz
- [ ] Pruebas unitarias para `Services`
- [ ] Instalador para Windows

## Contribuir

1. Haz un fork del repositorio.
2. Crea una rama: `git checkout -b feature/mi-mejora`
3. Haz commit de tus cambios: `git commit -m "feat: descripción del cambio"`
4. Sube la rama: `git push origin feature/mi-mejora`
5. Abre un Pull Request.

Para cambios grandes, abre primero un issue para discutirlos. Se sugiere usar el formato de commits `feat:`, `fix:`, `docs:`, `refactor:`.

## Licencia

Uso interno del proyecto CapitalControl.
