# Parcial N. 3 — Herencia, Serialización JSON y Login con MySQL en C#

📅 Fecha: 09/11/2026  
📚 Asignatura: Herramientas de Programacion Aplicadas III  
🏫 Facultad de Ingeniería en Sistemas — Campus Víctor Levis Sasso  
👩‍🏫 Instructor: Ing. Irina Fong  
👥 Grupo: 1IL133 — II Semestre 2026

## 📋 Contenido del Repositorio

Este repositorio contiene la solución del **Parcial N. 3**, desarrollada en **C# con .NET 9**, orientada a la aplicación de conceptos de programación orientada a objetos, serialización de datos y acceso a bases de datos.

El parcial está compuesto por tres ejercicios:

1. **Figuras geométricas:** programa de consola que utiliza una clase abstracta y herencia para calcular el área y el perímetro de distintas figuras.
2. **Serialización JSON:** programa de consola que convierte un objeto anónimo en una cadena JSON utilizando Newtonsoft.Json.
3. **Portal de Login con MySQL y Windows Forms:** aplicación gráfica que permite registrar usuarios y autenticarlos, almacenando las contraseñas cifradas con BCrypt y llevando un historial de los intentos de inicio de sesión.

También se incluyen los scripts SQL necesarios para crear y respaldar la base de datos utilizada por el tercer ejercicio.

## 📝 Criterios de Evaluación

Según el enunciado del parcial, cada ejercicio se evalúa con los siguientes criterios:

### Ejercicio 1 — Figuras geométricas (15 pts)

| Criterio | Puntos | Dónde se cumple |
|---|---|---|
| Clase abstracta que actúa como molde obligatorio | 3 | `Figura.cs` |
| Métodos abstractos desarrollados en las clases hijas | 2 | `Rectangulo.cs`, `Cuadrado.cs`, `Triangulo.cs` |
| Arreglo unidimensional de tipo padre (`Figura[]`) | 5 | `Program.cs` |
| Recorrido polimórfico mostrando clase, área y perímetro | 5 | `Program.cs` |

### Ejercicio 2 — Ejecutar el script de JSON (15 pts)

| Criterio | Puntos | Dónde se cumple |
|---|---|---|
| Instalar `Newtonsoft.Json`, crear el objeto y mostrar el JSON en consola | 15 | `Ejercicio2/Program.cs` |

### Ejercicio 3 — Actividad adicional: login con BCrypt (20 pts)

| Criterio | Puntos | Dónde se cumple |
|---|---|---|
| Programa con login que utiliza BCrypt (BCrypt.Net-Next) para generar el hash | 5 | `Utiles.Registrar()` |
| Generar y guardar el hash de la clave en la base de datos | 5 | Tabla `Usuarios`, columna `PasswordHash` |
| Verificar la contraseña original con `BCrypt.Verify()` | 5 | `Utiles.Login()` |
| Indicar el nombre del usuario al tener un acceso exitoso | 5 | `Form1.btnLogin_Click()` |

Además, el enunciado pide una tabla separada que registre los intentos fallidos y exitosos, con el usuario y la fecha, para un posible análisis posterior (`IntentosLogin`), y subir todo a un repositorio incluyendo el backup de la base de datos (`backup.sql`).

**Total del parcial:** 50 pts

## 🛠 Tecnologías Utilizadas

- **Lenguaje:** C#
- **Framework:** .NET 9
- **Interfaz gráfica:** Windows Forms
- **Base de datos:** MySQL
- **Conector:** MySql.Data 26.10.0
- **Cifrado de contraseñas:** BCrypt.Net-Next 4.2.0
- **Serialización:** Newtonsoft.Json 13.0.4
- **IDE recomendado:** Visual Studio
- **Control de versiones:** Git
- **Conceptos aplicados:**
  - Programación orientada a objetos
  - Clases abstractas
  - Herencia y polimorfismo
  - Constructores primarios
  - Sobrescritura de métodos
  - Serialización de objetos a JSON
  - Interfaces
  - Validación de datos
  - Manejo de excepciones
  - Acceso a bases de datos
  - Parámetros en consultas SQL
  - Hash de contraseñas
  - Windows Forms
  - `DataGridView` y `DataTable`

## 💻 Ejercicios y Funcionalidades

### 1. Figuras Geométricas (Herencia y Polimorfismo)

Ubicación:

```text
Ejercicio1/
```

Este ejercicio implementa una jerarquía de clases para representar figuras geométricas.

La clase abstracta:

```csharp
Figura
```

define los dos métodos que cada figura debe implementar:

