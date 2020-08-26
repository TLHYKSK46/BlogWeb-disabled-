using System;
using BlogEntities.BlogDb;
using FluentValidation;
namespace BlogCores.CrossCuttingConcerns.Validation.FluentValidation
{
    public class ValidatorTool
    {
        public static void FluentValidate(IValidator validator, Object entity)
        {
            var result = validator.Validate((IValidationContext)entity);
            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors); 
            }
        }
        
    }
}