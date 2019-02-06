﻿using System;
using System.Collections.Generic;
using System.Text;

namespace KrajinovicMatijaKlaseitd.Klase
{
    class Vozilo
    {
        int brojKotaca;
        bool leti, pliva, vozi;
        string vrsta;
        string oznaka;

        public void setBrojKotaca(int brojKotaca)
        { this.brojKotaca = brojKotaca;
        }

        public int getBrojKotaca()
        { return this.brojKotaca; }

        public void setLeti(bool leti)
        {
            this.leti = leti;
        }

        public bool getleti()
        { return this.leti; }

        public void setPliva(bool pliva)
        {
            this.pliva = pliva;
        }

        public bool getPliva()
        { return this.pliva; }

        public void setVozi(bool vozi)
        {
            this.vozi = vozi;
        }

        public bool getVozi()
        { return this.vozi; }

        public void setVrsta(string vrsta)
        { this.vrsta = vrsta; }

        public string getVrsta()
        { return this.vrsta; }

        public void setOznaka(string oznaka)
        {
            this.oznaka = oznaka;
        }

        public string getOznaka()
        { return this.oznaka; }

        public Vozilo(int brojKotaca, bool leti, bool pliva, bool vozi, string vrsta, string oznaka)
        {
            this.brojKotaca = brojKotaca;
            this.leti = leti;
            this.pliva = pliva;
            this.vozi = vozi;
            this.vrsta = vrsta;
            this.oznaka = oznaka;

        }

        public Vozilo()
        {

        }

        public override string ToString()
        {
            return " Vrsta : " + vrsta + "\n Oznaka : " + oznaka + "\n Pliva : " + 
                pliva + "\n Leti : " + leti + "\n Vozi : " + vozi + "\n Broj Kotaca : " +
                brojKotaca;
        }



    }

}
