using FilmsEvaluationV2.Models.Enums;
using System;

namespace FilmsEvaluationV2.Models
{
    public class Person
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public Gender Gender { set; get; }
        public DateTime Born { set; get; }
        public string Description { set; get; }
    }
}
