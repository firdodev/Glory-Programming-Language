namespace Glory.CodeAnalysis.Binding
{
    internal abstract class BoundNode {
        public abstract BoundNodeKind Kind { get; }
    }
}