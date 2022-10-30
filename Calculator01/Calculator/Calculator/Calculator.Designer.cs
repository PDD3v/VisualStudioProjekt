namespace Calculator
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.Result = new System.Windows.Forms.TextBox();
            this.x7 = new System.Windows.Forms.Button();
            this.x4 = new System.Windows.Forms.Button();
            this.x1 = new System.Windows.Forms.Button();
            this.x2 = new System.Windows.Forms.Button();
            this.x5 = new System.Windows.Forms.Button();
            this.x8 = new System.Windows.Forms.Button();
            this.x3 = new System.Windows.Forms.Button();
            this.x6 = new System.Windows.Forms.Button();
            this.x9 = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.exponentiation = new System.Windows.Forms.Button();
            this.x0 = new System.Windows.Forms.Button();
            this.comma = new System.Windows.Forms.Button();
            this.xC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Result
            // 
            resources.ApplyResources(this.Result, "Result");
            this.Result.Name = "Result";
            // 
            // x7
            // 
            this.x7.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.x7, "x7");
            this.x7.Name = "x7";
            this.x7.UseVisualStyleBackColor = false;
            this.x7.Click += new System.EventHandler(this.OnNumberClick);
            // 
            // x4
            // 
            this.x4.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.x4, "x4");
            this.x4.Name = "x4";
            this.x4.UseVisualStyleBackColor = false;
            this.x4.Click += new System.EventHandler(this.OnNumberClick);
            // 
            // x1
            // 
            this.x1.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.x1, "x1");
            this.x1.Name = "x1";
            this.x1.UseVisualStyleBackColor = false;
            this.x1.Click += new System.EventHandler(this.OnNumberClick);
            // 
            // x2
            // 
            this.x2.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.x2, "x2");
            this.x2.Name = "x2";
            this.x2.UseVisualStyleBackColor = false;
            this.x2.Click += new System.EventHandler(this.OnNumberClick);
            // 
            // x5
            // 
            this.x5.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.x5, "x5");
            this.x5.Name = "x5";
            this.x5.UseVisualStyleBackColor = false;
            this.x5.Click += new System.EventHandler(this.OnNumberClick);
            // 
            // x8
            // 
            this.x8.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.x8, "x8");
            this.x8.Name = "x8";
            this.x8.UseVisualStyleBackColor = false;
            this.x8.Click += new System.EventHandler(this.OnNumberClick);
            // 
            // x3
            // 
            this.x3.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.x3, "x3");
            this.x3.Name = "x3";
            this.x3.UseVisualStyleBackColor = false;
            this.x3.Click += new System.EventHandler(this.OnNumberClick);
            // 
            // x6
            // 
            this.x6.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.x6, "x6");
            this.x6.Name = "x6";
            this.x6.UseVisualStyleBackColor = false;
            this.x6.Click += new System.EventHandler(this.OnNumberClick);
            // 
            // x9
            // 
            this.x9.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.x9, "x9");
            this.x9.Name = "x9";
            this.x9.UseVisualStyleBackColor = false;
            this.x9.Click += new System.EventHandler(this.OnNumberClick);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.SystemColors.InactiveCaption;
            resources.ApplyResources(this.minus, "minus");
            this.minus.Name = "minus";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.OnButtonOperation);
            // 
            // multiplication
            // 
            this.multiplication.BackColor = System.Drawing.SystemColors.InactiveCaption;
            resources.ApplyResources(this.multiplication, "multiplication");
            this.multiplication.Name = "multiplication";
            this.multiplication.UseVisualStyleBackColor = false;
            this.multiplication.Click += new System.EventHandler(this.OnButtonOperation);
            // 
            // division
            // 
            this.division.BackColor = System.Drawing.SystemColors.InactiveCaption;
            resources.ApplyResources(this.division, "division");
            this.division.Name = "division";
            this.division.UseVisualStyleBackColor = false;
            this.division.Click += new System.EventHandler(this.OnButtonOperation);
            // 
            // equal
            // 
            this.equal.BackColor = System.Drawing.SystemColors.ButtonShadow;
            resources.ApplyResources(this.equal, "equal");
            this.equal.Name = "equal";
            this.equal.UseVisualStyleBackColor = false;
            this.equal.Click += new System.EventHandler(this.OnButtonResult);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.SystemColors.InactiveCaption;
            resources.ApplyResources(this.plus, "plus");
            this.plus.Name = "plus";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.OnButtonOperation);
            // 
            // exponentiation
            // 
            this.exponentiation.BackColor = System.Drawing.SystemColors.InactiveCaption;
            resources.ApplyResources(this.exponentiation, "exponentiation");
            this.exponentiation.Name = "exponentiation";
            this.exponentiation.UseVisualStyleBackColor = false;
            this.exponentiation.Click += new System.EventHandler(this.OnButtonOperation);
            // 
            // x0
            // 
            this.x0.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.x0, "x0");
            this.x0.Name = "x0";
            this.x0.UseVisualStyleBackColor = false;
            this.x0.Click += new System.EventHandler(this.OnNumberClick);
            // 
            // comma
            // 
            this.comma.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.comma, "comma");
            this.comma.Name = "comma";
            this.comma.UseVisualStyleBackColor = false;
            this.comma.Click += new System.EventHandler(this.OnNumberClick);
            // 
            // xC
            // 
            this.xC.BackColor = System.Drawing.Color.IndianRed;
            resources.ApplyResources(this.xC, "xC");
            this.xC.Name = "xC";
            this.xC.UseVisualStyleBackColor = false;
            this.xC.Click += new System.EventHandler(this.OnButtonClear);
            // 
            // Calculator
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Controls.Add(this.xC);
            this.Controls.Add(this.comma);
            this.Controls.Add(this.x0);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.exponentiation);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.division);
            this.Controls.Add(this.x3);
            this.Controls.Add(this.x6);
            this.Controls.Add(this.x9);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.x5);
            this.Controls.Add(this.x8);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.x4);
            this.Controls.Add(this.x7);
            this.Controls.Add(this.Result);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Button x7;
        private System.Windows.Forms.Button x4;
        private System.Windows.Forms.Button x1;
        private System.Windows.Forms.Button x2;
        private System.Windows.Forms.Button x5;
        private System.Windows.Forms.Button x8;
        private System.Windows.Forms.Button x3;
        private System.Windows.Forms.Button x6;
        private System.Windows.Forms.Button x9;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button exponentiation;
        private System.Windows.Forms.Button x0;
        private System.Windows.Forms.Button comma;
        private System.Windows.Forms.Button xC;
    }
}

