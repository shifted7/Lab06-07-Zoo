# Lab06-07-Zoo

## Introduction
- This project is a learning exercise, exploring Object-Oriented Programming and the concepts thereof. Through the process of building a zoo, we implement the four pillars of OOP: Inheritance, Abstraction, Polymorphism, and Encapsulation.
- In part two of this lab, we implement interfaces into our design, allowing us to duplicate certain behaviors and properties between different classes.

![Zoo Diagram](https://github.com/shifted7/Lab06-07-Zoo/blob/master/assets/Zoo%20Diagram%20Interfaces.png)


#### The four OOP principles can be explained as follows:
- Inheritance: The ability for one class to pass behaviors and properties to another.
- Abstraction: The ability to create a template or blueprint with basic information without instantiation.
- Polymorphism: The ability to change the behaviors and values of selected methods/properties.
- Encapsulation: The ability to group specific info for reusability or access requirements.


#### We use each of the four principles in the following ways:
- Inheritance: we have a base class of Animal from which all our other classes inherit properties such as having a habitat and diet
- Abstraction: all of our classes are abstract until the lowest level, so that we can pass down the fact that all animals must have a diet property even though we don't know each animal's individual diet.
- Polymorphism: lower classes override many of the properties defined in the classes higher up.
- Encapsulation: we have multiple branches that all stem from the animal class, thus keeping all the animals under this umbrella of categorization without having to rewrite all our properties.


#### Interfaces
- An interface is a reusable group of related class methods and properties which can be added to any class.
- The interfaces implemented here are IHunt and IFly: 
  - IHunt's purpose is to group properties and methods that simulates carnivores hunting prey. It includes a prey property to define the animals that are prey for that class, a SmellForPrey method for finding that prey, and a CatchPrey method for chasing down that prey.
  - IHunt is included in the Tiger, Polar Bear, Owl, Eagle, and Snake classes. All of these classes represent carnivores. Most bears are not carnivores, but the polar bear is. So IHunt is added to the PolarBear class, rather than the bear class.
  - IFly's purpose is to group properties and methods that simulate an animal's ability to fly using its wings. It includes a TopFlySpeed property to quantify how fast an animal can fly at its fastest. It also includes the TakeOff method for starting flight, which is intended to return the animal's speed after takeoff, and the Land method for landing, which is intended to return whether the creature successfully lands.
  - IFly is part of the Owl and Eagle classes, because we expect that all the sub-categories of animals within those categories can fly. Most birds can fly but not all, so IFly is not included in the Bird class.