```csharp
public abstract double CalcularArea();
public abstract double CalcularPerimetro();
```

A partir de ella se crean tres clases derivadas, todas con constructor primario:

| Clase | Parámetros | Área | Perímetro |
|---|---|---|---|
| `Triangulo` | `ladoA`, `ladoB`, `ladoC` | Fórmula de Herón | `LadoA + LadoB + LadoC` |
| `Cuadrado` | `lado` | `Lado * Lado` | `4 * Lado` |
| `Rectangulo` | `ancho`, `largo` | `Ancho * Largo` | `2 * (Ancho + Largo)` |

En el cálculo del área del triángulo se utiliza la **fórmula de Herón**:

```csharp
double s = (LadoA + LadoB + LadoC) / 2;
return Math.Sqrt(s * (s - LadoA) * (s - LadoB) * (s - LadoC));
```

El programa principal crea cuatro figuras, las almacena en un arreglo de tipo `Figura[]` y las recorre con un ciclo `for`, mostrando para cada una su tipo, su área y su perímetro. Esto demuestra el **polimorfismo**, ya que se invoca el mismo método sobre objetos de distintas clases y cada uno responde según su propia implementación.

Las figuras utilizadas en la prueba son:

- `Triangulo(12, 10.2, 5.8)`
- `Cuadrado(2)`
- `Cuadrado(7.98)`
- `Rectangulo(10, 2)`

### 2. Serialización JSON con Newtonsoft.Json

Ubicación:

```text
Ejercicio2/
```

Este ejercicio utiliza la biblioteca **Newtonsoft.Json** para convertir un objeto en texto con formato JSON.

Se crea un **objeto anónimo** con la información de una persona:

```csharp
var persona = new
{
    Nombre = "Cristell",
    Edad = 20,
    Carrera = "Ingenieria en Sistemas"
};
```

Luego se serializa mediante:

```csharp
string json = JsonConvert.SerializeObject(persona);
```

y se muestra el resultado en la consola.

La dependencia se agrega al proyecto mediante el paquete NuGet `Newtonsoft.Json` versión `13.0.4`.

### 3. Portal de Login con MySQL y Windows Forms

Ubicación:

```text
Ejercicio3/
```

Este proyecto es una aplicación de escritorio desarrollada con **Windows Forms** que permite registrar usuarios e iniciar sesión, guardando un historial de todos los intentos de acceso.

La interfaz contiene:

- Un encabezado con el título **PORTAL**.
- Un campo de usuario y un campo de contraseña (con caracteres ocultos).
- Un botón **Registrar** y un botón **Iniciar sesión**.
- Una etiqueta que muestra el resultado de la operación (en verde si es exitosa y en rojo si falla).
- Un `DataGridView` de solo lectura con el historial de intentos de inicio de sesión.
- Un `ErrorProvider` para mostrar los errores de validación junto a cada campo.

#### Organización del código

| Archivo | Responsabilidad |
|---|---|
| `Conexion.cs` | Clase estática que crea y abre la conexión a MySQL mediante `ObtenerConexion()`. |
| `Utiles.cs` | Operaciones de base de datos y seguridad: `Registrar()`, `Login()` y `ObtenerIntentos()`. |
| `Form1.cs` | Lógica del formulario: eventos de los botones, validación y presentación de resultados. |
| `Validar/IValidatorCampo.cs` | Interfaz común de validación. |
| `Validar/ValidadorTexto.cs` | Verifica que el campo no esté vacío. |
| `Validar/ValidadorClave.cs` | Verifica que la contraseña tenga al menos 4 caracteres. |

#### Registro de usuarios

Al presionar **Registrar**:

1. Se validan los campos. Para el usuario se utiliza `ValidadorTexto`, y para la contraseña `ValidadorClave`.
2. Se genera el hash de la contraseña con `BCrypt.Net.BCrypt.HashPassword()`.
3. Se inserta el usuario y su hash en la tabla `Usuarios` mediante una consulta parametrizada.
4. Si el usuario ya existe, la base de datos genera el error `1062` (clave duplicada). Este error se captura y se muestra el mensaje **"Ese usuario ya existe"**.
5. Si el registro es exitoso, se muestra el hash generado y se limpian los campos.

La contraseña **nunca se guarda en texto plano**, únicamente su hash.

#### Inicio de sesión

Al presionar **Iniciar sesión**:

