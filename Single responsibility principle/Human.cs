namespace Single_responsibility_principle
{
    [Serializable]
    public class Human
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public Human(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public Human()
        {
            Name = "Default Name";
            Age = 25;
        }
    }
}
