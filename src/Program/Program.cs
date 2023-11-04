using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instancias de personas: 
            Person abuelaM= new Person("Abuela Materna", 70);
            Person abueloM= new Person("Abuelo Materno",80);
            Person madre= new Person("Madre", 45);
            Person padre=new Person("Padre",50);
            Person abueloP=new Person("Abuelo Paterno", 60);
            Person abuelaP= new Person("Abuela Paterna",57);
            Person hijo1= new Person("Hijo 1", 20);
            Person hijo2=new Person("Hijo 2", 17);

            //Instancias de nodos:
            Node abuela1=new Node(abuelaM);
            Node abuelo1=new Node(abueloM);
            Node abuela2=new Node(abuelaP);
            Node abuelo2=new Node(abueloP);
            Node Madre=new Node (madre);
            Node Padre=new Node (padre);
            Node Hijo1=new Node (hijo1);
            Node Hijo2=new Node (hijo2);
            
            //Crea los distintos nodos para el arbol genealogico :
            abuela1.AddChildren(Madre);
            abuelo1.AddChildren(Madre);
            abuela2.AddChildren(Padre);
            abuelo2.AddChildren(Padre);
            Madre.AddChildren(Hijo1);
            Padre.AddChildren(Hijo1);
            Madre.AddChildren(Hijo2);
            Padre.AddChildren(Hijo2);

            //Acceder al arbol:
            Console.WriteLine("Nombre del abuelo materno: " + abuelo1.Person.Name);
            Console.WriteLine("Nombre de la madre: " + abuela1.Children[0].Person.Name);

            //Uso del patrón Visitor:
            AgeVisitor ageVisitor= new AgeVisitor();
            abuela1.Accept(ageVisitor); 
            int totalAge=ageVisitor.Age;
            Console.WriteLine($"suma de las edades de todos los integrantes de la familia {totalAge}");
        }
    }
}
