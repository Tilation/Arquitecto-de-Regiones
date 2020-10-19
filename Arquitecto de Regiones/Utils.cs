using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arquitecto_de_Regiones
{
    public static class Utils
    {

        public static Rectangle ToRectangle(this RectangleF r)
        {
            return new Rectangle(
                (int)r.X,
                (int)r.Y,
                (int)r.Width,
                (int)r.Height
                );
        }
        public static void AppendLine(this RichTextBox tb, string line)
        {
            tb.AppendText($"{line}{Environment.NewLine}");
        }
        public static void ColorizePattern(this RichTextBox tb, string pattern, Color color, FontStyle extraStyle = FontStyle.Regular)
        {
            int selectStart = tb.SelectionStart;
            foreach (Match match in Regex.Matches(tb.Text, pattern))
            {
                tb.Select(match.Index, match.Length);
                tb.SelectionColor = color;
                if (extraStyle != FontStyle.Regular)
                {
                    tb.SelectionFont = new Font(tb.SelectionFont, extraStyle);
                }
                tb.Select(selectStart, 0);
                tb.SelectionColor = tb.ForeColor;
            };
        }
        
    }
}
