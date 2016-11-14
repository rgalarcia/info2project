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
    public partial class ConflictoForm : Form
    {
        double velocidad1;
        double velocidad2;
        FlightPlan plan1,plan2;
        double distseg;

        public ConflictoForm()
        {
            InitializeComponent();
        }

        public void tomadatos(double vel1,double vel2, FlightPlan plan1, FlightPlan plan2,double distseg)
        {
            velocidad1=vel1;
            velocidad2 = vel2;
            this.plan1=plan1;
            this.plan2=plan2;
            this.distseg = distseg;
        }

        public FlightPlan getflight1()
        {
            return plan1;
        }

        public FlightPlan getflight2()
        {
            return plan2;
        }

        private void ConflictoForm_Load(object sender, EventArgs e)
        {
            plan1.resolverConflicto(plan2, distseg);
            v1label.Text = Convert.ToString(plan1.GetVelocidad());
            v2label.Text = Convert.ToString(plan2.GetVelocidad());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            plan1.SetVelocidad(velocidad1);
            plan2.SetVelocidad(velocidad2);
            Close();
        }




    }
}
