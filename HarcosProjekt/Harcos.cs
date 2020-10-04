using System;
using System.Collections.Generic;
using System.Text;

namespace HarcosProjekt
{
    class Harcos
    {
        private string nev;
        private int szint;
        private int tapasztalat;
        private int eletero;
        private int alapEletero;
        private int alapSebzes;

        public Harcos(string nev, int statuszSablon)
        {
            this.nev = nev;
            this.szint = 1;
            this.tapasztalat = 0;
            if (statuszSablon == 3)
            {
                this.alapEletero = 8;
                this.alapSebzes = 5;
            }
            else if (statuszSablon == 2)
            {
                this.alapEletero = 12;
                this.alapSebzes = 4;
            }
            else
            {
                this.alapEletero = 15;
                this.alapSebzes = 3;
            }
            this.eletero = MaxEletero;
        }

        public string Nev { get => nev; set => nev = value; }
        public int Szint
        {
            get => szint;
            set
            {
                if (this.tapasztalat >= this.Szintlepeshez)
                {
                    this.tapasztalat -= this.Szintlepeshez;
                    this.szint = value;
                    this.eletero = this.MaxEletero;
                }
            }
        }
        public int Tapasztalat
        {
            get => this.tapasztalat;
            set
            {
                this.tapasztalat = value;
                if (Szintlepeshez <= this.tapasztalat)
                {
                    Szint++;
                }
            }
        }
        public int Eletero
        {
            get => eletero;
            set
            {   this.eletero = value;
                if (this.eletero == 0) { this.tapasztalat = 0; }
                else if (this.eletero > this.MaxEletero) { this.eletero = this.MaxEletero; }
            }
        }
        public int Sebzes { get => alapSebzes + szint; }
        public int Szintlepeshez { get => 10 + szint * 5; }
        public int MaxEletero { get => alapEletero + szint * 3; }
        public void Megkuzd(Harcos masikHarcos)
        {
            if (this == masikHarcos)
            {
                Console.WriteLine("A két harcos azonos");
            }

            if (this.Eletero == 0 || masikHarcos.Eletero == 0)
            {
                Console.WriteLine("A Harcos életereje 0");
            }
            else
            {
                if (this.Eletero > 0) { masikHarcos.Eletero -= this.Sebzes; }
                if (masikHarcos.Eletero > 0) { this.Eletero -= masikHarcos.Sebzes; }
                masikHarcos.Eletero += masikHarcos.Eletero < 0 ? (-1 * masikHarcos.Eletero) : 0;
                this.Eletero += this.Eletero < 0 ? (-1 * this.Eletero) : 0;
                masikHarcos.Tapasztalat += masikHarcos.Eletero <= 0 ? 0 : (this.Eletero == 0) ? 15 : 5;
                Tapasztalat += this.Eletero <= 0 ? 0 : (masikHarcos.Eletero == 0) ? 15 : 5;
            }
        }
        public void Gyogyul()
        {
            Eletero += Eletero == 0 ? MaxEletero : 3 + Szint; 
        }
        public override string ToString()
        {
            return String.Format("{0} – LVL:{1} – EXP: {2}/{3} – HP:{4}/{5} – DMG: {6}",
                this.nev, this.szint, this.tapasztalat, Szintlepeshez, this.eletero, MaxEletero, Sebzes);
        }

    }
}
