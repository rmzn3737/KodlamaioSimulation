// See https://aka.ms/new-console-template for more information

using Business.Concrete;
using DataAccsess.Concrete.EntityFramework;
using DataAccsess.Concrete.InMemory;

internal class Program
{
    public static void Main(string[] args)
    {
        //CourseManager courseManager = new CourseManager(new InMemoryCourseDal());
        CourseManager courseManager = new CourseManager(new EfCourseDal());
        
        foreach (var course in courseManager.GetAll())
        {
            Console.WriteLine(course.CourseName);
        }
        
    }
}
