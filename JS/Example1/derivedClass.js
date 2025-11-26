const { AbstractExample } = require('./abstractExample');

class DerivedClass extends AbstractExample {
    doSomething() {
        console.log("Haciendo algo en Derived1");
    }
}

module.exports = { DerivedClass };