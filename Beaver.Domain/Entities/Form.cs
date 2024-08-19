using Beaver.Domain.Common;
using Beaver.Domain.Enums;

namespace Beaver.Domain.Entities
{
    public class Form : BaseEntity
    {
        public Form(string name, string description, bool? publicForm)
        {
            Name = name;
            Description = description;
            PublicForm = publicForm ?? true;

            Type = TypesOfForms.Default;
            DateCreated = DateTime.Now;
        }

        public TypesOfForms Type { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public bool PublicForm { get; private set; }
        public Input[] Inputs { get; private set; }
    }
}
