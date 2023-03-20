using Singleton;

var instance1 = DatabaseRepository.GetInstance();
var instance2 = DatabaseRepository.GetInstance();

Console.WriteLine(instance1 == instance2);