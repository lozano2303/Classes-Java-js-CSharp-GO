package Example4;

public class ExampleClass { // no implementa interfaz - cuando no es implementada
    private String name;

    // Constructor por defecto
    public ExampleClass() {
        this.name = "Default4";
    }

    // Constructor de copia - crea una copia de otra instancia
    public ExampleClass(ExampleClass other) {
        this.name = other.name;
    }
}