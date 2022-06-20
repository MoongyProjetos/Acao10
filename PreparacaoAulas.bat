	echo 'Criando Pasta de Solucao'
	mkdir %1
	cd %1
	echo 'Agenda da Aula %1' >> agenda.txt

	echo 'Versao mais atual do .NET CORE instalada'
	dotnet --version
	#dotnet --info #Caso queira ver todas as versões

	echo 'Criacao dos Projetos'
	dotnet new console -n ConsoleApplication -o ConsoleApplication
	dotnet new classlib -n LogicaNegocio -o LogicaNegocio 
	dotnet new classlib -n Modelo -o Modelo 
	dotnet new webapp -n WebApplication -o WebApplication
	dotnet new mstest -n Tests -o Tests

	echo 'Criacao da Solucao'
	dotnet new sln -n Solucao
	dotnet sln add ConsoleApplication
	dotnet sln add WebApplication
	dotnet sln add LogicaNegocio
	dotnet sln add Modelo
	dotnet sln add Tests

	echo 'Preparacao dos Testes'
	dotnet add ConsoleApp/ConsoleApplication.csproj reference  LogicaNegocio/LogicaNegocio.csproj
	dotnet add Tests/Tests.csproj reference LogicaNegocio/LogicaNegocio.csproj

	echo 'Validacao do Preparo'
	dotnet restore
	dotnet build
	dotnet test