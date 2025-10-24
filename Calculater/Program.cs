using Calculater;
using System.Runtime.InteropServices.Marshalling;
UICalculate _uiCalculate = new();
double nums1;
double nums2;
string symbol = "";
while (true)
{
    Console.WriteLine("Введите операцию которую хотите совершить, а затем введите значения!");
    symbol = Console.ReadLine();
    nums1 = float.Parse(Console.ReadLine());
    nums2 = float.Parse(Console.ReadLine());
    try
    {
        _uiCalculate.Nums(nums1, symbol);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"{ex.Message}");
    }


    try
    {
        _uiCalculate.Nums(nums1, nums2, symbol);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"{ex.Message}");
    }

}