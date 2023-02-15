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
    public abstract class Vehicule
    {
        protected string immatriculation;
        protected string marque;
        protected string couleur;

        public Vehicule(string _imm, string _marque, string _coul)
        {
            immatriculation = _imm;
            marque = _marque;
            couleur = _coul;

        }
        public override string ToString()
        {
            return "véhicule " + immatriculation + "(" + marque + " ,  " + couleur + ")";
        }
    }
}
