const { AbstractExample } = require('./abstractExample');

class DerivedClass extends AbstractExample {
    doSomething() {
        console.log("Haciendo algo en Derived3");
    }
}

module.exports = { DerivedClass };