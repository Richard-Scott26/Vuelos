using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Copa_AirLine
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        void Porcentaje()
        {
            Main main = new Main();

            for (int i = 0; i < 101; i++)
            {
                pbPorcentaje.Value = i;
                lblPorcentaje.Text = pbPorcentaje.Value.ToString() + "%";
            }

            if (pbPorcentaje.Value == 100)
            {
                main.ShowDialog();
                this.Dispose();
            }

        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            Porcentaje();
        }

        private void pbPorcentaje_Click(object sender, EventArgs e)
        {

        }
    }
}
