namespace Example5
{
    public class ExampleClass : IExample
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor con múltiples parámetros
        public ExampleClass(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Implementación de interfaz - cuando la interfaz es implementada
        public void PerformAction()
        {
            Console.WriteLine("Accion realizada en Example5");
        }
    }
}