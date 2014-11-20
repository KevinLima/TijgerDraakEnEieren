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
        protected int aantalZetten = 0;

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

            aantalZetten++;
        }

        public bool IsZetMogelijk(int pos)
        {
            return bord.IsVeldBeschikbaar(pos);
        }
        public Status StatusVanVeld(int pos)
        {
            return bord.VeldStatus(pos);
        }

        public void ResetSpel( )
        {
            bord.NewGame( );
            aantalZetten = 0;
            beurt = 1;
        }

        public virtual int BerekenZet( )
        {
            return 2;
        }
        public virtual int WinnendeZet(Status st)
        {
            return 2;
        }
    }
}
