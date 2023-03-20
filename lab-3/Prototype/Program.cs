using Prototype;

var virusChildren = new VirusChild(new[] { new DateTime(2023, 3, 21), new DateTime(2022, 2, 22) });


var virus = new Virus(10.12m, 2, "Some virus1", "Some type1", virusChildren);