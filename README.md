# Programacion
Proyectos de programacion Realizados por Jesus Molina para la materia Programacion Visual.


PROYECTO 4

El componente de conexion a base de datos se compila en un .dll y se referencia en el programa final para ser utilizado en las diferentes operaciones de base de datos. El .dll puede ser encontrado en el .rar del ejecutable, tambien dentro de una de las carpetas del codigo del componente por el nombre DB_Component.dll

Para conectarse a una base de datos se crea un connection string en el archivo de configuracion del programa. Luego se ejecuta el comando del db component "LoadPool" en el cual se pasa como parametro la id que se le dio al connection string dentro del archivo de configuracion. ej: dbComponent.LoadPool("Database1").

En el comando GetSentence, uno de los parametros es el nombre de la tabla en la que se va a trabajar, me parecio util para una DB con mas de una tabla.


PROYECTO 5

El programa fue hecho de tal manera de que se pueda editar el valor maximo que pueden alcanzar las barras sin necesidad de tener que editar todo el codigo, simplemente se cambia dicho valor directamente. Fuera de eso no hay mucho que comentar, hace lo que se pidio.
