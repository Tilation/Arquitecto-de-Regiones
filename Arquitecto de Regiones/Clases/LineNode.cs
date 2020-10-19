using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquitecto_de_Regiones.Clases
{
    public class LineNode : Node
    {
        public override (string, Color) Keyword => ("AddLine", DefaultColor);
        public override string Name => "Line Node";
        public override int NArguments => 4;
        public override List<string> ArgumentName => new List<string>() {"X1", "Y1" , "X2", "Y2" };
        public LineNode()
        {
            Arguments = new int[] { 0, 0, 50, 50 };
        }
        public override void ApplyNode(GraphicsPath gp)
        {
            gp.AddLine(Arguments[0], Arguments[1], Arguments[2], Arguments[3]);
        }
        public override string GenerateCode(string gp)
        {
            return $"{gp}.AddLine({Arguments[0]}, {Arguments[1]}, {Arguments[2]}, {Arguments[3]});";
        }
    }
}
