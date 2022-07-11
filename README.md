# AutoForm
O projeto **AutoForm** nasceu a partir da iniciativa de se criar uma implementação fácil para geração de formulários html dinamicamente. _É um projeto experimental_.

O objetivo é criar campos com base em entidades de domínio ou DTOs anotadas com atributos específicos. Veja um exemplo abaixo:

```
[Form(Action = "//api.dominio.com.br", Method = Method.POST)]
public class People {

    [Input(Type=Type.Text, Label = "Nome:")]
    public string Name { get; set; }

    [Input(Type=Type.Text, Label = "Address:")]
    public string Address { get; set; }

    [Input(Type=Type.Radio, Label = "Sexo:")]
    public EGender Gender { get; set; }
}
```

O resultado será um arquivo Json com as definições acima. O objetivo inicial é implementar para VueJS sendo possível também utilizá-lo em outros frameworks frontend.