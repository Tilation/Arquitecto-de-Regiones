using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquitecto_de_Regiones.Clases
{
    public class RectangleNode : Node
    {
        public override (string, Color) Keyword => ("AddRectangle", DefaultColor);
        public override string Name => "Rectangle Node";
        public override int NArguments => 4;
        public override List<string> ArgumentName => new List<string>() { "X", "Y", "Width", "Height" };
        public RectangleNode()
        {
            Arguments = new int[] { 0, 0, 50, 50 };
        }
        public override void ApplyNode(GraphicsPath gp)
        {
            gp.AddRectangle(new Rectangle(Arguments[0], Arguments[1], Arguments[2], Arguments[3]));
        }
        public override string GenerateCode(string gp)
        {
            return $"{gp}.AddRectangle(new Rectangle({Arguments[0]}, {Arguments[1]}, {Arguments[2]}, {Arguments[3]}));";
        }
    }
}
