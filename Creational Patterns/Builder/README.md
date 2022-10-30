### Builder 
 
 So what is the motivation behind a builder?

Well, the thing is that some objects are simple. And if you have a simple object like a point which has X and Y coordinates, you can go ahead and create this object in a single constructor call you just call the constructor, provide the arguments and that's it.

On the other hand, other objects require a lot of ceremony to create.
So, for example, when you are constructing a string from a dozen different pieces, what you typically want to do is not call a constructor and not do a concatenation where you have 1000 plus signs.
Instead you make a string builder, which actually lets you construct an object piece by piece.

So having an object with 10 constructor arguments is really not productive. It's not the great way to go because people make mistakes when they see too much variety. If you have a constructed with 10 arguments, you may miss up two of the arguments by misplacing one of them. And once again, code completion in modern IDs is great, but it's not that great. And sometimes it can give you a false sense of security in a way.

So having a massive constructor is not a great way and instead you should opt for piecewise construction.

So allow people to construct objects piece by piece and provide a good API for actually doing it. 

And this is what the builder pattern is all about. So a builder is essentially a separate component. So when piecewise construction of an object is complicated, then you provide a special API for actually doing it succinctly.


The Builder Design Pattern builds a complex object using many simple objects and using a step-by-step approach. The Process of constructing a complex object should be generic so that the same construction process can be used to create different representations of the same complex object.

So, the Builder Design Pattern is all about separating the construction process from its representation. When the construction process of your object is very complex then only you need to use to Builder Design Pattern

<p align="center">
  <img src="http://mokarchi.ir/git/Builder/c-users-pranaya-pictures-understanding-the-builde.png" />
</p>
<p align="center">
  <img src="http://mokarchi.ir/git/Builder/c-users-pranaya-pictures-bilder-design-pattern-re.png" />
</p>
<p align="center">
  <img src="http://mokarchi.ir/git/Builder/Understanding-the-Class-Diagram-of-Builder-Design-Pattern-in-C-768x386.png" />
</p>

* Builder: The Builder is an interface that defines all the steps which are used to make the concrete product. 
* Concrete Builder: The ConcreteBuilder class implements the Builder interface and provides implementation to all the abstract methods. The Concrete Builder is responsible for constructs and assembles the individual parts of the product by implementing the Builder interface. It also defines and tracks the representation it creates.
* Director: The Director takes those individual processes from the Builder and defines the sequence to build the product.
* Product: The Product is a class and we want to create this product object using the builder design pattern. This class defines different parts that will make the product
---
## We need to use the Builder Design Pattern in real-time applications in the following scenarios.
* When you want to make a complex object by specifying only its type and content. The built object is constructed from the details of its construction.
* When you decouple the process of building a complex object from the parts that make up the object.
* When you want to isolate the code for construction and representation
