using System;

namespace Lab_4_3 
{
    class Program
    {
        private const string PRO_LICENSE = "2000";
        private const string EXP_LICENSE = "1984";

        static void Main(string[] args)
        {

            Console.WriteLine("Enter the key:");
            var license = Console.ReadLine();


            DocumentWorker worker;
            switch (license)
            {
                case PRO_LICENSE: worker = new ProDocumentWorker(); break;
                case EXP_LICENSE: worker = new ExpertDocumentWorker(); break;
                default: worker = new DocumentWorker(); break;
            }


            while (true)
            {
                Console.WriteLine("Enter the command (open/edit/save/quit): ");
                switch (Console.ReadLine())
                {
                    case "open": worker.OpenDocument(); break;
                    case "edit": worker.EditDocument(); break;
                    case "save": worker.SaveDocument(); break;
                    case "quit": return;
                }
            }
        }
    }
}