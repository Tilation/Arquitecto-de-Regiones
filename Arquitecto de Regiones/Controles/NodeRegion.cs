using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Arquitecto_de_Regiones.Clases;

namespace Arquitecto_de_Regiones.Controles
{
    public partial class NodeRegion : UserControl
    {
        private Node nodo;
        public Node Nodo
        {
            get => nodo;
            set
            { 
                nodo = value;
                CalculateArgumentoNodo();
            }
        }
        readonly int offset = 1;
        public event Action<Node> DeleteButtonClick;
        public event Action NodesChanged;
        public event Action<Node> DuplicateButtonClick;
        public event Action<Node> MoveNodeUp;
        public event Action<Node> MoveNodeDown;
        public NodeRegion(Node _nodo)
        {
            InitializeComponent();
            Nodo = _nodo;
        }
        void CalculateArgumentoNodo()
        {
            SuspendLayout();

            List<ArgumentoNodo> ars = tableLayoutPanelArgumentos.Controls.OfType<ArgumentoNodo>().ToList();

            foreach (ArgumentoNodo ar in ars)
            {
                tableLayoutPanelArgumentos.Controls.Remove(ar);
            }

            labelNodeName.Text = $"[{Nodo.Name}]";
            tableLayoutPanelArgumentos.ColumnCount = (Nodo.NArguments + offset > tableLayoutPanelArgumentos.ColumnCount) ? Nodo.NArguments + offset : tableLayoutPanelArgumentos.ColumnCount;

            for (int i = 0; i < Nodo.NArguments; i++)
            {
                ArgumentoNodo an = new ArgumentoNodo
                {
                    Text = Nodo.ArgumentName[i],
                    Value = Nodo.GetArgumentValue(Nodo.ArgumentName[i]) ?? 0
                };
                an.OnValueChanged += ArgValueChanged;
                tableLayoutPanelArgumentos.Controls.Add(an, i + offset, 0);
                an.Dock = DockStyle.Fill;
            }
            ResumeLayout();
        }

        private void ArgValueChanged()
        {
            int[] args = new int[Nodo.NArguments];

            for (int i = 0; i < Nodo.NArguments; i++)
            {
                string argName = Nodo.ArgumentName[i];
                ArgumentoNodo nud = tableLayoutPanelArgumentos.Controls.OfType<ArgumentoNodo>().First(x => x.Name == argName);
                args[i] = (int)nud.Value;
            }
            Nodo.Arguments = args;
            NodesChanged?.Invoke();
        }

        private void DeleteClick(object sender, EventArgs e)
        {
            DeleteButtonClick?.Invoke(Nodo);
        }

        private void DuplicateClick(object sender, EventArgs e)
        {
            DuplicateButtonClick?.Invoke(Nodo);
        }

        private void ButtonMoveDown_Click(object sender, EventArgs e)
        {
            MoveNodeDown?.Invoke(Nodo);
        }

        private void ButtonMoveUp_Click(object sender, EventArgs e)
        {
            MoveNodeUp?.Invoke(Nodo);
        }
    }
}
