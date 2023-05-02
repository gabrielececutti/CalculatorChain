
// la stringa deve contenre due numeri
// la stringa deve contenere due numeri positivi
// fare la somma
using CalculatorChainLibrary;

var input1 = "1,2,3"; //ok
var input2 = "1,";
var input3 = "1,a";
var input4 = "-1,b";
var input5 = "-1,5";

var myInput1 = new Response { Input = input1, Numbers = new List<int>() };
var myInput2 = new Response { Input = input2, Numbers = new List<int>() };
var myInput3 = new Response { Input = input3, Numbers = new List<int>() };
var myInput4 = new Response { Input = input4, Numbers = new List<int>() };
var myInput5 = new Response { Input = input5, Numbers = new List<int>() };

var validator = new SetUpChain().GetChain;

var result1 = validator.IsValid(myInput1);
var result2 = validator.IsValid(myInput2);
var result3 = validator.IsValid(myInput3);
var result4 = validator.IsValid(myInput4);
var result5 = validator.IsValid(myInput5);

Console.WriteLine($"String: {input1} | Result: {result1.Valid} | Errors: {result1.Error} | Sum: {result1.Sum}");
Console.WriteLine($"String: {input2} | Result: {result2.Valid} | Errors: {result2.Error} | Sum: {result2.Sum}");
Console.WriteLine($"String: {input3} | Result: {result3.Valid} | Errors: {result3.Error} | Sum: {result3.Sum}");
Console.WriteLine($"String: {input4} | Result: {result4.Valid} | Errors: {result4.Error} | Sum: {result4.Sum}");
Console.WriteLine($"String: {input5} | Result: {result5.Valid} | Errors: {result5.Error} | Sum: {result5.Sum}");




