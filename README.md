# Fundamentos do C#

## C#

### Definições

- Linguagem
  - Tipada (Fortemente)
  - Compilada
  - Gerenciada
- Por que?
  - Completa
  - Madura
  - Mercado corporativo
  - Comunidade (Popular)
  - Aplicabilidade vasta
  - MS por trás
  - O. O.

### Como funciona?

- Tipada
- Compilada
- Gerenciada

### Código Gerenciado

- Sua execução depende de um gerenciador
- Também conhecido como _runtime_
  - CLR ~ _Common Language Runtime_
- Gerencia memória, segurança, entre outros
  - Permite interagir manualmente pouco ou quase nada com recursos da máquina

### Compilação e Gerenciamento

- Gerenciador comum entre as múltiplas linguagens da MS
- Compiladores separados
- Compilação inicial gera um IL
  - Linguagem intermediária ou _intermediate language_

### Intermediate Language

- Compilações distintas
  - Gerenciamento igual
  - Alocação de memória
  - Execução de instruções
- CLR recebe um código (C#, VB.NET, F#) e compila para IL
  - Podemos ter mais de uma linguagem no mesmo projeto
- JIT ~ _Just In Time_
  - Processo de conversão da IL para binário

## Frameworks

- Alicerce
  - Conjunto de bibliotecas
- Base para construir aplicações
  - Não fazer tudo do zero / reinventar a roda
- Validados e testados
- `.NET`

### .NET Framework

- Versões `1.0`, `1.1`, `2.0`, `3.0`, `3.5`, `4.x` (mais 'recente')
- Pode ser instalado _side-by-side_
- Windows only
- Legado

### .NET Core

- Versão mais moderna
- Suporte a linux/unix/mac
- Primeiras versões continham apenas o essencial/_core_
- Totalmente reescrito
- Ótima retro-compatibilidade
- Muita estabilidade na versão 3.1
- Versões `1.0`, `1.1`, `2.0`, `2.1`, `3.0`, `3.1`
- _side-by-side_

### .NET Standard

- .NET Framework e .NET Core coexistem
  - Podem rodar juntos e no mesmo projeto
- .NET standard garante o funcionamento e compatibilidade dos dois
- .NET Standard não é um framework, é um _contrato_
  - Também chamado de _Surface API_
- Intersecção entre os frameworks

### .NET 5

- Futuro do .NET
- Unificação dos Frameworks
  - `.NET Core`
  - `.NET Framework`
- `.NET Core` alcançou o `.NET Framework`

### LTS

- _Long Term Support_
  - `.NET Framework` ~ não tinha release programado
  - `.NET Core` ~ lançamentos semestrais
  - `.NET 5` em diante ~ lançamentos anuais
- Use sempre `LTS` em `prod`

### Versionamento

- Versão Semântica
- Fases
  - Alpha
    - Muito ainda pode mudar
  - Beta
    - Já tem uma ideia estruturada
    - Ainda pode mudar
  - Release Candidate
    - Candidato a versão final
  - Final
- Divisões
  - `Major.Minor.Patch` ~ `1.2.3`
  - `Major`
    - Pode conter _breaking changes_
  - `Minor`
    - Deve ser _backwards compatible_
  - `Patch`
    - Bugfixes e hotfixes

### Runtime e SDK

- Runtime
  - Gerenciamento da aplicação
  - Necessário para executar as aplicações
  - Divididos em 3
    - ASP.NET para Web
    - WPF, WinForms para Desktop
    - .NET Core para console / batch / serviço
  - Usado apenas para distribuição
- SDK ~ _Software Development Kip_
  - Possui as ferramentas para desenvolvimento das aplicações
  - Possui runtime integrado
  - Não utilizar em produção

## .NET

### Instalação

> - https://balta.io/blog/dotnet-instalacao-configuracao-e-primeiros-passos

### dotnet-cli

- _Command Line Interface_
  - Interface via terminal / linha de comando
- `dotnet --version` ~ versão atual
- `dotnet --list-sdks` ~ lista as versões do SDK instaladas
- `dotnet --list-runtimes` ~ lista as versões da runtime instaladas

### Tipos de projetos

- Class Library
  - Produz um `.dll`
  - Sem interface visual
  - `dotnet new classlib`
- Console
  - Produz uma aplicação de terminal
  - Pode receber input do usuário
  - `dotnet new console`
- Projeto Web
  - ASP.NET Web
    - `dotnet new web`
  - ASP.NET MVC
    - `dotnet new mvc`
  - ASP.NET WebAPI
    - `dotnet new webapi`
- Projeto Testes
  - Microsoft Tests
    - `dotnet new mstest`

```PowerShell
dotnet new console --framework "netcoreapp3.1" -o MeuApp
```

> - `--framework "netcoreapp3.1"` ~ Define o framework a ser utilizado no projeto em questão
> - `-o MeuApp` ~ Cria na pasta MeuApp ao inves de criar na pasta local
> - https://learn.microsoft.com/en-us/dotnet/standard/net-standard

### Fluxo de execução

```PowerShell
dotnet restore
```

> - `dotnet restore` ~ Valida e instala as dependências adicionais com base no `.csproj`

---

```PowerShell
dotnet build
```

> - `dotnet build` ~ Compila a aplicação

---

```PowerShell
dotnet clean
```

> - `dotnet clean` ~ Limpa o cache da aplicação

---

```PowerShell
dotnet run
```

> - `dotnet run` ~ Executa a aplicação

### Variáveis de ambiente

- Podemos passar ao .NET qual ambiente estamos rodando
  - `dotnet run --environment=$AMBIENTE`
  - `dotnet run --environment=development`
  - `dotnet run --environment=production`
  - O `run` não executa depuração (debug)

### Estrutura do Console App

- `.csproj` ~ XML de definição do projeto
- `Program.cs` ~ Porta de entrada da aplicação

## Linguagem de Programação com C#

### Escopo de um programa

- Importações
- Namespace
- Classe
- Método principal

### Namespace

- Divisões lógicas da aplicação
- Nomes de classes são únicos dentro do namespace
- Pode ser reutilizado entre vários arquivos e classes
- Nomes devem ser `UpperCamelCase` e sem caracteres especiais
- Um namespace dentro do outro, usando `.`
  - `MeuApp.Teste`
- Costumam acompanhar os nomes das pastas

### Importações (`using`)

- Bibliotecas e namespaces que o programa vai usar
- Via de regra, feitas no topo do arquivo

### Variáveis

- Espaço de armazenamento de uma informação que pode variar
- Pode ser definida com o tipo ou com a palavra reservada `var`
- O tipo precede o nome da variável
- Utilize nomes coesos
- Nomes devem ser `lowerCamelCase` e sem caracteres especiais

### Constantes

- Espaço de armazenamento de valor que não pode ser alterado depois
- Já deve ser instanciada com o valor
- Nomes maiúsculos separados com `_`

### Palavras Reservadas

- Palavras-chave que não devem ser usadas como nomes de variáveis, constantes, classes, métodos, etc

### Comentários

- Uma linha `// Uma linha`
- Multi-linhas `/* Multi-linhas */`
- XML `/// <?xml?>`

### Tipos Primitivos

- built-in types
- Tipos base que serão derivados em tipos complexos
- Tipos de valor ~ _Value Types_
  - Armazenam o valor e não a referência para o item na memória
- Classificados em
  - Tipos Simples ~ _Simple Types_
  - Enumeradores ~ _Enums_
  - Estruturas ~ _Structs_
  - Tipos Nulos ~ _Nullable Types_
- Cada tipo primitivo possui uma capacidade

#### System

- No `.NET`, todos os tipos derivam do `System`

#### Byte

- Usado para representar um byte de fato
  - 8-bit ~ `0` à `255`
- Arquivos ou streams costumam ser cadeias de bytes (byte array)
- sbyte ~ `signed byte`
  - Permite valores negativos
  - 8-bit ~ `-128` à `127`

#### Números inteiros

- short ~ `16-bit`
  - ushort ~ `unsigned short`
- int ~ `32-bit`
  - uint ~ `unsigned int`
- long ~ `64-bit`
  - ulong ~ `unsigned long`

#### Números reais

- float ~ Notação F
  - 32-bit
- double
  - 64-bit
- decimal ~ Notação M
  - 128-bit

```csharp
float salario = 2500.25F; // Notação F
double tarifa = 125.95; // Padrão
decimal preco = 1923.75M; // Notação M
```

---

#### Boolean

- Armazena `True` ou `False`
- `bool` ~ 8-bit

#### Char

- Armazena um caractere `unicode`
- Definido com 'aspas simples'
- `char` ~ 16-bit

#### String

- Cadeia / lista de caracteres
- Definido com "aspas duplas"
- string ~ Tamanho alocado depende do conteúdo
