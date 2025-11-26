namespace Example3
{
    public class ExampleClass : IExample
    {
        public string Name { get; set; }

        // Constructor estático - llamado una vez antes de crear cualquier instancia
        static ExampleClass()
        {
            Console.WriteLine("Constructor estatico en Example3");
        }

        // Implementación de interfaz - cuando la interfaz es implementada
        public void PerformAction()
        {
            Console.WriteLine("Accion realizada en Example3");
        }
    }
}