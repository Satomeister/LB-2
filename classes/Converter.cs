using System;
using System.Collections.Generic;
using System.Text;

namespace LB_2.classes
{
    class Converter
    {
        double usd;
        double eur;
        double rub;
        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }

        public void convertFromUAH()
        {
            Console.WriteLine("Кiлькiсть гривень");
            double uan = Convert.ToDouble(Console.ReadLine());

            double rub = uan * this.rub;
            double eur = uan * this.eur;
            double usd = uan * this.usd;
            Console.WriteLine($"{uan} гривень = {rub} рублiв, {eur} євро, {usd} доларiв");
        }

        public void convertToUAH()
        {
            Console.Write(
                "Iз якої валюти конвертувати:\n" +
                "1.RUB\n" +
                "2.USD\n" +
                "3.EUR\n" +
                "--> ");
            int from = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Скiльки");
            double num = Convert.ToDouble(Console.ReadLine());

            double uan;
            switch (from)
            {
                case 1:
                    /*рублі*/
                    {
                        uan = num / this.rub;
                        Console.WriteLine($"{num} рублiв = {uan} гривень");
                    }
                    break;
                case 2:
                    /*долари*/
                    {
                        uan = num / this.usd;
                        Console.WriteLine($"{num} долларiв = {uan} гривень");
                    }
                    break;
                case 3:
                    /*євро*/
                    {
                        uan = num / this.eur;
                        Console.WriteLine($"{num} євро = {uan} гривень");
                    }
                    break;
            }
        }
    }
}
