# creacionTerminators
Desarrollo de una aplicacion C# que permite emular el funcionamiento del sistema de creación de
máquinas SkyNet de la pelicula Terminator

# Para lo cual:
1 Crear un Class Library que incluya el Namespace DTO y, dentro de él, la Clase Terminator, que
debe incluir los atributos descritos en el módulo de ingreso.

2 Implementar las operaciones de ingreso, búsqueda y listado de Terminators en base a la siguiente
lógica de negocios, dentro de una Aplicación de Consola C#:
Crear un menú de acceso de la aplicación que permita:

• Ingresar Terminator
• Buscar Terminator
• Mostrar Terminators

# 1 Ingreso de Terminator:

Número de Serie (String): Corresponde a un código identificador único del Terminator, debe
tener un largo de 7 caracteres y no puede existir otro igual. En el caso de que exista otro
Terminator con el mismo Número de Serie, el sistema debe solicitar un nuevo número de serie.

Tipo (String Tipo): Puede ser alguno de los siguientes:
a) T-1
b) T-800
c) T-1000
d) T-3000

PrioridadBase (int) : prioridad de ejecución de un objetivo cuando el
mismo es distinto a Sarah Connor

Objetivo (String): Corresponde al principal objetivo a eliminar del Terminator, en el caso de
que el objetivo sea Sarah Connor, el atributo prioridad del Terminator debe ser definida como
999, sino debe ser definida por la prioridad base

Año de Destino (Int32): Valor mayor 1997 (El cual corresponde a la fecha de creación de
SkyNet por CyberDyne) y menor que 3000
Considerar el ingreso de todos sus atributos como obligatorio. En el caso de que alguno de los atributos
no sea ingresado apropiadamente, el sistema debe solicitarlo nuevamente.
Una vez ingresado todos los datos requeridos, el sistema debe agregar el nuevo Terminator mediante el
DAL definido en la Clase Principal

# 2 Buscar Terminator
El usuario debe ingresar el modelo y año de un posible Terminator y el sistema debe mostrar todos los
Terminators que tengan ese modelo y año de destino, con la estructura Número de Serie + “ “ + Tipo + “ “ + objetivo.

# 3 Mostrar Terminators
Al ingresar a este menú, debe mostrar los datos de todos los Terminators, con la estructura ya descrita en
el punto 2.
