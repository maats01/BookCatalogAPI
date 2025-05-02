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

1. Clonar o repositório:
```bash
git clone https://github.com/maats01/BookCatalogAPI.git
```

2. Executar o projeto:
O projeto pode ser executado pelo Visual Studio (CTRL + F5, com o projeto aberto) ou por terminal usando o seguinte comando:
```bash
dotnet run
```

3. Testando a API:
Após executar o projeto e o servidor estiver funcionando, a API vai estar disponível para testes em:
```
http://localhost:5201/
```

Para testes, pode ser usado cURL ou Postman, enviando um JSON como corpo de requisição para recursos POST e PUT, contendo o seguinte formato:
```
{
  "title": "O Senhor dos Anéis",
  "author": "J.R.R. Tolkien",
  "yearPublished": 1954
}
```
