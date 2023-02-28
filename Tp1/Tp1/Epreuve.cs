using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1
{
    internal class Epreuve
    {
        private string id, nom;
        private List <Athlete> listeA;
        private List <Resultat> listeR;
        private bool ferme;
        public Epreuve()
        {
            id = "";
            nom = "";
            listeA = new List <Athlete>();
            listeR = new List <Resultat>();
            ferme = false;
        }
        public bool AjouterAthlete( Athlete a )
        {
            if (listeA.Contains(a)) {
                Console.WriteLine("L'athlète existe déjà");
                    return false;
            
            }else { try
                {
                    listeA.Add(a);
                    return true;
                }catch(NullReferenceException x)
                {
                    Console.WriteLine("Athlète null");
                    return false;
                }
                }
        }
    }
    
}
