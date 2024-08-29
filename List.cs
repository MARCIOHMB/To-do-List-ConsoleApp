using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_do_List__ConsoleApp
{
    class List
    {
        string name;
        List<string> list = new List<string>();
        string option = "";


        public void Startup()
        {
            var continueloop = true;

            do
            {
                try
                {

                    Console.WriteLine("Please input your name");
                    name = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(name))
                        throw new Exception("Error! Name not provided");
                    Console.ReadLine();

                    if (name.Any(char.IsDigit))
                        throw new Exception("Error! Please use a real name");


                    continueloop = false;

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            } while (continueloop);



            Console.WriteLine("Hello " + name);
            Console.WriteLine("This is a to-do list application");


            CreateList();
        }

        public void CreateList()
        {

            var lp = true;
            do
            {
                try
                {
                    Console.WriteLine("---------------------------------------------------------------------------------");
                    Console.WriteLine("Below are the options available to work on the list: ");
                    Console.WriteLine("Enter 0 to exit application.");
                    Console.WriteLine("Enter 1 to add a task to the list.");
                    Console.WriteLine("Enter 2 to remove a task from the list.");
                    Console.WriteLine("Enter 3 to view the list.");
                    Console.WriteLine("Enter 4 to count how many values are in the list.");
                    Console.WriteLine("---------------------------------------------------------------------------------");
                    Console.WriteLine("Please enter a number for the action you want to iniate");



                    option = Console.ReadLine();

                    // Alternative to many else if statements
                    switch (option)
                    {
                        case "0":
                            Console.WriteLine("Do you want to exit the application (yes,no)");
                            string exit = Console.ReadLine();
                            if (exit.ToLower() == "yes")
                            {
                                Console.WriteLine("Thank you.\n Exiting appication.\n Have a good day.\n Goodbye!");
                                Environment.Exit(0);
                            }
                            else
                            {
                                Console.WriteLine("Continuing with the application");
                                Console.ReadLine();
                            }
                            break;

                        case "1":
                            Console.WriteLine("Please enter the task to add to the list");
                            string add = Console.ReadLine();
                            list.Add(add);
                            Console.WriteLine("Task has been added to the list");
                            Console.ReadLine();
                            break;

                        case "2":

                            for (int i = 0; i < list.Count; i++)
                            {
                                Console.WriteLine(i + " : " + list[i]);
                            }
                            Console.WriteLine("Please enter the # of the task you would like to remove from the list. ");
                            int tasknumber = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Task has been removed from the list");
                            list.RemoveAt(tasknumber);
                            Console.ReadLine();
                            break;

                        case "3":
                            Console.WriteLine("To DO List: ");
                            for (int i = 0; i < list.Count; i++)
                            {
                                string item = list[i];
                                Console.WriteLine("\t" + i + " - " + item);

                            }

                            break;

                        case "4":
                            Console.WriteLine($"# of items stored in the list:{list.Count}");
                            Console.ReadLine();
                            break;

                    }

                    while (true)
                    {
                        Console.WriteLine("Do you want to perform another action to the list? (yes/no)");
                        string rerun = Console.ReadLine();

                        if (rerun.ToLower() == "yes")
                        {
                            Console.WriteLine("Clearing the screen!");
                            Console.Clear();
                            break;

                        }
                        else if (rerun.ToLower() == "no")
                        {
                            lp = false;
                            Console.WriteLine();
                            Console.WriteLine(name);
                            break; // Exit the loop if the user says "no"
                        }
                        else if (string.IsNullOrWhiteSpace(rerun))
                        {
                            Console.WriteLine("Error! No value provided");
                            Console.WriteLine("Please type 'yes' or 'no'.");
                        }
                        else if (rerun.Any(char.IsDigit))
                        {
                            Console.WriteLine("Error! Please type 'yes' or 'no'");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input! Please type 'yes' or 'no'.");
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            } while (lp);

            Console.WriteLine("Thank you for using the list! ");

            Console.ReadLine();



        }

    }
}
