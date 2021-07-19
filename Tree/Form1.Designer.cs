
namespace Tree
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
            this.ShowPanel = new System.Windows.Forms.Panel();
            this.NewTreeButton = new System.Windows.Forms.Button();
            this.TBNumber = new System.Windows.Forms.TextBox();
            this.InsertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShowPanel
            // 
            this.ShowPanel.Location = new System.Drawing.Point(12, 12);
            this.ShowPanel.Name = "ShowPanel";
            this.ShowPanel.Size = new System.Drawing.Size(952, 370);
            this.ShowPanel.TabIndex = 0;
            this.ShowPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ShowPanel_Paint);
            // 
            // NewTreeButton
            // 
            this.NewTreeButton.Location = new System.Drawing.Point(345, 417);
            this.NewTreeButton.Name = "NewTreeButton";
            this.NewTreeButton.Size = new System.Drawing.Size(75, 23);
            this.NewTreeButton.TabIndex = 1;
            this.NewTreeButton.Text = "New ";
            this.NewTreeButton.UseVisualStyleBackColor = true;
            this.NewTreeButton.Click += new System.EventHandler(this.NewTreeButton_Click);
            // 
            // TBNumber
            // 
            this.TBNumber.Location = new System.Drawing.Point(445, 417);
            this.TBNumber.Name = "TBNumber";
            this.TBNumber.Size = new System.Drawing.Size(99, 20);
            this.TBNumber.TabIndex = 2;
            this.TBNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBNumber_KeyDown);
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(570, 417);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(75, 23);
            this.InsertButton.TabIndex = 3;
            this.InsertButton.Text = "Insert";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 468);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.TBNumber);
            this.Controls.Add(this.NewTreeButton);
            this.Controls.Add(this.ShowPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "AVL Tree Show";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ShowPanel;
        private System.Windows.Forms.Button NewTreeButton;
        private System.Windows.Forms.TextBox TBNumber;
        private System.Windows.Forms.Button InsertButton;
    }
}

