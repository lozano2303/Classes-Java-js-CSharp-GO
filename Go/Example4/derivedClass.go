package example4

import "fmt"

type DerivedClass struct {
    // ExtraAttribute int
}

func (d *DerivedClass) DoSomething() {
    fmt.Println("Haciendo algo en Derived4")
}