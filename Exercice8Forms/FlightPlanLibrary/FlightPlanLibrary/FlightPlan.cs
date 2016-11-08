using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlightPlanLibrary
{
    public class FlightPlan
    {
        string ID;
        string compañía;
        double velocidad;
        double IX;
        double IY;
        double posix;
        double posiy;
        double FX;
        double FY;

        public FlightPlan()
        {

        }

        public Boolean HasArrived()
        {
            if (this.IX >= this.FX && this.IY >= this.FY)
                return true;
            else
                return false;
        }

        public void Move(double tiempo)
        {
            double D = tiempo * this.velocidad / 60;

            double H = Math.Sqrt((this.FX - this.IX) * (this.FX - this.IX) + (this.FY - this.IY) * (this.FY - this.IY));
            if (H == 0)
                H = 1;
            double C = (this.FX - this.IX) / H;
            double S = (this.FY - this.IY) / H;

            this.IX = this.IX + D * C;
            this.IY = this.IY + D * S;

            if (this.IX > this.FX && this.IY > this.FY)
            {
                this.IX = this.FX;
                this.IY = this.FY;
            }

        }

        public void Restart()
        {
            this.IX = this.posix;
            this.IY = this.posiy;
        }

        public double Distance(FlightPlan plan)
        {
            return Math.Sqrt((this.IX - plan.GetIX()) * (this.IX - plan.GetIX()) + (this.IY - plan.GetIY()) * (this.IY - plan.GetIY()));
        }

        public void SetID(string ID)
        {
            this.ID = ID;
        }

        public string GetID()
        {
            return this.ID;
        }

        public void SetCompañía(string compañía)
        {
            this.compañía = compañía;
        }

        public string GetCompañía()
        {
            return this.compañía;
        }

        public void SetVelocidad(double velocidad)
        {
            this.velocidad = velocidad;
        }

        public double GetVelocidad()
        {
            return this.velocidad;
        }

        public void SetIX(double IX)
        {
            this.IX = IX;
            this.posix = IX;
        }

        public void SetIY(double IY)
        {
            this.IY = IY;
            this.posiy = IY;
        }

        public void SetFX(double FX)
        {
            this.FX = FX;
        }

        public void SetFY(double FY)
        {
            this.FY = FY;
        }

        public double GetIX()
        {
            return this.IX;
        }

        public double GetIY()
        {
            return this.IY;
        }

        public double GetFX()
        {
            return this.FX;
        }

        public double GetFY()
        {
            return this.FY;
        }

    }
}
