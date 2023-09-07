# Week 3 Assessment

## Setup
* Fork and Clone this repository
* Run `update-database` - let the instructors know if you run into any issues!

## Exercise (10 Points)
### Securing the Application (4 points)
* Use Secrets Managemnt to remove the database connection string from the application.
* So that we can see the full implmentation, include a screenshot below to show your `secrets.json` file

![image](https://github.com/jcepriano/Mod4Week3_Assessment/assets/130601095/abc3dd9e-b26f-40d2-b475-2d3765f151fe)


### Maintaining Current-User (6 points)

This application includes some starter code so that we could maintain a current user.  Review the Login and Logout code in the Home Controller, along with the Login and Logout buttons in the Home/Index.cshtml file.  Building on this pre-existing structure:
* Create a cookie that holds a key for "currentUser" when a user logs in.
* Delete that cookie when a user logs out.
* Add the value of "current user" to all views

## Questions (10 Points)

For the following questions, answer as if you are in an interview!
1. Describe one strategy you have used to maintain state in a web application. (2 points)

   In the past, I have used Session State and Cookies when creating web apps that have to maintain state.

2. How would you protect sensitive data that we need to store in our database - for example, passwords? (2 points)

   I would use secret files like the User Secrets in Visual Studios to hide sensitive information about the database. When it comes to passwords and storing them, something that I have used in the past is Hashing the data to make it unreadable to anything but a computer.

3. Describe 3 additional common security risks in web development. (make sure you discuss what you know about the risk, and if you know how to minimize the risk) (6 points)

   A few things that come to mind are DDOS Attacks, Overposting, and SQL Injection. With DDOS attacks, a hacker will overflow a server with traffic to make it very difficult for users to access the server. The risk of this can be reduced through API Rate Limiting. Overposting is when someone posts more data than a form asks for which can change sensitive information.

