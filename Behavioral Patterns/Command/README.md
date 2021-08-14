### Command  
According to Gang of Four (GoF) definitions, the Command Design Pattern is used to encapsulate a request as an object (i.e. a command) and pass to an invoker, wherein the invoker does now knows how to service the request but uses the encapsulated command to perform an action.

Let us understand the above definition with an example. Please have a look at the following diagram. As you can see in the above image, the client will create the command object. The command object has the request (i.e. what to do?). It also has the receiver object reference. The receiver object is nothing but the object which will handle the request. The command object also has the Execute method. The execute method will call the receiver object method and the receiver object method will handle the request.

<p align="center">
  <img src="http://mokarchi.ir/git/Command/word-image-30.png" />
</p>

As per the command design pattern, the command object will be passed to the invoker object. The Invoker does not know how to handle the request. What the invoker will do is, it will call the Execute method of the command object. The execute method of the command object will call the receiver object method and the receiver object method will perform the necessary action to handle the request. For better understanding please have a look at the following diagram.

<p align="center">
  <img src="http://mokarchi.ir/git/Command/word-image-31-768x298.png" />
</p>

This is how the command design pattern works.

Note: As per the command design pattern the command has three things. The first one is the request i.e. the command. The second one is the Receiver object reference and the third one is the Execute method which will call the receiver object method to handle the request.
---
## Example
<p align="center">
  <img src="http://mokarchi.ir/git/Command/word-image-32.png" />
</p>

## When to use Command Design Pattern in Real-time Application?
* When you need to parameterize objects according to action perform.
* When you need to create and execute requests at different times.
* Sending requests to different receivers can handle it in different ways.
* When you need to support rollback, logging, or transaction functionality.
* When you need to implement callback functionality.
* The source of the request should be decoupled from the object that actually handles the request
