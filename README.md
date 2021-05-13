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
