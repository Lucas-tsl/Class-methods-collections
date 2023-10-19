namespace Class_methods_collections
{
    public class Personnage
    {
        private int codeP;
        private string nomP;
        private string peuple;
        private string dateDC;
        private bool enBataille;
        private int valeur;
        public int nouvValeur;


        public int CodeP
        {
            get { return codeP; }
            set { codeP = value; }
        }
        public string Peuple
        {
            get { return peuple; }
            set { peuple = value; }
        }
        public string DateDC
        {
            get { return dateDC; }
            set { dateDC = value; }
        }
        public bool EnBataille
        {
            get { return enBataille; }
            set { enBataille = value; }
        }

        public int Valeur
        {
            get { return valeur; }
            set { valeur = value; }
        }

        public Personnage(int c, string nom) { }

        public void meurt(string dateFin) { }

        public void change(int nouvValeur) { }
        

    }
}