# Design Pattern Registry

![.NET 9 SDK](https://img.shields.io/badge/.NET-9-blue)  
![License: MIT](https://img.shields.io/badge/License-MIT-yellow)

A curated registry of **22 classic design patterns** demonstrated in C#. This guide gives you everything you need to **build**, **run**, and **apply** these patterns in production—along with decision questions to help you choose the right pattern for your scenario.

> **MythBuster**: Contrary to outdated advice, design patterns are **production-ready** when applied judiciously. These examples mirror real-world use cases and prove that patterns can improve maintainability, extensibility, and clarity in enterprise systems.

---

## Table of Contents

- [Prerequisites](#prerequisites)  
- [Getting Started](#getting-started)  
- [Repository Layout](#repository-layout)  
- [Quick Reference](#quick-reference)  
- [Pattern Details](#pattern-details)  
  - [Adapter](#adapter)  
  - [Bridge](#bridge)  
  - [Builder](#builder)  
  - [Chain of Responsibility](#chain-of-responsibility)  
  - [Command](#command)  
  - [Composite](#composite)  
  - [Decorator](#decorator)  
  - [Facade](#facade)  
  - [Factory](#factory)  
  - [Flyweight](#flyweight)  
  - [Interpreter](#interpreter)  
  - [Iterator](#iterator)  
  - [Mediator](#mediator)  
  - [Memento](#memento)  
  - [Null Object](#null-object)  
  - [Observer](#observer)  
  - [Prototype](#prototype)  
  - [Proxy](#proxy)  
  - [Singleton](#singleton)  
  - [State](#state)  
  - [Strategy](#strategy)  
  - [Template Method](#template-method)  
  - [Visitor](#visitor)  
- [Production Considerations](#production-considerations)  
- [License](#license)  

---

## Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/) installed  
- A C#-capable IDE or editor (Visual Studio, Rider, VS Code, etc.)

---

## Getting Started

1. **Clone** the repo:  
   ```bash
   git clone https://github.com/your-org/design-pattern-registry.git
   cd design-pattern-registry


2. **Build** the solution:

   ```bash
   dotnet build "Design Pattern Demos.sln"
   ```
3. **Select & Run** a demo:

   * Open `Program.cs`.
   * Uncomment the desired `Demo.Run()` or `Demo.RunHTML()` line.
   * In terminal:

     ```bash
     dotnet run --project "Design Pattern Demos"
     ```

---

## Repository Layout

```
├── Design Pattern Demos.sln
├── Program.cs               # Entry point: toggle demos here
├── Patterns/
│   ├── Adapter/
│   │   └── Demo.cs
│   ├── Bridge/
│   │   └── Demo.cs
│   ├── Builder/
│   │   └── Demo.cs
│   ├── … (other patterns)…  
│   └── Visitor/
│       └── Demo.cs
└── SOLID/                   # Principle demos (SRP, OCP, etc.)
    └── … 
```

---

## Quick Reference

| Pattern                 | Intent                                      | Demo Path                                |
| ----------------------- | ------------------------------------------- | ---------------------------------------- |
| Adapter                 | Convert one interface to another            | `Patterns/Adapter/Demo.cs`               |
| Bridge                  | Decouple abstraction from implementation    | `Patterns/Bridge/Demo.cs`                |
| Builder                 | Construct complex objects step by step      | `Patterns/Builder/Demo.cs`               |
| Chain of Responsibility | Pass a request along a chain of handlers    | `Patterns/ChainOfResponsibility/Demo.cs` |
| Command                 | Encapsulate requests as objects             | `Patterns/Command/Demo.cs`               |
| Composite               | Compose objects into tree structures        | `Patterns/Composite/Demo.cs`             |
| Decorator               | Add behavior dynamically via wrapping       | `Patterns/Decorator/Demo.cs`             |
| Facade                  | Provide a simple interface to a subsystem   | `Patterns/Facade/Demo.cs`                |
| Factory                 | Centralize object creation logic            | `Patterns/Factory/Demo.cs`               |
| Flyweight               | Share common data among many objects        | `Patterns/Flyweight/Demo.cs`             |
| Interpreter             | Define a grammar and interpret sentences    | `Patterns/Interpreter/Demo.cs`           |
| Iterator                | Sequentially traverse a collection          | `Patterns/Iterator/Demo.cs`              |
| Mediator                | Centralize complex communications           | `Patterns/Mediator/Demo.cs`              |
| Memento                 | Capture and restore object state            | `Patterns/Memento/Demo.cs`               |
| Null Object             | Provide a do-nothing stand-in object        | `Patterns/NullObject/Demo.cs`            |
| Observer                | Publish/subscribe for event handling        | `Patterns/Observer/Demo.cs`              |
| Prototype               | Clone objects for efficient creation        | `Patterns/Prototype/Demo.cs`             |
| Proxy                   | Control access to another object            | `Patterns/Proxy/Demo.cs`                 |
| Singleton               | Ensure a single global instance             | `Patterns/Singleton/Demo.cs`             |
| State                   | Change behavior when internal state changes | `Patterns/State/Demo.cs`                 |
| Strategy                | Swap algorithms at runtime                  | `Patterns/Strategy/Demo.cs`              |
| Template Method         | Define skeleton of an algorithm             | `Patterns/TemplateMethod/Demo.cs`        |
| Visitor                 | Add operations without modifying elements   | `Patterns/Visitor/Demo.cs`               |

---

## Pattern Details

### Adapter

* **Intent**
  Convert the interface of a class into one that clients expect.

* **Context / When to Use**
  Reusing legacy or third-party code whose interface doesn’t match your own.

* **Problem**
  Client code depends on a specific interface; you cannot modify the existing class.

* **Solution**
  Create an adapter that implements the target interface and delegates calls to the adaptee.

* **Benefits**

   * Allows code reuse without modifying existing classes
   * Decouples client from service implementation

* **Demo**

  ```csharp
  Patterns.Adapter.Demo.Run();
  ```

  See [`Patterns/Adapter/Demo.cs`](Patterns/Adapter/Demo.cs).

* **Decision Questions**

   * Do you need to integrate code whose interface you cannot change?
   * Is there an impedance mismatch between two interfaces you must connect?

---

### Bridge

* **Intent**
  Decouple an abstraction from its implementation.

* **Context / When to Use**
  Both the abstractions and their implementations should vary independently.

* **Problem**
  Class hierarchies explode when you combine multiple abstractions with multiple implementations.

* **Solution**
  Define interfaces for abstraction and implementation, then compose them at runtime.

* **Benefits**

   * Extends abstractions and implementations independently
   * Reduces coupling between high-level and low-level modules

* **Demo**

  ```csharp
  Patterns.Bridge.Demo.Run();
  ```

  See [`Patterns/Bridge/Demo.cs`](Patterns/Bridge/Demo.cs).

* **Decision Questions**

   * Do you have orthogonal dimensions of variation in your classes?
   * Would you benefit from swapping implementations at runtime?

---

### Builder

* **Intent**
  Construct complex objects step by step.

* **Context / When to Use**
  Objects require numerous optional parameters or construction steps.

* **Problem**
  Telescoping constructors or inconsistent object states are error-prone.

* **Solution**
  Provide a builder with fluent methods to configure and then create the object.

* **Benefits**

   * Clear, readable construction code
   * Ensures fully initialized, valid objects

* **Demo**

  ```csharp
  Patterns.Builder.Demo.RunHTML();
  ```

  See [`Patterns/Builder/Demo.cs`](Patterns/Builder/Demo.cs).

* **Decision Questions**

   * Are you struggling with constructors that take too many parameters?
   * Do you need to enforce mandatory steps or combinations before creation?

---

### Chain of Responsibility

* **Intent**
  Pass a request along a chain of handlers until one handles it.

* **Context / When to Use**
  Multiple objects may handle a request, but the sender shouldn’t know which one does.

* **Problem**
  Hard-coded if/else chains or tight coupling between sender and receivers.

* **Solution**
  Link handler objects in a chain, each deciding to handle or forward the request.

* **Benefits**

   * Flexible assignment of responsibilities
   * Loose coupling between senders and receivers

* **Demo**

  ```csharp
  Patterns.ChainOfResponsibility.Demo.Run();
  ```

  See [`Patterns/ChainOfResponsibility/Demo.cs`](Patterns/ChainOfResponsibility/Demo.cs).

* **Decision Questions**

   * Do you have multiple potential handlers for the same request?
   * Would you like to configure handler order dynamically?

---

### Command

* **Intent**
  Encapsulate a request as an object.

* **Context / When to Use**
  You need to parameterize clients with operations, support undo/redo, or queue commands.

* **Problem**
  Caller is tightly coupled to the actions it invokes.

* **Solution**
  Create command objects that implement an `Execute()` method and possibly `Undo()`.

* **Benefits**

   * Supports undo/redo and logging
   * Decouples sender and receiver

* **Demo**

  ```csharp
  Patterns.Command.Demo.Run();
  ```

  See [`Patterns/Command/Demo.cs`](Patterns/Command/Demo.cs).

* **Decision Questions**

   * Do you need to queue, log, or undo operations?
   * Do callers need to be decoupled from the execution logic?

---

### Composite

* **Intent**
  Compose objects into tree structures and treat them uniformly.

* **Context / When to Use**
  You have part-whole hierarchies of objects.

* **Problem**
  Clients must distinguish between leaf and composite objects.

* **Solution**
  Define a common interface for leaves and containers, and compose recursively.

* **Benefits**

   * Simplifies client code
   * Makes tree structures transparent to users

* **Demo**

  ```csharp
  Patterns.Composite.Demo.Run();
  ```

  See [`Patterns/Composite/Demo.cs`](Patterns/Composite/Demo.cs).

* **Decision Questions**

   * Do you have recursive, tree-like object structures?
   * Should clients treat individual objects and compositions uniformly?

---

### Decorator

* **Intent**
  Add responsibilities to objects at runtime.

* **Context / When to Use**
  You need flexible combinations of behaviors without an explosion of subclasses.

* **Problem**
  Subclassing for every feature combination is unsustainable.

* **Solution**
  Wrap the original object with decorator classes that implement the same interface.

* **Benefits**

   * Mix and match behaviors at runtime
   * Open for extension, closed for modification

* **Demo**

  ```csharp
  Patterns.Decorator.Demo.Run();
  ```

  See [`Patterns/Decorator/Demo.cs`](Patterns/Decorator/Demo.cs).

* **Decision Questions**

   * Do you need to add or remove features dynamically?
   * Can you wrap objects instead of modifying their code?

---

### Facade

* **Intent**
  Provide a unified, simple interface to a complex subsystem.

* **Context / When to Use**
  Clients must interact with multiple classes in a subsystem.

* **Problem**
  Clients become tightly coupled to many subsystem classes and protocols.

* **Solution**
  Create a facade class that exposes high-level operations and delegates internally.

* **Benefits**

   * Reduces coupling to subsystem details
   * Simplifies client code

* **Demo**

  ```csharp
  Patterns.Facade.Demo.Run();
  ```

  See [`Patterns/Facade/Demo.cs`](Patterns/Facade/Demo.cs).

* **Decision Questions**

   * Do clients need a simpler entry point to a complex API?
   * Can you centralize coordination logic in one class?

---

### Factory

* **Intent**
  Centralize object creation logic.

* **Context / When to Use**
  You need to decouple clients from concrete classes or vary products at runtime.

* **Problem**
  Clients depend on constructors or concrete types.

* **Solution**
  Provide a factory method or class that returns instances based on input.

* **Benefits**

   * Encapsulates creation logic
   * Makes substitution of implementations easy

* **Demo**

  ```csharp
  Patterns.Factory.Demo.Run();
  ```

  See [`Patterns/Factory/Demo.cs`](Patterns/Factory/Demo.cs).

* **Decision Questions**

   * Do you need to hide which concrete class you instantiate?
   * Will you add new product types in the future?

---

### Flyweight

* **Intent**
  Share intrinsic state among many fine-grained objects.

* **Context / When to Use**
  You must create large numbers of similar objects.

* **Problem**
  Memory usage balloons when each object holds the same data.

* **Solution**
  Store shared state in flyweight objects and pass unique context externally.

* **Benefits**

   * Significant memory savings
   * Maintains object-oriented design

* **Demo**

  ```csharp
  Patterns.Flyweight.Demo.Run();
  ```

  See [`Patterns/Flyweight/Demo.cs`](Patterns/Flyweight/Demo.cs).

* **Decision Questions**

   * Are you instantiating thousands of similar objects?
   * Can you separate shared (intrinsic) from unique (extrinsic) state?

---

### Interpreter

* **Intent**
  Define a representation for a grammar and an interpreter.

* **Context / When to Use**
  You have a language to evaluate or parse at runtime.

* **Problem**
  Ad-hoc parsing code grows complex and hard to extend.

* **Solution**
  Model grammar rules as classes with an `Interpret()` method.

* **Benefits**

   * Extensible grammar
   * Cleaner parsing logic

* **Demo**

  ```csharp
  Patterns.Interpreter.Demo.Run();
  ```

  See [`Patterns/Interpreter/Demo.cs`](Patterns/Interpreter/Demo.cs).

* **Decision Questions**

   * Do you need to interpret or evaluate expressions?
   * Will your language or grammar evolve over time?

---

### Iterator

* **Intent**
  Provide a way to access elements of a collection sequentially.

* **Context / When to Use**
  You want to hide the internal structure of a collection.

* **Problem**
  Clients depend on concrete collection types for traversal.

* **Solution**
  Implement an iterator object with `MoveNext()` and `Current`.

* **Benefits**

   * Multiple, independent traversals
   * Supports different traversal strategies

* **Demo**

  ```csharp
  Patterns.Iterator.Demo.Run();
  ```

  See [`Patterns/Iterator/Demo.cs`](Patterns/Iterator/Demo.cs).

* **Decision Questions**

   * Do you need multiple cursors over a collection?
   * Should clients be ignorant of the collection’s internals?

---

### Mediator

* **Intent**
  Define an object that encapsulates how a set of objects interact.

* **Context / When to Use**
  Many components communicate in complex ways.

* **Problem**
  Direct references lead to a tangled web of interactions.

* **Solution**
  Centralize communication in a mediator object.

* **Benefits**

   * Reduces coupling between colleagues
   * Simplifies maintenance of interaction logic

* **Demo**

  ```csharp
  Patterns.Mediator.Demo.Run();
  ```

  See [`Patterns/Mediator/Demo.cs`](Patterns/Mediator/Demo.cs).

* **Decision Questions**

   * Do components communicate in unpredictable ways?
   * Would a central coordinator simplify your design?

---

### Memento

* **Intent**
  Capture and restore an object’s internal state without violating encapsulation.

* **Context / When to Use**
  You need undo/rollback functionality.

* **Problem**
  Storing state externally exposes internals.

* **Solution**
  Originator creates a memento object; caretaker stores it for later restoration.

* **Benefits**

   * Encapsulated snapshots
   * Clean undo stacks

* **Demo**

  ```csharp
  Patterns.Memento.Demo.Run();
  ```

  See [`Patterns/Memento/Demo.cs`](Patterns/Memento/Demo.cs).

* **Decision Questions**

   * Do you need to rollback to previous states?
   * Can you encapsulate all state needed into a memento?

---

### Null Object

* **Intent**
  Provide a non-functional object to avoid null checks.

* **Context / When to Use**
  You have many null checks scattered in client code.

* **Problem**
  Clients guard against `null` before each use, cluttering code.

* **Solution**
  Implement a do-nothing object that conforms to the interface.

* **Benefits**

   * Eliminates null checks
   * Simplifies client logic

* **Demo**

  ```csharp
  Patterns.NullObject.Demo.Run();
  ```

  See [`Patterns/NullObject/Demo.cs`](Patterns/NullObject/Demo.cs).

* **Decision Questions**

   * Are you littering code with null guards?
   * Can you replace `null` with a harmless stub?

---

### Observer

* **Intent**
  Define a one-to-many subscription mechanism.

* **Context / When to Use**
  Objects should be notified of state changes in other objects.

* **Problem**
  Tight coupling or manual polling between subjects and observers.

* **Solution**
  Observers register with a subject and receive automatic updates.

* **Benefits**

   * Loose coupling
   * Supports event-driven designs

* **Demo**

  ```csharp
  Patterns.Observer.Demo.Run();
  ```

  See [`Patterns/Observer/Demo.cs`](Patterns/Observer/Demo.cs).

* **Decision Questions**

   * Do multiple components react to the same events?
   * Would you prefer push notifications over polling?

---

### Prototype

* **Intent**
  Specify the kind of objects to create using a prototypical instance.

* **Context / When to Use**
  Object creation is expensive or complex.

* **Problem**
  Constructors with many parameters or resource-heavy initialization.

* **Solution**
  Clone a prototype instance with a `Clone()` method.

* **Benefits**

   * Fast object creation
   * Avoids constructor explosion

* **Demo**

  ```csharp
  Patterns.Prototype.Demo.Run();
  ```

  See [`Patterns/Prototype/Demo.cs`](Patterns/Prototype/Demo.cs).

* **Decision Questions**

   * Is cloning cheaper than constructing from scratch?
   * Can you deep-copy all necessary state reliably?

---

### Proxy

* **Intent**
  Provide a surrogate for another object to control access.

* **Context / When to Use**
  You need lazy loading, caching, or access control.

* **Problem**
  Clients must handle initialization, security checks, or remote calls.

* **Solution**
  Proxy implements the same interface and adds logic before delegating.

* **Benefits**

   * Transparent control over the real subject
   * Supports lazy, remote, and security proxies

* **Demo**

  ```csharp
  Patterns.Proxy.Demo.Run();
  ```

  See [`Patterns/Proxy/Demo.cs`](Patterns/Proxy/Demo.cs).

* **Decision Questions**

   * Do you need to defer object creation or enforce security?
   * Can you hide the real subject behind a surrogate?

---

### Singleton

* **Intent**
  Ensure a class has only one instance and provide a global access point.

* **Context / When to Use**
  A single shared resource (e.g., configuration, logger).

* **Problem**
  Multiple instances lead to inconsistent behavior or wasted resources.

* **Solution**
  Use a static property that lazily creates and returns the sole instance.

* **Benefits**

   * Controlled single instance
   * Lazy initialization

* **Demo**

  ```csharp
  Patterns.Singleton.Demo.Run();
  ```

  See [`Patterns/Singleton/Demo.cs`](Patterns/Singleton/Demo.cs).

* **Decision Questions**

   * Do you absolutely need a single, shared instance?
   * Could dependency injection be a better alternative?

---

### State

* **Intent**
  Allow an object to alter its behavior when its internal state changes.

* **Context / When to Use**
  An object’s behavior must change in response to state transitions.

* **Problem**
  Conditional statements for each state become unwieldy.

* **Solution**
  Encapsulate state-specific behavior in separate classes implementing a common interface.

* **Benefits**

   * Removes bulky conditional logic
   * Makes state transitions explicit

* **Demo**

  ```csharp
  Patterns.State.Demo.Run();
  ```

  See [`Patterns/State/Demo.cs`](Patterns/State/Demo.cs).

* **Decision Questions**

   * Do you have many `if/else` or `switch` blocks based on state?
   * Can you represent each state as a separate class?

---

### Strategy

* **Intent**
  Define a family of algorithms and make them interchangeable.

* **Context / When to Use**
  A class uses one of several algorithms based on configuration or context.

* **Problem**
  Hard-coded conditional logic to select algorithms.

* **Solution**
  Encapsulate each algorithm in its own class and compose at runtime.

* **Benefits**

   * Simplifies adding new algorithms
   * Promotes the Open/Closed Principle

* **Demo**

  ```csharp
  Patterns.Strategy.Demo.Run();
  ```

  See [`Patterns/Strategy/Demo.cs`](Patterns/Strategy/Demo.cs).

* **Decision Questions**

   * Do you choose behavior via conditional logic?
   * Would you benefit from swapping algorithms without code changes?

---

### Template Method

* **Intent**
  Define the skeleton of an algorithm, deferring steps to subclasses.

* **Context / When to Use**
  Multiple classes share the same algorithm structure but differ in steps.

* **Problem**
  Duplicated code across similar algorithms.

* **Solution**
  Implement an abstract base class with a template method that calls abstract operations.

* **Benefits**

   * Ensures consistent workflow
   * Promotes code reuse

* **Demo**

  ```csharp
  Patterns.TemplateMethod.Demo.Run();
  ```

  See [`Patterns/TemplateMethod/Demo.cs`](Patterns/TemplateMethod/Demo.cs).

* **Decision Questions**

   * Do you share an algorithm’s outline but vary individual steps?
   * Can you extract common sequence logic into a base class?

---

### Visitor

* **Intent**
  Represent an operation to be performed on elements of an object structure.

* **Context / When to Use**
  You frequently add new operations on a fixed set of object classes.

* **Problem**
  Adding behavior requires modifying every class in the structure.

* **Solution**
  Create visitor classes with `Visit()` methods for each element type; elements accept visitors.

* **Benefits**

   * Easy to add new operations
   * Keeps element classes stable

* **Demo**

  ```csharp
  Patterns.Visitor.Demo.Run();
  ```

  See [`Patterns/Visitor/Demo.cs`](Patterns/Visitor/Demo.cs).

* **Decision Questions**

   * Do you need to add operations without changing element classes?
   * Is your object structure stable but operations vary?

---

## Production Considerations

* **Performance**: Patterns add indirection. Measure and optimize critical paths.
* **Thread Safety**: Ensure singletons and shared flyweights are thread-safe.
* **Dependency Injection**: Combine factories, strategies, and singletons with DI containers.
* **Maintainability**: Overuse can over-engineer; apply patterns only when they solve concrete problems.
* **Community & Frameworks**: Many libraries (e.g., ASP.NET Core, EF Core) leverage these patterns—so can you!

---

## License

This registry is released under the [MIT License](LICENSE). Feel free to adapt and extend these demos for your teams and projects.
