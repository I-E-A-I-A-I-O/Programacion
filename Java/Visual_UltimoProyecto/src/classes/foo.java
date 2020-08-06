package classes;

public class foo
{
    @annotation(Id = "Nombre", Description = "Jesus", IsPk = false)
    private String field1;
    @annotation(Id = "Apellido", Description = "Molina", IsPk = false)
    private String field2;
    @annotation(Id = "Cedula", Description = "27847829", IsPk = true)
    private  String field3;

    public foo()
    {

    }

    public String GetFName()
    {
        return field1;
    }

    public void SetFName(String NewValue)
    {
        field1 = NewValue;
    }

    public String GetLName()
    {
        return field2;
    }

    public void SetLName(String NewValue)
    {
        field2 = NewValue;
    }

    public String GetId()
    {
        return field3;
    }

    public void SetId(String NewValue)
    {
        field3 = NewValue;
    }

    public void PrintFields()
    {
        System.out.println(field1 + " " + field2 + " " + field3);
    }
}
