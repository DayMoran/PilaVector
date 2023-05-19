using PilaVector;
int op;
Console.WriteLine("Pila con Vector");
Console.WriteLine("******************************");
Console.WriteLine("1.Crear Pila.");
Console.WriteLine("2.Agregar elemento a la Pila.");
Console.WriteLine("3.Sacar Elemento de la Pila.");
Console.WriteLine("4.Mostrar Pila.");
Console.WriteLine("5.Limpiar Pila");
Console.WriteLine("6.Contar elementos.");
Console.WriteLine("7.Elemento Mayor");
Console.WriteLine("8.Elemento menor");
Console.WriteLine("9.Salir");
Console.WriteLine("******************************");

Pila miPila = null;
do
{
    Console.WriteLine("Ingrese una opcion: ");
    op = int.Parse(Console.ReadLine());
    switch (op)
    {
        case 1:
            Console.WriteLine("Ingrese el tamaño de la pila:");
            int tam = int.Parse(Console.ReadLine());
            miPila = new Pila(tam);
            Console.WriteLine("Se creo la pila.");            
            break;

        case 2:
            if (miPila != null)
            {
                
                if (miPila.pilaLlena())
                {
                    Console.WriteLine("La pila esta llena.");
                }
                else
                {
                    Console.WriteLine("Ingrese el elemento a agregar:");
                    int elemento = int.Parse(Console.ReadLine());
                    miPila.push(elemento);
                    Console.WriteLine("Elemento agregado correctamente.");
                }
                
            }
            else
            {
                Console.WriteLine("Debe crear una Pila primero.");                
            }
            break;

        case 3:
            if (miPila != null)
            {
                int dato = miPila.pop();
                if (dato != -1)
                {
                    Console.WriteLine("Elemento sacado de la pila: {0}", dato);
                }
            }
            else
            {
                Console.WriteLine("Debe crear una pila primero.");
            }
            break;

        case 4:
            if (miPila != null)
            {
                Console.WriteLine("Contenido de la pila:");
                miPila.muestraPila();
            }
            else
            {
                Console.WriteLine("Debe crear una pila primero.");
            }
            break;
        case 5:
            if (miPila != null)
            {
                miPila.LimpiarPila();
            }
            else
            {
                Console.WriteLine("Debe crear una pila primero.");
            }
            break;
        case 6:
            if (miPila != null)
            {
                miPila.ContarElementos();
            }
            else
            {
                Console.WriteLine("Debe crear una pila primero.");
            }
            break;
        case 7:
            if (miPila != null)
            {
                miPila.MostrarElementoMayor();
            }
            else
            {
                Console.WriteLine("Debe crear una pila primero.");
            }
            break;
        case 8:
            if (miPila != null)
            {
                miPila.MostrarElementoMenor();
            }
            else
            {
                Console.WriteLine("Debe crear una pila primero.");
            }
            break;
        case 9:
            Console.WriteLine("Programa terminado.");
            break;

        default:
            Console.WriteLine("Opción no válida. Intente nuevamente.");
            break;
    }


} while(op != 9);






    
