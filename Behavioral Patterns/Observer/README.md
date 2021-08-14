### Observer  
According to GoF, the Observer design Pattern should “Define a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically”.

The Observer Design Pattern is a Software Design Pattern in which an object (called as Subject) maintains a list of its dependents (called as Observers) and notifies them automatically whenever any state changes by calling one of their methods.

The Observer Design Pattern defines a one-to-many dependency between objects so that when one object’s state changes, all its dependents are notified and updated automatically. The Other names of this pattern are Producer/Consumer, Publish/Subscribe.

---
## Example
<p align="center">
  <img src="http://mokarchi.ir/git/Observer/c-users-pranaya-pictures-real-time-example-of-obs.png" />
</p>
As you can see in the above image, three users come to the Amazon site for buying a Mobile Phone. Unfortunately, at that time the Mobile phone is out of stock i.e. the mobile is in a Not Available state. But the above three users want to buy that particular mobile. On the Amazon site, there is an option called to notify me when the product is available. What the above three users do is, they registered with the above option, so that when the product is available, the Amazon site will send a notification to them.

After a few days, the Product is available, and so the status is changed from Out Of Stock to available. So, what Amazon will do is send notifications to all the users who are registered. As we already discussed the Observer Design Pattern has two main components i.e. the Subject and the Observer. In our examples, the Mobile is the Subject and three users (i.e. User1, User2, and User3) are the Observers. For better understanding please have a look at the following image.
<p align="center">
  <img src="http://mokarchi.ir/git/Observer/c-users-pranaya-pictures-observer-design-pattern-1.png" />
</p>
As per the Observer Design Pattern, the Observers need to be registered to the Subject. In our case, the three users are registered to the notification option of the Subject. When the state changes i.e. Out of Stock to Available the Subject will send a notification to all the subscribers.
