using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquitecto_de_Regiones.Clases
{
    public class QuadNode : Node
    {
        public override (string, Color) Keyword => ("AddPolygon", DefaultColor);
        public override string Name => "Quad Node";
        public override int NArguments => 8;
        public override List<string> ArgumentName => new List<string>() { "X1", "Y1", "X2", "Y2", "X3", "Y3", "X4", "Y4" };

        public QuadNode()
        {
            Arguments = new int[] { 
                         25, 0,
                50, 25,          25, 50,
                         0, 25 
            };
        }
        public override void ApplyNode(GraphicsPath gp)
        {
            gp.AddPolygon(new Point[] { new Point(Arguments[0], Arguments[1]), new Point(Arguments[2], Arguments[3]), new Point(Arguments[4], Arguments[5]), new Point(Arguments[6], Arguments[7]) });
        }
        public override string GenerateCode(string gp)
        {
            return $"{gp}.AddPolygon(new Point[] {{ new Point({Arguments[0]}, {Arguments[1]}),new Point({Arguments[2]}, {Arguments[3]}), new Point({Arguments[4]}, {Arguments[5]}),new Point({Arguments[6]}, {Arguments[7]})}});";
        }

    }
}
