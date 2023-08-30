# Fundamentos do C#

## Definições

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

## Como funciona?

- Tipada
- Compilada
- Gerenciada

## Código Gerenciado

- Sua execução depende de um gerenciador
- Também conhecido como _runtime_
  - CLR ~ _Common Language Runtime_
- Gerencia memória, segurança, entre outros
  - Permite interagir manualmente pouco ou quase nada com recursos da máquina

## Compilação e Gerenciamento

- Gerenciador comum entre as múltiplas linguagens da MS
- Compiladores separados
- Compilação inicial gera um IL
  - Linguagem intermediária ou _intermediate language_

## Intermediate Language

- Compilações distintas
  - Gerenciamento igual
  - Alocação de memória
  - Execução de instruções
- CLR recebe um código (C#, VB.NET, F#) e compila para IL
  - Podemos ter mais de uma linguagem no mesmo projeto
- JIT ~ _Just In Time_
  - Processo de conversão da IL para binário
