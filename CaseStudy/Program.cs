using CaseStudy;
Console.WriteLine("Choose");
Console.WriteLine("1-> Book\n 2-> Fiction\n 3-> NonFiction \n " +
    "4-> Get Customer Details\n 5-> To Order");
switch (Convert.ToInt32(Console.ReadLine()))
{
    case 1:
        Book book = new Book();
        Console.WriteLine("Enter the title");
        book.Title = Console.ReadLine();
        Console.WriteLine("Enter the Author");
        book.Author = Console.ReadLine();
        Console.WriteLine("Enter the ISBN");
        book.ISBN = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Price");
        book.Price = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Availabity");
        book.Availability = Console.ReadLine();
        book.DisplayBook();
        book.SearchBook();
        break;
    case 2:
        FictionBook fiction = new FictionBook();
        Console.WriteLine("Enter the title");
        fiction.Title = Console.ReadLine();
        Console.WriteLine("Enter the Author");
        fiction.Author = Console.ReadLine();
        Console.WriteLine("Enter the ISBN");
        fiction.ISBN = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Price");
        fiction.Price = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Availabity");
        fiction.Availability = Console.ReadLine();
        Console.WriteLine("Enter the Category");
        fiction.Category = Console.ReadLine();
        fiction.DisplayBook();
        fiction.DisplayFictionDetails();
        fiction.SearchFictionBook();
        break;
    case 3:
        NonFictionBook nonfiction = new NonFictionBook();
        Console.WriteLine("Enter the title");
        nonfiction.Title = Console.ReadLine();
        Console.WriteLine("Enter the Author");
        nonfiction.Author = Console.ReadLine();
        Console.WriteLine("Enter the ISBN");
        nonfiction.ISBN = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Price");
        nonfiction.Price = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Availabity");
        nonfiction.Availability = Console.ReadLine();
        Console.WriteLine("Enter the Edition");
        nonfiction.Edition = Convert.ToInt32(Console.ReadLine());
        nonfiction.DisplayBook();
        nonfiction.DisplayNonFictionDetails();
        nonfiction.SearchNonFictionBook();
        break;
    case 4:
        Customer customer = new Customer();
        Console.WriteLine("Enter the Customer Id");
        customer.CustomerId1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Customer Name");
        customer.CustomerName1 = Console.ReadLine();
        Console.WriteLine("Enter the Phone Number");
        customer.PhoneNumber1 = Console.ReadLine();
        customer.DisplayCustomerDetails();
        customer.AddCustomerDetails("64646");
        Console.WriteLine("After modification");
        customer.DisplayCustomerDetails();
        break;
    case 5:
        Order order = new Order();
        Book book1 = new Book();

        Console.WriteLine("Enter the Customer Id");
        order.CustomerId1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Customer Name");
        order.CustomerName1 = Console.ReadLine();
        Console.WriteLine("Enter the Customer Phone Number");
        order.PhoneNumber1 = Console.ReadLine();
        Console.WriteLine("Enter the Book Details Title And Author Name");
        book1.Title = Console.ReadLine();
        book1.Author = Console.ReadLine();
        Console.WriteLine("enter the cost of book");
        book1.Price = Convert.ToInt32(Console.ReadLine());
        order.DisplayCustomerDetails();
        order.PlaceOrder(book1);
        Console.WriteLine("Total cost: " + order.CalculateCost(book1));
        break;

    default:
        Console.WriteLine("please check the number you have entered");
        break;

}
