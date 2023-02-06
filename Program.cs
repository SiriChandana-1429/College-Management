namespace Models
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
               
                MyContext myContext = new MyContext();
                Department department = new Department();
                department.Name = "Civil";
                myContext.Add(department);
                myContext.SaveChanges();
                Console.WriteLine("Department created");

                Student student = new Student();
                student.Name = "Shashi";

                student.DepartmentId = "3";
                myContext.Add(student);
                myContext.SaveChanges();
                Console.WriteLine("student created");

                Course course = new Course();
                course.Name = "Java";

                course.DepartmentId = "1";
                myContext.Add(course);
                myContext.SaveChanges();
                Console.WriteLine("course created");

                StudentAddress address = new StudentAddress();
                address.StudentAddressId = "102";
                address.State = "Telangana";
                address.PinCode = "500084";
                address.City = "Kurnool";
                address.StudentId = "1";

                myContext.Add(address);
                myContext.SaveChanges();
                Console.WriteLine("address created");


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
        }
    }
}