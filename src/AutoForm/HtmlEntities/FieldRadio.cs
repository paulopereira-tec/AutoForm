using DotCreative.Services.AutoForm.Enums;

namespace DotCreative.Services.AutoForm.HtmlEntities
{
  public class FieldRadio : FieldAttribute
  {
    public FieldRadio() : base(EFieldTypes.Radio)
    {

    }

    public FieldRadio(string name) : base(name, EFieldTypes.Radio)
    {

    }
  }
}