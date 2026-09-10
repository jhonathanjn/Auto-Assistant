# Documentação do Projeto — Assistente Pessoal

## 1. Visão do projeto

Criar uma assistente pessoal multiplataforma capaz de receber comandos digitados e executar ações no computador e, futuramente, no celular.

O núcleo do projeto deve ser independente da interface. Assim, no futuro, o mesmo sistema poderá receber comandos pelo terminal, aplicativo desktop, Linux ou Android.

O reconhecimento de voz será opcional e ficará para uma fase posterior.

---

# 2. Objetivo final

A assistente deverá ser capaz de:

- Executar comandos digitados.
- Abrir aplicativos, arquivos, pastas e sites.
- Criar e manipular arquivos e pastas.
- Permitir atalhos/comandos personalizados.
- Criar e executar rotinas.
- Pesquisar arquivos.
- Registrar histórico.
- Utilizar banco de dados.
- Consumir APIs externas.
- Agendar tarefas.
- Possuir interface desktop.
- Possuir uma versão mobile.
- Opcionalmente receber comandos por voz.
- Futuramente utilizar IA para interpretar linguagem natural.

---

# 3. Roadmap de desenvolvimento

## Fase 1 — Fundação

Status: CONCLUÍDA

### Objetivos
Criar a aplicação de console e seu loop principal.

### Funcionalidades
- [x] Banner inicial
- [x] Loop principal
- [x] Entrada de comandos
- [x] Comando `ajuda`
- [x] Comando `help`
- [x] Comando `clear`
- [x] Comando `sair`
- [x] Mensagem para comandos desconhecidos

### Conceitos
- Console
- while
- if
- switch
- métodos
- classes
- namespaces

---

## Fase 2 — Parser de comandos

Status: EM DESENVOLVIMENTO

### Objetivo
Transformar uma entrada de texto em informações que o sistema consiga interpretar.

Exemplo:

    abrir vscode

Resultado esperado:

    Ação: abrir
    Alvo: vscode

### Funcionalidades
- [X] Separar comando em partes
- [X] Identificar ação
- [X] Identificar alvo
- [X] Validar comandos incompletos
- [X] Tratar entradas inválidas
- [X] Preparar estrutura para comandos com vários argumentos

### Estudar
- string
- String.Split()
- Trim()
- ToLower()
- Equals()
- arrays
- List<T>
- validação de entrada

---

## Fase 3 — Executor / Aplicativos

Status: PRÓXIMA

### Objetivo
Fazer o sistema executar ações reais no computador.

### Primeira funcionalidade
Abrir aplicativos.

Exemplo:

    abrir notepad

Depois:

    abrir vscode
    abrir spotify
    abrir chrome

### Funcionalidades futuras
- [X] Abrir aplicativo
- [X] Abrir arquivo
- [X] Abrir pasta
- [ ] Abrir site
- [ ] Fechar aplicativo
- [ ] Verificar se aplicativo está executando

### Estudar
- System.Diagnostics
- Process
- Process.Start()
- ProcessStartInfo
- UseShellExecute
- tratamento de exceções

---

## Fase 4 — Sistema de arquivos

### Objetivo
Permitir que a assistente manipule arquivos e pastas.

### Funcionalidades
- [ ] Criar pasta
- [ ] Criar arquivo
- [ ] Copiar arquivo
- [ ] Mover arquivo
- [ ] Renomear arquivo
- [ ] Excluir arquivo
- [ ] Excluir pasta
- [ ] Consultar informações de arquivos

### Estudar
- File
- Directory
- Path
- FileInfo
- DirectoryInfo

---

## Fase 5 — Configurações e comandos personalizados

### Objetivo
Tirar configurações do código e permitir que o usuário personalize os comandos.

### Arquivos planejados
- apps.json
- settings.json
- routines.json

### Exemplos

    .estudo
    .trabalho
    .jogos

