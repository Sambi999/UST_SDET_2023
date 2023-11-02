using System.Diagnostics;
using System.Net.Http.Headers;
using ThreadsEx;
/*
Warehouse warehouse = new Warehouse();

Thread worker1 = new Thread(() => warehouse.AddBox(1));
Thread worker2 = new Thread(() => warehouse.AddBox(2));

worker1.Start();
worker2.Start();

worker1.Join();
worker2.Join();

Console.WriteLine("Work completed. Total boxes in the warehouse:" + warehouse.GetTotalBoxes());
*/


/*
CourseRegistration course = new CourseRegistration();
int numberOfStudents = 5;

List<Thread> studentThreads = new List<Thread>();
for (int i = 1; i <= numberOfStudents; i++)
{
    string studentName = $"Student {i}";
    Thread studentThread = new Thread(() => course.RegisterStudent(studentName));
    studentThreads.Add(studentThread);
    studentThread.Start();


}
foreach (Thread studentThread in studentThreads)
{
    studentThread.Join();
}
Console.WriteLine("Course registration completed. Total registread students: {course.GetRegisteredStudentCount()}");
*/

/*
static async Task Main()
{
    Console.WriteLine("Starting the asynchronous operation...");
    //Perform an asynchronous operation
    await PerformAsyncOperation();
    Console.WriteLine("Asynchronous operation completed.");
}
static async Task PerformAsyncOperation()
{
    //Simulate an asynchronous operation
    await Task.Delay(2000); //Delay for 2 seconds (simulating work)
    Console.WriteLine("Async operation is complete.");
}                                     
 */


/*
static async Task Main()
{
    List<string> urls = new List<string>
    {
        "https://www.bewakoof.com",
        "https://www.bigbasket.com",
        "https://www.youtube.com"
    };
    Console.WriteLine("Downloading web pages aynchronously...");
    List<Task<string>> downloadTasks = new List<Task<string>>();
    foreach (string url in urls)
    {
        downloadTasks.Add(DownloadWebPageAsync(url));
    }
    await Task.WhenAll(downloadTasks);
    foreach (Task<string> task in downloadTasks)
    {
        string content = await task;
        Console.WriteLine($"Downloaded {content.Length} bytes from a web page.");
    }
    Console.WriteLine("All web pages downloaded.");
}
static async Task<string> DownloadWebPageAsync(string url)
{
    using (HttpClient client = new HttpClient())
    {
        string content = await client.GetStringAsync(url);
        return content;
    }
}

*/

static async Task Main()
{
    CourseRegistration course = new CourseRegistration();
    int numberOfStudents = 5;
    List<Task> registrationTasks = new List<Task>();
    for (int i = 1; i <= numberOfStudents; i++)
    {
        string studentName = $"Student {i}";
        Task registrationTask = course.RegisterStudentAsync(studentName);
        registrationTasks.Add(registrationTask);
    }
    await Task.WhenAll(registrationTasks);
    Console.WriteLine($"Course registration completed. Total registered students: {course.GetRegisteredStudentCount()}");
}
                                         
                                         
                                         





    

                                         
                                         
                                         
                                         
                                         



                                        


