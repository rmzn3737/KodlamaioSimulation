// See https://aka.ms/new-console-template for more information

using Business.Concrete;
using DataAccsess.Concrete.EntityFramework;
using DataAccsess.Concrete.InMemory;

internal class Program
{
    public static void Main(string[] args)
    {
        //CourseManager courseManager = new CourseManager(new InMemoryCourseDal());
        //ProductTest();
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());//Şimdilik newliyoruz, ilerde IoC conteyner ile yapacağız.
        foreach (var category in categoryManager.GetAll())
        {
            Console.WriteLine(category.CategoryName);
        }
    }

    private static void ProductTest()
    {
        CourseManager courseManager = new CourseManager(new EfCourseDal());

        foreach (var course in courseManager.GetAll())
        {
            Console.WriteLine(course.CourseName);
        }
    }
}
