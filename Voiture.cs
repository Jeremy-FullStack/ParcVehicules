/*
 * Name : Parc Véhicules
 * Author : Jeremy-FullStack
 * Date: 15/02/2023
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcVehicules
{
    public class Voiture : Vehicule
    {
        protected int nbPortes;

        public Voiture(string _imm, string _marque, string _couleur, int _nbPortes) : base(_imm, _marque, _couleur)
        {
            nbPortes = _nbPortes;
        }

        public override string ToString()
        {
            return base.ToString() + " : voiture avec " + nbPortes + "portes";
        }
    }
}
