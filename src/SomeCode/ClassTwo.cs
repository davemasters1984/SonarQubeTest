namespace SomeCode
{
    public class ClassTwo
    {
        public string One { get; set; }
        public string Two { get; set; }
        public string Three { get; set; }
        public string Four { get; set; }
        public string Five { get; set; }

        public ClassTwo(string one, string two, string three, string four, string five)
        {
            One = one;
            Two = two;
            Three = three;
            Four = four;
            Five = five;

            if (Five == null)
                Five.ToString();
        }
    }
}
