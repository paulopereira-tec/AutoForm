using DotCreative.Services.AutoForm.Enums;

namespace DotCreative.Services.AutoForm.HtmlEntities
{
  public class FieldDate : FieldAttribute
  {
    public FieldDate() : base(EFieldTypes.Date)
    {

    }

    public FieldDate(string name) : base(name, EFieldTypes.Date)
    {

    }
  }
}