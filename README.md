# StrategyPattern
Learning about the Strategy Design Patern

The Strategy Pattern:
"It defines a family of algorithms, encapsulates each one, and makes them inter-changeable. 
Strategy lets the algorithm vary independently from clients that use it."

UNDERSTANDING:
The strategy pattern allows seperation of concerns. When working on large scale software a lot of changes can occur, 
it allows us to make changes with minimum effort. 

One of the key-component in this pattern is composition or "Has-a". Our Duck class "has-a" behavior (interface) of flying. 
It also has the behavior of quacking. We can add multiple behavior like these that our Duck class uses.
*When using "Has-a", we are using composition. We are composing this behavior inside the class instead of inheriting them.
If we want code re-usability use composition.

The "Is-a" relationship is of inheritance. The Duck class in this case would be the abstract class (can't create an instance of
this class) that all other derived classes inherit from. Derived classed could be different species of ducks and even toy ducks.
