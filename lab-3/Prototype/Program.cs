using Prototype;

var virusChild1 = new VirusChild(new DateTime(2022, 12, 22));
var virusChild2 = (VirusChild)virusChild1.Clone();

var virus = new Virus(11.11m, 1, "name1", "type1", new VirusChild[] { virusChild1, virusChild2 });

var virusClone = (Virus)virus.Clone();



Console.WriteLine("Virus Original:");
ShowVirus(virus);

Console.WriteLine("\nVirus Clone:");
ShowVirus(virusClone);

void ShowVirus(Virus virus)
{
    Console.WriteLine($"\tName: {virus.Name}");
    Console.WriteLine($"\tType: {virus.Type}");
    Console.WriteLine($"\tAge: {virus.Age}");
    Console.WriteLine($"\tWeight: {virus.Weight}");
    Console.WriteLine($"\tChildren BirthDates: ");

    foreach (VirusChild child in virus.VirusChildren)
    {
        Console.WriteLine($"\t\t{child.BirthDate}");
    }
}