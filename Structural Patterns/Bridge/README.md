### Bridge 
As per the Gang of Four definitions, the Bridge Pattern “Decouples an abstraction from its implementation so that the two can vary independently“.

In the bridge design pattern, there are 2 parts. The first part is the abstraction and the second part is the implementation. The bridge design pattern allows the abstraction and implementation to be developed independently and the client code can access only the abstraction part without being concerned about the implementation part.

The Bridge Design Pattern separates the abstraction hierarchy and the implementation hierarchy into two different layers so that change in one hierarchy will not affect the development or functionality of another hierarchy.

<p align="center">
  <img src="https://dotnettutorials.net/wp-content/uploads/2019/10/word-image-7-768x396.png" />
</p>
---
## When do we need to use Bridge Design Pattern in C# Real-Time Applications?
* We want to hide the implementation details from the client.
* We want the selection or switching of the implementation is at runtime rather than design time.
* We want both the abstraction and implementation classes to be extensible by the subclasses.
* We want to avoid a tight coupling binding between an abstraction and its implementation. 
* The changes in the implementation of an abstraction should have no impact on clients.
* When we want to share an implementation among multiple objects and this should be hidden from the client.