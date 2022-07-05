using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



namespace luncher_rayman_aréna
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string cheminfichierLangue = @"fils\Langue.txt "; //chemain fichier txt carte reseau



            //test si le fichier txt est present (partie langue)
            if (!File.Exists(cheminfichierLangue))
            {
            }
            else
            {
                string lecture = File.ReadAllText(cheminfichierLangue);

                if (lecture == "EN")
                {


                    Patient.Text = "Wait, modification of skin(s) in progress...";

                }
                else if (lecture == "FR")
                {
                    Patient.Text = "Attendez, modification de skin(s) en cours...";

                }
                else if (lecture == "ES")
                {
                    Patient.Text = "Espera, modificación de skin(s) en progreso... ";

                }
            }






        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
