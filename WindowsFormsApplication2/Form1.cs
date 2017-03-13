using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class formheading : Form
    {
        int width;
        public formheading()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void formheading_Load(object sender, EventArgs e)
        {

        }

        private void lblinstruction2_Click(object sender, EventArgs e)
        {

        }

        private void lblinstruction1_Click(object sender, EventArgs e)
        {

        }


        private void nobutton_Click(object sender, EventArgs e)
        {
            Visible = false;

        }


        private void yesbutton_Click(object sender, EventArgs e)
        {
            formheading1 frm = new formheading1();
            frm.Show();
            Visible = false;

        }

        private void yesbutton_hover(object sender, EventArgs e)
        {

            yesbutton.BackColor = Color.DarkSeaGreen;




        }

        private void yesbutton_leave(object sender, EventArgs e)
        {

            yesbutton.BackColor = Color.LemonChiffon;


        }

        private void yesbutton_Leave1(object sender, EventArgs e)
        {

            yesbutton.BackColor = Color.LightCoral;


        }

        private void nobutton_hover(object sender, EventArgs e)
        {
            nobutton.BackColor = Color.DarkSeaGreen; ;
        }

        private void nobutton_leave(object sender, EventArgs e)
        {

            nobutton.BackColor = Color.LemonChiffon;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}