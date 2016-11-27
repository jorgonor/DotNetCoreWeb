# Step-by-step .NET Core on Linux

These are the simple steps followed to make a pet project with .NET Core on Linux.

## INSTALLATION SETUP WITH SQLITE
* Install https://www.microsoft.com/net/core
* Install Visual Studio Code https://code.visualstudio.com/
* Create project (suggest installing a different ef package or .net core 1.0 to run ef database.)
    - mkdir DotNetCoreWeb && cd DotNetCoreWeb
    - dotnet new -t web 
    - dotnet restore
    - (install client-side dependencies and js minification tools) Install Node.js, bower install && npm install
    - dotnet ef database update
    - dotnet run
* Add a Todo class
    - Add Models\Todo.cs
    - Add DbSet<Todo> to ApplicationContext
    - run "dotnet ef migrations add Todo1"
    - run "dotnet ef database update"
* Add a TodoController

## MIGRATING TO MYSQL WITH POMELO DRIVER
* Regenerate migrations (at least Todo1).

## PUBLISHING IN LINUX
* dotnet publish -c Release
* install nginx
* follow https://docs.microsoft.com/en-us/aspnet/core/publishing/linuxproduction
* set WorkingDirectory in systemd.