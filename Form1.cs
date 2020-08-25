using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weiss_Jessica_Bonus1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBerechnen_Click(object sender, EventArgs e)
        {

            //Defaultwerte
            txtboxUmsatz.BackColor = Color.White;
            txtboxVertreter.BackColor = Color.White;

            //Variablen deklarieren
            double Umsatz = 0;
            double Provision = 0;
            string VertreterName = "";


            //Eingabekontrolle
            if (double.TryParse(txtboxUmsatz.Text, out Umsatz) == false)
            {
                lblErgebnis.Text = "Geben Sie bitte eine korrekte Zahl ein.";
                txtboxUmsatz.BackColor = Color.Red;
                txtboxUmsatz.Focus();
                txtboxUmsatz.Text = "";
                return;
            }


            //Rechnung inkl. Eingabekontrolle

            switch (txtboxVertreter.Text)
            {
                case "Huber":
                    Provision = Umsatz * 0.02;
                    VertreterName = "Huber";
                    break;

                case "Maier":
                    Provision = Umsatz * 0.03;
                    VertreterName = "Maier";
                    break;

                case "Frick":
                    Provision = Umsatz * 0.04;
                    VertreterName = "Frick";
                    break;

                case "Moser":
                    Provision = Umsatz * 0.05;
                    VertreterName = "Moser";
                    break;

                default:
                    MessageBox.Show("Überprüfen Sie den Namen des Vertreters!", "Fehler",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    txtboxVertreter.BackColor = Color.Red;
                    txtboxVertreter.Text = "";
                    txtboxVertreter.Focus();

                    return;

            }

            //Ausgabe

            lblErgebnis.Text = "Die Provision für " + VertreterName + " beträgt: CHF " + Provision;


        }
    }
}
