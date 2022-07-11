using DotCreative.Services.AutoForm.Enums;

namespace DotCreative.Services.AutoForm.HtmlEntities
{
  public class FieldText : FieldAttribute
  {
    public FieldText() : base(EFieldTypes.Text)
    {

    }

    public FieldText(string name) : base(name, EFieldTypes.Text)
    {

    }
  }
}