using System;

namespace ClassLibrary1
{
    public class State
    {
        protected string name;
        protected uint population;
        protected string capital;
        // public string Name { get; set; }
        //public int Population { get; set; }
        // public string Capital { get; set; }
        public bool IsSearch(string str)
        {
            str = str.ToUpper();
            if (name.ToUpper().Contains(str))return true; else return false;
        }
        public virtual void Get()
        {

            Console.Write($"Название: {name}\t\tНаселение: {population} чел.\t Столица: {capital}");
        }
        public State(string name, uint population, string capital)
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
            Console.WriteLine($"\t\tПрезидент: {president}");
        }
        public Republic(string name, uint population, string capital, string president) : base(name, population, capital)
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
            Console.WriteLine($"\t\tИмператор: {emperor}");
        }
        public Monarchy(string name, uint population, string capital, string emperor) : base(name, population, capital)
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
            Console.WriteLine($"\t\tКороль: {king}");
        }
        public Kingdom(string name, uint population, string capital, string king) : base(name, population, capital)
        {
            this.king = king;
        }
    }

}
