int a;

Console.WriteLine("Enter size of Array: ");

a = int.Parse(Console.ReadLine());

int[] array = new int[a];

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
Console.ReadLine();




// Use the following code for later
//Console.WriteLine(array.Count());