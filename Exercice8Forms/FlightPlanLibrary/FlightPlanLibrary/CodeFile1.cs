using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        class FlightPlan
        {
            public string ID;
            public string compañia;
            public double velocidad;
            public double IX;
            public double IY;
            public double FX;
            public double FY;
        }

        static void escribeDatosVuelo(FlightPlan v)
        {
            Console.WriteLine("******************************");
            Console.WriteLine("******************************");
            Console.WriteLine("Datos del vuelo: ");
            Console.WriteLine("Compañia: {0}", v.compañia);
            Console.WriteLine("Velocidad: {0}", v.velocidad);
            Console.WriteLine("Posición actual: ({0},{1})", v.IX, v.IY);
            Console.WriteLine("******************************");
        }

        static double distancia(FlightPlan a, FlightPlan b)
        {
            return Math.Sqrt((a.IX - b.IX) * (a.IX - b.IX) + (a.IY - b.IY) * (a.IY - b.IY));
        }

        static void MoverVuelo(FlightPlan plan, double tiempo)
        {
            double D = tiempo * plan.velocidad / 60;

            double H = Math.Sqrt((plan.FX - plan.IX) * (plan.FX - plan.IX) + (plan.FY - plan.IY) * (plan.FY - plan.IY));
            if (H == 0)
                H=1;
            double C = (plan.FX - plan.IX) / H;
            double S = (plan.FY - plan.IY) / H;

             plan.IX = plan.IX + D * C;
             plan.IY = plan.IY + D * S;

            if (plan.IX > plan.FX && plan.IY > plan.FY)
            {
                plan.IX = plan.FX;
                plan.IY = plan.FY;
            }

        }

        // Hacer una función para leer los datos de un vuelo
        static void leeDatosVuelo(FlightPlan plan)
        {

                Console.WriteLine("Escriba el nombre de la compañia");
                plan.compañia = Console.ReadLine();

                Console.WriteLine("Escriba la velocidad");
                plan.velocidad = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Escribe las coordenadas de la posición inicial, separadas por un blanco");
                string linea = Console.ReadLine();
                string[] trozos = linea.Split(' ');
                plan.IX = Convert.ToInt32(trozos[0]);
                plan.IY = Convert.ToInt32(trozos[1]);

                Console.WriteLine("Escribe las coordenadas de la posición final, separadas por un blanco");
                linea = Console.ReadLine();
                trozos = linea.Split(' ');
                plan.FX = Convert.ToInt32(trozos[0]);
                plan.FY = Convert.ToInt32(trozos[1]);
        }

        static void Main(string[] args)
        {
            try
            {
                FlightPlan a = new FlightPlan();
                leeDatosVuelo(a);
                escribeDatosVuelo(a);

                FlightPlan b = new FlightPlan();
                leeDatosVuelo(b);
                escribeDatosVuelo(b);


                Console.WriteLine("Escribe el tiempo de ciclo (minutos): ");
                double t = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Escribe la distancia de seguridad (nm): ");
                double ds = Convert.ToDouble(Console.ReadLine());

                if (t < 0)
                    Console.WriteLine("Error en el tiempo de ciclo");
                {
                    int i = 0;
                    bool fin = false;

                    do
                    {
                        MoverVuelo(a, t);
                        MoverVuelo(b, t);
                        escribeDatosVuelo(a);
                        escribeDatosVuelo(b);

                        if (distancia(a, b) <= ds)
                        {
                            Console.WriteLine("Distancia de seguridad violada.");
                        }

                        i = i + 1;

                        if (a.IX == a.FX && b.IX == b.FX)
                        {
                            Console.WriteLine("Los dos vuelos han llegado a su destino.");
                            fin = true;
                        }
                        else if (a.IX == a.FX)
                        {
                            Console.WriteLine("El vuelo {0} ha llegado a su destino", a.ID);
                        }
                        else if (b.IX == b.FX)
                        {
                            Console.WriteLine("El vuelo {0} ha llegado a su destino", b.ID);
                        }

                    } while (!fin);
                }
                Console.ReadLine();

            }
            catch (FormatException)
            {

                Console.WriteLine("Error en el formato de los datos");
                Console.ReadLine();
            }
        }

    }
}