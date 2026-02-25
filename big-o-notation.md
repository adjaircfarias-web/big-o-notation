# Big O Notation

## O que é Big O?

É uma notação matemática que descreve **como um algoritmo escala** conforme o tamanho do input (n). Não mede performance direta, mas sim a **escalabilidade**.

---

## Complexidade Temporal vs Espacial

| Tipo | O que mede |
|------|------------|
| **Temporal** | Quantas vezes o código é executado (runtime) |
| **Espacial** | Quantidade de memória adicional alocada |

---

## O(1) - Constante

O tempo de execução **não depende** do tamanho do input.

- Acessar primeiro elemento de um array
- Verificar se número é par/impar

**Espacial:** Constante - não importa o tamanho do input

---

## O(log n) - Logarítmico

O(log₂ n)

Cada dobrada no input aumenta o tempo em **1 unidade** (não dobra).

Exemplo com Binary Search em array ordenado:
- Array de 10 elementos → ~3 passos (log₂ 10 ≈ 3.32)
- Array de 20 elementos → ~4 passos (log₂ 20 ≈ 4.32)
- Array de 40 elementos → ~5 passos (log₂ 40 ≈ 5.32)

Dobrar o input = +1 no tempo de execução.

---

## O(n) - Linear

Tempo escala **proporcionalmente** ao input.

- Percorrer um array para encontrar maior elemento
- Somar todos os elementos de um array

**Espacial:** O(n) se criar novo array; O(1) se usar variáveis fixas

---

## O(n log n) - Linearítmico

Usado em algoritmos de ordenação (merge sort, quick sort).

Divide o array em partes menores (log n) e ordena cada parte (n).

---

## O(n²) - Quadrático

Loop dentro de loop (nested loops).

```python
for i in array:
    for j in array:
        # executa n * n vezes
```

Exemplo: somar todos os pares de elementos de um array.

---

## Resumo Comparativo

| Notação | Nome | Exemplo |
|---------|------|---------|
| O(1) | Constante | Acessar elemento por índice |
| O(log n) | Logarítmico | Binary Search |
| O(n) | Linear | Percorrer array |
| O(n log n) | Linearítmico | Merge Sort, Quick Sort |
| O(n²) | Quadrático | Bubble Sort, loops aninhados |
