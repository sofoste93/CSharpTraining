# CSharpTraining

Learning C# by practicing


>
> Wanna learn C# ?
> This is a result of a training
> 
> Topics: 
> 
> Flow Control,
> 
> Arrays,
> 
> Exception Handling
>

@Author
- Stephane Sob F.


# Arrays and Collection
- Arrays
>
> var groceryList = new string[4];
> 
> groceryList[0] = "Milk";
> 
> groceryList[1] = "Eggs";
> 
> groceryList[2] = "Apples";
> 
> groceryList[3] = "Cheese";
> 
> groceryList[4] = "Impossible";
> 
> System.IndexOutOfRangeException: Index was outside the bounds of the array.
> 
> // groceryList[x] has a fixed size
> 
> . // ;
> 
> #reset 64
> 
> Resetting execution engine.
> 
> Loading context from 'CSharpInteractive.rsp'.
>
> var groceryList = new string[4] { "Milk", "Eggs", "Cheese", "Apples" };
> groceryList[2]
> "Cheese"
> 
> groceryList[3]
> "Apples"
> groceryList[4]
> System.IndexOutOfRangeException: Index was outside the bounds of the array.
> // error was expected;
> 
- Resizing Array
> 
> Array.Resize(ref groceryList, 6);
> 
> groceryList[4] = "Bread";
> 
> groceryList[5] = "Soda";
> 
> groceryList[6] = "Coca"; // error expected;
> 
> System.IndexOutOfRangeException: Index was outside the bounds of the array.
> 
- Multidimensional array
- 
>
>  var multiDim = new int[3, 4] {
> {0 ,1, 2, 3},
> {4, 5, 3, 7},
> {8, 7, 6, 9}
> };
> 
> multiDim
> 
> int[3, 4] { { 0, 1, 2, 3 }, { 4, 5, 3, 7 }, { 8, 7, 6, 9 } }
> 
> multiDim[2,3]
- 9
>
>  multiDim[1,1]
- 5
- Collection
> - Generic class
>  // Managing ordered data with lists;
> var awesomeSauces = new List<string>();
> 
// No need to specify the size - it increases 
> awesomeSauces.Add("Tobasco");
> awesomeSauces.Add("Cholula");
> awesomeSauces.Add("Bolonia");
> awesomeSauces.Add("Bongo");
> awesomeSauces.Add("Ndolais");
> 
> awesomeSauces[4]
"Ndolais"
> awesomeSauces[2]
"Bolonia"
> 
-
- > // Introduction to LINQ;
. var listOfNumbers = new int[5] { 1, 3, 5, 7, 9 };
. listOfNumbers.Sum()
. 25
. listOfNumbers.Average()
. 5
. listOfNumbers.Where(item => item >= 3)
. Enumerable.WhereArrayIterator<int> { 3, 5, 7, 9 }

> // Unordered data and dictionaries;
> 
> var testList = new List<string>();
> 
> testList.Add("C# is a awesome programming language");
testList#
(1,9): error CS1040: Präprozessordirektiven müssen das erste Zeichen in einer Zeile sein, das keine Leerstelle ist.
>
>  testList[0]
"C# is a awesome programming language"
>
>  var dictionaryWords = new Dictionary<string, string>();
> 
> dictionaryWords.Add("var", "shorthand for variable");
> 
> dictionaryWords["var"]
"shorthand for variable"
> 
> dictionaryWords.Add("function", "something that does work on data");
> 
> dictionaryWords.Add("variable", "a container for data");
> 
> dictionaryWords.Count
3
> 
> dictionaryWords.Keys
Dictionary<string, string>.KeyCollection(3) { "var", "function", "variable" }
> 
> dictionaryWords.Add("var", "this is a dupe"); // error expected;
System.ArgumentException: An item with the same key has already been added.
  + System.ThrowHelper.ThrowArgumentException(System.ExceptionResource)
  + Dictionary<TKey, TValue>.Insert(TKey, TValue, bool)
> 
> dictionaryWords["function"]
"something that does work on data"
> 
> dictionaryWords[variable]
(1,17): error CS0103: Der Name "variable" ist im aktuellen Kontext nicht vorhanden.
> 
> dictionaryWords["variable"]
"a container for data"
> 
# Flow Control - looping
  - Testing the assembly
>
>  #r "A:\Workspace\VisualStudio\CSharpTraining\CSharpTraining\CSharpTraining\bin\Debug\CSharpTraining.dll"
> 
> var test = new CSharpTraining.LoopingCSharp();
> 
> test.ForLoop()
- 4950
> 
> test.ForEachLoop()
> - 25
> 
> // successfuly tested the assembly;
>
> #r "A:\Workspace\VisualStudio\CSharpTraining\CSharpTraining\CSharpTraining\bin\Debug\CSharpTraining.dll"
> 
> var test = new CSharpTraining.LoopingCSharp();
> 
> test.DoWhileLoop()
4950
> 
> test.WhileLoop()
4950
> 
> test.ForEachLoop()
25
> 
> test.ForLoop()
4950
> 
> test.GetType()
[CSharpTraining.LoopingCSharp]
> 
> test.ToString()
"CSharpTraining.LoopingCSharp"
> 
> test.GetHashCode()
22896952
> 
> test.Equals()
(1,6): error CS1501: Keine Überladung für die Equals-Methode nimmt 0 Argumente an.
> 
> test.Equals(test)
true
> 
>
> #r "A:\Workspace\VisualStudio\CSharpTraining\CSharpTraining\CSharpTraining\bin\Debug\CSharpTraining.dll"
> 
> var test = new CSharpTraining.LoopingCSharp();
> 
> test.BreakAndContinue()
"Bread\r\nEggs\r\n"
> 
>
