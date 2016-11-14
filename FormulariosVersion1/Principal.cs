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
    public partial class Principal : Form
    {
        FlightPlan miPlan1, miPlan2;
        double distSeg;
        double tiempo;
        Boolean PuedoMostrar = false;

        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido");
        }

        private void leerPlanDeVueloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IntroducirPlanDeVueloForm formulario = new IntroducirPlanDeVueloForm();
            formulario.ShowDialog();
            miPlan1 = formulario.DamePlan1();
            miPlan2 = formulario.DamePlan2();
            if (PuedoMostrar)
                simularToolStripMenuItem.Visible = true;
            else
                PuedoMostrar = true;

        }

        private void introducirTiempoDeCicloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IntroducirTiempoForm formularioTiempo = new IntroducirTiempoForm();
            formularioTiempo.ShowDialog();
            tiempo = formularioTiempo.DameTiempo();
            distSeg = formularioTiempo.DameDistSeg();
            if (PuedoMostrar)
                simularToolStripMenuItem.Visible = true;
            else
                PuedoMostrar = true;
        }

        private void simularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SimularForm formulario = new SimularForm();
            formulario.TomaDatos(miPlan1, miPlan2, tiempo,distSeg);
            formulario.ShowDialog();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();       
        }
    }

}
