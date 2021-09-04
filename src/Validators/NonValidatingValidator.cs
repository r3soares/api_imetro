using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Validators
{
    /// <summary>
    /// Necessário para evitar erros no Realm
    /// </summary>
    public class NonValidatingValidator : IObjectModelValidator
    {
        public void Validate(ActionContext actionContext, ValidationStateDictionary validationState, string prefix, object model)
        {
        }
    }
}
