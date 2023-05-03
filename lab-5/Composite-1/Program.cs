using Composite_1;

var div1 = new LightElementNode("div", "block", true, new List<string>());
var div2 = new LightElementNode("qwe", "block", true, new List<string>());
var div3 = new LightElementNode("asd", "block", true, new List<string>());
var div4 = new LightElementNode("zxc", "block", true, new List<string>());
var div5 = new LightElementNode("rty", "block", true, new List<string>());
var text1 = new LightTextNode("Some text1");

div1.AppendChild(div2);
div2.AppendChild(div4);
div4.AppendChild(text1);
div1.AppendChild(div3);
div2.InsertBefore(div5, div4);
div1.RemoveChild(div3);

var divCloned1 = div1.Clone();

divCloned1.OuterHTML();
