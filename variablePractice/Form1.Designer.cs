namespace variablePractice
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
            this.hockeyButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.payButton = new System.Windows.Forms.Button();
            this.areaButton = new System.Windows.Forms.Button();
            this.carpetButton = new System.Windows.Forms.Button();
            this.billButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hockeyButton
            // 
            this.hockeyButton.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hockeyButton.ForeColor = System.Drawing.Color.DimGray;
            this.hockeyButton.Location = new System.Drawing.Point(41, 39);
            this.hockeyButton.Name = "hockeyButton";
            this.hockeyButton.Size = new System.Drawing.Size(170, 56);
            this.hockeyButton.TabIndex = 0;
            this.hockeyButton.Text = "hockey";
            this.hockeyButton.UseVisualStyleBackColor = true;
            this.hockeyButton.Click += new System.EventHandler(this.hockeyButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.DimGray;
            this.outputLabel.Location = new System.Drawing.Point(259, 45);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(432, 367);
            this.outputLabel.TabIndex = 2;
            this.outputLabel.Click += new System.EventHandler(this.outputLabel_Click);
            // 
            // payButton
            // 
            this.payButton.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payButton.ForeColor = System.Drawing.Color.DimGray;
            this.payButton.Location = new System.Drawing.Point(41, 121);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(170, 56);
            this.payButton.TabIndex = 3;
            this.payButton.Text = "pay";
            this.payButton.UseVisualStyleBackColor = true;
            this.payButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // areaButton
            // 
            this.areaButton.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaButton.ForeColor = System.Drawing.Color.DimGray;
            this.areaButton.Location = new System.Drawing.Point(41, 206);
            this.areaButton.Name = "areaButton";
            this.areaButton.Size = new System.Drawing.Size(170, 56);
            this.areaButton.TabIndex = 5;
            this.areaButton.Text = "area";
            this.areaButton.UseVisualStyleBackColor = true;
            this.areaButton.Click += new System.EventHandler(this.areaButton_Click);
            // 
            // carpetButton
            // 
            this.carpetButton.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carpetButton.ForeColor = System.Drawing.Color.DimGray;
            this.carpetButton.Location = new System.Drawing.Point(41, 285);
            this.carpetButton.Name = "carpetButton";
            this.carpetButton.Size = new System.Drawing.Size(170, 56);
            this.carpetButton.TabIndex = 4;
            this.carpetButton.Text = "carpet";
            this.carpetButton.UseVisualStyleBackColor = true;
            this.carpetButton.Click += new System.EventHandler(this.carpetButton_Click);
            // 
            // billButton
            // 
            this.billButton.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billButton.ForeColor = System.Drawing.Color.DimGray;
            this.billButton.Location = new System.Drawing.Point(41, 364);
            this.billButton.Name = "billButton";
            this.billButton.Size = new System.Drawing.Size(170, 56);
            this.billButton.TabIndex = 6;
            this.billButton.Text = "bill";
            this.billButton.UseVisualStyleBackColor = true;
            this.billButton.Click += new System.EventHandler(this.billButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(751, 450);
            this.Controls.Add(this.billButton);
            this.Controls.Add(this.areaButton);
            this.Controls.Add(this.carpetButton);
            this.Controls.Add(this.payButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.hockeyButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button hockeyButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button payButton;
        private System.Windows.Forms.Button areaButton;
        private System.Windows.Forms.Button carpetButton;
        private System.Windows.Forms.Button billButton;
    }
}

