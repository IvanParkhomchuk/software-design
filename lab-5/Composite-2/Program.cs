using Composite_2;

//var hero = new MarvelHero("BlackWidow", 1);
//var ring = new Artefact("PowerRing", 5, 50);
//var necklace = new Artefact("PerlNecklace", 10, 100);
//var husband = new CompositeArtefact("Thanos", 1000, 1000);

//husband.AddArtefact(ring);
//husband.AddArtefact(necklace);

//hero.AddArtefact(husband);


//hero.CountArtefacts();
//hero.CalculateArtefactsWeight();
//hero.Strike();

//husband.RemoveArtefact(ring);
//hero.CountArtefacts();
//hero.CalculateArtefactsWeight();
//hero.Strike();

var hero = new MarvelHero("Iron Man", 1);
var gloveOfPower = new CompositeArtefact("Glove of Power", 5, 50);

var redInfStone = new Artefact("Red Infinity Srone", 5, 100);
var greenInfStone = new Artefact("Green Infinity Srone", 5, 100);
var yellowInfStone = new Artefact("Yellow Infinity Srone", 5, 100);
var violetInfStone = new Artefact("Violet Infinity Srone", 5, 100);
var blueInfStone = new Artefact("Blue Infinity Srone", 5, 100);

gloveOfPower.AddArtefact(redInfStone);
gloveOfPower.AddArtefact(greenInfStone);
gloveOfPower.AddArtefact(yellowInfStone);
gloveOfPower.AddArtefact(violetInfStone);
gloveOfPower.AddArtefact(blueInfStone);

hero.AddArtefact(gloveOfPower);
hero.CountArtefacts();
hero.CalculateArtefactsWeight();
hero.Strike();