
using System;

class Program
{
    static void Main()
    {

        #region Resize-
        //    int[] numbers = { 1, 2, 3, 4, 5 };
        //    Console.Write("silinecek elementi daxil edin: ");
        //    bool tapildi = false;

        //    int silinecekElement;
        //    bool isValid = int.TryParse(Console.ReadLine(), out silinecekElement);
        //    if (!isValid)
        //    {
        //        Console.WriteLine("duzgun eded daxil edilmedi.");
        //        return;
        //    }

        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        if (numbers[i] == silinecekElement)
        //        {
        //            tapildi = true;


        //            for (int j = i; j < numbers.Length - 1; j++)
        //            {
        //                numbers[j] = numbers[j + 1];
        //            }

        //            numbers[numbers.Length - 1] = 0;
        //            Array.Resize(ref numbers, numbers.Length - 1);
        //        }
        //        }


        //    if (!tapildi)
        //    {
        //        Console.WriteLine("NotFound");
        //    }
        //    foreach (int n in numbers)
        //    {
        //        Console.WriteLine(n);
        //    }
        //}
        #endregion

        #region Resize+
        //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
        //Console.WriteLine("Elave edmek istediyiniz ededi daxil edin");
        //int daxilolunacaqeded;

        //bool tapildi = false; 
        //bool isValid = int.TryParse(Console.ReadLine(), out daxilolunacaqeded);
        //if (!isValid)
        //{
        //    Console.WriteLine("Duzgun deyer daxil edin");
        //    return;
        //}
        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    if (numbers[i]==daxilolunacaqeded)
        //    {
        //        tapildi = true;
        //        Console.WriteLine("Bu eded artiq massivde var");
        //        break;
        //    }
        //}
        //if (!tapildi) {
        //Array.Resize(ref numbers, numbers.Length + 1);
        //numbers[numbers.Length - 1] = daxilolunacaqeded;
        //}
        //foreach (var item in numbers)
        //{
        //    Console.WriteLine(item);
        //}
        #endregion


        #region ResizeSort
        //int[] numbers = { 1, 2,4, 5, 6, 7, 88 };
        //Console.WriteLine("Elave edmek istediyiniz ededi daxil edin");
        //int daxilolunacaqeded;
        //Array.Sort(numbers);

        //bool tapildi = false;
        //bool isValid = int.TryParse(Console.ReadLine(), out daxilolunacaqeded);
        //if (!isValid)
        //{
        //    Console.WriteLine("Duzgun deyer daxil edin");
        //    return;
        //}
        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    if (numbers[i] == daxilolunacaqeded)
        //    {
        //        tapildi = true;
        //        Console.WriteLine("Bu eded artiq massivde var");
        //        break;
        //    }
        //}
        //if (!tapildi)
        //{
        //    Array.Resize(ref numbers, numbers.Length + 1);
        //    int insertIndex =numbers.Length - 1;
        //    for (int i = 0; i < numbers.Length-1; i++)
        //    {
        //        if (daxilolunacaqeded < numbers[i])
        //        {
        //            insertIndex = i;
        //            break;
        //        }
        //    }

        //    for (int j = numbers.Length - 1; j > insertIndex; j--)
        //    {
        //        numbers[j] = numbers[j - 1];
        //    }
        //    numbers[insertIndex] = daxilolunacaqeded;


        //}
        //foreach (var item in numbers)
        //{
        //    Console.WriteLine(item);
        //}
        #endregion
        #region Fibanocciile
        //Console.WriteLine("Ededi daxil edin");
        //int eded=Convert.ToInt32(Console.ReadLine());
        //int[] number = new int[3];
        //number[0] = 0;
        //number[1] = 1;
        //Array.Resize(ref number, eded);

        //int frstnum = 0, secondnum = 1, n, i;
        //for (i = 2; i < eded; i++)
        //{
        //    n = frstnum + secondnum;
        //    frstnum = secondnum;
        //    secondnum = n;
        //    number[i] = n;
        //}
        //foreach (var item in number)
        //{
        //    Console.WriteLine(item);
        //}
        #endregion
    }
}
