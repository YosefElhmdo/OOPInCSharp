using Exception;
   try {
    int[] arr = { 1, 2, 3, 4, 5, 6 };
    int item = 54;
    Console.WriteLine(Test.IsExist(arr, item));
}
catch (System.Exception exp)
{
    Console.WriteLine(exp.Message);
}
try
{
    Console.WriteLine("Enter n: ");
    int[] arr = { 1, 2, 3, 4, 5, 6 };
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(arr[n]);
}
catch (IndexOutOfRangeException en)
{
    Console.WriteLine(en.Message);
}