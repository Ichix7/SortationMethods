using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_Winden
{
    class Program
    {
        static void Main(string[] args)
        {

            //Question 1 - Completed below
            //Question 2 - Completed below
            //Question 3 - I could print the array backwards. or make the algorithum compare it backwards 
            //start at the last cell and work you ways back to 0
            //Question 4 - Completed below, shows after every algorithum is complete
            //Question 5 c/d - Completed, Turned in excel document
            //Question 5e- if im doing everything right then the best one to use would be selection since it 
            //has the smallest amounts of comparisons and swapping

            string answer = "";
            
            do
            {
                Console.Write("Hello Friends: Choose One: Selection (s), Bubble(b), Insertion(i), or Quit(q): ");
                answer = Console.ReadLine().ToUpper();
                Console.Write("How many numbers?: ");
                string num = Console.ReadLine();
                int choices = Convert.ToInt32(num);

                int[] numbers = new int[choices];
                Random random = new Random();

                int Comp = 0;
                int Swap = 0;

                for (int y = 0; y < choices; y++)
                {
                    int randomnum = random.Next(1, 100);
                    numbers[y] = randomnum;
                }
                if (answer == "B")
                {
                    #region Bubble

                    for (int i = 1; i < numbers.Length; i++)
                    {
                        for (int j = 0; j < numbers.Length - 1; j++)
                        {
                            Comp++;

                            if (numbers[j] > numbers[j + 1])
                            {
                                Swap++;
                                int temp = numbers[j + 1];
                                numbers[j + 1] = numbers[j];
                                numbers[j] = temp;
                            }
                        }
                    }
                    #endregion
                }
                if (answer == "S")
                {
                    #region Selection

                    for (int j = 0; j < numbers.Length - 1; j++)
                    {
                        Comp++;
                        int imin = j;

                        for (int i = j + 1; i < numbers.Length; i++)
                        {
                            if (numbers[i] < numbers[imin]) { imin = i; }

                        }
                        if (imin != j)
                        {
                            Swap++;
                            int temp = numbers[j];
                            numbers[j] = numbers[imin];
                            numbers[imin] = temp;
                        }
                    }

                    #endregion
                }
                if (answer == "I")
                {
                    #region Insertions

                    for (int j = 2; j < numbers.Length; j++)
                    {
                        int key = numbers[j];
                        int i = j - 1;
                        while (i > 0 && numbers[i] > key)
                        {
                            Comp++;
                            numbers[i + 1] = numbers[i];
                            i = i - 1;

                        }
                        Swap++;
                        numbers[i + 1] = key;
                    }

                    #endregion
                }
                for (int x = 0; x < numbers.Length; x++)
                {
                    Console.Write(" " + numbers[x]);
                }

                Console.WriteLine("\nCompared: {0}", Comp);
                Console.WriteLine("Swapped: {0}", Swap);
                Console.WriteLine("<Press Enter>");
                Console.ReadLine();
                Console.Clear();
                
            } while (answer != "Q"); 
            }
    }
}
