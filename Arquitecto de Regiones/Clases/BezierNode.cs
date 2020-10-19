using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquitecto_de_Regiones.Clases
{
    public class BezierNode : Node
    {
        public override (string, Color) Keyword => ("AddBezier", DefaultColor);
        public override string Name => "Bezier Node";
        public override int NArguments => 8;
        public override List<string> ArgumentName => new List<string>() {"X1","Y1", "X2", "Y2", "X3", "Y3", "X4", "Y4", };
        public BezierNode()
        {
            Arguments = new int[] { 0, 0, 0, 0, 0, 0, 0, 0 };
        }
        public override void ApplyNode(GraphicsPath gp)
        {
            gp.AddBezier(Arguments[0], Arguments[1], Arguments[2], Arguments[3], Arguments[4], Arguments[5], Arguments[6], Arguments[7]);
        }
        public override string GenerateCode(string gp)
        {
            return $"{gp}.AddBezier({Arguments[0]},{Arguments[1]},{Arguments[2]},{Arguments[3]},{Arguments[4]},{Arguments[5]},{Arguments[6]},{Arguments[7]});";
        }
    }
}
