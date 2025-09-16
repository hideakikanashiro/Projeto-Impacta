# Projeto: Agendamento Veterinária e Banho e Tosa
Este projeto permite que você gerencie agendamentos para uma clínica veterinária, oferecendo serviços como consultas veterinárias e banho e tosa. Você pode cadastrar, editar, excluir e visualizar todos os agendamentos.


## Como Rodar o Projeto
  * **.NET 6 ou superior:** Certifique-se de ter o SDK do .NET instalado.
  * **Visual Studio 2022:** Ou outro editor de código compatível com projetos ASP.NET Core.


### Passos para Rodar o Projeto:
1.  **Clone o Repositório:**

    ```bash
    git clone https://github.com/hideakikanashiro/Projeto-Impacta.git
    cd [NOME_DA_PASTA_DO_PROJETO]
    ```


2.  **Restaure as Dependências:**
    No terminal, dentro da pasta do projeto Web, execute:

    ```bash
    dotnet restore
    ```

    Isso baixará as dependências, incluindo o Entity Framework.


3.  **Crie o Banco de Dados (se for a primeira vez):**
    Se você está rodando o projeto pela primeira vez ou se o banco de dados ainda não existe, você precisará criar as migrações e atualizar o banco de dados. Execute os seguintes comandos la no terminal:

    ```bash
    dotnet ef migrations add InitialCreate
    dotnet ef database update
    ```

    Isso irá criar o banco de dados e as tabelas necessárias.


4.  **Rode o Projeto:**
    Pressione F5 para rodar o projeto. Lembrando que caso não esteja pré-configurado para rodar o projeto Web, altere para que ele rode o projeto Web.

-----

### Sobre o Tailwind CSS

O **Tailwind CSS** já está configurado no projeto. O arquivo de configuração (`tailwind.config.js`) e os CSS compilados (`tailwind.css`) devem estar presentes. Ao rodar o projeto com `dotnet run`, o Tailwind processará os arquivos e aplicará os estilos automaticamente. Não é necessário instalar nada extra para ele funcionar corretamente.
