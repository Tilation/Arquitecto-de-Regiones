using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arquitecto_de_Regiones.Clases
{
    public abstract class Node
    {
        public static Color DefaultColor => Color.DarkGoldenrod;
        public abstract (string, Color) Keyword { get; }
        public abstract string Name { get; }
        public abstract int NArguments { get; }
        public abstract List<string> ArgumentName { get; }
        public int[] Arguments { get; set; }
        public Type[] ArgumentTypes { get; set; }
        public abstract void ApplyNode(GraphicsPath gp);
        public abstract string GenerateCode(string gp);

        public Node NewInstance()
        {
            return (Node)Activator.CreateInstance(this.GetType());
        }

        public Node DuplicateNode()
        {
            Node n = (Node)MemberwiseClone();
            n.ArgumentTypes = ArgumentTypes;
            n.Arguments = Arguments;
            return n;
        }

        public int? GetArgumentValue(string argName)
        {
            if (NArguments > 0 && ArgumentName.Contains(argName))
            {
                return Arguments[ArgumentName.IndexOf(argName)];
            }
            else 
            {
                return null;
            }
        }
    }
}
