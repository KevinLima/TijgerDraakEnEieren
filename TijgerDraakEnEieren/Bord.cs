using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TijgerDraakEnEieren
{
    public class Bord
    {
        private Status[] velden = new Status[9];
    
        public Bord( )
        {
            for (int i = 0; i <= 8; i++)
            {
                velden[i] = Status.Leeg;
                Console.WriteLine("Velden" + velden[i]);
            }
        }

        public bool IsBordVol( )
        {
            bool vol = false;
            for (int i = 0; i <= 8; i++)
            {
                vol |= velden[i] != Status.Leeg;
            }
            return vol;
        }

        public bool IsVeldBeschikbaar(int pos )
        {
            bool veldIsLeeg = false;

            if (velden[pos] == Status.Leeg)
            {
                veldIsLeeg = true;
            }
            return veldIsLeeg;
        }

        public void RegistreerZet(int pos, Status speler )
        {
            velden[pos] = speler;
        }

        public bool Uitslag( )
        {
            // Heeft iemand gewonnen?
            bool uitslag = false;

            #region Uitslag check
            // Dit is de algoritme die bepaald of er een winnende zet is gemaakt. 
            if (velden[0] != Status.Leeg && velden[0] == velden[1] && velden[0] == velden[2])
            {
                uitslag = true;
            }
            if (velden[0] != Status.Leeg && velden[0] == velden[4] && velden[0] == velden[8])
            {
                uitslag = true;
            }
            if (velden[0] != Status.Leeg && velden[0] == velden[3] && velden[0] == velden[6])
            {
                uitslag = true;
            }
            if (velden[1] != Status.Leeg && velden[1] == velden[4] && velden[1] == velden[7])
            {
                uitslag = true;
            }
            if (velden[2] != Status.Leeg && velden[2] == velden[5] && velden[2] == velden[8])
            {
                uitslag = true;
            }
            if (velden[3] != Status.Leeg && velden[3] == velden[4] && velden[3] == velden[5])
            {
                uitslag = true;
            }
            if (velden[2] != Status.Leeg && velden[2] == velden[4] && velden[2] == velden[6])
            {
                uitslag = true;
            }
            if (velden[6] != Status.Leeg && velden[6] == velden[7] && velden[6] == velden[8])
            {
                uitslag = true;
            }

            #endregion
            return uitslag;
        }

        public void NewGame( )
        {
            for (int i = 0; i <= 8; i++)
            {
                velden[i] = Status.Leeg;
                Console.WriteLine("Velden" + velden[i]);
            }
        }
    }
}
