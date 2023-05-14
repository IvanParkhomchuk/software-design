using Mediator;

var aircraft1 = new Aircraft("ac1", 12);
var aircraft2 = new Aircraft("ac2", 12);
var aircraft3 = new Aircraft("ac3", 12);

var runway1 = new Runway();
var runway2 = new Runway();

CommandCentre commandCentre = new CommandCentre(new Runway[] { runway1, runway2 }, new Aircraft[] { aircraft1, aircraft2 });

commandCentre.Landing(aircraft1);
Console.WriteLine();
commandCentre.Landing(aircraft2);
Console.WriteLine();
commandCentre.Landing(aircraft3);
Console.WriteLine();
commandCentre.TakingOff(aircraft2);
Console.WriteLine();
commandCentre.Landing(aircraft3);
