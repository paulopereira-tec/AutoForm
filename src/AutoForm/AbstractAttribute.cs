namespace DotCreative.Services.AutoForm;

public abstract class AbstractAttribute: Attribute
{
  public string DisplayName { get; set; }
  public string CssClass { get; set; }
  public string CssId { get; set; }
}
