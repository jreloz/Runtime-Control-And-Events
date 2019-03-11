namespace RuntimeControlsAndEvents
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
            this.ControlLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AddControl = new System.Windows.Forms.Button();
            this.GetValue = new System.Windows.Forms.Button();
            this.SetValue = new System.Windows.Forms.Button();
            this.ControlCount = new System.Windows.Forms.Button();
            this.AddForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ControlLayoutPanel
            // 
            this.ControlLayoutPanel.AutoScroll = true;
            this.ControlLayoutPanel.Location = new System.Drawing.Point(12, 49);
            this.ControlLayoutPanel.Name = "ControlLayoutPanel";
            this.ControlLayoutPanel.Size = new System.Drawing.Size(796, 475);
            this.ControlLayoutPanel.TabIndex = 0;
            // 
            // AddControl
            // 
            this.AddControl.BackColor = System.Drawing.Color.SteelBlue;
            this.AddControl.FlatAppearance.BorderSize = 0;
            this.AddControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddControl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddControl.ForeColor = System.Drawing.Color.White;
            this.AddControl.Location = new System.Drawing.Point(12, 12);
            this.AddControl.Name = "AddControl";
            this.AddControl.Size = new System.Drawing.Size(35, 31);
            this.AddControl.TabIndex = 1;
            this.AddControl.Text = "+";
            this.AddControl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AddControl.UseVisualStyleBackColor = false;
            this.AddControl.Click += new System.EventHandler(this.AddControl_Click);
            // 
            // GetValue
            // 
            this.GetValue.BackColor = System.Drawing.Color.SeaGreen;
            this.GetValue.FlatAppearance.BorderSize = 0;
            this.GetValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetValue.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetValue.ForeColor = System.Drawing.Color.White;
            this.GetValue.Location = new System.Drawing.Point(562, 12);
            this.GetValue.Name = "GetValue";
            this.GetValue.Size = new System.Drawing.Size(108, 31);
            this.GetValue.TabIndex = 2;
            this.GetValue.Text = "Get Value";
            this.GetValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GetValue.UseVisualStyleBackColor = false;
            this.GetValue.Click += new System.EventHandler(this.GetValue_Click);
            // 
            // SetValue
            // 
            this.SetValue.BackColor = System.Drawing.Color.SeaGreen;
            this.SetValue.FlatAppearance.BorderSize = 0;
            this.SetValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetValue.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetValue.ForeColor = System.Drawing.Color.White;
            this.SetValue.Location = new System.Drawing.Point(448, 12);
            this.SetValue.Name = "SetValue";
            this.SetValue.Size = new System.Drawing.Size(108, 31);
            this.SetValue.TabIndex = 3;
            this.SetValue.Text = "Set Value";
            this.SetValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SetValue.UseVisualStyleBackColor = false;
            this.SetValue.Click += new System.EventHandler(this.SetValue_Click);
            // 
            // ControlCount
            // 
            this.ControlCount.BackColor = System.Drawing.Color.SeaGreen;
            this.ControlCount.FlatAppearance.BorderSize = 0;
            this.ControlCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ControlCount.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ControlCount.ForeColor = System.Drawing.Color.White;
            this.ControlCount.Location = new System.Drawing.Point(676, 12);
            this.ControlCount.Name = "ControlCount";
            this.ControlCount.Size = new System.Drawing.Size(135, 31);
            this.ControlCount.TabIndex = 4;
            this.ControlCount.Text = "Control Count";
            this.ControlCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ControlCount.UseVisualStyleBackColor = false;
            this.ControlCount.Click += new System.EventHandler(this.ControlCount_Click);
            // 
            // AddForm
            // 
            this.AddForm.BackColor = System.Drawing.Color.SteelBlue;
            this.AddForm.FlatAppearance.BorderSize = 0;
            this.AddForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddForm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddForm.ForeColor = System.Drawing.Color.White;
            this.AddForm.Location = new System.Drawing.Point(407, 11);
            this.AddForm.Name = "AddForm";
            this.AddForm.Size = new System.Drawing.Size(35, 31);
            this.AddForm.TabIndex = 5;
            this.AddForm.Text = "+";
            this.AddForm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AddForm.UseVisualStyleBackColor = false;
            this.AddForm.Click += new System.EventHandler(this.AddForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 537);
            this.Controls.Add(this.AddForm);
            this.Controls.Add(this.ControlCount);
            this.Controls.Add(this.SetValue);
            this.Controls.Add(this.GetValue);
            this.Controls.Add(this.AddControl);
            this.Controls.Add(this.ControlLayoutPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel ControlLayoutPanel;
        private System.Windows.Forms.Button AddControl;
        private System.Windows.Forms.Button GetValue;
        private System.Windows.Forms.Button SetValue;
        private System.Windows.Forms.Button ControlCount;
        private System.Windows.Forms.Button AddForm;
    }
}

