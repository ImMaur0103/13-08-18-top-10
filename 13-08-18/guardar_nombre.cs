using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_08_18
{
    class guardar_nombre
    {
        /*****************************************************************
            Proceso de ordenado de top 10 V1
            Creador: Mauricio Lopez
            Fecha: 13-08-2018
        *****************************************************************/
        private string nombre;
        private string apellido;
        private int puntaje;
        public string[,] nombreapellidopuntaje = new string[22, 3];
        int[] puntajes = new int[22];
        public void top10 ()
        {
            nombreapellidopuntaje[9, 0] = "usuario1";
            nombreapellidopuntaje[8, 0] = "usuario2";
            nombreapellidopuntaje[7, 0] = "usuario3";
            nombreapellidopuntaje[6, 0] = "usuario4";
            nombreapellidopuntaje[5, 0] = "usuario5";
            nombreapellidopuntaje[4, 0] = "usuario6";
            nombreapellidopuntaje[3, 0] = "usuario7";
            nombreapellidopuntaje[2, 0] = "usuario8";
            nombreapellidopuntaje[1, 0] = "usuario9";
            nombreapellidopuntaje[0, 0] = "nombre";

            nombreapellidopuntaje[9, 1] = "apodo1";
            nombreapellidopuntaje[8, 1] = "apodo1";
            nombreapellidopuntaje[7, 1] = "apodo1";
            nombreapellidopuntaje[6, 1] = "apodo1";
            nombreapellidopuntaje[5, 1] = "apodo1";
            nombreapellidopuntaje[4, 1] = "apodo1";
            nombreapellidopuntaje[3, 1] = "apodo1";
            nombreapellidopuntaje[2, 1] = "apodo1";
            nombreapellidopuntaje[1, 1] = "apodo1";
            nombreapellidopuntaje[0, 1] = "apellido";

            nombreapellidopuntaje[9, 2] = "900";
            nombreapellidopuntaje[8, 2] = "905";
            nombreapellidopuntaje[7, 2] = "800";
            nombreapellidopuntaje[6, 2] = "700";
            nombreapellidopuntaje[5, 2] = "600";
            nombreapellidopuntaje[4, 2] = "555";
            nombreapellidopuntaje[3, 2] = "400";
            nombreapellidopuntaje[2, 2] = "900";
            nombreapellidopuntaje[1, 2] = "2000";
            nombreapellidopuntaje[0, 2] = "1";
        }
        public void llenar(string a, string b,int c)
        {
            bool orden = false;
            bool cambio = false;

            nombre = a;
            apellido = b;
            puntaje = c;

            puntajes[0] = Convert.ToInt16(nombreapellidopuntaje[0, 2]);
            puntajes[1] = Convert.ToInt16(nombreapellidopuntaje[1, 2]);
            puntajes[2] = Convert.ToInt16(nombreapellidopuntaje[2, 2]);
            puntajes[3] = Convert.ToInt16(nombreapellidopuntaje[3, 2]);
            puntajes[4] = Convert.ToInt16(nombreapellidopuntaje[4, 2]);
            puntajes[5] = Convert.ToInt16(nombreapellidopuntaje[5, 2]);
            puntajes[6] = Convert.ToInt16(nombreapellidopuntaje[6, 2]);
            puntajes[7] = Convert.ToInt16(nombreapellidopuntaje[7, 2]);
            puntajes[8] = Convert.ToInt16(nombreapellidopuntaje[8, 2]);
            puntajes[9] = Convert.ToInt16(nombreapellidopuntaje[9, 2]);

            for (int x = 0; x <= 9; x++)
            {
                if (puntajes[x] > puntajes[x + 1])
                {
                    if (puntajes[x] > puntajes[x + 2])
                    {
                        if (puntajes[x] > puntajes[x + 3])
                        {
                            if (puntajes[x] > puntajes[x + 4])
                            {
                                if (puntajes[x] > puntajes[x + 5])
                                {
                                    if (puntajes[x] > puntajes[x + 6])
                                    {
                                        if (puntajes[x] > puntajes[x + 7])
                                        {
                                            if (puntajes[x] > puntajes[x + 8])
                                            {
                                                if (puntajes[x] > puntajes[x + 9])
                                                {
                                                    if(x == 9)
                                                    {
                                                        orden = true;
                                                    }
                                                    if(cambio)
                                                    {
                                                        x = 0;
                                                        cambio = false;
                                                    }
                                                }
                                                else if (puntajes[x] < puntajes[x + 9])
                                                {
                                                    nombreapellidopuntaje[11, 0] = nombreapellidopuntaje[x, 0];
                                                    nombreapellidopuntaje[11, 1] = nombreapellidopuntaje[x, 1];
                                                    nombreapellidopuntaje[11, 2] = nombreapellidopuntaje[x, 2];
                                                    nombreapellidopuntaje[12, 0] = nombreapellidopuntaje[x + 1, 0];
                                                    nombreapellidopuntaje[12, 1] = nombreapellidopuntaje[x + 1, 1];
                                                    nombreapellidopuntaje[12, 2] = nombreapellidopuntaje[x + 1, 2];
                                                    nombreapellidopuntaje[13, 0] = nombreapellidopuntaje[x + 2, 0];
                                                    nombreapellidopuntaje[13, 1] = nombreapellidopuntaje[x + 2, 1];
                                                    nombreapellidopuntaje[13, 2] = nombreapellidopuntaje[x + 2, 2];
                                                    nombreapellidopuntaje[14, 0] = nombreapellidopuntaje[x + 3, 0];
                                                    nombreapellidopuntaje[14, 1] = nombreapellidopuntaje[x + 3, 1];
                                                    nombreapellidopuntaje[14, 2] = nombreapellidopuntaje[x + 3, 2];
                                                    nombreapellidopuntaje[15, 0] = nombreapellidopuntaje[x + 4, 0];
                                                    nombreapellidopuntaje[15, 1] = nombreapellidopuntaje[x + 4, 1];
                                                    nombreapellidopuntaje[15, 2] = nombreapellidopuntaje[x + 4, 2];
                                                    nombreapellidopuntaje[16, 0] = nombreapellidopuntaje[x + 5, 0];
                                                    nombreapellidopuntaje[16, 1] = nombreapellidopuntaje[x + 5, 1];
                                                    nombreapellidopuntaje[16, 2] = nombreapellidopuntaje[x + 5, 2];
                                                    nombreapellidopuntaje[17, 0] = nombreapellidopuntaje[x + 6, 0];
                                                    nombreapellidopuntaje[17, 1] = nombreapellidopuntaje[x + 6, 1];
                                                    nombreapellidopuntaje[17, 2] = nombreapellidopuntaje[x + 6, 2];
                                                    nombreapellidopuntaje[18, 0] = nombreapellidopuntaje[x + 7, 0];
                                                    nombreapellidopuntaje[18, 1] = nombreapellidopuntaje[x + 7, 1];
                                                    nombreapellidopuntaje[18, 2] = nombreapellidopuntaje[x + 7, 2];
                                                    nombreapellidopuntaje[19, 0] = nombreapellidopuntaje[x + 8, 0];
                                                    nombreapellidopuntaje[19, 1] = nombreapellidopuntaje[x + 8, 1];
                                                    nombreapellidopuntaje[19, 2] = nombreapellidopuntaje[x + 8, 2];

                                                    nombreapellidopuntaje[x, 0] = nombreapellidopuntaje[x + 9, 0];
                                                    nombreapellidopuntaje[x, 1] = nombreapellidopuntaje[x + 9, 1];
                                                    nombreapellidopuntaje[x, 2] = nombreapellidopuntaje[x + 9, 2];
                                                    nombreapellidopuntaje[x + 1, 0] = nombreapellidopuntaje[11, 0];
                                                    nombreapellidopuntaje[x + 1, 1] = nombreapellidopuntaje[11, 1];
                                                    nombreapellidopuntaje[x + 1, 2] = nombreapellidopuntaje[11, 2];
                                                    nombreapellidopuntaje[x + 2, 0] = nombreapellidopuntaje[12, 0];
                                                    nombreapellidopuntaje[x + 2, 1] = nombreapellidopuntaje[12, 1];
                                                    nombreapellidopuntaje[x + 2, 2] = nombreapellidopuntaje[12, 2];
                                                    nombreapellidopuntaje[x + 3, 0] = nombreapellidopuntaje[13, 0];
                                                    nombreapellidopuntaje[x + 3, 1] = nombreapellidopuntaje[13, 1];
                                                    nombreapellidopuntaje[x + 3, 2] = nombreapellidopuntaje[13, 2];
                                                    nombreapellidopuntaje[x + 4, 0] = nombreapellidopuntaje[14, 0];
                                                    nombreapellidopuntaje[x + 4, 1] = nombreapellidopuntaje[14, 1];
                                                    nombreapellidopuntaje[x + 4, 2] = nombreapellidopuntaje[14, 2];
                                                    nombreapellidopuntaje[x + 5, 0] = nombreapellidopuntaje[15, 0];
                                                    nombreapellidopuntaje[x + 5, 1] = nombreapellidopuntaje[15, 1];
                                                    nombreapellidopuntaje[x + 5, 2] = nombreapellidopuntaje[15, 2];
                                                    nombreapellidopuntaje[x + 6, 0] = nombreapellidopuntaje[16, 0];
                                                    nombreapellidopuntaje[x + 6, 1] = nombreapellidopuntaje[16, 1];
                                                    nombreapellidopuntaje[x + 6, 2] = nombreapellidopuntaje[16, 2];
                                                    nombreapellidopuntaje[x + 7, 0] = nombreapellidopuntaje[17, 0];
                                                    nombreapellidopuntaje[x + 7, 1] = nombreapellidopuntaje[17, 1];
                                                    nombreapellidopuntaje[x + 7, 2] = nombreapellidopuntaje[17, 2];
                                                    nombreapellidopuntaje[x + 8, 0] = nombreapellidopuntaje[18, 0];
                                                    nombreapellidopuntaje[x + 8, 1] = nombreapellidopuntaje[18, 1];
                                                    nombreapellidopuntaje[x + 8, 2] = nombreapellidopuntaje[18, 2];
                                                    nombreapellidopuntaje[x + 9, 0] = nombreapellidopuntaje[19, 0];
                                                    nombreapellidopuntaje[x + 9, 1] = nombreapellidopuntaje[19, 1];
                                                    nombreapellidopuntaje[x + 9, 2] = nombreapellidopuntaje[19, 2];


                                                    nombreapellidopuntaje[11, 0] = "";
                                                    nombreapellidopuntaje[11, 1] = "";
                                                    nombreapellidopuntaje[11, 2] = "";
                                                    nombreapellidopuntaje[12, 0] = "";
                                                    nombreapellidopuntaje[12, 1] = "";
                                                    nombreapellidopuntaje[12, 2] = "";
                                                    nombreapellidopuntaje[13, 0] = "";
                                                    nombreapellidopuntaje[13, 1] = "";
                                                    nombreapellidopuntaje[13, 2] = "";
                                                    nombreapellidopuntaje[14, 0] = "";
                                                    nombreapellidopuntaje[14, 1] = "";
                                                    nombreapellidopuntaje[14, 2] = "";
                                                    nombreapellidopuntaje[15, 0] = "";
                                                    nombreapellidopuntaje[15, 1] = "";
                                                    nombreapellidopuntaje[15, 2] = "";
                                                    nombreapellidopuntaje[16, 0] = "";
                                                    nombreapellidopuntaje[16, 1] = "";
                                                    nombreapellidopuntaje[16, 2] = "";
                                                    nombreapellidopuntaje[17, 0] = "";
                                                    nombreapellidopuntaje[17, 1] = "";
                                                    nombreapellidopuntaje[17, 2] = "";
                                                    nombreapellidopuntaje[18, 0] = "";
                                                    nombreapellidopuntaje[18, 1] = "";
                                                    nombreapellidopuntaje[18, 2] = "";
                                                    nombreapellidopuntaje[19, 0] = "";
                                                    nombreapellidopuntaje[19, 1] = "";
                                                    nombreapellidopuntaje[19, 2] = "";

                                                    puntajes[11] = puntajes[x];
                                                    puntajes[12] = puntajes[x + 1];
                                                    puntajes[13] = puntajes[x + 2];
                                                    puntajes[14] = puntajes[x + 3];
                                                    puntajes[15] = puntajes[x + 4];
                                                    puntajes[16] = puntajes[x + 5];
                                                    puntajes[17] = puntajes[x + 6];
                                                    puntajes[18] = puntajes[x + 7];
                                                    puntajes[19] = puntajes[x + 8];

                                                    puntajes[x] = puntajes[x + 9];
                                                    puntajes[x + 1] = puntajes[11];
                                                    puntajes[x + 2] = puntajes[12];
                                                    puntajes[x + 3] = puntajes[13];
                                                    puntajes[x + 4] = puntajes[14];
                                                    puntajes[x + 5] = puntajes[15];
                                                    puntajes[x + 6] = puntajes[16];
                                                    puntajes[x + 7] = puntajes[17];
                                                    puntajes[x + 8] = puntajes[18];
                                                    puntajes[x + 9] = puntajes[19];

                                                    puntajes[11] = 0;
                                                    puntajes[12] = 0;
                                                    puntajes[13] = 0;
                                                    puntajes[14] = 0;
                                                    puntajes[15] = 0;
                                                    puntajes[16] = 0;
                                                    puntajes[17] = 0;
                                                    puntajes[18] = 0;
                                                    puntajes[19] = 0;

                                                    cambio = true;
                                                    x = 0;
                                                    x = x + 9;
                                                }
                                            }
                                            else if (puntajes[x] < puntajes[x + 8])
                                            {
                                                nombreapellidopuntaje[11, 0] = nombreapellidopuntaje[x, 0];
                                                nombreapellidopuntaje[11, 1] = nombreapellidopuntaje[x, 1];
                                                nombreapellidopuntaje[11, 2] = nombreapellidopuntaje[x, 2];
                                                nombreapellidopuntaje[12, 0] = nombreapellidopuntaje[x + 1, 0];
                                                nombreapellidopuntaje[12, 1] = nombreapellidopuntaje[x + 1, 1];
                                                nombreapellidopuntaje[12, 2] = nombreapellidopuntaje[x + 1, 2];
                                                nombreapellidopuntaje[13, 0] = nombreapellidopuntaje[x + 2, 0];
                                                nombreapellidopuntaje[13, 1] = nombreapellidopuntaje[x + 2, 1];
                                                nombreapellidopuntaje[13, 2] = nombreapellidopuntaje[x + 2, 2];
                                                nombreapellidopuntaje[14, 0] = nombreapellidopuntaje[x + 3, 0];
                                                nombreapellidopuntaje[14, 1] = nombreapellidopuntaje[x + 3, 1];
                                                nombreapellidopuntaje[14, 2] = nombreapellidopuntaje[x + 3, 2];
                                                nombreapellidopuntaje[15, 0] = nombreapellidopuntaje[x + 4, 0];
                                                nombreapellidopuntaje[15, 1] = nombreapellidopuntaje[x + 4, 1];
                                                nombreapellidopuntaje[15, 2] = nombreapellidopuntaje[x + 4, 2];
                                                nombreapellidopuntaje[16, 0] = nombreapellidopuntaje[x + 5, 0];
                                                nombreapellidopuntaje[16, 1] = nombreapellidopuntaje[x + 5, 1];
                                                nombreapellidopuntaje[16, 2] = nombreapellidopuntaje[x + 5, 2];
                                                nombreapellidopuntaje[17, 0] = nombreapellidopuntaje[x + 6, 0];
                                                nombreapellidopuntaje[17, 1] = nombreapellidopuntaje[x + 6, 1];
                                                nombreapellidopuntaje[17, 2] = nombreapellidopuntaje[x + 6, 2];
                                                nombreapellidopuntaje[18, 0] = nombreapellidopuntaje[x + 7, 0];
                                                nombreapellidopuntaje[18, 1] = nombreapellidopuntaje[x + 7, 1];
                                                nombreapellidopuntaje[18, 2] = nombreapellidopuntaje[x + 7, 2];

                                                nombreapellidopuntaje[x, 0] = nombreapellidopuntaje[x + 8, 0];
                                                nombreapellidopuntaje[x, 1] = nombreapellidopuntaje[x + 8, 1];
                                                nombreapellidopuntaje[x, 2] = nombreapellidopuntaje[x + 8, 2];
                                                nombreapellidopuntaje[x + 1, 0] = nombreapellidopuntaje[11, 0];
                                                nombreapellidopuntaje[x + 1, 1] = nombreapellidopuntaje[11, 1];
                                                nombreapellidopuntaje[x + 1, 2] = nombreapellidopuntaje[11, 2];
                                                nombreapellidopuntaje[x + 2, 0] = nombreapellidopuntaje[12, 0];
                                                nombreapellidopuntaje[x + 2, 1] = nombreapellidopuntaje[12, 1];
                                                nombreapellidopuntaje[x + 2, 2] = nombreapellidopuntaje[12, 2];
                                                nombreapellidopuntaje[x + 3, 0] = nombreapellidopuntaje[13, 0];
                                                nombreapellidopuntaje[x + 3, 1] = nombreapellidopuntaje[13, 1];
                                                nombreapellidopuntaje[x + 3, 2] = nombreapellidopuntaje[13, 2];
                                                nombreapellidopuntaje[x + 4, 0] = nombreapellidopuntaje[14, 0];
                                                nombreapellidopuntaje[x + 4, 1] = nombreapellidopuntaje[14, 1];
                                                nombreapellidopuntaje[x + 4, 2] = nombreapellidopuntaje[14, 2];
                                                nombreapellidopuntaje[x + 5, 0] = nombreapellidopuntaje[15, 0];
                                                nombreapellidopuntaje[x + 5, 1] = nombreapellidopuntaje[15, 1];
                                                nombreapellidopuntaje[x + 5, 2] = nombreapellidopuntaje[15, 2];
                                                nombreapellidopuntaje[x + 6, 0] = nombreapellidopuntaje[16, 0];
                                                nombreapellidopuntaje[x + 6, 1] = nombreapellidopuntaje[16, 1];
                                                nombreapellidopuntaje[x + 6, 2] = nombreapellidopuntaje[16, 2];
                                                nombreapellidopuntaje[x + 7, 0] = nombreapellidopuntaje[17, 0];
                                                nombreapellidopuntaje[x + 7, 1] = nombreapellidopuntaje[17, 1];
                                                nombreapellidopuntaje[x + 7, 2] = nombreapellidopuntaje[17, 2];
                                                nombreapellidopuntaje[x + 8, 0] = nombreapellidopuntaje[18, 0];
                                                nombreapellidopuntaje[x + 8, 1] = nombreapellidopuntaje[18, 1];
                                                nombreapellidopuntaje[x + 8, 2] = nombreapellidopuntaje[18, 2];


                                                nombreapellidopuntaje[11, 0] = "";
                                                nombreapellidopuntaje[11, 1] = "";
                                                nombreapellidopuntaje[11, 2] = "";
                                                nombreapellidopuntaje[12, 0] = "";
                                                nombreapellidopuntaje[12, 1] = "";
                                                nombreapellidopuntaje[12, 2] = "";
                                                nombreapellidopuntaje[13, 0] = "";
                                                nombreapellidopuntaje[13, 1] = "";
                                                nombreapellidopuntaje[13, 2] = "";
                                                nombreapellidopuntaje[14, 0] = "";
                                                nombreapellidopuntaje[14, 1] = "";
                                                nombreapellidopuntaje[14, 2] = "";
                                                nombreapellidopuntaje[15, 0] = "";
                                                nombreapellidopuntaje[15, 1] = "";
                                                nombreapellidopuntaje[15, 2] = "";
                                                nombreapellidopuntaje[16, 0] = "";
                                                nombreapellidopuntaje[16, 1] = "";
                                                nombreapellidopuntaje[16, 2] = "";
                                                nombreapellidopuntaje[17, 0] = "";
                                                nombreapellidopuntaje[17, 1] = "";
                                                nombreapellidopuntaje[17, 2] = "";
                                                nombreapellidopuntaje[18, 0] = "";
                                                nombreapellidopuntaje[18, 1] = "";
                                                nombreapellidopuntaje[18, 2] = "";

                                                puntajes[11] = puntajes[x];
                                                puntajes[12] = puntajes[x + 1];
                                                puntajes[13] = puntajes[x + 2];
                                                puntajes[14] = puntajes[x + 3];
                                                puntajes[15] = puntajes[x + 4];
                                                puntajes[16] = puntajes[x + 5];
                                                puntajes[17] = puntajes[x + 6];
                                                puntajes[18] = puntajes[x + 7];

                                                puntajes[x] = puntajes[x + 8];
                                                puntajes[x + 1] = puntajes[11];
                                                puntajes[x + 2] = puntajes[12];
                                                puntajes[x + 3] = puntajes[13];
                                                puntajes[x + 4] = puntajes[14];
                                                puntajes[x + 5] = puntajes[15];
                                                puntajes[x + 6] = puntajes[16];
                                                puntajes[x + 7] = puntajes[17];
                                                puntajes[x + 8] = puntajes[18];

                                                puntajes[11] = 0;
                                                puntajes[12] = 0;
                                                puntajes[13] = 0;
                                                puntajes[14] = 0;
                                                puntajes[15] = 0;
                                                puntajes[16] = 0;
                                                puntajes[17] = 0;
                                                puntajes[18] = 0;

                                                cambio = true;
                                                x = 0;
                                                x = x + 8;
                                            }
                                        }
                                        else if (puntajes[x] < puntajes[x + 7])
                                        {
                                            nombreapellidopuntaje[11, 0] = nombreapellidopuntaje[x, 0];
                                            nombreapellidopuntaje[11, 1] = nombreapellidopuntaje[x, 1];
                                            nombreapellidopuntaje[11, 2] = nombreapellidopuntaje[x, 2];
                                            nombreapellidopuntaje[12, 0] = nombreapellidopuntaje[x + 1, 0];
                                            nombreapellidopuntaje[12, 1] = nombreapellidopuntaje[x + 1, 1];
                                            nombreapellidopuntaje[12, 2] = nombreapellidopuntaje[x + 1, 2];
                                            nombreapellidopuntaje[13, 0] = nombreapellidopuntaje[x + 2, 0];
                                            nombreapellidopuntaje[13, 1] = nombreapellidopuntaje[x + 2, 1];
                                            nombreapellidopuntaje[13, 2] = nombreapellidopuntaje[x + 2, 2];
                                            nombreapellidopuntaje[14, 0] = nombreapellidopuntaje[x + 3, 0];
                                            nombreapellidopuntaje[14, 1] = nombreapellidopuntaje[x + 3, 1];
                                            nombreapellidopuntaje[14, 2] = nombreapellidopuntaje[x + 3, 2];
                                            nombreapellidopuntaje[15, 0] = nombreapellidopuntaje[x + 4, 0];
                                            nombreapellidopuntaje[15, 1] = nombreapellidopuntaje[x + 4, 1];
                                            nombreapellidopuntaje[15, 2] = nombreapellidopuntaje[x + 4, 2];
                                            nombreapellidopuntaje[16, 0] = nombreapellidopuntaje[x + 5, 0];
                                            nombreapellidopuntaje[16, 1] = nombreapellidopuntaje[x + 5, 1];
                                            nombreapellidopuntaje[16, 2] = nombreapellidopuntaje[x + 5, 2];
                                            nombreapellidopuntaje[17, 0] = nombreapellidopuntaje[x + 6, 0];
                                            nombreapellidopuntaje[17, 1] = nombreapellidopuntaje[x + 6, 1];
                                            nombreapellidopuntaje[17, 2] = nombreapellidopuntaje[x + 6, 2];

                                            nombreapellidopuntaje[x, 0] = nombreapellidopuntaje[x + 7, 0];
                                            nombreapellidopuntaje[x, 1] = nombreapellidopuntaje[x + 7, 1];
                                            nombreapellidopuntaje[x, 2] = nombreapellidopuntaje[x + 7, 2];
                                            nombreapellidopuntaje[x + 1, 0] = nombreapellidopuntaje[11, 0];
                                            nombreapellidopuntaje[x + 1, 1] = nombreapellidopuntaje[11, 1];
                                            nombreapellidopuntaje[x + 1, 2] = nombreapellidopuntaje[11, 2];
                                            nombreapellidopuntaje[x + 2, 0] = nombreapellidopuntaje[12, 0];
                                            nombreapellidopuntaje[x + 2, 1] = nombreapellidopuntaje[12, 1];
                                            nombreapellidopuntaje[x + 2, 2] = nombreapellidopuntaje[12, 2];
                                            nombreapellidopuntaje[x + 3, 0] = nombreapellidopuntaje[13, 0];
                                            nombreapellidopuntaje[x + 3, 1] = nombreapellidopuntaje[13, 1];
                                            nombreapellidopuntaje[x + 3, 2] = nombreapellidopuntaje[13, 2];
                                            nombreapellidopuntaje[x + 4, 0] = nombreapellidopuntaje[14, 0];
                                            nombreapellidopuntaje[x + 4, 1] = nombreapellidopuntaje[14, 1];
                                            nombreapellidopuntaje[x + 4, 2] = nombreapellidopuntaje[14, 2];
                                            nombreapellidopuntaje[x + 5, 0] = nombreapellidopuntaje[15, 0];
                                            nombreapellidopuntaje[x + 5, 1] = nombreapellidopuntaje[15, 1];
                                            nombreapellidopuntaje[x + 5, 2] = nombreapellidopuntaje[15, 2];
                                            nombreapellidopuntaje[x + 6, 0] = nombreapellidopuntaje[16, 0];
                                            nombreapellidopuntaje[x + 6, 1] = nombreapellidopuntaje[16, 1];
                                            nombreapellidopuntaje[x + 6, 2] = nombreapellidopuntaje[16, 2];
                                            nombreapellidopuntaje[x + 7, 0] = nombreapellidopuntaje[17, 0];
                                            nombreapellidopuntaje[x + 7, 1] = nombreapellidopuntaje[17, 1];
                                            nombreapellidopuntaje[x + 7, 2] = nombreapellidopuntaje[17, 2];


                                            nombreapellidopuntaje[11, 0] = "";
                                            nombreapellidopuntaje[11, 1] = "";
                                            nombreapellidopuntaje[11, 2] = "";
                                            nombreapellidopuntaje[12, 0] = "";
                                            nombreapellidopuntaje[12, 1] = "";
                                            nombreapellidopuntaje[12, 2] = "";
                                            nombreapellidopuntaje[13, 0] = "";
                                            nombreapellidopuntaje[13, 1] = "";
                                            nombreapellidopuntaje[13, 2] = "";
                                            nombreapellidopuntaje[14, 0] = "";
                                            nombreapellidopuntaje[14, 1] = "";
                                            nombreapellidopuntaje[14, 2] = "";
                                            nombreapellidopuntaje[15, 0] = "";
                                            nombreapellidopuntaje[15, 1] = "";
                                            nombreapellidopuntaje[15, 2] = "";
                                            nombreapellidopuntaje[16, 0] = "";
                                            nombreapellidopuntaje[16, 1] = "";
                                            nombreapellidopuntaje[16, 2] = "";
                                            nombreapellidopuntaje[17, 0] = "";
                                            nombreapellidopuntaje[17, 1] = "";
                                            nombreapellidopuntaje[17, 2] = "";

                                            puntajes[11] = puntajes[x];
                                            puntajes[12] = puntajes[x + 1];
                                            puntajes[13] = puntajes[x + 2];
                                            puntajes[14] = puntajes[x + 3];
                                            puntajes[15] = puntajes[x + 4];
                                            puntajes[16] = puntajes[x + 5];
                                            puntajes[17] = puntajes[x + 6];

                                            puntajes[x] = puntajes[x + 7];
                                            puntajes[x + 1] = puntajes[11];
                                            puntajes[x + 2] = puntajes[12];
                                            puntajes[x + 3] = puntajes[13];
                                            puntajes[x + 4] = puntajes[14];
                                            puntajes[x + 5] = puntajes[15];
                                            puntajes[x + 6] = puntajes[16];
                                            puntajes[x + 7] = puntajes[17];

                                            puntajes[11] = 0;
                                            puntajes[12] = 0;
                                            puntajes[13] = 0;
                                            puntajes[14] = 0;
                                            puntajes[15] = 0;
                                            puntajes[16] = 0;
                                            puntajes[17] = 0;

                                            cambio = true;
                                            x = 0;
                                            x = x + 7;
                                        }
                                    }
                                    else if (puntajes[x] < puntajes[x + 6])
                                    {
                                        nombreapellidopuntaje[11, 0] = nombreapellidopuntaje[x, 0];
                                        nombreapellidopuntaje[11, 1] = nombreapellidopuntaje[x, 1];
                                        nombreapellidopuntaje[11, 2] = nombreapellidopuntaje[x, 2];
                                        nombreapellidopuntaje[12, 0] = nombreapellidopuntaje[x + 1, 0];
                                        nombreapellidopuntaje[12, 1] = nombreapellidopuntaje[x + 1, 1];
                                        nombreapellidopuntaje[12, 2] = nombreapellidopuntaje[x + 1, 2];
                                        nombreapellidopuntaje[13, 0] = nombreapellidopuntaje[x + 2, 0];
                                        nombreapellidopuntaje[13, 1] = nombreapellidopuntaje[x + 2, 1];
                                        nombreapellidopuntaje[13, 2] = nombreapellidopuntaje[x + 2, 2];
                                        nombreapellidopuntaje[14, 0] = nombreapellidopuntaje[x + 3, 0];
                                        nombreapellidopuntaje[14, 1] = nombreapellidopuntaje[x + 3, 1];
                                        nombreapellidopuntaje[14, 2] = nombreapellidopuntaje[x + 3, 2];
                                        nombreapellidopuntaje[15, 0] = nombreapellidopuntaje[x + 4, 0];
                                        nombreapellidopuntaje[15, 1] = nombreapellidopuntaje[x + 4, 1];
                                        nombreapellidopuntaje[15, 2] = nombreapellidopuntaje[x + 4, 2];
                                        nombreapellidopuntaje[16, 0] = nombreapellidopuntaje[x + 5, 0];
                                        nombreapellidopuntaje[16, 1] = nombreapellidopuntaje[x + 5, 1];
                                        nombreapellidopuntaje[16, 2] = nombreapellidopuntaje[x + 5, 2];

                                        nombreapellidopuntaje[x, 0] = nombreapellidopuntaje[x + 6, 0];
                                        nombreapellidopuntaje[x, 1] = nombreapellidopuntaje[x + 6, 1];
                                        nombreapellidopuntaje[x, 2] = nombreapellidopuntaje[x + 6, 2];
                                        nombreapellidopuntaje[x + 1, 0] = nombreapellidopuntaje[11, 0];
                                        nombreapellidopuntaje[x + 1, 1] = nombreapellidopuntaje[11, 1];
                                        nombreapellidopuntaje[x + 1, 2] = nombreapellidopuntaje[11, 2];
                                        nombreapellidopuntaje[x + 2, 0] = nombreapellidopuntaje[12, 0];
                                        nombreapellidopuntaje[x + 2, 1] = nombreapellidopuntaje[12, 1];
                                        nombreapellidopuntaje[x + 2, 2] = nombreapellidopuntaje[12, 2];
                                        nombreapellidopuntaje[x + 3, 0] = nombreapellidopuntaje[13, 0];
                                        nombreapellidopuntaje[x + 3, 1] = nombreapellidopuntaje[13, 1];
                                        nombreapellidopuntaje[x + 3, 2] = nombreapellidopuntaje[13, 2];
                                        nombreapellidopuntaje[x + 4, 0] = nombreapellidopuntaje[14, 0];
                                        nombreapellidopuntaje[x + 4, 1] = nombreapellidopuntaje[14, 1];
                                        nombreapellidopuntaje[x + 4, 2] = nombreapellidopuntaje[14, 2];
                                        nombreapellidopuntaje[x + 5, 0] = nombreapellidopuntaje[15, 0];
                                        nombreapellidopuntaje[x + 5, 1] = nombreapellidopuntaje[15, 1];
                                        nombreapellidopuntaje[x + 5, 2] = nombreapellidopuntaje[15, 2];
                                        nombreapellidopuntaje[x + 6, 0] = nombreapellidopuntaje[16, 0];
                                        nombreapellidopuntaje[x + 6, 1] = nombreapellidopuntaje[16, 1];
                                        nombreapellidopuntaje[x + 6, 2] = nombreapellidopuntaje[16, 2];


                                        nombreapellidopuntaje[11, 0] = "";
                                        nombreapellidopuntaje[11, 1] = "";
                                        nombreapellidopuntaje[11, 2] = "";
                                        nombreapellidopuntaje[12, 0] = "";
                                        nombreapellidopuntaje[12, 1] = "";
                                        nombreapellidopuntaje[12, 2] = "";
                                        nombreapellidopuntaje[13, 0] = "";
                                        nombreapellidopuntaje[13, 1] = "";
                                        nombreapellidopuntaje[13, 2] = "";
                                        nombreapellidopuntaje[14, 0] = "";
                                        nombreapellidopuntaje[14, 1] = "";
                                        nombreapellidopuntaje[14, 2] = "";
                                        nombreapellidopuntaje[15, 0] = "";
                                        nombreapellidopuntaje[15, 1] = "";
                                        nombreapellidopuntaje[15, 2] = "";
                                        nombreapellidopuntaje[16, 0] = "";
                                        nombreapellidopuntaje[16, 1] = "";
                                        nombreapellidopuntaje[16, 2] = "";

                                        puntajes[11] = puntajes[x];
                                        puntajes[12] = puntajes[x + 1];
                                        puntajes[13] = puntajes[x + 2];
                                        puntajes[14] = puntajes[x + 3];
                                        puntajes[15] = puntajes[x + 4];
                                        puntajes[16] = puntajes[x + 5];

                                        puntajes[x] = puntajes[x + 6];
                                        puntajes[x + 1] = puntajes[11];
                                        puntajes[x + 2] = puntajes[12];
                                        puntajes[x + 3] = puntajes[13];
                                        puntajes[x + 4] = puntajes[14];
                                        puntajes[x + 5] = puntajes[15];
                                        puntajes[x + 6] = puntajes[16];

                                        puntajes[11] = 0;
                                        puntajes[12] = 0;
                                        puntajes[13] = 0;
                                        puntajes[14] = 0;
                                        puntajes[15] = 0;
                                        puntajes[16] = 0;

                                        cambio = true;
                                        x = 0;
                                        x = x + 6;
                                    }
                                }
                                else if (puntajes[x] < puntajes[x + 5])
                                {
                                    nombreapellidopuntaje[11, 0] = nombreapellidopuntaje[x, 0];
                                    nombreapellidopuntaje[11, 1] = nombreapellidopuntaje[x, 1];
                                    nombreapellidopuntaje[11, 2] = nombreapellidopuntaje[x, 2];
                                    nombreapellidopuntaje[12, 0] = nombreapellidopuntaje[x + 1, 0];
                                    nombreapellidopuntaje[12, 1] = nombreapellidopuntaje[x + 1, 1];
                                    nombreapellidopuntaje[12, 2] = nombreapellidopuntaje[x + 1, 2];
                                    nombreapellidopuntaje[13, 0] = nombreapellidopuntaje[x + 2, 0];
                                    nombreapellidopuntaje[13, 1] = nombreapellidopuntaje[x + 2, 1];
                                    nombreapellidopuntaje[13, 2] = nombreapellidopuntaje[x + 2, 2];
                                    nombreapellidopuntaje[14, 0] = nombreapellidopuntaje[x + 3, 0];
                                    nombreapellidopuntaje[14, 1] = nombreapellidopuntaje[x + 3, 1];
                                    nombreapellidopuntaje[14, 2] = nombreapellidopuntaje[x + 3, 2];
                                    nombreapellidopuntaje[15, 0] = nombreapellidopuntaje[x + 4, 0];
                                    nombreapellidopuntaje[15, 1] = nombreapellidopuntaje[x + 4, 1];
                                    nombreapellidopuntaje[15, 2] = nombreapellidopuntaje[x + 4, 2];

                                    nombreapellidopuntaje[x, 0] = nombreapellidopuntaje[x + 5, 0];
                                    nombreapellidopuntaje[x, 1] = nombreapellidopuntaje[x + 5, 1];
                                    nombreapellidopuntaje[x, 2] = nombreapellidopuntaje[x + 5, 2];
                                    nombreapellidopuntaje[x + 1, 0] = nombreapellidopuntaje[11, 0];
                                    nombreapellidopuntaje[x + 1, 1] = nombreapellidopuntaje[11, 1];
                                    nombreapellidopuntaje[x + 1, 2] = nombreapellidopuntaje[11, 2];
                                    nombreapellidopuntaje[x + 2, 0] = nombreapellidopuntaje[12, 0];
                                    nombreapellidopuntaje[x + 2, 1] = nombreapellidopuntaje[12, 1];
                                    nombreapellidopuntaje[x + 2, 2] = nombreapellidopuntaje[12, 2];
                                    nombreapellidopuntaje[x + 3, 0] = nombreapellidopuntaje[13, 0];
                                    nombreapellidopuntaje[x + 3, 1] = nombreapellidopuntaje[13, 1];
                                    nombreapellidopuntaje[x + 3, 2] = nombreapellidopuntaje[13, 2];
                                    nombreapellidopuntaje[x + 4, 0] = nombreapellidopuntaje[14, 0];
                                    nombreapellidopuntaje[x + 4, 1] = nombreapellidopuntaje[14, 1];
                                    nombreapellidopuntaje[x + 4, 2] = nombreapellidopuntaje[14, 2];
                                    nombreapellidopuntaje[x + 5, 0] = nombreapellidopuntaje[15, 0];
                                    nombreapellidopuntaje[x + 5, 1] = nombreapellidopuntaje[15, 1];
                                    nombreapellidopuntaje[x + 5, 2] = nombreapellidopuntaje[15, 2];


                                    nombreapellidopuntaje[11, 0] = "";
                                    nombreapellidopuntaje[11, 1] = "";
                                    nombreapellidopuntaje[11, 2] = "";
                                    nombreapellidopuntaje[12, 0] = "";
                                    nombreapellidopuntaje[12, 1] = "";
                                    nombreapellidopuntaje[12, 2] = "";
                                    nombreapellidopuntaje[13, 0] = "";
                                    nombreapellidopuntaje[13, 1] = "";
                                    nombreapellidopuntaje[13, 2] = "";
                                    nombreapellidopuntaje[14, 0] = "";
                                    nombreapellidopuntaje[14, 1] = "";
                                    nombreapellidopuntaje[14, 2] = "";
                                    nombreapellidopuntaje[15, 0] = "";
                                    nombreapellidopuntaje[15, 1] = "";
                                    nombreapellidopuntaje[15, 2] = "";

                                    puntajes[11] = puntajes[x];
                                    puntajes[12] = puntajes[x + 1];
                                    puntajes[13] = puntajes[x + 2];
                                    puntajes[14] = puntajes[x + 3];
                                    puntajes[15] = puntajes[x + 4];

                                    puntajes[x] = puntajes[x + 5];
                                    puntajes[x + 1] = puntajes[11];
                                    puntajes[x + 2] = puntajes[12];
                                    puntajes[x + 3] = puntajes[13];
                                    puntajes[x + 4] = puntajes[14];
                                    puntajes[x + 5] = puntajes[15];

                                    puntajes[11] = 0;
                                    puntajes[12] = 0;
                                    puntajes[13] = 0;
                                    puntajes[14] = 0;
                                    puntajes[15] = 0;

                                    cambio = true;
                                    x = 0;
                                    x = x + 5;
                                }
                            }
                            else if (puntajes[x] < puntajes[x + 4])
                            {
                                nombreapellidopuntaje[11, 0] = nombreapellidopuntaje[x, 0];
                                nombreapellidopuntaje[11, 1] = nombreapellidopuntaje[x, 1];
                                nombreapellidopuntaje[11, 2] = nombreapellidopuntaje[x, 2];
                                nombreapellidopuntaje[12, 0] = nombreapellidopuntaje[x + 1, 0];
                                nombreapellidopuntaje[12, 1] = nombreapellidopuntaje[x + 1, 1];
                                nombreapellidopuntaje[12, 2] = nombreapellidopuntaje[x + 1, 2];
                                nombreapellidopuntaje[13, 0] = nombreapellidopuntaje[x + 2, 0];
                                nombreapellidopuntaje[13, 1] = nombreapellidopuntaje[x + 2, 1];
                                nombreapellidopuntaje[13, 2] = nombreapellidopuntaje[x + 2, 2];
                                nombreapellidopuntaje[14, 0] = nombreapellidopuntaje[x + 3, 0];
                                nombreapellidopuntaje[14, 1] = nombreapellidopuntaje[x + 3, 1];
                                nombreapellidopuntaje[14, 2] = nombreapellidopuntaje[x + 3, 2];

                                nombreapellidopuntaje[x, 0] = nombreapellidopuntaje[x + 4, 0];
                                nombreapellidopuntaje[x, 1] = nombreapellidopuntaje[x + 4, 1];
                                nombreapellidopuntaje[x, 2] = nombreapellidopuntaje[x + 4, 2];
                                nombreapellidopuntaje[x + 1, 0] = nombreapellidopuntaje[11, 0];
                                nombreapellidopuntaje[x + 1, 1] = nombreapellidopuntaje[11, 1];
                                nombreapellidopuntaje[x + 1, 2] = nombreapellidopuntaje[11, 2];
                                nombreapellidopuntaje[x + 2, 0] = nombreapellidopuntaje[12, 0];
                                nombreapellidopuntaje[x + 2, 1] = nombreapellidopuntaje[12, 1];
                                nombreapellidopuntaje[x + 2, 2] = nombreapellidopuntaje[12, 2];
                                nombreapellidopuntaje[x + 3, 0] = nombreapellidopuntaje[13, 0];
                                nombreapellidopuntaje[x + 3, 1] = nombreapellidopuntaje[13, 1];
                                nombreapellidopuntaje[x + 3, 2] = nombreapellidopuntaje[13, 2];
                                nombreapellidopuntaje[x + 4, 0] = nombreapellidopuntaje[14, 0];
                                nombreapellidopuntaje[x + 4, 1] = nombreapellidopuntaje[14, 1];
                                nombreapellidopuntaje[x + 4, 2] = nombreapellidopuntaje[14, 2];

                                nombreapellidopuntaje[11, 0] = "";
                                nombreapellidopuntaje[11, 1] = "";
                                nombreapellidopuntaje[11, 2] = "";
                                nombreapellidopuntaje[12, 0] = "";
                                nombreapellidopuntaje[12, 1] = "";
                                nombreapellidopuntaje[12, 2] = "";
                                nombreapellidopuntaje[13, 0] = "";
                                nombreapellidopuntaje[13, 1] = "";
                                nombreapellidopuntaje[13, 2] = "";
                                nombreapellidopuntaje[14, 0] = "";
                                nombreapellidopuntaje[14, 1] = "";
                                nombreapellidopuntaje[14, 2] = "";

                                puntajes[11] = puntajes[x];
                                puntajes[12] = puntajes[x + 1];
                                puntajes[13] = puntajes[x + 2];
                                puntajes[14] = puntajes[x + 3];

                                puntajes[x] = puntajes[x + 4];
                                puntajes[x + 1] = puntajes[11];
                                puntajes[x + 2] = puntajes[12];
                                puntajes[x + 3] = puntajes[13];
                                puntajes[x + 4] = puntajes[14];

                                puntajes[11] = 0;
                                puntajes[12] = 0;
                                puntajes[13] = 0;
                                puntajes[14] = 0;

                                cambio = true;
                                x = 0;
                                x = x + 4;
                            }
                        }
                        else if (puntajes[x] < puntajes[x + 3])
                        {
                            nombreapellidopuntaje[11, 0] = nombreapellidopuntaje[x, 0];
                            nombreapellidopuntaje[11, 1] = nombreapellidopuntaje[x, 1];
                            nombreapellidopuntaje[11, 2] = nombreapellidopuntaje[x, 2];
                            nombreapellidopuntaje[12, 0] = nombreapellidopuntaje[x + 1, 0];
                            nombreapellidopuntaje[12, 1] = nombreapellidopuntaje[x + 1, 1];
                            nombreapellidopuntaje[12, 2] = nombreapellidopuntaje[x + 1, 2];
                            nombreapellidopuntaje[13, 0] = nombreapellidopuntaje[x + 2, 0];
                            nombreapellidopuntaje[13, 1] = nombreapellidopuntaje[x + 2, 1];
                            nombreapellidopuntaje[13, 2] = nombreapellidopuntaje[x + 2, 2];

                            nombreapellidopuntaje[x, 0] = nombreapellidopuntaje[x + 3, 0];
                            nombreapellidopuntaje[x, 1] = nombreapellidopuntaje[x + 3, 1];
                            nombreapellidopuntaje[x, 2] = nombreapellidopuntaje[x + 3, 2];
                            nombreapellidopuntaje[x + 1, 0] = nombreapellidopuntaje[11, 0];
                            nombreapellidopuntaje[x + 1, 1] = nombreapellidopuntaje[11, 1];
                            nombreapellidopuntaje[x + 1, 2] = nombreapellidopuntaje[11, 2];
                            nombreapellidopuntaje[x + 2, 0] = nombreapellidopuntaje[12, 0];
                            nombreapellidopuntaje[x + 2, 1] = nombreapellidopuntaje[12, 1];
                            nombreapellidopuntaje[x + 2, 2] = nombreapellidopuntaje[12, 2];

                            nombreapellidopuntaje[x + 3, 0] = nombreapellidopuntaje[13, 0];
                            nombreapellidopuntaje[x + 3, 1] = nombreapellidopuntaje[13, 1];
                            nombreapellidopuntaje[x + 3, 2] = nombreapellidopuntaje[13, 2];

                            nombreapellidopuntaje[11, 0] = "";
                            nombreapellidopuntaje[11, 1] = "";
                            nombreapellidopuntaje[11, 2] = "";
                            nombreapellidopuntaje[12, 0] = "";
                            nombreapellidopuntaje[12, 1] = "";
                            nombreapellidopuntaje[12, 2] = "";
                            nombreapellidopuntaje[13, 0] = "";
                            nombreapellidopuntaje[13, 1] = "";
                            nombreapellidopuntaje[13, 2] = "";

                            puntajes[11] = puntajes[x];
                            puntajes[12] = puntajes[x + 1];
                            puntajes[13] = puntajes[x + 2];

                            puntajes[x] = puntajes[x + 3];
                            puntajes[x + 1] = puntajes[11];
                            puntajes[x + 2] = puntajes[12];

                            puntajes[x + 3] = puntajes[13];

                            puntajes[11] = 0;
                            puntajes[12] = 0;
                            puntajes[13] = 0;

                            cambio = true;
                            x = 0;
                            x = x + 3;
                        }
                    }
                    else if (puntajes[x] < puntajes[x + 2])
                    {
                        nombreapellidopuntaje[11, 0] = nombreapellidopuntaje[x, 0];
                        nombreapellidopuntaje[11, 1] = nombreapellidopuntaje[x, 1];
                        nombreapellidopuntaje[11, 2] = nombreapellidopuntaje[x, 2];
                        nombreapellidopuntaje[12, 0] = nombreapellidopuntaje[x + 1, 0];
                        nombreapellidopuntaje[12, 1] = nombreapellidopuntaje[x + 1, 1];
                        nombreapellidopuntaje[12, 2] = nombreapellidopuntaje[x + 1, 2];

                        nombreapellidopuntaje[x, 0] = nombreapellidopuntaje[x + 2, 0];
                        nombreapellidopuntaje[x, 1] = nombreapellidopuntaje[x + 2, 1];
                        nombreapellidopuntaje[x, 2] = nombreapellidopuntaje[x + 2, 2];
                        nombreapellidopuntaje[x + 1, 0] = nombreapellidopuntaje[11, 0];
                        nombreapellidopuntaje[x + 1, 1] = nombreapellidopuntaje[11, 1];
                        nombreapellidopuntaje[x + 1, 2] = nombreapellidopuntaje[11, 2];

                        nombreapellidopuntaje[x + 2, 0] = nombreapellidopuntaje[12, 0];
                        nombreapellidopuntaje[x + 2, 1] = nombreapellidopuntaje[12, 1];
                        nombreapellidopuntaje[x + 2, 2] = nombreapellidopuntaje[12, 2];

                        nombreapellidopuntaje[11, 0] = "";
                        nombreapellidopuntaje[11, 1] = "";
                        nombreapellidopuntaje[11, 2] = "";
                        nombreapellidopuntaje[12, 0] = "";
                        nombreapellidopuntaje[12, 1] = "";
                        nombreapellidopuntaje[12, 2] = "";

                        puntajes[11] = puntajes[x];
                        puntajes[12] = puntajes[x + 1];

                        puntajes[x] = puntajes[x + 2];
                        puntajes[x + 1] = puntajes[11];

                        puntajes[x + 2] = puntajes[12];

                        puntajes[11] = 0;
                        puntajes[12] = 0;

                        cambio = true;
                        x = 0;
                        x = x + 2;
                    }
                }
                else if (puntajes[x] < puntajes[x + 1])
                {
                    nombreapellidopuntaje[11, 0] = nombreapellidopuntaje[x, 0];
                    nombreapellidopuntaje[11, 1] = nombreapellidopuntaje[x, 1];
                    nombreapellidopuntaje[11, 2] = nombreapellidopuntaje[x, 2];

                    nombreapellidopuntaje[x, 0] = nombreapellidopuntaje[x + 1, 0];
                    nombreapellidopuntaje[x, 1] = nombreapellidopuntaje[x + 1, 1];
                    nombreapellidopuntaje[x, 2] = nombreapellidopuntaje[x + 1, 2];

                    nombreapellidopuntaje[x + 1, 0] = nombreapellidopuntaje[11, 0];
                    nombreapellidopuntaje[x + 1, 1] = nombreapellidopuntaje[11, 1];
                    nombreapellidopuntaje[x + 1, 2] = nombreapellidopuntaje[11, 2];

                    nombreapellidopuntaje[11, 0] = "";
                    nombreapellidopuntaje[11, 1] = "";
                    nombreapellidopuntaje[11, 2] = "";

                    puntajes[11] = puntajes[x];

                    puntajes[x] = puntajes[x + 1];

                    puntajes[x + 1] = puntajes[11];

                    puntajes[11] = 0;

                    cambio = true;
                    x = 0;
                    x++;
                }
            }

            if (orden)
            {
                nombreapellidopuntaje[9, 0] = nombreapellidopuntaje[8, 0];
                nombreapellidopuntaje[8, 0] = nombreapellidopuntaje[7, 0];
                nombreapellidopuntaje[7, 0] = nombreapellidopuntaje[6, 0];
                nombreapellidopuntaje[6, 0] = nombreapellidopuntaje[5, 0];
                nombreapellidopuntaje[5, 0] = nombreapellidopuntaje[4, 0];
                nombreapellidopuntaje[4, 0] = nombreapellidopuntaje[3, 0];
                nombreapellidopuntaje[3, 0] = nombreapellidopuntaje[2, 0];
                nombreapellidopuntaje[2, 0] = nombreapellidopuntaje[1, 0];
                nombreapellidopuntaje[1, 0] = nombreapellidopuntaje[0, 0];
                nombreapellidopuntaje[0, 0] = nombre;

                nombreapellidopuntaje[9, 1] = nombreapellidopuntaje[8, 1];
                nombreapellidopuntaje[8, 1] = nombreapellidopuntaje[7, 1];
                nombreapellidopuntaje[7, 1] = nombreapellidopuntaje[6, 1];
                nombreapellidopuntaje[6, 1] = nombreapellidopuntaje[5, 1];
                nombreapellidopuntaje[5, 1] = nombreapellidopuntaje[4, 1];
                nombreapellidopuntaje[4, 1] = nombreapellidopuntaje[3, 1];
                nombreapellidopuntaje[3, 1] = nombreapellidopuntaje[2, 1];
                nombreapellidopuntaje[2, 1] = nombreapellidopuntaje[1, 1];
                nombreapellidopuntaje[1, 1] = nombreapellidopuntaje[0, 1];
                nombreapellidopuntaje[0, 1] = apellido;

                nombreapellidopuntaje[9, 2] = nombreapellidopuntaje[8, 2];
                nombreapellidopuntaje[8, 2] = nombreapellidopuntaje[7, 2];
                nombreapellidopuntaje[7, 2] = nombreapellidopuntaje[6, 2];
                nombreapellidopuntaje[6, 2] = nombreapellidopuntaje[5, 2];
                nombreapellidopuntaje[5, 2] = nombreapellidopuntaje[4, 2];
                nombreapellidopuntaje[4, 2] = nombreapellidopuntaje[3, 2];
                nombreapellidopuntaje[3, 2] = nombreapellidopuntaje[2, 2];
                nombreapellidopuntaje[2, 2] = nombreapellidopuntaje[1, 2];
                nombreapellidopuntaje[1, 2] = nombreapellidopuntaje[0, 2];
                nombreapellidopuntaje[0, 2] = Convert.ToString(puntaje);

                Console.WriteLine("ordenado");
            }

            puntajes[0] = Convert.ToInt16(nombreapellidopuntaje[0, 2]);
            puntajes[1] = Convert.ToInt16(nombreapellidopuntaje[1, 2]);
            puntajes[2] = Convert.ToInt16(nombreapellidopuntaje[2, 2]);
            puntajes[3] = Convert.ToInt16(nombreapellidopuntaje[3, 2]);
            puntajes[4] = Convert.ToInt16(nombreapellidopuntaje[4, 2]);
            puntajes[5] = Convert.ToInt16(nombreapellidopuntaje[5, 2]);
            puntajes[6] = Convert.ToInt16(nombreapellidopuntaje[6, 2]);
            puntajes[7] = Convert.ToInt16(nombreapellidopuntaje[7, 2]);
            puntajes[8] = Convert.ToInt16(nombreapellidopuntaje[8, 2]);
            puntajes[9] = Convert.ToInt16(nombreapellidopuntaje[9, 2]);

            for (int x = 0; x <= 9; x++)
            {
                if (puntajes[x] > puntajes[x + 1])
                {
                    if (puntajes[x] > puntajes[x + 2])
                    {
                        if (puntajes[x] > puntajes[x + 3])
                        {
                            if (puntajes[x] > puntajes[x + 4])
                            {
                                if (puntajes[x] > puntajes[x + 5])
                                {
                                    if (puntajes[x] > puntajes[x + 6])
                                    {
                                        if (puntajes[x] > puntajes[x + 7])
                                        {
                                            if (puntajes[x] > puntajes[x + 8])
                                            {
                                                if (puntajes[x] > puntajes[x + 9])
                                                {
                                                    if (x == 9)
                                                    {
                                                        orden = true;
                                                    }
                                                    if (cambio)
                                                    {
                                                        x = 0;
                                                        cambio = false;
                                                    }
                                                }
                                                else if (puntajes[x] < puntajes[x + 9])
                                                {
                                                    nombreapellidopuntaje[11, 0] = nombreapellidopuntaje[x, 0];
                                                    nombreapellidopuntaje[11, 1] = nombreapellidopuntaje[x, 1];
                                                    nombreapellidopuntaje[11, 2] = nombreapellidopuntaje[x, 2];
                                                    nombreapellidopuntaje[12, 0] = nombreapellidopuntaje[x + 1, 0];
                                                    nombreapellidopuntaje[12, 1] = nombreapellidopuntaje[x + 1, 1];
                                                    nombreapellidopuntaje[12, 2] = nombreapellidopuntaje[x + 1, 2];
                                                    nombreapellidopuntaje[13, 0] = nombreapellidopuntaje[x + 2, 0];
                                                    nombreapellidopuntaje[13, 1] = nombreapellidopuntaje[x + 2, 1];
                                                    nombreapellidopuntaje[13, 2] = nombreapellidopuntaje[x + 2, 2];
                                                    nombreapellidopuntaje[14, 0] = nombreapellidopuntaje[x + 3, 0];
                                                    nombreapellidopuntaje[14, 1] = nombreapellidopuntaje[x + 3, 1];
                                                    nombreapellidopuntaje[14, 2] = nombreapellidopuntaje[x + 3, 2];
                                                    nombreapellidopuntaje[15, 0] = nombreapellidopuntaje[x + 4, 0];
                                                    nombreapellidopuntaje[15, 1] = nombreapellidopuntaje[x + 4, 1];
                                                    nombreapellidopuntaje[15, 2] = nombreapellidopuntaje[x + 4, 2];
                                                    nombreapellidopuntaje[16, 0] = nombreapellidopuntaje[x + 5, 0];
                                                    nombreapellidopuntaje[16, 1] = nombreapellidopuntaje[x + 5, 1];
                                                    nombreapellidopuntaje[16, 2] = nombreapellidopuntaje[x + 5, 2];
                                                    nombreapellidopuntaje[17, 0] = nombreapellidopuntaje[x + 6, 0];
                                                    nombreapellidopuntaje[17, 1] = nombreapellidopuntaje[x + 6, 1];
                                                    nombreapellidopuntaje[17, 2] = nombreapellidopuntaje[x + 6, 2];
                                                    nombreapellidopuntaje[18, 0] = nombreapellidopuntaje[x + 7, 0];
                                                    nombreapellidopuntaje[18, 1] = nombreapellidopuntaje[x + 7, 1];
                                                    nombreapellidopuntaje[18, 2] = nombreapellidopuntaje[x + 7, 2];
                                                    nombreapellidopuntaje[19, 0] = nombreapellidopuntaje[x + 8, 0];
                                                    nombreapellidopuntaje[19, 1] = nombreapellidopuntaje[x + 8, 1];
                                                    nombreapellidopuntaje[19, 2] = nombreapellidopuntaje[x + 8, 2];

                                                    nombreapellidopuntaje[x, 0] = nombreapellidopuntaje[x + 9, 0];
                                                    nombreapellidopuntaje[x, 1] = nombreapellidopuntaje[x + 9, 1];
                                                    nombreapellidopuntaje[x, 2] = nombreapellidopuntaje[x + 9, 2];
                                                    nombreapellidopuntaje[x + 1, 0] = nombreapellidopuntaje[11, 0];
                                                    nombreapellidopuntaje[x + 1, 1] = nombreapellidopuntaje[11, 1];
                                                    nombreapellidopuntaje[x + 1, 2] = nombreapellidopuntaje[11, 2];
                                                    nombreapellidopuntaje[x + 2, 0] = nombreapellidopuntaje[12, 0];
                                                    nombreapellidopuntaje[x + 2, 1] = nombreapellidopuntaje[12, 1];
                                                    nombreapellidopuntaje[x + 2, 2] = nombreapellidopuntaje[12, 2];
                                                    nombreapellidopuntaje[x + 3, 0] = nombreapellidopuntaje[13, 0];
                                                    nombreapellidopuntaje[x + 3, 1] = nombreapellidopuntaje[13, 1];
                                                    nombreapellidopuntaje[x + 3, 2] = nombreapellidopuntaje[13, 2];
                                                    nombreapellidopuntaje[x + 4, 0] = nombreapellidopuntaje[14, 0];
                                                    nombreapellidopuntaje[x + 4, 1] = nombreapellidopuntaje[14, 1];
                                                    nombreapellidopuntaje[x + 4, 2] = nombreapellidopuntaje[14, 2];
                                                    nombreapellidopuntaje[x + 5, 0] = nombreapellidopuntaje[15, 0];
                                                    nombreapellidopuntaje[x + 5, 1] = nombreapellidopuntaje[15, 1];
                                                    nombreapellidopuntaje[x + 5, 2] = nombreapellidopuntaje[15, 2];
                                                    nombreapellidopuntaje[x + 6, 0] = nombreapellidopuntaje[16, 0];
                                                    nombreapellidopuntaje[x + 6, 1] = nombreapellidopuntaje[16, 1];
                                                    nombreapellidopuntaje[x + 6, 2] = nombreapellidopuntaje[16, 2];
                                                    nombreapellidopuntaje[x + 7, 0] = nombreapellidopuntaje[17, 0];
                                                    nombreapellidopuntaje[x + 7, 1] = nombreapellidopuntaje[17, 1];
                                                    nombreapellidopuntaje[x + 7, 2] = nombreapellidopuntaje[17, 2];
                                                    nombreapellidopuntaje[x + 8, 0] = nombreapellidopuntaje[18, 0];
                                                    nombreapellidopuntaje[x + 8, 1] = nombreapellidopuntaje[18, 1];
                                                    nombreapellidopuntaje[x + 8, 2] = nombreapellidopuntaje[18, 2];
                                                    nombreapellidopuntaje[x + 9, 0] = nombreapellidopuntaje[19, 0];
                                                    nombreapellidopuntaje[x + 9, 1] = nombreapellidopuntaje[19, 1];
                                                    nombreapellidopuntaje[x + 9, 2] = nombreapellidopuntaje[19, 2];


                                                    nombreapellidopuntaje[11, 0] = "";
                                                    nombreapellidopuntaje[11, 1] = "";
                                                    nombreapellidopuntaje[11, 2] = "";
                                                    nombreapellidopuntaje[12, 0] = "";
                                                    nombreapellidopuntaje[12, 1] = "";
                                                    nombreapellidopuntaje[12, 2] = "";
                                                    nombreapellidopuntaje[13, 0] = "";
                                                    nombreapellidopuntaje[13, 1] = "";
                                                    nombreapellidopuntaje[13, 2] = "";
                                                    nombreapellidopuntaje[14, 0] = "";
                                                    nombreapellidopuntaje[14, 1] = "";
                                                    nombreapellidopuntaje[14, 2] = "";
                                                    nombreapellidopuntaje[15, 0] = "";
                                                    nombreapellidopuntaje[15, 1] = "";
                                                    nombreapellidopuntaje[15, 2] = "";
                                                    nombreapellidopuntaje[16, 0] = "";
                                                    nombreapellidopuntaje[16, 1] = "";
                                                    nombreapellidopuntaje[16, 2] = "";
                                                    nombreapellidopuntaje[17, 0] = "";
                                                    nombreapellidopuntaje[17, 1] = "";
                                                    nombreapellidopuntaje[17, 2] = "";
                                                    nombreapellidopuntaje[18, 0] = "";
                                                    nombreapellidopuntaje[18, 1] = "";
                                                    nombreapellidopuntaje[18, 2] = "";
                                                    nombreapellidopuntaje[19, 0] = "";
                                                    nombreapellidopuntaje[19, 1] = "";
                                                    nombreapellidopuntaje[19, 2] = "";

                                                    puntajes[11] = puntajes[x];
                                                    puntajes[12] = puntajes[x + 1];
                                                    puntajes[13] = puntajes[x + 2];
                                                    puntajes[14] = puntajes[x + 3];
                                                    puntajes[15] = puntajes[x + 4];
                                                    puntajes[16] = puntajes[x + 5];
                                                    puntajes[17] = puntajes[x + 6];
                                                    puntajes[18] = puntajes[x + 7];
                                                    puntajes[19] = puntajes[x + 8];

                                                    puntajes[x] = puntajes[x + 9];
                                                    puntajes[x + 1] = puntajes[11];
                                                    puntajes[x + 2] = puntajes[12];
                                                    puntajes[x + 3] = puntajes[13];
                                                    puntajes[x + 4] = puntajes[14];
                                                    puntajes[x + 5] = puntajes[15];
                                                    puntajes[x + 6] = puntajes[16];
                                                    puntajes[x + 7] = puntajes[17];
                                                    puntajes[x + 8] = puntajes[18];
                                                    puntajes[x + 9] = puntajes[19];

                                                    puntajes[11] = 0;
                                                    puntajes[12] = 0;
                                                    puntajes[13] = 0;
                                                    puntajes[14] = 0;
                                                    puntajes[15] = 0;
                                                    puntajes[16] = 0;
                                                    puntajes[17] = 0;
                                                    puntajes[18] = 0;
                                                    puntajes[19] = 0;

                                                    cambio = true;
                                                    x = 0;
                                                    x = x + 9;
                                                }
                                            }
                                            else if (puntajes[x] < puntajes[x + 8])
                                            {
                                                nombreapellidopuntaje[11, 0] = nombreapellidopuntaje[x, 0];
                                                nombreapellidopuntaje[11, 1] = nombreapellidopuntaje[x, 1];
                                                nombreapellidopuntaje[11, 2] = nombreapellidopuntaje[x, 2];
                                                nombreapellidopuntaje[12, 0] = nombreapellidopuntaje[x + 1, 0];
                                                nombreapellidopuntaje[12, 1] = nombreapellidopuntaje[x + 1, 1];
                                                nombreapellidopuntaje[12, 2] = nombreapellidopuntaje[x + 1, 2];
                                                nombreapellidopuntaje[13, 0] = nombreapellidopuntaje[x + 2, 0];
                                                nombreapellidopuntaje[13, 1] = nombreapellidopuntaje[x + 2, 1];
                                                nombreapellidopuntaje[13, 2] = nombreapellidopuntaje[x + 2, 2];
                                                nombreapellidopuntaje[14, 0] = nombreapellidopuntaje[x + 3, 0];
                                                nombreapellidopuntaje[14, 1] = nombreapellidopuntaje[x + 3, 1];
                                                nombreapellidopuntaje[14, 2] = nombreapellidopuntaje[x + 3, 2];
                                                nombreapellidopuntaje[15, 0] = nombreapellidopuntaje[x + 4, 0];
                                                nombreapellidopuntaje[15, 1] = nombreapellidopuntaje[x + 4, 1];
                                                nombreapellidopuntaje[15, 2] = nombreapellidopuntaje[x + 4, 2];
                                                nombreapellidopuntaje[16, 0] = nombreapellidopuntaje[x + 5, 0];
                                                nombreapellidopuntaje[16, 1] = nombreapellidopuntaje[x + 5, 1];
                                                nombreapellidopuntaje[16, 2] = nombreapellidopuntaje[x + 5, 2];
                                                nombreapellidopuntaje[17, 0] = nombreapellidopuntaje[x + 6, 0];
                                                nombreapellidopuntaje[17, 1] = nombreapellidopuntaje[x + 6, 1];
                                                nombreapellidopuntaje[17, 2] = nombreapellidopuntaje[x + 6, 2];
                                                nombreapellidopuntaje[18, 0] = nombreapellidopuntaje[x + 7, 0];
                                                nombreapellidopuntaje[18, 1] = nombreapellidopuntaje[x + 7, 1];
                                                nombreapellidopuntaje[18, 2] = nombreapellidopuntaje[x + 7, 2];

                                                nombreapellidopuntaje[x, 0] = nombreapellidopuntaje[x + 8, 0];
                                                nombreapellidopuntaje[x, 1] = nombreapellidopuntaje[x + 8, 1];
                                                nombreapellidopuntaje[x, 2] = nombreapellidopuntaje[x + 8, 2];
                                                nombreapellidopuntaje[x + 1, 0] = nombreapellidopuntaje[11, 0];
                                                nombreapellidopuntaje[x + 1, 1] = nombreapellidopuntaje[11, 1];
                                                nombreapellidopuntaje[x + 1, 2] = nombreapellidopuntaje[11, 2];
                                                nombreapellidopuntaje[x + 2, 0] = nombreapellidopuntaje[12, 0];
                                                nombreapellidopuntaje[x + 2, 1] = nombreapellidopuntaje[12, 1];
                                                nombreapellidopuntaje[x + 2, 2] = nombreapellidopuntaje[12, 2];
                                                nombreapellidopuntaje[x + 3, 0] = nombreapellidopuntaje[13, 0];
                                                nombreapellidopuntaje[x + 3, 1] = nombreapellidopuntaje[13, 1];
                                                nombreapellidopuntaje[x + 3, 2] = nombreapellidopuntaje[13, 2];
                                                nombreapellidopuntaje[x + 4, 0] = nombreapellidopuntaje[14, 0];
                                                nombreapellidopuntaje[x + 4, 1] = nombreapellidopuntaje[14, 1];
                                                nombreapellidopuntaje[x + 4, 2] = nombreapellidopuntaje[14, 2];
                                                nombreapellidopuntaje[x + 5, 0] = nombreapellidopuntaje[15, 0];
                                                nombreapellidopuntaje[x + 5, 1] = nombreapellidopuntaje[15, 1];
                                                nombreapellidopuntaje[x + 5, 2] = nombreapellidopuntaje[15, 2];
                                                nombreapellidopuntaje[x + 6, 0] = nombreapellidopuntaje[16, 0];
                                                nombreapellidopuntaje[x + 6, 1] = nombreapellidopuntaje[16, 1];
                                                nombreapellidopuntaje[x + 6, 2] = nombreapellidopuntaje[16, 2];
                                                nombreapellidopuntaje[x + 7, 0] = nombreapellidopuntaje[17, 0];
                                                nombreapellidopuntaje[x + 7, 1] = nombreapellidopuntaje[17, 1];
                                                nombreapellidopuntaje[x + 7, 2] = nombreapellidopuntaje[17, 2];
                                                nombreapellidopuntaje[x + 8, 0] = nombreapellidopuntaje[18, 0];
                                                nombreapellidopuntaje[x + 8, 1] = nombreapellidopuntaje[18, 1];
                                                nombreapellidopuntaje[x + 8, 2] = nombreapellidopuntaje[18, 2];


                                                nombreapellidopuntaje[11, 0] = "";
                                                nombreapellidopuntaje[11, 1] = "";
                                                nombreapellidopuntaje[11, 2] = "";
                                                nombreapellidopuntaje[12, 0] = "";
                                                nombreapellidopuntaje[12, 1] = "";
                                                nombreapellidopuntaje[12, 2] = "";
                                                nombreapellidopuntaje[13, 0] = "";
                                                nombreapellidopuntaje[13, 1] = "";
                                                nombreapellidopuntaje[13, 2] = "";
                                                nombreapellidopuntaje[14, 0] = "";
                                                nombreapellidopuntaje[14, 1] = "";
                                                nombreapellidopuntaje[14, 2] = "";
                                                nombreapellidopuntaje[15, 0] = "";
                                                nombreapellidopuntaje[15, 1] = "";
                                                nombreapellidopuntaje[15, 2] = "";
                                                nombreapellidopuntaje[16, 0] = "";
                                                nombreapellidopuntaje[16, 1] = "";
                                                nombreapellidopuntaje[16, 2] = "";
                                                nombreapellidopuntaje[17, 0] = "";
                                                nombreapellidopuntaje[17, 1] = "";
                                                nombreapellidopuntaje[17, 2] = "";
                                                nombreapellidopuntaje[18, 0] = "";
                                                nombreapellidopuntaje[18, 1] = "";
                                                nombreapellidopuntaje[18, 2] = "";

                                                puntajes[11] = puntajes[x];
                                                puntajes[12] = puntajes[x + 1];
                                                puntajes[13] = puntajes[x + 2];
                                                puntajes[14] = puntajes[x + 3];
                                                puntajes[15] = puntajes[x + 4];
                                                puntajes[16] = puntajes[x + 5];
                                                puntajes[17] = puntajes[x + 6];
                                                puntajes[18] = puntajes[x + 7];

                                                puntajes[x] = puntajes[x + 8];
                                                puntajes[x + 1] = puntajes[11];
                                                puntajes[x + 2] = puntajes[12];
                                                puntajes[x + 3] = puntajes[13];
                                                puntajes[x + 4] = puntajes[14];
                                                puntajes[x + 5] = puntajes[15];
                                                puntajes[x + 6] = puntajes[16];
                                                puntajes[x + 7] = puntajes[17];
                                                puntajes[x + 8] = puntajes[18];

                                                puntajes[11] = 0;
                                                puntajes[12] = 0;
                                                puntajes[13] = 0;
                                                puntajes[14] = 0;
                                                puntajes[15] = 0;
                                                puntajes[16] = 0;
                                                puntajes[17] = 0;
                                                puntajes[18] = 0;

                                                cambio = true;
                                                x = 0;
                                                x = x + 8;
                                            }
                                        }
                                        else if (puntajes[x] < puntajes[x + 7])
                                        {
                                            nombreapellidopuntaje[11, 0] = nombreapellidopuntaje[x, 0];
                                            nombreapellidopuntaje[11, 1] = nombreapellidopuntaje[x, 1];
                                            nombreapellidopuntaje[11, 2] = nombreapellidopuntaje[x, 2];
                                            nombreapellidopuntaje[12, 0] = nombreapellidopuntaje[x + 1, 0];
                                            nombreapellidopuntaje[12, 1] = nombreapellidopuntaje[x + 1, 1];
                                            nombreapellidopuntaje[12, 2] = nombreapellidopuntaje[x + 1, 2];
                                            nombreapellidopuntaje[13, 0] = nombreapellidopuntaje[x + 2, 0];
                                            nombreapellidopuntaje[13, 1] = nombreapellidopuntaje[x + 2, 1];
                                            nombreapellidopuntaje[13, 2] = nombreapellidopuntaje[x + 2, 2];
                                            nombreapellidopuntaje[14, 0] = nombreapellidopuntaje[x + 3, 0];
                                            nombreapellidopuntaje[14, 1] = nombreapellidopuntaje[x + 3, 1];
                                            nombreapellidopuntaje[14, 2] = nombreapellidopuntaje[x + 3, 2];
                                            nombreapellidopuntaje[15, 0] = nombreapellidopuntaje[x + 4, 0];
                                            nombreapellidopuntaje[15, 1] = nombreapellidopuntaje[x + 4, 1];
                                            nombreapellidopuntaje[15, 2] = nombreapellidopuntaje[x + 4, 2];
                                            nombreapellidopuntaje[16, 0] = nombreapellidopuntaje[x + 5, 0];
                                            nombreapellidopuntaje[16, 1] = nombreapellidopuntaje[x + 5, 1];
                                            nombreapellidopuntaje[16, 2] = nombreapellidopuntaje[x + 5, 2];
                                            nombreapellidopuntaje[17, 0] = nombreapellidopuntaje[x + 6, 0];
                                            nombreapellidopuntaje[17, 1] = nombreapellidopuntaje[x + 6, 1];
                                            nombreapellidopuntaje[17, 2] = nombreapellidopuntaje[x + 6, 2];

                                            nombreapellidopuntaje[x, 0] = nombreapellidopuntaje[x + 7, 0];
                                            nombreapellidopuntaje[x, 1] = nombreapellidopuntaje[x + 7, 1];
                                            nombreapellidopuntaje[x, 2] = nombreapellidopuntaje[x + 7, 2];
                                            nombreapellidopuntaje[x + 1, 0] = nombreapellidopuntaje[11, 0];
                                            nombreapellidopuntaje[x + 1, 1] = nombreapellidopuntaje[11, 1];
                                            nombreapellidopuntaje[x + 1, 2] = nombreapellidopuntaje[11, 2];
                                            nombreapellidopuntaje[x + 2, 0] = nombreapellidopuntaje[12, 0];
                                            nombreapellidopuntaje[x + 2, 1] = nombreapellidopuntaje[12, 1];
                                            nombreapellidopuntaje[x + 2, 2] = nombreapellidopuntaje[12, 2];
                                            nombreapellidopuntaje[x + 3, 0] = nombreapellidopuntaje[13, 0];
                                            nombreapellidopuntaje[x + 3, 1] = nombreapellidopuntaje[13, 1];
                                            nombreapellidopuntaje[x + 3, 2] = nombreapellidopuntaje[13, 2];
                                            nombreapellidopuntaje[x + 4, 0] = nombreapellidopuntaje[14, 0];
                                            nombreapellidopuntaje[x + 4, 1] = nombreapellidopuntaje[14, 1];
                                            nombreapellidopuntaje[x + 4, 2] = nombreapellidopuntaje[14, 2];
                                            nombreapellidopuntaje[x + 5, 0] = nombreapellidopuntaje[15, 0];
                                            nombreapellidopuntaje[x + 5, 1] = nombreapellidopuntaje[15, 1];
                                            nombreapellidopuntaje[x + 5, 2] = nombreapellidopuntaje[15, 2];
                                            nombreapellidopuntaje[x + 6, 0] = nombreapellidopuntaje[16, 0];
                                            nombreapellidopuntaje[x + 6, 1] = nombreapellidopuntaje[16, 1];
                                            nombreapellidopuntaje[x + 6, 2] = nombreapellidopuntaje[16, 2];
                                            nombreapellidopuntaje[x + 7, 0] = nombreapellidopuntaje[17, 0];
                                            nombreapellidopuntaje[x + 7, 1] = nombreapellidopuntaje[17, 1];
                                            nombreapellidopuntaje[x + 7, 2] = nombreapellidopuntaje[17, 2];


                                            nombreapellidopuntaje[11, 0] = "";
                                            nombreapellidopuntaje[11, 1] = "";
                                            nombreapellidopuntaje[11, 2] = "";
                                            nombreapellidopuntaje[12, 0] = "";
                                            nombreapellidopuntaje[12, 1] = "";
                                            nombreapellidopuntaje[12, 2] = "";
                                            nombreapellidopuntaje[13, 0] = "";
                                            nombreapellidopuntaje[13, 1] = "";
                                            nombreapellidopuntaje[13, 2] = "";
                                            nombreapellidopuntaje[14, 0] = "";
                                            nombreapellidopuntaje[14, 1] = "";
                                            nombreapellidopuntaje[14, 2] = "";
                                            nombreapellidopuntaje[15, 0] = "";
                                            nombreapellidopuntaje[15, 1] = "";
                                            nombreapellidopuntaje[15, 2] = "";
                                            nombreapellidopuntaje[16, 0] = "";
                                            nombreapellidopuntaje[16, 1] = "";
                                            nombreapellidopuntaje[16, 2] = "";
                                            nombreapellidopuntaje[17, 0] = "";
                                            nombreapellidopuntaje[17, 1] = "";
                                            nombreapellidopuntaje[17, 2] = "";

                                            puntajes[11] = puntajes[x];
                                            puntajes[12] = puntajes[x + 1];
                                            puntajes[13] = puntajes[x + 2];
                                            puntajes[14] = puntajes[x + 3];
                                            puntajes[15] = puntajes[x + 4];
                                            puntajes[16] = puntajes[x + 5];
                                            puntajes[17] = puntajes[x + 6];

                                            puntajes[x] = puntajes[x + 7];
                                            puntajes[x + 1] = puntajes[11];
                                            puntajes[x + 2] = puntajes[12];
                                            puntajes[x + 3] = puntajes[13];
                                            puntajes[x + 4] = puntajes[14];
                                            puntajes[x + 5] = puntajes[15];
                                            puntajes[x + 6] = puntajes[16];
                                            puntajes[x + 7] = puntajes[17];

                                            puntajes[11] = 0;
                                            puntajes[12] = 0;
                                            puntajes[13] = 0;
                                            puntajes[14] = 0;
                                            puntajes[15] = 0;
                                            puntajes[16] = 0;
                                            puntajes[17] = 0;

                                            cambio = true;
                                            x = 0;
                                            x = x + 7;
                                        }
                                    }
                                    else if (puntajes[x] < puntajes[x + 6])
                                    {
                                        nombreapellidopuntaje[11, 0] = nombreapellidopuntaje[x, 0];
                                        nombreapellidopuntaje[11, 1] = nombreapellidopuntaje[x, 1];
                                        nombreapellidopuntaje[11, 2] = nombreapellidopuntaje[x, 2];
                                        nombreapellidopuntaje[12, 0] = nombreapellidopuntaje[x + 1, 0];
                                        nombreapellidopuntaje[12, 1] = nombreapellidopuntaje[x + 1, 1];
                                        nombreapellidopuntaje[12, 2] = nombreapellidopuntaje[x + 1, 2];
                                        nombreapellidopuntaje[13, 0] = nombreapellidopuntaje[x + 2, 0];
                                        nombreapellidopuntaje[13, 1] = nombreapellidopuntaje[x + 2, 1];
                                        nombreapellidopuntaje[13, 2] = nombreapellidopuntaje[x + 2, 2];
                                        nombreapellidopuntaje[14, 0] = nombreapellidopuntaje[x + 3, 0];
                                        nombreapellidopuntaje[14, 1] = nombreapellidopuntaje[x + 3, 1];
                                        nombreapellidopuntaje[14, 2] = nombreapellidopuntaje[x + 3, 2];
                                        nombreapellidopuntaje[15, 0] = nombreapellidopuntaje[x + 4, 0];
                                        nombreapellidopuntaje[15, 1] = nombreapellidopuntaje[x + 4, 1];
                                        nombreapellidopuntaje[15, 2] = nombreapellidopuntaje[x + 4, 2];
                                        nombreapellidopuntaje[16, 0] = nombreapellidopuntaje[x + 5, 0];
                                        nombreapellidopuntaje[16, 1] = nombreapellidopuntaje[x + 5, 1];
                                        nombreapellidopuntaje[16, 2] = nombreapellidopuntaje[x + 5, 2];

                                        nombreapellidopuntaje[x, 0] = nombreapellidopuntaje[x + 6, 0];
                                        nombreapellidopuntaje[x, 1] = nombreapellidopuntaje[x + 6, 1];
                                        nombreapellidopuntaje[x, 2] = nombreapellidopuntaje[x + 6, 2];
                                        nombreapellidopuntaje[x + 1, 0] = nombreapellidopuntaje[11, 0];
                                        nombreapellidopuntaje[x + 1, 1] = nombreapellidopuntaje[11, 1];
                                        nombreapellidopuntaje[x + 1, 2] = nombreapellidopuntaje[11, 2];
                                        nombreapellidopuntaje[x + 2, 0] = nombreapellidopuntaje[12, 0];
                                        nombreapellidopuntaje[x + 2, 1] = nombreapellidopuntaje[12, 1];
                                        nombreapellidopuntaje[x + 2, 2] = nombreapellidopuntaje[12, 2];
                                        nombreapellidopuntaje[x + 3, 0] = nombreapellidopuntaje[13, 0];
                                        nombreapellidopuntaje[x + 3, 1] = nombreapellidopuntaje[13, 1];
                                        nombreapellidopuntaje[x + 3, 2] = nombreapellidopuntaje[13, 2];
                                        nombreapellidopuntaje[x + 4, 0] = nombreapellidopuntaje[14, 0];
                                        nombreapellidopuntaje[x + 4, 1] = nombreapellidopuntaje[14, 1];
                                        nombreapellidopuntaje[x + 4, 2] = nombreapellidopuntaje[14, 2];
                                        nombreapellidopuntaje[x + 5, 0] = nombreapellidopuntaje[15, 0];
                                        nombreapellidopuntaje[x + 5, 1] = nombreapellidopuntaje[15, 1];
                                        nombreapellidopuntaje[x + 5, 2] = nombreapellidopuntaje[15, 2];
                                        nombreapellidopuntaje[x + 6, 0] = nombreapellidopuntaje[16, 0];
                                        nombreapellidopuntaje[x + 6, 1] = nombreapellidopuntaje[16, 1];
                                        nombreapellidopuntaje[x + 6, 2] = nombreapellidopuntaje[16, 2];


                                        nombreapellidopuntaje[11, 0] = "";
                                        nombreapellidopuntaje[11, 1] = "";
                                        nombreapellidopuntaje[11, 2] = "";
                                        nombreapellidopuntaje[12, 0] = "";
                                        nombreapellidopuntaje[12, 1] = "";
                                        nombreapellidopuntaje[12, 2] = "";
                                        nombreapellidopuntaje[13, 0] = "";
                                        nombreapellidopuntaje[13, 1] = "";
                                        nombreapellidopuntaje[13, 2] = "";
                                        nombreapellidopuntaje[14, 0] = "";
                                        nombreapellidopuntaje[14, 1] = "";
                                        nombreapellidopuntaje[14, 2] = "";
                                        nombreapellidopuntaje[15, 0] = "";
                                        nombreapellidopuntaje[15, 1] = "";
                                        nombreapellidopuntaje[15, 2] = "";
                                        nombreapellidopuntaje[16, 0] = "";
                                        nombreapellidopuntaje[16, 1] = "";
                                        nombreapellidopuntaje[16, 2] = "";

                                        puntajes[11] = puntajes[x];
                                        puntajes[12] = puntajes[x + 1];
                                        puntajes[13] = puntajes[x + 2];
                                        puntajes[14] = puntajes[x + 3];
                                        puntajes[15] = puntajes[x + 4];
                                        puntajes[16] = puntajes[x + 5];

                                        puntajes[x] = puntajes[x + 6];
                                        puntajes[x + 1] = puntajes[11];
                                        puntajes[x + 2] = puntajes[12];
                                        puntajes[x + 3] = puntajes[13];
                                        puntajes[x + 4] = puntajes[14];
                                        puntajes[x + 5] = puntajes[15];
                                        puntajes[x + 6] = puntajes[16];

                                        puntajes[11] = 0;
                                        puntajes[12] = 0;
                                        puntajes[13] = 0;
                                        puntajes[14] = 0;
                                        puntajes[15] = 0;
                                        puntajes[16] = 0;

                                        cambio = true;
                                        x = 0;
                                        x = x + 6;
                                    }
                                }
                                else if (puntajes[x] < puntajes[x + 5])
                                {
                                    nombreapellidopuntaje[11, 0] = nombreapellidopuntaje[x, 0];
                                    nombreapellidopuntaje[11, 1] = nombreapellidopuntaje[x, 1];
                                    nombreapellidopuntaje[11, 2] = nombreapellidopuntaje[x, 2];
                                    nombreapellidopuntaje[12, 0] = nombreapellidopuntaje[x + 1, 0];
                                    nombreapellidopuntaje[12, 1] = nombreapellidopuntaje[x + 1, 1];
                                    nombreapellidopuntaje[12, 2] = nombreapellidopuntaje[x + 1, 2];
                                    nombreapellidopuntaje[13, 0] = nombreapellidopuntaje[x + 2, 0];
                                    nombreapellidopuntaje[13, 1] = nombreapellidopuntaje[x + 2, 1];
                                    nombreapellidopuntaje[13, 2] = nombreapellidopuntaje[x + 2, 2];
                                    nombreapellidopuntaje[14, 0] = nombreapellidopuntaje[x + 3, 0];
                                    nombreapellidopuntaje[14, 1] = nombreapellidopuntaje[x + 3, 1];
                                    nombreapellidopuntaje[14, 2] = nombreapellidopuntaje[x + 3, 2];
                                    nombreapellidopuntaje[15, 0] = nombreapellidopuntaje[x + 4, 0];
                                    nombreapellidopuntaje[15, 1] = nombreapellidopuntaje[x + 4, 1];
                                    nombreapellidopuntaje[15, 2] = nombreapellidopuntaje[x + 4, 2];

                                    nombreapellidopuntaje[x, 0] = nombreapellidopuntaje[x + 5, 0];
                                    nombreapellidopuntaje[x, 1] = nombreapellidopuntaje[x + 5, 1];
                                    nombreapellidopuntaje[x, 2] = nombreapellidopuntaje[x + 5, 2];
                                    nombreapellidopuntaje[x + 1, 0] = nombreapellidopuntaje[11, 0];
                                    nombreapellidopuntaje[x + 1, 1] = nombreapellidopuntaje[11, 1];
                                    nombreapellidopuntaje[x + 1, 2] = nombreapellidopuntaje[11, 2];
                                    nombreapellidopuntaje[x + 2, 0] = nombreapellidopuntaje[12, 0];
                                    nombreapellidopuntaje[x + 2, 1] = nombreapellidopuntaje[12, 1];
                                    nombreapellidopuntaje[x + 2, 2] = nombreapellidopuntaje[12, 2];
                                    nombreapellidopuntaje[x + 3, 0] = nombreapellidopuntaje[13, 0];
                                    nombreapellidopuntaje[x + 3, 1] = nombreapellidopuntaje[13, 1];
                                    nombreapellidopuntaje[x + 3, 2] = nombreapellidopuntaje[13, 2];
                                    nombreapellidopuntaje[x + 4, 0] = nombreapellidopuntaje[14, 0];
                                    nombreapellidopuntaje[x + 4, 1] = nombreapellidopuntaje[14, 1];
                                    nombreapellidopuntaje[x + 4, 2] = nombreapellidopuntaje[14, 2];
                                    nombreapellidopuntaje[x + 5, 0] = nombreapellidopuntaje[15, 0];
                                    nombreapellidopuntaje[x + 5, 1] = nombreapellidopuntaje[15, 1];
                                    nombreapellidopuntaje[x + 5, 2] = nombreapellidopuntaje[15, 2];


                                    nombreapellidopuntaje[11, 0] = "";
                                    nombreapellidopuntaje[11, 1] = "";
                                    nombreapellidopuntaje[11, 2] = "";
                                    nombreapellidopuntaje[12, 0] = "";
                                    nombreapellidopuntaje[12, 1] = "";
                                    nombreapellidopuntaje[12, 2] = "";
                                    nombreapellidopuntaje[13, 0] = "";
                                    nombreapellidopuntaje[13, 1] = "";
                                    nombreapellidopuntaje[13, 2] = "";
                                    nombreapellidopuntaje[14, 0] = "";
                                    nombreapellidopuntaje[14, 1] = "";
                                    nombreapellidopuntaje[14, 2] = "";
                                    nombreapellidopuntaje[15, 0] = "";
                                    nombreapellidopuntaje[15, 1] = "";
                                    nombreapellidopuntaje[15, 2] = "";

                                    puntajes[11] = puntajes[x];
                                    puntajes[12] = puntajes[x + 1];
                                    puntajes[13] = puntajes[x + 2];
                                    puntajes[14] = puntajes[x + 3];
                                    puntajes[15] = puntajes[x + 4];

                                    puntajes[x] = puntajes[x + 5];
                                    puntajes[x + 1] = puntajes[11];
                                    puntajes[x + 2] = puntajes[12];
                                    puntajes[x + 3] = puntajes[13];
                                    puntajes[x + 4] = puntajes[14];
                                    puntajes[x + 5] = puntajes[15];

                                    puntajes[11] = 0;
                                    puntajes[12] = 0;
                                    puntajes[13] = 0;
                                    puntajes[14] = 0;
                                    puntajes[15] = 0;

                                    cambio = true;
                                    x = 0;
                                    x = x + 5;
                                }
                            }
                            else if (puntajes[x] < puntajes[x + 4])
                            {
                                nombreapellidopuntaje[11, 0] = nombreapellidopuntaje[x, 0];
                                nombreapellidopuntaje[11, 1] = nombreapellidopuntaje[x, 1];
                                nombreapellidopuntaje[11, 2] = nombreapellidopuntaje[x, 2];
                                nombreapellidopuntaje[12, 0] = nombreapellidopuntaje[x + 1, 0];
                                nombreapellidopuntaje[12, 1] = nombreapellidopuntaje[x + 1, 1];
                                nombreapellidopuntaje[12, 2] = nombreapellidopuntaje[x + 1, 2];
                                nombreapellidopuntaje[13, 0] = nombreapellidopuntaje[x + 2, 0];
                                nombreapellidopuntaje[13, 1] = nombreapellidopuntaje[x + 2, 1];
                                nombreapellidopuntaje[13, 2] = nombreapellidopuntaje[x + 2, 2];
                                nombreapellidopuntaje[14, 0] = nombreapellidopuntaje[x + 3, 0];
                                nombreapellidopuntaje[14, 1] = nombreapellidopuntaje[x + 3, 1];
                                nombreapellidopuntaje[14, 2] = nombreapellidopuntaje[x + 3, 2];

                                nombreapellidopuntaje[x, 0] = nombreapellidopuntaje[x + 4, 0];
                                nombreapellidopuntaje[x, 1] = nombreapellidopuntaje[x + 4, 1];
                                nombreapellidopuntaje[x, 2] = nombreapellidopuntaje[x + 4, 2];
                                nombreapellidopuntaje[x + 1, 0] = nombreapellidopuntaje[11, 0];
                                nombreapellidopuntaje[x + 1, 1] = nombreapellidopuntaje[11, 1];
                                nombreapellidopuntaje[x + 1, 2] = nombreapellidopuntaje[11, 2];
                                nombreapellidopuntaje[x + 2, 0] = nombreapellidopuntaje[12, 0];
                                nombreapellidopuntaje[x + 2, 1] = nombreapellidopuntaje[12, 1];
                                nombreapellidopuntaje[x + 2, 2] = nombreapellidopuntaje[12, 2];
                                nombreapellidopuntaje[x + 3, 0] = nombreapellidopuntaje[13, 0];
                                nombreapellidopuntaje[x + 3, 1] = nombreapellidopuntaje[13, 1];
                                nombreapellidopuntaje[x + 3, 2] = nombreapellidopuntaje[13, 2];
                                nombreapellidopuntaje[x + 4, 0] = nombreapellidopuntaje[14, 0];
                                nombreapellidopuntaje[x + 4, 1] = nombreapellidopuntaje[14, 1];
                                nombreapellidopuntaje[x + 4, 2] = nombreapellidopuntaje[14, 2];

                                nombreapellidopuntaje[11, 0] = "";
                                nombreapellidopuntaje[11, 1] = "";
                                nombreapellidopuntaje[11, 2] = "";
                                nombreapellidopuntaje[12, 0] = "";
                                nombreapellidopuntaje[12, 1] = "";
                                nombreapellidopuntaje[12, 2] = "";
                                nombreapellidopuntaje[13, 0] = "";
                                nombreapellidopuntaje[13, 1] = "";
                                nombreapellidopuntaje[13, 2] = "";
                                nombreapellidopuntaje[14, 0] = "";
                                nombreapellidopuntaje[14, 1] = "";
                                nombreapellidopuntaje[14, 2] = "";

                                puntajes[11] = puntajes[x];
                                puntajes[12] = puntajes[x + 1];
                                puntajes[13] = puntajes[x + 2];
                                puntajes[14] = puntajes[x + 3];

                                puntajes[x] = puntajes[x + 4];
                                puntajes[x + 1] = puntajes[11];
                                puntajes[x + 2] = puntajes[12];
                                puntajes[x + 3] = puntajes[13];
                                puntajes[x + 4] = puntajes[14];

                                puntajes[11] = 0;
                                puntajes[12] = 0;
                                puntajes[13] = 0;
                                puntajes[14] = 0;

                                cambio = true;
                                x = 0;
                                x = x + 4;
                            }
                        }
                        else if (puntajes[x] < puntajes[x + 3])
                        {
                            nombreapellidopuntaje[11, 0] = nombreapellidopuntaje[x, 0];
                            nombreapellidopuntaje[11, 1] = nombreapellidopuntaje[x, 1];
                            nombreapellidopuntaje[11, 2] = nombreapellidopuntaje[x, 2];
                            nombreapellidopuntaje[12, 0] = nombreapellidopuntaje[x + 1, 0];
                            nombreapellidopuntaje[12, 1] = nombreapellidopuntaje[x + 1, 1];
                            nombreapellidopuntaje[12, 2] = nombreapellidopuntaje[x + 1, 2];
                            nombreapellidopuntaje[13, 0] = nombreapellidopuntaje[x + 2, 0];
                            nombreapellidopuntaje[13, 1] = nombreapellidopuntaje[x + 2, 1];
                            nombreapellidopuntaje[13, 2] = nombreapellidopuntaje[x + 2, 2];

                            nombreapellidopuntaje[x, 0] = nombreapellidopuntaje[x + 3, 0];
                            nombreapellidopuntaje[x, 1] = nombreapellidopuntaje[x + 3, 1];
                            nombreapellidopuntaje[x, 2] = nombreapellidopuntaje[x + 3, 2];
                            nombreapellidopuntaje[x + 1, 0] = nombreapellidopuntaje[11, 0];
                            nombreapellidopuntaje[x + 1, 1] = nombreapellidopuntaje[11, 1];
                            nombreapellidopuntaje[x + 1, 2] = nombreapellidopuntaje[11, 2];
                            nombreapellidopuntaje[x + 2, 0] = nombreapellidopuntaje[12, 0];
                            nombreapellidopuntaje[x + 2, 1] = nombreapellidopuntaje[12, 1];
                            nombreapellidopuntaje[x + 2, 2] = nombreapellidopuntaje[12, 2];

                            nombreapellidopuntaje[x + 3, 0] = nombreapellidopuntaje[13, 0];
                            nombreapellidopuntaje[x + 3, 1] = nombreapellidopuntaje[13, 1];
                            nombreapellidopuntaje[x + 3, 2] = nombreapellidopuntaje[13, 2];

                            nombreapellidopuntaje[11, 0] = "";
                            nombreapellidopuntaje[11, 1] = "";
                            nombreapellidopuntaje[11, 2] = "";
                            nombreapellidopuntaje[12, 0] = "";
                            nombreapellidopuntaje[12, 1] = "";
                            nombreapellidopuntaje[12, 2] = "";
                            nombreapellidopuntaje[13, 0] = "";
                            nombreapellidopuntaje[13, 1] = "";
                            nombreapellidopuntaje[13, 2] = "";

                            puntajes[11] = puntajes[x];
                            puntajes[12] = puntajes[x + 1];
                            puntajes[13] = puntajes[x + 2];

                            puntajes[x] = puntajes[x + 3];
                            puntajes[x + 1] = puntajes[11];
                            puntajes[x + 2] = puntajes[12];

                            puntajes[x + 3] = puntajes[13];

                            puntajes[11] = 0;
                            puntajes[12] = 0;
                            puntajes[13] = 0;

                            cambio = true;
                            x = 0;
                            x = x + 3;
                        }
                    }
                    else if (puntajes[x] < puntajes[x + 2])
                    {
                        nombreapellidopuntaje[11, 0] = nombreapellidopuntaje[x, 0];
                        nombreapellidopuntaje[11, 1] = nombreapellidopuntaje[x, 1];
                        nombreapellidopuntaje[11, 2] = nombreapellidopuntaje[x, 2];
                        nombreapellidopuntaje[12, 0] = nombreapellidopuntaje[x + 1, 0];
                        nombreapellidopuntaje[12, 1] = nombreapellidopuntaje[x + 1, 1];
                        nombreapellidopuntaje[12, 2] = nombreapellidopuntaje[x + 1, 2];

                        nombreapellidopuntaje[x, 0] = nombreapellidopuntaje[x + 2, 0];
                        nombreapellidopuntaje[x, 1] = nombreapellidopuntaje[x + 2, 1];
                        nombreapellidopuntaje[x, 2] = nombreapellidopuntaje[x + 2, 2];
                        nombreapellidopuntaje[x + 1, 0] = nombreapellidopuntaje[11, 0];
                        nombreapellidopuntaje[x + 1, 1] = nombreapellidopuntaje[11, 1];
                        nombreapellidopuntaje[x + 1, 2] = nombreapellidopuntaje[11, 2];

                        nombreapellidopuntaje[x + 2, 0] = nombreapellidopuntaje[12, 0];
                        nombreapellidopuntaje[x + 2, 1] = nombreapellidopuntaje[12, 1];
                        nombreapellidopuntaje[x + 2, 2] = nombreapellidopuntaje[12, 2];

                        nombreapellidopuntaje[11, 0] = "";
                        nombreapellidopuntaje[11, 1] = "";
                        nombreapellidopuntaje[11, 2] = "";
                        nombreapellidopuntaje[12, 0] = "";
                        nombreapellidopuntaje[12, 1] = "";
                        nombreapellidopuntaje[12, 2] = "";

                        puntajes[11] = puntajes[x];
                        puntajes[12] = puntajes[x + 1];

                        puntajes[x] = puntajes[x + 2];
                        puntajes[x + 1] = puntajes[11];

                        puntajes[x + 2] = puntajes[12];

                        puntajes[11] = 0;
                        puntajes[12] = 0;

                        cambio = true;
                        x = 0;
                        x = x + 2;
                    }
                }
                else if (puntajes[x] < puntajes[x + 1])
                {
                    nombreapellidopuntaje[11, 0] = nombreapellidopuntaje[x, 0];
                    nombreapellidopuntaje[11, 1] = nombreapellidopuntaje[x, 1];
                    nombreapellidopuntaje[11, 2] = nombreapellidopuntaje[x, 2];

                    nombreapellidopuntaje[x, 0] = nombreapellidopuntaje[x + 1, 0];
                    nombreapellidopuntaje[x, 1] = nombreapellidopuntaje[x + 1, 1];
                    nombreapellidopuntaje[x, 2] = nombreapellidopuntaje[x + 1, 2];

                    nombreapellidopuntaje[x + 1, 0] = nombreapellidopuntaje[11, 0];
                    nombreapellidopuntaje[x + 1, 1] = nombreapellidopuntaje[11, 1];
                    nombreapellidopuntaje[x + 1, 2] = nombreapellidopuntaje[11, 2];

                    nombreapellidopuntaje[11, 0] = "";
                    nombreapellidopuntaje[11, 1] = "";
                    nombreapellidopuntaje[11, 2] = "";

                    puntajes[11] = puntajes[x];

                    puntajes[x] = puntajes[x + 1];

                    puntajes[x + 1] = puntajes[11];

                    puntajes[11] = 0;

                    cambio = true;
                    x = 0;
                    x++;
                }
            }
        }
        public void print()
        {
            Console.WriteLine();
            Console.WriteLine(nombreapellidopuntaje[0, 0]);
            Console.WriteLine(nombreapellidopuntaje[0, 1]);
            Console.WriteLine(nombreapellidopuntaje[0, 2]);
            Console.WriteLine();
            Console.WriteLine(nombreapellidopuntaje[1, 0]);
            Console.WriteLine(nombreapellidopuntaje[1, 1]);
            Console.WriteLine(nombreapellidopuntaje[1, 2]);
            Console.WriteLine();
            Console.WriteLine(nombreapellidopuntaje[2, 0]);
            Console.WriteLine(nombreapellidopuntaje[2, 1]);
            Console.WriteLine(nombreapellidopuntaje[2, 2]);
            Console.WriteLine();
            Console.WriteLine(nombreapellidopuntaje[3, 0]);
            Console.WriteLine(nombreapellidopuntaje[3, 1]);
            Console.WriteLine(nombreapellidopuntaje[3, 2]);
            Console.WriteLine();
            Console.WriteLine(nombreapellidopuntaje[4, 0]);
            Console.WriteLine(nombreapellidopuntaje[4, 1]);
            Console.WriteLine(nombreapellidopuntaje[4, 2]);
            Console.WriteLine();
            Console.WriteLine(nombreapellidopuntaje[5, 0]);
            Console.WriteLine(nombreapellidopuntaje[5, 1]);
            Console.WriteLine(nombreapellidopuntaje[5, 2]);
            Console.WriteLine();
            Console.WriteLine(nombreapellidopuntaje[6, 0]);
            Console.WriteLine(nombreapellidopuntaje[6, 1]);
            Console.WriteLine(nombreapellidopuntaje[6, 2]);
            Console.WriteLine();
            Console.WriteLine(nombreapellidopuntaje[7, 0]);
            Console.WriteLine(nombreapellidopuntaje[7, 1]);
            Console.WriteLine(nombreapellidopuntaje[7, 2]);
            Console.WriteLine();
            Console.WriteLine(nombreapellidopuntaje[8, 0]);
            Console.WriteLine(nombreapellidopuntaje[8, 1]);
            Console.WriteLine(nombreapellidopuntaje[8, 2]);
            Console.WriteLine();
            Console.WriteLine(nombreapellidopuntaje[9, 0]);
            Console.WriteLine(nombreapellidopuntaje[9, 1]);
            Console.WriteLine(nombreapellidopuntaje[9, 2]);
            Console.WriteLine();

            Console.WriteLine(Convert.ToString(puntajes[0]));
            Console.WriteLine(Convert.ToString(puntajes[1]));
            Console.WriteLine(Convert.ToString(puntajes[2]));
            Console.WriteLine(Convert.ToString(puntajes[3]));
            Console.WriteLine(Convert.ToString(puntajes[4]));
            Console.WriteLine(Convert.ToString(puntajes[5]));
            Console.WriteLine(Convert.ToString(puntajes[6]));
            Console.WriteLine(Convert.ToString(puntajes[7]));
            Console.WriteLine(Convert.ToString(puntajes[8]));
            Console.WriteLine(Convert.ToString(puntajes[9]));

            Console.WriteLine(Convert.ToString(puntajes[11]));
            Console.WriteLine(Convert.ToString(puntajes[12]));
            Console.WriteLine(Convert.ToString(puntajes[13]));
            Console.WriteLine(Convert.ToString(puntajes[14]));
            Console.WriteLine(Convert.ToString(puntajes[15]));
            Console.WriteLine(Convert.ToString(puntajes[16]));
            Console.WriteLine(Convert.ToString(puntajes[17]));
            Console.WriteLine(Convert.ToString(puntajes[18]));
            Console.WriteLine(Convert.ToString(puntajes[19]));


        }
    }
}
