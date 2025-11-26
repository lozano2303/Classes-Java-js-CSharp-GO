package Example1;

public class ExampleClass implements IExample {
    private String name;

    // Constructor por defecto - sin parámetros, inicializa con valores por defecto
    public ExampleClass() {
        this.name = "Default";
    }

    // Implementación de interfaz - cuando la interfaz es implementada
    @Override
    public void performAction() {
        System.out.println("Accion realizada en Example1");
    }
}