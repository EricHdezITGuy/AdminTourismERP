# AdminTourismo 🌐

_AdminTourismo_ es una plataforma de administración para servicios de turismo. Esta aplicación permite a los usuarios registrarse, iniciar sesión y administrar reservas y tours.

## 🚀 **Características** 

- **Autenticación de usuarios**: 
    - Registro de usuarios
    - Inicio de sesión
    - Recuperación de contraseña
- **Gestión de reservas**: 
    - Administración completa de reservas y tours
- **Gestión de tours**: 
    - Añadir, editar, eliminar tours

## 💻 **Tecnologías utilizadas** 

- **Backend**: 
    - .NET 6 
    - ASP.NET Core 
    - ASP.NET Core Identity
- **Base de datos**: 
    - MySQL con Pomelo.EntityFrameworkCore.MySql
- **Frontend**: 
    - Razor Views

## 📦 **Instalación** 

1. **Clonar el repositorio**
    ```bash
    git clone https://github.com/EricHdezITGuy/AdminTourismERP
    ```

2. **Cambiar al directorio del proyecto**
    ```bash
    cd AdminTourismo
    ```

3. **Restaurar paquetes NuGet**
    ```bash
    dotnet restore
    ```

4. **Configurar base de datos**
    - Ajustar la cadena de conexión en `appsettings.json`.

5. **Ejecutar migraciones** (si estás usando Code First):
    ```bash
    dotnet ef database update
    ```

6. **Ejecutar el proyecto**
    ```bash
    dotnet run
    ```

## 🤝 **Contribuciones** 

Las contribuciones son **bienvenidas**. Para problemas o sugerencias, por favor abre un _issue_ o realiza un _pull request_.

## 📄 **Licencia** 

Este proyecto está licenciado bajo MIT. Consulta el archivo [LICENSE.md](LICENSE.md) para obtener más detalles.
