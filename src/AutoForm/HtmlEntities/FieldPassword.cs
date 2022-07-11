using DotCreative.Services.AutoForm.Enums;

namespace DotCreative.Services.AutoForm.HtmlEntities
{
  public class FieldPassword : FieldAttribute
  {
    public FieldPassword() : base(EFieldTypes.Password)
    {

    }

    public FieldPassword(string name) : base(name, EFieldTypes.Password)
    {

    }
  }
}