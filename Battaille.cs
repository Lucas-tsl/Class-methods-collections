using System.Collections.ObjectModel;
using System.Globalization;

namespace Class_methods_collections
{
    class Battaille
    {
        private DateTime date;
        private string lieu;
        private int duree;
        private string gagnant; 


        public DateTime Date   
        {
            get { return date; }   
            set { date = value; }  
        }
        public string Lieu
        {
            get { return lieu; }
            set { lieu = value; }
        }
        public int Duree
        {
            get { return duree; }
            set { duree = value; }
        }
        public string Gagnant
        {
            get { return gagnant; }
            set { gagnant = value; }
        }

        
        public void Bataille (DateTime date,string lieu, int duree)
        {
            this.date = date;
            this.lieu = lieu;
            this.duree = duree; 
        }

        public void RetourneValeur (Collection<string> Personnage)
        {

        }

        public void AjoutPers(Collection<string> Personnage)
        {

        }

        public void DéfinirChef(Collection<string> Personnage, int code, int nom, string arme)
        {

        }

        public void RetournerNbPerte(Collection<string> Personnage)
        {

        }
        public void AjoutPers(Collection<string> Personnage, int code, string nom, int val)
        {

        }
        public  void DefinirGagnant()
        {

        }


    }



}
