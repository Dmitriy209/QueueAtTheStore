using System;
using System.Collections.Generic;
using System.Data.SqlTypes;

namespace QueueAtTheStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queueClients = CreateQueue();

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

        private static Queue<int> CreateQueue()
        {
            Random random = new Random();

            Queue<int> queue = new Queue<int>();

            int minLimitRandom = 10;
            int maxLimitRandom = 10001;

            int queueLimit = 10;

            for (int i = 0; i < queueLimit; i++)
            {
                int purchaseAmount = random.Next(minLimitRandom, maxLimitRandom);
                queue.Enqueue(purchaseAmount);
            }

            return queue;
        }
    }
}
