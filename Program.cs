using System;

namespace Fizzbuzz
{
class Program
 {
  static void Main(string[] args)
  {
   
  }
   public string FizzBuzz(int determine)   
   {
     var answer = "";

     if(determine % 3 == 0)
     {
      answer = "fizz";
     }

     if(determine % 5 == 0)
     {
      answer += "buzz";
     }

     return answer;
    }

  }
 }
