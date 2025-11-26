package example3

import "fmt"

type ExampleClass struct {
    Name string
}

func NewExampleClass() *ExampleClass {
    fmt.Println("Bloque estatico en Example3")
    return &ExampleClass{Name: "Default"}
}

func (e *ExampleClass) PerformAction() {
    fmt.Println("Accion realizada en Example3")
}