# CapitalControl

Aplicación de escritorio para Windows que te ayuda a controlar tus finanzas personales: transacciones, deudas y créditos, metas de ahorro y membresías, todo en un solo panel.

![.NET 8](https://img.shields.io/badge/.NET-8.0-512BD4?logo=dotnet)
![C#](https://img.shields.io/badge/lenguaje-C%23-239120?logo=csharp)
![Windows Forms](https://img.shields.io/badge/UI-Windows%20Forms-0078D4)
![Plataforma](https://img.shields.io/badge/plataforma-Windows-lightgrey)
![Estado](https://img.shields.io/badge/estado-en%20desarrollo-yellow)

<!-- TODO: agrega capturas en docs/screenshots/ -->
<!-- ![Dashboard](docs/screenshots/dashboard.png) -->

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

- Registro e inicio de sesión de usuarios.
- Dashboard con el resumen de tu situación financiera.
- Registro de ingresos y gastos.
- Gestión de deudas y créditos: crear, editar y pagar.
- Metas de ahorro con aportes progresivos.
- Control de membresías y suscripciones.
- Historial completo de movimientos.
- Datos persistentes en base de datos SQL.

## Módulos

| Módulo | Formularios | Qué permite hacer |
|--------|-------------|-------------------|
| Autenticación | `LoginForm`, `RegisterForm` | Crear una cuenta e iniciar sesión |
| Panel principal | `MainForm`, `DashboardForm` | Navegar por la app y ver el resumen financiero |
| Transacciones | `TransactionForm` | Registrar ingresos y gastos |
| Deudas y créditos | `DebtsCreditsForm`, `DebtEditForm`, `PayDebtForm` | Listar, editar y pagar deudas |
| Metas de ahorro | `SavingsGoalsForm`, `GoalEditForm`, `ContributeGoalForm` | Crear metas y aportar a ellas |
| Membresías | `MembershipsForm`, `MembershipEditForm` | Administrar suscripciones |
| Historial | `HistoryForm` | Consultar movimientos pasados |

## Tecnologías

| Área | Tecnología |
|------|------------|
| Lenguaje | C# |
| Framework | .NET 8 (`net8.0-windows`) |
| Interfaz | Windows Forms |
| Base de datos | MySQL / MariaDB <!-- TODO: confirma el motor en Conexion.cs --> |
| IDE recomendado | Visual Studio 2022 |

## Requisitos

- Windows 10 u 11
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- Visual Studio 2022 (17.8 o superior) con la carga de trabajo **Desarrollo de escritorio de .NET**
- MySQL 5.7+ o MariaDB 10.2+
- Git

## Instalación

1. Clona el repositorio:

   ```bash
   git clone https://github.com/ManuelRojas22/CapitalControl.git
   cd CapitalControl
   ```

2. Crea la base de datos importando el esquema:

   ```bash
   mysql -u tu_usuario -p < database/capitalcontrol.sql
   ```

3. Configura la conexión (ver [Configuración](#configuración)).

4. Restaura dependencias, compila y ejecuta:

   ```bash
   dotnet restore
   dotnet build
   dotnet run
   ```

   También puedes abrir `CapitalControl.slnx` en Visual Studio y presionar **F5**.

## Configuración

La conexión a la base de datos se define en `Conexion.cs`. Ajusta estos valores:

| Parámetro | Ejemplo |
|-----------|---------|
| Servidor | `localhost` |
| Puerto | `3306` |
| Base de datos | `capitalcontrol` |
| Usuario | `tu_usuario` |
| Contraseña | `tu_contraseña` |

> **Recomendación:** no subas credenciales reales al repositorio. Usa variables de entorno o un archivo de configuración local excluido con `.gitignore`.

## Uso

1. Abre la aplicación y crea una cuenta desde **Registro**.
2. Inicia sesión con tu correo y contraseña.
3. Desde el **Dashboard** revisa tu resumen financiero.
4. Registra tus ingresos y gastos en **Transacciones**.
5. Agrega tus deudas en **Deudas y créditos** y regístralas como pagadas cuando corresponda.
6. Crea **Metas de ahorro** y aporta a ellas con el tiempo.
7. Registra tus **Membresías** para no olvidar pagos recurrentes.
8. Consulta el **Historial** para ver todos tus movimientos.

## Arquitectura

El proyecto separa la interfaz, la lógica y los datos:

```
┌──────────────────────┐
│  Formularios (UI)    │  *.cs / *.Designer.cs / Controls/
└──────────┬───────────┘
           │
┌──────────▼───────────┐
│  Services            │  Lógica de negocio y acceso a datos
└──────────┬───────────┘
           │
┌──────────▼───────────┐     ┌──────────────────┐
│  Models              │     │  Base de datos   │
│  Entidades           │◄───►│  (Conexion.cs)   │
└──────────────────────┘     └──────────────────┘
```

## Estructura del proyecto

```
CapitalControl/
├── database/              # Esquema SQL
├── Models/                # Entidades del dominio
├── Services/              # Lógica de negocio y acceso a datos
├── Controls/              # Controles personalizados de la interfaz
├── Conexion.cs            # Conexión a la base de datos
├── Complementos.cs        # Utilidades y helpers
├── Fmt.cs                 # Formato de montos y fechas
├── Program.cs             # Punto de entrada
├── App.xaml.cs
├── LoginForm.cs           # Inicio de sesión
├── RegisterForm.cs        # Registro
├── MainForm.cs            # Ventana principal
├── DashboardForm.cs       # Resumen financiero
├── TransactionForm.cs     # Ingresos y gastos
├── DebtsCreditsForm.cs    # Deudas y créditos
├── DebtEditForm.cs
├── PayDebtForm.cs
├── SavingsGoalsForm.cs    # Metas de ahorro
├── GoalEditForm.cs
├── ContributeGoalForm.cs
├── MembershipsForm.cs     # Membresías
├── MembershipEditForm.cs
├── HistoryForm.cs         # Historial
└── CapitalControl.csproj
```

## Base de datos

El esquema está en [`database/capitalcontrol.sql`](database/capitalcontrol.sql). Las tablas de autenticación son:

| Tabla | Propósito |
|-------|-----------|
| `roles` | Roles de usuario |
| `usuarios` | Cuentas: email único, hash de contraseña, estado y verificación de email |
| `sesiones` | Sesiones activas / refresh tokens con expiración |
| `tokens_reset` | Recuperación de contraseña |
| `intentos_login` | Auditoría de intentos de inicio de sesión |

<!-- TODO: documenta aquí las tablas de transacciones, deudas, metas y membresías, y agrega un diagrama ER en docs/ -->

Para reinstalar desde cero:

```bash
mysql -u tu_usuario -p -e "DROP DATABASE IF EXISTS capitalcontrol;"
mysql -u tu_usuario -p < database/capitalcontrol.sql
```

> Esto elimina todos los datos existentes.

## Seguridad

- Las contraseñas se almacenan como hash (bcrypt o argon2), nunca en texto plano.
- El correo de cada usuario es único.
- Los intentos de inicio de sesión quedan registrados para auditoría.
- Las sesiones y los tokens de recuperación tienen fecha de expiración.
- Usa consultas parametrizadas en todo acceso a datos para evitar inyección SQL.
- No subas credenciales ni cadenas de conexión reales al repositorio.

## Solución de problemas

| Problema | Posible causa | Solución |
|----------|---------------|----------|
| No conecta a la base de datos | Servidor apagado o credenciales incorrectas | Verifica que MySQL/MariaDB esté activo y revisa `Conexion.cs` |
| `Unknown database 'capitalcontrol'` | No se importó el esquema | Ejecuta `mysql -u tu_usuario -p < database/capitalcontrol.sql` |
| Error al compilar por el SDK | Falta .NET 8 | Instala el [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) y revisa con `dotnet --version` |
| El diseñador de formularios no abre | Falta la carga de trabajo de escritorio | Instálala desde el instalador de Visual Studio |
| `Access denied for user` | Usuario sin permisos | Concede permisos sobre la base de datos al usuario configurado |

## Preguntas frecuentes

**¿Funciona en Linux o macOS?**
No. Usa Windows Forms (`net8.0-windows`), así que requiere Windows.

**¿Mis datos se envían a internet?**
No. Todo se guarda en la base de datos que tú configuras.

**¿Puedo usar otro motor de base de datos?**
Es posible, pero tendrías que adaptar `Conexion.cs`, el proveedor de datos y el esquema SQL.

## Hoja de ruta

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

Uso interno del proyecto CapitalControl. <!-- TODO: añade una licencia (MIT, etc.) si el repositorio es público -->
