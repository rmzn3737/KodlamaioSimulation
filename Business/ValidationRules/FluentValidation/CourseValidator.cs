using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CourseValidator : AbstractValidator<Course>
    {
        public CourseValidator()
        {
            RuleFor(c => c.CourseName).NotEmpty();
            RuleFor(c => c.CourseName).MinimumLength(2);
            RuleFor(c => c.Price).NotEmpty();
            RuleFor(c => c.Price).GreaterThan(0);
            RuleFor(c => c.Price).GreaterThanOrEqualTo(10).When(c => c.CategoryId == 1);//Kategori id si 1 e eşitse ücret 10 dan küçük olamaz.
            RuleFor(c => c.CourseName).Must(StartWithA).WithMessage("Ürünler A harfi ile başlmalı.");//Kurs ismi A harfi ile başlamalı, saçma kural ama denemek için yazdık.Altta da ilgili metodunu yazdık.
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
