using DotCreative.Services.AutoForm.Enums;

namespace DotCreative.Services.AutoForm.HtmlEntities
{
  public class FieldFile : FieldAttribute
  {
    public FieldFile() : base(EFieldTypes.File)
    {

    }

    public FieldFile(string name) : base(name, EFieldTypes.File)
    {

    }
  }
}