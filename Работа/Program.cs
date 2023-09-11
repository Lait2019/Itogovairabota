string [] array1 = { "Hello", "2", "world", ":-)"};
int n = array1.Length;
string [] array2 = new string [0];
for (int i=0; i < n; i++)
{
    if (array1[i].Length < 4)
    {
        Array.Resize(ref array2, array2.Length + 1);
        array2[array2.Length - 1] = array1[i];
    }
}