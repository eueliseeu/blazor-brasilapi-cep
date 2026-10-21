# Consulta de CEP com Blazor WebAssembly

Aplicação web simples que consulta endereços pelo CEP usando a [BrasilAPI](https://brasilapi.com.br/docs#tag/CEP).

## Como funciona

1. O usuário digita o CEP (com ou sem hífen).
2. A aplicação valida se o CEP tem 8 dígitos.
3. A consulta é feita na BrasilAPI.
4. O endereço é exibido na tela, com os dados do IBGE.

## API utilizada

```
GET https://brasilapi.com.br/api/cep/v1/{cep}
```

Não precisa de chave de API nem de cadastro.

## Tecnologias

- .NET 10
- Blazor WebAssembly
- C#
- Bootstrap

## Estrutura do projeto

```
Domain/           Entidades e regras de negócio (Address, PostalCode)
Application/      Caso de uso e contratos (SearchAddressUseCase, IAddressGateway)
Infrastructure/   Comunicação com a BrasilAPI
Pages/            Páginas Blazor
Components/       Componentes reutilizáveis (AddressCard)
Program.cs        Configuração e injeção de dependências
```

## Pré-requisitos

- [.NET SDK 10](https://dotnet.microsoft.com/download)

## Como executar

```bash
git clone <url-do-repositorio>
cd BlazorWasmBrasilApiCep
dotnet run
```

Abra no navegador o endereço exibido no terminal (por exemplo, `http://localhost:5062`) e consulte um CEP, como `30130000`.

## Exemplo de resposta da API

```json
{
  "cep": "30130000",
  "state": "MG",
  "city": "Belo Horizonte",
  "neighborhood": "Centro",
  "street": "Avenida Afonso Pena",
  "service": "open-cep",
  "ibge": {
    "city": "3106200",
    "state": "31"
  }
}
```

### Autores

- Eliseu Pereira da Silva RA: 124220479
