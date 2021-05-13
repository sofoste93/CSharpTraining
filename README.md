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
> Array.Resize(ref groceryList, 6);
> groceryList[4] = "Bread";
> groceryList[5] = "Soda";
> groceryList[6] = "Coca"; // error expected;
> System.IndexOutOfRangeException: Index was outside the bounds of the array.
> 
>
