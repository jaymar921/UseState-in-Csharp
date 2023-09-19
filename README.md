# Use State in C#
> Inspired by ReactJS useState, I have created my C# way haha
- Created by Jaymar

### How it works
Initializing the `State` class
```cs
// first way of initializing
var (getterMethod, setterMethod) = new State<Type>().CreateState();

// second way of initializing
State state = new State<Type>();
var (getterMethod, setterMethod) = state.CreateState();
```
### CreateState returns a tuple
- `getterMethod() : Func<T?> delegate` a getter method that will return a value which of type `T` based on the State's initialize value when invoked.
- `setterMethod(T):Action<T> delegate` a setter method will accept a value of type `T` and will set the State's value.

### How to use
An Example code that will have a setter and getter for message
```cs
    Func<T?>, Action<T>
var (message, setMessage) = new State<string>().CreateState("This can be empty");
```
Setting the message value
```cs
setMessage("Hello World");
```
Testing to Log the value of State by invoking the getter method

Since the `CreateState()` method returns a tuple of `(Func<T?>, Action<T>)`
we still need to invoke the getter method in order to get the
value of the state

There are 2 ways of invoking
first way is putting an open and close parenthesis, another way
is calling the .Invoke() method
```cs
Console.WriteLine(message());         // should print "Hello World"
Console.WriteLine(message.Invoke());  // should print "Hello World"
```

### Using Multiple States
Now that you know how to create a single state, you can create multiple states of your choice
```cs
// creating the getters and setters States
var (name, setName) = new State<string>().CreateState();
var (age, setAge)   = new State<int>().CreateState();

// calling the State setters
setName("Jayharron");
setAge(22);

// invoking the State getters
Console.WriteLine("Hello " + name());
Console.WriteLine("You are " + age() + "years old as of 2023");
```

## Installing Dependency

<p align="center">
    <span style="color:orange;font-weight:700;font-size:20px;">
        <img src="https://www.nuget.org/Content/gallery/img/logo-header.svg" width='200'>
    </span>
    <br/>
    <a style="color:greenyellow;text-decoration:underline;" href="https://www.nuget.org/packages/Jaymar.CSharp.UseState/">Jaymar.CSharp.UseState</a>
</p>

```
.NET CLI
> dotnet add package Jaymar.CSharp.UseState --version 1.0.0

Package Manager
PM> NuGet\Install-Package Jaymar.CSharp.UseState -Version 1.0.0

PackageReference
<PackageReference Include="Jaymar.CSharp.UseState" Version="1.0.0" />

Packet CLI
> paket add Jaymar.CSharp.UseState --version 1.0.0

Script & Interactive
> #r "nuget: Jaymar.CSharp.UseState, 1.0.0"

Cake
// Install Jaymar.CSharp.UseState as a Cake Addin
#addin nuget:?package=Jaymar.CSharp.UseState&version=1.0.0

// Install Jaymar.CSharp.UseState as a Cake Tool
#tool nuget:?package=Jaymar.CSharp.UseState&version=1.0.0
```