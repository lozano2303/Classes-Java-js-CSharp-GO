using Example1;
using Example2;
using Example3;
using Example4;
using Example5;

// Ejemplo 1: constructor por defecto, implementa interfaz
var obj1 = new Example1.ExampleClass();
obj1.PerformAction();
var derived1 = new Example1.DerivedClass();
derived1.DoSomething();

// Ejemplo 2: constructor parametrizado, no implementa interfaz
var obj2 = new Example2.ExampleClass("Test");
var derived2 = new Example2.DerivedClass();
derived2.DoSomething();

// Ejemplo 3: constructor estatico, implementa
var obj3 = new Example3.ExampleClass();
obj3.PerformAction();
var derived3 = new Example3.DerivedClass();
derived3.DoSomething();

// Ejemplo 4: constructor de copia, no implementa interfaz
var obj4 = new Example4.ExampleClass();
var derived4 = new Example4.DerivedClass();
derived4.DoSomething();

// Ejemplo 5: constructor con múltiples parámetros, implementa
var obj5 = new Example5.ExampleClass("Test", 25);
obj5.PerformAction();
var derived5 = new Example5.DerivedClass();
derived5.DoSomething();

Console.WriteLine("Ejemplos completados");
