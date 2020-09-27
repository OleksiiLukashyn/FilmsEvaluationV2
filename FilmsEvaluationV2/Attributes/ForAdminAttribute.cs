using FilmsEvaluationV2.Filters;
using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace FilmsEvaluationV2.Attributes
{
    public class ForAdminAttribute : Attribute, IFilterFactory
    {
        public IFilterMetadata CreateInstance(IServiceProvider serviceProvider) =>
            new ForAdminFilter();

        public bool IsReusable => false;
    }
}
