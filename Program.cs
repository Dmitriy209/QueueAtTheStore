using System;
using System.Collections.Generic;

namespace QueueAtTheStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> purchaseAmount = new List<int> { 250, 5163, 1248, 9803, 25, 146, 347, 513, 168, 790, 1524, 796 };
            Queue<int> queueClients = new Queue<int>(purchaseAmount);

            int wallet = 0;

            while (queueClients.Count > 0)
            {
                Console.WriteLine("Нажмите любую клавишу, чтобы продолжить принимать клиентов.");
                Console.ReadKey();

                Console.Clear();

                wallet += ServesTheClient(queueClients);
                Console.WriteLine($"Ваш счёт: {wallet}");
            }

            Console.Clear();
            Console.WriteLine($"Очередь закончилась, можно закрываться.\n" +
                $"Вы заработали: {wallet}");
        }

        private static int ServesTheClient(Queue<int> queueClients)
        {
            int purchaseAmount = queueClients.Dequeue();

            Console.WriteLine($"Клиент оплатил: {purchaseAmount}");

            return purchaseAmount;
        }
    }
}
