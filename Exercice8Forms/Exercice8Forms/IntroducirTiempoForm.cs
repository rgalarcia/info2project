using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FlightPlanLibrary;

namespace Exercice8Forms
{
    public partial class IntroducirTiempoForm : Form
    {
        double tiempo;
        double distanciaSeguridad;

        public IntroducirTiempoForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                tiempo = Convert.ToInt32(timeBox.Text);
                distanciaSeguridad = Convert.ToDouble(distanciaBox.Text);
                Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("ERROR en el formato de los datos, por favor vuelve a intentarlo");
            }
        }

        public double DameTiempo()
        {
            return this.tiempo;
        }
        public double DameDistSeg()
        {
            return this.distanciaSeguridad;
        }

        private void IntroducirTiempoForm_Load(object sender, EventArgs e)
        {

        }

    }
}
