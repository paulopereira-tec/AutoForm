using DotCreative.Services.AutoForm.Enums;

namespace DotCreative.Services.AutoForm.HtmlEntities
{
  [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
  public class FieldAttribute : AbstractAttribute
  {
    public string FieldName { get; set; }
    public EFieldTypes Type { get; set; }

    public bool Hidden
    {
      get
      {
        return Type == EFieldTypes.Hidden ? true : false;
      }
      set
      {
        Type = value is true ? EFieldTypes.Hidden : EFieldTypes.Text;
      }
    }

    public FieldAttribute(string fieldName, EFieldTypes type)
    {
      FieldName = fieldName;
      Type = type;
    }

    public FieldAttribute(string fieldName)
    {
      FieldName = fieldName;
    }

    public FieldAttribute(EFieldTypes type)
    {
      Type = type;
    }
  }
}