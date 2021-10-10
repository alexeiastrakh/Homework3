using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{

    class Converter
    {
        public double usd;
        public double eur;

        public Converter(double usd, double eur)
        {
            this.usd = usd;
            this.eur = eur;
        }
        public double FromUahToEur(double uah)
        {
            return uah / eur;
        }

        public double FromUahToUsd(double uah)
        {
            return uah / usd;
        }

        public double FromEurToUah(double uah)
        {
            return eur * uah;
        }
        public double FromUsdToUah(double uah)
        {
            return usd * uah;
        }
    }

    class Program
    {


        static void Main(string[] args)
        {

            Converter converter = new Converter(26.33, 30.47);

            Console.WriteLine("what currency do you want to convert");
            string From = Console.ReadLine();
            Console.WriteLine("how much do you want to convert");
            string A = Console.ReadLine();
            double x = Convert.ToDouble(A);



            if (From == "FromUahToEur")
            {
                Console.WriteLine(converter.FromUahToEur(x));
            }

            if (From == "FromUahToUsd")
            {
                Console.WriteLine(converter.FromUahToUsd(x));
            }

            if (From == "FromEurToUah")
            {
                Console.WriteLine(converter.FromEurToUah(x));
            }

            if (From == "FromUsdToUah")
            {
                Console.WriteLine(converter.FromUsdToUah(x));
            }

            Console.Read();

        }
    }
}