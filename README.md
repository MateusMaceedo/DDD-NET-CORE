#### Exemplos práticos de DDD, conceitos de responsabilidade única.

No mundo da programação e desenvolvimento de software, DDD é a sigla para Domain-Driver-Design, que consiste em um padrão de modelagem para sofwares, cujo objetivo é facilitar a implementação de regras e processos complexos, além da divisão de responsabilidade por camadas.

Alguns modelos de empresas, como as fintechs, utilizam os padrões estratégicos do DDD, já que em alguns casos elas precisam lidar com a modelagem de domínios complexos em um negócio que passa por constantes mudanças. Desta forma, é possível escalar o negócio de maneira sustentável. Para que seja utilizado o DDD, é preciso que todas as partes do processo estejam interligadas, por mais que sejam diferentes, elas precisam conversar entre si para a obtenção satisfatória dos resultados que a empresa deseja.

- NET CORE 5, Entity Framework Core, Docker, IoC com AutoFac e muitas dicas para criar uma arquitetura modelo e totalmente responsável.

Arquitetura de Sistemas Corporativos é um tema muito menos explorado do que Rest Api e nem por isso é menos importante (na verdade é bem mais), Neste vídeo tutorial eu mostrarei como criar uma arquitetura padrão DDD utilizando ASP.NET CORE 3.1, Entity Framework Core, Docker, IoC com AutoFac e muitas dicas para criar uma arquitetura modelo e totalmente responsável.

Domain-Driver Design ou Projeto Orientado a Domínio é um padrão de modelagem de software orientado a objetos que procura reforçar conceitos e boas práticas relacionadas à OO.

Isso vem de contrapartida com o uso comum do Data-Driver Design ou Projetos Orientado a Dados, que a maioria dos desenvolvedores usa sem mesmo ter consciência disso.

#### Data-Driver Development

Já ouvi várias vezes que os dados são a coisa mais importante em uma uma empresa, logo a modelagem deve sempre começar pensando no banco de dados.

Não é nada incomum desenvolvedores .Net, Java, C++ começarem em sistema estabelecendo os tipos que eles não usar e o relacionamento entre eles. Esses tipos geralmente são objetos "burros", com getters e setters, representando nada mais, nada menos, que uma tabela do banco de dados.

O problema com essa abordagem é que ela não faz bom uso dos recursos Orientação a Objetos. Muitos acham que Getters e Setters são oauge do encapsulamento, mas na prática esse métodos permitem ao usuário recuperar e alterar todos os atributos. Não há ganho algum, a não ser muito código desnecessário.

Enfim, muita gente acha que está usando OO, mas as classes poderiam ser facilmente substituídas por registros ou estruturas, de acordo com a linguagem utilizada.

Referências:

- 1 - [DDD - Introdução a Domain Driver Design](http://www.agileandart.com/2010/07/16/ddd-introducao-a-domain-driven-design/)
- 2 - [Coding for Domain-Driven Design: Tips for Data-Focused Devs](http://msdn.microsoft.com/en-us/magazine/dn342868.aspx)
- 3 - [Domain Driven Design Quickly](http://www.infoq.com/minibooks/domain-driven-design-quickly)
