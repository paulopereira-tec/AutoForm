using DotCreative.Services.AutoForm.Enums;

namespace DotCreative.Services.AutoForm.HtmlEntities
{
  public class ButtonReset : FieldAttribute
  {
    public ButtonReset() : base(EFieldTypes.Reset)
    {

    }

    public ButtonReset(string name) : base(name, EFieldTypes.Reset)
    {

    }
  }
}