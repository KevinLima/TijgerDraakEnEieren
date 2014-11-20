using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TijgerDraakEnEieren
{
    public class AI_Spel : Spel
    {

        public override int BerekenZet( )
        {
            int zet = 0;

            if (aantalZetten == 1)
            {
                if (IsZetMogelijk(4) == true)
                {
                    zet = 4;
                }
                else
                {
                    zet = 2;
                }
            }
            if (aantalZetten >= 3)
            {
                // AI bekijkt eerst of het kan winnen
                int winnendeZet = WinnendeZet(Status.O);
                if (winnendeZet != 88)
                {
                    zet = winnendeZet;
                }
                else
                {
                    // Moet de AI blokkeren?
                    winnendeZet = WinnendeZet(Status.X);
                    if (winnendeZet != 88)
                    {
                        zet = winnendeZet;
                    }
                    else
                    {
                        if (IsZetMogelijk(0))
                        {
                            zet = 0;
                        }
                        else if (IsZetMogelijk(2))
                        {
                            zet = 2;
                        }
                        else
                        {
                            zet = 6;
                        }
                       
                    }
                }
            }

            

            return zet;
        }
        public override int WinnendeZet(Status st)
        {
            int winnendeZet = 88;

            #region Reeks 0
            if (StatusVanVeld(0) == st && StatusVanVeld(1) == st && IsZetMogelijk(2))
            {
                winnendeZet = 2;
            }
            if (StatusVanVeld(1) == st && StatusVanVeld(2) == st && IsZetMogelijk(0))
            {
                winnendeZet = 0;
            }
            if (StatusVanVeld(0) == st && StatusVanVeld(2) == st && IsZetMogelijk(1))
            {
                winnendeZet = 1;
            }
            if (StatusVanVeld(0) == st && StatusVanVeld(3) == st && IsZetMogelijk(6))
            {
                winnendeZet = 6;
            }
            if (StatusVanVeld(3) == st && StatusVanVeld(6) == st && IsZetMogelijk(0))
            {
                winnendeZet = 0;
            }
            if (StatusVanVeld(0) == st && StatusVanVeld(6) == st && IsZetMogelijk(3))
            {
                winnendeZet = 3;
            }
            if (StatusVanVeld(0) == st && StatusVanVeld(4) == st && IsZetMogelijk(8))
            {
                winnendeZet = 8;
            }
            if (StatusVanVeld(4) == st && StatusVanVeld(8) == st && IsZetMogelijk(0))
            {
                winnendeZet = 0;
            }
            if (StatusVanVeld(0) == st && StatusVanVeld(8) == st && IsZetMogelijk(4))
            {
                winnendeZet = 4;
            } 
            #endregion

            #region Reeks 1
            if (StatusVanVeld(1) == st && StatusVanVeld(4) == st)
            {
                winnendeZet = 7;
            }
            if (StatusVanVeld(4) == st && StatusVanVeld(7) == st)
            {
                winnendeZet = 1;
            }
            if (StatusVanVeld(1) == st && StatusVanVeld(7) == st)
            {
                winnendeZet = 4;
            }
            #endregion

            #region Reeks 2
            if (StatusVanVeld(2) == st && StatusVanVeld(4) == st && IsZetMogelijk(6))
            {
                winnendeZet = 6;
            }
            if (StatusVanVeld(4) == st && StatusVanVeld(6) == st && IsZetMogelijk(2))
            {
                winnendeZet = 2;
            }
            if (StatusVanVeld(2) == st && StatusVanVeld(6) == st && IsZetMogelijk(4))
            {
                winnendeZet = 4;
            }
            if (StatusVanVeld(2) == st && StatusVanVeld(5) == st && IsZetMogelijk(8))
            {
                winnendeZet = 8;
            }
            if (StatusVanVeld(5) == st && StatusVanVeld(8) == st && IsZetMogelijk(2))
            {
                winnendeZet = 2;
            }
            if (StatusVanVeld(2) == st && StatusVanVeld(8) == st && IsZetMogelijk(5))
            {
                winnendeZet = 5;
            }
            #endregion

            #region Reeks 3
            if (StatusVanVeld(3) == st && StatusVanVeld(4) == st && IsZetMogelijk(5))
            {
                winnendeZet = 5;
            }
            if (StatusVanVeld(4) == st && StatusVanVeld(5) == st && IsZetMogelijk(3))
            {
                winnendeZet = 3;
            }
            if (StatusVanVeld(3) == st && StatusVanVeld(5) == st && IsZetMogelijk(4))
            {
                winnendeZet = 4;
            }
            #endregion

            #region Reeks 4
            if (StatusVanVeld(6) == st && StatusVanVeld(7) == st && IsZetMogelijk(8))
            {
                winnendeZet = 8;
            }
            if (StatusVanVeld(7) == st && StatusVanVeld(8) == st && IsZetMogelijk(6))
            {
                winnendeZet = 6;
            }
            if (StatusVanVeld(6) == st && StatusVanVeld(8) == st && IsZetMogelijk(7))
            {
                winnendeZet = 7;
            }
            #endregion

            return winnendeZet;
        }
    }
}
