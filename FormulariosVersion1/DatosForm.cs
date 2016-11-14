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
            origenXBox.Text = Convert.ToString(Math.Round(miPlan.GetIX(),2,MidpointRounding.ToEven));
            OrigenYBox.Text = Convert.ToString(Math.Round(miPlan.GetIY(),2,MidpointRounding.ToEven));
            destinoYBox.Text = Convert.ToString(Math.Round(miPlan.GetFX(),2,MidpointRounding.ToEven));
            DestinoXbox.Text = Convert.ToString(Math.Round(miPlan.GetFY(),2,MidpointRounding.ToEven));
            velocidadBox.Text = Convert.ToString(Math.Round(miPlan.GetVelocidad(),2,MidpointRounding.ToEven));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
