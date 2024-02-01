namespace Glory.CodeAnalysis.Binding
{
    internal sealed class BoundBinaryExpression : BoundExpression {
        public BoundBinaryExpression(BoundExpression left, BoundBinaryOperatorKind operatorKind, BoundExpression right){
            Left = left;
            OperatorKind = operatorKind;
            Right = right;
        }

        public override Type Type => Left.Type;
        public BoundBinaryOperatorKind OperatorKind { get; }
        public BoundExpression Right { get; }
        public BoundExpression Left { get; }
        

        public override BoundNodeKind Kind => BoundNodeKind.BinaryExpression;
    }
}