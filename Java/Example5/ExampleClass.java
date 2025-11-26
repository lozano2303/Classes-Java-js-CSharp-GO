package Example5;

public class ExampleClass implements IExample {
    private String name;
    private int age;

    // Constructor con múltiples parámetros
    public ExampleClass(String name, int age) {
        this.name = name;
        this.age = age;
    }

    // Implementación de interfaz - cuando la interfaz es implementada
    @Override
    public void performAction() {
        System.out.println("Accion realizada en Example5");
    }
}