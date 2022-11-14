using Lab_4_3;
using System;

namespace Lab_4_3 
{
    class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("The document is saved in a new format");
        }
    }
}