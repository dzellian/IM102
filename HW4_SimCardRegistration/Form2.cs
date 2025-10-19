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


    public partial class Form2 : Form
    {
        private TextBox pfname;
        private TextBox plname;
        private TextBox plokasyon;
        private MaskedTextBox pmobile;
        private ComboBox pstatus;
        private DateTimePicker pbidet;
        private RadioButton prdoMale;
        private RadioButton prdoFemale;
        private Image ppicBox;

        public Form2(TextBox fname, TextBox lname, DateTimePicker bidet, MaskedTextBox mobile,
                ComboBox status, RadioButton rdoFemale, RadioButton rdoMale, TextBox lokasyon, Image picBox)
        {

            InitializeComponent();

            pfname = fname;
            plname = lname;
            plokasyon = lokasyon;
            pmobile = mobile;
            pstatus = status;
            pmobile = mobile;
            pbidet = bidet;
            prdoMale = rdoMale;
            prdoFemale = rdoFemale;
            ppicBox = picBox;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            fname.Text = pfname.Text;
            lname.Text = plname.Text;
            lokasyon.Text = plokasyon.Text;
            mobile.Text = pmobile.Text;
            status.Text = pstatus.Text;
            bidet.Text = pbidet.Text;
            rdoMale.Text = prdoMale.Text;
            rdoFemale.Text = prdoFemale.Text;
            picBox.Image = ppicBox;

            if (prdoMale.Checked) {
                rdoMale.Checked = true;
}
            else
            {
                rdoFemale.Checked = true;
            }
        }

        
    }
}
