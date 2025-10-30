## Criando páginas poderosas no .Net com Razor Pages


---



# 📒 Projeto Razor Pages - Agenda de Contatos

Este projeto demonstra como criar páginas poderosas no .NET utilizando Razor Pages, aplicando boas práticas de programação orientada a objetos e integração com banco de dados PostgreSQL. O objetivo é construir um CRUD completo de contatos com estrutura limpa, escalável e moderna.

---

## 🚀 Tecnologias Utilizadas

- **.NET 8**
- **C# 12**
- **Razor Pages**
- **Entity Framework Core**
- **PostgreSQL**
- **Bootstrap (opcional para estilização)**
- **Design Patterns: MVC, MVVM, Repository**

---

## 💻 Requisitos de Hardware e Software

### Hardware
- Processador Dual Core ou superior
- 4 GB de RAM (mínimo)
- 500 MB de espaço livre em disco

### Software
- Windows 10 ou superior
- Visual Studio 2022 ou 2025 com suporte ao .NET 8
- PostgreSQL instalado e configurado
- .NET SDK 8.0
- Git (para versionamento e publicação)

---

## 📁 Estrutura de Pastas e Arquivos

### `Models/Contato.cs`
Define a entidade Contato com propriedades como Nome, Telefone, Email, Data de Nascimento e Foto. Aplica validações com atributos como `[Required]`, `[StringLength]` e `[EmailAddress]`.

### `Data/AppDbContext.cs`
Classe de contexto do Entity Framework Core que representa a conexão com o banco de dados e expõe o `DbSet<Contato>`.

### `Services/IContatoRepository.cs`
Interface que define os métodos do repositório: `GetAllAsync`, `GetByIdAsync`, `AddAsync`, `UpdateAsync`, `DeleteAsync`.

### `Services/ContatoRepository.cs`
Implementação da interface `IContatoRepository`. Contém a lógica de acesso ao banco de dados usando o `AppDbContext`.

---

## 📄 Páginas Razor

### `Pages/Index.cshtml`
Página inicial da aplicação. Apresenta uma mensagem de boas-vindas e um botão para acessar a lista de contatos.

### `Pages/Contatos/Index.cshtml`
Exibe a lista de contatos cadastrados em uma tabela. Inclui botões para editar, visualizar detalhes e excluir.

### `Pages/Contatos/Index.cshtml.cs`
Classe `PageModel` que carrega os contatos usando o repositório e os disponibiliza para a view.

### `Pages/Contatos/Create.cshtml`
Formulário para cadastrar um novo contato. Campos para nome, telefone, email, data de nascimento e foto.

### `Pages/Contatos/Create.cshtml.cs`
Classe que recebe os dados do formulário, valida e salva o novo contato no banco de dados.

### `Pages/Contatos/Edit.cshtml`
Formulário para editar um contato existente. Os dados são preenchidos automaticamente.

### `Pages/Contatos/Edit.cshtml.cs`
Carrega o contato por ID, permite edição e salva as alterações no banco.

### `Pages/Contatos/Delete.cshtml`
Confirmação de exclusão de um contato. Exibe o nome e pergunta se deseja excluir.

### `Pages/Contatos/Delete.cshtml.cs`
Carrega o contato por ID e executa a exclusão após confirmação.

### `Pages/Contatos/Details.cshtml`
Exibe os detalhes completos de um contato, incluindo a foto.

### `Pages/Contatos/Details.cshtml.cs`
Carrega o contato por ID e disponibiliza os dados para visualização.

---

## ⚙️ Configuração Principal

### `Program.cs`
Configura os serviços da aplicação, incluindo:
- Conexão com PostgreSQL
- Injeção de dependência do repositório
- Mapeamento de Razor Pages

### `appsettings.json`
Arquivo de configuração que contém a `ConnectionString` para o banco PostgreSQL:
```json
"ConnectionStrings": {
  "PostgresConnection": "Host=localhost;Database=AgendaDb;Username=postgres;Password=senha123"
}

---

