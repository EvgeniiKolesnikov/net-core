using System;

class Task1
{
  static void Main(string[] args)
  {
    // Task 1
    const string x = "aabbcccdde";
    // string target = "a2b2c3d2e1";
    Console.WriteLine("Init   = " + x);
    Console.WriteLine("Result = " + MagicBox(x));
  }

  // Solution
  static string MagicBox(string x)
  {
    string res = "";
    int cnt = 1;
    for (int i = 0; i < x.Length; i++)
    {
      try
      {
        if (x[i] == x[i + 1])
        {
          cnt++;
        }
        else
        {
          res += x[i] + cnt.ToString();
          cnt = 1;
        }
      }
      catch (IndexOutOfRangeException)
      {
        res += x[i] + cnt.ToString();
        cnt = 1;
      }
    }
    return res;
  }
}