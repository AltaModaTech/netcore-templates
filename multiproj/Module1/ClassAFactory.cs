namespace Module1
{

    public static class ClassAFactory
    {
        public static ClassA Create(string name)
        {
            return new ClassA(name);
        }
    }

}