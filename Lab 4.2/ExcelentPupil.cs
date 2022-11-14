using System;

namespace Lab_4_2 
{
    class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("ExcelentPupil: Study-excelent");
        }
        public override void Read()
        {
            Console.WriteLine("ExcelentPupil: Read-excelent");
        }
        public override void Write()
        {
            Console.WriteLine("ExcelentPupil: Write-excelent");
        }
        public override void Relax()
        {
            Console.WriteLine("ExcelentPupil: Relax-excelent");
        }

    }
}