/* int[] studentGrades = { 85, 90, 78, 92, 88 };
   assignments.Student student = new assignments.Student("Sambi", studentGrades);
   double average = student.CalculateAverage();
   Console.WriteLine($"{student.studentName}'s average grade is {average}"); */



/*
Product[] p1 = new Product[3];
p1[0] = new("TV", 25000, 1);
p1[1] = new("FRIDGE", 50000, 2);
p1[2] = new("AC", 10000000, 3);
foreach (var item in p1)
{
    Console.WriteLine("product name:" + item.ProductName);
    Console.WriteLine("product price:" + item.Price);
    Console.WriteLine("product quantity " + item.Quantity);
    Console.WriteLine("total price" + item.ProductValue());
} 
*/

/*
using static assignments.Students;

Students[] students = new Students[]
{

 new("Sambi", new double[] {89,80,80}, 'A'),
 new("Arjun", new double[] {90,99,90}, 'B'),
 new("Balu", new double[] {70,79,70}, 'C'),



};
foreach (Students item in students)
{
    Console.WriteLine($"Student Name is :{item.Name}");
    Console.WriteLine($"Student Grade is: {item.Grade}");
    double[] marks = new double[3];
    double total = 0;
    Console.WriteLine("Marks of student is:\t");
    for (int i = 0; i < marks.Length; i++)
    {
        marks[i] = item.Marks[i];
        total = total + marks[i];
        Console.WriteLine(marks[i]);
    }
    Console.WriteLine($"Total Marks is:{total}");
    Console.WriteLine($"Average Marks is: {item.CalculateAverage()}");
    Console.WriteLine(item.GetMarksSummary());
}
*/

/*
using assignments;

List<Patient> patients = new List<Patient>();
string filePath = "patient_records.txt";
void LoadPatientRecordsFromFile()
{
    throw new NotImplementedException();
}
int choice;
do
{
    Console.WriteLine("Patient Records System");
    Console.WriteLine("1. Add Patient Record");
    Console.WriteLine("2. View Pateint Records");
    Console.WriteLine("3. Exit");
    Console.Write("Enter your choice: ");

    if (int.TryParse(Console.ReadLine(), out choice))
    {
        switch (choice)
        {
            case 1:
                AddPatientRecord();
                break;
            case 2:
                ViewPatientRecords();
                break;
            case 3:
                SavePatientRecordsToFile();
                Console.WriteLine("Exiting the program.");
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a number. ");
    }

}while (choice != 3);

*/








/*using assignments.UserException;

try
{
    Patient patient1 = new(11, "aa", 25, "diabetics");
    patient1.AddPatient(patient1);
}
catch (AgeException ex)
{
    Console.WriteLine(ex.Message);
}
try
{
    Patient patient2 = new(11, "aa", 125, "diabetics");
    patient2.AddPatient(patient2);
}
catch (AgeException ex)
{
    Console.WriteLine(ex.Message);
}
*/












/*
Customer customer = new Customer();
List<Customer> customerArray = new List<Customer>
{
new(1, "Arjun", "1908", 5677),
new(2, "Mani", "0908", 7890),
new(3, "kajal", "5643", 3000)
};

foreach (Customer cust in customerArray)
{
    Console.WriteLine("Customer Name: " + cust.Name +
    " Customer ID : " + cust.CustomerId + " Phone Number: " +
    cust.PhoneNumber + " Balance : " + cust.Balance);
}
bool IsCustAvail = false;

foreach (Customer cust in customerArray)
{
    if (customer.SearchCustomer("8484", cust))
    {
        IsCustAvail = true;
        Console.WriteLine("Customer Name: " + cust.Name + " Balance: " +
        cust.Balance);
        break;
    }
}

if (!IsCustAvail)
{
    Console.WriteLine("Customer not found");
}
*/









using assignments.UserException;
using assignments;

