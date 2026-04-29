# 🤖 Robô Tupiniquim (Console - C#)

Este projeto simula um robô que se movimenta em um plano cartesiano (eixos X e Y), recebendo comandos do usuário via console.

---

## 📌 Funcionalidades

- Definir posição inicial do robô (X e Y)
- Definir direção inicial:
  - `N` (Norte)
  - `S` (Sul)
  - `L` (Leste)
  - `O` (Oeste)
- Executar comandos de movimentação:
  - `E` → virar à esquerda
  - `D` → virar à direita
  - `M` → mover para frente
- Exibir posição final do robô

---

## 🧠 Regras de funcionamento

- O robô sempre se move **1 unidade por comando `M`**
- A direção influencia o movimento:
  - `N` → aumenta Y
  - `S` → diminui Y
  - `L` → aumenta X
  - `O` → diminui X
- Os comandos são executados **em sequência**

---

## ✅ Validações implementadas

- Direção inicial aceita apenas: `N`, `S`, `L`, `O`
- Comandos aceitam apenas: `E`, `D`, `M`
- Caso o usuário digite valores inválidos, será solicitado novamente

---

## ▶️ Como executar

1. Abra o projeto no VS Code  
2. Abra o terminal na pasta do projeto  
3. Execute o comando abaixo:


dotnet run


4. Informe:
   - Posição inicial (X e Y)
   - Direção inicial
   - Sequência de comandos

---

## 💻 Exemplo de uso


Digite a posição inicial do Robô no eixo X:
0
Digite a posição inicial do Robô no eixo Y:
0
Digite o sentido inicial do Robô (N, S, L, O):
N
Digite os comandos:
EMMMD


### 📍 Saída esperada


Posição Final:
X = -1
Y = 3
Direção = N


---

## 🧩 Estrutura do código

O projeto foi organizado em métodos para melhor legibilidade:

- `ExecutarComandos()` → processa todos os comandos
- `VirarEsquerda()` → altera direção
- `VirarDireita()` → altera direção
- `Mover()` → atualiza posição

---

## 📚 Tecnologias

- C#
- .NET (Console Application)