//Q1
Console.WriteLine("Q1: Create .Net console application framework?");
string answer = Console.ReadLine();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine(answer);
Console.ResetColor();
//Done

//Q2
Console.WriteLine("Q2: Difference between .Net framework & .Net core?");
string answer2 = Console.ReadLine();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine(answer2);
Console.ResetColor();
//"The difference is that .NET core works and oparates on different os like windows,linux,macOS ,but .NET frmework only operates on windows only"

//Q3
Console.WriteLine("Q3: Difference between project & solution?");
string answer3 = Console.ReadLine();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine(answer3);
Console.ResetColor();
//"a solution is a container that contains several projects that are related to eachother"

//Q4
Console.WriteLine("Q4: Difference between function and method?");
string answer4 = Console.ReadLine();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine(answer4);
Console.ResetColor();
//"you can call a function independently in any part of the code if you define it right and call it by its name so its global , but the method is only called inside classes and its defined there too so its local."

//Q5
int[] salary={450,500,550,470};
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine(salary[0]);
Console.ResetColor();

//Q6 part A
Console.WriteLine("enter a word please");
string word = Console.ReadLine();

Stack<char> stack = new Stack<char>();

foreach (char c in word)
    stack.Push(c);

while (stack.Count > 0)
    Console.WriteLine(stack.Pop());


//Q6 part B
Console.WriteLine("enter another word please");
string word2 = Console.ReadLine();

Queue<char> queue = new Queue<char>();

foreach (char c in word2)
    queue.Enqueue(c);

while (queue.Count > 0)
    Console.WriteLine(queue.Dequeue());

