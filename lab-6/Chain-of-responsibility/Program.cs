using Chain_of_responsibility;

var technicalProblem = new TechnicalSupportHandler();
var paymentProblem = new PaymentOrderHandler();
var productProblem = new ProductServiceHandler();
var additionalProblem = new AdditionalHelpHandler();

technicalProblem
    .SetNext(paymentProblem)
    .SetNext(productProblem)
    .SetNext(additionalProblem);

string result = technicalProblem.Handle();

Console.WriteLine(result);