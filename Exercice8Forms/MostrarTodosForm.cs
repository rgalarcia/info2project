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
    public partial class MostrarTodosForm : Form
    {
        FlightPlan miPlan1;
        FlightPlan miPlan2;

        public MostrarTodosForm(FlightPlan Plan1, FlightPlan Plan2)
        {
            InitializeComponent();
            this.miPlan1 = Plan1;
            this.miPlan2 = Plan2;
        }

        private void MostrarTodosForm_Load(object sender, EventArgs e)
        {
            vuelosGrid.ColumnCount = 5;
            vuelosGrid.RowHeadersVisible = false;
            vuelosGrid.Columns[0].HeaderText = "ID";
            vuelosGrid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            vuelosGrid.Columns[1].HeaderText = "Actual X";
            vuelosGrid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            vuelosGrid.Columns[2].HeaderText = "Actual Y";
            vuelosGrid.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            vuelosGrid.Columns[3].HeaderText = "Velocidad";
            vuelosGrid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            vuelosGrid.Columns[4].HeaderText = "Distancia";
            vuelosGrid.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            vuelosGrid.Rows.Add(miPlan1.GetID(), miPlan1.GetIX(), miPlan1.GetIY(), miPlan1.GetVelocidad(),miPlan1.Distance(miPlan2));
            vuelosGrid.Rows.Add(miPlan2.GetID(), miPlan2.GetIX(), miPlan1.GetIY(), miPlan2.GetVelocidad(),miPlan2.Distance(miPlan1));

            vuelosGrid.ClearSelection();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void vuelosGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