//Todo
//TaskItem taskItem = new TaskItem(1, "Maths", "Completed");
//TaskItem taskItem1 = new TaskItem(2, "Science", "Pending");

//TaskItem.toDoList.Add(taskItem);
//TaskItem.AddTodo(taskItem);
//TaskItem.AddTodo(taskItem1);
//TaskItem.updateList(2, "Completed");
//TaskItem.Display("Completed");
//TaskItem.Remove(1);

//FamilyMember
FamilyMember grandparent = new FamilyMember("Grandparent", 80);
FamilyMember parent1 = new FamilyMember("Parent 1", 47);
FamilyMember parent2 = new FamilyMember("Parent 2", 42);
FamilyMember child1 = new FamilyMember("Child 1", 17);
FamilyMember child2 = new FamilyMember("Child 2", 10);

grandparent.AddChild(parent1);
grandparent.AddChild(parent2);
parent1.AddChild(child1);
parent2.AddChild(child2);

FamilyTree familyTree = new FamilyTree(grandparent);
familyTree.DisplayFamilyTree();






//TourismDestinations
//TourismDestinations tourism1 = new TourismDestinations("Dungeness", "UK", 4, 9875);
//TourismDestinations tourism2 = new TourismDestinations("Goa", "India", 3, 3500);
//TourismDestinations tourism3 = new TourismDestinations("Melbourne", "Australia", 3, 7450);
//TourismDestinations.tourismDestinations.Add(tourism1);
//TourismDestinations.tourismDestinations.Add(tourism2);
//TourismDestinations.tourismDestinations.Add(tourism3);
//TourismDestinations.DisplayTopRated();
//TourismDestinations.SortedDestination();
//TourismDestinations.FilterDestination();

//TourPackage

//TourPackage package = new TourPackage(1, "kochi", "12-11-2024", 2000);
//TourPackage package1 = new TourPackage(2, "Alappuzha", "12-10-2024", 3000);
//TourPackage package2 = new TourPackage(3, "Trivandrum", "2-2-2023", 2500);

//TourPackage.TourPackages.Add(package1);
//TourPackage.TourPackages.Add(package2);
//TourPackage.TourPackages.Add(package);


//Thread thread = new Thread(TourPackage.HotelReservation);

//Thread thread1 = new Thread(TourPackage.HotelReservation);

//thread1.Start();
//thread1.Join();
//thread.Start();

//Hotel


//Hotel hotel = new Hotel("name", 4, "gfd", "adfgas", 45);
//Hotel hotel1 = new Hotel("name2", 6, "kju", "adfgas", 45);
//Hotel hotel2 = new Hotel("name3", 17, "asr", "adfgas", 45);

//await hotel.HotelBookingig(6, hotel);
//await hotel1.HotelBookingig(5, hotel1);
//await hotel2.HotelBookingig(5, hotel2);


/*
List<TourismDestination> destinations = new List<TourismDestination>()
{
    new TourismDestination("Beach Paradise", "Tropical Island", 4, 200),
    new TourismDestination("Mountain Retreat", "Alpine village", 5, 150),
    new TourismDestination("City Lights", "Metropolis", 4, 300),
    new TourismDestination("Historic Town", "Old Europe", 3, 100),
    new TourismDestination("Nature's Beauty", "National Park", 5, 80),
};
var topRatedDestinations = destinations.Where(dest => dest.Rating > 4);
Console.WriteLine("Top-Rated Tourist Destinations: ");
foreach (var destination in topRatedDestinations)
{
    Console.WriteLine($"Name: {destination.Name}, Location: {destination.Location}, Rating: {destination.Rating}, Price Per Night: ${destination.PricePerNight}");

}
var sortedByPrice = destinations.OrderBy(dest => dest.PricePerNight);
Console.WriteLine("\nTourist Destinations Sorted by Price Per Night (Ascending Order):");
foreach (var destination in sortedByPrice)
{
    Console.WriteLine($"Name: {destination.Name}, Location: {destination.Rating}, Price Per Night: ${destination.PricePerNight}");

    
}
string targetLocation = "Metropolis";
var filteredByLocation = destinations.Where(dest => dest.Location == targetLocation);
Console.WriteLine($"\nTourist Destinations in {targetLocation}:");
foreach (var destination in filteredByLocation)
{
    Console.WriteLine($"Name: {destination.Name}, Location: {destination.Location}, Rating: {destination.Rating}, Price Per Night: ${destination.PricePerNight}");

}
*/
















