# Musicfy
Prueba Tecnica Dynamic Devs - .Net Core
	1. Clonar repositorio al IDE de preferencia (Visual Studio en este caso)
  2. Verificar las cadenas de conexión en  Repositories.EFCore.DataContext (Archivo MusicfyContextFactory) y en appsetings.json (WebApi)  
  3. Ir a herramientas / Tools
	4. Ir a Administrador de Paquetes Nuget / Nuget Package Manager 
	5. Seleccionar Consola del administrador paquetes
  6.  Ejecutar los comandos
    i. add-migration InitialCreate -p Repositories.EFCore -c MusicfyContext -o Migrations -s Repositories.EFCore
    ii. update-database -p Repositories.EFCore -s Repositories.EFCore![image](https://user-images.githubusercontent.com/58633633/200274158-33d0e865-e401-423e-a883-15c940879473.png)
  7. Verificar 
  8. Compilar Solución (F5)
