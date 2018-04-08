![alt text](http://lozanotek.com/images/logo.gif "Created by Lozanotek, Inc.") 
# Skills Assessment for Consultants

This repository contains all the instructions for a quick (+/- 60min) assessment of skills. The purpose of the assessment is to serve as a simple baseline to help evaluate the skills a .NET developer should have.

The assessment will be updated as needed to keep up with changes in the .NET ecosystem.

## Instructions
This is an "open note" and "open Google" assessment. In other words, use all the resources you have available to complete the activities to the best of your ability. If you run into any issues or have questions, open an [issue](https://github.com/lozanotek/skills-assessment/issues). If you don't know how to do something or are stuck, just skip it. There's no harm in saying, *I don't know*. Time is too valuable to be stuck.

To get started, please do the following:

* Fork this repository to your GitHub ID
* Switch to the `git-eval` branch, start the first activity
* Each activity has self contained instructions and the next steps
* Have fun!
## Activity 1 - Git Evaluation

1. Create a new file called `self-assessment.md`
2. For each of the items below, create a header section and write a small description about it.
3. After you complete each section, commit the change.

### Header Sections
* **Development Experience** - What technologies do you know? What do you like about them?
* **Git Commands** - What are your favorite git commands? Give a simple description for each.
* **Continuing Education** - How do you learn new things? What interesting projects are you currently working on?

Once you're done with these tasks, merge back into the `master` branch as a single commit. Go to the `fizz-buzz` branch for instructions on the next activity.

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
The library must have the following:

1. A class called `FizzBuzz` that has a method called `GetFizzBuzz`.
2. The `GetFizzBuzz` method is designed as:
   * Min and max parameters for evaluating a range of values
   * Default are 1 for min, 100 for max
   * Returns all the results from the evaluations as an enumerable structure
3. Must perform the following evalutions on the range:
   * Evaluate **Fizz** for multiples of 3
   * Evaluate **Buzz** for multiples of 5
   * Evaluate **FizzBuzz** for multiples of 3 and 5
4. Must be flexible enough to accomodate for future expression evaluations. For example, anyone can easily add an evaluation like, **Foo** for multiples of 2, without changing the structure of the library.
5. Commit the changes

### FizzClient
The console application (client) must have the following:

1. In the `Program` class, perform a run and print to the console the range values for:
   * min: 1, max: 100
   * min: 1, max: `Int32.MaxValue`
   * min: `Int32.MinValue`, max: `Int32.MaxValue`
2. The program must not crash for the larger range runs
3. Commit the changes

Once you're done with these pieces, merge back into the `master` branch as a single commit. Create a pull request (PR) from master so the changes can be reviewed.