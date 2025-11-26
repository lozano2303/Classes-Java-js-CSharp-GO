package example2

type ExampleClass struct {
    Name string
}

func NewExampleClass(name string) *ExampleClass {
    return &ExampleClass{Name: name}
}