using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TijgerDraakEnEieren
{
    public partial class Form1 : Form
    {
        Spel spel;
        bool PVP = true;
        bool NieuweSpel = true;
        PictureBox[] speelVelden;

        public Form1( )
        {
            InitializeComponent( );
            speelVelden = new PictureBox[] { v0,v1,v2,v3,v4,v5,v6,v7,v8 };
        }

        private void UserKlik(object sender, EventArgs e)
        {
            // Dit is de veld die de gebruiker klikt
            PictureBox userKlik = (PictureBox)sender;

            // Elke veld heeft een tag, de eerste veld is 0 en de laatste is 8. 
            int veldTag = Convert.ToInt16(userKlik.Tag);

            // Hier wordt bekeken of de speler tegen een andere speler wilt spelen of tegen de computer.

                if (PVP == true)
                {
                    if (NieuweSpel == true)
                    {
                        spel = new Spel( );
                        NieuweSpel = false;
                    }
                    #region PVP Logica
                    // De speler heeft de AI knop NIET ingedrukt.
                    AI_Knop.Enabled = false;
                    AI_Knop.ForeColor = System.Drawing.Color.DarkSlateGray;

                    // Nu moet er getoetst worden of de zet v/d speler mogelijk is.
                    if (spel.IsZetMogelijk(veldTag) == true)
                    {
                        // Veld is beschikbaar, registreer de zet.
                        spel.MaakZet(veldTag);

                        // Veld wordt visueel ook verandert.
                        if (spel.WieIsAanDeBeurt( ) == Status.X)
                        {
                            userKlik.Image = Properties.Resources.tiger;
                            huidgeSpelerBox.Image = Properties.Resources.blackdragon;
                        }
                        else
                        {
                            userKlik.Image = Properties.Resources.blackdragon;
                            huidgeSpelerBox.Image = Properties.Resources.tiger;
                        }
                        // Bekijk of de spel gewonnen is.
                        if (spel.SpelGewonnen( ) == true)
                        {
                            // Velden uitzetten 
                            BewerkVelden(false);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Veld is niet beschikbaar");
                    } 
                    #endregion


                }
                else
                {
                    // Alse de speler de AI knop WEL heeft ingedrukt.
                    if (NieuweSpel == true)
                    {
                        spel = new AI_Spel( );
                        NieuweSpel = false;
                    }
                    // De speler maakt altijd de eerste zet.
                    // Aan het einde van die zet wordt er een reactie getriggerd v/d AI.

                    #region P vs AI Logica
                    // AI knop wordt uitgezet.
                    AI_Knop.Enabled = false;

                    // Nu moet er getoetst worden of de zet v/d speler mogelijk is.
                    if (spel.IsZetMogelijk(veldTag) == true)
                    {
                        // Veld is beschikbaar, registreer de zet.
                        spel.MaakZet(veldTag);

                        // Veld wordt visueel ook verandert.
                        if (spel.WieIsAanDeBeurt( ) == Status.X)
                        {
                            userKlik.Image = Properties.Resources.tiger;
                            huidgeSpelerBox.Image = Properties.Resources.blackdragon;
                        }
                        else
                        {
                            userKlik.Image = Properties.Resources.blackdragon;
                            huidgeSpelerBox.Image = Properties.Resources.tiger;
                        }
                        // Bekijk of de spel gewonnen is.
                        if (spel.SpelGewonnen( ) == true)
                        {
                            // Velden uitzetten 
                            BewerkVelden(false);
                        }
                        ComputerZet( );
                    }
                    else
                    {
                        Console.WriteLine("Veld is niet beschikbaar");
                    } 
                    #endregion

                }
            
        }
        private void ComputerZet( )
        {
            int zet = spel.BerekenZet( );
            spel.MaakZet(zet);
            if (spel.WieIsAanDeBeurt( ) == Status.X)
            {
                speelVelden[zet].Image = Properties.Resources.tiger;
                huidgeSpelerBox.Image = Properties.Resources.blackdragon;
            }
            else
            {
                speelVelden[zet].Image = Properties.Resources.blackdragon;
                huidgeSpelerBox.Image = Properties.Resources.tiger;
            }
            // Bekijk of de spel gewonnen is.
            if (spel.SpelGewonnen( ) == true)
            {
                // Velden uitzetten 
                BewerkVelden(false);
            }
        }
        private void speelTegenDeComputer(object sender, EventArgs e)
        {
            //De speler heeft de AI knopt ingedrukt.
            AI_Knop.Enabled = false;
            AI_Knop.ForeColor = System.Drawing.Color.DarkSlateGray;
            PVP = false;
            //NieuweSpel = false;

        }

        private void ResetKnop(object sender, EventArgs e )
        {
            BewerkVelden(true);
        }

        private void BewerkVelden(bool onOff)
        {

            for (int i = 0; i <= 8; i++)
            {
                speelVelden[i].Enabled = onOff;
            }

                if (onOff == true)
                {
                    AI_Knop.Enabled = onOff;
                    AI_Knop.ForeColor = System.Drawing.Color.Black;

                    for (int i = 0; i <= 8; i++)
                    {
                        speelVelden[i].Image = null;
                    }

                    huidgeSpelerBox.Image = Properties.Resources.blackdragon;
                    NieuweSpel = true;
                    PVP = true;
                    spel.ResetSpel( );
                }
        }
    }
}
