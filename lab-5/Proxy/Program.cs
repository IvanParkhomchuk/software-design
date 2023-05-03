using Proxy;
using System.Net.Http.Headers;

ISmartTextReader reader = new SmartTextReader();

ISmartTextReader smartTextChecker = new SmartTextChecker(reader);

smartTextChecker.ReadFile("textForMatrix.txt");

try
{
    ISmartTextReader textReaderLocker = new SmartTextReaderLocker(reader, "restricted_file");
    textReaderLocker.ReadFile("restricted_file.txt");
}
catch (Exception e)
{
    Console.WriteLine("Could not process a request");
    Console.WriteLine(e.Message);
}