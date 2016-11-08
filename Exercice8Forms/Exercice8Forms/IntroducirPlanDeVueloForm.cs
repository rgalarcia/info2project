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
    public partial class IntroducirPlanDeVueloForm : Form
    {
        FlightPlan miPlan1;
        FlightPlan miPlan2;
        //Point PO, PD, PO2, PD2;

        public IntroducirPlanDeVueloForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            idBox.Text = "IB123";
            compañiaBox.Text = "Iberia";
            origenXBox.Text = "10";
            OrigenYBox.Text = "10";
            DestinoXbox.Text = "500";
            destinoYBox.Text = "300";
            velocidadBox.Text = "250";

            idBox2.Text = "VY222";
            compañia2Box.Text = "Vueling";
            origenX2Box.Text = "500";
            OrigenY2Box.Text = "20";
            DestinoX2box.Text = "50";
            destinoY2Box.Text = "300";
            velocidad2Box.Text = "250";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                miPlan1 = new FlightPlan(idBox.Text, compañiaBox.Text, Convert.ToDouble(velocidadBox.Text), Convert.ToDouble(origenXBox.Text), Convert.ToDouble(OrigenYBox.Text), Convert.ToDouble(DestinoXbox.Text), Convert.ToDouble(destinoYBox.Text),Convert.ToInt32(origenXBox.Text),Convert.ToInt32(OrigenYBox.Text));
                //miPlan1.SetID = idBox.Text;
                //miPlan1.compañia = compañiaBox.Text;
                //miPlan1.Origen.X = Convert.ToInt32(origenXBox.Text);
                //miPlan1.Origen.Y = Convert.ToInt32(OrigenYBox.Text);
                //miPlan1.Destino.X = Convert.ToInt32(DestinoXbox.Text);
                //miPlan1.Destino.Y = Convert.ToInt32(destinoYBox.Text);
                //miPlan1.velocidad = Convert.ToInt32(velocidadBox.Text);

                miPlan2 = new FlightPlan(idBox2.Text, compañia2Box.Text, Convert.ToDouble(velocidad2Box.Text), Convert.ToDouble(origenX2Box.Text), Convert.ToDouble(OrigenY2Box.Text), Convert.ToDouble(DestinoX2box.Text), Convert.ToDouble(destinoY2Box.Text), Convert.ToInt32(origenX2Box.Text), Convert.ToInt32(OrigenY2Box.Text)); ;
                //miPlan2.ID = idBox2.Text;
                //miPlan2.compañia = compañia2Box.Text;
                //miPlan2.Origen.X = Convert.ToInt32(origenX2Box.Text);
                //miPlan2.Origen.Y = Convert.ToInt32(OrigenY2Box.Text);
                //miPlan2.Destino.X = Convert.ToInt32(DestinoX2box.Text);
                //miPlan2.Destino.Y = Convert.ToInt32(destinoY2Box.Text);
                //miPlan2.velocidad = Convert.ToInt32(velocidad2Box.Text);

                //PO = miPlan1.Origen;
                //PD = miPlan1.Destino;
                //PO2 = miPlan2.Origen;
                //PD2 = miPlan2.Destino;

                MessageBox.Show("Datos introducidos correctamente");
                Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("ERROR en el formato de los datos, vuelve a intentarlo");
            }
           
        }

        public FlightPlan DamePlan1()
        {
            return this.miPlan1;
        }

        public FlightPlan DamePlan2()
        {
            return this.miPlan2;
        }

        //public Point DamePoint1()
        //{
        //    return this.PO;
        //}

        //public Point DamePoint2()
        //{
        //    return this.PD;
        //}
        //public Point DamePoint11()
        //{
        //    return this.PO2;
        //}

        //public Point DamePoint22()
        //{
        //    return this.PD2;
        //}

        private void IntroducirPlanDeVueloForm_Load(object sender, EventArgs e)
        {

        }

    }

}
