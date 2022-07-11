namespace DotCreative.Services.AutoForm.CssGridExtend;

public class ColumnGridAttribute: Attribute
{
  public int Column { get; private set; }

  public ColumnGridAttribute(int column)
  {
    Column = column;
  }
}
