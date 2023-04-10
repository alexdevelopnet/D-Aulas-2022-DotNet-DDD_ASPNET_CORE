# D-Aulas-2022-DotNet-DDD_ASPNET_CORE
DDD (Domain Driven Design) modelagem de software cujo objetivo é facilitar a implementação de regras e processos complexos, 
onde visa a divisão de responsabilidades por camadas e é independente da tecnologia utilizada. 
Ou seja, o DDD é uma filosofia voltado para o domínio do negócio.


criar solução
dotnet new sln --name Api
------------------------------------------------------------------------
criar webApi
dotnet new webapi -n application -o Api.Application 
------------------------------------------------------------------------
adicionar aplicacao a solucao

dotnet sln add api.Application\

------------------------------------------------------------------------
build
dotnet build
------------------------------------------------------------------------
criando class lib

dotnet new classlib -n Domain -o Api.Domain -f netcoreapp3.1
dotnet sln add api.Domain\
------------------------------------------------------------------------
dotnet new classlib -n CrossCutting -f netcoreapp3.1 -o Api.CrossCutting
dotnet sln add api.CrossCutting\
------------------------------------------------------------------------
dotnet new classlib -n Data -f netcoreapp3.1 -o Api.Data
dotnet sln add api.Data
