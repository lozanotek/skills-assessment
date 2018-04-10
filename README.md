![alt text](http://lozanotek.com/images/logo.gif "Created by Lozanotek, Inc.") 
# Skills Assessment for Consultants

This repository contains all the instructions for a quick (+/- 60min) assessment of skills. The purpose of the assessment is to serve a simple baseline to help evaluate the skills a .NET developer should have.

The assessment will be updated as needed to keep up with changes in the .NET ecosystem.

## Activity 2 - .NET Evaluation
This is a spin-off from the classic [FizzBuzz programming question](https://blog.codinghorror.com/why-cant-programmers-program). From the previous link, the FizzBuzz programming question is:

> Write a program that prints the numbers from 1 to 100. But for multiples of three print "Fizz" instead of the number and for the multiples of five print "Buzz". For numbers which are multiples of both three and five print "FizzBuzz".

Let's start with the following structure:

1. Create a folder named `src`
2. Within the folder create a `FizzBuzz` solution that has the following:
   * Console App: `FizzClient`
   * .NET Version: `4.6.2`
   * Library: `FizzLib`
   * .NET Version: `4.6.2`
3. Commit the changes.

### FizzLib
The library requires the following:

1. A class called `FizzBuzz` that has a method called `GetFizzBuzz`.
2. The `GetFizzBuzz` method is designed as:
   * Min and max parameters for evaluating a range of values
   * Default are 1 for min, 100 for max
   * Returns all the results from the evaluations as an enumerable structure
3. Must perform the following evalutions on the range:
   * Evaluate **Fizz** for multiples of 3
   * Evaluate **Buzz** for multiples of 5
   * Evaluate **FizzBuzz** for multiples of 3 and 5
4. Extensible for future expression evaluation. For example, we can easily add an evaluation like, _**Foo** for multiples of 2_, without modifying the FizzBuzz class.
5. Commit the changes

### FizzClient
The console application (client) requires the following:

1. In the `Program` class, perform a run and print to the console the range values for:
   * min: 1, max: 100
   * min: 1, max: `Int32.MaxValue`
   * min: `Int32.MinValue`, max: `Int32.MaxValue`
2. The program must not crash for the larger range runs
3. Commit the changes

Once you're done with these pieces, merge back into the `master` branch as a single commit. Create a pull request (PR) from master so the changes can be reviewed.
