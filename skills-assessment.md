# Git Evaluation
## Development Experience
### What technologies do you know? What do you like about them?
- .NET Core
    - Lightweight, cross-platform, speed
- .NET Framework
    - Tons of support and documentation
- Microsoft SQL Server
    - First database I learned and most familiar
- C#
    - Programming language with the most experience. Also very powerful and easy to learn
- Kotlin
    - Cutting edge and popularity on the rise
- Spring Framework
    - Easy to set up and start an application with Spring Boot
- Docker
    - Easy to automate and deploy Docker containers
- Concourse
    - Allows anything to be put in a CI/CD pipeline
- TeamCity
    - Easy to setup and use for automated builds
- Octopus
    - Very easy to deploy any .NET application as a Nuget Package with Octopack
- Test Driven Development
    - Forces me to think before I code, eliminates bugs, and makes refactoring easy
- RESTful API
    - Easy and consistent way to handle CRUD operations of data

## Git Commands
### What are your favorite git commands? Give a simple description for each.
I have three git commands that are my favorite when used together.
1. `git rm -r --cached .` This removes all files from tracking
2. `git add .` This adds and tracks all files
3. `git commit -m "remove untracked files"` This commits the changes to source control
I use these three commands together when unnecessary files accidentally get added to source control. For example, the `.gitignore` template for Visual Studio does not ignore `.DS_Store` files by default. When working on a Mac, it is easy to commit these files by mistake. After a file has been committed, you can update the `.gitignore`, but the file is already being tracked. To remove the file, you will have to use the above three commands to remove all cached files and then add everything back before committing. Any changes to the `.gitignore` file will take effect once all files are removed from tracking. 

## Continuing Education
### How do you learn new things? What interesting projects are you currently working on?
I am a hands-on learner and I learn best by doing or following along with tutorials. I use Pluralsight for introductions to new technologies or concepts. I have also used Lynda.com in the past. 

An interesting project I am currently working on is a RESTful API written in Kotlin with the Spring Framework. This is particularly interesting because of the new technologies and the rapid change of both. Since both technologies are rather new, there is limited documentation and resources available online. This forces us to gain a deeper understanding and dig into the source control to solve problems and debug our application.
