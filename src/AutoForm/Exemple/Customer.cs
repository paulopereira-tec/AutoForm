using DotCreative.Services.AutoForm.CssGridExtend;
using DotCreative.Services.AutoForm.HtmlEntities;

namespace DotCreative.Services.AutoForm.Exemple;

[Form("https://localhost/teste")]
public class Customer
{
  [FieldHidden, ColumnGrid(12)]
  public int Id { get; set; }

  [FieldText("Nome completo"), ColumnGrid(6)]
  public string Name { get; set; }

  [FieldDate("Data de nascimento"), ColumnGrid(3)]
  public DateTime BirthDay { get; set; }

  [FieldRadio("Sexo"), ColumnGrid(3)]
  public EGender Gender { get; set; }

  [FieldTextarea("Observações"), ColumnGrid(12)]
  public string Note { get; set; }

  [FieldCheckbox("Aceito os termos de uso", CssClass = "checkbox"), ColumnGrid(12)]
  public bool AcceptTerms { get; set; }

  [FormGroup("Endereço"), RowGrid]
  public Address Address { get; set; }
}
