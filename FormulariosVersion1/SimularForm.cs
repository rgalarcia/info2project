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
    public partial class SimularForm : Form
    {
        FlightPlan miPlan1;
        FlightPlan miPlan2;
        double tiempo, distSeg;
        PictureBox vuelo1, vuelo2;
        Label etiqueta1, etiqueta2;
        Boolean pintar = false;
        Boolean automatico = false;

        public void TomaDatos(FlightPlan miPlana, FlightPlan miPlanb, double tiempo,double distanciadeseguridad)
        {
            this.miPlan1 = miPlana;
            this.miPlan2 = miPlanb;
            this.tiempo = tiempo;
            this.distSeg = distanciadeseguridad;
        }

        public SimularForm()
        {
            InitializeComponent();
        }

        private void SimularForm_Load(object sender, EventArgs e)
        {
            vuelo1 = new PictureBox();
            vuelo1.Size = new Size(10, 10);
            vuelo1.BackColor = Color.Black;
            vuelo1.Location = new Point(Convert.ToInt32(miPlan1.GetIX()-5),Convert.ToInt32(miPlan1.GetIY()-5)); 

            vuelo2 = new PictureBox();
            vuelo2.Size = new Size(10, 10);
            vuelo2.BackColor = Color.Black;
            vuelo2.Location = new Point(Convert.ToInt32(miPlan2.GetIX()-5), Convert.ToInt32(miPlan2.GetIY()-5));

            etiqueta2 = new Label();
            etiqueta2.Text = miPlan2.GetID();
            etiqueta2.Size = new Size(40, 20);
            etiqueta2.Location = new Point(Convert.ToInt32(miPlan2.GetIX()), Convert.ToInt32(miPlan2.GetIY())+3);
            etiqueta2.Tag = miPlan2;
            etiqueta2.MouseClick += new MouseEventHandler(Avion_click);

            etiqueta1 = new Label();
            etiqueta1.Text = miPlan1.GetID();
            etiqueta1.Size = new Size(40, 20);
            etiqueta1.Location = new Point(Convert.ToInt32(miPlan1.GetIX()), Convert.ToInt32(miPlan1.GetIY()) + 3);
            etiqueta1.Tag = miPlan1;
            etiqueta1.MouseClick += new MouseEventHandler(Avion_click);

            PictureBox destino1 = new PictureBox();
            destino1.Size = new Size(8, 8);
            destino1.BackColor = Color.Red;
            destino1.Location = new Point(Convert.ToInt32(miPlan1.GetFX()-4), Convert.ToInt32(miPlan1.GetFY()-4)); 

            PictureBox destino2 = new PictureBox();
            destino2.Size = new Size(8, 8);
            destino2.BackColor = Color.Red;
            destino2.Location = new Point(Convert.ToInt32(miPlan2.GetFX()-4), Convert.ToInt32(miPlan2.GetFY()-4));

            PictureBox origen1 = new PictureBox();
            origen1.Size = new Size(8, 8);
            origen1.BackColor = Color.Red;
            origen1.Location = new Point(Convert.ToInt32(miPlan1.GetIX()-4),Convert.ToInt32(miPlan1.GetIY()-4));

            PictureBox origen2 = new PictureBox();
            origen2.Size = new Size(8, 8);
            origen2.BackColor = Color.Red;
            origen2.Location = new Point(Convert.ToInt32(miPlan2.GetIX()-4), Convert.ToInt32(miPlan2.GetIY()-4));

            miPanel.Controls.Add(destino1);
            miPanel.Controls.Add(origen1);
            miPanel.Controls.Add(etiqueta1);
            miPanel.Controls.Add(destino2);
            miPanel.Controls.Add(origen2);      
            miPanel.Controls.Add(etiqueta2);
            miPanel.Controls.Add(vuelo2);
            miPanel.Controls.Add(vuelo1);

            pintar = true;
            miPanel.Invalidate();

            plan1label.Text = Convert.ToString(miPlan1.GetID());
            plan2label.Text = Convert.ToString(miPlan2.GetID());
            speedV1.Text = Convert.ToString(miPlan1.GetVelocidad());
            speedV2.Text = Convert.ToString(miPlan2.GetVelocidad());
        }

        //Objeto que ha recibido el click = sender, E informaciones que pueden ser utiles
        private void Avion_click(object sender, MouseEventArgs e)
        {
            DatosForm formulario;
            //recupero el Label sobre el que he clicado
            Label p = (Label) sender;
            //que Label es?
            //recupero el tag
            formulario = new DatosForm((FlightPlan)p.Tag);
            formulario.ShowDialog();
       
        }
        
        private void button3_Click(object sender, EventArgs e)
        {

            miPlan1.Move(tiempo);
           
            miPlan2.Move(tiempo);

            PintarVuelos();

        }

        private void miPanel_Paint(object sender, PaintEventArgs e)
        {
            if (pintar)
            {
                Graphics graficos = miPanel.CreateGraphics();
                graficos.DrawLine(new Pen(Color.Red), new Point(Convert.ToInt32(miPlan1.GetIX()),Convert.ToInt32(miPlan1.GetIY())),new Point(Convert.ToInt32(miPlan1.GetFX()),Convert.ToInt32(miPlan1.GetFY()))); 
                graficos.DrawLine(new Pen(Color.Green), new Point(Convert.ToInt32(miPlan1.Getposix()), Convert.ToInt32(miPlan1.Getposiy())), new Point(Convert.ToInt32(miPlan1.GetIX()), Convert.ToInt32(miPlan1.GetIY()))); 

                graficos.DrawLine(new Pen(Color.Red), new Point(Convert.ToInt32(miPlan2.GetIX()), Convert.ToInt32(miPlan2.GetIY())), new Point(Convert.ToInt32(miPlan2.GetFX()), Convert.ToInt32(miPlan2.GetFY()))); 
                graficos.DrawLine(new Pen(Color.Green), new Point(Convert.ToInt32(miPlan2.Getposix()), Convert.ToInt32(miPlan2.Getposiy())), new Point(Convert.ToInt32(miPlan2.GetIX()), Convert.ToInt32(miPlan2.GetIY())));            

                if (miPlan1.Distance(miPlan2) < distSeg)
                {
                    Point esquina11 = new Point(Convert.ToInt32(miPlan1.GetIX() - distSeg / 2), Convert.ToInt32(miPlan1.GetIY() - distSeg / 2));
                    Size tamaño11 = new Size(Convert.ToInt32(distSeg), Convert.ToInt32(distSeg));
                    graficos.FillEllipse(new SolidBrush(Color.Red), new Rectangle(esquina11, tamaño11));

                    Point esquina22 = new Point(Convert.ToInt32(miPlan2.GetIX() - distSeg / 2), Convert.ToInt32(miPlan2.GetIY() - distSeg / 2));
                    Size tamaño22 = new Size(Convert.ToInt32(distSeg), Convert.ToInt32(distSeg));
                    graficos.FillEllipse(new SolidBrush(Color.Red), new Rectangle(esquina22, tamaño22));
                }
                else
                {
                    Point esquina = new Point(Convert.ToInt32(miPlan1.GetIX() - distSeg / 2), Convert.ToInt32(miPlan1.GetIY() - distSeg / 2));
                    Size tamaño = new Size (Convert.ToInt32(distSeg),Convert.ToInt32(distSeg));
                    graficos.DrawEllipse (new Pen (Color.Red),new Rectangle(esquina,tamaño));

                    Point esquina2 = new Point(Convert.ToInt32(miPlan2.GetIX() - distSeg / 2), Convert.ToInt32(miPlan2.GetIY() - distSeg / 2)); 
                    Size tamaño2 = new Size (Convert.ToInt32(distSeg),Convert.ToInt32(distSeg));
                    graficos.DrawEllipse (new Pen (Color.Red),new Rectangle(esquina2,tamaño2));
                }

                graficos.Dispose();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarTodosForm formulario = new MostrarTodosForm (miPlan1, miPlan2);
            formulario.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (automatico)
            {
                button2.Text = "Iniciar Simulación Automatica";
                Reloj.Stop();
                automatico = false;
            }
            else
            {
                //que me avise cada 1000 milisegundos
                try
                {
                    Reloj.Interval = Convert.ToInt32(Convert.ToDouble(tiempoBox.Text)*1000);
                    Reloj.Start();
                    button2.Text = "Parar Simulacion Automatica";
                    automatico = true;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Datos no introducidos");
                }    
            }
        }

        private void Reloj_Tick(object sender, EventArgs e)
        {
            miPlan1.Move(tiempo);
            miPlan2.Move(tiempo);
            
            PintarVuelos();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            miPlan1.Restart();
            miPlan2.Restart();
            PintarVuelos();

        }
        private void PintarVuelos()
        {
            vuelo1.Location = new Point(Convert.ToInt32(miPlan1.GetIX()-5),Convert.ToInt32(miPlan1.GetIY()-5));  
            etiqueta1.Location = new Point(Convert.ToInt32(miPlan1.GetIX()+10),Convert.ToInt32(miPlan1.GetIY()));    
            vuelo2.Location = new Point(Convert.ToInt32(miPlan2.GetIX()-5), Convert.ToInt32(miPlan2.GetIY()-5));   
            etiqueta2.Location = new Point(Convert.ToInt32(miPlan2.GetIX()+10),Convert.ToInt32(miPlan2.GetIY()));     
            miPanel.Invalidate();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Calcular si habrá un conflicto.
            double velocidad1=miPlan1.GetVelocidad();
            double velocidad2 = miPlan2.GetVelocidad();

            if (miPlan1.hayConflicto(miPlan2, distSeg))
            {
                ConflictoForm CF = new ConflictoForm();
                CF.tomadatos(velocidad1,velocidad2,miPlan1,miPlan2,distSeg);
                CF.ShowDialog();
                miPlan1=CF.getflight1();
                miPlan2=CF.getflight2();
                speedV1.Text = Convert.ToString(miPlan1.GetVelocidad());
                speedV2.Text = Convert.ToString(miPlan2.GetVelocidad());
            }
            else
                MessageBox.Show("No hay ningún conflicto");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (V1Box.Text != "")
                {
                    miPlan1.SetVelocidad(Convert.ToDouble(V1Box.Text));
                    V1Box.Text = "";
                }
                if (V2Box.Text != "")
                {
                    miPlan2.SetVelocidad(Convert.ToDouble(V2Box.Text));
                    V1Box.Text = "";
                }
                speedV1.Text = Convert.ToString(miPlan1.GetVelocidad());
                speedV2.Text = Convert.ToString(miPlan2.GetVelocidad());
            }
            catch (FormatException)
            {
                MessageBox.Show("Error en el formato de los datos");
            }
            miPlan1.Restart();
            miPlan2.Restart();
            miPanel.Invalidate();
            PintarVuelos();
        }

    }
}
