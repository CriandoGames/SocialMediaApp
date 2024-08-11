
# Projeto Web API para Plataforma de Rede Social

<p align="center">
<img loading="lazy" src="http://img.shields.io/static/v1?label=STATUS&message=EM%20DESENVOLVIMENTO&color=GREEN&style=for-the-badge"/>
</p>

## Descrição

Este projeto consiste em uma Web API desenvolvida em C# com o intuito de fornecer métodos para uma plataforma de uma rede social. A API terá as funções básicas de uma rede social como conta, perfil, publicações, feed, conexões, mensagens e grupos, utilizando uma arquitetura limpa e diversas tecnologias modernas.

### Abordagem de Desenvolvimento

Com o Entity Framework Core, utilizou-se a abordagem ```Code First```, no qual primeiramente foram definidas as entidades que a aplicação interagiria, para que somente em um segundo momento o banco de dados fosse criado.

## Arquitetura

Foi definido que o projeto segue os princípios da arquitetura limpa, separando as responsabilidades, visando escalabilidade através da facilidade no gerenciamento de mudanças, reutilização de código e integridade de dados.

- **API**: Camada responsável por expor os endpoints da Web API.
- **Application**: Implementa os casos de uso e a lógica de aplicação.
- **Core**: Contém as entidades e interfaces principais do domínio.
- **Infrastructure**: Implementação da infraestrutura, como repositórios e comunicação com o banco de dados.
- **Tests**: Projetos de testes unitários e de integração, garantindo a qualidade e o funcionamento correto da aplicação.

## Tecnologias Utilizadas

O projeto utiliza as seguintes tecnologias e padrões:

- **.NET 8**: Framework principal para o desenvolvimento da aplicação.
- **Padrão Repository**: Padrão que abstrai o acesso aos dados, centralizando as operações em um repositório.
- **Padrão Result**: Padrão que define uma forma explícita e clara de expressar erros no código.
- **JWT**: É um padrão aberto para transmitir dados entre partes de forma segura e compacta através de um objeto JSON.
- **xUnit**: Framework de testes unitários utilizado para garantir a qualidade do código.
- **Entity Framework Core**: ORM (Object-Relational Mapper) utilizado para comunicação com o banco de dados.
- **SQL Server**: Banco de dados relacional.


## MVP - Minimum Viable Product / Produto Mínimo Viável

O projeto está separado em três MVP´s

|  MVP  | Funcionalidades                      |
|------| -----------------------------  | 
|  ✅ | Contas, Perfis, Publicações    |
|  ✅ | Conexões, Feed                 |
|  ❌ | Mensagens, Grupos, Notificação | 


Veja o arquivo do [Mapa mental](https://whimsical.com/rede-social-SXpdtqiTQjNUfzMtYnxzDY) para mais detalhes.


Este README fornece uma visão geral do projeto, tecnologias e arquitetura utilizados.
