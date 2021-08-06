### Strategy  
The Template Method Design Pattern defines a sequence of steps of an algorithm and allows the subclasses to override the steps but not allowed to change the sequence. The Key to the Template Design Pattern is that we put the general logic in the abstract parent class and let the child classes define the specifics.

Let us understand the above explanation with an example. Suppose you want to build a concrete house, then you need to follow a sequence of steps such as first you need to build a foundation, then you need to build Pillars. Third, you need to build Walls and finally, you need to build Windows as shown in the below image.
<p align="center">
  <img src="https://dotnettutorials.net/wp-content/uploads/2019/11/word-image-22-768x462.png" />
</p>
So, you have to follow the above sequence of procedures in order to build a concrete house. Suppose you want to build a wooden house. Then also you need to follow the same sequence of procedures that you follow in order to build a concrete house i.e. first you need to build the foundation, then you need to build Pillars, then Walls, and Finally Windows as shown in the below image.
<p align="center">
  <img src="https://dotnettutorials.net/wp-content/uploads/2019/11/word-image-23-768x475.png" />
</p>
The only difference here is instead of using Concrete you need to use Wooden Materials. So, what you can do here is, you can define a template method (called Build a House). The template method will define what are all the procedures or steps (i.e. step1: Building Foundation, Step2: Building Pillars, Step3: Building Walls, Step4: Building Windows) that you need to follow in order to build a house. So, for both the house (Concrete and Wooden) you need to above steps which are shown in the below image.
<p align="center">
  <img src="https://dotnettutorials.net/wp-content/uploads/2019/11/word-image-24-768x378.png" />
</p>
