# TaxCalculator



  For this codng challnge, I decided to use interfaces such as Itax, IMedicare, ISuperannuation to improve reusability and maintainability of the application. 
  Implementing methods in concrete classes from interfaces makes the app loose coupled and gives developers more freedom to use intefaces to extend their classes. 
  Also if down the track some of the functionalities need to be extend, it is easy to add new methods and parameters in interfaces. 
  
  
  If income rules change, we could simply add new functionality to new interfaces, such as new objects or methods - Medicare account object that we can add paremeters for that we could explicitly call
  from IMedicare, new interface ICOVIDSupport for calculating amounts that were given, etc
  
  For encapusulation I used private readonly fields that contain important information, such as percentages of tax, income levels and tax brackets. That way they cannot be 
  reached outside the class they are being used. 
  
  I tried to use Exception handling using try catch blocks, but due to lack of time  and confidence I didn't succeed.
  
  For handling user input errors I used TryParse funcionality with while loop, so that user cannot go further without putting valid number. What is missing is validation check for zero and negative values. 
  
  Before I started, I was considering useng abstract class for Tax with all fields and methods, such as that they could be used in concrete classes, but again I think 
  that intefaces might give us a bit of more freedom to code and adjust the funcionality. 
  
  
  Thank you!
  
  
