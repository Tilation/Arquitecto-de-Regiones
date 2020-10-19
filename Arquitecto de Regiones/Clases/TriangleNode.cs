using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquitecto_de_Regiones.Clases
{
    public class TriangleNode : Node
    {
        public override (string, Color) Keyword => ("AddPolygon", DefaultColor);
        public override string Name => "Triangle Node";
        public override int NArguments => 6;
        public override List<string> ArgumentName => new List<string>() {"X1", "Y1", "X2", "Y2", "X3", "Y3"};
        public TriangleNode()
        {
            Arguments = new int[] { 50, 0, 0, 50, 50, 50 };
        }
        public override void ApplyNode(GraphicsPath gp)
        {
            gp.AddPolygon(new Point[] { new Point(Arguments[0], Arguments[1]), new Point(Arguments[2], Arguments[3]), new Point(Arguments[4], Arguments[5])});
        }
        public override string GenerateCode(string gp)
        {
            return $"{gp}.AddPolygon(new Point[] {{ new Point({Arguments[0]}, {Arguments[1]}),new Point({Arguments[2]}, {Arguments[3]}), new Point({Arguments[4]}, {Arguments[5]})}});";
        }
    }
}
