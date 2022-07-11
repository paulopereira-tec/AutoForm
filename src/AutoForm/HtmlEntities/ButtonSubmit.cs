using DotCreative.Services.AutoForm.Enums;

namespace DotCreative.Services.AutoForm.HtmlEntities
{
  public class ButtonSubmit : FieldAttribute
  {
    public ButtonSubmit() : base(EFieldTypes.Submit)
    {

    }

    public ButtonSubmit(string name) : base(name, EFieldTypes.Submit)
    {

    }
  }
}