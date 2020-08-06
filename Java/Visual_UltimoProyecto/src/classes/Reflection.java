package classes;

import java.lang.annotation.Annotation;
import java.lang.reflect.*;

public class Reflection
{
    public static void main(String[] args)
    {
        Class<foo> cs;
        Field[] fields;
        Annotation[] ann;
        try
        {
            cs = (Class<foo>) Class.forName("classes.foo");
            fields = cs.getDeclaredFields();
            foo Instance = cs.getDeclaredConstructor().newInstance();
            for (Field field : fields)
            {
                ann = field.getAnnotations();
                if (ann[0].toString().contains("Id=\"Nombre\""))
                {
                    Instance.SetFName(ann[0].toString().split("Description=\"")[1].split("\"")[0]);
                }
                else if(ann[0].toString().contains("Id=\"Apellido\""))
                {
                    Instance.SetLName(ann[0].toString().split("Description=\"")[1].split("\"")[0]);
                }
                else if (ann[0].toString().contains("Id=\"Cedula\""))
                {
                    Instance.SetId(ann[0].toString().split("Description=\"")[1].split("\"")[0]);
                }
                else
                {
                    System.out.println("Annotation not found.");
                }
            }
            System.out.println("Class fields values: ");
            Instance.PrintFields();
            System.out.println("Fields annotations: ");
            for (Field field: fields)
            {
                ann = field.getAnnotations();
                System.out.println(ann[0]);
            }
        } catch (ClassNotFoundException e)
        {
            System.out.println("not found");
        } catch (NoSuchMethodException | InvocationTargetException | InstantiationException | IllegalAccessException e) {
            e.printStackTrace();
        }
    }
}
