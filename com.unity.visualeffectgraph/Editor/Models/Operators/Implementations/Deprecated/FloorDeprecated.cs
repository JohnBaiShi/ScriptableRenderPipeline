using System;

namespace UnityEditor.VFX.Operator
{
    class FloorDeprecated : VFXOperatorUnaryFloatOperation
    {
        override public string name { get { return "Floor (deprecated)"; } }

        protected override sealed VFXExpression[] BuildExpression(VFXExpression[] inputExpression)
        {
            return new[] { new VFXExpressionFloor(inputExpression[0]) };
        }

        public sealed override void Sanitize(int version)
        {
            base.Sanitize(version);
            SanitizeHelper.ToOperatorWithoutFloatN(this, typeof(Floor));
        }
    }
}
