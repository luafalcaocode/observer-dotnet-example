using System;

namespace observer_dotnet_example
{
    public class NotificationObserverOne : IObserver<Message>
    {
        private IDisposable cancellation;

        public virtual void Subscribe(IObservable<Message> provider)
        {
            this.cancellation = provider.Subscribe(this);
        }

        public virtual void Unsubscribe()
        {
            this.cancellation.Dispose();
        }

        public virtual void OnCompleted()
        {
            Console.WriteLine("Não há mais notificações a serem recebidas.");
        }

        public virtual void OnError(Exception exception)
        {
            Console.WriteLine($"Ocorreu o seguinte erro: {exception.Message}");
        }

        public virtual void OnNext(Message message)
        {
            Console.WriteLine(this.ToString() + " observer");
            Console.WriteLine("Recebendo notificações...");
            Console.WriteLine("Título da mensagem: " + message.Title);
            Console.WriteLine("Conteúdo da mensagem: " + message.Content);
            Console.WriteLine();
        }
    }
}
