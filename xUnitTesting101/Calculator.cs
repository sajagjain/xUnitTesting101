using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace xUnitTesting101
{
    public class Calculator
    {
        public int Add(string numbers)
        {
            return 0;
        }

        //Handle upto 2 numbers
        //public int Add(string numbers)
        //{
        //    var numArray = numbers.Split(',');

        //    if(string.IsNullOrEmpty(numbers))
        //    {
        //        return 0;
        //    }

        //    if(numArray.Length == 1)
        //    {
        //        return Int32.Parse(numArray[0]);
        //    }

        //    return Int32.Parse(numArray[0]) + Int32.Parse(numArray[1]);
        //}

        ////Handle any amount of numbers
        //public int Add(string numbers)
        //{
        //    var numArray = numbers.Split(',').Select(Int32.Parse);

        //    if (string.IsNullOrEmpty(numbers))
        //    {
        //        return 0;
        //    }

        //    return numArray.Sum();
        //}

        //Support new line as well as ,
        //public int Add(string numbers)
        //{
        //    var numArray = numbers.Split(new [] { ",", "\n" },StringSplitOptions.RemoveEmptyEntries)
        //        .Select(Int32.Parse);

        //    if (string.IsNullOrEmpty(numbers))
        //    {
        //        return 0;
        //    }

        //    return numArray.Sum();
        //}

        //Support custom delimiters passed in string
        //public int Add(string numbers)
        //{
        //    var delimiters = new List<string>{ ",", "\n" };

        //    if (numbers.StartsWith("//"))
        //    {
        //        var splitOnFirstLine = numbers.Split("\n",2);
        //        var customDelimiter = splitOnFirstLine[0].Replace("//", string.Empty);
        //        delimiters.Add(customDelimiter);
        //        numbers = splitOnFirstLine[1];
        //    }

        //    var numArray = numbers.Split(delimiters.ToArray(), StringSplitOptions.RemoveEmptyEntries)
        //        .Select(Int32.Parse);

        //    if (string.IsNullOrEmpty(numbers))
        //    {
        //        return 0;
        //    }

        //    return numArray.Sum();
        //}

        //Should throw exception if negative number
        //public int Add(string numbers)
        //{
        //    var delimiters = new List<string> { ",", "\n" };

        //    if (numbers.StartsWith("//"))
        //    {
        //        var splitOnFirstLine = numbers.Split("\n", 2);
        //        var customDelimiter = splitOnFirstLine[0].Replace("//", string.Empty);
        //        delimiters.Add(customDelimiter);
        //        numbers = splitOnFirstLine[1];
        //    }

        //    var numArray = numbers.Split(delimiters.ToArray(), StringSplitOptions.RemoveEmptyEntries)
        //        .Select(Int32.Parse);

        //    var negativeNumbers = numArray.Where(a => a < 0);

        //    if(negativeNumbers.Count() > 0)
        //    {
        //        throw new Exception("Negatives not allowed: " + string.Join(',', negativeNumbers));
        //    }

        //    return numArray.Sum();
        //}


    }
}
