using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testesQualific
{
    

    internal class Program
    {
       

        static string[,] ex1 = new string[7, 2] { { "A", "B" }, { "A", "C" }, { "B", "G" }, { "C", "H" }, { "E", "F" }, { "B", "D" }, { "C", "E" } };
        static string[,] ex2 = new string[6, 2] { { "B", "D" }, { "D", "E" }, { "A", "B" }, { "C", "F" }, { "E", "G" }, { "A", "C" }};
        static string[,] ex3 = new string[4, 2] { { "A", "B" }, { "A", "C" }, { "B", "D" }, { "D", "C" } };

        static List<List<Char>> l1 = new List<List<Char>>()
            {
                new List<Char>(){'A','B'},
                new List<Char>(){'A','C'},
                new List<Char>(){'B','G'},
                new List<Char>(){'C','H'},
                new List<Char>(){'E','F'},
                new List<Char>(){'B','D'},
                new List<Char>(){'C','E'}
            };

        static List<List<Char>> l2 = new List<List<Char>>()
            {
                new List<Char>(){ 'B', 'D' }, 
                new List<Char>(){ 'D', 'E' }, 
                new List<Char>(){ 'A', 'B' }, 
                new List<Char>(){ 'C', 'F' }, 
                new List<Char>(){ 'E', 'G' },
                new List<Char>(){ 'A', 'C' }
            };

        static List<List<Char>> l3 = new List<List<Char>>()
            {
                new List<Char>(){ 'A', 'B' }, 
                new List<Char>(){ 'A', 'C' }, 
                new List<Char>(){ 'B', 'D' },
                new List<Char>(){ 'D', 'C' }
            };

        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando");
            Console.WriteLine("");
            Console.WriteLine("Monta exemplo 1");
            CriaArvore ca1 = new CriaArvore(l1);
            ca1.imprime();
            Console.WriteLine("===== Fim =====");

            Console.WriteLine("Monta exemplo 2");
            CriaArvore ca2 = new CriaArvore(l2);
            ca2.imprime();
            Console.WriteLine("===== Fim =====");

            Console.WriteLine("Monta exemplo 3");
            CriaArvore ca3 = new CriaArvore(l3);
            ca3.imprime();
            Console.WriteLine("===== Fim =====");





            Console.Read();
        }

        
    }


    

    
    




}
