using System;

class Task1 {
    static void Main(string[] args) {
        // Task 1
        const string x = "aabbcccdde";
        // string target = "a2b2c3d2e1";
        Console.WriteLine("Init   = " + x);
        Console.WriteLine("Result = " + MagicBox(x));
    }

    // Solution
    static string MagicBox(string word) {
        string res = "";
        int count = 1;

        for (int i = 0; i < word.Length - 1; i++) {
            if (word[i] == word[i + 1]) {
                count++;
            } else {
                res += word[i] + count.ToString();
                count = 1;
            }
        }
        res += word[word.Length - 1] + count.ToString();
        return res;
    }
}