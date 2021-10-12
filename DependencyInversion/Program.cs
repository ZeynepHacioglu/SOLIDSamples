using System;

namespace DependencyInversion
{
    class Program
    {
        /*
         * Küçük bir sistem değişikliği, kendisine bağlı çalışan nesneyi de değiştirmeyi gerektiriyorsa prensibi ihlal ediyorsunuz.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            bool isAccepted = true;
            bool isAvailable = true;

            if (checkRule(isAccepted, isAvailable))
            {

            }

        }

        private static bool checkRule(bool isAccepted, bool isAvailable)
        {
            return !(isAccepted || isAvailable);
        }
    }

    public interface ISender
    {
        void Send();
    }
    public class Report
    {
        private ISender _sender;

        public Report(ISender sender)
        {
            _sender = sender;
        }
        public void Send()
        {
          
            _sender.Send();
        }
    }

    public class MailSender : ISender
    {
        public void Send()
        {
            Console.WriteLine("Mail gönderildi");
        }
    }
}
