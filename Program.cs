namespace OOP04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 — Theoretical Questions
            /// Q1  Abstraction
            ///a)  What is Abstraction in Object - Oriented Programming?
            ///b)  Why is abstraction considered one of the four pillars of OOP ?

            // a) Abstraction is the process of hiding unnecesssary implementation details and showing only the essential features of an object

            // b) Because it helps reduce Complexity by hiding implementation details and exposing only what is necessary for using the object

            /// Q2  Abstract Classes vs. Interfaces
            /// a)  What is the difference between an Abstract Class and an Interface?
            /// b)  When would you choose an Interface instead of an Abstract Class?
            /// c)  Can a class inherit from multiple abstract classes? Can it implement multiple interfaces?

            // a) An abstract class can have both abstract and concrete methods,
            // while an interface can only have abstract methods (prior to C# 8.0).
            // Abstract classes can have fields, constructors, and access modifiers, while interfaces cannot.

            // b) You would choose an interface when you want to define a contract that multiple classes can implement,
            // regardless of their position in the class hierarchy.

            // c) No, a class cannot inherit from multiple abstract classes, but it can implement multiple interfaces.


            #endregion
        }
    }
}
