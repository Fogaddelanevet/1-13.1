﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obijektum
{
    class Program
    {
        class Allat
        {
            string nev;
            string fajta;
            string szin;
            int kor;
            string hang;

            public Allat(string nev, string fajta, string szin)
            {
                this.nev = nev;
                this.fajta = fajta;
                this.szin = szin;
                


            }
            public Allat()
            {
                this.nev = "ano";
                this.fajta = "ismeretlen";
                this.szin = "szar";
                this.kor = 0;
            }
            public string getFajta()
            {
                return this.fajta;
            }
            public string getSzin()
            {
                return this.szin;
            }
            public string getNev()
            {
                return this.nev;
            }
            public int getKor()
            {
                return this.kor;
            }

            public void setKor(int p)
            {
                if (p > 0 && p < 50)
                {
                    this.kor = p;

                }

            }
            public void setNev(string p)
            {
                this.nev = p;
            }
            public void setFajta(string p)
            {
                this.fajta = p;
            }
            public void setSzin(string p)
            {
               this.szin = p;
            }
            public string hangotAd()
            {
                return this.hang;
            }
        }
        static void Main(string[] args)
        {
            Allat allat1 = new Allat();
            // allat1.setKor(4);

            Console.WriteLine("{0} {1} {2} {3}", allat1.getKor(), allat1.getNev(), allat1.getFajta(), allat1.getSzin());

            // Allat allat2 = new Allat("kakás", "pibull", "black and yellow");
            //Console.WriteLine(allat2.getNev());
            Allat allat3 = new Allat();
            allat3.setFajta("puli");
            allat3.setKor(3);
            allat3.setNev("sanyi");
            allat3.setSzin("fekete");


            Console.WriteLine("{0} {1} {2} {3}", allat3.getKor(), allat3.getNev(), allat3.getSzin(),allat3.getFajta());
            Console.WriteLine("hang {0} ",allat3.hangotAd());

            Console.ReadKey();
        }
    }
}
