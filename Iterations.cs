using System;
using System.Collections.Generic;
using System.Linq;
using DotnetIteration.Models;

namespace DotnetIteration
{

  public static class Iteration
  {
    /*
       Welcome to Interation
       Down below you will find instructions for code to write.
       As you write and save your code, you can look in your terminal where you
       ran `dotnet watch test` to see if your code is working. The tests continuously check
       your work each time you save. If a test is failing you have not yet completed that method
       Once you finish a method and have it correct, the test will tell you how
       the next method is working.
    */

    /*  
      * 1) Define a function named `yelling` that takes an list of
      * strings as an argument and returns a new list with all
      * the words forced to uppercase
      *
    
   */
    public static IEnumerable<string> Yelling(List<string> words)
    {
      var allCaps = new List<string>();
        foreach (string word in words)
        {
          allCaps.Add(word.ToUpper());
        }
        return allCaps;
      throw new System.NotImplementedException();
    }

    /* 
      * 2) Define a function named `doubleTrouble` that takes an list of
      * numbers as an argument and returns a new list with all
      * the numbers multiplied by 2
      */

    public static IEnumerable<int> Double(List<int> numbers)
    {
      throw new System.NotImplementedException();
    }
    /*
      * 3) Define a function stringyIndexes() that takes an list of
      * strings as an argument and returns a new list with each string
      * suffixed with " is at index X" where X is the index of the element
      */
    public static IEnumerable<string> StringyIndexes(List<string> data)
    {
      throw new System.NotImplementedException();
    }
    /*
       * 4) Define a function onlyTheEvenSurvive that accepts an list of
       * numbers and returns only the elements that are even
       */

    public static IEnumerable<int> OnlyTheEvenSurvive(List<int> data)
    {
      throw new System.NotImplementedException();
    }
    /*
        * 5) Define a function onlyTheEvenIndexedSurvive that accepts an list of
        * numbers and returns only the elements at indexes that are even
        */
    public static IEnumerable<int> OnlyTheEvenIndexedSurvive(List<int> data)
    {
      throw new System.NotImplementedException();
    }
    /*
      * 6)  Define a function bestMoviesOfTheYear that accepts an list of
      * movie objects AND a year and returns the names of movies that are
      * from that year AND have a score more than 90
      *
      * A movie object looks like this:
      *
      * {
      *   name: "Get Out",
      *   year: "2017",
      *   score: 99
      * }
      */
    public static IEnumerable<string> BestMovieOfTheYear(List<Movie> data, int year)
    {
      throw new System.NotImplementedException();
    }

    /*
      * 7) Define a function everyoneIsOdd that accepts an list of
      * numbers and returns true if every element of the list is
      * odd.
      */

    public static bool EveryoneIsOdd(List<int> data)
    {
      throw new System.NotImplementedException();
    }
    /*
      * 8) Define a function findTheNeedle that accepts an list of
      * strings and returns the one string that contains the word
      * `needle` 
      */
    public static string FindTheNeedle(List<string> data)
    {
      throw new System.NotImplementedException();
    }


    /*
        * 9) Define a function findTheNeedleIndex that accepts an list of
        * strings and returns the index of the string that contains
        *  the word `needle` inside
        */

    public static int FindTheNeedleIndex(List<string> data)
    {
      throw new System.NotImplementedException();
    }

    /*
      *` 10)  Define a function someoneToLove that accepts an list of
      * strings and returns true if at least one string is exactly
      * four characters long
      */


    public static bool SomeoneToLove(List<string> data)
    {
      throw new System.NotImplementedException();
    }
  }

}