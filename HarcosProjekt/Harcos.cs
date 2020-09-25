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
            this.alapEletero = MaxEletero;
        }

        public string Nev { get => nev; set => nev = value; }
        public int Szint { get => szint; set => szint = value; }
        public int Tapasztalat { get => tapasztalat; set => tapasztalat = value; }
        public int Eletero { get => eletero; set => eletero = value; }
        public int Sebzes { get => alapSebzes + szint; }
        public int Szintlepeshez { get => 10 + szint * 5; }
        public int MaxEletero { get => alapEletero + szint * 3; }
        //public void Megkuzd(Harcos masikHarcos) {}
        //public void Gyogyul() {}
        public override string ToString()
        {
            return String.Format("{0}\n – LVL:{1}\n – EXP: {2}/{3}\n – HP:{4}/{5}\n – DMG: {6}",
                this.nev, this.szint, this.tapasztalat, Szintlepeshez,alapEletero, MaxEletero, Sebzes);
        }

    }
}
