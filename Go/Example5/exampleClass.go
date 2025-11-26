package example5

import "fmt"

type ExampleClass struct {
    Name string
    Age  int
}

func NewExampleClass(name string, age int) *ExampleClass {
    return &ExampleClass{Name: name, Age: age}
}

func (e *ExampleClass) PerformAction() {
    fmt.Println("Accion realizada en Example5")
}