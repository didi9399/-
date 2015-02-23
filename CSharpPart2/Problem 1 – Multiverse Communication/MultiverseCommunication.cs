using System;
using System.Collections.Generic;
using System.Numerics;

class MultiverseCommunication
{
    static BigInteger ConvertBinaryToDecimal(List<string> num)
    {
        List<BigInteger> array = new List<BigInteger>();
        for (int i = 0; i < num.Count; i++)
        {
            string a = num[i];
            array.Add(BigInteger.Parse(a));
        }
        array.Reverse();
        BigInteger el;
        BigInteger decimalNumeralSystems = 0;
        for (int i = 0; i < array.Count; i++)
        {
            el = array[i];
            for (BigInteger j = 1; j <= i; j++)
            {
                el = el * 13;
            }
            decimalNumeralSystems += el;
        }
        return decimalNumeralSystems;
    }
    static void Main(string[] args)
    {
       string[] arrayWord = {"CHU", "TEL", "OFT", "IVA", "EMY", "VNB", "POQ", "ERI", "CAD", "K-A", "IIA", "YLO", "PLA"};
        string word = Console.ReadLine();
       string[] l = new string[word.Length];
        string a = "";
        for (int i = 0; i < arrayWord.Length; i++)
        {
            if (word.IndexOf(arrayWord[i]) >= 0)
            {
                switch (i)
                {
                    case 0:
                        a = "0";
                        break;
                    case 1:
                        a = "1";
                        break;
                    case 2:
                        a = "2";
                        break;
                    case 3:
                        a = "3";
                        break;
                    case 4:
                        a = "4";
                        break;
                    case 5:
                        a = "5";
                        break;
                    case 6:
                        a = "6";
                        break;
                    case 7:
                        a = "7";
                        break;
                    case 8:
                        a = "8";
                        break;
                    case 9:
                        a = "9";
                        break;
                    case 10:
                        a = "10";
                        break;
                    case 11:
                        a = "11";
                        break;
                    case 12:
                        a = "12";
                        break;
                }
                l[word.IndexOf(arrayWord[i])] = a;
            }

           


        }

        List<string> array = new List<string>(l.Length);
        for (int j = 0; j < l.Length; j++)
        {
            if (l[j] != null)
            {
                array.Add(l[j]);
            }
            
        }
       /* foreach (string aaaa in array)
        {
            Console.WriteLine(aaaa);
        } */

        Console.WriteLine( ConvertBinaryToDecimal(array));
    }
}

