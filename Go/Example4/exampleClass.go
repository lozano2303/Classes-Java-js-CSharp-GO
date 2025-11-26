package example4

type ExampleClass struct {
    Name string
}

func NewExampleClass(other *ExampleClass) *ExampleClass {
    return &ExampleClass{Name: other.Name}
}