1. Se validan los campos. En este caso la contraseña solo debe no estar vacía, mediante `ValidadorTexto`.
2. Se consulta el hash almacenado del usuario.
3. Se compara la contraseña ingresada contra el hash con `BCrypt.Net.BCrypt.Verify()`.
4. Se registra el intento en la tabla `IntentosLogin`, indicando si fue exitoso o no.
5. Se muestra el mensaje de bienvenida o el mensaje de error, se limpia la contraseña y se actualiza el historial.

Los intentos se registran siempre, incluso cuando el usuario ingresado no existe.

#### Validación de información

El proyecto reutiliza la interfaz:

```csharp
IValidatorCampo
```

que define:

```csharp
bool EsValido(string? valor);
string MensajeError { get; }
```

Esto permite que el formulario trate a todos los validadores de la misma manera. El método `DatosCorrectos(bool esRegistro)` arma la lista de pares campo-validador, ejecuta cada validación y envía los mensajes al `ErrorProvider`.

#### Consultas parametrizadas

Todas las consultas que reciben datos del usuario utilizan parámetros (`@u`, `@h`, `@e`), evitando insertar directamente los valores escritos por el usuario dentro del texto SQL.

### Base de datos

Se incluyen dos archivos SQL:

```text
querysBD.sql
backup.sql
```

- `querysBD.sql` crea la base de datos `LoginDB` y sus dos tablas vacías.
- `backup.sql` es un respaldo generado con `mysqldump` que contiene la misma estructura junto con datos de prueba.

**Tabla `Usuarios`**

| Campo | Tipo | Descripción |
|---|---|---|
| `Id` | `int` | Identificador único autoincremental |
| `NombreUsuario` | `varchar(50)` | Nombre de usuario (único) |
| `PasswordHash` | `varchar(100)` | Hash BCrypt de la contraseña |

**Tabla `IntentosLogin`**

| Campo | Tipo | Descripción |
|---|---|---|
| `Id` | `int` | Identificador único autoincremental |
| `NombreUsuario` | `varchar(50)` | Usuario con el que se intentó ingresar |
| `Exitoso` | `tinyint(1)` | Indica si el intento fue exitoso (`1`) o fallido (`0`) |
| `Fecha` | `datetime` | Fecha y hora del intento (por defecto, el momento actual) |

## 💻 Capturas de Pantalla y Problemas

### Figuras Geométricas

El programa muestra, para cada figura, su tipo, área y perímetro.
<img width="1362" height="728" alt="image" src="https://github.com/user-attachments/assets/122f4432-d96a-4cce-9270-4048dd037858" />

### Serialización JSON

El programa imprime el objeto serializado:
<img width="1383" height="748" alt="image" src="https://github.com/user-attachments/assets/3560bd64-a426-4eb0-b133-a500a178070e" />

### Portal de Login
<img width="703" height="433" alt="Screenshot 2026-11-09 112643" src="https://github.com/user-attachments/assets/fd2a2451-755f-4ac3-a7f6-e1abd8f0d748" />
<img width="644" height="424" alt="Screenshot 2026-11-09 112706" src="https://github.com/user-attachments/assets/b2619678-73d5-4cf2-bf37-7a7eea0b58b4" />
<img width="688" height="419" alt="Screenshot 2026-11-09 112722" src="https://github.com/user-attachments/assets/0f658b0f-d895-46dd-93c7-ba1b480c2d79" />
<img width="990" height="414" alt="Screenshot 2026-11-09 112728" src="https://github.com/user-attachments/assets/c50bf811-9ca4-43ff-95ee-8a3d9ad6958c" />
<img width="621" height="410" alt="Screenshot 2026-11-09 112743" src="https://github.com/user-attachments/assets/30235c02-165d-4ac2-ab26-bbaaac453b6e" />


## 📁 Estructura de Carpetas o Directorios

```text
Parcial N. 3/
│
├── backup.sql
├── querysBD.sql
│
├── Ejercicio1/
│   ├── Cuadrado.cs
│   ├── Ejercicio1.csproj
│   ├── Ejercicio1.sln
│   ├── Figura.cs
│   ├── Program.cs
│   ├── Rectangulo.cs
│   └── Triangulo.cs
│
├── Ejercicio2/
│   ├── Ejercicio2.csproj
│   ├── Ejercicio2.sln
│   └── Program.cs
│
└── Ejercicio3/
    ├── Conexion.cs
    ├── Ejercicio3.csproj
    ├── Ejercicio3.csproj.user
    ├── Ejercicio3.sln
    ├── Form1.cs
    ├── Form1.Designer.cs
    ├── Form1.resx
    ├── Program.cs
    ├── Utiles.cs
    └── Validar/
        ├── IValidatorCampo.cs
        ├── ValidadorClave.cs
        └── ValidadorTexto.cs
```

