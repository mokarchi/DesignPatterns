### Strategy  
According to Gang of Four Definitions, define a family of algorithms, encapsulate each one, and make them interchangeable. Strategy lets the algorithm vary independently from clients that use it.

The Strategy Design Pattern is used when we have multiple algorithms (solutions) for a specific task and the client decides the actual implementation to be used at runtime.

In simple words, we can say that the Strategy Design Pattern (also called policy pattern) attempts to solve the issue where you need to provide multiple solutions for the same problem so that one can be selected at runtime.

To understand the above explanation better, please have a look at the following image. As shown in the below diagram we have one task and to solve the task we have three solutions (i.e. Solution 1, Solution 2, and Solution 3). That means using the above three solutions we can achieve the task. As per the Strategy Design Pattern which solution should be used that will be decided by the client only at runtime. So, the client will decide whether to use Solution 1 to achieve the task or solution 2 to achieve the task or solution 3 to achieve the task at run time.
<p align="center">
  <img src="https://dotnettutorials.net/wp-content/uploads/2019/11/word-image-38.png" />
</p>
---
## Example
Let us understand the strategy design pattern using one real-time example. Please have a look at the following image. As you can see, in my D drive I have a folder called DotNetDesignPattern and within that folder, multiple text files are there. My business requirement is, I have to compress this DotNetDesignPattern folder and send the compressed file to the client.

For this requirement, I have two solutions. The first solution is, I can compress the folder into rar format and send it to the client and the second solution is, I can compress the folder into zip format and sends it to the client. So, for the above requirement, I have two solutions

<p align="center">
  <img src="https://dotnettutorials.net/wp-content/uploads/2019/11/word-image-39-768x301.png" />
</p>
As per the strategy design pattern, for the particular problem (task) there are multiple solutions and which solution to be used will be decided by the client at runtime. So, in our example, the client will decide at runtime in which format he wants the file.
---
## When do we need to use the Strategy Design Pattern in real-time applications?
* When there are multiple solutions for a given task and the selection criteria of a solution defined at run-time.
* When you want different variants of an algorithm.
* When many related classes differ only in their behavior.
* When a class defines many behaviors and these appear as multiple conditional statements in its operations. Instead of many conditional statements, move-related conditional branches into their own strategy class.
* When an algorithm uses data that the client shouldn’t know about. Use the Strategy Design Pattern to avoid exposing the complex and algorithm-specific data structures.