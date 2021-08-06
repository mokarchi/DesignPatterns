### Interpreter  
The Interpreter Design Pattern Provides a way to evaluate language grammar or expression. This pattern is used in SQL parsing, symbol processing engine, etc.

Let us understand the interpreter design pattern with an example. Please have a look at the following image. On the left-hand side, you can see the Context. The Context is nothing but the value that we want to interpret. Here, the context value is the current date. On the right-hand side, you can see the Date expression or you can say the grammar. We have different types of date expression such as (MM-DD-YYYY, DD-MM-YYYY, YYYY-MM-DD, and DD-YYYY).
<p align="center">
  <img src="https://dotnettutorials.net/wp-content/uploads/2019/11/word-image-45-768x386.png" />
</p>
Suppose, you want the date in MM-DD-YYYY format then what you need to do is, you need to pass the Context value and the Date Expression you want (i.e. MM-DD-YYYY) to the interpreter. What the interpreter will do is, it will convert the context value into the date expression format you passed to it. So, basically the interpreter contains the logic or grammar to convert the context object into a specific readable format.
---
## Example
Let us implement the example that we discussed here step by step using the Interpreter Design Pattern in C#. So, here we need to convert date time to a specific format. In order to achieve this, we can define different types of grammar. Please have a look at the following diagram. As you can see in the following image, we define a class for each type of grammar such as Month, Year, Day, and separator. So, using this grammar you can create any type of date format

<p align="center">
  <img src="https://dotnettutorials.net/wp-content/uploads/2019/11/word-image-47.png" />
</p>

---
## When to use the Interpreter Design Pattern?
* Grammar is simple
* Efficiency is not a critical concern