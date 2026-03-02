# O(n²) - Quadrático

## O que é?

Complexidade quadrática ocorre quando há **loops aninhados** (nested loops), onde cada loop executa `n` vezes. O tempo de execução cresce proporcionalmente ao quadrado do tamanho da entrada.

```
Operações ≈ n × n = n²
```

## Quando ocorre?

- Loop dentro de loop
- Algoritmos de ordenação simples (Bubble Sort, Insertion Sort, Selection Sort)
- Comparar todos os pares de elementos

## Exempl projeto

### Exampleos neste 1: Bubble Sort
Ordena um array comparando elementos adjacentes em pares. O loop externo executa `n` vezes e o interno também executa aproximadamente `n` vezes.

### Example 2: Find All Pairs
Encontra todos os pares possíveis de elementos em um array. O primeiro loop varia de `0` a `n`, e o segundo de `i+1` a `n`.

## Complexidade

| Tamanho (n) | Operações |
|-------------|-----------|
| 10          | 100       |
| 100         | 10,000    |
| 1,000       | 1,000,000 |

## Comparação com outras notações

| Notação | Nome | 10 elementos | 100 elementos |
|---------|------|--------------|---------------|
| O(1)    | Constante | 1 | 1 |
| O(log n) | Logarítmico | 3 | 7 |
| O(n)    | Linear | 10 | 100 |
| O(n²)   | Quadrático | 100 | 10,000 |

## Dica

Evite O(n²) para grandes conjuntos de dados. Prefira algoritmos O(n log n) como Quick Sort ou Merge Sort para ordenação.
