# DesignPatterns
Design patterns are solutions to recurring problems
# Types of Design Patterns
 
* [Creational patterns]
* [Structural patterns]
* [Behavioral patterns]
  * [Memento](#memento)

## Memento
Memento is a behavioral design pattern that lets you save and restore the previous state of an object without revealing the details of its implementation.
<p align="center">
  <img src="https://exceptionnotfound.net/content/images/2020/10/memento-uml.gif" width="350" alt="Memento">
</p>

    The Memento stores internal state of the Originator object.  The Memento has no limit on what it may or may not store (e.g. as much or as little of the Originator's state as needed).
    The Originator creates a Memento containing a "snapshot" of its internal state, and then later uses that memento to restore its internal state.
    The Caretaker is responsible for the Memento's safekeeping, but does not operate on or examine the contents of that Memento.
