using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assinment_3
{
    public abstract class Planet 
    {
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;

        public double Diameter
        {
            get
            {
                return this._diameter;
            }
        }

        public double Mass
        {
            get
            {
                return this._mass;
            }

        }

        public int MoonCount
        {
            get
            {
                return this._moonCount;
            }

            set
            {
                this._mass = value;
            }
        }

        public String Name
        {
            get
            {
                return this._name;
            }
        }

        public double OrbitalPeriod
        {
            get
            {
                return this._orbitalPeriod;
            }

            set
            {
                this._orbitalPeriod = value;
            }
        }

        public int RingCount
        {
            get
            {
                return this._ringCount;
            }

            set
            {
                this._ringCount = value;
            }
        }

        public double RotationPeriod
        {
            get
            {
                return this._rotationPeriod;
            }

            set
            {
                this._rotationPeriod = value;
            }
        }


        public Planet(string name, double diameter, double mass)
        {
            this._name = name;
            this._diameter = diameter;
            this._mass = mass;

        }

        public override string ToString()
        {
            string returnString = "++++++++++++++++++++++++++++++++++++++++++";
            returnString += " " + "\n";
            returnString += "The Name Of The Planet Is    : " + this.Name + "\n";
            returnString += "The Diameter Of The Planet Is: " + this.Diameter + "\n";
            returnString += "The Mass Of The Planet Is    : " + this.Mass + "\n";
            returnString += "++++++++++++++++++++++++++++++++++++++++++";

            return returnString;
        }



    }
}