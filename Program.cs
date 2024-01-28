//Написать метод для добавления эл. в начало массива в конец и по указанному индексу.
void ChangeFirstElement(ref int[] array , int changeInt)
{
    array[0] = changeInt;
} 
void ChangeLastElement(ref int[] array , int changeInt)
{
    array[array.Length - 1] = changeInt;
}
void ChangeIndexedElement(ref int[] array , int index , int changeInt)
{
    array[index] = changeInt;
}
int IsIntCycle(string input)
{
    int result = -1;
    bool isInt = int.TryParse(input , out result);
    while (isInt==false)
    {
        Console.WriteLine("Enter the integer");
        input = Console.ReadLine();
        isInt = int.TryParse(input , out result);
    }
    return result;
}
int[] FillArray(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++) 
    {
        array[i] = rnd.Next(1,33);
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0;i < array.Length;i++) 
    {
        Console.Write(array[i] + "\t"); 
    }
}
bool IsIndexInArray(int[] array , int index)
{
bool isInArray = false;
    if (index < array.Length-1 && index>=0 )
    {
    isInArray = true;
    }
    return isInArray;
}
int[] myArray = new int[10];
Console.WriteLine("Enter the index of the changing element");
string inputIndex = Console.ReadLine() ?? "No Data";
int myIndex = IsIntCycle(inputIndex);
while (IsIndexInArray(myArray, myIndex)==false)
{
    Console.WriteLine("Your entered index is out the bounds of the Array enter again");
    inputIndex = Console.ReadLine();
    myIndex = IsIntCycle(inputIndex);
}
Console.WriteLine("Enter integer on which it must be changed");
string inputChange = Console.ReadLine() ?? string.Empty;
int mychange = IsIntCycle(inputChange);
FillArray(myArray);
PrintArray(myArray);
ChangeFirstElement(ref myArray , mychange);
ChangeLastElement(ref myArray , mychange);
ChangeIndexedElement(ref myArray ,myIndex ,mychange);
Console.WriteLine();
PrintArray(myArray);
Console.ReadLine();
