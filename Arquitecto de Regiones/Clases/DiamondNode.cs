using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquitecto_de_Regiones.Clases
{
    public class DiamondNode : Node
    {
        public override (string, Color) Keyword => ("AddPolygon", DefaultColor);
        public override string Name => "Diamond Node";
        public override int NArguments => 4;
        public override List<string> ArgumentName => new List<string>() { "X", "Y", "Width", "Height"};

        public DiamondNode()
        {
            Arguments = new int[] {
                0, 0,
                50, 50
            };
        }
        public override void ApplyNode(GraphicsPath gp)
        {
            gp.AddPolygon(new Point[] {
                new Point(Arguments[0] + Arguments[2]/2 , Arguments[1]),
                new Point(Arguments[0] + Arguments[2]   , Arguments[1] + Arguments[3]/2),
                new Point(Arguments[0] + Arguments[2]/2 , Arguments[1] + Arguments[3]),
                new Point(Arguments[0]                  , Arguments[1] + Arguments[3]/2)
                });
        }
        public override string GenerateCode(string gp)
        {
            return $@"{gp}.AddPolygon(new Point[] {{
                new Point({Arguments[0]} + {Arguments[2]}/ 2, {Arguments[1]}), 
                new Point({Arguments[0]} + {Arguments[2]}, {Arguments[1]} + {Arguments[3]} / 2),
                new Point({Arguments[0]} + {Arguments[2]}/2 , {Arguments[1]} + {Arguments[3]}),
                new Point({Arguments[0]}, {Arguments[1]} + {Arguments[3]}/2)
            }});";
        }

    }
}
