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

1. Clone o repositório:
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

---

## Exemplos de uso
### Listar todos os livros

**Requisição:**

```bash
curl http://localhost:5201/api/books
```

**Resposta:**

```json
[
  {
    "id": 1,
    "titulo": "O Senhor dos Anéis",
    "autor": "J.R.R. Tolkien",
    "ano": 1954
  }
]
```
---

### 🔎 Obter um livro por ID

**Requisição:**

```bash
curl http://localhost:5201/api/books/1
```

**Resposta:**

```json
{
  "id": 1,
  "titulo": "O Senhor dos Anéis",
  "autor": "J.R.R. Tolkien",
  "ano": 1954
}
```

**Se não encontrado:**

```json
{
  "message": "Livro não encontrado"
}
```

---

### ➕ Adicionar um novo livro

**Requisição:**

```bash
curl -X POST http://localhost:5201/api/books \
-H "Content-Type: application/json" \
-d '{
  "titulo": "1984",
  "autor": "George Orwell",
  "ano": 1949
}'
```

**Resposta:**

```json
{
  "id": 2,
  "titulo": "1984",
  "autor": "George Orwell",
  "ano": 1949
}
```

---

### ✏️ Atualizar um livro existente

**Requisição:**

```bash
curl -X PUT http://localhost:5201/api/books/2 \
-H "Content-Type: application/json" \
-d '{
  "id": 2,
  "titulo": "1984",
  "autor": "George Orwell",
  "ano": 1950
}'
```

**Resposta:**

```json
{
  "id": 2,
  "titulo": "1984",
  "autor": "George Orwell",
  "ano": 1950
}
```

---

### ❌ Remover um livro

**Requisição:**

```bash
curl -X DELETE http://localhost:5201/api/books/2
```

**Resposta:**

```bash
# status code 204 No Content
```
