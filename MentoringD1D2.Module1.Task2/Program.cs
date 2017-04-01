using System;
using MentoringD1D2.Module1.Task2.Helpers;

namespace MentoringD1D2.Module1.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            IntToBool intToBoolDelagate = ConvertHelper.ToBool;
            IntToNullableBool intToNullableBoolDelegate = ConvertHelper.ToNullableBool;

            Console.WriteLine("------------Before conversion------------");
            Console.WriteLine("---------Positive Int to Bool------------");
            Console.WriteLine(intToBoolDelagate(1));
            Console.WriteLine("-----Positive Int to Nullable Bool-------");
            Console.WriteLine(intToNullableBoolDelegate(1));

            Console.WriteLine("------------After conversion-------------");
            Console.WriteLine("-----------Positive Int to Bool----------");
            Console.WriteLine(intToBoolDelagate.ToNullableBool()(1));
            Console.WriteLine("------Positive Int to Nullable Bool------");
            Console.WriteLine(intToNullableBoolDelegate.ToBool()(1));

            Console.WriteLine("------------Before conversion------------");
            Console.WriteLine("---------------Zero to Bool--------------");
            Console.WriteLine(intToBoolDelagate(0));
            Console.WriteLine("----------Zero to Nullable Bool----------");
            Console.WriteLine(intToNullableBoolDelegate(0));

            Console.WriteLine("------------After conversion-------------");
            Console.WriteLine("---------------Zero to Bool--------------");
            Console.WriteLine(intToBoolDelagate.ToNullableBool()(0));
            Console.WriteLine("----------Zero to Nullable Bool----------");
            Console.WriteLine(intToNullableBoolDelegate.ToBool()(0));



            Console.WriteLine("------------Before conversion------------");
            Console.WriteLine("----------Negative Int to Bool-----------");
            Console.WriteLine(intToBoolDelagate(-1));
            Console.WriteLine("-------Negative Int to Nullable Bool-----");
            Console.WriteLine(intToNullableBoolDelegate(-1));

            Console.WriteLine("------------After conversion-------------");
            Console.WriteLine("---------Negative Int to Bool------------");
            Console.WriteLine(intToBoolDelagate.ToNullableBool()(-1));
            Console.WriteLine("------Negative Int to Nullable Bool------");
            Console.WriteLine(intToNullableBoolDelegate.ToBool()(-1));


            Console.ReadKey();
        }
    }
}
