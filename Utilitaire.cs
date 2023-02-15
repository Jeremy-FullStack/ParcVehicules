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
    public class Utilitaire : Vehicule
    {
        protected int volume;

        public Utilitaire(string _imm, string _marque, string _coul, int _volume) : base(_imm, _marque, _coul)
        {
            volume = _volume;
        }

        public override string ToString()
        {
            return base.ToString() + ": utilitaire de " + volume + "m3";
        }
    }
}
