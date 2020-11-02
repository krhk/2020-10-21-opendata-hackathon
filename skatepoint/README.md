# Skatepoint

- Git: https://github.com/majda107/skatepoint
- Technologie: Backend je tvořen .NET ASPNETem, frontend VUE a databáze MSSQL.
- Opendata: Památné stromy, seznam obcí a měst, památky

**Popis**

Naše aplikace s názvem Skatepoint pomáhá řešit problém se sdílením volných míst pro nadšence do skateboardu / bruslí / koloběžek. Ve webovém rozhraní si uživatel může procházet dostupné body a hodnotit je, či je dokonce sám přidávat.

**Usage**

Ke sprovoznění aplikace stačí upravit connection string v Startup.cs pro připojení do vlastní databáze, poté pustit migrace (nainstalovat nuget dotnet-ef) "dotnet ef database update" a spustit ASP.NET server jako takový. Pro webového klienta, musíte v "ClientApp/src/models/CONSTS.ts" upravit endpoint url na adresu, kde běží ASP.NET server, pokud má klient server hostovat, stačí pustit příkaz "npm run build" a soubory "dist" složky přesunout do složky "wwwroot" v ASP.NET projektu.

Pro načtení opendat do databáze jsou v "DataController.cs" připravené REST funkce.

**Screenshots**

![](01.jpg)
![](02.jpg)
![](03.jpg)
![](04.jpg)
