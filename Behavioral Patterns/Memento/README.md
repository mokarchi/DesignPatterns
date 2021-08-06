### Memento  
Let us understand the Memento Design Pattern with an example. Please have a look at the following image. As shown in the left-hand side of the image, we have an employee with Id =101, Name =John, Salary = 2Lakhs, Designation = Software Engineer, Address = London, and many more attributes. Later some point in time we did change some of the properties (Salary to 3Lakhs, Designation to Senior Software Engineer, like this we also change some other attributes) of employee which is shown in the right-hand side of the below image. That means we change the object state from State 1 to State 2.

<p align="center">
  <img src="https://dotnettutorials.net/wp-content/uploads/2019/12/word-image-14.png" />
</p>

Later some point in time, we think that let’s undo or rollback the employee information to its previous state i.e. State 1. If this is your requirement then you need to use the Memento Design Pattern and rollback the employee information to its previous state.
---
## Example
I buy one 42inch led TV whose cost is 60000rs and it does not support USB and I placed it on the hall. After some point of time, I thought let buy 46inch led TV. So, I buy a 46 inch led TV whose cost is 80000rs and it supports USB and I want to place it in the hall. But already in the hall 42inch led tv is there. So, what I have to do is, I have to place the 42inch led TV in the storeroom and place this 46inch led TV on the hall.

Again after some point of time, I am thinking let buy 50inch led TV whose cost is 100000rs and supports USB. So, I buy this 46inch led TV and I want to place it in the hall. But in the hall, the 46inch led TV is there. So, what I have to do is, I have to take the 46inch led TV from the hall and put it again in the storeroom and then place the 50inch led TV in the hall.

After some point of time, I thought let put the 42inch led TV in the hall as the clarity of the 50inch led TV is not that good. So, what I have to do is, I have to take the 50inch led TV from the hall and put it on the storeroom and from the storeroom take thee 42inch led TV and put it on the hall. So, basically we are rollbacking to its previous state.

<p align="center">
  <img src="https://dotnettutorials.net/wp-content/uploads/2019/12/word-image-16.png" />
</p>
In this example, the Hall is the Originator and the Store Room is the Caretaker. Led TV is the memento i.e. it used to hold the internal state of LED TV. This is one of the best examples of the memento design pattern. So, in a scenario like this, we need to use the Memento Design Pattern.
## When to use the memento Design pattern in real-time applications?
* The state of an object needs to be saved and restored at a later time.
* The state of an object cannot be exposed directly by using an interface without exposing implementation.