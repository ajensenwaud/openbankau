# OpenBanking AU - ASP.NET Core 2.2 mock API server

API sets created by the Australian Consumer Data Standards to meet the needs of the Consumer Data Right legislation. 

### About
openbankau is a mock API server that enables banks and app developers to quickly test their code against the emerging Open Banking / CDR specification. It has been generated from a snapshot of the OpenAPI spec published by Data#61 in Feb 2019. It is functional, but needs to be extended with a proper database (postgres) and identity / authentication, eg using JWT. I'm working on it now.

## Run
You must have .NET Core 2.2 installed for it to run.
Linux/OS X/Windows:

```
dotnet restore
dotnet build
dotnet run
```
