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
    public partial class formheading3 : Form
    {
        public formheading3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Random random = new Random();
          
            pictureBox1.Image = imageList1.Images[random.Next(0,imageList1.Images.Count - 1)];
            pictureBox2.Image = imageList1.Images[random.Next(0, imageList1.Images.Count - 1)];
           

        }
    }
}
