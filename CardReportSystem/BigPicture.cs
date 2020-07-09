using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardReportSystem
{
    public partial class BigPicture : Form
    {
        public BigPicture()
        {
            InitializeComponent();
        }

        private void BigPicture_Load(object sender, EventArgs e)
        {

        }

        public void BigPic(Image image)
        {
            pbCard.Image = image;
            pbCard.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btEnd_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
