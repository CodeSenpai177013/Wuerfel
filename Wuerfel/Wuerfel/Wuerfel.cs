using System;
using System.Windows.Forms;

namespace Wuerfel
{
    public partial class Wuerfel : Form
    {
        //Variabeln und Random Klasse
        Random rnd = new Random();
        int wurf, ausgabe;

        public Wuerfel()
        {
            InitializeComponent();
        }

        //beendet das Programm
        private void endeMS_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Durchlauf mit einem Wurf
        private void start1MS_Click(object sender, EventArgs e)
        {
            //setzt den Wert von wurf zu einer Zahl zwischen 1 und 6
            wurf = rnd.Next(1, 6);

            //fragt ab für welche Zahl ausgegeben werden soll
            ausgabe = Convert.ToInt16(cbbxwa.SelectedText);

            if (wurf == ausgabe)
            {
                //sollte die Augenzahl des Wurfes = der geforderten Ausgabe entsprechen dann:
                lblahe.Text = "1";
                lblrhe.Text = "100%";
            }
            else
            {
                //sollte die Augenzahl des Wurfes nicht der geforderten Ausgabe entsprechen dann:
                lblahe.Text = "0";
                lblrhe.Text = "0%";
            }
        }

        //Durchlauf mit 10 Würfen
        private void start10MS_Click(object sender, EventArgs e)
        {
            //Erstellen eines Arrays
            int[] wurfE = new int[10];

            //fragt ab für welche Zahl ausgegeben werden soll
            ausgabe = Convert.ToInt16(cbbxwa.SelectedText);

            //erstellen eines Integers zum zählen der Anzahl der Ergebnisse
            int ausgabeWA= 0;

            //10 maliges Würfeln und in Array schreiben
            for (int i = 0; i < 10; i++)
            {
                wurf = rnd.Next(1, 6);
                wurfE[i] = wurf;
                Console.WriteLine(wurfE.GetValue(i));
            }
            
            //suche nach der Anzahl der gefragten Ausgabe im Array
            for (int x = 0; x < wurfE.Length; x++)
            {
                if (wurfE[x] == ausgabe)
                {
                    ausgabeWA++;
                }
            }
            //Ausgabe
            lblahe.Text = Convert.ToString(ausgabeWA);
            lblrhe.Text = Convert.ToString(ausgabeWA * 10) + "%";

        }

        //Durchlauf mit 100 Würfen
        private void start100MS_Click(object sender, EventArgs e)
        {
            //Erstellen eines arrays
            int[] wurfE = new int[100];

            //fragt ab für welche Zahl ausgegeben werden soll
            ausgabe = Convert.ToInt16(cbbxwa.SelectedText);

            //erstellen eines Integers zum zählen der Anzahl der Ergebnisse
            int ausgabeWA = 0;

            // 100 maliges Würfeln und in Array schreiben
            for (int i = 0; i < 100; i++)
            {
                wurf = rnd.Next(1, 6);
                wurfE[i] = wurf;
                Console.WriteLine(wurfE.GetValue(i));
            }

            //suche nach der Anzahl der gefragten Ausgabe im Array
            for (int x = 0; x < wurfE.Length; x++)
            {
                if (wurfE[x] == ausgabe)
                {
                    ausgabeWA++;
                }
            }

            //Ausgabe
            lblahe.Text = Convert.ToString(ausgabeWA);
            lblrhe.Text = Convert.ToString(ausgabeWA) + "%";
        }

        //Durchlauf mit 1000 Würfen
        private void start1000MS_Click(object sender, EventArgs e)
        {
            //erstellen eines arrays
            int[] wurfE = new int[1000];

            ausgabe = Convert.ToInt16(cbbxwa.SelectedText);

            int ausgabeWA = 0;

            // 1000 maliges Würfeln und in Array schreiben
            for (int i = 0; i < 1000; i++)
            {
                wurf = rnd.Next(1, 6);
                wurfE[i] = wurf;
                Console.WriteLine(wurfE.GetValue(i));
            }

            //suche nach der Anzahl der gefragten Ausgabe im Array
            for (int x = 0; x < wurfE.Length; x++)
            {
                if (wurfE[x] == ausgabe)
                {
                    ausgabeWA++;
                }
            }

            //Ausgabe
            lblahe.Text = Convert.ToString(ausgabeWA);
            lblrhe.Text = Convert.ToString(ausgabeWA / 10) + "%";
        }

        //Durchlauf mit 10000 Würfen
        private void start10000MS_Click(object sender, EventArgs e)
        {
            //erstellen eines arrays
            int[] wurfE = new int[10000];

            ausgabe = Convert.ToInt16(cbbxwa.SelectedText);

            int ausgabeWA = 0;

            // 10000 maliges Würfeln und in Array schreiben
            for (int i = 0; i < 10000; i++)
            {
                wurf = rnd.Next(1, 6);
                wurfE[i] = wurf;
                Console.WriteLine(wurfE.GetValue(i));
            }

            //suche nach der Anzahl der gefragten Ausgabe im Array
            for (int x = 0; x < wurfE.Length; x++)
            {
                if (wurfE[x] == ausgabe)
                {
                    ausgabeWA++;
                }
            }

            //Ausgabe
            lblahe.Text = Convert.ToString(ausgabeWA);
            lblrhe.Text = Convert.ToString(ausgabeWA / 100) + "%";
        }

        //Zurücksetzen aller Ausgaben
        private void löschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblahe.Text = "";
            lblrhe.Text = "";
            cbbxwa.SelectedIndex = 0;
        }
    }
}
