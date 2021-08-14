### Mediator  
The Mediator Design Pattern is used to reduce the communication complexity between multiple objects. This design pattern provides a mediator object and that mediator object normally handles all the communication complexities between different objects.

The Mediator object acts as the communication center for all objects. That means when an object needs to communicate to another object, then it does not call the other object directly, instead, it calls the mediator object and it is the responsibility of the mediator object to route the message to the destination object

## Example 
Please have a look at the following diagram. Nowadays, everybody is aware of Facebook. On Facebook, we can create some specific groups and in that group, people can join and share their knowledge. Assume on Facebook there is a group called Dot Net Tutorials and in that group, many peoples (such as Ram, Sam, Pam, Dave, Steve, Anurag, etc.) are joined. Let say Ram sharing some dot net links in the Dot Net Tutorials group. Then what this Facebook Group (Dot Net Tutorials) will do is it will send that links to all the members who are joined in this group. So, here the Facebook group is acting as a Mediator.
<p align="center">
  <img src="http://mokarchi.ir/git/Mediator/word-image-52-768x537.png" />
</p>

## Real-time Example 
ATC stands for Air Traffic Control. The ATC mediator is nothing but the Air Traffic Control Tower which is available at the Airport. Please have a look at the following image. Here, you can see different flights (such as Flight 101, Flight 202, Flight 707, and Flight 808).

Suppose Flight 101 wants to land at a particular terminal in the Airport. Then what the Flight Pilot will do is he will communicate with the ATC Mediator and saying he wants to land the Flight 101 at the particular airport terminal. Then what the ATC Mediator will do is, he will check whether any flight is there at that particular terminal or not. If no flight is there, then what the ATC mediator will do is it will send a message to Pilots of other flights saying that Flight 101 is going to land and you should not land at that particular terminal. Then the ATC mediator sends a message to the Flight 101 pilot and saying you can land your flight at the particular airport terminal. Once the Flight 101 pilot got the confirmation message from the ATC Mediator then he will land the flight at that particular terminal.
<p align="center">
  <img src="http://mokarchi.ir/git/Mediator/Real-time-Example-of-Mediator-Design-Pattern-ATC-768x390.png" />
</p>

So, here the ATC mediator will act as a central point and all flights should communicate to the ATC mediator. So, what the ATC mediator will do is, it will receive the message and route the message to the appropriate destinations. Here destinations are flight.
