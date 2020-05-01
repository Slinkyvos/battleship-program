using System;

namespace Loopsproject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //for loop example
            for(int i=1;i<=10;i++)
            {
                if (i==5)
                {
                    //continue;
                    break;
                }
                
                Console.WriteLine("The number is " + i);
            }
            //while loop example
            int j = 1;//intialisation 
            while(j<=15)//condition
            {

                j++;//increment
                if (j == 5)
                {
                    continue;
                    j++;
                }
                Console.WriteLine("Number" + j);
            }
            //do while loop example
            int k = 1;
            do
            {
                Console.WriteLine("Number is " + k);
                k++;
            } while (k <= 20);

            //choices
            Console.WriteLine("choose one of the following options \n 1. Choose 1 for display again \n 2. choose 2 for exit");
            char ch =Char.Parse(Console.ReadLine());
            bool flag = false;
            while (ch != '2')
            {
                Console.WriteLine("choose one of the following options  \n 1. Choose 1 for display again \n 2. choose 2 for exit");
                char ch = Char.Parse(Console.ReadLine());
                if (ch=='2')
                {
                    Console.WriteLine("cya");
                    flag = true;
                }
            }
            // Array example
            int[] sID = new int[5];
            //name array
            string[] sName = new string[5];
            //writing array
            for (int count = 0; count <=sID.Length; count++)
            {
                Console.WriteLine("please enter student number " + count + 1);
                sID[count] = Int32.Parse(Console.ReadLine());
            }
            //reading array
            for (int count = 0; count <= sID.Length; count++)
            {
                Console.WriteLine("the student number at index " + count + " is " +sID[count]);
            }
            for (int count = 0; count <= sID.Length; count++)
            {
                Console.WriteLine("please enter student name " + count + 1);
                sID[count] = Int32.Parse(Console.ReadLine());
            }
            for (int count = 0; count <= sID.Length; count++)
            {
                Console.WriteLine("the student name at index " + count + " is " + sID[count]);
            }
        }
    }
}
