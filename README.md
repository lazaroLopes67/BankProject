BankProject
Descrição: Este é um sistema bancário desenvolvido em C#, projetado com uma arquitetura modular e resiliente


🌐 Visão Geral do Sistema
O projeto foi construído seguindo o princípio de separação de responsabilidades (SoC), garantindo que cada "membro da equipe" (camada) execute sua função sem comprometer a integridade do núcleo.

🏗️ Arquitetura de Camadas (Layers)
O sistema é dividido em camadas lógicas para facilitar a manutenção e escalabilidade:
🖥️ 1. Presentation Layer
A interface de entrada. Responsável pela interação com o usuário e exibição de dados. É o "casulo" que protege a lógica interna.

🧠 2. Business Logic Layer (BLL)
Aqui são processadas as regras de negócio, validações bancárias e cálculos complexos. Nada acontece sem a aprovação desta camada.

💾 3. Data Access Layer (DAL)
A conexão com o banco de dados. Esta camada gerencia a persistência de dados, garantindo que as informações sejam gravadas e recuperadas com segurança do banco de dados, no caso desse projeto minha implementação de
banco de dados foi uma coleção genérica nativa do C# (List<Costumer>).

🧱 4. Entities Layer
Modelos fundamentais do sistema. Define a estrutura dos objetos (Contas, Clientes, Transações) que circulam por todas as outras camadas.

🛡️ 5. Exceptions Layer
Camada dedicada ao tratamento de erros customizados, garantindo que falhas sejam interceptadas antes de comprometerem o sistema.

⚙️ 6. Configuration Layer
Possui as varáveis padrões que o sistema usa.
🚀 Tecnologias Utilizadas

    Linguagem: C# 💻
    Arquitetura: Layered Architecture (N-Tier) 
  
🛠️ Instalação e Execução

Para clonar e rodar este projeto na sua "net", você precisará do .NET SDK instalado.
# Clone o repositório
git clone https://github.com/lazaroLopes67/BankProject.git

# Entre no diretório
cd BankProject

# Restaure as dependências
dotnet restore

# Execute o projeto
dotnet run --project PresentationLayer

# No Visual Studio
altere a bankProject.Presentation como Projeto de inicialização

# username e password
utilize username: system, password: manager

📂 Estrutura de Pastas
Plaintext

BankProject/
├── Presentation/      # Interface do Usuário
├── BusinessLogic/     # Regras de Negócio
├── DataAccess/        # Gravação no database
├── Entities/          # Modelos
├── Exceptions/        # Exceções Customizadas
└── Configuration/     # Configurações
