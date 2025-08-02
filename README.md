# DCIT318 Assignment 2 - Object-Oriented Programming in C#

This repository contains three C# console applications demonstrating different aspects of object-oriented programming:

## Applications

### 1. InheritanceDemo - Inheritance and Method Overriding
**Location:** `InheritanceDemo/`

This application demonstrates:
- Base class `Animal` with a virtual method `MakeSound()`
- Derived classes `Dog` and `Cat` that override the `MakeSound()` method
- Polymorphism with method overriding

**Features:**
- Animal class prints "Some generic sound"
- Dog class prints "Bark" 
- Cat class prints "Meow"
- Demonstrates polymorphism with an array of Animal references

**To run:**
```bash
cd InheritanceDemo
dotnet run
```

### 2. AbstractClassDemo - Abstract Classes and Methods
**Location:** `AbstractClassDemo/`

This application demonstrates:
- Abstract base class `Shape` with abstract method `GetArea()`
- Derived classes `Circle` and `Rectangle` implementing `GetArea()`
- Abstract class polymorphism

**Features:**
- Circle calculates area using πr²
- Rectangle calculates area using width × height
- Demonstrates polymorphism with abstract classes

**To run:**
```bash
cd AbstractClassDemo
dotnet run
```

### 3. InterfaceDemo - Interfaces
**Location:** `InterfaceDemo/`

This application demonstrates:
- Interface `IMovable` with method `Move()`
- Classes `Car` and `Bicycle` implementing `IMovable`
- Interface polymorphism

**Features:**
- Car prints "Car is moving"
- Bicycle prints "Bicycle is moving"
- Demonstrates polymorphism with interfaces

**To run:**
```bash
cd InterfaceDemo
dotnet run
```

## Prerequisites

- .NET 9.0 SDK or later
- Any C# compatible IDE (Visual Studio, VS Code, etc.)

## Running All Applications

To run all applications at once, you can use the following commands:

```bash
# Inheritance Demo
cd InheritanceDemo && dotnet run && cd ..

# Abstract Class Demo
cd AbstractClassDemo && dotnet run && cd ..

# Interface Demo
cd InterfaceDemo && dotnet run && cd ..
```

## Key OOP Concepts Demonstrated

1. **Inheritance:** Classes inheriting from base classes
2. **Method Overriding:** Derived classes providing specific implementations
3. **Abstract Classes:** Classes that cannot be instantiated directly
4. **Abstract Methods:** Methods that must be implemented by derived classes
5. **Interfaces:** Contracts that classes must fulfill
6. **Polymorphism:** Using base class/interface references to call derived implementations

## Output Examples

### InheritanceDemo Output:
```
=== Inheritance and Method Overriding Demo ===
Animal: Some generic sound
Dog: Bark
Cat: Meow

=== Polymorphism Demo ===
Animal: Some generic sound
Dog: Bark
Cat: Meow
```

### AbstractClassDemo Output:
```
=== Abstract Classes and Methods Demo ===
Circle with radius 5.0:
Area = 78.54

Rectangle with width 4.0 and height 6.0:
Area = 24.00

=== Polymorphism with Abstract Classes ===
Circle Area = 28.27
Rectangle Area = 11.25
```

### InterfaceDemo Output:
```
=== Interfaces Demo ===
Car: Car is moving
Bicycle: Bicycle is moving

=== Polymorphism with Interfaces ===
Car: Car is moving
Bicycle: Bicycle is moving
```
