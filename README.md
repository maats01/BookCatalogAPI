# 📚 BookCatalogAPI

BookCatalog é uma API REST simples feita com ASP.NET Core para gerenciamento de um catálogo de livros (armazenados em memória), com o objetivo de compreender os princípios de uma API REST.

## Funcionalidades

- Listar todos os livros (`GET /api/books`)
- Obter um livro pelo ID (`GET /api/books/{id}`)
- Adicionar um novo livro (`POST /api/books`)
- Atualizar um livro existente (`PUT /api/books/{id}`)
- Remover um livro (`DELETE /api/books/{id}`)

## Tecnologias utilizadas

- C#
- ASP.NET Core
- Visual Studio

## Executando a aplicação

### 1. Clonar o repositório
```bash
git clone https://github.com/maats01/BookCatalogAPI.git
```

### 2. Instalar o pacote do Swagger
Com o terminal aberto e dentro do diretório da aplicação, execute:
```bash
dotnet add package Swashbuckle.AspNetCore
```

Ou, abra o projeto no Visual Studio e utilize o **gerenciador de pacotes NuGet** para instalar o pacote **Swashbuckle.AspNetCore**.

### 3. Executar o projeto
O projeto pode ser executado pelo Visual Studio (CTRL + F5, com o projeto aberto) ou por terminal usando o seguinte comando:
```bash
dotnet run
```

### 4. Testar a API
Após executar o projeto e o servidor estiver funcionando, a API vai estar disponível para testes em:
```bash
http://localhost:5201/
```

Também é possível testar a aplicação utilizando a interface do Swagger, disponível em:
```bash
http://localhost:5201/swagger
```

Pela interface do Swagger, você pode testar todos os endpoints de forma interativa, visualizando as especificações da API e os exemplos de requisição/resposta.

Para testar os endpoints `POST` e `PUT`, envie um corpo JSON seguindo o exemplo abaixo (via Postman, cURL ou outro client HTTP):
```json
{
  "title": "O Senhor dos Anéis",
  "author": "J.R.R. Tolkien",
  "yearPublished": 1954
}
```
