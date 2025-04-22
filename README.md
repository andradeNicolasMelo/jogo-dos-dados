# 🎲 Jogo de Corrida de Dados
![](https://imgur.com/iQImTVM.gif)

Um jogo simples e interativo em que o jogador compete contra o computador em uma corrida virtual, utilizando dados virtuais (números aleatórios). O primeiro a alcançar ou ultrapassar a linha de chegada vence!

---

## 🚀 Objetivo

Ambos os competidores (jogador e computador) avançam em uma pista representada por uma linha numérica. Cada turno, um dado virtual é lançado (número aleatório entre 1 e 6), e a posição do competidor é atualizada de acordo com o valor sorteado. O primeiro a chegar ao final da pista é o vencedor.

---

## 📌 Regras e Funcionalidades

### 🛤️ Pista
- Representada por uma linha de posições (ex: de 0 a 30).
- Jogador e computador começam na posição 0.

### 🔁 Turnos
- O jogador e o computador se alternam em rodadas.
- Cada rodada envolve o lançamento de um dado (número entre 1 e 6).
- O valor gerado é somado à posição atual do competidor.
- A posição atual de ambos é exibida após cada turno.

### 🏁 Condição de Vitória
- O primeiro a alcançar ou ultrapassar a posição 30 vence o jogo.

### 🕹️ Interação
- O jogador pressiona **Enter** para rolar o dado.
- O computador joga automaticamente no seu turno.

---

## 🎯 Eventos Especiais

Para tornar o jogo mais dinâmico, certas posições da pista possuem efeitos:

- **Avanço extra:** ao cair nas posições 5, 10 ou 15 → avança +3 casas.
- **Recuo:** ao cair nas posições 7, 13 ou 20 → recua -2 casas.
- **Rodada extra:** ao tirar 6 no dado → ganha um novo turno imediato.

---

## 🧠 Conceitos Aplicados

- Geração de números aleatórios
- Estruturas de repetição e condicionais
- Lógica de turnos
- Interação com o usuário via teclado
- Manipulação de estados de jogo
- Utilização de Métodos

---

## 🆕 Implementação Adicional

### 🗺️ Mapeamento de Caminhos

Foi adicionada uma funcionalidade extra que não estava prevista nos requisitos originais:

- **Dois mapas visuais separados** foram criados:
  - Um para exibir o **caminho percorrido pelo jogador**
  - Outro para exibir o **caminho percorrido pelo computador**

Essa melhoria permite visualizar claramente o progresso de cada competidor ao longo da corrida, enriquecendo a experiência do usuário.

---

## 📌 Status

✅ Concluído.
🚧 Melhorias visuais.

---

Desenvolvido como exercício prático de lógica de programação e manipulação de estruturas em C#.
