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
    public partial class DatosForm : Form
    {
        FlightPlan miPlan;

        public DatosForm(FlightPlan Plan)
        {
            InitializeComponent();
            miPlan = Plan;
        }

        private void DatosForm_Load(object sender, EventArgs e)
        {
            idBox.Text=miPlan.GetID();
            compañiaBox.Text = miPlan.GetCompañía();
            origenXBox.Text = Convert.ToString(miPlan.GetIX());
            OrigenYBox.Text = Convert.ToString(miPlan.GetIY());
            destinoYBox.Text = Convert.ToString(miPlan.GetFX());
            DestinoXbox.Text = Convert.ToString(miPlan.GetFY());
            velocidadBox.Text=Convert.ToString(miPlan.GetVelocidad());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
