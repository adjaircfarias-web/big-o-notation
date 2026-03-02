# Entendendo O(n) - Complexidade Linear em Algoritmos

Quando falamos de Big O Notation, o **O(n) - Linear** é talvez o conceito mais intuitivo: o tempo de execução cresce proporcionalmente ao tamanho da entrada.

## O que significa O(n)?

Um algoritmo com complexidade linear significa que, se duplicarmos o tamanho da entrada, o tempo de execução também duplica. É como ler um livro: quanto mais páginas, mais tempo leva para ler.

## Implementação Prática

Recentemente implementei dois exemplos em C# que demonstram essa complexidade:

### Exemplo 1: Encontrar o Maior Elemento

```csharp
int[] numbers = { 10, 25, 30, 45, 50, 60, 70, 80, 90, 100 };

int largest = numbers[0];
for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] > largest)
    {
        largest = numbers[i];
    }
}
```

**Por que é O(n)?** O loop percorre cada elemento exatamente uma vez. Com 10 elementos = 10 operações. Com 100 elementos = 100 operações.

### Exemplo 2: Somar Todos os Elementos

```csharp
int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    sum += numbers[i];
}
```

**Por que é O(n)?** Mesmo princípio - cada elemento precisa ser processado uma vez.

## Comparando com O(1)

Lembra do exemplo O(1) de acessar o maior elemento em um array **ordenado**? Lá, simplesmente acessamos o último índice diretamente. Com O(n), não temos essa vantagem - precisamos verificar cada elemento.

| Tamanho (n) | O(1) | O(n) |
|-------------|------|------|
| 10          | 1    | 10   |
| 100         | 1    | 100  |
| 1.000       | 1    | 1.000|

## Quando usar algoritmos O(n)?

- Quando não há estrutura de dados organizada (array não ordenado)
- Quando precisamos processar todos os dados
- É a complexidade mínima para busca em estruturas não ordenadas

## Conclusão

O(n) é fundamental em ciência da computação. Embora não seja tão eficiente quanto O(1) ou O(log n), é frequentemente a melhor opção quando não temos dados organizados. O importante é entender quando cada complexidade se aplica.

#BigO #Algoritmos #Programação #DesenvolvimentoDeSoftware #CSharp #ComputerScience
