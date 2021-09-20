using System;

namespace ArrayColection
{
    class Program
    {
        static void Main(string[] args)
        {
            //sintaxe do Array : Tiposdedados [] = new tiposdedados [tamanho];

            string[] alunosAMS = new string [5]{
          
            "Daniela",
            "Ana Julia",
            "Bruno",
            "Oberdan",
            "Sofia"

            };  

            Console.WriteLine(alunosAMS[2]);

            //alunosAMS[2] = "Pedro";

            Console.WriteLine($"Novo valor no index: {alunosAMS[2]}");

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
