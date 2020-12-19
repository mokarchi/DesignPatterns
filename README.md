# DesignPatterns
Design patterns are solutions to recurring problems
# Types of Design Patterns
 
* [Creational Patterns]
* [Structural Patterns](#Structural-Patterns)
  * [Composite](#Composite)
  * [Adapter](#Adapter)
  * [Decorator](#Decorator)
  * [Facade](#Facade)
  * [Bridge](#Bridge)
  * [Flyweight](#Flyweight)
* [Behavioral Patterns](#Behavioral-Patterns)
  * [Memento](#memento)
  * [State](#state)
  * [Iterator](#iterator)
  * [Strategy](#strategy)
  * [Template Method](#Template-Method)
  * [Command](#Command)
  * [Observer](#Observer)
  * [Mediator](#Mediator)
  * [Chain of Responsibility](#Chain-of-Responsibility)
  * [Visitor](#Visitor)

## Structural Patterns

### Composite
Compose objects into tree structures to represent part-whole hierarchies. Composite lets clients treat individual objects and compositions of objects uniformly. 
<p align="center">
  <img src="https://www.dofactory.com/img/diagrams/net/composite.gif" />
</p>

### Adapter
Convert the interface of a class into another interface clients expect. Adapter lets classes work together that couldn't otherwise because of incompatible interfaces.
<p align="center">
  <img src="https://www.dofactory.com/img/diagrams/net/adapter.gif" />
</p>

### Decorator
Attach additional responsibilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extending functionality.
<p align="center">
  <img src="https://www.dofactory.com/img/diagrams/net/decorator.gif" />
</p>

### Facade
Provide a unified interface to a set of interfaces in a subsystem. Façade defines a higher-level interface that makes the subsystem easier to use. 
<p align="center">
  <img src="https://www.dofactory.com/img/diagrams/net/facade.gif" />
</p>

### Bridge
Decouple an abstraction from its implementation so that the two can vary independently. 
<p align="center">
  <img src="https://www.dofactory.com/img/diagrams/net/bridge.gif" />
</p>

### Flyweight
Use sharing to support large numbers of fine-grained objects efficiently. 
<p align="center">
  <img src="https://www.dofactory.com/img/diagrams/net/flyweight.gif" />
</p>

## Behavioral Patterns

### Memento
Memento is a behavioral design pattern that lets you save and restore the previous state of an object without revealing the details of its implementation.
<p align="center">
  <img src="https://www.dofactory.com/img/diagrams/net/memento.gif" />
</p>

### State
Allow an object to alter its behavior when its internal state changes. The object will appear to change its class.
<p align="center">
  <img src="https://www.dofactory.com/img/diagrams/net/state.gif" />
</p>

### Iterator
Iterator is a behavioral design pattern that lets you traverse elements of a collection without exposing its underlying representation (list, stack, tree, etc.).
<p align="center">
  <img src="https://www.dofactory.com/img/diagrams/net/iterator.gif" />
</p>

### Strategy
Define a family of algorithms, encapsulate each one, and make them interchangeable. Strategy lets the algorithm vary independently from clients that use it.
<p align="center">
  <img src="https://www.dofactory.com/img/diagrams/net/strategy.gif" />
</p>

### Template Method
Define the skeleton of an algorithm in an operation, deferring some steps to subclasses. Template Method lets subclasses redefine certain steps of an algorithm without changing the algorithm's structure. 
<p align="center">
  <img src="https://www.dofactory.com/img/diagrams/net/template.gif" />
</p>

### Command
Encapsulate a request as an object, thereby letting you parameterize clients with different requests, queue or log requests, and support undoable operations. 
<p align="center">
  <img src="https://www.dofactory.com/img/diagrams/net/command.gif" />
</p>

### Observer
Define a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically.
<p align="center">
  <img src="https://www.dofactory.com/img/diagrams/net/observer.gif" />
</p>

### Mediator
Define an object that encapsulates how a set of objects interact. Mediator promotes loose coupling by keeping objects from referring to each other explicitly, and it lets you vary their interaction independently.
<p align="center">
  <img src="https://www.dofactory.com/img/diagrams/net/mediator.gif" />
</p>

### Chain of Responsibility
Avoid coupling the sender of a request to its receiver by giving more than one object a chance to handle the request. Chain the receiving objects and pass the request along the chain until an object handles it.
<p align="center">
  <img src="https://www.dofactory.com/img/diagrams/net/chain.gif" />
</p>

### Visitor
Represent an operation to be performed on the elements of an object structure. Visitor lets you define a new operation without changing the classes of the elements on which it operates. 
<p align="center">
  <img src="https://www.dofactory.com/img/diagrams/net/visitor.gif" />
</p>
