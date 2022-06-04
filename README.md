# ModeloCleanArchitecture

Modelo ModeloCleanArchitecture para DotNet Core WebApi

# Configuração
Abra o arquivo appsettings.json para alterar as strings de conexão conforme as usada em seu ambiente.

No console do gerenciador de pacotes rode os comandos:
``` shell
update-database -Context ApplicationDbContext
```

``` shell
update-database -Context IdentityContext
```

# Funções

## Usuários e funções adicionados ao banco de dados.

- SuperAdmin
- Admin
- Moderador
- Básico

## Credenciais definidas para os usuários padrão :

- Email - superadmin@gmail.com / Senha - 123Pa$$word!
- Email - basic@gmail.com / Senha - 123Pa$$word!

É possivel gerar credenciais JWTokens válidos no endpoint ../api/account/authenticate.


# Tecnologias usadas

- ASP.NET Core 3.1 WebApi
- Padrões REST
- Bibliotecas .NET Core 3.1 / Standard 2.1 / .NET 5