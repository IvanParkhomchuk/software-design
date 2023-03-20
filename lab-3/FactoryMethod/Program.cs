using FactoryMethod;

ISubscribe subscribe = new WebSite();

ISubscription subscribtion = subscribe.CreateSubscribe("Premium");

subscribtion.GetSubscribtionType();

Console.ReadLine();