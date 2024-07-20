public interface IResource 
{
    public float Weight { get; }
    public int MaxStack { get; }
    public string Description { get; }
    public ResourceType Type { get; }
}