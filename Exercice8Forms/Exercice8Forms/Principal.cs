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
        //Point PO, PD, PO2, PD2;

        double distSeg;

        double tiempo;

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
            //PO = formulario.DamePoint1();
            //PD = formulario.DamePoint2();
            //PO2 = formulario.DamePoint11();
            //PD2 = formulario.DamePoint22();
        }

        private void introducirTiempoDeCicloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IntroducirTiempoForm formularioTiempo = new IntroducirTiempoForm();
            formularioTiempo.ShowDialog();
            tiempo = formularioTiempo.DameTiempo();
            distSeg = formularioTiempo.DameDistSeg();

        }

        private void simularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SimularForm formulario = new SimularForm();

            //enviar al formulario secundario
            formulario.TomaDatos(miPlan1, miPlan2, tiempo,distSeg);
            //formulario.TomaMasDatos(PO, PD, PO2, PD2);

            formulario.ShowDialog();

        }
    }

    //public class PlanVuelo
    //{
    //    public string ID;
    //    public string compañia;
    //    public double velocidad;
    //    public Point Origen;
    //    public Point Destino;
    //}
}
