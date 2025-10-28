using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPatterns.src.LLD.DPatterns
{
    public class Observer
    {
        public static void NotMain(string[] args)
        {
            OrderService orderService = new OrderService();
            orderService.RegisterObserver(new InventoryService());
            orderService.RegisterObserver(new ShippingService());
            orderService.PlaceOrder("ORD001");
        }
    }

    public interface IObserver
    {
        void update(string message);
    }

    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void UnregisterObserver(IObserver observer);
        void NotifyObserver(string message);
    }

    public class InventoryService : IObserver
    {
        public void update(string message)
        {
            Logger.Instance.Log($"Inventory Service : {message}");
        }
    }

    public class ShippingService : IObserver
    {
        public void update(string message)
        {
            Logger.Instance.Log($"Shipping Service : {message}");
        }
    }

    public class OrderService : ISubject
    {
        private readonly List<IObserver> _observers = new List<IObserver>();
        public void RegisterObserver(IObserver observer) => _observers.Add(observer);
        public void UnregisterObserver(IObserver observer) => _observers.Remove(observer);

        public void NotifyObserver(string message)
        {
            foreach(var observer in _observers)
            {
                observer.update($"order ID : {message}");
            }
        }

        public void PlaceOrder(string Message)
        {
            NotifyObserver(Message);
        }
    }

}
