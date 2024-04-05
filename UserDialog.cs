using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Uml2_Maybe
{
    public class UserDialog
    {
        static PizzaController PC = new PizzaController();
        static CustomerController CC = new CustomerController();
        static OrderController OC = new OrderController();


        int MenuchoiceMain(List<string> MenuChoices) 
        {
            Console.Clear();
            Console.WriteLine("--------------------");
            Console.WriteLine("| MAIN MENU |");
            Console.WriteLine("--------------------");
            Console.WriteLine();
            Console.WriteLine("Options:");
            foreach (string choice in MenuChoices)
            {
                Console.WriteLine(choice);
            }

            Console.Write("Enter option#: ");
            string input = Console.ReadKey().KeyChar.ToString();

            try
            {
                int result = Int32.Parse(input);
                return result;
            }

            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{input}'");
            }
            return -1;
        }
        int MenuchoiceCustomer(List<string> MenuChoices)
        {
            Console.Clear();
            Console.WriteLine("--------------------");
            Console.WriteLine("| MAIN MENU FOR CUSTOMER |");
            Console.WriteLine("--------------------");
            Console.WriteLine();
            Console.WriteLine("Options:");
            foreach (string choice in MenuChoices)
            {
                Console.WriteLine(choice);
            }

            Console.Write("Enter option#: ");
            string input = Console.ReadKey().KeyChar.ToString();

            try
            {
                int result = Int32.Parse(input);
                return result;
            }

            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{input}'");
            }
            return -1;
        }
        int MenuchoicePizza(List<string> MenuChoices)
        {
            Console.Clear();
            Console.WriteLine("--------------------");
            Console.WriteLine("| MAIN MENU FOR PIZZA |");
            Console.WriteLine("--------------------");
            Console.WriteLine();
            Console.WriteLine("Options:");
            foreach (string choice in MenuChoices)
            {
                Console.WriteLine(choice);
            }

            Console.Write("Enter option#: ");
            string input = Console.ReadKey().KeyChar.ToString();

            try
            {
                int result = Int32.Parse(input);
                return result;
            }

            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{input}'");
            }
            return -1;
        }
        int MenuchoiceOrder(List<string> MenuChoices)
        {
            Console.Clear();
            Console.WriteLine("--------------------");
            Console.WriteLine("| MAIN MENU FOR ORDER |");
            Console.WriteLine("--------------------");
            Console.WriteLine();
            Console.WriteLine("Options:");
            foreach (string choice in MenuChoices)
            {
                Console.WriteLine(choice);
            }

            Console.Write("Enter option#: ");
            string input = Console.ReadKey().KeyChar.ToString();

            try
            {
                int result = Int32.Parse(input);
                return result;
            }

            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{input}'");
            }
            return -1;
        }
        public void Start()
        {
            bool ProceedMain = true;
            List<string> MainMenu = new List<string>()
            {
                "1. Pizza menu",
                "2. Custuomer menu",
                "3. Order menu"

            };
            List<string> MainMenuCustomer = new List<string>
            {
                "1. Create new Customer",
                "2. Delete Customer",
                "3. Update Customer",
                "4. Search Customer",
                "5. Print all Customer",
                "6. Back to main menu"
            };

            List<string> MainMenuPizza = new List<string>()
            {
                "1. Create new Pizza",
                "2. Delete Pizza",
                "3. Update Pizza",
                "4. Search Pizza",
                "5. Print Pizza menu",
                "6. Back to main menu"
            };
            List<string> MainMenuOrder = new List<string>()
            {
                "1. Create new Order",
                "2. Delete Order",
                "3. Update Order",
                "4. Search Order",
                "5. Print All Orders",
                "6. Back to main menu"
            };

            while (ProceedMain)
            {
                int ChoiceMainMenu = MenuchoiceMain(MainMenu);

                switch (ChoiceMainMenu) 
                {
                    case 1:
                        bool ProceedPizza = true;
                        while (ProceedPizza)
                        {
                            int ChoicePizza = MenuchoicePizza(MainMenuPizza);

                            {

                                switch (ChoicePizza)
                                {
                                    case 1:
                                        Console.Clear();

                                        try
                                        {
                                            Console.WriteLine("ENTER NAME OF NEW PIZZA :\n");
                                            string Name = Console.ReadLine();
                                            Console.WriteLine("ENTER PRICE OF NEW PIZZA :\n");
                                            int Price = int.Parse(Console.ReadLine());
                                            Console.WriteLine("ENTER ID OF NEW PIZZA :\n");
                                            int Id = int.Parse(Console.ReadLine());

                                            Pizza NewPizza = PC.Addpizza(Name, Price, Id);
                                            Console.Clear();
                                            Console.WriteLine($"THE NEW PIZZA \n\n{NewPizza}");

                                        }
                                        catch (FormatException e) { Console.WriteLine(e.Message); }
                                          

                                        Console.Write("\nHit any key to continue");
                                        Console.ReadKey();
                                        break;

                                    case 2:
                                        string MenuForDelete = PC.PrintMenu();
                                        Console.Clear();
                                        Console.WriteLine(MenuForDelete);
                                        try
                                        {
                                            Console.WriteLine("Please enter the ID by the pizza you want to delete\n");
                                            int id = int.Parse(Console.ReadLine());
                                            PC.DeletePizza(id);

                                            Console.WriteLine($"\nThis is the menu now\n\n{MenuForDelete}");
                                        }
                                        catch (FormatException e) { Console.WriteLine(e.Message); }
                                        Console.Write("\nHit any key to continue");
                                        Console.ReadKey();
                                        break;

                                    case 3:
                                        string MenuForUpdate = PC.PrintMenu();
                                        Console.Clear();
                                        Console.WriteLine("Please enter the ID by the pizza you want to Update\n\n");

                                        Console.WriteLine(MenuForUpdate);
                                        try
                                        {
                                            int idchoice = int.Parse(Console.ReadLine());
                                            Console.Clear();
                                            Pizza PizzaToBeUpdated = PC.SearchForPizza(idchoice);

                                            if (PizzaToBeUpdated != null)
                                            {
                                                Console.WriteLine("ENTER NEW NAME OF PIZZA :\n");
                                                string NewName = Console.ReadLine();
                                                Console.WriteLine("ENTER NEW PRICE OF PIZZA :\n");
                                                int NewPrice = int.Parse(Console.ReadLine()); Pizza UpdatedPizza = PC.UpdatePizza(PizzaToBeUpdated, NewPrice, NewName);
                                                Console.Clear();
                                                Console.WriteLine($"THE NEW PIZZA \n\n{UpdatedPizza}");
                                            }
                                            else
                                            { Console.WriteLine("No pizza matches this ID"); }
                                        }
                                        catch (FormatException e) { Console.WriteLine(e.Message); }

                                        Console.Write("\nHit any key to continue");
                                        Console.ReadKey();
                                        ; break;

                                    case 4:
                                        string MenuForSearch = PC.PrintMenu();
                                        Console.Clear();
                                        Console.WriteLine(MenuForSearch);
                                        Console.WriteLine("\nPlease enter the Id by the Pizza you want to search for\n");
                                        int Id1 = int.Parse(Console.ReadLine());
                                        Console.Clear();
                                        Pizza foundpizza = PC.SearchForPizza(Id1);
                                        if (foundpizza == null) { Console.WriteLine("No Pizza matches this ID"); }
                                        else { Console.WriteLine(foundpizza.ToString()); }
                                        Console.Write("\nHit any key to continue");
                                        Console.ReadKey(); ; break;

                                    case 5:
                                        string Menu = PC.PrintMenu();
                                        Console.Clear();
                                        Console.WriteLine(Menu);
                                        Console.Write("\nHit any key to continue");
                                        Console.ReadKey(); break;

                                    case 6: ProceedPizza = false;  break;
                                }
                            }
                    }
                    break;

                    case 2:
                        bool ProceedCustomer = true;

                        while (ProceedCustomer)
                        {
                            int ChoiceCustomer = MenuchoiceCustomer(MainMenuCustomer);
                            switch (ChoiceCustomer)
                            {
                                case 1:
                                    Console.Clear();

                                    try
                                    {
                                        Console.WriteLine("ENTER NAME OF NEW CUSTOMER :\n");
                                        string Name = Console.ReadLine();
                                        Console.WriteLine("ENTER PHONERNUMBER OF NEW CUSTOMER :\n");
                                        string Phonernumber = (Console.ReadLine());
                                        Console.WriteLine("ENTER ID OF NEW CUSTOMER :\n");
                                        int Id = int.Parse(Console.ReadLine());
                                        Console.Clear();
                                        Console.WriteLine("CREATING ADRESSE FOR NEW CUSTOMER\n\nENTER CITY :");
                                        string city = Console.ReadLine();
                                        Console.WriteLine("ENTER ZIPCODE :\n");
                                        string zipcode = Console.ReadLine();
                                        Console.WriteLine("ENTER STREETNAME :\n");
                                        string streetname = Console.ReadLine();
                                        Console.WriteLine("ENTER STREETNUMBER :\n");
                                        string streetnumber = Console.ReadLine();

                                        Customer NewCustomer = CC.AddCustomer(Name, Phonernumber, Id, city, zipcode, streetname, streetnumber);
                                        Console.Clear();
                                        Console.WriteLine($"\n The new Customer \n\n{NewCustomer}");
                                        Console.Write("\nHit any key to continue");
                                        Console.ReadKey();
                                    }

                                    catch (FormatException e) { Console.WriteLine(e.Message); }

                                    break;



                                case 2:
                                    string MenuForDelete = CC.PrintMenu();
                                    Console.Clear();
                                    Console.WriteLine(MenuForDelete);
                                    try
                                    {
                                        Console.WriteLine("Please enter the ID by the customer you want to delete\n");
                                        int id = int.Parse(Console.ReadLine());
                                        CC.DeleteCustomer(id);

                                        Console.WriteLine($"\nThis is the menu now\n\n{MenuForDelete}");
                                    }
                                    catch (FormatException e) { Console.WriteLine(e.Message); }
                                    Console.Write("\nHit any key to continue");
                                    Console.ReadKey();
                                    break;

                                case 3:
                                    string MenuForUpdate = CC.PrintMenu();
                                    Console.Clear();
                                    Console.WriteLine("Please enter the ID by the Customer you want to Update\n\n");
                                    Console.WriteLine(MenuForUpdate);
                                    int idchoice = int.Parse(Console.ReadLine());
                                    Console.Clear();
                                    Customer CustomerToBeUpdated = CC.SearchForCustomer(idchoice);
                                    if (CustomerToBeUpdated != null)
                                    {
                                        Console.WriteLine("ENTER NEW NAME OF CUSTOMER :\n");
                                        string NewName = Console.ReadLine();
                                        Console.WriteLine("ENTER NEW PHONERNUMBER OF PIZZA :\n");
                                        string NewPhonenumber = Console.ReadLine();
                                        Console.WriteLine("CREATING NEW ADRESSE FOR NEW CUSTOMER\n\nENTER CITY :");
                                        string Newcity = Console.ReadLine();
                                        Console.WriteLine("ENTER ZIPCODE :\n");
                                        string Newzipcode = Console.ReadLine();
                                        Console.WriteLine("ENTER STREETNAME :\n");
                                        string Newstreetname = Console.ReadLine();
                                        Console.WriteLine("ENTER STREETNUMBER :\n");
                                        string Newstreetnumber = Console.ReadLine();

                                        Customer UpdatedCustomer = CC.UpdateCustomer(CustomerToBeUpdated, NewPhonenumber, NewName, Newcity, Newzipcode, Newstreetname, Newstreetnumber);
                                        Console.Clear();
                                        Console.WriteLine($"THE NEW CUSTOMER \n\n{UpdatedCustomer}");
                                    }
                                    else
                                    { Console.WriteLine("No Customer matches this ID"); }
                                    Console.Write("\nHit any key to continue");
                                    Console.ReadKey();
                                    break;

                                case 4:
                                    string MenuForSearch = CC.PrintMenu();
                                    Console.Clear();
                                    Console.WriteLine(MenuForSearch);
                                    Console.WriteLine("\nPlease enter the ID by the Customer you want to search for\n");
                                    int Id1 = int.Parse(Console.ReadLine());
                                    Console.Clear();
                                    Customer foundcustomer = CC.SearchForCustomer(Id1);
                                    if (foundcustomer == null) { Console.WriteLine("No Customer matches this ID"); }
                                    else { Console.WriteLine(foundcustomer.ToString()); }
                                    Console.Write("\nHit any key to continue");
                                    Console.ReadKey();
                                    break;

                                case 5:
                                    string Menu = CC.PrintMenu();
                                    Console.Clear();
                                    Console.WriteLine(Menu);
                                    Console.Write("\nHit any key to continue");
                                    Console.ReadKey();
                                    break;

                                case 6:
                                    ProceedCustomer = false;

                                    break;
                            }
                        }
                    break;

                        case 3:
                        bool ProceedOrder = true;
                        while (ProceedOrder)
                        { int ChoiceOrder = MenuchoiceCustomer(MainMenuOrder);
                            switch (ChoiceOrder)
                            {
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine(" ENTER ID OF NEW ORDER :\n");
                                    int IdOrder = int.Parse(Console.ReadLine());
                                    string MenuCustomers = CC.PrintMenu();
                                    Console.Clear();
                                    Console.WriteLine(" PLEASE CHOOSE CUSTOMER\n\n");
                                    Console.WriteLine(MenuCustomers);
                                    int Idcustomer = int.Parse(Console.ReadLine());
                                    Customer customerForOrder = CC.AddCustomerToOrder(Idcustomer);
                                    Order NewOrder = OC.AddOrder(IdOrder, customerForOrder);
                                    bool ProceedPizzaChoice = true;
                                    while (ProceedPizzaChoice) 
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Please choose a pizza\n\n When you are done adding pizzas press 0");
                                        string MenuForAddPizza = PC.PrintMenu();
                                        Console.WriteLine(MenuForAddPizza);
                                        int id = int.Parse(Console.ReadLine());
                                        if(id == 0) { ProceedPizzaChoice = false; }
                                        Pizza PizzaOrder = PC.AddPizzaToOrder(id);
                                        NewOrder.AddPizzaToOrder(PizzaOrder);
                                        
                                    }
                                    
                                    break;
                            }
                        }
                        break;
                }
            }
            
        }
    }
}
