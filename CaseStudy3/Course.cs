using CaseStudy3.Exception;
using static CaseStudy3.Exception.EnrollmentException;

namespace CaseStudy3
{
    internal class Course : IEnrollable
    {


        public int CourseCode { get; set; }
        public string? Title { get; set; }
        public string? Instructor { get; set; }
        public int? MaxCount { get; set; }
        public static List<Course> courses = new List<Course>();
        public List<Student> Enrollments = new List<Student>();

        public void CourseRegistration(int id, int sid)
        {
            var data = courses.Find(x => x.CourseCode == id && x.MaxCount >= x.Enrollments.Count);
            var nameCheck = Student.students.Find(x => x.Id == sid);
            var s = data.Enrollments.Find(x => x.Id == sid);

            if (data == null)
            {
                throw new FullException(EnrollmentException.exceptionMessages["One"]);
            }
            else if (s != null)
            {
                throw new DuplicateException(EnrollmentException.exceptionMessages["Two"]);
            }
            else
            {
                data.Enrollments.Add(nameCheck);
                Console.WriteLine("Successfully Added!!!");
            }

        }

        public void CourseWithdrawal(int id)
        {
            var data = courses.Find(x => x.CourseCode == id);
            var removeEnroll = data.Enrollments.RemoveAll(x => x.Id == id);
            if (removeEnroll != null)
            {
                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("Unsuccess");
            }
        }

    }

}