/*
while (true)
{
    Console.WriteLine("Menu:");
    Console.WriteLine("1: Add a Tourism Destination");
    Console.WriteLine("2: View Destinations Sorted by Rating");
    Console.WriteLine("3. Exit");
    Console.WriteLine("Choose an option: ");
    if (!int.TryParse(Console.ReadLine(), out int choice))
    {
        Console.WriteLine("Invalid input. Please enter a number. ");
        continue;
    }


    switch (choice)
    {
        case 1:
            Console.Write("Enter the name of the destination: ");
            string name = Console.ReadLine();
            Console.Write("Enter the country: ");
            string country = Console.ReadLine();
            Console.Write("Enter the rating (1 to 5): ");
            if (!int.TryParse(Console.ReadLine(), out int rating) || rating < 1 || rating > 5)
            {
                Console.WriteLine("Invalid rating. Please enter a number between 1 and 5. ");
                continue;
            }
            destinations.Add(new TourismDestination(name, country, rating));
            break;
        case 2:
            List<TourismDestination> sortedDestinations = TourismDestination.SortByRatingDescending(destinations);
            Console.WriteLine("Tourism Destinations Sorted by Rating (Descending Order):");
            foreach (var destination in sortedDestinations)
            {
                Console.WriteLine($"Name: {destination.Name}, Country: {destination.Country}, Rating: {destination.Rating}");

            }
            break;
        case 3:
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid option. Please choose a valid option");
            break;

    }

}
*/















/*
class Program
{
    public delegate double DelegateOne(Employees employee);
    public delegate double DelegateTwo(Employees employeeone);

    public static void Main(String[] args)
    {
        DelegateBonus delegateExample = new DelegateBonus();
        Employees employee = new(1, "Parvathy", 4);
        Employees employeeone = new(2, "Aiswarya", 5);
        DelegateOne delegateOne = Employees.BonusCalculation;
        DelegateTwo delegateTwo = Employees.BonusCalculation;
        Console.WriteLine($"Employee Name:{employee.EmployeeName}\nPerformance Rating:{employee.PerformanceRange}\nBonus Amount:{delegateOne(employee)}");
        Console.WriteLine($"Employee Name:{employeeone.EmployeeName}\nPerformance Rating:{employeeone.PerformanceRange}\nBonus Amount:{delegateTwo(employeeone)}");

    }
}
*/

/*
class Program
{
    public delegate string DelegateMessageOne(string msg);
    public delegate string DelegateMessageTwo(string msg);
    public static void Main(string[] args)
    {
        HotelEvent hotelEvent = new("Dance", "Calicut", "12.00:1-11-2023", 4);
        DelegateMessageOne delegateMessageOne = HotelEvent.EventRegistration;
        if (hotelEvent != null)
        {
            Console.WriteLine(delegateMessageOne($"Hai {hotelEvent.EventName} is Successfully Registered the event on {hotelEvent.EventDate}"));
        }
        else
        {
            Console.WriteLine(delegateMessageOne("Unsuccessfully registered"));
        }
        HotelEvent hotelEventone = new("Concert", "Ernakulam", "12.0013-10-2023", 6);

        DelegateMessageTwo delegateMessageTwo = HotelEvent.EventRegistration;
        if (hotelEventone != null)
        {
            Console.WriteLine(delegateMessageTwo($"Hai {hotelEventone.EventName} is Successfully Registered the event on {hotelEventone.EventDate}"));
        }
        else
        {
            Console.WriteLine(delegateMessageTwo("Unsuccessfully registered"));
        }
    }
}
*/














