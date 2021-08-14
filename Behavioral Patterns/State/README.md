### State  
According to Gang of Four Definitions, the State Design Pattern allows an object to alter its behavior when its internal state changes. In simple words, we can say that the State Pattern is a design pattern that allows an object to completely change its behavior depending upon its current internal state.

For a better understanding of the above definition, please have a look at the following diagram. Here, you can see on the left-hand side we have the client and on the right-hand side we have the Context object and the context object internally maintains some states (such as State A and State B).

As you can see in the below diagram, the current state of the Context object is State A. So, when the client makes a request to the Context object, what the Context object will do is, it will perform Operation A.
<p align="center">
  <img src="http://mokarchi.ir/git/State/word-image-14.png" />
</p>
Let us say the state of the context object is changed to State B. Now when the request is coming from the client, the context object will perform operation B as the current state us State B as shown in the following diagram.
<p align="center">
  <img src="http://mokarchi.ir/git/State/word-image-15-768x248.png" />
</p>
So, the point that you need to remember is based on the internal state of the context object, the behavior will be changed.
---
## Example
Let us understand the State Design Pattern with a real-time example. ATM machine behavior is the best example of the State Design Pattern. Please have a look at the following diagram. Let say the ATM machine’s internal state is Debit Card Not Inserted means the ATM card is not inserted into the slot of the ATM Machine. Then what are all the operations you can do? The operations you can do are as follows.

    You can insert the debit card.
    You cannot eject the debit card as the debit card is not inserted into ATM Machine.
    Again you cannot also enter the PIN and withdraw money. So, the only allowed operation is he can insert the debit card.

Suppose you inserted the debit card into the machine. So the state of the ATM (i.e. Context Object) is changed to Debit Card Inserted. Then what are all the operations you can do? The operations you can do are as follows.

    You cannot insert the debit card as already one debit card is inserted into the machine.
    It allows you to eject the Debit card.
    You can enter the PIN number and withdraw the money.

<p align="center">
  <img src="http://mokarchi.ir/git/State/word-image-16-768x342.png" />
</p>
The point that you need to remember is, if the state is Debit Card Not Inserted then it will allow you to perform certain operations and when the state is Debit Card Inserted then it will allow you to perform another set of operations. So, based on the internal state of the ATM machine the behavior will be changed.
