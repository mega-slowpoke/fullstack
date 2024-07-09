public class Exercise2
{

    /**
     * QUESTION 1
     * 1. string is used for immutable text, while stringbuilder is used when we construct a string
     *
     * 2. System.Array
     *
     * 3. Array.sort()
     *
     * 4. .Length
     *
     * 5. No, only data of the same type can be stored in an arry
     */


    /*
    * Practice 1
    */
    public void CopyArray()
    {
        int[] arr1 = new int[10];
        for (int i = 0; i < arr1.Length; i++)
        {
            arr1[i] = i;
        }
        
        int[] arr2 = new int[arr1.Length];
        for (int i = 0; i < arr2.Length; i++)
        {
            arr2[i] = arr1[i];
        }
        
        Console.WriteLine("Original Array:");
        for (int i = 0; i < arr1.Length; i++)
        {
            Console.Write($"{arr1[i]}, ");
        }
        
        Console.WriteLine("\nCopied Array:");
        for (int i = 0; i < arr2.Length; i++)
        {
            Console.Write($"{arr2[i]}, ");
        }
    }


    /*
     * Practice 2
     */
    public void ManageList()
    {
        List<string> toDoList = new List<string>();

        while (true)
        {
            Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
            Console.WriteLine("+ <item>  : Add");
            Console.WriteLine("- <item>  : Remove");
            Console.WriteLine("--        : Clear the list");
            Console.WriteLine("Enter 'q' to quit");

            string userInput = Console.ReadLine();

            if (userInput.StartsWith('+'))
            {
                string item = userInput.Substring(1).Trim();
                toDoList.Add(item);
                Console.WriteLine($"'{item}' added to the list.");
            }
            else if (userInput.StartsWith('-'))
            {
                string item = userInput.Substring(1).Trim();
                if (toDoList.Contains(item))
                {
                    toDoList.Remove(item);
                    Console.WriteLine($"'{item}' removed from the list.");
                }
                else
                {
                    Console.WriteLine($"'{item}' is not in the list.");
                }
            }
            else if (userInput == "--")
            {
                toDoList.Clear();
                Console.WriteLine("List cleared.");
            }
            else if (userInput.ToLower() == "q")
            {
                Console.WriteLine("Exiting program.");
                break;
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
    
    /*
     * Practice 3
     */
    public int[] FindPrimesInRange(int startNum, int endNum) 
    {
        List<int> lst = new List<int>();

        for (int num = startNum; num <= endNum; num++)
        {
            if (IsPrime(num))
            {
                lst.Add(num);
            }
        }

        return lst.ToArray();
    }
    
    private bool IsPrime(int num)
    {
        if (num < 2) 
        {
            return false;
        }
        
        if (num == 2)
        {
            return true;
        }
        
        
        for (int i = 3; i * i <= num; i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }

        return true;
    }


    /*
     * Practice 4
     */
    public void RotateArrSum()
    {
        string[] input = Console.ReadLine().Split();
        int[] arr = new int[input.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(input[i]);
        }
        int k = int.Parse(Console.ReadLine());

        int n = arr.Length;
        int[] sums = new int[n];
        
        for (int i = 1; i <= k; i++)
        {
            int[] tempArr = Rotate(arr, i);
            for (int idx = 0; idx < n; idx++)
            {
                sums[idx] += tempArr[idx];
            }
        }
        
        Console.WriteLine(string.Join(" ", sums));
    }
    
    private int[] Rotate(int[] arr, int r)
    {
        int n = arr.Length;
        int[] rotated = new int[n];
        
        for (int i = 0; i < n; i++)
        {
            rotated[(i + r) % n] = arr[i];
        }
        
        return rotated;
    }
    
    
    /*
     * Practice 5
     */
    public int[] LongestSubarray(int[] arr)
    {

        int left = 0;
        int right = 1;
        int maxNum = arr[1];
        int maxCnt = 1;
        
        while (right < arr.Length)
        {
            int cur = arr[right];
            right++;
            
            while (left < right && arr[left] != cur)
            {
                left++;
            }

            if (right - left > maxCnt)
            {
                maxCnt = right - left;
                maxNum = cur;
            }
        }
        
        int[] res = new int[maxCnt];
        for (int i = 0; i < maxCnt; i++)
        {
            res[i] = maxNum;
        }
        return res;
    }
    
    /*
     * Practice 7
     */
    public static int MostFrequentNumber(int[] arr)
    {
        // Dictionary to count frequencies
        Dictionary<int, int> map = new Dictionary<int, int>();

        foreach (int num in arr)
        {
            if (map.ContainsKey(num))
            {
                map[num]++;
            }
            else
            {
                map[num] = 1;
            }
        }
        
        int maxCnt = -1;
        int res = 0;
        foreach (var pair in map)
        {
            if (pair.Value > maxCnt)
            {
                maxCnt = pair.Value;
                res = pair.Key;
            }
        }
        
        return res;
    }
    
    
    /*
     * 1
     */

    public void reverseStr1()
    {
        Console.WriteLine("Enter string: ");
        string input = Console.ReadLine();
        
        char[] charArray = input.ToCharArray();
        string reversed = new string(charArray);
        
        Console.WriteLine($"Reversed string: {reversed}");
    }
    
    public void reverseStr2()
    {
        Console.WriteLine("Enter string: ");
        string input = Console.ReadLine();


        for (int i = input.Length - 1; i >= 0; i--)
        {
            Console.Write(input[i]);
        }
    }

    private void MyReverse(char[] chars, int start, int end)
    {
        while (start < end)
        {
            char temp = chars[start];
            chars[start] = chars[end];
            chars[end] = temp;
            start++;
            end--;
        }
    }
    
    /*
     * 2
     */
    public string ReverseSentence(string sentence)
    {
        char[] separators = { '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' };

        // Split the sentence into words and separators
        List<string> parts = new List<string>();
        List<char> separatorsFound = new List<char>();

        int startIndex = 0;
        for (int i = 0; i < sentence.Length; i++)
        {
            char currentChar = sentence[i];
            if (Array.IndexOf(separators, currentChar) != -1)
            {
                // Found a separator
                parts.Add(sentence.Substring(startIndex, i - startIndex));
                separatorsFound.Add(currentChar);
                startIndex = i + 1;
            }
        }
        if (startIndex < sentence.Length)
        {
            parts.Add(sentence.Substring(startIndex));
        }

        parts.Reverse();

        string reversedSentence = "";
        for (int i = 0; i < parts.Count; i++)
        {
            reversedSentence += parts[i];
            if (i < separatorsFound.Count)
            {
                reversedSentence += separatorsFound[i];
            }
        }

        return reversedSentence.Trim();
    }
    
    /*
     * 3
     */
    public void FindPalindromes(string text)
    {
        HashSet<string> palindromeSet = new HashSet<string>();
        string[] strs = text.Split(" ");
        foreach (string str in strs)
        {
            if (IsPalindrome(str))
            {
                palindromeSet.Add(str);
            }
        }
        
        string[] sortedPalindromes = palindromeSet.OrderBy(p => p).ToArray();
        string result = string.Join(", ", sortedPalindromes);
        Console.WriteLine(result);
    }
    
    private bool IsPalindrome(string word)
    {
        int left = 0;
        int right = word.Length - 1;
        
        while (left < right)
        {
            while (left < right && !IsLetter(word[left])) left++;
            while (left < right && !IsLetter(word[right])) right--;
            
            if (word[left] != word[right])
            {
                return false;
            }
            left++;
            right--;
        }
        
        return true;
    }

    private bool IsLetter(char c)
    {
        return (c <= 'z' && c >= 'a') || (c <= 'Z' && c >= 'A');
    }
    
    
    /*
     * 4
     */
    public void Parse(string url)
    {
        string[] tempStrs = url.Split("://");
        string protocol = tempStrs[0];
        
        string[] serverResourceSplit = tempStrs[1].Split("/"); 
        string server = serverResourceSplit[0]; 
        string resource = serverResourceSplit.Length > 1 ? serverResourceSplit[1] : ""; 
        
        Console.WriteLine("[protocol] = " + protocol);
        Console.WriteLine("[server] = " + server);
        Console.WriteLine("[resource] = " + resource);
    }
    
}



