
// la stringa deve contenre due numeri
// la stringa deve contenere due numeri positivi
// fare la somma
using CalculatorChainConsoleApp;
using CalculatorChainLibrary;

var input1 = "1,2,3"; //ok
var input2 = "1,";
var input3 = "1,a";
var input4 = "-1,b";
var input5 = "-1,5";

var splitter = new Splitter(",");

var array1 = splitter.Split(input1);
var array2 = splitter.Split(input2);
var array3 = splitter.Split(input3);
var array4 = splitter.Split(input4);
var array5 = splitter.Split(input5);

var validator = new SetUpChain().GetChain;

var result1 = validator.IsValid(array1);
var result2 = validator.IsValid(array2);
var result3 = validator.IsValid(array3);
var result4 = validator.IsValid(array4);
var result5 = validator.IsValid(array5);

Console.WriteLine($"String: {input1} | Result: {result1.Valid} | Error: {result1.Error}");
Console.WriteLine($"String: {input2} | Result: {result2.Valid} | Error: {result2.Error}");
Console.WriteLine($"String: {input3} | Result: {result3.Valid} | Error: {result3.Error}");
Console.WriteLine($"String: {input4} | Result: {result4.Valid} | Error: {result4.Error}");
Console.WriteLine($"String: {input5} | Result: {result5.Valid} | Error: {result5.Error}");




