const { AbstractExample } = require('./abstractExample');

class DerivedClass extends AbstractExample {
    doSomething() {
        console.log("Haciendo algo en Derived2");
    }
}

module.exports = { DerivedClass };