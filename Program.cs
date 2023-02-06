namespace Models
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (var myContext = new MyContext())
                {

                    
                    Department department = new Department();
                    department.Name = "Mech";
                    myContext.Add(department);
                    myContext.SaveChanges();
                    Console.WriteLine("Department created");

                    Student student = new Student();
                    student.Name = "Chandana";

                    student.DepartmentId = "4";
                    myContext.Add(student);
                    myContext.SaveChanges();
                    Console.WriteLine("student created");

                    Course course = new Course();
                    course.Name = "Web Technology";

                    course.DepartmentId = "2";
                    myContext.Add(course);
                    myContext.SaveChanges();
                    Console.WriteLine("course created");

                    StudentAddress address = new StudentAddress();
                    address.StudentAddressId = "103";
                    address.State = "TS";
                    address.PinCode = "12345";
                    address.City = "Hyderabad";
                    address.StudentId = "3";

                    myContext.Add(address);
                    myContext.SaveChanges();
                    Console.WriteLine("address created");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
        }
    }
}