using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula0304
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnExercicio1_Click(object sender, EventArgs e)
        {
            //this.Close();
            frmExercicio1 f2 = new frmExercicio1();
            f2.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcercicio2_Click(object sender, EventArgs e)
        {
            frmExercicio2 f3 = new frmExercicio2();
            f3.ShowDialog();
        }
    }
}
