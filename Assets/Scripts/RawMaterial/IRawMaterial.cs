public interface IRawMaterial
{
    float Weight { get;  }
    int MaxStack { get; }
    string Description { get; }
    RawMaterialType Type { get; }
}