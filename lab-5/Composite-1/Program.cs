using Composite_1;

LightNode main = new LightElementNode(
    "main", 
    "block", 
    true, 
    new List<string> { "user-block" }
);

LightNode div1 = new LightElementNode(
    "div",
    "block",
    true,
    new List<string> { "container1", "container-block" }
);

LightNode div2 = new LightElementNode(
    "div",
    "block",
    true,
    new List<string> { "container2", "container-block" }
);

LightNode div3 = new LightElementNode(
    "div",
    "block",
    true,
    new List<string> { "container3", "container-block" }
);

LightNode div4 = new LightElementNode(
    "div",
    "block",
    true,
    new List<string> { "container4", "container-block" }
);

LightNode p1 = new LightElementNode(
    "p",
    "block",
    true,
    new List<string> { "container-p" }
);

LightNode text1 = new LightTextNode("Hello world!");

p1.AppendChild(text1);
div2.AppendChild(p1);
div1.AppendChild(div2);
main.AppendChild(div1);
div3.AppendChild(div4);
main.AppendChild(div3);

LightNode mainCloned = main.Clone();

main.RemoveChild(div3);

Console.WriteLine(main.OuterHTML());
Console.WriteLine();
Console.WriteLine(mainCloned.OuterHTML());
