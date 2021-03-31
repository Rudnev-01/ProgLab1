namespace ClassLibrary1
{
    public class Monarchy : State
    {
        private string emperor;
        public string Emperor
        {
            get { return emperor; }
            set { emperor = value; }
        }

        public Monarchy(string name, uint population, string capital, string emperor) : base(name, population, capital)
        {
            this.emperor = emperor;
        }
    }

}
