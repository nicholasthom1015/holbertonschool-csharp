using System;
using InventoryLibrary;

namespace InventoryManager
{
    class Program
    {
        static JSONStorage jsonStorage;
        
        static void Main(string[] args)
        {
            jsonStorage = new JSONStorage("data.json");
            jsonStorage.Load();

            PrintPrompt();

            string input;
            while ((input = Console.ReadLine()) != null)
            {
                string[] command = input.ToLower().Split(' ');

                if (command[0] == "classnames")
                {
                    PrintClassNames();
                }
                else if (command[0] == "all")
                {
                    if (command.Length == 1)
                    {
                        PrintAllObjects();
                    }
                    else if (command.Length == 2)
                    {
                        string className = command[1];
                        PrintObjectsByClassName(className);
                    }
                    else
                    {
                        PrintInvalidCommand();
                    }
                }
                else if (command[0] == "create")
                {
                    if (command.Length == 2)
                    {
                        string className = command[1];
                        CreateObject(className);
                    }
                    else
                    {
                        PrintInvalidCommand();
                    }
                }
                else if (command[0] == "show")
                {
                    if (command.Length == 3)
                    {
                        string className = command[1];
                        string id = command[2];
                        ShowObject(className, id);
                    }
                    else
                    {
                        PrintInvalidCommand();
                    }
                }
                else if (command[0] == "update")
                {
                    if (command.Length == 3)
                    {
                        string className = command[1];
                        string id = command[2];
                        UpdateObject(className, id);
                    }
                    else
                    {
                        PrintInvalidCommand();
                    }
                }
                else if (command[0] == "delete")
                {
                    if (command.Length == 3)
                    {
                        string className = command[1];
                        string id = command[2];
                        DeleteObject(className, id);
                    }
                    else
                    {
                        PrintInvalidCommand();
                    }
                }
                else if (command[0] == "exit")
                {
                    break;
                }
                else
                {
                    PrintInvalidCommand();
                }

                PrintPrompt();
            }
        }

        static void PrintPrompt()
        {
            Console.WriteLine("\nInventory Manager");
            Console.WriteLine("-------------------------");
            Console.WriteLine("<ClassNames>\t\t\tShow all ClassNames of objects");
            Console.WriteLine("<All>\t\t\t\tShow all objects");
            Console.WriteLine("<All [ClassName]>\t\tShow all objects of a ClassName");
            Console.WriteLine("<Create [ClassName]>\t\tCreate a new object");
            Console.WriteLine("<Show [ClassName object_id]>\tShow an object");
            Console.WriteLine("<Update [ClassName object_id]>\tUpdate an object");
            Console.WriteLine("<Delete [ClassName object_id]>\tDelete an object");
            Console.WriteLine("<Exit>\t\t\t\tQuit the application");
        }

        static void PrintClassNames()
        {
            Console.WriteLine("\nClassNames:");
            foreach (var key in jsonStorage.All().Keys)
            {
                string className = key.Split('.')[0];
                Console.WriteLine(className);
            }
        }

        static void PrintAllObjects()
        {
            Console.WriteLine("\nAll objects:");
            foreach
        }
