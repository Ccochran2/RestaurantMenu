using System;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

public class Menu
{
    public class MenuItem
    {
        private string itemName { get; set; }
        private string description { get; set; }
        private string category { get; set; }
        private int price { get; set; }
        private bool isNew { get; set; }

        public MenuItem(string ItemName, string Description, string Category, int Price, bool IsNew)
        {
            itemName = ItemName;
            description = Description;
            category = Category;
            price = Price;
            isNew = IsNew;
        }



        static void Main()
        {
            int Active = 1;

            MenuItem Item1 = new MenuItem("Steak", "8oz ribeye steak that's cooked to your preference.", "Main Course", 25, false);
            MenuItem Item2 = new MenuItem("Nachos", "A platter of nachos coated in melted 3 blend cheese.", "Appetizer", 15, false);
            MenuItem Item3 = new MenuItem("Cheesecake", "A slice of cheesecake made in-house just for you.", "Dessert", 20, true);

            while (Active != 0)
            {

                Console.WriteLine("Welcome! Here are our three most popular items.\n");
                Console.WriteLine($"{Item1.itemName}: {Item1.description} {Item1.category}. ${Item1.price}");
                Console.WriteLine($"{Item2.itemName}: {Item2.description} {Item2.category}. ${Item2.price}");
                Console.WriteLine($"{Item3.itemName}: {Item3.description} {Item3.category}. ${Item3.price}");

                Console.WriteLine("\nWould you like to change any of these options? Y/N");
                string changeOptions = Console.ReadLine()!;
                changeOptions = changeOptions.ToLower();

                while (changeOptions != "y" && changeOptions != "n")
                {
                    Console.WriteLine("Type Y if you want to change options or N to exit the program.");
                    changeOptions = Console.ReadLine()!;
                    changeOptions = changeOptions.ToLower();
                }

                if (changeOptions == "n") 
                { 
                    return; 
                }
                else if (changeOptions == "y")
                {
                    Console.WriteLine("Which menu item would you like to change?");
                    string OptionToChange = Console.ReadLine()!;
                    OptionToChange = OptionToChange.ToLower();

                    while (OptionToChange != "steak" && OptionToChange != "nachos" && OptionToChange != "cheesecake")
                    {
                        Console.WriteLine("That's not one of the existing menu options! They are Steak, Nachos, and Cheesecake.\nType in one of those options to change them.");
                        OptionToChange = Console.ReadLine()!;
                        OptionToChange = OptionToChange.ToLower();
                    }

                    

                    switch (OptionToChange)
                    {
                    

                        case "steak":
                            Console.WriteLine("What's the name of the dish?");
                            string newName = Console.ReadLine()!;
                            

                            Console.WriteLine("How would you describe it?");
                            string newDescription = Console.ReadLine()!;

                            Console.WriteLine("Is it a main course, an appetizer, or a dessert?");
                            string newCategory = Console.ReadLine()!;

                            Console.WriteLine("How much does it cost?");
                            string newPriceInput = Console.ReadLine();
                            while (int.TryParse(newPriceInput, out int newPriceBool) != true)
                            {
                                Console.WriteLine("The price has to be a number. Type in digits.");
                                newPriceInput = Console.ReadLine();
                            }
                            int newPrice = int.Parse(newPriceInput);
                            
                            Console.WriteLine("Is this item new? Y/N");
                            string IsNew = Console.ReadLine()!;
                            IsNew = IsNew.ToLower();

                            while (IsNew != "y" && IsNew != "n") { 
                            Console.WriteLine("Type Y or N only.");
                            IsNew = Console.ReadLine()!;
                            IsNew = IsNew.ToLower()!;
                            }
                            bool isNew = true;

                            if (IsNew == "y")
                            {
                                isNew = true;
                            } else if (IsNew == "n")
                            {
                                isNew = false;
                            } else { return; }
                            Item1.itemName = newName;
                            Item1.description = newDescription;
                            Item1.category = newCategory;
                            Item1.price = newPrice;
                            Item1.isNew = isNew;
                            break;

                        case "nachos":
                            Console.WriteLine("What's the name of the dish?");
                            newName = Console.ReadLine()!;

                            Console.WriteLine("How would you describe it?");
                            newDescription = Console.ReadLine()!;

                            Console.WriteLine("Is it a main course, an appetizer, or a dessert?");
                            newCategory = Console.ReadLine()!;

                            Console.WriteLine("How much does it cost?");
                            newPriceInput = Console.ReadLine();
                            while (int.TryParse(newPriceInput, out newPrice) != true)
                            {
                                Console.WriteLine("The price has to be a number. Type in digits.");
                                newPriceInput = Console.ReadLine();
                            }
                            Console.WriteLine("Is this item new? Y/N");
                            IsNew = Console.ReadLine()!;
                            IsNew = IsNew.ToLower();

                            while (IsNew != "y" && IsNew != "n")
                            {
                                Console.WriteLine("Type Y or N only.");
                                IsNew = Console.ReadLine()!;
                                IsNew = IsNew.ToLower()!;
                            }
                            isNew = true;

                            if (IsNew == "y")
                            {
                                isNew = true;
                            }
                            else if (IsNew == "n")
                            {
                                isNew = false;
                            }
                            else { return; }
                            Item2.itemName = newName;
                            Item2.description = newDescription;
                            Item2.category = newCategory;
                            Item2.price = newPrice;
                            Item2.isNew = isNew;
                            break;

                        case "cheesecake":
                            Console.WriteLine("What's the name of the dish?");
                            newName = Console.ReadLine()!;

                            Console.WriteLine("How would you describe it?");
                            newDescription = Console.ReadLine()!;

                            Console.WriteLine("Is it a main course, an appetizer, or a dessert?");
                            newCategory = Console.ReadLine()!;

                            Console.WriteLine("How much does it cost?");
                            newPriceInput = Console.ReadLine();
                            while (int.TryParse(newPriceInput, out newPrice) != true)
                            {
                                Console.WriteLine("The price has to be a number. Type in digits.");
                                newPriceInput = Console.ReadLine();
                            }
                            Console.WriteLine("Is this item new? Y/N");
                            IsNew = Console.ReadLine()!;
                            IsNew = IsNew.ToLower();

                            while (IsNew != "y" && IsNew != "n")
                            {
                                Console.WriteLine("Type Y or N only.");
                                IsNew = Console.ReadLine()!;
                                IsNew = IsNew.ToLower()!;
                            }
                            isNew = true;

                            if (IsNew == "y")
                            {
                                isNew = true;
                            }
                            else if (IsNew == "n")
                            {
                                isNew = false;
                            }
                            else { return; }
                            Item3.itemName = newName;
                            Item3.description = newDescription;
                            Item3.category = newCategory;
                            Item3.price = newPrice;
                            Item3.isNew = isNew;

                            break;

                    }


                }
            }
        }
    }
}