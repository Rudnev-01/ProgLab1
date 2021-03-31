namespace ClassLibrary1
{
    public class State
    {
        protected string name;
        protected uint population;
        protected string capital;

        public string Name 
        {
            get { return name; }
            set { name = value;}
        }

        public uint Population
        {
            get { return population; }
            set { population = value; }
        }

        public string Capital
        {
            get { return capital; }
            set { capital = value; }
        }
      
        public bool IsSearch(string str)
        {
            str = str.ToUpper();
            if (name.ToUpper().Contains(str))return true; else return false;
        }
       
        public State(string name, uint population, string capital)
        {
            this.name = name;
            this.population = population;
            this.capital = capital;
        }
    }

}
