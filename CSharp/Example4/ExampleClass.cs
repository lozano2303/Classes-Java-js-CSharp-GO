namespace Example4
{
    public class ExampleClass // no implementa interfaz - cuando no es implementada
    {
        public string Name { get; set; }

        // Constructor por defecto
        public ExampleClass()
        {
            Name = "Default4";
        }

        // Constructor de copia - crea una copia de otra instancia
        public ExampleClass(ExampleClass other)
        {
            Name = other.Name;

        }
    }
}