# observer-dotnet-example
Uso do padrão de projetos Observer usando as interfaces IObserver&lt;T> e IObservable&lt;T>

O Padrão de Projetos Observer cria uma relação de dependência entre 1 x N objetos, de forma que quando há uma mudança no estado de um objeto todos os demais são notificados. Isto é interessante em cenários baseados em push notifications para manter objetos informados quando algo de interessante ocorre no sistema.

Neste repositório há um exemplo do padrão Observer utilizando as interfaces IObserver<T> e IObservable<T> disponíveis na plataforma .NET, seguindo o exemplo disponível na documentação da Microsoft. No nosso cenário, iremos manter nossos objetos informados com mensagens que possuem um título e conteúdo, simulando o disparo de notificações em um sistema real. 

Podemos abstrair a implementação em 5 passos:

    1. Implemente a classe que tem informações de interesse dos observadores
    2. Implemente o provedor de notificações usando a interface IObservable<T> onde T é a classe que contém informações de interesse dos observadores e deve retornar uma instância de unsubscriber
    3. Implemente uma classe unsubscriber que implemente a interface IDisposable
    4. Implemente os observadores através da interface IObserver<T>
    5. Instancie o provedor, o observerdador e experimente alterar o estado do objeto para emitir notificações
