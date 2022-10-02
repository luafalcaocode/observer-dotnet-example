using System;
using System.Collections.Generic;

namespace observer_dotnet_example
{
    public class NotificationProvider : IObservable<Message>
    {
        private List<IObserver<Message>> observers;
        private List<Message> messages;

        public NotificationProvider()
        {
            this.observers = new List<IObserver<Message>>();
            this.messages = new List<Message>();
        }

        public IDisposable Subscribe(IObserver<Message> observer)
        {
            if (!this.observers.Contains(observer))
            {
                this.observers.Add(observer);

                foreach(var message in this.messages)
                {
                    observer.OnNext(message);
                }
            }

            return new Unsubscriber<Message>(observers, observer);
        }

        public void SetState(string title, string content)
        {
            var message = new Message(title, content);

            this.messages.Add(message);

            foreach(var observer in this.observers)
            {
                observer.OnNext(message);
            }
        }

        public void FinalizeChangeOfState()
        {
            foreach(var observer in this.observers)
            {
                observer.OnCompleted();
            }

            this.observers.Clear();
        }
    }
}
