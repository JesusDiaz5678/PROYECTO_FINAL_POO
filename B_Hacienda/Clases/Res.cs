﻿using System;
using System.Collections.Generic;
using System.Text;

namespace B_Hacienda.Clases
{
    //Res es una Superclase
    public abstract class Res
    {
        //ATRIBUTOS
        internal byte edad; //meses
        private List<Vacuna> l_vacunas;
        private byte num_vacunas_vivas;
        private byte num_vacunas_bacterianas;
        private int peso;

        //CONSTRUCTOR
        protected Res(byte edad)
        {
            this.edad = edad;
            l_vacunas = new List<Vacuna>();
            num_vacunas_vivas = 0;
            num_vacunas_bacterianas = 0;
            Peso = 0;
        }

        //ACCESORES

        public List<Vacuna> L_vacunas { get => l_vacunas; set => l_vacunas = value; }
        public byte Num_vacunas_vivas { get => num_vacunas_vivas; set => num_vacunas_vivas = value; }
        public byte Num_vacunas_bacterianas { get => num_vacunas_bacterianas; set => num_vacunas_bacterianas = value; }
        internal int Peso { get => peso; set => peso = value; }
    }
}
