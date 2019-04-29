using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardioAnalisiLibrary
{
    public class Class1
    {
        //1
        public static bool IsDetermined(int età, double numerobattiti)
        {
            int frequenza_cardiaca = 0;
            frequenza_cardiaca = 220 - età;

            double minimo = 0;
            double massimo = 0;
            bool risultato = false;

            minimo = frequenza_cardiaca * 70 / 100;
            massimo = frequenza_cardiaca * 90 / 100;

            if (numerobattiti > minimo && numerobattiti < massimo)
            {
                risultato = true;
            }
            else
            {
                risultato = false;
            }

            return risultato;
        }

        //2
        public static string IsDetermined1( double numerobattiti)
        {
            
            string risultato = "";

            if (numerobattiti < 60) 
            {
                risultato = "Bradicardia";
            }

            if (numerobattiti >= 60 && numerobattiti <= 100)
            {
                risultato = "Normale";
            }

            if (numerobattiti > 100)
            {
                risultato = "Tachicardia";
            }

            return risultato;
        }

        //3
        public static int IsDetermined2(string sesso, double età, double peso, double minuti,double frequenza)
        {

            int risultato = 0;

            if (sesso == "M")
            {
                risultato = Convert.ToInt32(((età * 0.2017) + (peso * 0.199) + (frequenza * 0.6309) - 55.0969) * minuti / 4.184);
;
            }
            else
            {
                risultato =Convert.ToInt32( ((età * 0.074) + (peso * 0.126) + (frequenza * 0.4472) - 20.4022) * minuti / 4.184);
            }

           

            
            return risultato;
        }

        //4
        public static int IsDetermined3(string andatura, double peso, double Km)
        {

            int risultato = 0;

            if (andatura.ToUpper() == "CORSA")
            {
                risultato = Convert.ToInt32((0.9*peso*Km));
                
            }
            else
            {
                risultato = Convert.ToInt32((0.50 * peso * Km));
            }




            return risultato;
        }

        //5
        public static string IsDetermined4(double battito1, double battito2, double battito3)
        {

            string risultato = "";
            string media = "";
            string frequenza = "";
            string variabilità = "";
            string primo = "";
            string secondo = "";
            string terzo = "";
            double battitomedio = 0;
            double min =1000;
            double max = 0;
            double centrale = 0;

            battitomedio = Convert.ToUInt32((battito1 + battito2 + battito3) / 3);

            media =Convert.ToString(battitomedio);

            if (battitomedio < 60)
            {
                frequenza = "Bradicardia";
            }

            if (battitomedio >= 60 && battitomedio <= 100)
            {
                frequenza = "Normale";
            }

            if (battitomedio > 100)
            {
               frequenza = "Tachicardia";
            }

            if (min > battito1) min = battito1;
            if (min > battito2) min = battito2;
            if (min > battito3) min = battito3;

            if (max < battito1) max = battito1;
            if (max < battito2) max = battito2;
            if (max < battito3) max = battito3;

            variabilità = Convert.ToString(max - min);

            if (battito1 != min)
            {
                if (battito1 != max) centrale = battito1;
            }
            if (battito2 != min)
            {
                if(battito2 != max) centrale = battito2;
            }
            if (battito3 != min)
            {
                if(battito3 != max) centrale = battito3;
            } 


            primo =Convert.ToString(min);
            secondo = Convert.ToString(centrale);
            terzo = Convert.ToString(max);

            risultato = media + " " + frequenza + " " + variabilità + " " + primo + " " + secondo + " " + terzo;

            return risultato;
        }

        //6
        public static string IsDetermined2(double numerobattiti)
        {

            string risultato = "";

            if (numerobattiti >= 50 && numerobattiti <=59)
            {
                risultato = "Bradicardia Lieve";
            }

            if (numerobattiti >= 40 && numerobattiti <= 49)
            {
                risultato = "Bradicardia Moderata";
            }

            if (numerobattiti < 40)
            {
                risultato = "Bradicardia Grave";
            }

            return risultato;
        }
    }

}
