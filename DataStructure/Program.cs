using System;

namespace DataStructure
{
    class Program 
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" enter your choice on which operator you want to operate on ");
            Console.WriteLine(" \n 1. linked list \n 2. Stack \n 3. Queue");
            int choiceOfFunction = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            int x = 1;
            while (i == 1)
            {
                switch (choiceOfFunction)
                {
                    case 1: // inside 
                                 Interface1 objectLinkList = new LinkedList();
                         x = 1;
                        while (x == 1)
                        {

                            Console.WriteLine("enter your choice\n 1.add   2.remove   3.display  4.sort \n");
                            int choice = Convert.ToInt32(Console.ReadLine());
                            switch (choice)
                            {
                                case 1:
                                    Console.WriteLine("enter the number to entered");
                                    int val = Convert.ToInt32(Console.ReadLine());
                                            objectLinkList.AddNewElement(val);
                                    break;
                                case 2:
                                           objectLinkList.RemoveElement();
                                    break;
                                case 3: 
                                                
                                            objectLinkList.Display();
                                    break;
                                case 4:
                                            objectLinkList.Sort();    
                                    break;

                                default:    
                                            
                                    break;


                            }
                            Console.WriteLine("enter 1 and 0 to exit to continue working in queue");
                            x = Convert.ToInt32(Console.ReadLine());
                        }
                        break;

                    case 2:
                        Interface1 objectStack = new Stack();
                        x = 1;
                        while (x == 1)
                        {

                            Console.WriteLine("enter your choice\n 1.add   2.remove   3.display  4.sort \n");
                            int choice = Convert.ToInt32(Console.ReadLine());
                            switch (choice)
                            {
                                case 1:
                                    Console.WriteLine("enter the number to entered");
                                    int val = Convert.ToInt32(Console.ReadLine());
                                    objectStack.AddNewElement(val);
                                    break;
                                case 2:
                                    objectStack.RemoveElement();
                                    break;
                                case 3:
                                    objectStack.Display(); 
                                    break;
                                case 4:
                                    objectStack.Sort();
                                    break;

                                default:
                                    break;


                            }
                            Console.WriteLine("enter 1 to continue working in queue");
                            x = Convert.ToInt32(Console.ReadLine());
                        }

                        break;

                    case 3:

                        Interface1 objectQueue = new Queue();

                        Queue Object2Queue = new Queue();
                         x = 1;
                        while (x == 1)
                        {

                            Console.WriteLine("enter your choice\n 1.add   2.remove   3.display  4.sort \n");
                            int choice = Convert.ToInt32(Console.ReadLine());
                            switch (choice)
                            {
                                case 1:
                                    Console.WriteLine("enter the val");
                                    int val = Convert.ToInt32(Console.ReadLine());
                                    objectQueue.AddNewElement(val);
                                    break;

                                case 2:
                                    objectQueue.RemoveElement();
                                    break;

                                case 3:
                                    objectQueue.Display();
                                    break;

                                case 4:
                                    objectQueue.Sort();
                                    break;

                                default:
                                    break;


                            }
                            Console.WriteLine("enter 1 to continue working in queue");
                            x = Convert.ToInt32(Console.ReadLine());
                        }

                         break;

                     default:
                        Console.WriteLine("wrong choice chosen");
                        break;

                }
                Console.WriteLine("enter 1 to continue and 0 to exit");
                i = Convert.ToInt32(Console.ReadLine());
            }


        }
    }
}
