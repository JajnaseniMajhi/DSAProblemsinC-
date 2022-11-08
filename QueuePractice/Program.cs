// See https://aka.ms/new-console-template for more information
using QueuePractice;
using System.Text;

Console.WriteLine("Hello, World!");
AthPerfectNumber athPerfectNUmber = new AthPerfectNumber();
var result = athPerfectNUmber.GetRepaeting("gu");
Console.WriteLine(result);
//Console.WriteLine(result);
//11
//22
//1111
//1221
//111111
//112211
//121121
//122221
 string simplifyPath(string A) {
if (A == string.Empty)
{
    return string.Empty;
}
Stack<string> stack = new Stack<string>();
    string[] arr = A.Split("/");
//stack.Push("/");
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] == "/" || arr[i] == "." || arr[i]== string.Empty)
    {
        continue;
    }
    if (arr[i] == "..")
    {
            if(stack.Count > 0)
        stack.Pop();
        continue;
    }

    stack.Push(arr[i]);

}


    //List<String> list = new List<string>(stack);
    //return "/" +string.Join("/", list);

    string result = string.Empty;
    StringBuilder str = new StringBuilder();

    while (stack.Count > 0)
    { 
        str.Insert(0, stack.Pop());
        str.Insert(0, "/");
        //result = str.ToString();
       // result = "/" + stack.Pop() + result;
    }

    return str.ToString();
}