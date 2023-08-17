# Gestão de Produtos API - Documentação

## Descrição

Esta é uma API de gerenciamento de produtos que permite criar, atualizar, listar e excluir produtos. A API é construída em C# usando o framework ASP.NET Core e utiliza o Entity Framework Core para a persistência de dados. O AutoMapper é utilizado para mapear entre os modelos de dados e os DTOs (Data Transfer Objects). Abaixo estão os principais componentes da API:

- **Controllers:** A API possui um controlador chamado `ProdutoController` que gerencia as operações CRUD (Create, Read, Update, Delete) relacionadas aos produtos.

- **Data:** A pasta `Data` contém a classe `ProdutoContext`, que é uma classe de contexto do Entity Framework Core, responsável por se conectar ao banco de dados e mapear as entidades para tabelas.

- **Data.Dtos:** Nesta pasta estão os objetos DTO (Data Transfer Objects) que são usados para receber e retornar dados da API sem expor os detalhes internos dos modelos de dados.

- **Models:** Os modelos de dados representam a estrutura dos produtos que serão armazenados no banco de dados.

- **Profiles:** Os perfis de mapeamento do AutoMapper são definidos nesta pasta para converter objetos entre os modelos de dados e os DTOs.

- **Program.cs:** O arquivo de entrada do programa configura os serviços, o banco de dados, o AutoMapper e outras configurações da aplicação.

## Endpoints

### Criar um Produto

Endpoint: `POST /api/produto`

Cria um novo produto com base nos dados fornecidos.

Parâmetros da Solicitação (JSON):
```json
{
  "Nome": "Nome do Produto",
  "Preco": 100,
  "QuantidadeEmEstoque": 10,
  "DataDeCriacao": "2023-08-17"
}
```
Resposta:
- Status: 201 Created
- Corpo: Detalhes do produto criado
  
###  Listar Produtos
Endpoint: GET /api/produto
Lista todos os produtos.

Parâmetros da Solicitação:

- skip (opcional): Número de produtos a pular (padrão: 0)
- take (opcional): Número máximo de produtos a retornar (padrão: 15)
  
Resposta:
- Status: 200 OK
- Corpo: Lista de produtos
  
### Obter Produto por ID
Endpoint: GET /api/produto/{id}

Obtém os detalhes de um produto com base no ID fornecido.

Parâmetros da Solicitação:

- id: ID do produto a ser obtido
Resposta:

- Status: 200 OK
- Corpo: Detalhes do produto
  
### Atualizar Produto
Endpoint: PUT /api/produto/{id}

Atualiza os detalhes de um produto com base no ID fornecido.

Parâmetros da Solicitação (JSON):
```json
{
  "Nome": "Novo Nome do Produto",
  "Preco": 150,
  "QuantidadeEmEstoque": 20,
  "DataDeCriacao": "2023-08-17"
}
```
Resposta:
- Status: 204 No Content
  
### Atualizar Produto Parcialmente
Endpoint: PATCH /api/produto/{id}

Atualiza parcialmente os detalhes de um produto com base no ID fornecido.

Parâmetros da Solicitação (JSON Patch):
```json
[
  { "op": "replace", "path": "/Nome", "value": "Novo Nome do Produto" }
]
```
Resposta:
- Status: 204 No Content
  
### Excluir Produto
Endpoint: DELETE /api/produto/{id}

Exclui um produto com base no ID fornecido.

Parâmetros da Solicitação:
- id: ID do produto a ser excluído
Resposta:
- Status: 204 No Content

### Configuração do Projeto
## Banco de Dados
A aplicação utiliza um banco de dados MySQL. Certifique-se de configurar a string de conexão no arquivo appsettings.json.

## Execução
Certifique-se de que você tem o SDK do .NET Core instalado. Para executar a aplicação, navegue até a pasta raiz do projeto no terminal e execute:
```
dotnet run
```
A aplicação será iniciada e estará disponível em https://localhost:5000.
## Swagger
Durante o desenvolvimento, você pode acessar a documentação interativa da API usando o Swagger. Vá para https://localhost:5000/swagger após iniciar a aplicação.
## Considerações Finais
Esta API oferece funcionalidades completas para o gerenciamento de produtos. Certifique-se de fornecer os dados corretos nos formatos esperados ao fazer solicitações para a API. Se houver alguma dúvida ou problema, consulte a documentação, o código-fonte ou entre em contato com a equipe de desenvolvimento.








