namespace Arquitecto_de_Regiones
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelCanvas = new System.Windows.Forms.Panel();
            this.panelRegion = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.FlowLayoutPanel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonAgregarNodo = new System.Windows.Forms.Button();
            this.labelOutCode = new System.Windows.Forms.Label();
            this.richTextBoxCode = new System.Windows.Forms.RichTextBox();
            this.buttonShowExampleForm = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelCanvas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelCanvas, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelContenedor, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.buttonAgregarNodo, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelOutCode, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.richTextBoxCode, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonShowExampleForm, 3, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.85714F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(631, 403);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Location = new System.Drawing.Point(265, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Real time previsualization:";
            // 
            // panelCanvas
            // 
            this.panelCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.panelCanvas, 2);
            this.panelCanvas.Controls.Add(this.panelRegion);
            this.panelCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCanvas.Location = new System.Drawing.Point(264, 19);
            this.panelCanvas.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelCanvas.Name = "panelCanvas";
            this.tableLayoutPanel1.SetRowSpan(this.panelCanvas, 2);
            this.panelCanvas.Size = new System.Drawing.Size(365, 176);
            this.panelCanvas.TabIndex = 8;
            // 
            // panelRegion
            // 
            this.panelRegion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelRegion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRegion.Location = new System.Drawing.Point(0, 0);
            this.panelRegion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelRegion.Name = "panelRegion";
            this.panelRegion.Size = new System.Drawing.Size(363, 174);
            this.panelRegion.TabIndex = 1;
            // 
            // panelContenedor
            // 
            this.panelContenedor.AutoScroll = true;
            this.panelContenedor.AutoScrollMargin = new System.Drawing.Size(10, 0);
            this.panelContenedor.AutoSize = true;
            this.panelContenedor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelContenedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.panelContenedor, 2);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(3, 4);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.tableLayoutPanel1.SetRowSpan(this.panelContenedor, 5);
            this.panelContenedor.Size = new System.Drawing.Size(256, 359);
            this.panelContenedor.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 371);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(171, 25);
            this.comboBox1.TabIndex = 2;
            // 
            // buttonAgregarNodo
            // 
            this.buttonAgregarNodo.AutoSize = true;
            this.buttonAgregarNodo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAgregarNodo.Location = new System.Drawing.Point(180, 371);
            this.buttonAgregarNodo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAgregarNodo.Name = "buttonAgregarNodo";
            this.buttonAgregarNodo.Size = new System.Drawing.Size(79, 27);
            this.buttonAgregarNodo.TabIndex = 3;
            this.buttonAgregarNodo.Text = "Add Node";
            this.buttonAgregarNodo.UseVisualStyleBackColor = true;
            this.buttonAgregarNodo.Click += new System.EventHandler(this.Button_AgregarNodo);
            // 
            // labelOutCode
            // 
            this.labelOutCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelOutCode.AutoSize = true;
            this.labelOutCode.Location = new System.Drawing.Point(265, 214);
            this.labelOutCode.Name = "labelOutCode";
            this.labelOutCode.Size = new System.Drawing.Size(84, 17);
            this.labelOutCode.TabIndex = 5;
            this.labelOutCode.Text = "Code output:";
            // 
            // richTextBoxCode
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.richTextBoxCode, 2);
            this.richTextBoxCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxCode.Location = new System.Drawing.Point(264, 234);
            this.richTextBoxCode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.richTextBoxCode.Name = "richTextBoxCode";
            this.richTextBoxCode.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.richTextBoxCode, 2);
            this.richTextBoxCode.Size = new System.Drawing.Size(365, 166);
            this.richTextBoxCode.TabIndex = 6;
            this.richTextBoxCode.Text = "";
            // 
            // buttonShowExampleForm
            // 
            this.buttonShowExampleForm.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonShowExampleForm.AutoSize = true;
            this.buttonShowExampleForm.Location = new System.Drawing.Point(422, 201);
            this.buttonShowExampleForm.Name = "buttonShowExampleForm";
            this.buttonShowExampleForm.Size = new System.Drawing.Size(206, 27);
            this.buttonShowExampleForm.TabIndex = 10;
            this.buttonShowExampleForm.Text = "Show / Terminate Preview Form";
            this.buttonShowExampleForm.UseVisualStyleBackColor = true;
            this.buttonShowExampleForm.Click += new System.EventHandler(this.ShowExampleForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 403);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "C# - WinForms - Region Architect";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panelCanvas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel panelContenedor;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonAgregarNodo;
        private System.Windows.Forms.Label labelOutCode;
        private System.Windows.Forms.RichTextBox richTextBoxCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelCanvas;
        private System.Windows.Forms.Panel panelRegion;
        private System.Windows.Forms.Button buttonShowExampleForm;
    }
}

