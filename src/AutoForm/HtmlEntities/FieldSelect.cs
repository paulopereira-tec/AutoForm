using DotCreative.Services.AutoForm.Enums;

namespace DotCreative.Services.AutoForm.HtmlEntities
{
  public class FieldSelect : FieldAttribute
  {
    public FieldSelect(string name) : base(name, EFieldTypes.Select)
    {
    }

    public FieldSelect(string name, string isOptionFor) : base(name, EFieldTypes.Select)
    {
      IsOptionFor = isOptionFor;
    }

    public string PropertyId { get; set; }
    public string PropertyName { get; set; }
    public string IsOptionFor { get; set; }

  }
}