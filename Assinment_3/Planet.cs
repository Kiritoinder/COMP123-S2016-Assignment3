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
            set
            {
                this._diameter = value;
            }

        }

        public double Mass
        {
            get
            {
                return this._mass;
            }
            set
            {
                this._mass = value;
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
            set
            {
                this._name = value;
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
            this.Name = name;
            this.Diameter = diameter;
            this.Mass = mass;

        }

        public override string ToString()
        {
            string returnString = "++++++++++++++++++++++++++++++++++++++";
            returnString += "Diameter: " + this.Diameter + "\n";
            returnString += "Mass: " + this.Mass + "\n";
            returnString += "Moon Count: " + this.MoonCount + "\n";
            returnString += "Name: " + this.Name + "\n";
            returnString += "Orbital Period: " + this.OrbitalPeriod + "\n";
            returnString += "Ring Count: " + this.RingCount + "\n";
            returnString += "Rotation Period: " + this.RotationPeriod + "\n";
            returnString += "++++++++++++++++++++++++++++++++++++++";

            return returnString;
        }



    }
}