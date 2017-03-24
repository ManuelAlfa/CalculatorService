# CalculatorService
repositorio para el calculator de ejemplo en vass
README DE APLICACION DE CALCULO PARA VASS

Realización:
-El programa esta realizado con visualStudio15 Community.

Contenido:
-Es una aplicación web, para realizar operaciones de calculo, con una sola pagina html, que presenta un sencillo interfaz:
 Para operaciones básicas (suma, resta, multiplicación, división) presenta dos controles de entrada de datos y un control de resultado.
Para la raíz cuadrada presenta otro control de entrada y el anterior de resultado.

Funcionamiento:
-La ejecución de la aplicación se realiza a través de la invocación de la función $Ajax, al pulsar sobre el botón de operación correspondiente;  del método apropiado a cada operación, definido en un servicio REST, alojado en un controlador API: (/Controllers/CalculatorControler.cs) 

-Se realizan varias validaciones:
Que no se intente una operación binaria con un solo término
Que no se introduzcan caracteres no numéricos,
Que no se use el ‘0’ para operar.

-La primera ejecución llama al equivoco, porque tarda bastante y parece que no funciona, pero si que lo hace.

Observaciones:(importante) 

-En los requerimientos, se pedía un tracking de las operaciones de la api .
Lo cierto es que es un tema , que cuando lo he encontrado con anterioridad, se resolvía con volcados a Logs de texto desde el momento posterior de la ejecución del método.

-Como parece que se pedía otra cosa más automática, busque por internet información, encontrando un código que parece ser transparente y que funciona con eficacia.

-Esta descrito en fichero ‘ApiLogEntry.cs’ y en una entrada que parece que necesita en el método Application.Start del Global.asax:
_
 GlobalConfiguration.Configuration.MessageHandlers.Add(new ApiLogHandler());

-NOTA:  posteriormente al envío de la prueba pude constatar, que el código de ApiLogEntry, carga un objeto de forma transparente  cada vez que se ejecuta una petición api, necesitaria crear un código de persistencia, para almacenar los resultados de ese objeto en BBDD (Se pedía en los requerimientos evitar crearlas).

REPOSITORIO GITHUB:
El repositorio Github ya esta creado y tiene la siguiente dirección:

ManuelAlfa/CalculatorService

-Bueno eso es todo, espero que no es de problemas y se ejecute bien.

Saludos.


