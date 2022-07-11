namespace DotCreative.Services.AutoForm.HtmlEntities
{
  [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
  public class FormGroupAttribute : AbstractAttribute
  {
    public FormGroupAttribute()
    {
    }

    public FormGroupAttribute(string displayName)
    {
      DisplayName = displayName;
    }


  }
}
