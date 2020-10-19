using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;

namespace Arquitecto_de_Regiones.Controles
{
    public partial class ArgumentoNodo : UserControl
    {
        public new string Name 
        {
            get => Text;
            set => Text = value;
        }
        public int Value { get => (int)numericUpDown1.Value; set => numericUpDown1.Value = value; }


        public new string Text 
        {
            get => labelArgName.Text;
            set => labelArgName.Text = value;
        }

        public event Action OnValueChanged;
        public ArgumentoNodo()
        {
            InitializeComponent();
            numericUpDown1.Minimum = decimal.MinValue;
            numericUpDown1.Maximum = decimal.MaxValue;
            numericUpDown1.DecimalPlaces = 0;
            numericUpDown1.Increment = 1;
        }

        private void NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            OnValueChanged?.Invoke();
        }
    }
}
