namespace PCBuilder
{
    public abstract class Component
    {
        public string Name { get; }
        public int PowerChange { get; }

        public int TempChange { get; }
        
        public Component(string name, int powerChange, int tempChange)
        {
            Name = name;
            PowerChange = powerChange;
            TempChange = tempChange;
        }
        
    }
}