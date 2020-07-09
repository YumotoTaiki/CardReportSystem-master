using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardReportSystem
{
    public partial class Sort : Form
    {
        Form1 form1 = new Form1();
        private string color;

        public Sort()
        {
            InitializeComponent();
        }

        private void btDecided_Click(object sender, EventArgs e)
        {
            RadioCheck();
            this.Hide();
        }

        private string RadioCheck()
        {
            if (rbRed.Checked == false && rbBlue.Checked == false && rbGreen.Checked == false && rbWhite.Checked == false && rbBlack.Checked == false && rbNoColor.Checked == false)
            {

            } else {
                var RadioButtonChecked_InGroup = gbColor.Controls.OfType<RadioButton>()
                .SingleOrDefault(rb => rb.Checked == true);
                color = RadioButtonChecked_InGroup.Text;
            }
            return color;
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            var RadioButtonChecked_InGroup = gbColor.Controls.OfType<RadioButton>()
            .SingleOrDefault(rb => rb.Checked == true);
            RadioButtonChecked_InGroup.Checked = false;
        }
    }
}
