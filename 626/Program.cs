using System;

public class Solutionkata
{
    public int solution(int num1, int num2)
    {
        int answer = 0;
        return answer;
    }
    public int solution2(int num1, int num2)
    {
        return num1 * num2;
    }

    public int solution3(int num1, int num2)
    {
        int answer = num1 / num2;
        return answer;
    }
    public int solution4(int age)
    {
        return 2022 - age + 1;
    }
    public int solution5(int num1, int num2)
    {
        if (num1 == num2) { return 1; }
        if (num1 != num2) { return -1; }
        return 0;
    }
    public int solution6(int num1, int num2)
    {

        return num1 + num2;
    }
    public int solution7(int num1, int num2)
    {
        float result = (float)num1 / num2 * 1000;
        return (int)result;
    }
    public int solution8(int angle)
    {
        if (angle < 90)
        {
            return 1;
        }
        else if (angle == 90)
        {
            return 2;
        }
        else if (angle > 90 && angle < 180)
        {
            return 3;
        }
        else { return 4; }
    }
    public int solution9(int n)
    {
        int temp = 0;
        for (int i = 0; i <= n; i += 2)
        {
            temp += i;
        }
        return temp;
    }
    public double solution10(int[] arr)
    {
        double temp = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            temp += arr[i];
        }
        temp /= arr.Length;
        if (temp % 1 == 0)
        {
            return temp;
        }
        else if ((temp - 0.5f) % 1 == 0)
        {
            return temp;
        }
        else
        {
            return (int)temp;
        }
    }
    public string solution11(int num)
    {
        if (num % 2 == 0)
        {
            return "Even";
        }
        else
        {
            return "Odd";
        }
    }
    public double solution12(int[] arr)
    {
        double temp = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            temp += arr[i];
        }
        return temp /= arr.Length;
    }
    public int solution13(int n)
    {
        string temp = n.ToString();
        int[] tempp = new int[temp.Length];
        for (int i = 0; i < temp.Length; i++)
        {
            tempp[i] = Int32.Parse(temp[i].ToString());
        }
        n = 0;
        foreach (var item in tempp)
        {
            n += item;
        }
        return n;
    }
    public int solution14(int n)
    {
        List<int> w = new List<int>();
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                w.Add(i);
            }
        }
        n = 0;
        foreach (var item in w)
        {
            n += item;
        }
        return n;
    }
    public int solution15(int n)
    {

        for (int i = 1; i < n; i++)
        {
            if (n % i == 1)
            {
                return i;
            }
        }
        return 0;
    }
    public long[] solution16(int x, int n)
    {
        long[] answer = new long[n];
        for (long i = 1; i <= n; i++)
        {
            answer[i - 1] = x * i;
        }
        return answer;
    }
    public int[] solution17(long n)
    {
        string temp = n.ToString();
        int[] answer = new int[temp.Length];
        for (int i = 0; i < temp.Length; i++)
        {
            answer[i] = int.Parse(temp[temp.Length - i - 1].ToString());
        }
        return answer;
    }
    public int solution18(string s)
    {
        return int.Parse(s);
    }
    public long solution19(long n)
    {
        for (long i = 1; i <= n; i++)
        {
            if (i * i == n)
            {
                return (i + 1) * (i + 1);
            }
        }
        return -1;
    }
    public long solution20(long n)
    {
        string temp = n.ToString();
        int[] longint = new int[temp.Length];
        for (int i = 0; i < temp.Length; i++)
        {
            longint[i] = int.Parse(temp[i].ToString());
        }
        for (int i = longint.Length - 2; i >= 0; i--)
        {
            int stemp = i + 1;
            int ket = longint[i];
            while (stemp < longint.Length && longint[stemp] > ket)
            {
                longint[stemp - 1] = longint[stemp];
                stemp++;
            }
            longint[stemp - 1] = ket;
        }
        temp = "";
        foreach (var item in longint)
        {
            temp += item.ToString();
        }
        return long.Parse(temp);

    }
    public bool solution21(int x)
    {
        string temp = x.ToString();
        int weee = 0;
        for (int i = 0; i < temp.Length; i++)
        {
            weee += int.Parse(temp[i].ToString());
        }
        if (x % weee == 0)
        {
            return true;
        }
        return false;
    }
    public long solution22(long a, long b)
    {
        if (a == b)
        {
            return a;
        }
        long pl = 0;
        for (long i = (a < b == true ? a : b) + 1; i < (a < b == false ? a : b); i++)
        {
            pl += i;
        }
        return a + b + pl;

    }
    public int solution23(long num)
    {
        int trypoint = 0;
        if (num == 1)
        {
            return 0;
        }
        while (num != 1)
        {
            num = num % 2 == 0 ? num / 2 : num * 3 + 1;
            trypoint++;
            if (trypoint == 500)
            {
                return -1;
            }
        }
        return trypoint;
    }
    public string solution24(string[] seoul)
    {
        string a = "김서방은 ";
        string c = "에 있다";
        for (int i = 0; i < seoul.Length; i++)
        {
            if (seoul[i] == "Kim")
            {
                return a + i + c;
            }
        }
        return a;
    }
}
internal class Program
{

    static void Main(string[] args)
    {

    }
}
