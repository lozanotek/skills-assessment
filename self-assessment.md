## Development Experience
- ASP.NET Web API
  - It's a robust framework for building Web APIs, providing built-in security, and easy extension using NuGet packages for non-native functionality
  - I can easily scaffold out a RESTful controller based on a data model
- .NET Core Web API
  - The same benefits of full-framework web api projects, with the ability to run anywhere
  - I can develop on my Mac without a parallels VM running all the time :)
- Entity Framework / EF Core
  - Create and maintain database tables in MSSQL, MySQL, and other database formats using code-first modeling
- AngularJS
  - The first JS framework I really dove into -- allows for quick prototyping, and for robust web applications to be built. Easy integration with any RESTful API.
- Angular (2+, TypeScript)
  - My current go-to JS framework for UI development. TypeScript provides strongly typed models in the UI code that match the models on my API. Prototyping a UI can still be done quickly with real connections to my API.
- Swagger (via Swashbuckle)
  - Automatic contracts for Web APIs via .NET Standard or .NET Core
  - Also provides testing tools for manually testing that an API works as expected.
- Swagger Codegen
  - Takes the swagger definition file from Swashbuckle, and allows for quick automated generation of numerous types of UI / API libraries.
  - I typically use this to generate my API services in Angular-friendly TypeScript. That way I automatically have all of my C# models with linked APIs ported into TypeScript
- Visual Studio Test framework
  - I use this to test my APIs on a regular basis. Works well with test-driven development, or to quickly work through a bug that was missed in an edge case.
- Karma testing
  - I use karma to test complex scenarios in my UI code, whether I'm working in AngularJS, or Angular 2+

## Git Commands
- **git status**: While simple, I use this frequently to make sure I don't have any unexpected changes to files.
- **git commit -am [message]**: Once happy with my changes and ready for a commit, this lets me quickly commit everything and add a basic commit message.
- **git reset --hard**: Sometimes things get messy, and I want to get back to where I last pushed a commit

### Honorable Mentions _(Git tools and tricks)_
- **SourceTree**: When working on a Mac I frequently use SourceTree for a visual look at my file changes, managing commits, and swapping between remotes when using a forking approach to team-based development.
- **Git Shortcuts and Aliases**:
  - For longer commands that I use frequently, aliases are definitely my friend.
  - I also typically leverage the shortcuts recommended on the Git website [https://git-scm.com/book/en/v1/Git-Basics-Tips-and-Tricks]
  - To make it faster to apply these shortcuts, I build a bash script that runs the commands for me automatically, for the first time I'm using a computer and getting it set up for my needs: [https://github.com/djsoults/git_shortcuts]

## Continuing Education

### Learning New Things
- I always try to stay up to date with the latest announcements around the .NET and Angular worlds. I'm frequently reading news and blog posts about the latest vNext announcements for the frameworks, tools, and libraries that I use.
- Having said that, I can learn a _lot_ from conferences, and try to attend a couple every year. Being an independent developer makes it that much more important to stay up to date, and it's nice to see other tech-minded people from time to time, too.
  - Last year, I attended SXSW and Prairie.code(). They each had different focuses, but I learned a lot at both!

### Interesting Projects
- **dsmHack: Here To Help**: Last month, I attended the dsmHack charity hack-a-thon, and worked on a unique project that was built specifically for dsmHack to host and offer for local non-profits to help track their volunteer hours. We chose to build an Angular UI, using Angular CLI. I led development of the UI side of the project, while other team members focused on API development in a Java Sprint Boot application. (Unfortunately, my suggestions for .NET Core lost out :D).
  - I'll be continuing to develop new features on the UI for _Here To Help_ in the coming months, as a number of developers from our team expressed interest in continuing the development process to deliver some of the nice-to-have features that we didn't have time for.
- **ISU College of Human Sciences - Online Learning Applications**: I'm currently working on a suite of three applications that will be used by the team who manages the offering of online classes for the college.
  - These applications will allow them to more effectively manage:
    1. Requests for classes to be offered online
    1. The library of offered courses, as a web-app that is made available to the public via their website
    1. Communications with students and instructors, and
    1. The application review and approval process for certain classes that have special requirements
