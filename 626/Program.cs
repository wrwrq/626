using System.Numerics;
using System.Text;
using System.Globalization;

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
    public int[] solution25(int[] arr, int divisor)
    {
        List<int> ssss = new List<int>();

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % divisor == 0)
            {
                ssss.Add(arr[i]);
            }
        }
        if (ssss.Count == 0)
        {
            return new int[1] { -1 };
        }
        ssss.Sort();
        int[] answer = new int[ssss.Count];
        for (int i = 0; i < ssss.Count; i++)
        {
            answer[i] = ssss[i];
        }
        return answer;
    }
    public int solution26(int[] absolutes, bool[] signs)
    {
        for (int i = 0; i < signs.Length; i++)
        {
            if (signs[i] == false)
            {
                absolutes[i] = -(absolutes[i]);
            }
        }
        int answer = 0;
        foreach (var item in absolutes)
        {
            answer += item;
        }
        return answer;
    }
    public string solution27(string phone_number)
    {
        string answer = "";
        for (int i = 0; i < phone_number.Length - 4; i++)
        {
            answer += "*";
        }
        for (int p = phone_number.Length - 4; p < phone_number.Length; p++)
        {
            answer += phone_number[p];
        }
        return answer;
    }
    public int solution28(int[] numbers)
    {
        int answer = 0;
        for (int i = 0; i <= 9; i++)
        {
            if (numbers.All(a => a != i))
            {
                answer += i;
            }
        }
        return answer;
    }
    public int[] solution29(int[] arr)
    {
        if (arr.Length == 1)
        {
            return new int[] { -1 };
        }
        int smallIndex = 0;
        for (int p = 1; p < arr.Length; p++)
        {
            if (arr[smallIndex] > arr[p])
            {
                smallIndex = p;
            }
        }
        int temp = 0;
        for (int i = smallIndex + 1; i < arr.Length; i++)
        {
            temp = arr[smallIndex];
            arr[smallIndex] = arr[i];
            arr[i] = temp;
            smallIndex++;
        }

        int[] answer = new int[arr.Length - 1];
        for (int i = 0; i < answer.Length; i++)
        {
            answer[i] = arr[i];
        }
        return answer;
    }
    public string solution30(string s)
    {
        string answer = "";
        answer = s.Length % 2 == 0 ? s[s.Length / 2 - 1].ToString() + s[s.Length / 2].ToString() : s[s.Length / 2].ToString();
        return answer;
    }
    public string solution31(int n)
    {
        string answer = "";
        for (int i = 0; i < n; i++)
        {
            answer += i % 2 == 0 ? "수" : "박";
        }
        return answer;
    }
    public int solution32(int[] a, int[] b)
    {
        int answer = 0;
        for (int i = 0; i < a.Length; i++)
        {
            answer += a[i] * b[i];
        }
        return answer;
    }
    public string solution33(string s)
    {
        char[] temp = s.ToCharArray();
        Array.Sort(temp);
        Array.Reverse(temp);
        return s = new string(temp);
    }
    public string solution34(string s)
    {
        char[] temp = s.ToCharArray();
        Array.Sort(temp);
        Array.Reverse(temp);
        return s = new string(temp);
    }

    public long solution35(long price, long money, long count) //Wait 채점은 통과인데 테스트는 실패 ??
    {
        long tryCount = 1;
        long a = price;
        while (count != 0)
        {
            money -= a;
            tryCount++;
            a = price * tryCount;
            count--;
        }
        return money < 0 ? money * -1 : 0;
    }
    public bool solution36(string s)
    {
        if (s.Length == 4 || s.Length == 6)
        {
            return int.TryParse(s, out int w);
        }
        return false;
    }
    public int[,] solution37(int[,] arr1, int[,] arr2)
    {
        for (int i = 0; i < arr1.GetLength(0); i++)
        {
            for (int p = 0; p < arr1.GetLength(1); p++)
            {
                arr1[i, p] += arr2[i, p];
            }
        }
        return arr1;
    }
    public int[] solution39(int n, int m)
    {
        int a = 0;
        if (n < m)
        {
            for (int i = 1; i <= n; i++) //내림으로 하면 더 빠를듯
            {
                if (n % i == 0 && m % i == 0)
                {
                    a = i;
                }
            }
        }
        else
        {
            for (int i = 1; i <= m; i++)
            {
                if (n % i == 0 && m % i == 0)
                {
                    a = i;
                }
            }
        }
        int b = 0;
        int c = 0;
        if (n < m)
        {
            c = m;
        }
        else
        {
            c = n;
        }
        while (true)
        {
            if (c % m == 0 && c % n == 0)
            {
                b = c;
                break;
            }
            c++;
        }

        int[] answer = new int[] { a, b };
        return answer;
    }
    //40 스킵
    public string solution41(string s)
    {
        int w = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == ' ')
            {
                w++;
            }
        }
        string[] temp = new string[w];
        temp = s.Split(' ');
        string answer = "";
        foreach (var item in temp)
        {
            for (int i = 0; i < item.Length; i++)
            {
                int a = i + 1;
                if (a % 2 != 0)
                {
                    answer += item[i].ToString().ToUpper();
                }
                else
                {
                    answer += item[i].ToString().ToLower();
                }
            }
            answer += " ";
        }
        answer = answer.Remove(answer.Length - 1, 1);
        return answer;
    }
    public int solution42(int[] number)
    {
        int answer = 0;
        for (int i = 0; i < number.Length; i++)
        {
            for (int p = i + 1; p < number.Length; p++)
            {
                for (int u = p + 1; u < number.Length; u++)
                {
                    if (number[i] + number[p] + number[u] == 0)
                    {
                        answer++;
                    }
                }
            }
        }
        return answer;
    }
    public static int solution43(string t, string p)
    {
        int answer = 0;
        for (int i = 0; i < t.Length - p.Length; i++)
        {
            string temp = "";
            for (int u = i; u < p.Length + i; u++)
            {
                temp += t[u];
            }
            if (int.Parse(temp) <= int.Parse(p))
            {
                answer++;
            }
        }
        return answer;
    }
    //44
    public string solution45(string s, int n)
    {
        char[] answer = s.ToCharArray();
        s = "";
        foreach (var i in answer)
        {
            if (i == 32)
            {
                s += " ";
                continue;
            }
            if (i - 91 < 0)
            {
                s += ((char)(i + n >= 91 ? i + n - 26 : i + n)).ToString();
                continue;
            }
            s += ((char)(i + n >= 123 ? i + n - 26 : i + n)).ToString();
        }
        return s;
    }
    public int solution46(string s)
    {
        string answer = "";
        string aaa = "";
        for (int i = 0; i < s.Length; i++)
        {
            if (int.TryParse(s[i].ToString(), out int a))
            {
                answer += a.ToString();
            }
            else
            {
                aaa += s[i].ToString();
                switch (aaa)
                {
                    case "zero":
                        answer += "0"; aaa = "";
                        break;
                    case "one":
                        answer += "1"; aaa = "";
                        break;
                    case "two":
                        answer += "2"; aaa = "";
                        break;
                    case "three":
                        answer += "3"; aaa = "";
                        break;
                    case "four":
                        answer += "4"; aaa = "";
                        break;
                    case "five":
                        answer += "5"; aaa = "";
                        break;
                    case "six":
                        answer += "6"; aaa = "";
                        break;
                    case "seven":
                        answer += "7"; aaa = "";
                        break;
                    case "eight":
                        answer += "8"; aaa = "";
                        break;
                    case "nine":
                        answer += "9"; aaa = "";
                        break;
                }
            }
        }
        return int.Parse(answer);
    }
    public string[] solution47(string[] strings, int n)
    {
        char[] c = new char[strings.Length];
        for (int i = 0; i < strings.Length; i++)
        {
            c[i] = strings[i][n];
        }
        for (int i = 0; i < c.Length; i++)
        {
            for (int p = i; p < c.Length; p++)
            {
                if (c[i] == c[p])
                {
                    if (string.Compare(strings[i], strings[p]) == 1)
                    {
                        string temppp = strings[p];
                        strings[p] = strings[i];
                        strings[i] = temppp;
                        continue;
                    }
                }
                else if ((string.Compare(c[i].ToString(), c[p].ToString())) == 1)
                {
                    char temp = c[i];
                    c[i] = c[p];
                    c[p] = temp;
                    string tempp = strings[p];
                    strings[p] = strings[i];
                    strings[i] = tempp;
                }
            }
        }
        return strings;
    }
    public static int[] solution48(int[] array, int[,] commands)
    {
        int[] temp = new int[commands.GetLength(0)];
        for (int i = 0; i < commands.GetLength(0); i++)
        {
            List<int> t = new List<int>();
            for (int p = commands[i, 0] - 1; p < commands[i, 1]; p++)
            {
                t.Add(array[p]);
                t.Sort();
            }
            temp[i] = t[commands[i, 2] - 1];
        }
        return temp;
    }
    public int[] solution49(int[] numbers)
    {
        List<int> o = new List<int>();
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int p = 0; p < numbers.Length; p++)
            {
                if (i == p)
                {
                    continue;
                }
                int a = numbers[i] + numbers[p];
                if (!o.Contains(a))
                {
                    o.Add(a);
                }
            }
        }
        o.Sort();
        return o.ToArray();
    }
    public int[] solution50(string s)
    {
        List<int> a = new List<int>();
        for (int i = 0; i < s.Length; i++)
        {
            for (int p = i - 1; p > -1; p--)
            {
                if (s[i] == s[p])
                {
                    a.Add(i - p);
                    goto A;
                }
            }
            a.Add(-1);
        A:;
        }
        return a.ToArray();
    }
    public string solution51(int[] food)
    {
        List<int> a = new List<int>();
        for (int i = 1; i < food.Length; i++)
        {
            if (food[i] % 2 != 0)
            {
                food[i]--;
            }
            for (int p = 0; p < food[i]; p++)
            {
                a.Insert((int)(a.Count / 2), i);
            }
        }
        a.Insert(a.Count / 2, 0);
        string s = "";
        foreach (var item in a)
        {
            s += item.ToString();
        }
        return s;
    }
    public int solution52(int 마트가받는양, int 마트가주는양, int 빈병갯수)
    {
        int 받는양 = 0;
        while (빈병갯수 >= 마트가받는양)
        {
            받는양 += (빈병갯수 / 마트가받는양) * 마트가주는양;
            int 거래한횟수 = 빈병갯수 / 마트가받는양;
            빈병갯수 -= 마트가받는양 * 거래한횟수;
            빈병갯수 += 마트가주는양 * 거래한횟수;
        }
        return 받는양;
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        
    }
}
