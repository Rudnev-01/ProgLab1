using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;


namespace ProgrLab1
{
    class Program
    {
        static List<State> states = new List<State>();
        static void Main(string[] args)
        {
            
            
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Добавить государство(1)");
                Console.WriteLine("Вывести государства(2)");
                Console.WriteLine("Выход(3)");
                Console.WriteLine("Выберите действие и введите число:");
                switch (Number(1, 3))
                {
                    case 1: Add(); break;
                    case 2: Print(); break;
                    case 3: Environment.Exit(1); break;
                }

            }
           
        }
     
        static void Print()
        {
            if (states.Count() == 0) {
                Console.WriteLine("Список пуст");
                Console.ReadKey();
            } 
            else
            {

                bool b = true;
                foreach (State el in states)
                {
                    if (el is Republic)
                    {
                        if (b == true)
                        {
                            Console.WriteLine("\t\t\t\tРЕСПУБЛИКА");
                            Console.WriteLine("Название\t\t\tНаселение\t\t\tСтолица\t\t\tПрезидент");
                        }
                        b = false;
                        el.Get();
                    }
                }
                if (b == false) Console.WriteLine("\n\n");
                b = true;
                foreach (State el in states)
                {
                    if (el is Monarchy)
                    {
                        if (b == true)
                        {
                            Console.WriteLine("\t\t\t\tМОНАРХИЯ");
                            Console.WriteLine("Название\t\t\tНаселение\t\t\tСтолица\t\t\tИмператор");
                        }
                        b = false;
                        el.Get();
                    }
                }
                if (b == false) Console.WriteLine("\n\n");
                b = true;
                foreach (State el in states)
                {
                    if (el is Kingdom)
                    {
                        if (b == true)
                        {
                            Console.WriteLine("\t\t\t\tКРОРЛЕВСТВО");
                            Console.WriteLine("Название\t\t\tНаселение\t\t\tСтолица\t\\ttКороль");
                        }
                        b = false;
                        el.Get();
                    }
                }


                Console.Write("\n\n\n\n\n\nНажмите любую клавишу для продолжения");    
                Console.ReadKey();
            }
        }
        static void Add()
        {
            Console.WriteLine("Какое государство вы хотите добавить ?");
            Console.WriteLine("Республика(1)");
            Console.WriteLine("Монархия(2)");
            Console.WriteLine("Королевство(3)");
            Console.WriteLine("Выберите действие и введите число:");
            int q = Number(1,3);

            Console.WriteLine("Введите название:");
            string name = Console.ReadLine();

            Console.WriteLine("Введите население:");
            int population;
            string input;
            do
            {
                input = Console.ReadLine();
                if (!Int32.TryParse(input, out population) || (population < 1)) Console.WriteLine("Некорректный ввод");

            } while (!Int32.TryParse(input, out population) || (population < 1));

            Console.WriteLine("Введите столицу:");
            string capital = Console.ReadLine();
            switch (q)
            {
                case 1:
                    
                    Console.WriteLine("Введите президента:");
                    string president= Console.ReadLine();
                    states.Add(new Republic(name, population, capital, president));


                    break;
                case 2:
                    Console.WriteLine("Введите императора:");
                    string emperor = Console.ReadLine();
                    states.Add(new Monarchy(name, population, capital, emperor));


                    break;
                case 3:
                    Console.WriteLine("Введите короля/королеву:");
                    string king = Console.ReadLine();
                    states.Add(new Kingdom(name, population, capital, king));


                    break;
            }

        }
        static int Number(int a, int b)
        {
            int x;
            string input;
            do
            {
                
                input = Console.ReadLine();
                if (!Int32.TryParse(input, out x) || (x < a)||(x>b)) Console.WriteLine("Некорректный ввод");
                
                
            } while (!Int32.TryParse(input, out x) || (x < a) || (x > b));

            return x;
        }
    }
}
