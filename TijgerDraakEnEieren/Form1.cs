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
        public Form1( )
        {
            InitializeComponent( );
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


                }
                else
                {
                    // Alse de speler de AI knop WEL heeft ingedrukt.
                    if (NieuweSpel == true)
                    {
                        spel = new AI_Spel( );
                        NieuweSpel = false;
                    }


                }
            
        }
        private void speelTegenDeComputer(object sender, EventArgs e)
        {
            //De speler heeft de AI knopt ingedrukt.
            AI_Knop.Enabled = false;
            AI_Knop.ForeColor = System.Drawing.Color.DarkSlateGray;
            PVP = false;
            NieuweSpel = false;

        }

        private void ResetKnop(object sender, EventArgs e )
        {
            BewerkVelden(true);
        }

        private void BewerkVelden(bool onOff)
        {
            v0.Enabled = onOff;
            v1.Enabled = onOff;
            v2.Enabled = onOff;
            v3.Enabled = onOff;
            v4.Enabled = onOff;
            v5.Enabled = onOff;
            v6.Enabled = onOff;
            v7.Enabled = onOff;
            v8.Enabled = onOff;

            if (onOff == true)
            {
                AI_Knop.Enabled = onOff;
                AI_Knop.ForeColor = System.Drawing.Color.Black;

                v0.Image = null;
                v1.Image = null;
                v2.Image = null;
                v3.Image = null;
                v4.Image = null;
                v5.Image = null;
                v6.Image = null;
                v7.Image = null;
                v8.Image = null;

                spel.ResetSpel( );
            }
        }
        
        private void Form1_Load(object sender, EventArgs e)//Leeg
        {

        }

        private void label1_Click(object sender, EventArgs e)//Leeg
        {

        }

        private void button2_Click(object sender, EventArgs e)//Leeg
        {

        }
    }
}
