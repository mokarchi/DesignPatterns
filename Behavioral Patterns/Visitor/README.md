### Visitor  
In the Visitor Design Pattern, we use a Visitor object which changes the executing algorithm of an element object. In this way, when the visitor varies, the execution algorithm of the element object can also vary. As per the Visitor Design Pattern, the element object has to accept the visitor object so that the visitor object handles the operation on the element object.

The Visitor Design Pattern should be used when you have distinct and unrelated operations to perform across a structure of objects (element objects). This avoids adding in code throughout your object structure that is better kept separate.

To understand the above explanation better, please have a look at the following diagram. On the left-hand side, you can see visitor objects and on the right-hand side, you have the object structure. The object structure can be a collection of type either Array, List, ArrayList, etc. As you can see, the object structure (collection) can have multiple elements (i.e. Element 1, Element 2, Element 3, and Element 4). Now if you want to perform some common operation on each element, then you need to use the visitor design pattern. Here, the Visitor object will visit each element of the object structure and perform the common operation.
<p align="center">
  <img src="https://dotnettutorials.net/wp-content/uploads/2019/11/word-image-34.png" />
</p>
Now it is possible to vary the operation as the visitor varies. For example, for Visitor 1, you may perform operation A on each element whereas, for Visitor 2, you may perform operation B on each element. If still, this is not clear at the moment then don’t worry we will try to understand the above explanation with some real-time examples.
---
## Example
Please have a look at the following image. Here, we have a school and in school, lots of kids are studying. One day the school management has decided to perform a health checkup for all the kids. So, what the school management has done is they appointment one child specialist doctor. What the doctor will do is, he will visit the school and check the health of each and every kid. Once he has checked the health of each kid, then he provides the reports to the school management.

<p align="center">
  <img src="https://dotnettutorials.net/wp-content/uploads/2019/11/word-image-35-1024x306.png" />
</p>
So, here in this example, the doctor is nothing but a visitor and the object structure is a collection of Kids where each kid is an element object.

In the same manner, one school bag sales company wants to promote their school bag. So, the company communicates with the school management and decided to give a school to each kid as a gift. So, the company salesman visits the school and give a school bag to each kid. For better understanding please have a look at the following diagram.
<p align="center">
  <img src="https://dotnettutorials.net/wp-content/uploads/2019/11/word-image-36-1024x306.png" />
</p>
Here, the salesman is the visitor and the object structure is the same collection of kids where each kid is an element.
---
## When to use Visitor Design Pattern in C#?
* An object structure must have many unrelated operations to perform on it.
* An object structure cannot change but operations performed on it can change.
* The operations need to perform on the concrete classes of an object structure.
* Exposing the internal state or operations of the object structure is acceptable.
* Operations should be able to operate on multiple object structures that implement the same interface.