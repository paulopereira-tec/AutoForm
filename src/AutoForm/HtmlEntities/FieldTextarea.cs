using DotCreative.Services.AutoForm.Enums;

namespace DotCreative.Services.AutoForm.HtmlEntities
{
  public class FieldTextarea : FieldAttribute
  {
    public FieldTextarea() : base(EFieldTypes.Textarea)
    {

    }

    public FieldTextarea(string name) : base(name, EFieldTypes.Textarea)
    {

    }
  }
}