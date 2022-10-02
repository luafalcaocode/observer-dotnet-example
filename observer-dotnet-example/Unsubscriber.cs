using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer_dotnet_example
{
    public class Unsubscriber<Message> : IDisposable
    {
        private List<IObserver<Message>> observers;
        private IObserver<Message> observer;

        public Unsubscriber(List<IObserver<Message>> observers, IObserver<Message> observer)
        {
            this.observers = observers;
            this.observer = observer;
        }

        public void Dispose()
        {
            if (this.observers.Contains(this.observer))
            {
                this.observers.Remove(this.observer);
            }
        }
    }
}
