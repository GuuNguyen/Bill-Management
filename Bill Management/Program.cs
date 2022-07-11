namespace Bill_Management;

class Program
{
    public static void Main()
    {
        Service service = new Service();
        int choice = 0;
        do
        {
            Console.WriteLine("Choose: ");
            Console.WriteLine("1. Add customer");
            Console.WriteLine("2. Display all");
            Console.WriteLine("3. Calculate the total amount of KW consumed");
            Console.WriteLine("4. Average money of foreign customers");
            Console.WriteLine("5. Delete");
            Console.WriteLine("6. Exit");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("----------------ADD CUSTOMER----------------");
                    Console.WriteLine("Choose type of customer:");
                    Console.WriteLine("1. Viet Nam customer");
                    Console.WriteLine("2. Foriegn customer");
                    int choice2 = int.Parse(Console.ReadLine());
                    if(choice2 == 1)
                    {
                        service.CreateVNCustomer();
                    }
                    else
                    {
                        service.CreateForeignCustomer();
                    }
                    break;
                case 2:
                    if (service.getList() == true)
                    {
                        Console.WriteLine("----------------DISPLAY----------------");
                        service.getList(); 
                    }
                    else
                    {
                        Console.WriteLine("There are no Customer!");
                    }
                    break;
                case 3:
                    if(service.getList() == true)
                    {
                        Console.WriteLine("----------------TOTAL OF KW----------------");
                        Console.WriteLine($"Total amount of KW consumed of Viet Nam Customer: "+ service.TotalKWOfVNC());
                        Console.WriteLine($"Total amount of KW consumed of Foriegn Customer: "+ service.TotalKWOfFC());
                    }
                    else
                    {
                        Console.WriteLine("There are no Customer!");
                    }
                    break;
                case 4:
                    if (service.getList() == true)
                    {
                        Console.WriteLine("----------------AVERAGE----------------");
                        Console.WriteLine($"Average money of foreign customers: " + service.AvgMoneyPay());
                    }
                    else
                    {
                        Console.WriteLine("There are no Customer!");
                    }
                    break;
                case 5:
                    if (service.getList() == true)
                    {
                        Console.WriteLine("----------------DELETE----------------");
                        Console.WriteLine($"Enter the id of customer: ");
                        int id = int.Parse(Console.ReadLine());
                        service.Delete(id);
                    }
                    else
                    {
                        Console.WriteLine("There are no Customer!");
                    }
                    break;
            }
        }while (choice != 6);
    }

}