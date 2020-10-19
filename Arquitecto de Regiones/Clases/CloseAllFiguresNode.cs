using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquitecto_de_Regiones.Clases
{
    public class CloseAllFiguresNode : Node
    {
        public override (string,Color) Keyword => ("CloseAllFigures", DefaultColor);
        public override string Name => "Close All Figures Node";
        public override int NArguments => 0;
        public override List<string> ArgumentName => new List<string> {""};
        public CloseAllFiguresNode()
        {
            Arguments = null;
        }
        public override void ApplyNode(GraphicsPath gp)
        {
            gp.CloseAllFigures();
        }
        public override string GenerateCode(string gp)
        {
            return $"{gp}.CloseAllFigures();";
        }
    }
}