/*
Inventory<string> inventory = new Inventory<string>();
int choice, option;
do
{
    Console.WriteLine("Choose The Menu");
    Console.WriteLine("1.Add Product\n2.Update Product\n3.RemoveProduct\n4.Search ProductById\n5.Search Product By Name");
    choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            Console.WriteLine("Enter The Product Id");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The ProductName");
            string? productname = Console.ReadLine();
            Console.WriteLine("Enter The Price");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the quantity in stock");
            int qty = Convert.ToInt32(Console.ReadLine());
            inventory.AddProduct(new Products<string>(id, productname, price, qty));
            break;
        case 2:
            Console.WriteLine("Enter the product id Do You want update");
            int proid = Convert.ToInt32(Console.ReadLine());
            var prId = inventory.FindProductById(proid);
            if (prId != null)
            {
                Console.WriteLine("Enter the Product Name");
                string? name = Console.ReadLine();
                Console.WriteLine("Enter the price");
                double pric = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the qty");
                int qt = Convert.ToInt32(Console.ReadLine());
                inventory.UpdateProduct(proid, name, pric, qt);
                Console.WriteLine("Successfully Updated");

            }
            else
            {
                Console.WriteLine("No Product Found!!!");
            }

            break;
        case 3:
            Console.WriteLine("Enter the product Id Do You Want Delete");
            int ids = Convert.ToInt32(Console.ReadLine());
            var data = inventory.FindProductById(ids);
            if (data != null)
            {
                inventory.DeleteProduct(ids);
                Console.WriteLine("Product Deleted Success!!!!");
            }
            else
            {
                Console.WriteLine("No Product available!!!");
            }
            break;
        case 4:
            Console.WriteLine("View Product BY Id");
            Console.WriteLine("Enter The Product Id");
            int pid = Convert.ToInt32(Console.ReadLine());
            Products<string> pro = inventory.FindProductById(pid);
            if (pro != null)
            {
                Console.WriteLine($"Product Id:{pro.ProductId}\nProduct Name:{pro.ProductName}" +
                    $"\nPrice:{pro.Price}\nQuantity:{pro.QuantityInStock}");
            }
            else
            {
                Console.WriteLine("No Product Available");
            }



            break;
        case 5:
            Console.WriteLine("Search Product By Name");
            string? proname = Console.ReadLine();
            List<Products<string>> dat = inventory.FindProductByName(proname);
            if (dat != null)
            {
                foreach (Products<string> p in dat)
                {
                    Console.WriteLine($"Product Id:{p.ProductId}\nProduct Name:{p.ProductName}" +
                    $"\nPrice:{p.Price}\nQuantity:{p.QuantityInStock}");
                }
            }
            else
            {
                Console.WriteLine("No Product Found!!!");
            }
            break;
        case 6:
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid Option!!!!");
            break;
    }
    Console.WriteLine("Do you want to continue \n1. Yes \n2.No");
    option = Convert.ToInt32(Console.ReadLine());

} while (option == 1);
*/










