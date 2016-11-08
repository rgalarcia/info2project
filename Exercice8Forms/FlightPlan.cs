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

        public FlightPlan(string ID, string compañía, double velocidad, double IX, double IY, double FX, double FY,double posix,double posiy)
        {
            this.ID = ID;
            this.compañía = compañía;
            this.velocidad = velocidad;
            this.IX = IX;
            this.IY = IY;
            this.FX = FX;
            this.FY = FY;
            this.posix = posix;
            this.posiy = posiy;
        }

        public Boolean HasArrived()
        {
            double H1 = Math.Sqrt((this.IX - this.posix) * (this.IX - this.posix) + (this.IY - this.posiy) * (this.IY - this.posiy));
            double H2 = Math.Sqrt((this.FX - this.posix) * (this.FX - this.posix) + (this.FY - this.posiy) * (this.FY - this.IY));

            if (H1>H2)
                return true;
            else
                return false;
        }

        public void Move(double tiempo)
        {
            double D = tiempo * this.velocidad / 60;

            double H = Math.Sqrt((this.FX - this.IX) * (this.FX - this.IX) + (this.FY - this.IY) * (this.FY - this.IY));
            double H1 = Math.Sqrt((this.IX - this.posix) * (this.IX - this.posix) + (this.IY - this.posiy) * (this.IY - this.posiy));
            double H2 = Math.Sqrt((this.FX - this.posix) * (this.FX - this.posix) + (this.FY - this.posiy) * (this.FY - this.IY));
            if (H == 0)
                H = 1;
            double C = (this.FX - this.IX) / H;
            double S = (this.FY - this.IY) / H;

            this.IX = this.IX + D * C;
            this.IY = this.IY + D * S;
            
            if (H1>H2)
            {
                this.IX = this.FX;
                this.IY = this.FY;
            }

        }

        public Boolean hayConflicto(FlightPlan planB, double DistSeg)
        {
            double H = Math.Sqrt((this.FX - this.IX) * (this.FX - this.IX) + (this.FY - this.IY) * (this.FY - this.IY));
            if (H == 0)
                H = 1;
            double Cosa = (this.FX - this.IX) / H;
            double Sina = (this.FY - this.IY) / H;

            double H2 = Math.Sqrt((planB.FX - planB.IX) * (planB.FX - planB.IX) + (planB.FY - planB.IY) * (planB.FY - planB.IY));
            if (H2 == 0)
                H2 = 1;
            double Cosb = (planB.FX - planB.IX) / H2;
            double Sinb = (planB.FY - planB.IY) / H2;

            double t = (((this.IX - planB.IX) * (this.velocidad * Cosa - planB.velocidad * Cosb) + (this.IY - planB.IY) * (this.velocidad * Sina - planB.velocidad * Sinb)) * (-60)) / (this.velocidad * this.velocidad * Cosa * Cosa + planB.velocidad * planB.velocidad * Cosb * Cosb - 2 * this.velocidad * planB.velocidad * Cosb * Cosa + this.velocidad * this.velocidad * Sina * Sina + planB.velocidad * planB.velocidad * Sinb * Sinb - 2 * this.velocidad * planB.velocidad * Sinb * Sina);
            double distmin = Math.Sqrt(((this.IX + t * Cosa * this.velocidad / 60) - (planB.IX + t * Cosb * planB.velocidad / 60)) * ((this.IX + t * Cosa * this.velocidad / 60) - (planB.IX + t * Cosb * planB.velocidad / 60)) + ((this.IY + t * Sina * this.velocidad / 60) - (planB.IY + t * Sinb * planB.velocidad / 60)) * ((this.IY + t * Sina * this.velocidad / 60) - (planB.IY + t * Sinb * planB.velocidad / 60)));

            if (distmin < DistSeg)
                return true;
            else
                return false;

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
        
        public double Getposix()
        {
            return this.posix;
        }
        public double Getposiy()
        {
            return this.posiy;
        }

    }
}
