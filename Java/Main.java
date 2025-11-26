public class Main {
    public static void main(String[] args) {
        // Ejemplo 1
        Example1.ExampleClass obj1 = new Example1.ExampleClass();
        obj1.performAction();
        Example1.DerivedClass derived1 = new Example1.DerivedClass();
        derived1.doSomething();

        // Ejemplo 2
        Example2.ExampleClass obj2 = new Example2.ExampleClass("Test");
        Example2.DerivedClass derived2 = new Example2.DerivedClass();
        derived2.doSomething();

        // Ejemplo 3
        Example3.ExampleClass obj3 = new Example3.ExampleClass();
        obj3.performAction();
        Example3.DerivedClass derived3 = new Example3.DerivedClass();
        derived3.doSomething();

        // Ejemplo 4
        Example4.ExampleClass obj4_temp = new Example4.ExampleClass();
        Example4.ExampleClass obj4 = new Example4.ExampleClass(obj4_temp);
        Example4.DerivedClass derived4 = new Example4.DerivedClass();
        derived4.doSomething();

        // Ejemplo 5
        Example5.ExampleClass obj5 = new Example5.ExampleClass("Test", 25);
        obj5.performAction();
        Example5.DerivedClass derived5 = new Example5.DerivedClass();
        derived5.doSomething();

        System.out.println("Ejemplos completados");
    }
}