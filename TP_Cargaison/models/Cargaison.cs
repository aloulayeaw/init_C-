﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Cargaison.models
{
    abstract class Cargaison
    {
        private static int nbreCargaison;
        private int id;
        private double distance;
        private double poidsTotal;
        private double volumeTotal;

        public static int NbreCargaison { get => nbreCargaison; set => nbreCargaison = value; }
        public int Id { get => id; set => id = value; }
        protected double Distance { get => distance; set => distance = value; }
        public double PoidsTotal { get => poidsTotal; set => poidsTotal = value; }
        public double VolumeTotal { get => volumeTotal; set => volumeTotal = value; }

        public Cargaison()
        {
            Id = ++NbreCargaison;
        }

        public override string ToString()
        {
            return "ID: " + Id + "Distance: " + Distance;
        }

        public abstract double Cout();
    }
}