/*
HotelRoom hotel = new HotelRoom(401, "Double", true);
RoomReservation<HotelRoom> room = new();

room.BookRoom(hotel);
Console.WriteLine("Hotel Room booked Successfully");
Console.WriteLine("Details are :");
string? status;
foreach (var item in RoomReservation<HotelRoom>.values)
{
    if (item.IsBooked)
        status = "Engaged";
    else
        status = "Not Engaged";
    Console.WriteLine("Room Number:{0} Room Type:{1} Status:{2} ", item.RoomNumber, item.RoomType, status);
}
Console.WriteLine("Enter the room number for canceling:");
int num = Convert.ToInt32(Console.ReadLine());
var roomNum = HotelRoom.GetRoom(num);
if (roomNum != null)
{
    room.CancelRoom(roomNum);
    Console.WriteLine("Room is canceled");
}
else
{
    Console.WriteLine("Room doesn't exist");
}
*/
/*
MedicalHistory medicalHistory = new MedicalHistory();
medicalHistory.RecordId = 11;
medicalHistory.PatientId = 102;
medicalHistory.Description = " Paracetamol for 3 days";
medicalHistory.Date = DateTime.UtcNow;

Console.WriteLine("Choose");
Console.WriteLine("1-> Add Medical History\n2->View Medical History\n 3-> exit ");
int ch = Convert.ToInt32(Console.ReadLine());
switch (ch)
{
    case 1:
        medicalHistory.AddMedicalHistoryToFile(medicalHistory);
        break;
    case 2:
        Console.WriteLine("Enter the Patient Id to read");
        medicalHistory.ReadMedicalHistoryFromFile(Convert.ToInt32(Console.ReadLine()));
        break;
    case 3:
        Console.WriteLine("You got exited from execution");
        break;
    default:
        Console.WriteLine("Please check the number");
        break;
}
*/













/*
Patient patient = new Patient();
Console.Write("Enter the patient Id:");
int id = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the Name:");
string name = Console.ReadLine();
Console.Write("Enter the Age:");
int age = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the Diagnosis:");
string diagnosis = Console.ReadLine();
try
{
    patient.AddPatient(id, name, age, diagnosis);

}
catch (Exception ex)
{
   Console.WriteLine(ex.Message);
}
*/

/*
Patient patient = new Patient();
int option=1;
do
{
    Console.WriteLine("Enter the choice:");
    Console.WriteLine("1.Add Patient Record\n2.View Patient Record\n3.Exit");
    switch (Convert.ToInt32(Console.ReadLine()))
    {
        case 1:
            Console.Write("Enter the patient Id:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Name:");
            string name = Console.ReadLine();
            Console.Write("Enter the Age:");
            int age = Convert.ToInt32(Console.ReadLine());
           Console.Write("Enter the Diagnosis:");
           string diagnosis = Console.ReadLine();
           patient.AddPatientTextFile(id, name, age, diagnosis);
          break;

          case 2:
          patient.ReadDetails();
          break;

     case 3:
          Environment.Exit(0);
           break;
       default:
            Console.WriteLine("Invalid choice");
           break;

   }  
   Console.WriteLine("Do you wish to continue?\n1.Yes\n2.No");
   option=Convert.ToInt32(Console.ReadLine());
}
while(option!=2);


Console.WriteLine("Enter the choice:\n1.");

*/







/*
MedicalRecord medicalRecord = new MedicalRecord();


Console.Write("Enter the patient Id:");
int id = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the record Id:");
int r_id = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the Name:");
string name = Console.ReadLine();
Console.Write("Enter the Age:");
int age = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the Diagnosis:");
string diagnosis = Console.ReadLine();
Console.Write("Enter the treatment cost:");
double cost = Convert.ToDouble(Console.ReadLine());
try
{
    medicalRecord.AddMedicalRecord(r_id, id, name, age, diagnosis, cost);
    medicalRecord.DisplayDetails();
}
catch (InvalidMedicalRecordException ex)
{
    Console.WriteLine(ex.Message);
}
catch (InvalidPatientDataException ex)
{
    Console.WriteLine(ex.Message);
}
*/



/*
try
{
    Patient patient1 = new(11, "aa", 25, "diabetics");
    patient1.AddPatient(patient1);
    Console.WriteLine();
}
catch (AgeException ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine();
}
try
{
    Patient patient2 = new(11, "aa", 125, "diabetics");
    patient2.AddPatient(patient2);
    Console.WriteLine();
}
catch (AgeException ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine();
}
*/








