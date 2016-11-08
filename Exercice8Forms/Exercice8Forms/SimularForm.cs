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
        //Point PO, PD, PO2, PD2;
        Boolean pintar = false;
        Boolean automatico = false;

        public void TomaDatos(FlightPlan miPlana, FlightPlan miPlanb, double tiempo,double distanciadeseguridad)
        {
            this.miPlan1 = miPlana;
            this.miPlan2 = miPlanb;
            this.tiempo = tiempo;
            this.distSeg = distanciadeseguridad;
        }


        //public void TomaMasDatos(Point P1, Point P2, Point P3, Point P4)
        //{
        //    this.PO = P1;
        //    this.PD = P2;
        //    this.PO2 = P3;
        //    this.PD2 = P4;
        //}

        public SimularForm()
        {
            InitializeComponent();
        }

        private void SimularForm_Load(object sender, EventArgs e)
        {
            vuelo1 = new PictureBox();
            vuelo1.Size = new Size(9, 9);
            vuelo1.BackColor = Color.Black;
            //vuelo.Image = Image.FromFile("avion.jpg");
            //vuelo.SizeMode = PictureBoxSizeMode.StretchImage;
            ////ajustar el picture boz al tamaño de la imagen
            //vuelo.Size = vuelo.Image.Size;
            vuelo1.Location = new Point(Convert.ToInt32(miPlan1.GetIX()),Convert.ToInt32(miPlan1.GetIY())); //miPlan1.Origen.X, miPlan1.Origen.Y);
            vuelo1.MouseClick += new MouseEventHandler(Avion_click);
            //para saber que picture box se trata
            vuelo1.Tag = miPlan1;

            vuelo2 = new PictureBox();
            vuelo2.Size = new Size(9, 9);
            vuelo2.BackColor = Color.Black;
            //vuelo.Image = Image.FromFile("avion.jpg");
            //vuelo.SizeMode = PictureBoxSizeMode.StretchImage;
            ////ajustar el picture boz al tamaño de la imagen
            //vuelo.Size = vuelo.Image.Size;
            vuelo2.Location = new Point(Convert.ToInt32(miPlan2.GetIX()), Convert.ToInt32(miPlan2.GetIY()));//(miPlan2.Origen.X, miPlan2.Origen.Y);
            vuelo2.MouseClick += new MouseEventHandler(Avion_click);
            //admite cualquier cosa
            vuelo2.Tag = miPlan2;

            etiqueta2 = new Label();
            etiqueta2.Text = miPlan2.GetID();
            etiqueta2.Location = new Point(Convert.ToInt32(miPlan2.GetIX()), Convert.ToInt32(miPlan2.GetIY())+3);//(miPlan2.Origen.X, miPlan2.Origen.Y + 3);

            etiqueta1 = new Label();
            etiqueta1.Text = miPlan1.GetID();
            etiqueta1.Location = new Point(Convert.ToInt32(miPlan1.GetIX()), Convert.ToInt32(miPlan1.GetIY()) + 3);//(miPlan1.Origen.X, miPlan1.Origen.Y + 3);

            PictureBox destino1 = new PictureBox();
            destino1.Size = new Size(8, 8);
            destino1.BackColor = Color.Red;
            destino1.Location = new Point(Convert.ToInt32(miPlan1.GetFX()), Convert.ToInt32(miPlan1.GetFY())); //(miPlan1.Destino.X, miPlan1.Destino.Y);

            PictureBox destino2 = new PictureBox();
            destino2.Size = new Size(8, 8);
            destino2.BackColor = Color.Red;
            destino2.Location = new Point(Convert.ToInt32(miPlan2.GetFX()), Convert.ToInt32(miPlan2.GetFY()));//(miPlan2.Destino.X, miPlan2.Destino.Y);

            PictureBox origen1 = new PictureBox();
            origen1.Size = new Size(8, 8);
            origen1.BackColor = Color.Red;
            origen1.Location = new Point(Convert.ToInt32(miPlan1.GetIX()),Convert.ToInt32(miPlan1.GetIY()));//(miPlan1.Origen.X, miPlan1.Origen.Y);

            PictureBox origen2 = new PictureBox();
            origen2.Size = new Size(8, 8);
            origen2.BackColor = Color.Red;
            origen2.Location = new Point(Convert.ToInt32(miPlan2.GetIX()), Convert.ToInt32(miPlan2.GetIY()));//(miPlan2.Origen.X, miPlan2.Origen.Y);

            miPanel.Controls.Add(destino1);
            miPanel.Controls.Add(origen1);
            miPanel.Controls.Add(vuelo1);
            miPanel.Controls.Add(etiqueta1);
            miPanel.Controls.Add(destino2);
            miPanel.Controls.Add(origen2);
            miPanel.Controls.Add(vuelo2);
            miPanel.Controls.Add(etiqueta2);

            pintar = true;
            miPanel.Invalidate();
        }

        //Objeto que ha recibido el click = sender, E informaciones que pueden ser utiles
        private void Avion_click(object sender, MouseEventArgs e)
        {
            DatosForm formulario;
            //recupero el picture box sobre el que he clicado
            PictureBox p = (PictureBox) sender;
            //que picturebox es?
            //recupero el tag
            formulario = new DatosForm((FlightPlan)p.Tag);
            formulario.ShowDialog();
       
        }
        
        private void button3_Click(object sender, EventArgs e)
        {

            miPlan1.Move(tiempo);
           
            miPlan2.Move(tiempo);



            //double D1 = tiempo * miPlan1.velocidad / 60;
            //double D2 = tiempo * miPlan2.velocidad / 60;
            ////comprobar que no me paso

            ////Calculamos las razones trigonométricas
            //double H1 = Math.Sqrt((miPlan1.Destino.X - miPlan1.Origen.X) * (miPlan1.Destino.X - miPlan1.Origen.X) + (miPlan1.Destino.Y - miPlan1.Origen.Y) * (miPlan1.Destino.Y - miPlan1.Origen.Y));
            //double H2 = Math.Sqrt((miPlan2.Destino.X - miPlan2.Origen.X) * (miPlan2.Destino.X - miPlan2.Origen.X) + (miPlan2.Destino.Y - miPlan2.Origen.Y) * (miPlan2.Destino.Y - miPlan2.Origen.Y));

            //if (H1 < D1) //si la distancia que me voy a mover es mas grande de la que me separa
            //{
            //    //me paso
            //    miPlan1.Origen.X = miPlan1.Destino.X;
            //    miPlan1.Origen.Y = miPlan1.Destino.Y;
            //}
            //else
            //{
            //    double C1 = (miPlan1.Destino.X - miPlan1.Origen.X) / H1;
            //    double S1 = (miPlan1.Destino.Y - miPlan1.Origen.Y) / H1;


            //    //Caculamos la nueva posición del vuelo
            //    miPlan1.Origen.X = Convert.ToInt32(miPlan1.Origen.X + D1 * C1);
            //    miPlan1.Origen.Y = Convert.ToInt32(miPlan1.Origen.Y + D1 * S1);
            //}

            //if (H2 < D2) //si la distancia que me voy a mover es mas grande de la que me separa
            //{
            //    //me paso
            //    miPlan2.Origen.X = miPlan2.Destino.X;
            //    miPlan2.Origen.Y = miPlan2.Destino.Y;
            //}
            //else
            //{
            //    double C2 = (miPlan2.Destino.X - miPlan2.Origen.X) / H2;
            //    double S2 = (miPlan2.Destino.Y - miPlan2.Origen.Y) / H2;


            //    //Caculamos la nueva posición del vuelo
            //    miPlan2.Origen.X = Convert.ToInt32(miPlan2.Origen.X + D1 * C2);
            //    miPlan2.Origen.Y = Convert.ToInt32(miPlan2.Origen.Y + D1 * S2);
            //}

            PintarVuelos();

            //miro la distancia

            //double distancia = Math.Sqrt((miPlan1.Origen.X - miPlan2.Origen.X) * (miPlan1.Origen.X - miPlan2.Origen.X) + (miPlan1.Origen.Y - miPlan2.Origen.Y) * (miPlan1.Origen.Y - miPlan2.Origen.Y));

        }

        private void miPanel_Paint(object sender, PaintEventArgs e)
        {
            if (pintar)
            {
                Graphics graficos = miPanel.CreateGraphics();
                graficos.DrawLine(new Pen(Color.Red), new Point(Convert.ToInt32(miPlan1.GetIX()),Convert.ToInt32(miPlan1.GetIY())),new Point(Convert.ToInt32(miPlan1.GetFX()),Convert.ToInt32(miPlan1.GetFY()))); //(miPlan1.Origen.X, miPlan1.Origen.Y), PD);
                graficos.DrawLine(new Pen(Color.Green), new Point(Convert.ToInt32(miPlan1.Getposix()), Convert.ToInt32(miPlan1.Getposiy())), new Point(Convert.ToInt32(miPlan1.GetIX()), Convert.ToInt32(miPlan1.GetIY()))); //(new Pen(Color.Green), PO, new Point(miPlan1.Origen.X, miPlan1.Origen.Y));

                graficos.DrawLine(new Pen(Color.Red), new Point(Convert.ToInt32(miPlan2.GetIX()), Convert.ToInt32(miPlan2.GetIY())), new Point(Convert.ToInt32(miPlan2.GetFX()), Convert.ToInt32(miPlan2.GetFY()))); //(new Pen(Color.Red), new Point(miPlan2.Origen.X, miPlan2.Origen.Y), PD2);
                graficos.DrawLine(new Pen(Color.Green), new Point(Convert.ToInt32(miPlan2.Getposix()), Convert.ToInt32(miPlan2.Getposiy())), new Point(Convert.ToInt32(miPlan2.GetIX()), Convert.ToInt32(miPlan2.GetIY()))); //(new Pen(Color.Green), PO2, new Point(miPlan2.Origen.X, miPlan2.Origen.Y));

                //distancia = Math.Sqrt((miPlan1.Origen.X - miPlan2.Origen.X) * (miPlan1.Origen.X - miPlan2.Origen.X) + (miPlan1.Origen.Y - miPlan2.Origen.Y) * (miPlan1.Origen.Y - miPlan2.Origen.Y));

                if (miPlan1.Distance(miPlan2) < distSeg)
                {
                    Point esquina11 = new Point(Convert.ToInt32(miPlan1.GetIX() - distSeg / 2), Convert.ToInt32(miPlan1.GetIY() - distSeg / 2));//(Convert.ToInt32(miPlan1.Origen.X - distSeg / 2), Convert.ToInt32(miPlan1.Origen.Y - distSeg / 2));
                    Size tamaño11 = new Size(Convert.ToInt32(distSeg), Convert.ToInt32(distSeg));
                    graficos.FillEllipse(new SolidBrush(Color.Red), new Rectangle(esquina11, tamaño11));

                    Point esquina22 = new Point(Convert.ToInt32(miPlan2.GetIX() - distSeg / 2), Convert.ToInt32(miPlan2.GetIY() - distSeg / 2));//(Convert.ToInt32(miPlan2.Origen.X - distSeg / 2), Convert.ToInt32(miPlan2.Origen.Y - distSeg / 2));
                    Size tamaño22 = new Size(Convert.ToInt32(distSeg), Convert.ToInt32(distSeg));
                    graficos.FillEllipse(new SolidBrush(Color.Red), new Rectangle(esquina22, tamaño22));
                }
                else
                {
                    Point esquina = new Point(Convert.ToInt32(miPlan1.GetIX() - distSeg / 2), Convert.ToInt32(miPlan1.GetIY() - distSeg / 2)); //(Convert.ToInt32( miPlan1.Origen.X - distSeg/2),Convert.ToInt32( miPlan1.Origen.Y - distSeg/2));
                    Size tamaño = new Size (Convert.ToInt32(distSeg),Convert.ToInt32(distSeg));
                    graficos.DrawEllipse (new Pen (Color.Red),new Rectangle(esquina,tamaño));

                    Point esquina2 = new Point(Convert.ToInt32(miPlan2.GetIX() - distSeg / 2), Convert.ToInt32(miPlan2.GetIY() - distSeg / 2)); //(Convert.ToInt32( miPlan2.Origen.X - distSeg/2),Convert.ToInt32( miPlan2.Origen.Y - distSeg/2));
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
                Reloj.Interval = Convert.ToInt32(tiempoBox.Text);
                Reloj.Start();
                button2.Text = "Parar Simulacion Automatica";
                automatico = true;
            }
        }

        private void Reloj_Tick(object sender, EventArgs e)
        {
            miPlan1.Move(tiempo);
            miPlan2.Move(tiempo);
            //double D1 = tiempo * miPlan1.velocidad / 60;
            //double D2 = tiempo * miPlan2.velocidad / 60;
            ////comprobar que no me paso

            ////Calculamos las razones trigonométricas
            //double H1 = Math.Sqrt((miPlan1.Destino.X - miPlan1.Origen.X) * (miPlan1.Destino.X - miPlan1.Origen.X) + (miPlan1.Destino.Y - miPlan1.Origen.Y) * (miPlan1.Destino.Y - miPlan1.Origen.Y));
            //double H2 = Math.Sqrt((miPlan2.Destino.X - miPlan2.Origen.X) * (miPlan2.Destino.X - miPlan2.Origen.X) + (miPlan2.Destino.Y - miPlan2.Origen.Y) * (miPlan2.Destino.Y - miPlan2.Origen.Y));

            //if (H1 < D1) //si la distancia que me voy a mover es mas grande de la que me separa
            //{
            //    //me paso
            //    miPlan1.Origen.X = miPlan1.Destino.X;
            //    miPlan1.Origen.Y = miPlan1.Destino.Y;
            //}
            //else
            //{
            //    double C1 = (miPlan1.Destino.X - miPlan1.Origen.X) / H1;
            //    double S1 = (miPlan1.Destino.Y - miPlan1.Origen.Y) / H1;


            //    //Caculamos la nueva posición del vuelo
            //    miPlan1.Origen.X = Convert.ToInt32(miPlan1.Origen.X + D1 * C1);
            //    miPlan1.Origen.Y = Convert.ToInt32(miPlan1.Origen.Y + D1 * S1);
            //}

            //if (H2 < D2) //si la distancia que me voy a mover es mas grande de la que me separa
            //{
            //    //me paso
            //    miPlan2.Origen.X = miPlan2.Destino.X;
            //    miPlan2.Origen.Y = miPlan2.Destino.Y;
            //}
            //else
            //{
            //    double C2 = (miPlan2.Destino.X - miPlan2.Origen.X) / H2;
            //    double S2 = (miPlan2.Destino.Y - miPlan2.Origen.Y) / H2;


            //    //Caculamos la nueva posición del vuelo
            //    miPlan2.Origen.X = Convert.ToInt32(miPlan2.Origen.X + D1 * C2);
            //    miPlan2.Origen.Y = Convert.ToInt32(miPlan2.Origen.Y + D1 * S2);
            //}

            PintarVuelos();


            //miro la distancia

            //double distancia = Math.Sqrt((miPlan1.Origen.X - miPlan2.Origen.X) * (miPlan1.Origen.X - miPlan2.Origen.X) + (miPlan1.Origen.Y - miPlan2.Origen.Y) * (miPlan1.Origen.Y - miPlan2.Origen.Y));

        }

        private void button4_Click(object sender, EventArgs e)
        {
            miPlan1.Restart();
            miPlan2.Restart();
            PintarVuelos();

        }
        private void PintarVuelos()
        {
            vuelo1.Location = new Point(Convert.ToInt32(miPlan1.GetIX()),Convert.ToInt32(miPlan1.GetIY()));     //(miPlan1.Origen.X, miPlan1.Origen.Y);
            etiqueta1.Location = new Point(Convert.ToInt32(miPlan1.GetIX()+10),Convert.ToInt32(miPlan1.GetIY()));     //(miPlan1.Origen.X + 10, miPlan1.Origen.Y);
            vuelo2.Location = new Point(Convert.ToInt32(miPlan2.GetIX()), Convert.ToInt32(miPlan2.GetIY()));    //(miPlan2.Origen.X, miPlan2.Origen.Y);
            etiqueta2.Location = new Point(Convert.ToInt32(miPlan2.GetIX()+10),Convert.ToInt32(miPlan2.GetIY()));     //(miPlan2.Origen.X + 10, miPlan2.Origen.Y);
            miPanel.Invalidate();

        }

        public bool hayConflicto(double dist_sec)
        {
            // En primer lugar definimos variables útiles para operar sin "carros" algebraicos
            double kx = Math.Abs(miPlan1.Getposix() - miPlan2.Getposix());
            double ky = Math.Abs(miPlan1.Getposiy() - miPlan2.Getposiy());
            double kv = Math.Abs(miPlan1.GetVelocidad() - miPlan2.GetVelocidad());


            double Hp1 = Math.Sqrt((miPlan1.GetFX() - miPlan1.GetIX()) * (miPlan1.GetFX() - miPlan1.GetIX()) + (miPlan1.GetFY() - miPlan1.GetIY()) * (miPlan1.GetFY() - miPlan1.GetIY()));
            double cosp1 = (miPlan1.GetFX() - miPlan1.GetIX()) / Hp1;
            double sinp1 = (miPlan1.GetFY() - miPlan1.GetIY()) / Hp1;
            double Hp2 = Math.Sqrt((miPlan2.GetFX() - miPlan2.GetIX()) * (miPlan2.GetFX() - miPlan2.GetIX()) + (miPlan2.GetFY() - miPlan2.GetIY()) * (miPlan2.GetFY() - miPlan2.GetIY()));
            double cosp2 = (miPlan2.GetFX() - miPlan2.GetIX()) / Hp2;
            double sinp2 = (miPlan2.GetFX() - miPlan2.GetIX()) / Hp2;

            double t = ( (kx * Math.Cos(cosp1) + ky * Math.Cos(cosp2)) / (kv * (Math.Pow(Math.Cos(cosp1), 2) + Math.Pow(Math.Cos(cosp2), 2))) );

            double ax = miPlan1.Getposix() + t * miPlan1.GetVelocidad() * cosp1;
            double ay = miPlan1.Getposiy() + t * miPlan1.GetVelocidad() * sinp1;
            double bx = miPlan2.Getposix() + t * miPlan2.GetVelocidad() * cosp2;
            double by = miPlan2.Getposiy() + t * miPlan2.GetVelocidad() * sinp2;


            double mindist = Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2))/2;
            //MessageBox.Show(t.ToString());
            //MessageBox.Show(mindist.ToString());

            if (mindist <= dist_sec)
                return true;
            else
                return false;
        }

        public bool resolverConflicto(double dist_sec)
        {
            bool conflicto = hayConflicto(dist_sec);
            while (conflicto && miPlan1.GetVelocidad() > 1)
            {
                miPlan1.SetVelocidad(miPlan1.GetVelocidad() - 1);
                conflicto = hayConflicto(dist_sec);
            }

            while (conflicto && miPlan2.GetVelocidad() > 1)
            {
                miPlan2.SetVelocidad(miPlan2.GetVelocidad() - 1);
                conflicto = hayConflicto(dist_sec);
            }

            if (hayConflicto(dist_sec))
                return false;
            else
                return true;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Calcular si habrá un conflicto.
            if (hayConflicto(distSeg))
            {
                MessageBox.Show("Hay un conflicto");
                button6.Visible = true;
            }
            else
                MessageBox.Show("No hay ningún conflicto");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Resolvemos el conflicto
            if (resolverConflicto(distSeg))
                MessageBox.Show("El conflicto se ha evitado");
            else
                MessageBox.Show("No fue posible evitar el conflicto");

            button6.Visible = false;
        }

    }
}
