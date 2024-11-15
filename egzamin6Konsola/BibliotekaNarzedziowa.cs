﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace egzamin6Konsola
{
    /********************************************
         * klasa:       BibliotekaNarzedziowa
         * opis:        Klasa reprezentuje program z narzędziami dla typu string, oblicza liczbę samogłosek w podanym tekście oraz usuwa powtarzające się litery obok siebie
         * metody:      LiczSamogloski - zwraca licznik będący liczbą samoglosek w podanym tekscie
         *              UsunPowtorzenia - zwraca tekst z usunietymi powtorzonymi obok siebie literami
         * autor:       PESEL
    ********************************************/
    public static class BibliotekaNarzedziowa
    {
        public static int licznik = 0;
        public static string napisWyjsciowy = "";

        public static int LiczSamogloski(string tekst)
        {
            if (string.IsNullOrWhiteSpace(tekst))
            {
                return 0;
            }
            else
            {
                foreach (char c in tekst)
                {
                    if (c == 'a' || c == 'ą' || c == 'e' || c == 'ę' || c == 'i' || c == 'o' || c == 'u' || c == 'ó' || c == 'y' || c == 'A' || c == 'Ą' || c == 'E' || c == 'Ę' || c == 'I' || c == 'O' || c == 'U' || c == 'Ó' || c == 'Y')
                    {
                        licznik++;
                    }
                }
            }
            return licznik;
        }

        public static string UsunPowtorzenia(string tekst)
        {
            if (string.IsNullOrWhiteSpace(tekst))
            {
                return "";
            }
            else
            {
                foreach (char c in tekst)
                {
                    if (!napisWyjsciowy.EndsWith(c))
                    {
                        napisWyjsciowy += c;
                    }
                }
            }
            return napisWyjsciowy;
        }
    }
}
