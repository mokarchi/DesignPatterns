### Prototype 
To simplify the above definition, we can say that, the Prototype Design Pattern gives us a way to create new objects from the existing instance of the object. That means it clone the existing object with its data into a new object
While working with object cloning, we need to understand two things i.e. shallow copy and deep copy

## Points to Remember
* The MemberwiseClone method is part of the System.Object class and creates a shallow copy of the given object. 
* MemberwiseClone Method only copies the non-static fields of the object to the new object
* In the process of copying, if a field is a value type, a bit by bit copy of the field is performed. If a field is a reference type, the reference is copied but the referenced object is not.
