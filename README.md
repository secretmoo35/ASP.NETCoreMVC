# ASP.NETCoreMVC
Test WepApplication with asp.net core 2.1 mvc

    - Connect database to Microsoft SQL: https://www.microsoft.com/en-us/sql-server/sql-server-2017
    - Add authentication with scaffold identity
    
### Config

Change appsettings.json

    "DatabaseContextConnection": "Server={{ SERVER_NAME }};Database={{ DATABASE_NAME }};Trusted_Connection=True;MultipleActiveResultSets=true",

    "IdentityContextConnection": "Server={{ SERVER_NAME }};Database={{ DATABASE_NAME }};Trusted_Connection=True;MultipleActiveResultSets=true"

### Run package manager console

Change model

    Add-migration {{ Commit }}

Update database

    update-database


