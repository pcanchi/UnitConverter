namespace CurCon
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.from = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.to = new System.Windows.Forms.ComboBox();
            this.calc = new System.Windows.Forms.Button();
            this.Amt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.converted = new System.Windows.Forms.TextBox();
            this.dataType = new System.Windows.Forms.Label();
            this.dataSelection = new System.Windows.Forms.ComboBox();
            this.Exit = new System.Windows.Forms.Button();
            this.swap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // from
            // 
            resources.ApplyResources(this.from, "from");
            this.from.FormattingEnabled = true;
            this.from.Name = "from";
            this.from.Sorted = true;
            this.from.SelectedValueChanged += new System.EventHandler(this.from_SelectedValueChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // to
            // 
            resources.ApplyResources(this.to, "to");
            this.to.FormattingEnabled = true;
            this.to.Name = "to";
            this.to.Sorted = true;
            this.to.SelectedValueChanged += new System.EventHandler(this.to_SelectedValueChanged);
            // 
            // calc
            // 
            resources.ApplyResources(this.calc, "calc");
            this.calc.Name = "calc";
            this.calc.UseVisualStyleBackColor = true;
            this.calc.Click += new System.EventHandler(this.calc_Click);
            // 
            // Amt
            // 
            resources.ApplyResources(this.Amt, "Amt");
            this.Amt.Name = "Amt";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // converted
            // 
            resources.ApplyResources(this.converted, "converted");
            this.converted.Name = "converted";
            // 
            // dataType
            // 
            resources.ApplyResources(this.dataType, "dataType");
            this.dataType.Name = "dataType";
            // 
            // dataSelection
            // 
            this.dataSelection.FormattingEnabled = true;
            this.dataSelection.Items.AddRange(new object[] {
            resources.GetString("dataSelection.Items"),
            resources.GetString("dataSelection.Items1"),
            resources.GetString("dataSelection.Items2")});
            resources.ApplyResources(this.dataSelection, "dataSelection");
            this.dataSelection.Name = "dataSelection";
            this.dataSelection.SelectedValueChanged += new System.EventHandler(this.dataSelection_SelectedValueChanged);
            // 
            // Exit
            // 
            this.Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.Exit, "Exit");
            this.Exit.Name = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // swap
            // 
            resources.ApplyResources(this.swap, "swap");
            this.swap.Name = "swap";
            this.swap.UseVisualStyleBackColor = true;
            this.swap.Click += new System.EventHandler(this.swap_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.calc;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.CancelButton = this.Exit;
            this.Controls.Add(this.swap);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.dataSelection);
            this.Controls.Add(this.dataType);
            this.Controls.Add(this.converted);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Amt);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.to);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.from);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox from;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox to;
        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.TextBox Amt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox converted;
        private System.Windows.Forms.Label dataType;
        private System.Windows.Forms.ComboBox dataSelection;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button swap;
    }
}

