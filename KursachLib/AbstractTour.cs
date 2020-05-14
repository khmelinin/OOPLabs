using System;
using System.IO;

namespace KursachLib
{
    public abstract class AbstractTour:IPrint
    {
        protected string destination;
        protected string theme;
        protected double price;
        protected DateTime date;
        protected string addition= @"C:\Users\AdmiN\source\repos\khmelinin\OOPLabs\Kursach\bin\Debug\netcoreapp3.1\logs";
        

        protected AbstractTour(string destination, string theme, double price, DateTime date)
        {
            this.destination = destination;
            this.theme = theme;
            try
            {
                if (price >= 0)
                    this.price = price;
                else
                    throw new Exception("price can't be "+price.ToString()+", installed default price = 7777777");
            }
            catch(Exception e)
            {
                
                Directory.CreateDirectory(addition);
                string path = addition+@"\log_" + DateTime.Now.Year.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Day.ToString() + ".log";
                StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default);
                sw.WriteLine(e.Message+"   "+DateTime.Now.TimeOfDay);
                sw.Close();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.ResetColor();
                this.price = 7777777;
            }

            
            this.date = date;
        }

        public abstract void Print();
    }
}
