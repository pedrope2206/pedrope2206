﻿using System;

namespace ArrayColection
{
    class Program
    {
        static void Main(string[] args)
        {
            //sintaxe do Array : Tiposdedados [] = new tiposdedados [tamanho];

            string[] alunosAMS = new string [6]{
          
            "Danieli",
            "Ana Julia",
            "Bruno",
            "Oberdan",
            "Sofia"
             "Pivettão"

            };  

            Console.WriteLine(alunosAMS[2]);

            foreach ( string alunos in alunosAMS)
            {
              Console.WriteLine(alunos);  
            }

            for (int i = 0; i < alunosAMS.Length; i++ )
            {
              Console.WriteLine(alunosAMS[i]);  
            } 



        }
    }
}
