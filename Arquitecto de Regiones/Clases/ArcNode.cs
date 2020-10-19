using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquitecto_de_Regiones.Clases
{
    public class ArcNode : Node
    {
        public override string Name => "Arc Node";
        public override int NArguments => 6;
        public override List<string> ArgumentName => new List<string> {"X", "Y", "Width", "Height", "Start Angle", "Sweep Angle" };
        public override (string,Color) Keyword => ("AddArc", DefaultColor);
        public override void ApplyNode(GraphicsPath gp)
        {
            gp.AddArc(
                Arguments[0], 
                Arguments[1],
                Math.Max(1, Arguments[2]),
                Math.Max(1, Arguments[3]), 
                Arguments[4],
                Arguments[5]);
        }
        public ArcNode()
        {
            Arguments = new int[] { 0, 0, 40, 40, 0, 90 };
        }
        public override string GenerateCode(string gp)
        {
            return $"{gp}.AddArc({Arguments[0]},{Arguments[1]},{Math.Max(1, Arguments[2])},{Math.Max(1, Arguments[3])},{Arguments[4]},{Arguments[5]});";
        }
    }
}
