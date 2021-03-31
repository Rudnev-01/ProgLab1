using System;

namespace ClassLibrary1
{

    public class Kingdom : State
    {
        private string king;
        public string King
        {
            get { return king; }
            set { king = value; }
        }

        public Kingdom(string name, uint population, string capital, string king) : base(name, population, capital)
        {
            this.king = king;
        }
    }

}
