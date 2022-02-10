namespace NumberValidation
{
    partial class FormNumberValidation
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
            this.Number = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.listBoxData = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Number
            // 
            this.Number.AutoSize = true;
            this.Number.Location = new System.Drawing.Point(63, 42);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(55, 16);
            this.Number.TabIndex = 0;
            this.Number.Text = "Number";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(240, 82);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(66, 83);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(100, 22);
            this.textBoxNumber.TabIndex = 2;
            // 
            // listBoxData
            // 
            this.listBoxData.FormattingEnabled = true;
            this.listBoxData.ItemHeight = 16;
            this.listBoxData.Location = new System.Drawing.Point(66, 179);
            this.listBoxData.Name = "listBoxData";
            this.listBoxData.Size = new System.Drawing.Size(120, 84);
            this.listBoxData.TabIndex = 3;
            this.listBoxData.SelectedIndexChanged += new System.EventHandler(this.listBoxData_SelectedIndexChanged);
            // 
            // FormNumberValidation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 292);
            this.Controls.Add(this.listBoxData);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.Number);
            this.Name = "FormNumberValidation";
            this.Text = "NumberValidation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Number;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.ListBox listBoxData;
    }
}

