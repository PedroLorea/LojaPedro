# Loja Pedro

![TelaInicial](https://github.com/PedroLorea/LojaPedro/assets/101357140/00728414-db2d-4254-b4ea-a24b325a9d2b)


# Objetivo
O objetivo do programa é fornecer um sistema CRUD para um estoque de produtos que possuem categorias, ou seja, tanto Produtos quanto Categorias tem as funcionalidades: Detalhes, Criar, Editar e Remover

# Tecnologias Utilizadas
A Loja Pedro foi desenvolvida na linguagem de programação C#, em cima do framework ASP.NET. 
Para realizar a persistência foi utilizado o framework Entity, utilizando os pacotes AutoMapper e Mediator para fazer 

Foi desenvolvido com a abordagem DDD (Domain Drive Design), criando o programa a partir do projeto Domínio e pensando a partir das Entidades. As Entidades elas possuem um sistema de validação, garantindo que as informações inseridas estão de acordo com a regra de negócio. E os testes unitários foram desenvolvidos para garantir que estão funcionando as validações do Domínio.

A solução conta com 6 projetos: Domain, Domain.Tests, Application, Infra.Data, Infra.IoC e WebUI

OBS: Foi utilizado o padrão arquitetural CQRS para realizar a persistência, pela complexidade desse projeto não faz sentido, foi apenas usado por questões de aprendizagem.



# Funcionalidades

### Tela Sobre
![TelaSobre](https://github.com/PedroLorea/LojaPedro/assets/101357140/fb36798d-d276-4bce-857d-ad7bc5e07440)


### Tela Categorias
![TelaCategorias](https://github.com/PedroLorea/LojaPedro/assets/101357140/37d864ec-cfd4-48eb-9f1f-d2836bd8ca1a)


### Tela Produtos
![TelaProdutos](https://github.com/PedroLorea/LojaPedro/assets/101357140/363b90c5-1680-45fe-9144-eef56681c39c)


### Tela Detalhes (Imagem Disponível)
<img src="https://github.com/PedroLorea/LojaPedro/assets/101357140/32602763-ad89-448b-b303-81a38821347c" alt="Tela Detalhesm">


### Tela Detalhes (Imagem Indisponível)
![TelaDetalhesProduto](https://github.com/PedroLorea/LojaPedro/assets/101357140/c1d0f89b-1014-468b-8cbf-b519a7cc88f2)


### Tela Criar
![TelaCriarProduto](https://github.com/PedroLorea/LojaPedro/assets/101357140/e2f82aaa-4d15-4816-8343-d48e69165712)


### Tela Editar
![TelaEditarProduto](https://github.com/PedroLorea/LojaPedro/assets/101357140/3d76d8a5-d583-4311-b95f-bc748ba3cb31)


### Tela Remover
![TelaRemover](https://github.com/PedroLorea/LojaPedro/assets/101357140/6ff8383a-e742-4648-bbac-481fead51683)
