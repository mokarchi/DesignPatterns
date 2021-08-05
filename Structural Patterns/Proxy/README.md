### Proxy 
According to the Gang of four definitions, the Proxy Design Pattern provides a surrogate (act on behalf of other) or placeholder for another object to control the access to it. Proxy means ‘in place of‘ or ‘representing‘ or ‘on behalf of‘.

In the simplest form, we can define a proxy as a class functioning as an interface to something else. The proxy could interface to anything such as a network connection, a large object in memory, a file, or some other resources that are expensive or impossible to duplicate.

We can also say that the Proxy is the object which is being called by the client to access the real object behind the scene. That means, In Proxy Design Pattern, a class represents the functionality of another class
---
<p align="center">
  <img src="https://dotnettutorials.net/wp-content/uploads/2019/11/word-image-3-768x311.png" />
</p>

<p align="center">
  <img src="https://dotnettutorials.net/wp-content/uploads/2019/11/word-image-4.png" />
</p>
---
## Implementation of Proxy Design Pattern(Protection Proxy):
Please have a look at the following diagram. As you can see in the following image, on the right side we have a shared computer that has a shared folder. On the left side, we have employees who are working on a software farm. The shared computer contains a shared folder that contains confidential information and only the employee having role Manager and CEO can access this shared folder and perform the read-write operations. On the other hand, if the employee is a developer, then it should not allow access to the shared folder. That is we need to do some kind of protection. In scenarios like this, the Protection Proxy can be handy.

What we can do here is, in between the employees and the shared computer we need to introduce the Folder Proxy. What this Folder proxy can do is, it will check if the employee’s role is Manager or CEO, then it allows the employee to access the shared folder and perform the read-write operation. On the other hand, if the employee role is Developer then it will say you don’t have permission to access this folder. That kind of protection logic we can write in the folder proxy.
<p align="center">
  <img src="https://dotnettutorials.net/wp-content/uploads/2019/11/word-image-6-768x361.png" />
</p>
---
## When to use the Proxy Design Pattern in C# Real-Time Applications?
* Adding security access to an existing object. The proxy will determine if the client can access the object of interest.
* Simplifying the API of a complex object. The proxy can provide a simple API so that the client code does not have to deal with the complexity of the object of interest.
* Providing interfaces for remote resources such as web service or REST resources.
* Coordinating expensive operations on remote resources by asking the remote resources to start the operation as soon as possible before accessing the resources.
* Adding a thread-safe feature to an existing class without changing the existing class code.