using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
* Author: Inderjeet Singh
* Student Number: 300874118
* Date Created: June 24, 2016
* Description: My Hero Class
* Version: 0.0.3
*/
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

        // PUBLIC PROPERTIES +++++++++++++++++++++++++++++++++++++++++++++++++

        /**<summary>
        * This is a property for our _diameter field.
        * </summary>
        *
        * @property Diameters
        */
        public double Diameter
        {
            get
            {
                return this._diameter;
            }
        }

        /**<summary>
        * This is a property for our _mass field.
        * </summary>
        *
        * @property Mass
        */
        public double Mass
        {
            get
            {
                return this._mass;
            }

        }

        /**<summary>
        * This is a property for our _moonCount field.
        * </summary>
        *
        * @property MoonCount
        */
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

        /**<summary>
        * This is a property for our _name field.
        * </summary>
        *
        * @property Name
        */
        public String Name
        {
            get
            {
                return this._name;
            }
        }

        /**<summary>
        * This is a property for our _orbitalPeriod field.
        * </summary>
        *
        * @property Orbital Period
        */
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

        /**<summary>
        * This is a property for our _ringCount field.
        * </summary>
        *
        * @property RingCount
        */
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

        /**<summary>
        * This is a property for our _rotationPeriod field.
        * </summary>
        *
        * @property RotationalPeriod
        */
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

        // CONSTRUCTORS ++++++++++++++++++++++++++++++++++++++++++++

        /** <summary>
        * This constructor takes name, diameter, and mass as parameters
        * and passes them to the PRIVATE INSTANCE VARIABLES.
        * </summary>
        *
        * @constructor Planets
        * @params {string} name
        * @params {double} diameter
        * @params {double} mass
        */
        public Planet(string name, double diameter, double mass)
        {
            this._name = name;
            this._diameter = diameter;
            this._mass = mass;

        }
        // PUBLIC METHODS +++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /** <summary>
        * This method ToString outputs Name, Diameter, and Mass 
        * </summary>
        *
        * @method ToString
        * returns {string}
        */
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
    }// End of Namespace
} //End of Program