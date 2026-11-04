using CarDealership.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealership.Domain.Observers
{
    public class OrderStatusNotifier
    {
        private readonly List<IOrderObserver> _observers = new();

        public void Subscribe(IOrderObserver observer)
        {
            if (observer == null)
                throw new ArgumentNullException(nameof(observer));

            if (!_observers.Contains(observer))
                _observers.Add(observer);
        }

        public void Unsubscribe(IOrderObserver observer)
        {
            if (observer != null)
                _observers.Remove(observer);
        }

        public void Notify(string orderId, string status)
        {
            foreach (var observer in _observers)
            {
                observer.OnOrderStatusChanged(orderId, status);
            }
        }
    }
}