/*
TelecomCallManager callManager = new TelecomCallManager();
callManager.AddCallRecord(new CallRecord(1, "123 - 456 - 7890", DateTime.Now.AddHours(-1)));
callManager.AddCallRecord(new CallRecord(2, "987 - 456 - 8970", DateTime.Now.AddHours(-2)));
callManager.AddCallRecord(new CallRecord(3, "345 - 546 - 9870", DateTime.Now.AddHours(-3)));
callManager.DisplayCallHistoryForPhoneNumber("123 - 456 - 7890");
callManager.DisplayTotalCallPerPhoneNumber();
Console.ReadLine();









/*
InsurancePolicy1 lifeInsurance = new LifeInsurance(" Life Policy", 1, 25);
InsurancePolicy1 carInsurance = new CarInsurance("Car Policy", 2, "SUV");
Console.WriteLine("Life Insurance Policy Details:");
lifeInsurance.DisplayPolicyDetails();
Console.WriteLine("\nCar Insurance Policy Details:");
carInsurance.DisplayPolicyDetails();






/*
InsurancePolicy policy = new InsurancePolicy("Auto Insurance", 12345, 500.00);
Console.WriteLine("Initial Policy Details:");
policy.DisplayPolicyDetails();
Console.WriteLine();
policy.RenewPolicy(550.00);
Console.WriteLine();
policy.RenewPolicy();
Console.WriteLine();
Console.WriteLine("Final Policy Details: ");
policy.DisplayPolicyDetails();
*/



//Employee employee1 = new Employee("John", "Doe", 24, 101);
//Employee employee2 = new Employee("Jane", "Smith", 30, 102);
//employee1.DisplayInfo();
//employee2.DisplayInfo();










/*
Console.WriteLine("Choose");
Console.WriteLine("1-> Area\n 2-> Perimeter\n");
switch (Convert.ToInt32(Console.ReadLine()))
{


 case 1:
    Circle circle = new Circle(5);
    circle.Draw();
    break;
case 2:
    Rectangle rectangle = new Rectangle(4, 6);
    rectangle.Draw();
    break;
default:
    Console.WriteLine("Please check the number you have entered");
    break;
}
*/
/*
 Console.WriteLine("Choose");
Console.WriteLine("1-> Book\n 2-> Fiction\n 3-> NonFiction \n " +
    "4-> Get Customer Details\n 5-> To Order");
switch (Convert.ToInt32(Console.ReadLine()))
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
    break;/

    //Circle circle = new Circle(5);
    //Rectangle rectangle = new Rectangle(4, 6);
    //circle.Draw();
    //Console.WriteLine();
    //rectangle.Draw();








/*
ElectronicsProduct electronicsProduct = new(5, "fan", 870, 8);
electronicsProduct.ProductValue();
electronicsProduct.ElectronicsProductDisplay();

DigitalProduct digitalProduct = new(5, "camera", 10000, 6, "MP4");
digitalProduct.DisplayDigitalProduct();
digitalProduct.ElectronicsProductDisplay();
digitalProduct.ProductValue();
*/







/*
Console.WriteLine("Choose");
Console.WriteLine("1 -> DigitalProduct\n 2->ElectronicsProduct\n" + "3-> ClothingProduct");
switch (Convert.ToInt32(Console.ReadLine()))
{
    case 1:
        DigitalProduct digitalProduct = new(5, "camera", 10000, 6, "MP4");
        digitalProduct.ProductValue();
        digitalProduct.ElectronicsProductDisplay();
        digitalProduct.DisplayDigitalProduct();
        break;
        case 2:
        ElectronicsProduct electronicsProduct = new(5, "fan", 870, 8);
        electronicsProduct.ProductValue();
        electronicsProduct.ElectronicsProductDisplay();
        break;
        case 3:
        ClothingProduct clothingProduct = new("Dress", 500, 4, "XL");
        clothingProduct.ProductValue();
        clothingProduct.DisplayClothing();
        break;
    default: Console.WriteLine("Please check the number you have entered");
        break;

}
*/