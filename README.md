# 📋 Alugaki - Software de Gestão de Aluguéis

Este é um software desenvolvido para facilitar a organização de aluguéis, criado com **C#**, **.NET 8** e **SQL Server Manager**, utilizando a extensão **Microsoft.Data.SqlClient**. O principal objetivo é tornar o gerenciamento de cadastros de aluguéis mais intuitivo, permitindo que os dados de cada usuário sejam armazenados e acessados separadamente.

## ✨ Funcionalidades

- **Criação de Contas**: Sistema de cadastro de usuários vinculado a um banco de dados SQL.
- **Login Seguro**: Verificação de credenciais com autenticação no banco de dados.
- **Cadastro de Aluguéis**: Cada usuário pode registrar aluguéis específicos, com dados separados no banco.
- **Revisão e Exclusão**: Permite revisar os aluguéis registrados e excluir os que não são mais necessários.
- **Sidebar Animada**: Interface com navegação amigável e animações para facilitar o uso.
- **Integração com Banco de Dados SQL**: Manipulação segura dos dados no banco.

## 🛠️ Tecnologias Utilizadas

- **C#**
- **.NET 8**
- **SQL Server Manager**
- **Microsoft.Data.SqlClient**

## 🔍 Como Usar

### Cadastro e Login

1. Ao iniciar o software, crie uma conta preenchendo os campos obrigatórios (Nome, Sobrenome, Email, Usuário e Senha).
2. Faça o login para acessar as funcionalidades.

### Gerenciamento de Aluguéis

1. Na seção de "Cadastrar Aluguel", insira os dados do aluguel (Nome do Cliente, Telefone, Conteúdo, Tempo, Preço e CPF).
2. Para revisar os aluguéis cadastrados, acesse a seção "Revisar Aluguéis".
3. A exclusão de um aluguel pode ser feita selecionando-o na lista e clicando no botão de exclusão.

### Sidebar e Navegação

Utilize o menu lateral animado para navegar entre as páginas do software.

## 💻 Código de Exemplo

Aqui estão alguns trechos de código usados no desenvolvimento:

### Conexão com o Banco de Dados
```csharp
string connectionString = "minha-string-de-conexão-aqui";

using (SqlConnection connection = new SqlConnection(connectionString))
{
    connection.Open();
   
}
```
### Cadastro de Novo Aluguel
```csharp
private void CadastrarAluguel()
{
    //Foi criada uma lista no SQL, para salvamento dos dados e após trazer ele para o software foi utilizado:
    string nomeCliente = txtNomeCliente.Text;
    string telefoneCliente = txtTelefoneCliente.Text;
    string conteudo = txtConteudo.Text;
    // Lógica para salvar no banco de dados
}
```

##📸 Imagens do Software

### 🔐 Tela de Login
<img src="https://github.com/user-attachments/assets/7f6358db-2508-4860-904f-a3db473aa45c" alt="Tela de Login" style="float: right; width: 300px;"/>

### 📝 Tela de Cadastro
<img src="https://github.com/user-attachments/assets/72cd1324-eeeb-4e80-9107-7b10e9a54712" alt="Tela de Cadastro" style="float: right; width: 300px;"/>

### 📂 Menu de Navegação
<img src="https://github.com/user-attachments/assets/4bb71d19-6248-46c3-aa57-cfec9e5ce7e0" alt="Menu de Navegação" style="float: right; width: 300px;"/>

### 🎚️ Slide Bar
<img src="https://github.com/user-attachments/assets/e5d0d7c8-639a-4a45-b1ad-87b974d9f471" alt="Slide Bar" style="float: right; width: 300px;"/>

### 🏷️ Cadastro de Aluguéis
<img src="https://github.com/user-attachments/assets/dca5e9f6-d581-4533-a06b-bfa43c9cfcd7" alt="Cadastro de Aluguéis" style="float: right; width: 300px;"/>

### 🗑️ Exclusão de Aluguel
<img src="https://github.com/user-attachments/assets/9a4e2fae-d870-4c01-8c49-a67d8fa08d92" alt="Exclusão de Aluguel" style="float: right; width: 300px;"/>

### 📋 Lista dos Aluguéis
<img src="https://github.com/user-attachments/assets/16fb3271-43f1-4eec-8a03-6118dbc064af" alt="Lista dos Aluguéis" style="float: right; width: 300px;"/>


## 📝 Observações
-  Projeto pessoal criado para estudo.
-  Primeiro software que desenvolvi.
