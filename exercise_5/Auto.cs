using System;
using System.Collections.Generic;
using System.Text;

namespace exercise_5
{
    class Auto
    {
        protected double nadrz;
        protected double stav;
        protected TypPaliva autoPalivo;
        protected AutoRadio radio = new AutoRadio();

        public double VelikostNadrze
        {
            get { return nadrz; }
            protected set { nadrz = value; }
        }

        public double StavNadrze
        {
            get { return stav; }
            protected set
            {
                if ((value) > nadrz)
                {
                    throw new Exception("Nadrz by pretekla!");
                }
                stav = value;
            }
        }

        public TypPaliva Palivo
        {
            get { return autoPalivo; }
            protected set { autoPalivo = value; }
        }

        public AutoRadio Radio
        {
            get { return radio; }
        }

        public enum TypPaliva
        {
            Benzin,
            Nafta
        }

        public void Natankuj(TypPaliva palivo, double mnozstvi)
        {
            if (Palivo != palivo)
            {
                Exception e = new Exception("Nespravne palivo!");
                throw e;
            }
            double temp = StavNadrze;
            StavNadrze = temp + mnozstvi;
        }

        public void ZapniRadio(bool zapVyp)
        {
            radio.RadioZapnuto = zapVyp;
        }

        public void PreladRadioNaPredvolbu(int cislo)
        {
            try
            {
                radio.PreladNaPredvolbu(cislo);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void NastavPredvolbuRadia(int cislo, double kmitocet)
        {
            radio.NastavPredvolbu(cislo, kmitocet);
        }
    }
    }
