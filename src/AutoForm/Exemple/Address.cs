using DotCreative.Services.AutoForm.CssGridExtend;
using DotCreative.Services.AutoForm.HtmlEntities;

namespace DotCreative.Services.AutoForm.Exemple;

public class Address
{
  [FieldHidden, ColumnGrid(12)]
  public int Id { get; set; }

  [FieldText("Logradouro"), ColumnGrid(12)]
  public string Street { get; set; }

  [FieldText("Bairro"), ColumnGrid(6)]
  public string Neighborhood { get; set; }
  
  [FieldSelect("Cidade", nameof(City), PropertyId = "Id", PropertyName = "Name"), ColumnGrid(6)]
  public IEnumerable<City> Cities { get; set; }
  public int City { get; set; }
  
  [FieldSelect("UF", nameof(State)), ColumnGrid(6)]
  public EAddressState States { get; set; }
  public int State { get; set; }
  
  [FieldText("CEP"), ColumnGrid(6)]
  public string Zipcode { get; set; }
  
  [FieldText("Complemento"), ColumnGrid(12)]
  public string Complement { get; set; }
}
