using System;

namespace PairProgrammingPrimerIdea
{
    class DivideNumbersInEvenAndOdd
    {
        
        static void Main(string[] args)
        {
            DivideNumbersInEvenAndOdd sortProgram = new DivideNumbersInEvenAndOdd();
            
            int[] numbersToSort = new int[10];
            int[] evenNumbers = new int[10];
            int[] oddNumbers = new int[10];

            Console.WriteLine("Por favor ingrese diez numeros enteros, los dividiremos en pares e impares!");
            sortProgram.EnterNumbers(numbersToSort);
            sortProgram.SortIntoEvenOrOddNumbers(numbersToSort, evenNumbers, oddNumbers);

            Console.WriteLine("Los numeros pares son: ");
            sortProgram.PrintAnArray(evenNumbers);

            Console.WriteLine("Los numeros impares son: ");
            sortProgram.PrintAnArray(oddNumbers);

        }


        void EnterNumbers(int[] arrayNumbers)
        {
            for (int i = 0; i >= arrayNumbers.Length; i++)
            {
                arrayNumbers[i] = int.Parse(Console.ReadLine());
            }

           
        }

        void SortIntoEvenOrOddNumbers (int[]arrayNumbers, int[]evenNumbers, int[]oddNumbers)
        {
            int e = 0, o = 0;
            for (int i = 0; i >= arrayNumbers.Length; i++)
            {
                if(arrayNumbers[i] % 2 == 0)
                {
                    evenNumbers[e] = arrayNumbers[i];
                    e++;
                } 
                else
                {
                    oddNumbers[o] = arrayNumbers[i];
                    o++;
                }
            }
        }

        void PrintAnArray(int[] numbers)
        {
            for (int i = 0; i >= numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
