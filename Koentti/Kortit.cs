using System;
using System.Collections.Generic;
using System.Drawing;
using Jypeli;
using Jypeli.Assets;
using Jypeli.Controls;
using Jypeli.Widgets;



    public class Kortit : Game
    {

        public class Kortti
        {
            private string nimi;
            private int vasen;
            private int alas;
            private int oikea;
            private int ylos;
            private Jypeli.Image kortinKuva;


        public Kortti(string nimi, int vasen, int alas, int oikea, int ylos, Jypeli.Image kortinKuva)
            {
                this.nimi = nimi;
                this.vasen = vasen;
                this.alas = alas;
                this.oikea = oikea;
                this.ylos = ylos;
                this.kortinKuva = LoadImage("kortti");
            }
        }

        Kortti geezard = new Kortti("Geezard", 5, 1, 4, 1, geezard.png);

        Kortti funguar = new Kortti("Funguar", 3, 1, 1, 5);

        Kortti bitebug = new Kortti("Bite Bug", 5, 3, 3, 1);

        Kortti redbat = new Kortti("Red Bat", 2, 1, 1, 6);

    //List<Kortti> korttilista = new List<Kortti>();
    Kortti[] korttiarray = { };

    }

