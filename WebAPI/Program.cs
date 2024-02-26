using Business.Abstract;
using Business.Concrete;
using DataAccsess.Abstract;
using DataAccsess.Concrete.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Autofac, Ninject, CastleWindsor,StructureMap, LightInject, DryInject --> Bunlar .Net te IoC yokken bile bunun yaptýðý iþi yapan alt yapý sunuyor idi.
//AOP yapacaðýz. Autofac bu imkaný sunuyor.
builder.Services.AddControllers();
builder.Services.AddSingleton<ICourseService,CourseManager>();//Biri CourseManagerda ICourseService isterse ona CourseManager ver demiþ oluyoruz. Ýçinde data tutmuyorsak singleton kullanýyoruz. 11. video 1. saat 37. dakikadan yeniden dinleyelim. Bunlar Javadaki in configurasyonu.
builder.Services.AddSingleton<ICourseDal, EfCourseDal>();//Biri CourseManagerda ICourseService isterse ona CourseManager ver demiþ oluyoruz.


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
