namespace GUI_movie
{
    partial class ReadForm
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
            this.rtbReadDisplay = new System.Windows.Forms.RichTextBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbReadDisplay
            // 
            this.rtbReadDisplay.Cursor = System.Windows.Forms.Cursors.No;
            this.rtbReadDisplay.Location = new System.Drawing.Point(22, 76);
            this.rtbReadDisplay.Name = "rtbReadDisplay";
            this.rtbReadDisplay.ReadOnly = true;
            this.rtbReadDisplay.Size = new System.Drawing.Size(394, 235);
            this.rtbReadDisplay.TabIndex = 0;
            this.rtbReadDisplay.Text = "";
            this.rtbReadDisplay.TextChanged += new System.EventHandler(this.rtbReadDisplay_TextChanged);
            // 
            // btnRead
            // 
            this.btnRead.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.Location = new System.Drawing.Point(60, 15);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(106, 39);
            this.btnRead.TabIndex = 1;
            this.btnRead.Text = "&Read file";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(246, 15);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 39);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ReadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 330);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.rtbReadDisplay);
            this.Name = "ReadForm";
            this.Text = "ReadForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbReadDisplay;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnExit;
    }
}