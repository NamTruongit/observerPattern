using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatterns
{
    public interface ISubject
    {
        public void RegisterObserver(IObserver o);
        public void RemoveObserver(IObserver o);

        public void NotifyObserver();
    }
}
