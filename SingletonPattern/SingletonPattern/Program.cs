// See https://aka.ms/new-console-template for more information
using SingletonPattern;

// Objective - To ensure that the class has only one instance:


Console.WriteLine("Hello, World!");

var loggerInstance = Logger.Instance;
loggerInstance.Log("I am a logger Instance");

//Lazy Initialization

var lazyLoggerInstance= LazyLogger.Instance;
lazyLoggerInstance.Log("I am a lazy Instance");