using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {   //Crear los nodos con todos los integrantes de la familia:
            Node abuelaM= new Node(new Person("Abuela Materna",70));
            Node abueloM=new Node(new Person("Abuelo Materno",80));
            Node madre=new Node(new Person("Madre",45));
            Node abuelaP=new Node(new Person("Abuela Paterna", 75));
            Node abueloP =new Node(new Person("Abuelo Paterno", 85));
            Node padre=new Node(new Person("Padre", 50));
            Node hijo1=new Node(new Person("Hijo 1", 20));
            Node hijo2=new Node(new Person("Hijo 2", 17));

            Node familiaMaterna=new Node(null); //Crea la familia materna
            familiaMaterna.AddChildren(abuelaM);
            familiaMaterna.AddChildren(abueloM);
            familiaMaterna.AddChildren(madre);
            Node familiaPaterna = new Node(null); //Crea la familia paterna
            familiaPaterna.AddChildren(abuelaP);
            familiaPaterna.AddChildren(abueloP);
            familiaPaterna.AddChildren(padre);
            Node familiaCompleta = new Node(null); //une las dos familias y suma a los hijos
            familiaCompleta.AddChildren(familiaMaterna);
            familiaCompleta.AddChildren(familiaPaterna);
            familiaCompleta.AddChildren(hijo1);
            familiaCompleta.AddChildren(hijo2);

            //Acceder al árbol:
            Console.WriteLine("Nombre del abuelo materno: " + familiaMaterna.Children[1].Person.Name);
            Console.WriteLine("Nombre de la madre: " + madre.Person.Name);

            //Uso del patrón Visitor para calcular la edad de todos los integrantes:
            AgeVisitor ageVisitor= new AgeVisitor();
            familiaCompleta.Accept(ageVisitor); 
            int totalAge=ageVisitor.Age;
            Console.WriteLine($"suma de las edades de todos los integrantes de la familia:  {totalAge}");//442

            //Saber cual es el hijo mas grande a traves del metodo visitor:

            ChildVisitor childVisitor=new ChildVisitor();
            familiaCompleta.Accept(childVisitor);
            Person child=childVisitor.Child;
            Console.WriteLine($"el hijo mas grande es {child.Name} y tiene {child.Age} años");

            //Saber quien tiene el nombre mas largo:
            NameVisitor nameVisitor=new NameVisitor();
            familiaCompleta.Accept(nameVisitor);
            string longestName=nameVisitor.LongestName;
            Console.WriteLine($"El nombre mas largo es : {longestName}");
        }
    }
} 
