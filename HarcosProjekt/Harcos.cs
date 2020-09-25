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
            this.Nev = nev;
        }

        public string Nev { get => nev; set => nev = value; }
        public int Szint { get => szint; set => szint = value; }
        public int Tapasztalat { get => tapasztalat; set => tapasztalat = value; }
        public int Eletero { get => eletero; set => eletero = value; }
        //public int Sebzes() { get =>  }
        //public int Szintlepeshez() { get =>  }
        //public int MaxEletero() { get => }
        //public void Megkuzd(Harcos masikHarcos) {}
        //public void Gyogyul() {}
        //public override string ToString()
        //{
        //    return base.ToString();
        //}

    }
}
