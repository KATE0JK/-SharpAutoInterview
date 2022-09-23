// using System;
//
// namespace SharpAutoBubbleSort 
// {
//     internal static class Program
//     {
//         static void Main(string[] args)
//         {

using System;
using SharpAutoInterview;

Console.WriteLine("Bubble Sort");
Console.Write("Enter array elements : "); 
var parts = Console.ReadLine()?.Split(new[] { " ", ",", ";" }, StringSplitOptions.RemoveEmptyEntries); 

if (parts != null) 
{ 
    var array = new int[parts.Length]; 
    for (int i = 0; i < parts.Length; i++) 
    { 
        array[i] = Convert.ToInt32(parts[i]);
    }
    
    Console.WriteLine("Bubble Sorted Array: {0}", string.Join(", ", BubbleSort.SortBubble(array)));
}

Console.ReadLine();   
    //    }
  //  }
//}



