using System;

namespace Java_Csharp_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] listPr = new Product[6];
            listPr[0] = new Book(1, "BookA", 10000, "ProdA");
            listPr[1] = new Book(2, "BookB", 20000, "ProdB");
            listPr[2] = new Book(3, "BookC", 30000, "ProdC");
            listPr[3] = new MobilePhone(4, "Mobi1", 50000, "ProdD");
            listPr[4] = new MobilePhone(5, "Mobi2", 60000, "ProdE");
            listPr[5] = new MobilePhone(6, "Mobi3", 70000, "ProdF");

            //ComputeTotalTax Book
            double taxBook = 0;
            for (int i = 0; i <= 2; i++)
            {
                taxBook += listPr[i].computeTax();
            }

            //ComputeTotalTax Mobilephone
            double taxMobilePhone = 0;
            for (int i = 3; i <= 5; i++)
            {
                taxMobilePhone += listPr[i].computeTax();
            }

            double computeTotaltax = 0;
            for (int i = 0; i < listPr.Length; i++)
            {
                computeTotaltax += listPr[i].computeTax();
            }

            Console.WriteLine("Total tax of Book: " + taxBook);
            Console.WriteLine("Total tax of MobilePhone: " + taxMobilePhone);
            Console.WriteLine("Total tax : " + computeTotaltax);

        }
    }
}