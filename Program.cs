namespace Dictionary_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> openWith = new Dictionary<string, string>();
            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");
            openWith.Add("dib", "paint.exe");
            if (!openWith.ContainsKey("doc"))
            {
                openWith["doc"] = "winword.exe";
                Console.WriteLine("新增  Key = \"doc\", Value = {0} \n", openWith["doc"]);
            }


            Console.WriteLine("陳列 Dictionary 泛型物件 Key 與 Value 組配對資料");
            foreach (KeyValuePair<string, string> kvp in openWith)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }
            Console.Read();
        }
    }
}