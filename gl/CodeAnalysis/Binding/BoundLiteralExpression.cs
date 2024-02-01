namespace Glory.CodeAnalysis.Binding
{
    internal sealed record BoundLiteralExpression(object Value) : BoundExpression
    {
        public override BoundNodeKind Kind => BoundNodeKind.LiteralExpression;
        public override Type Type => Value.GetType();
    }
}