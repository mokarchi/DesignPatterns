### Abstract Factory

## Point to Remember:
* Abstract Factory Pattern provides an interface for creating families of related dependent objects without specifying their concrete classes.
* The Abstract Factory Pattern provides a way to encapsulate a group of individual factories that have a common theme without specifying their concrete classes.
* The abstract factory design pattern is merely an extension to the factory method pattern or factory pattern, which allows you to create objects without being concerned about the actual class of the object being created.
* Abstract means hiding some information and factory means which produces the products and pattern means a design. So, the Abstract Factory Pattern is a software design pattern that provides a way to encapsulate a group of individual factories that have a common theme. 

<p align="center">
  <img src="http://mokarchi.ir/git/AbstractFactory/c-users-pranaya-pictures-abstract-factory-design-1024x614.png" />
</p>
---
## When to use it Abstract Factory Design Pattern?
* When you want to create a set of related objects or dependent objects which must be used together.
* When the system should configure to work with multiple families of products.
* When the Concrete classes should be decoupled from the clients.
---
## Differences between Abstract Factory and Factory Method Design Pattern:
* Abstract Factory Design Pattern adds a layer of abstraction to the Factory Method Design Pattern
* The Abstract Factory design pattern implementation can have multiple factory methods
* Similar products of a factory implementation are grouped in Abstract factory
* The Abstract Factory Pattern uses object composition to decouple applications from specific implementations
* The Factory Method Pattern uses inheritance to decouple applications from specific implementations
