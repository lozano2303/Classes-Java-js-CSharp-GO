package example5

import "fmt"

type DerivedClass struct {
    // ExtraAttribute int
}

func (d *DerivedClass) DoSomething() {
    fmt.Println("Haciendo algo en Derived5")
}