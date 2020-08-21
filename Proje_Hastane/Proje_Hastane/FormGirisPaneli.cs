using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class FormGirisPaneli : Form
    {
        public FormGirisPaneli()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnHastaGirisi_Click(object sender, EventArgs e)
        {
            FormHastaGiris fr = new FormHastaGiris();
            fr.Show();
            this.Hide();
        }

        private void BtnDoktorGirisi_Click(object sender, EventArgs e)
        {
            FormDoktorGiris fr = new FormDoktorGiris();
            fr.Show();
            this.Hide();
        }

        private void BtnSekreterGirisi_Click(object sender, EventArgs e)
        {
            FormSekreterGiris fr = new FormSekreterGiris();
            fr.Show();
            this.Hide();
        }

        private void lblTarih_Click(object sender, EventArgs e)
        {

        }
    }
}
