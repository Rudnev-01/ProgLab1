using System;

namespace ClassLibrary1
{
    public class State
    {
        protected string name;
        protected int population;
        protected string capital;
        // public string Name { get; set; }
        //public int Population { get; set; }
        // public string Capital { get; set; }

        public virtual void Get()
        {

            Console.Write($"{name}\t\t\t{population} чел.\t\t\t{capital}");
        }
        public State(string name, int population, string capital)
        {
            this.name = name;
            this.population = population;
            this.capital = capital;
        }
    }
    public class Republic : State
    {

        private string president;
        // public string President {get; set; }
        public override void Get()
        {
            base.Get();
            Console.WriteLine($"\t\t\t{president}");
        }
        public Republic(string name, int population, string capital, string president) : base(name, population, capital)
        {
            this.president = president;
        }
    }

    public class Monarchy : State
    {
        private string emperor;
        // public string Emperor {get; set; }
        public override void Get()
        {
            base.Get();
            Console.WriteLine($"\t\t\t{emperor}");
        }
        public Monarchy(string name, int population, string capital, string emperor) : base(name, population, capital)
        {
            this.emperor = emperor;
        }
    }

    public class Kingdom : State
    {
        private string king;
        // public string King {get; set; }
        public override void Get()
        {
            base.Get();
            Console.WriteLine($"\t\t\t{king}");
        }
        public Kingdom(string name, int population, string capital, string king) : base(name, population, capital)
        {
            this.king = king;
        }
    }

}
