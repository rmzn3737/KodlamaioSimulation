// See https://aka.ms/new-console-template for more information

using Business.Concrete;
using DataAccsess.Concrete.EntityFramework;
using DataAccsess.Concrete.InMemory;

internal class Program
{
    public static void Main(string[] args)
    {
        //DTO= Data Transformation Object
        //CourseManager courseManager = new CourseManager(new InMemoryCourseDal());
        CourseTest();
        //CategoryTest();
    }

    private static void CategoryTest()
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());//Şimdilik newliyoruz, ilerde IoC conteyner ile yapacağız.
        foreach (var category in categoryManager.GetAll())
        {
            Console.WriteLine(category.CategoryName);
        }
    }

    private static void CourseTest()
    {
        CourseManager courseManager = new CourseManager(new EfCourseDal());

        foreach (var course in courseManager.GetCourseDetails())
        {
            Console.WriteLine(course.CourseName +" ***/*** "+course.CategoryName);
        }
    }
}
