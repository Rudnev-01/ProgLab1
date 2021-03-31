namespace ClassLibrary1
{
    public class Republic : State
    {

        private string president;
        public string President
        {
            get { return president; }
            set { president = value; }
        }

        public Republic(string name, uint population, string capital, string president) : base(name, population, capital)
        {
            this.president = president;
        }
    }

}
