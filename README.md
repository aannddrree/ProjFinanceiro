# ProjFinanceiro

* Criar projeto

  dotnet new webapi

* Incluir EntityFramework

  dotnet add package Microsoft.EntityFrameworkCore.InMemory

* Swagger:

  https://localhost:5001/swagger/index.html

* Gerar Controller:

  Instação:
  
  dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
  
  dotnet add package Microsoft.EntityFrameworkCore.Design
  
  dotnet add package Microsoft.EntityFrameworkCore.SqlServer
  
  dotnet tool install -g dotnet-aspnet-codegenerator
  

  Gerar:

  dotnet aspnet-codegenerator controller -name DogController -async -api -m Dog -dc PetContext -outDir Controllers
  
  dotnet aspnet-codegenerator controller -name BreedController -async -api -m Breed -dc PetContext -outDir Controllers
  

* Criar tabelas:

  dotnet tool install --global dotnet-ef 
  
  dotnet ef migrations add v1
  
  dotnet ef database update
  

* Implementação para chamada do serviço (MongoService):

    dotnet add package Microsoft.AspNet.WebApi.Client --version 5.2.7