Um comando personalizado poderá representar uma ação ou uma rotina.

### Funcionalidades
- [ ] Cadastrar aplicativo
- [ ] Editar aplicativo
- [ ] Remover aplicativo
- [ ] Listar aplicativos
- [ ] Criar atalhos personalizados
- [ ] Alterar atalhos
- [ ] Remover atalhos

### Estudar
- JSON
- System.Text.Json
- JsonSerializer
- Serialize
- Deserialize
- Dictionary

---

## Fase 6 — Rotinas e automações

### Objetivo
Permitir que um único comando execute várias ações.

Exemplo:

    .estudo

Pode executar:

- Abrir VS Code
- Abrir navegador
- Abrir páginas necessárias
- Abrir Spotify

### Funcionalidades
- [ ] Criar rotina
- [ ] Executar rotina
- [ ] Editar rotina
- [ ] Excluir rotina
- [ ] Listar rotinas
- [ ] Adicionar várias ações a uma rotina
- [ ] Definir ordem das ações

### Estudar
- List<T>
- foreach
- LINQ
- JSON
- composição de objetos

---

## Fase 7 — Busca de arquivos

### Objetivo
Permitir encontrar arquivos e pastas através de comandos.

Exemplos:

    procurar GameHub
    encontrar currículo

### Funcionalidades
- [ ] Pesquisar arquivos
- [ ] Pesquisar pastas
- [ ] Filtrar por extensão
- [ ] Limitar diretórios de pesquisa
- [ ] Exibir resultados

### Estudar
- Directory.GetFiles()
- SearchOption
- FileInfo
- DirectoryInfo
- LINQ

---

## Fase 8 — Histórico e logs

### Objetivo
Registrar o que aconteceu no sistema.

### Funcionalidades
- [ ] Histórico de comandos
- [ ] Data e hora
- [ ] Resultado da execução
- [ ] Registro de erros
- [ ] Consulta do histórico

### Estudar
- DateTime
- DateTimeOffset
- logging
- Serilog
- tratamento de exceções

---

## Fase 9 — Banco de dados

### Objetivo
Substituir gradualmente o armazenamento em JSON por PostgreSQL.

### Dados
- Aplicativos
- Atalhos
- Rotinas
- Histórico
- Configurações

### Estudar
- SQL
- PostgreSQL
- Npgsql
- Entity Framework Core
- DbContext
- DbSet
- migrations
- relacionamentos

---

## Fase 10 — APIs externas

### Objetivo
Permitir que a assistente consulte serviços externos.

Exemplos:

    clima
    dólar
    notícias

### Funcionalidades
- [ ] Consumir API de clima
- [ ] Consumir API de câmbio
- [ ] Consumir outras APIs úteis
- [ ] Tratar erros de conexão
- [ ] Configurar chaves de API com segurança

### Estudar
- HTTP
- REST
- HttpClient
- GET
- POST
- JSON
- API keys
- async/await

---

## Fase 11 — Agendamento

### Objetivo
Executar ações automaticamente em horários definidos.

Exemplos:

    às 20:00 abrir Spotify
    amanhã 08:00 executar estudo

### Funcionalidades
- [ ] Criar agendamento
- [ ] Excluir agendamento
- [ ] Listar agendamentos
- [ ] Executar rotina em horário definido
- [ ] Cancelar tarefas

### Estudar
- Task
- async/await
- Timer
- CancellationToken
- BackgroundService

---

## Fase 12 — Interface desktop

### Objetivo
Criar uma interface gráfica sem reescrever o núcleo da aplicação.

Tecnologia planejada:

- Avalonia UI
- MVVM
- Data Binding

### Funcionalidades
- [ ] Campo de comando
- [ ] Histórico
- [ ] Lista de rotinas
- [ ] Configurações
- [ ] Gerenciamento de atalhos
- [ ] Status das tarefas

---

## Fase 13 — Versão mobile

