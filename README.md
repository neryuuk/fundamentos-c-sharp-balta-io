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

## .NET Framework

- Versões `1.0`, `1.1`, `2.0`, `3.0`, `3.5`, `4.x` (mais recente)
- Pode ser instalado _side-by-side_
- Windows only
- Legado

## .NET Core

- Versão mais moderna
- Suporte a linux/unix/mac
- Primeiras versões continham apenas o essencial/_core_
- Totalmente reescrito
- Ótima retro-compatibilidade
- Muita estabilidade na versão 3.1
- Versões `1.0`, `1.1`, `2.0`, `2.1`, `3.0`, `3.1`
- _side-by-side_

## .NET Standard

- .NET Framework e .NET Core coexistem
  - Podem rodar juntos e no mesmo projeto
- .NET standard garante o funcionamento e compatibilidade dos dois
- .NET Standard não é um framework, é um _contrato_
  - Também chamado de _Surface API_
- Intersecção entre os frameworks

## .NET 5

- Futuro do .NET
- Unificação dos Frameworks
  - `.NET Core`
  - `.NET Framework`
- `.NET Core` alcançou o `.NET Framework`

## LTS

- _Long Term Support_
  - `.NET Framework` ~ não tinha release programado
  - `.NET Core` ~ lançamentos semestrais
  - `.NET 5` em diante ~ lançamentos anuais
- Use sempre `LTS` em `prod`

## Versionamento

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

## Runtime e SDK

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
