### Facade 
As per the GOF definition, the Façade Design Pattern states that you need to provide a unified interface to a set of interfaces in a subsystem. The Façade Design Pattern defines a higher-level interface that makes the subsystem easier to use.

In simple words, we can say that the Facade Design Pattern is used to hide the complexities of a system and provides an interface to the client using which the client can access the system. The Façade (usually a wrapper) sits on the top of a group of subsystems and allows them to communicate in a unified manner.
---
Here, we need to design an application to place an order.
<p align="center">
  <img src="https://dotnettutorials.net/wp-content/uploads/2019/10/c-users-pranaya-pictures-understanding-facade-des-768x200.png" />
</p>
The Façade is actually an extra class that lies at the top of the above method class
<p align="center">
  <img src="https://dotnettutorials.net/wp-content/uploads/2019/10/c-users-pranaya-pictures-facade-design-pattern-im-768x240.png" />
</p>
---
## When to use Facade Design Pattern in Real-Time Applications?
* We want to provide a simple interface to a complex subsystem. Subsystems often get more complex as they evolve.
* There are many dependencies between clients and the implementation classes