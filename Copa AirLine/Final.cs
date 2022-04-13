using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Copa_AirLine
{
    public partial class Final : Form
    {
        public Final()
        {
            InitializeComponent();
        }

        void Porcentaje()
        {
            for (int i = 0; i < 101; i++)
            {
                pbPorcentaje.Value = i;
                lblPorcentaje.Text = pbPorcentaje.Value.ToString() + "%";
            }

            if (pbPorcentaje.Value == 100)
            {
                Application.Exit();
            }
        }

        private void Final_Load(object sender, EventArgs e)
        {
            Porcentaje();
        }
    }
}
