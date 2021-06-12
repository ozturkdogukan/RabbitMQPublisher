using System;

namespace RabbitMQSample
{
    class Program
    {
        private static readonly string _queueName = "DOGUKANOZTURK";
        private static Publisher _publisher;


        static void Main(string[] args)
        {
            string message = "deneme";
            do
            {
                Console.WriteLine("İletmek istediğiniz mesajı giriniz");
                message = Console.ReadLine();
                _publisher = new Publisher(_queueName, message);
            } while (!(message.Equals("q")));
            Console.WriteLine("Bay bay");
        }
    }
}