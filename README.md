# desafioUBC-Core
Desafio Técnico: Criação de uma WebAPI com .NET 6 com Autenticação

# --------------------------------------------------------------------------
##### Back-end (WebAPI)
1. **Framework**: .NET 6.
2. **Entity Framework**: Usar o EF Core com um banco de dados em memória.
3. **Autenticação**: Implementar autenticação básica (JWT).

-- 1, 2 e 3: Feitos

- Students:
	- Consultas: 
		- **GET**    `ListarTodos` 
		- **GET**    `ObterPorCodigo`
		- **POST**   `BuscarEstudantes (ListarPorFiltros)`
	- CRUD: 
		- **POST**   `Adicionar`: Cria um novo estudante.
        - **PUT**    `ALterar`:   Atualiza um estudante existente.
		- **DELETE** `Excluir`:   Deleta um estudante.


- Login:
	    - **POST** `/api/auth/login`: Autentica um usuário e retorna um token JWT.

# --------------------------------------------------------------------------

- Instruções para rodar o projeto localmente no README.md do projeto Front-End.