# 🛠️ Oficina Mecânica API (.NET 6)

API REST desenvolvida em **.NET 6** para gerenciamento de orçamentos de uma oficina mecânica.

O sistema permite criar orçamentos de serviços automotivos com cálculo automático de valores e validações de regras de negócio.

---

## 🚀 Tecnologias utilizadas

- .NET 6
- ASP.NET Core Web API
- C#
- Swagger (OpenAPI)
- Arquitetura em camadas (Controller, Service, Domain, Repository)

---

## 📌 Funcionalidades

- ✔ Cadastro de orçamento
- ✔ Cálculo automático do valor total
- ✔ Validação de dados obrigatórios
- ✔ Estrutura em camadas (Clean Architecture simplificada)
- ✔ API documentada com Swagger

---

## 📥 Endpoint

### ➕ Criar orçamento

`POST /api/orcamentos`

---

### 📄 Request

```json
{
  "clienteId": 10,
  "veiculoId": 25,
  "itens": [
    {
      "descricao": "Troca de óleo",
      "quantidade": 1,
      "valorUnitario": 120.00
    },
    {
      "descricao": "Filtro de óleo",
      "quantidade": 1,
      "valorUnitario": 45.00
    }
  ]
}
```
### 📤 Response
```
{
  "id": 1,
  "clienteId": 10,
  "veiculoId": 25,
  "total": 165.00,
  "itens": [
    {
      "descricao": "Troca de óleo",
      "quantidade": 1,
      "valorUnitario": 120.00
    },
    {
      "descricao": "Filtro de óleo",
      "quantidade": 1,
      "valorUnitario": 45.00
    }
  ]
}
```
### ⚠️ Regras de negócio
```
clienteId é obrigatório
veiculoId é obrigatório
Deve existir pelo menos 1 item no orçamento
Cada item deve conter:
descrição obrigatória
quantidade > 0
valor unitário > 0
O valor total é calculado automaticamente pela API
```
🧱 Arquitetura do projeto
```
Oficina.Api
│
├── Controllers        → Endpoints da API
├── Application
│   ├── DTOs           → Objetos de entrada/saída
│   └── Services       → Regras de negócio
│
├── Domain
│   ├── Entities       → Entidades do sistema
│   └── Interfaces     → Contratos
│
├── Infrastructure
│   └── Repositories    → Acesso a dados
```
### ⚙️ Como executar o projeto
1️⃣ Clonar o repositório
 `git clone https://github.com/seuusuario/oficina-api.git`

2️⃣ Acessar o projeto
 `cd oficina-api`

3️⃣ Rodar a aplicação
`dotnet run`

4️⃣ Acessar Swagger
 `https://localhost:5001/swagger`

📌 Melhorias futuras
- Integração com banco de dados (EF Core + SQL Server)
- Autenticação JWT
- Cadastro de clientes e veículos
- Status do orçamento (Aberto, Aprovado, Rejeitado)
- Logs e auditoria
- FluentValidation
