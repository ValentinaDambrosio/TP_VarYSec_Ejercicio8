using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_VarYSec_Ejercicio8
{
    public partial class fIntercambio : Form
    {
        public fIntercambio()
        {
            InitializeComponent();
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bIntercambiar_Click(object sender, EventArgs e)
        {
            double numA = Convert.ToDouble(tNumeroA.Text);
            double numB = Convert.ToDouble(tNumeroB.Text);
            double aux = numA;
            numA = numB;
            numB = aux;
            MessageBox.Show("Intercambio entre el número A y B:\nA: " + numA + "\nB: " + numB);
        }
    }
}
