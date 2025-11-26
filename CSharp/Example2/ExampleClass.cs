namespace Example2
{
    public class ExampleClass // no implementa interfaz - cuando no es implementada
    {
        public string Name { get; set; }

        // Constructor parametrizado - acepta parámetros para inicializar objeto
        public ExampleClass(string name)
        {
            Name = name;
        }
    }
}