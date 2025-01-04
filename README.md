# Uninitialized Property Access in C#

This repository demonstrates a common error in C#: accessing a property before it has been assigned a value.  Uninitialized properties will have their default value (0 for integers, null for reference types), but this might not always be the intended behavior.  This can lead to unexpected results or exceptions. 

## The Bug
The `bug.cs` file shows a simple example of accessing the `MyProperty` before assigning a value to it. The program does not throw an exception, but might return unexpected results. 

## The Solution
The `bugSolution.cs` file shows how to correct the problem by initializing the property in the class constructor or assigning a value before accessing it.