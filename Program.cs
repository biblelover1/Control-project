
string [] words = {"hello", "world", "abc", "bcd"};
for(int i = 0; i < words.Length; i++)
{
    string s = words[i];
    char [] arr = s.ToCharArray();
    int length = arr.Length;
    if(length<=3)
    {
     Console.WriteLine(s);
    }
}
