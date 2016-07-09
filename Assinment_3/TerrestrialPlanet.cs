using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * Author: Inderjeet Singh
 * StudentNumber: 300874118
 * Description: Driver class for Planet classes and Interfaces
 * Version: 0.1.2
 * DateCreated: July 7rd, 2016
 * DateModified: July 8rd, 2016
 */
namespace Assinment_3
{
    /**
    * <summary>
    * This class TerrestrialPlanet is a subclass of the Planets Abstract class.
    * This class implements both the IHasMoons and IHabitable interfaces 
    * </summary>
    *
    * @class TerrestrialPlanet
    * @extends Planet
    */
    public class TerrestrialPlanet : Planet, IHasMoons, IHabitable
    {

        // PRIVATE INSTANCE VARIABLES +++++++++++++++++++++++++++++++++++++++++

        private bool _oxygen;

        // PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++++++++++

        /**<summary>
        * This is a property for our _oxygen field.
        * </summary>
        *
        * @property Type
        */
        public bool Oxygen
        {
            get
            {
                return this._oxygen;
            }
            set
            {
                this._oxygen = value;
            }
        }

        // CONSTRUCTORS ++++++++++++++++++++++++++++++++++++++++++++

        /** <summary>
        * This constructor method takes all parameters of the Planets base class as well as Oxygen
        * </summary>
        *
        * @constructor TerrestrialPlanet
        * @param {string} name
        * @param {double} diameter
        * @param {double} mass
        * @param {bool} oxygen
        */
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen)
        : base(name, diameter, mass)
        {
            this.Oxygen = oxygen;
        }

        // PUBLIC METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++

        /** <summary>
         * This public method Habitable() will return true if the oxygen is set to true
         * </summary>
         *
         * @method oxygen
         * @returns {bool}
         */
        public bool Habitable()
        {
            if (Oxygen == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /** <summary>
         * This public method HasMoons() will return true if the MoonCount is greater than zero
         * </summary>
         *
         * @method MoonCount
         * @returns {bool}
         */
        public bool HasMoons()
        {
            if (MoonCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
