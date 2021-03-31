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
        static List<State> states = new List<State>(10);
        static void Main(string[] args)
        {


            while (true)
            {
                Console.Clear();
                Console.WriteLine("Добавить государство(1)");
                Console.WriteLine("Вывести государства(2)");
                Console.WriteLine("Поиск по имени(3)");
                Console.WriteLine("Выход(4)"); 
                Console.Write("Выберите действие и введите число: ");
                switch (Number(1, 4))
                {
                    case 1: Add(); break;
                    case 2: Print(); break;
                    case 3: Search(); break;
                    case 4: Environment.Exit(1); break;
                }

            }

        }
        static void Search()
        {
            bool b = true;
            Console.Write("Введите название: ");
            string word = Console.ReadLine();
            Console.WriteLine("\n");
            foreach (State el in states)
            {
                if (el.IsSearch(word))
                {
                    Console.Write($"{el.Name}\t\t{el.Population}\t\t{el.Capital}\t");
                    if (el is Republic) Console.WriteLine($"\t{((Republic)el).President}");
                    if (el is Monarchy) Console.WriteLine($"\t{((Monarchy)el).Emperor}");
                    if (el is Kingdom) Console.WriteLine($"\t{((Kingdom)el).King}");
                    b = false;
                }
            }


            if (b) Console.WriteLine("Элемент не найден.");
            Console.ReadKey();
        }
        static void Print()
        {
            if (states.Count() == 0)
            {
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
                            Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
                            Console.WriteLine("\t\t\t\t\t\tРЕСПУБЛИКА");
                            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                            b = false;
                        }

                        Console.Write($"{el.Name}\t\t{el.Population}\t\t{el.Capital}\t");
                        if (el is Republic) Console.WriteLine($"\t{((Republic)el).President}");

                        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                    }
                }
                if (b == false) Console.WriteLine("\n");
                b = true;
                foreach (State el in states)
                {
                    if (el is Monarchy)
                    {
                        if (b == true)
                        {
                            Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
                            Console.WriteLine("\t\t\t\t\t\tМОНАРХИЯ");
                            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                            b = false;
                        }

                        Console.Write($"{el.Name}\t\t{el.Population}\t\t{el.Capital}\t");

                        if (el is Monarchy) Console.WriteLine($"\t{((Monarchy)el).Emperor}");

                        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                    }
                }
                if (b == false) Console.WriteLine("\n");
                b = true;
                foreach (State el in states)
                {
                    if (el is Kingdom)
                    {
                        if (b == true)
                        {
                            Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
                            Console.WriteLine("\t\t\t\t\t\tКРОРЛЕВСТВО");
                            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                            b = false;
                        }

                        Console.Write($"{el.Name}\t\t{el.Population}\t\t{el.Capital}\t");

                        if (el is Kingdom) Console.WriteLine($"\t{((Kingdom)el).King}");
                        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                    }
                }


                Console.Write("\n\n\nНажмите любую клавишу для продолжения");
                Console.ReadKey();
            }
        }
        static void Add()
        {
            Console.Clear();
            Console.WriteLine("Какое государство вы хотите добавить ?");
            Console.WriteLine("Республика(1)");
            Console.WriteLine("Монархия(2)");
            Console.WriteLine("Королевство(3)");
            Console.Write("Выберите действие и введите число: ");
            int q = Number(1, 3);

            Console.WriteLine("Введите название:");
            string name = Console.ReadLine();

            Console.WriteLine("Введите население:");
            uint population;
            string input;
            bool p = true;
            do
            {
                input = Console.ReadLine();
                if (!UInt32.TryParse(input, out population) || (population < 1)) Console.WriteLine("Некорректный ввод");
                else p = false;
            } while (p == true);

            Console.WriteLine("Введите столицу:");
            string capital = Console.ReadLine();
            switch (q)
            {
                case 1:

                    Console.WriteLine("Введите президента:");
                    string president = Console.ReadLine();
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
            bool q = true;
            do
            {
                input = Console.ReadLine();
                if (!Int32.TryParse(input, out x) || (x < a) || (x > b)) Console.WriteLine("Некорректный ввод");
                else q = false;
            } while (q == true);

            return x;
        }
    }
}