### Objetivo
Criar uma interface rápida para Android.

Conceito:

    [ Digite um comando... ]

    .estudo
    .trabalho
    .jogos
    .pc

O aplicativo deverá enviar comandos para o núcleo/serviço responsável pela execução.

### Pontos a estudar
- Comunicação entre aplicativo e backend
- APIs
- Autenticação
- Comunicação local/remota
- Serviços em segundo plano
- Restrições do Android

Observação:
A implementação mobile será planejada quando o núcleo do sistema estiver maduro.

---

## Fase 14 — Voz (OPCIONAL)

### Objetivo
Adicionar voz como uma forma alternativa de entrada.

Fluxo:

    Microfone
        ↓
    Speech-to-Text
        ↓
    Parser
        ↓
    Executor

A voz não será o núcleo do sistema.

### Estudar
- Captura de áudio
- Eventos
- Speech-to-Text
- Whisper.NET
- Vosk

---

## Fase 15 — IA

### Objetivo
Permitir que a assistente compreenda linguagem natural.

Exemplo:

    "Quero começar a estudar."

A IA poderá interpretar:

    intenção = executar rotina
    rotina = estudo

Depois o sistema valida e executa a ação.

### Regra importante
A IA deve interpretar intenções; o executor deve validar e controlar as ações permitidas.

### Estudar
- APIs de IA
- prompts
- function/tool calling
- classificação de intenção
- validação de comandos
- segurança

---

## Fase 16 — Automação avançada

### Objetivo
Expandir o controle do computador.

### Possibilidades
- [ ] Abrir vários aplicativos
- [ ] Fechar processos
- [ ] Controlar volume
- [ ] Consultar CPU
- [ ] Consultar RAM
- [ ] Tirar screenshots
- [ ] Bloquear computador
- [ ] Desligar computador
- [ ] Reiniciar computador
- [ ] Executar scripts
- [ ] Monitorar processos
- [ ] Criar automações complexas

---

# 4. Arquitetura planejada

## Início

O projeto começa simples:

    Nah.Console
    ├── Commands
    ├── Models
    ├── Services
    ├── Resources
    ├── Utils
    ├── Program.cs
    └── README.md

## Futuro

Quando houver necessidade real:

    Nah
    ├── Nah.Console
    ├── Nah.Core
    ├── Nah.Infrastructure
    ├── Nah.Voice
    ├── Nah.Desktop
    └── Nah.Tests

Não criar projetos ou camadas antecipadamente sem necessidade.

---

# 5. Princípios do projeto

1. Construir uma funcionalidade por vez.
2. Entender o código antes de copiar soluções.
3. Pesquisar documentação oficial antes de procurar soluções prontas.
4. Evitar arquitetura complexa no início.
5. Manter o núcleo independente da interface.
6. Tratar voz como recurso opcional.
7. Priorizar comandos digitados e atalhos configuráveis.
8. Validar ações antes de executá-las.
9. Testar cada funcionalidade antes de avançar.
10. Refatorar e organizar o código depois que as funcionalidades principais estiverem funcionando.

---

# 6. Estado atual

## Fase atual

Fase 2 — Parser de comandos.

## Próximo objetivo

Fazer o sistema transformar:

    abrir vscode

em informações equivalentes a:

    ação = abrir
    alvo = vscode

Depois disso:

Fase 3 → Executor → abrir aplicativos.

---

# 7. Tecnologias planejadas

### Base
- C#
- .NET 9
- VS Code

### Dados
- JSON
- PostgreSQL
- Entity Framework Core
- Npgsql

### APIs
- HttpClient
- REST

### Desktop
- Avalonia UI
- MVVM

### Mobile
- Tecnologia a definir conforme a arquitetura do projeto

### Voz
- Whisper.NET ou Vosk (opcional)

### IA
- API de IA (futura)

### Testes
- xUnit

### Logs
- Serilog
