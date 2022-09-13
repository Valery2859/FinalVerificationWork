/* Написать программу, которая из имеющегося массива строк формирует новый массив
из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив 
можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении 
не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*/

class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();
        string[] stringArray = new string[]{"Sun", "Monday", "Tuer",
      "Wednesday", "Th", "Fri", "Saturday"};
        string[] result1 = new string[]{};
        string result;
        int b = 0;
        result1 = new string[7];
        for (int i = 0; i < stringArray.Length; i++)
        {
            result = stringArray[i];
            int a = result.Length;
            if (a <= 3)
            {                                              
                result1[b] = stringArray[i]; 
                b ++;              
            }
            Console.Write("{0},  ", stringArray[i]);            
        }
        Console.Write("-> ");
        for (int i = 0; i < result1.Length; i++)
        {            
            Console.Write("{0}  ", result1[i]);
        }
        Console.WriteLine(" ");
        Console.WriteLine(" ");

    }
}