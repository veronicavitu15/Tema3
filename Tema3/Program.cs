using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_3
{
    class Ex1
    {
        static void Main(string[] args)
        {
            double[] vector1 = new double[] { 3.4, 8.4, 9.1 };
            for (int i=0; i < vector1.Length; i++ )
            {
            Console.WriteLine("Element at index " + i + " : " + vector1[i]);
            }

            Console.ReadLine();
        }
    }

    class Ex2
    {
        static void Main(string[] args)
        {
            int[] numere = new int[] {9, 11, 70, 230, 698, 786, 4, 323, 122, 1000 };
            int min = numere[0]; 
            int max = numere[0];

            for (int i = 0; i < numere.Length; i++)
            {
                if (min > numere[i]) min = numere[i];
                if (max < numere[i]) max = numere[i];
            }
            Console.WriteLine("The minimum is: {0}", min);
            Console.WriteLine("The maximum is: {0}", max);

            Console.ReadLine();
        }
    }
    class Ex3
    {
        static void Main(string[] args)
        {
            int[] numere = new int[] { 58, 65, 10, -9 };

            Console.WriteLine("Pozitia numarului negativ este : ");
            for (int i = 0; i < numere.Length; i++)
            {
                if (numere[i] < 0)
                    Console.Write(i);
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
    class Ex4
    {
        static void Main(string[] args)
        {
            string enunt = "Bine ati venit !";
            char[] caractere = enunt.ToCharArray();
            foreach (char ch in caractere)
            { 
                Console.WriteLine(ch);
            }
                Console.ReadLine();
         
        }
    }
    class Ex5
    {
        static void Main(string[] args)
        {
            string enunt = "Bine ati venit";
            char[] vector = new char[enunt.Length];
            for (int i = 0; i < vector.Length; i++)
            {
                if (i % 2 == 0)
                    vector[i] = char.ToUpper(enunt[i]);
                else 
                    vector[i] = char.ToLower(enunt[i]);
            }
            
            Console.WriteLine(vector);
            Console.ReadLine();

        }
    }
    class Ex6
    {
        static void Main(string[] args)
        {
            int[] vector = new int[] { 58, 65, 10, 9 };
            double numar = 50.5;
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = vector [i] + (int)numar;  
            }
            for (int x = 0; x < vector.Length; x++)

            {
                Console.WriteLine(vector [x] + " ");
            }
                Console.ReadLine();

        }
    }
}
