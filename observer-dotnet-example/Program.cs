using System;

namespace observer_dotnet_example
{
    class Program
    {
        static void Main(string[] args)
        {
            var subject = new NotificationProvider();

            subject.SetState("Saudações", "Bem-vindo ao mundo dos Padrões de Projeto. Este é o Observer!");
            subject.SetState("Definição", "O padrão observer cria uma relação 1 x N entre objetos e emite notificações quando algo interessante acontece.");

            var observerOne = new NotificationObserverOne();

            observerOne.Subscribe(subject);

            subject.SetState("Dica", "Mantenha seus objectos informados quando algo interessante acontece usando o padrão Observer!");
            subject.SetState("Fonte", "Este exemplo foi baseado no artigo da Microsoft sobre o padrão Observer");

            observerOne.Unsubscribe();

            subject.SetState("Ops!", "Não há observeadores para receber esta notificação.");

            Console.ReadKey();
        }
    }
}
