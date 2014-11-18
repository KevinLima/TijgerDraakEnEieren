using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TijgerDraakEnEieren
{
    public class Spel
    {
        protected int beurt = 1;
        Bord bord = new Bord();
        protected int aantalZetten;

        public Spel( )//Leeg
        {
            
        }

        public void WisselBeurt( )
        {
            if (beurt == 1)
            {
                beurt = 2;
            }
            else
            {
                beurt = 1;
            }
        }

        public bool SpelGewonnen( )
        {
            return bord.Uitslag( );
        }

        public Status WieIsAanDeBeurt( )
        {
            // Hier wordt er bekeken wie aan de beurt is.
            Status speler = Status.O;
            if (beurt == 1)
            {
                speler = Status.X;
            }
            return speler;
        }

        public void MaakZet(int pos )
        {
            // Hier wordt een zet permanent gemaakt.
            bord.RegistreerZet(pos, WieIsAanDeBeurt( ));

            // Nu is de andere speler aan de beurt.
            WisselBeurt( );
        }

        public bool IsZetMogelijk(int pos)
        {
            return bord.IsVeldBeschikbaar(pos);
        }

        public void ResetSpel( )
        {
            bord.NewGame( );
        }
    }
}
