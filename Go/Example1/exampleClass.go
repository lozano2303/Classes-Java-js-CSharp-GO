package example1

import "fmt"

type ExampleClass struct {
    Name string
}

func NewExampleClass() *ExampleClass {
    return &ExampleClass{Name: "Default"}
}

func (e *ExampleClass) PerformAction() {
    fmt.Println("Accion realizada en Example1")
}