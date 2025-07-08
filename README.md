# Design Pattern Demos

This repository is a collection of concise examples demonstrating the SOLID principles and the classic Gang of Four design patterns in C#. It targets **.NET 9** and can be run directly with the `dotnet` SDK. The examples serve as a practical reference for both newcomers and experienced developers, proving that these patterns are very much applicable in production code.

## Getting Started

1. Install the [.NET 9 SDK](https://dotnet.microsoft.com/).
2. Restore and build the solution:
   ```bash
   dotnet build "Design Pattern Demos.sln"
   ```
3. Run the main demo:
   ```bash
   dotnet run --project "Design Pattern Demos"
   ```
   You can edit `Program.cs` to invoke any specific demo you wish to showcase.

## Repository Layout

- `Patterns/` – implementations of design patterns with "Problem" and "Solution" folders for comparison.
- `SOLID/` – demonstrations of the five SOLID principles.
- `Program.cs` – entry point calling the demos.

## Pattern Quick Reference

## Adapter
When to use: integrate classes with incompatible interfaces.
Problem: existing code expects one interface while another class provides different methods.
How it works: write an adapter that implements the expected interface and delegates to the adaptee.
Benefits: reuse legacy or third-party code without modification.
Tip: keep adapters lightweight so they only translate calls.

## Bridge
When to use: separate abstraction from implementation so both can vary.
Problem: multiple inheritance hierarchies lead to class explosion.
How it works: create an abstraction interface and an implementation interface linked via composition.
Benefits: extend either side independently and reduce coupling.
Example: UI widgets delegating drawing to platform-specific renderers.

## Builder
When to use: complex objects need to be constructed step by step.
Problem: many constructor parameters or optional parts make instantiation messy.
How it works: provide a builder with fluent methods to configure parts, then call Build() to get the result.
Benefits: clearer creation code and guarantees fully initialized objects.
Example: assembling a car or composing a multi-page document.

## ChainOfResponsibility
When to use: several handlers may respond to the same request.
Problem: chaining if/else statements couples clients to specific handlers.
How it works: each handler processes the request or passes it to the next handler in the chain.
Benefits: dynamic composition and flexible ordering of responsibilities.
Example: middleware pipelines or UI event bubbling.

## Command
When to use: requests should be parameterized or queued as objects.
Problem: callers are tightly coupled to the specific actions they invoke.
How it works: encapsulate an action and its receiver inside a command class with Execute().
Benefits: enables undo/redo, logging, and flexible invocation of operations.
Example: menu items creating command objects executed by an invoker.

## Composite
When to use: work with individual objects and groups through one interface.
Problem: special-casing leaves and groups makes client code complex.
How it works: define a component interface implemented by both leaf and composite classes.
Benefits: treats the whole structure uniformly and simplifies hierarchy management.
Example: graphics editors where shapes can be nested groups.

## Decorator
When to use: add functionality to objects dynamically.
Problem: subclassing for every feature combination causes class explosion.
How it works: decorator classes wrap the original object and implement the same interface while adding behavior.
Benefits: flexibly mix features at runtime without altering the base class.
Example: adding buffering or compression layers to a stream.

## Facade
When to use: simplify interaction with a complex subsystem.
Problem: clients must know about many subsystem classes and their coordination.
How it works: a facade provides high-level methods that delegate to the subsystem components.
Benefits: reduces coupling and hides intricate subsystem details.
Example: a media facade offering play/stop methods while orchestrating audio and video classes.

## Factory
When to use: object creation logic should be centralized or simplified.
Problem: client code should not depend on concrete classes or constructors.
How it works: define a factory method that returns the appropriate subclass based on input or configuration.
Benefits: decouples instantiation from use and eases substitution of implementations.
Example: a shape factory that returns different shape objects at runtime.

## Flyweight
When to use: you need to handle a large number of similar objects efficiently.
Problem: duplicating shared data across thousands of objects wastes memory.
How it works: store shared state in flyweight objects and pass unique context externally when needed.
Benefits: significant memory savings while keeping object-oriented structure intact.
Example: character glyphs in text rendering share font data but store positions separately.

## Interpreter
When to use: represent and evaluate sentences in a simple language or grammar.
Problem: expression parsing scattered in code becomes hard to maintain.
How it works: model grammar rules as classes with an Interpret method.
Benefits: easy to extend with new expressions and keeps parsing logic clean.
Example: arithmetic expression evaluation or simple scripting languages.

## Iterator
When to use: traverse elements of a collection without exposing its structure.
Problem: clients depend on collection implementation to loop through items.
How it works: an iterator object provides operations to access elements sequentially.
Benefits: multiple traversals and different iteration strategies become possible.
Example: IEnumerable and IEnumerator interfaces in C#.

## Mediator
When to use: many objects communicate in complex ways and dependencies must be minimized.
Problem: direct object references lead to a tangled web of interactions.
How it works: a mediator object coordinates communication among colleague objects.
Benefits: centralizes interaction logic and reduces coupling between components.
Example: a chat room where participants send messages through a mediator.

## Memento
When to use: provide undo or rollback functionality without exposing internal state.
Problem: storing state externally violates encapsulation.
How it works: the originator creates a memento object representing its state and restores from it when needed.
Benefits: encapsulated snapshots enable undo stacks and state checkpoints.
Example: text editors storing previous document versions for undo.

## NullObject
When to use: eliminate null checks by providing a do-nothing implementation.
Problem: clients constantly guard against null references before calling methods.
How it works: supply an object that conforms to the interface but performs neutral behavior.
Benefits: simplifies calling code and avoids NullReferenceException errors.
Example: a logger that silently ignores all messages in a production build.

## Observer
When to use: objects should react to state changes in another object.
Problem: manual polling or tight coupling between observers and subjects is hard to maintain.
How it works: observers subscribe to a subject and are notified automatically when changes occur.
Benefits: promotes loose coupling and enables event-driven systems.
Example: GUI components updating when underlying data models change.

## Prototype
When to use: creating new objects is expensive or complex.
Problem: constructing an object from scratch involves many steps or resource usage.
How it works: clone an existing prototype to produce new objects quickly.
Benefits: simplified creation of similar objects and reduced initialization cost.
Example: duplicating graphic elements in a drawing application.

## Proxy
When to use: manage access to an object that is expensive or sensitive.
Problem: clients may need lazy initialization, caching, or security checks before using the real object.
How it works: a proxy implements the same interface and adds the access logic before delegating to the real subject.
Benefits: transparent control over the actual object and additional behavior without modification.
Example: virtual proxies loading data on demand or remote proxies controlling network access.

## Singleton
When to use: exactly one instance of a class must coordinate actions globally.
Problem: multiple instances would cause inconsistent behavior or wasted resources.
How it works: the class exposes a static Instance property that lazily creates the sole object.
Benefits: controlled global access and lazy initialization when first needed.
Example: an application-wide configuration or logging service.

## State
When to use: an object's behavior must change according to its state.
Problem: large conditional statements for state transitions become hard to manage.
How it works: separate state-specific behavior into individual classes implementing a common interface.
Benefits: simplifies context code and makes state transitions explicit.
Example: a document that changes permitted actions when in Draft, Review, or Published state.

## Strategy
When to use: choose among multiple algorithms or behaviors at runtime.
Problem: embedding algorithm choices in conditional statements reduces flexibility.
How it works: define a family of strategy classes sharing a common interface and switch them interchangeably.
Benefits: easy to extend algorithms independently from the clients that use them.
Example: different sorting strategies selected based on data size.

## TemplateMethod
When to use: enforce the outline of an algorithm while letting subclasses refine steps.
Problem: similar algorithms implemented in several classes cause duplication.
How it works: a base class defines a template method calling abstract operations that subclasses override.
Benefits: ensures consistent workflow and promotes code reuse.
Example: a data processing pipeline where subclasses supply validation or transformation steps.

## Visitor
When to use: add new operations across a set of objects without modifying them.
Problem: adding behavior requires changing every class in the structure.
How it works: implement visitor objects with visit methods for each element and let elements accept a visitor.
Benefits: extend functionality easily while keeping element classes stable.
Example: traversing an AST to generate code or compute statistics.

