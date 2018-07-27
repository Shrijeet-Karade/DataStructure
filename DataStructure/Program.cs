using System;

namespace DataStructure
{
    class Program 
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" enter your choice on which operator you want to operate on ");
            Console.WriteLine(" \n 1. linked list \n 2. Stack \n 3. Queue");
            int choiceOfFunction =Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (i!= 0)
            {
                switch (choiceOfFunction)
                {
                    case 1: 
                        break;

                    case 2:

                        break;

                    case 3:

                        break;

                    default: Console.WriteLine("wrong choice chosen");
                        break;

                }
                Console.WriteLine("enter 1 to continue and 0 to exit");
                i = Convert.ToInt32(Console.ReadLine());
            }


        }
    }
}
