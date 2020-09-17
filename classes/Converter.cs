using System;
using System.Collections.Generic;
using System.Text;

namespace LB_2.classes
{
    class Converter
    {
        double _usd;
        double _eur;
        double _rub;
        public Converter(double usd, double eur, double rub)
        {
            this._usd = usd;
            this._eur = eur;
            this._rub = rub;
        }

        public void convertFromUAH()
        {
            Console.WriteLine("Кiлькiсть гривень");
            double uan = Convert.ToDouble(Console.ReadLine());

            double rub = uan * _rub;
            double eur = uan * _eur;
            double usd = uan * _usd;
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
                        uan = num / _rub;
                        Console.WriteLine($"{num} рублiв = {uan} гривень");
                    }
                    break;
                case 2:
                    /*долари*/
                    {
                        uan = num / _usd;
                        Console.WriteLine($"{num} долларiв = {uan} гривень");
                    }
                    break;
                case 3:
                    /*євро*/
                    {
                        uan = num / _eur;
                        Console.WriteLine($"{num} євро = {uan} гривень");
                    }
                    break;
            }
        }
    }
}
