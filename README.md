# Sistema de Pedidos - Exercício de Fixação (Enum e Composição)

Este projeto é um exercício de fixação proposto em um curso de C#, focado na prática dos conceitos de **enumerações (enum)** e **composição de classes**. 
O objetivo foi criar um sistema simples de pedidos com clientes, produtos e itens de pedido, usando boas práticas de programação orientada a objetos.

## 📚 Conceitos Utilizados

- Classes e Objetos
- Construtores
- Encapsulamento
- Enumerações (`enum`)
- Composição (uma classe contendo instâncias de outras)
- Listas (`List<T>`)
- Sobrescrita do método `ToString()`
- Entrada de dados pelo console

## 🛠️ Estrutura do Projeto

O projeto possui as seguintes classes principais:

- `Client`: Armazena os dados do cliente (nome, email, data de nascimento).
- `Product`: Representa o produto com nome e preço.
- `OrderItem`: Representa um item do pedido com quantidade, preço e um produto.
- `Order`: Contém os dados do pedido (cliente, status, data, itens).
- `OrderStatus`: Enumeração que define os status possíveis de um pedido (`PendingPayment`, `Processing`, `Shipped`, `Delivered`).

## 💡 Como Funciona

1. O usuário informa os dados do cliente.
2. Em seguida, informa os dados do pedido (status e itens).
3. Para cada item, são coletados: nome do produto, preço e quantidade.
4. O sistema cria os objetos necessários, calcula os subtotais e o total do pedido.
5. Ao final, exibe um resumo com todos os dados.

## ▶️ Execução

Para executar o projeto:

```bash
dotnet run
