# API de Gestión de Rifles de Francotirador

API REST básica desarrollada en **C#** para gestionar un catálogo de los rifles de francotirador más avanzados. Implementa un **CRUD** completo sobre una lista de objetos en memoria y se documenta con **Swagger**.



![C#](https://img.shields.io/badge/C%23-512BD4?logo=csharp&logoColor=white)




![.NET](https://img.shields.io/badge/.NET-[versión]-512BD4?logo=dotnet&logoColor=white)




![Swagger](https://img.shields.io/badge/Swagger-85EA2D?logo=swagger&logoColor=black)




![Visual Studio](https://img.shields.io/badge/Visual%20Studio-2026-5C2D91?logo=visualstudio&logoColor=white)



## 📖 Descripción

El proyecto expone endpoints para **crear, consultar, actualizar y eliminar** rifles de francotirador. Como la "base de datos" es una **lista de objetos** de la clase `Rifle`, el CRUD es más sencillo: no hay conexión a un motor de base de datos, y los datos viven en memoria mientras la aplicación está en ejecución.

## 🧱 Modelo de datos

La clase `Rifle` tiene los siguientes atributos:

| Atributo | Descripción |
|----------|-------------|
| `Id` | Identificador único del rifle |
| `Nombre` | Nombre o modelo del rifle |
| `Calibre` | Calibre de la munición que utiliza |
| `Alcance` | Alcance efectivo del rifle |
| `TipoRifle` | Tipo o categoría del rifle |

## 📁 Estructura del proyecto

```
[NombreDelProyecto]/
├── Models/
│   └── Rifle.cs               # Entidad que representa un rifle
├── Controllers/
│   └── RifleController.cs     # Recibe las peticiones y devuelve las respuestas
├── Program.cs                 # Configuración y punto de entrada
└── README.md
```

- **Models:** contiene las entidades del sistema; en este caso, `Rifle`.
- **Controllers:** contiene `RifleController`, donde se reciben las peticiones del usuario y el servidor entrega las respuestas.

## 📚 Temáticas aplicadas

| Temática | Definición |
|----------|------------|
| **Encapsulamiento** | Principio de la POO que consiste en proteger los datos de una clase y controlar cómo se accede a ellos, usando modificadores de acceso (`private`, `public`) y propiedades (`get` / `set`). |
| **Protocolos HTTP** | Conjunto de reglas con las que cliente y servidor se comunican en la web. Cada método indica una acción: `GET` consulta, `POST` crea, `PUT` actualiza y `DELETE` elimina. |
| **Controllers** | Clases que reciben las solicitudes HTTP del usuario, ejecutan la lógica necesaria y devuelven la respuesta del servidor. Son el punto de entrada de la API. |
| **Herencia** | Mecanismo de la POO por el cual una clase (hija) reutiliza los atributos y métodos de otra (base), pudiendo ampliarlos o modificarlos. En este proyecto, `RifleController` hereda de `ControllerBase`. |

## 🔌 Endpoints

| Método | Ruta | Descripción |
|--------|------|-------------|
| `GET` | `/api/rifle` | Obtiene la lista de todos los rifles |
| `GET` | `/api/rifle/{id}` | Obtiene un rifle por su ID |
| `POST` | `/api/rifle` | Crea un nuevo rifle |
| `PUT` | `/api/rifle/{id}` | Actualiza un rifle existente |
| `DELETE` | `/api/rifle/{id}` | Elimina un rifle |

### Ejemplo de objeto JSON

```json
{
  "id": 1,
  "nombre": "[Nombre del rifle]",
  "calibre": "[Calibre]",
  "alcance": "[Alcance]",
  "tipoRifle": "[Tipo]"
}
```

## 📘 Documentación con Swagger

Los endpoints están documentados con **Swagger**, que ofrece una interfaz web para ver cada ruta con su protocolo HTTP y probarla directamente desde el navegador.

Al ejecutar el proyecto, abre:

```
https://localhost:[puerto]/swagger
```

## 🛠️ Requisitos

- [Visual Studio 2026](https://visualstudio.microsoft.com/) con la carga de trabajo **ASP.NET y desarrollo web**
- [.NET SDK [versión]](https://dotnet.microsoft.com/download)
- [Git](https://git-scm.com/)

## ▶️ Cómo clonar y ejecutar

**1. Clonar el repositorio**

```bash
git clone [URL-del-repositorio]
cd [NombreDelProyecto]
```

**2. Ejecutar desde Visual Studio 2026**

1. Abre el archivo de solución (`.slnx` o `.sln`) con Visual Studio.
2. Selecciona el perfil `http` como proyecto de inicio.
3. Presiona `F5` (o `Ctrl + F5` para ejecutar sin depurar).
4. Se abrirá el navegador con **Swagger** listo para probar los endpoints.

**3. Ejecutar desde la terminal (opcional)**

```bash
dotnet run
```

## 👤 Autor

**[Tu nombre]**  
[GitHub](https://github.com/[tu-usuario])