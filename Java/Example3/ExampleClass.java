package Example3;

public class ExampleClass implements IExample {
    private String name;

    static {
        System.out.println("Bloque estatico en Example3");
    }

    // Implementación de interfaz - cuando la interfaz es implementada
    @Override
    public void performAction() {
        System.out.println("Accion realizada en Example3");
    }
}