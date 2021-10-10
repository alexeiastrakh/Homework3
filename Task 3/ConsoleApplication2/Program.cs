using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2

    class Converter
    {
        private double usd;
        private double eur;


        public Converter(double usd, double eur)
        {
            this.usd = usd;
            this.eur = eur;
        }

        public void HrnToEur(double hrn)
        {
            Console.WriteLine($"{hrn} hrn = {hrn / eur} eur");
        }
        public void HrnToUsd(double hrn)
        {
            Console.WriteLine($"{hrn} hrn = {hrn / usd} usd");
        }
        public void EurToHrn(double eur)
        {
            Console.WriteLine($"{eur} eur = {this.eur * eur} hrn");
        }
        public void UsdToHrn(double usd)
        {
            Console.WriteLine($"{usd} usd = {this.usd * usd} hrn");
        }
    }

    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Exchange rates");
            Converter converter = new Converter(28.29, 33.1);
            converter.HrnToEur(33.1);
            converter.HrnToUsd(28.29);
            Console.WriteLine("write from which currancy to which convert");
            string op = Console.ReadLine();
            Console.WriteLine("write amount of money which you want to convert");
            string a = Console.ReadLine();
            double amount = Convert.ToDouble(a);

            if (amount >= 0)
            {
                if (op == "HrnToEur")
                {
                    converter.HrnToEur(amount);
                }

                if (op == "HrnToUsd")
                {
                    converter.HrnToUsd(amount);
                }

                if (op == "EurToHrn")
                {
                    converter.EurToHrn(amount);
                }

                if (op == "UsdToHrn")
                {
                    converter.UsdToHrn(amount);
                }

                Console.Read();
            }
        }
    }
}