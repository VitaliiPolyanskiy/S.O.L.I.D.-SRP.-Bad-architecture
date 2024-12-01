namespace Single_responsibility_principle
{
    class Program
    {
        static void Main(string[] args)
        {
            Сontainer c = new Сontainer();
            c.Add(new Human("Larry Page", 50));
            c.Add(new Human("Satya Nadella", 56));
            c.Add(new Human("Tim Cook", 62));
            c.Print();
            c.SaveXmlSerializer();
            c.RemoveAll();
            c.Print();
            c.LoadXmlSerializer();
            c.Print();
        }
    }
}
