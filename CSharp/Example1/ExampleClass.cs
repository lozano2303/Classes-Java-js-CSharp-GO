namespace Example1
{
    public class ExampleClass : IExample
    {
        public string Name { get; set; }

        // Constructor por defecto - sin parámetros, inicializa con valores por defecto
        public ExampleClass()
        {
            Name = "Default";
        }

        // Implementación de interfaz - cuando la interfaz es implementada
        public void PerformAction()
        {
            Console.WriteLine("Accion realizada en Example1");
        }
    }
}