using DotCreative.Services.AutoForm.Enums;

namespace DotCreative.Services.AutoForm.HtmlEntities
{
  public class FieldCheckbox : FieldAttribute
  {
    public FieldCheckbox() : base(EFieldTypes.Checkbox)
    {

    }

    public FieldCheckbox(string name) : base(name, EFieldTypes.Checkbox)
    {

    }
  }
}