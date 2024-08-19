using Beaver.Domain.Common;
using Beaver.Domain.Enums;

namespace Beaver.Domain.Entities
{
    public class Input : BaseEntity
    {
        public Input(TypesOfInputs type, string title, int order, bool required, Option[]? options)
        {
            Type = type;
            Title = title;
            Order = order;
            Required = required;
            Options = options;

            DateCreated = DateTime.Now;
        }

        public TypesOfInputs Type { get; private set; }
        public string Title { get; private set; }
        public bool Required { get; private set; }
        public int Order { get; private set; }
        public Option[]? Options { get; private set; }

        public Form Form { get; private set; }
    }
}
