namespace CSharp
{
    public class ExampleClass : IExample
    {
        public string Name { get; set; }

        // Constructor por defecto - sin parámetros, inicializa con valores por defecto
        public ExampleClass()
        {
            Name = "Default";
        }

        // Constructor parametrizado - acepta parámetros para inicializar objeto
        public ExampleClass(string name)
        {
            Name = name;
        }

        // Constructor estático - llamado una vez antes de crear cualquier instancia
        static ExampleClass()
        {
            // Inicialización estática
        }

        // Constructor de copia - crea una copia de otra instancia
        public ExampleClass(ExampleClass other)
        {
            Name = other.Name;
        }

        // Implementación de interfaz - cuando la interfaz es implementada
        public void PerformAction()
        {
            // Implementación aquí
        }
    }
}