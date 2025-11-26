class AbstractExample {
    doSomething() {
        throw new Error("Must implement doSomething");
    }
}

module.exports = { AbstractExample };