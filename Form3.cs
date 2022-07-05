using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace luncher_rayman_aréna
{
    public partial class Form3 : Form
    {

 
        public Form3()
        {
            InitializeComponent();




            string cheminfichierLangue = @"fils\Langue.txt "; //chemain fichier txt carte reseau

            string lecture = File.ReadAllText(cheminfichierLangue);



            if (lecture == "EN")
            {

                label1.Text = "Applying Texture.";
                label2.Text = "Please Wait.";

                label1.Location = new Point(220, 66); // game language
                label2.Location = new Point(250, 99); // game language

            }
            else if (lecture == "FR")
            {

                label1.Text = "Application des textures.";
                label2.Text = "S'il vous plaît, attendez.";

                label1.Location = new Point(190, 66); // game language
                label2.Location = new Point(195, 99); // game language

            }
            else if (lecture == "ES")
            {
                label1.Text = "Aplicación de textura.";
                label2.Text = "Espere por favor.";

                label1.Location = new Point(220, 66); // game language
                label2.Location = new Point(250, 99); // game language
            }
            else if (lecture == "RU")
            {
                label1.Text = "Применение текстуры.";
                label2.Text = "Пожалуйста, подождите.";

                label1.Location = new Point(190, 66); // game language
                label2.Location = new Point(180, 99); // game language
            }















        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }




    















}
