using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Choose_a_Picture
{
    public partial class choosePictureForm : Form
    {
        public choosePictureForm()
        {
            InitializeComponent();
        }

        private void closeApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Sets the image depending on what 
        /// is selected within the combo box.
        /// </summary>
        private void selectImage(object sender, EventArgs e)
        {
            if(choiceComboBox.Text == "King Kong")
            {
                choicePictureBox.Image = Image.FromFile("King_Kong.jpg");
            }
            else if (choiceComboBox.Text == "Godzilla")
            {
                choicePictureBox.Image = Image.FromFile("Godzilla.jpg");
            }
            else if (choiceComboBox.Text == "Alien")
            {
                choicePictureBox.Image = Image.FromFile("Alien.jpg");
            }
            else if (choiceComboBox.Text == "Pirate Spider")
            {
                choicePictureBox.Image = Image.FromFile("Pirate_Spider.jpg");
            }
            else if (choiceComboBox.Text == "Nessie")
            {
                choicePictureBox.Image = Image.FromFile("Nessie.jpg");
            }
        }
    }
}
