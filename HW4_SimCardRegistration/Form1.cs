using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW4_SimCardRegistration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void addPic_Click(object sender, EventArgs e)
        {
            FileDialog dialog = new OpenFileDialog();
            dialog.Title = "Image File Only";
            dialog.Filter = "JPEG, PNG only | * .jpg; * jpeg; *.png *  ";
            DialogResult dr = dialog.ShowDialog();
            if(dr == DialogResult.OK) {
                picBox.Image = new Bitmap(dialog.FileName);
            }
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this.fname, this.lname, this.bidet, this.mobile, 
                this.status,  this.rdoFemale,  this.rdoMale, this.lokasyon, picBox.Image);
            form2.Show();
        }
    }
}
