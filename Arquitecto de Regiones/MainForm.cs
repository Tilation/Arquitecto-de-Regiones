using Arquitecto_de_Regiones.Clases;
using Arquitecto_de_Regiones.Controles;
using Arquitecto_de_Regiones.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arquitecto_de_Regiones
{ 
    public partial class MainForm : Form
    {
        TestForm exampleForm;
        readonly string gpname = "gp";

        GraphicsPath graphicsPath;
        Region region;

        Region backupRegion;

        List<NodeRegion> NodeRegions => panelContenedor.Controls.OfType<NodeRegion>().ToList();

        readonly Dictionary<string, Color> otherLinters = new Dictionary<string, Color>
        {
            {"GraphicsPath", Color.DarkOliveGreen},

            {"\nRegion",Color.DarkOliveGreen },
            {"Region\\(",Color.DarkOliveGreen },

            {"new ",Color.DarkBlue },

            {"\nForm",Color.DarkOliveGreen },
            {"Form\\(",Color.DarkOliveGreen },

            {"\nRectangle",Color.DarkOliveGreen },
            {"Rectangle\\(",Color.DarkOliveGreen },

            {"\nSize",Color.DarkOliveGreen },
            {"Size\\(",Color.DarkOliveGreen },

            {"Show\\(\\)",Color.DarkGoldenrod },
            {" FormBorderStyle",Color.DarkGoldenrod },

            {"\nint",Color.DarkBlue },

            {"GetBounds\\(\\)",Color.DarkGoldenrod }
        };

        List<Node> nodes;

        public MainForm()
        {
            InitializeComponent();

            backupRegion = panelRegion.Region;
            nodes = new List<Node>();

            comboBox1.DisplayMember = "Name";

            comboBox1.Items.Add(new LineNode());
            comboBox1.Items.Add(new ArcNode());
            comboBox1.Items.Add(new BezierNode());
            comboBox1.Items.Add(new EllipseNode());
            comboBox1.Items.Add(new DiamondNode());
            comboBox1.Items.Add(new QuadNode());
            comboBox1.Items.Add(new TriangleNode());
            comboBox1.Items.Add(new RectangleNode());
            comboBox1.Items.Add(new CloseAllFiguresNode());
        }


        void UpdateGraphicsPath()
        {
            graphicsPath = null;

            if (nodes.Count > 0)
            {
                // Si hay nodos, se aplican y se crea una region nueva
                graphicsPath = new GraphicsPath();
                foreach (Node n in nodes)
                {
                    n.ApplyNode(graphicsPath);
                }
                region = new Region(graphicsPath);
                panelRegion.Region = region;
            }
            else
            {
                //  Si no hay nodos, se usa la region de respaldo
                region = backupRegion;
                panelRegion.Region = backupRegion;
            }
            
            //  Finalmente se actualiza el formulario
            UpdateExampleForm(graphicsPath, panelRegion.Region);
        }

        void DeleteNode(Node n)
        {
            if (nodes.Contains(n))
            {
                //  Buscar y remover el control de configuracion
                NodeRegion nr = panelContenedor.Controls.OfType<NodeRegion>().Single(x => x.Nodo == n);
                panelContenedor.Controls.Remove(nr);

                //  Remover el nodo de la lista de nodos
                nodes.Remove(n);

                UpdateCodeOutput();
                UpdateGraphicsPath();
            }
        }

        void AgregarNodo(Node n, bool duplication = false)
        {
            if (n != null)
            {
                // Si hay que duplicar, se duplica, sino se crea una nueva instancia del nodo seleccioando
                Node nodo = (duplication == true) ? n : n.NewInstance();

                nodes.Add(nodo);

                //  Se crea un nuevo control para poder configurar el nodo
                NodeRegion nr = new NodeRegion(nodo);
                panelContenedor.Controls.Add(nr);

                //  Se registran los eventos del nuevo control configurador
                nr.DeleteButtonClick += DeleteNode;
                nr.DuplicateButtonClick += DuplicateNode;
                nr.MoveNodeDown += MoveNodeDown;
                nr.MoveNodeUp += MoveNodeUp;
                nr.NodesChanged += NodesChanged;

                //  Se actualizan las salidas de codigo y graficos
                UpdateCodeOutput();
                UpdateGraphicsPath();
            }
        }

        private void MoveNodeUp(Node node)
        {
            int nodeInd = nodes.IndexOf(node);

            //  Si no esta arriba del todo, se mueve
            if (nodeInd > 0)
            {
                // Se busca el nodo anterior y se aplica el intercambio
                int previousInd = nodeInd - 1;
                Node prev = nodes[previousInd];
                NodeRegion prevNR = NodeRegions.Single(x => x.Nodo == prev);
                NodeRegion currNR = NodeRegions.Single(x => x.Nodo == node);
                prevNR.Nodo = node;
                currNR.Nodo = prev;
                nodes[previousInd] = node;
                nodes[nodeInd] = prev;

                UpdateCodeOutput();
                UpdateGraphicsPath();
            }
        }

        private void MoveNodeDown(Node node)
        {
            int nodeInd = nodes.IndexOf(node);

            //  Si no esta abajo del todo
            if (nodeInd < nodes.Count - 1)
            {

                // Se busca el nodo proximo y se aplica el intercambio
                int nextInd = nodeInd + 1;
                Node next = nodes[nextInd];
                NodeRegion nextNR = NodeRegions.Single(x => x.Nodo == next);
                NodeRegion currNR = NodeRegions.Single(x => x.Nodo == node);
                nextNR.Nodo = node;
                currNR.Nodo = next;
                nodes[nextInd] = node;
                nodes[nodeInd] = next;

                UpdateCodeOutput();
                UpdateGraphicsPath();
            }
        }

        private void DuplicateNode(Node n)
        {
            Node nn = n.NewInstance();
            nn.Arguments = n.Arguments;
            AgregarNodo(nn, true);
        }

        private void NodesChanged()
        {
            UpdateGraphicsPath();
            UpdateCodeOutput();
        }

        /// <summary>
        /// Genera el código responsable de recrear la región diseñada
        /// </summary>
        private void UpdateCodeOutput()
        {
            // Creación de un buffer temporal
            RichTextBox rtb = new RichTextBox();

            rtb.AppendLine($"GraphicsPath {gpname} = new GraphicsPath();");

            //  Por cada nodo agregado, se genera su código C#
            foreach(Node n in nodes)
            {
                rtb.AppendLine(n.GenerateCode(gpname));
            }

            rtb.AppendLine($"Region region = new Region({gpname});");

            //  Si estamos usando el formulario de ejemplo, crear el código para él también
            if (exampleForm != null && exampleForm.Visible)
            {
                rtb.AppendLine($"Form form = new Form();");
                rtb.AppendLine($"form.FormBorderStyle = FormBorderStyle.FixedToolWindow;");

                rtb.AppendLine($@"Size newSize = new Size(
(int)({gpname}.GetBounds().Size.Width + {gpname}.GetBounds().Location.X),
(int)({gpname}.GetBounds().Size.Height + {gpname}.GetBounds().Location.Y)
);");
                rtb.AppendLine($"form.Bounds = new Rectangle(form.Bounds.Location, newSize);");
                rtb.AppendLine($"form.Region = region;");
                rtb.AppendLine($"form.Show();");
            }

            // Suspendemos la actualizacion del control para prevenir flickering temporalmente 
            richTextBoxCode.SuspendLayout();
            richTextBoxCode.Text = rtb.Text;
            LinterText(richTextBoxCode);
            richTextBoxCode.ResumeLayout();
        }

        /// <summary>
        /// Encargado de marcar la sintaxis en el RichTextBox
        /// </summary>
        void LinterText(RichTextBox rtb)
        {
            foreach (Node n in comboBox1.Items)
            {
                rtb.ColorizePattern(n.Keyword.Item1, n.Keyword.Item2, FontStyle.Bold);
            }
            foreach (KeyValuePair<string,Color> s in otherLinters)
            {
                rtb.ColorizePattern(s.Key, s.Value, FontStyle.Bold);
            }
        }

        private void Button_AgregarNodo(object sender, EventArgs e)
        {
            AgregarNodo((Node)comboBox1.SelectedItem);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateCodeOutput();
        }

        void UpdateExampleForm(GraphicsPath gp, Region reg)
        {
            if (gp == null && exampleForm != null)
            {
                exampleForm.Dispose();
            }
            if (exampleForm != null && !exampleForm.IsDisposed)
            {
                Size newSize = new Size(
                    (int)(gp.GetBounds().Width + gp.GetBounds().X),
                    (int)(gp.GetBounds().Height + gp.GetBounds().Y)
                );
                exampleForm.Bounds = new Rectangle(exampleForm.Bounds.Location, newSize);
                exampleForm.Region = reg;
            }
        }
        private void ShowExampleForm_Click(object sender, EventArgs e)
        {
            if (graphicsPath != null)
            {
                if (exampleForm == null || exampleForm.IsDisposed)
                {
                    exampleForm = new TestForm();
                    exampleForm.Region = region;
                    Size newSize = new Size(
                        (int)(graphicsPath.GetBounds().Size.Width + graphicsPath.GetBounds().X),
                        (int)(graphicsPath.GetBounds().Size.Height + graphicsPath.GetBounds().Y)
                        );
                    exampleForm.Bounds = new Rectangle(exampleForm.Bounds.Location, newSize);
                    exampleForm.Show();
                    
                }
                else
                {
                    exampleForm.Dispose();
                }
                UpdateCodeOutput();
            }

        }
    }
}
