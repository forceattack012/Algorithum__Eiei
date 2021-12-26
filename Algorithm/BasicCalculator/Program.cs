// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;

Console.WriteLine("Hello, World!");

Calculate("15+32*2");

int Calculate(string s)
{
    s = s.Trim();
    string temp;
    int cal = 0;
    int i = 0;
    var ops = new string[4] { "+", "-", "*", "/" };
    var op = s.Where(r => ops.Contains(r.ToString())).ToArray();
    var t = Regex.Replace(s, @"[\d-]", " ").Split(' ');
    var group = t
                .GroupBy(r => r)
                .ToDictionary(g => g.Key, g=> g);
    foreach (var item in op)
    {
        s = s.Replace(item, ' ');
    }

    var strArray = s.Split(' ');
    return 0;
}

