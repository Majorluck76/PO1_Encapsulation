using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO1_Encapsulation
{
    public class Personnage
    {
        string nom;
        int pointDeVies;
        int pointDePuissance;


        public string Nom { get => nom; }
        public int PointDeVies
        {
            get => pointDeVies;
            set
            {
                if (value < 0)
                {
                    pointDeVies = 0;
                }
                //else if (value > )
                //{

                //}
                else
                {
                    pointDeVies = value;
                }
            }
        }
        public int PointDePuissance { get => pointDePuissance; set => pointDePuissance = value; }

        public bool EstEnVie
        {

            get
            {
                if (pointDeVies > 0)
                {
                    return true;
                }
                return false;
            }

            
        }
    }
}