Los directorios `.vs`, `bin` y `obj` presentes en cada proyecto corresponden a archivos generados por Visual Studio y por el proceso de compilación. No son necesarios para comprender la implementación de los ejercicios.

## ▶️ Instrucciones de Ejecución / Uso

### Requisitos

Para ejecutar los proyectos se necesita:

- Windows (obligatorio para el Ejercicio 3, que usa Windows Forms).
- Visual Studio con soporte para .NET 9.
- .NET 9 SDK.
- Para el Ejercicio 2: acceso a NuGet para restaurar `Newtonsoft.Json`.
- Para el Ejercicio 3: servidor MySQL instalado y funcionando, y acceso a NuGet para restaurar `MySql.Data` y `BCrypt.Net-Next`.

### Ejecutar Ejercicio 1

Desde una terminal:

```bash
cd Ejercicio1
dotnet run
```

El programa no solicita datos; muestra directamente los resultados de las cuatro figuras.

### Ejecutar Ejercicio 2

```bash
cd Ejercicio2
dotnet run
```

El programa restaura el paquete `Newtonsoft.Json` y muestra el JSON generado.

### Ejecutar Ejercicio 3

Antes de iniciar la aplicación, es necesario crear la base de datos. Hay dos opciones:

- Ejecutar `querysBD.sql` para crear la base de datos `LoginDB` vacía.
- Importar `backup.sql` para crearla con datos de prueba incluidos.

Posteriormente, debe revisarse la cadena de conexión ubicada en:

```text
Ejercicio3/Conexion.cs
```

Actualmente el proyecto utiliza una cadena de conexión con la siguiente configuración:

```text
Server=localhost
Port=3306
Database=LoginDB
Uid=root
Pwd=demo
```

La contraseña debe adaptarse a la configuración local de MySQL.

Después de configurar MySQL, abrir:

```text
Ejercicio3/Ejercicio3.sln
```

en Visual Studio y ejecutar el proyecto.

Para probar la aplicación:

1. Escribir un usuario y una contraseña de al menos 4 caracteres, y presionar **Registrar**.
2. Escribir las mismas credenciales y presionar **Iniciar sesión**.
3. Repetir con una contraseña incorrecta para comprobar que el intento fallido queda registrado en el historial.

## ⚠️ Consideraciones

La contraseña de MySQL está escrita directamente en el archivo `Conexion.cs`. Para un proyecto real, no es recomendable almacenar credenciales de acceso directamente en el código fuente.

Una alternativa sería utilizar archivos de configuración, variables de entorno o mecanismos seguros de almacenamiento de secretos.

También se recomienda no publicar contraseñas reales en repositorios públicos.

Otras observaciones sobre el Ejercicio 3:

- Las contraseñas se almacenan únicamente como hash BCrypt, nunca en texto plano.
- Al registrar un usuario exitosamente, la aplicación muestra el hash generado en un cuadro de mensaje. Esto es útil para fines didácticos, pero en una aplicación real no debería mostrarse.
- El mensaje de error del inicio de sesión (**"Usuario o password mal"**) no distingue si falló el usuario o la contraseña, lo cual evita revelar qué usuarios existen.
- El archivo `backup.sql` incluye datos de prueba (un usuario y dos intentos de acceso). Conviene revisarlo antes de compartirlo públicamente.

## 👤 Autor y Contexto

- **Nombre:** *Mario Fernández Morales*
- **Institución:** Universidad Tecnológica de Panamá (UTP)
- **Facultad:** Ingeniería en Sistemas — Campus Víctor Levis Sasso
- **Asignatura:** Herramientas de Programación Aplicadas III
- **Instructor:** Ing. Irina Fong
- **Grupo:** 1IL133
- **Semestre:** II Semestre 2026
- **Evaluación:** Parcial N. 3
- **Fecha de Realización:** 09/11/2026

Este parcial fue desarrollado como parte de la evaluación de la asignatura, con el propósito de aplicar conceptos de programación orientada a objetos, serialización de datos y acceso a bases de datos utilizando C# y .NET.

## 📚 Referencias

- Microsoft Learn — Documentación oficial de C#.
- Microsoft Learn — .NET 9.
- Microsoft Learn — Windows Forms.
- Newtonsoft.Json — Documentación oficial de Json.NET.
- BCrypt.Net-Next — Documentación del paquete en NuGet.
- MySQL Documentation — SQL y administración de bases de datos.
- Documentación de `MySql.Data` para conectividad entre C# y MySQL.
