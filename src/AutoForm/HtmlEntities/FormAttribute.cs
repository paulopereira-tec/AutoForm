namespace DotCreative.Services.AutoForm.HtmlEntities
{
  [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
  public class FormAttribute : AbstractAttribute
  {
    public string Action { get; set; }

    public FormAttribute(string action)
    {
      Action = action;
    }
  }
}
