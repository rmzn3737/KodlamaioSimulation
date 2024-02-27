using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Microsoft.IdentityModel.Tokens;
using ValidationException = FluentValidation.ValidationException;

namespace Core.CrossCuttingConcerns.Validation
{
    public static class ValidationTool//Böyle toollar genellikle static yapılır. C# da static sınıfın metodları da static olur.
    {
        public static void Validate(IValidator validator,object entity)
        {
            //Cross Cutting Conserns
            //Log, cache, transaction, authorization, …  bunları araştıralım.
            var context = new ValidationContext<object>(entity);//**Bu yöntem doğrulamanın en spagetti code yöntemi.
            //CourseValidator courseValidator = new CourseValidator();//Artık ihtiyaç kalmadı comment yaptık.
            var result = validator.Validate(context);
            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }

        }
    }
}
