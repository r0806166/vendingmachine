using System;
using System.IO;

Console.WriteLine("WELCOME TO YOUR FRIENDLY NEIGHBORHOOD VENDING MACHINE");
Console.WriteLine();


string  value;



do
{
    int selection;
    Console.WriteLine("Have a look on today's menu and make a selection");
    Console.WriteLine();
    Console.WriteLine("\n 1. Food \n 2. Water \n 3. Soda \n");
    selection = int.Parse(Console.ReadLine());


    switch (selection)
    {
        case 1:
            int selectionfood;
            string yesOrno;
            Console.WriteLine();
            Console.WriteLine(" \n You've selected the Food Menu, Please choose your meal: ");
            Console.WriteLine();
            Console.WriteLine(" \n 1. Burger \n 2. Panini \n 3. Sandwich \n 4. Hot-Dog \n 5. Pizza \n");
            selectionfood = int.Parse(Console.ReadLine());
            switch (selectionfood)
            {
                case 1:
                    Console.WriteLine("You have chosen for Burger");
                    Console.WriteLine("Price for a burger is 3.50");
                    Console.WriteLine("Proceed to the payement? (Y or N");
                    yesOrno = Console.ReadLine();
                    if (yesOrno == "Y")
                    {
                        Console.WriteLine("Thank You for your purchase!");
                    }

                    break;
                case 2:
                    Console.WriteLine("You have chosen for Panini");
                    Console.WriteLine("Price for a panini is 5.50");
                    Console.WriteLine("Proceed to the payement? (Y or N");
                    yesOrno = Console.ReadLine();
                    if (yesOrno == "Y")
                    {
                        Console.WriteLine("Thank You for your purchase!");
                    }
                    break;
                case 3:
                    Console.WriteLine("You have chosen for Sandwich");
                    Console.WriteLine("Price for a Sandwich is 1.50");
                    Console.WriteLine("Proceed to the payement? (Y or N");
                    yesOrno = Console.ReadLine();
                    if (yesOrno == "Y")
                    {
                        Console.WriteLine("Thank You for your purchase!");
                    }

                    break;
                case 4:
                    Console.WriteLine("You have chosen for Hot-Dog");
                    Console.WriteLine("Price for a hot-dog is 2.50");
                    Console.WriteLine("Proceed to the payement? (Y or N");
                    yesOrno = Console.ReadLine();
                    if (yesOrno == "Y")
                    {
                        Console.WriteLine("Thank You for your purchase!");
                    }

                    break;
                case 5:
                    Console.WriteLine("You have chosen for Pizza");
                    Console.WriteLine("Price for a pizza is 7.50");
                    Console.WriteLine("Proceed to the payement? (Y or N");
                    yesOrno = Console.ReadLine();
                    if (yesOrno == "Y")
                    {
                        Console.WriteLine("Thank You for your purchase!");
                    }

                    break;  
            }
            break;
        case 2:
            int selectionwater;
            Console.WriteLine();
            Console.WriteLine(" \n You've selected the Water Menu, Please choose your water: ");
            Console.WriteLine();
            Console.WriteLine(" \n 1. Burger \n 2. Panini \n 3. Sandwich \n 4. Hot-Dog \n 5. Pizza \n");
            selectionfood = int.Parse(Console.ReadLine());

            break;
        case 3:
            break;
        default:
            // code block
            break;
    }
    Console.ReadLine();
    Console.Write("Do you want to continue(y/n):");
    value = Console.ReadLine();
} while (value == "y" || value == "Y");