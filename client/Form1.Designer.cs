namespace client
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
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.buttonAPIKey = new System.Windows.Forms.Button();
            this.textBoxAPIKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonPopulateCountries = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxCountries = new System.Windows.Forms.ComboBox();
            this.buttonPopulateCounties = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxCounties = new System.Windows.Forms.ComboBox();
            this.buttonPopulateTowns = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxTowns = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(199, 38);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(148, 20);
            this.textBoxUsername.TabIndex = 0;
            // 
            // buttonAPIKey
            // 
            this.buttonAPIKey.Location = new System.Drawing.Point(446, 38);
            this.buttonAPIKey.Name = "buttonAPIKey";
            this.buttonAPIKey.Size = new System.Drawing.Size(100, 20);
            this.buttonAPIKey.TabIndex = 1;
            this.buttonAPIKey.Text = "get API key";
            this.buttonAPIKey.UseVisualStyleBackColor = true;
            this.buttonAPIKey.Click += new System.EventHandler(this.buttonAPIKey_Click);
            // 
            // textBoxAPIKey
            // 
            this.textBoxAPIKey.Location = new System.Drawing.Point(12, 129);
            this.textBoxAPIKey.Name = "textBoxAPIKey";
            this.textBoxAPIKey.Size = new System.Drawing.Size(783, 20);
            this.textBoxAPIKey.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "please enter your username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "your API key";
            // 
            // buttonPopulateCountries
            // 
            this.buttonPopulateCountries.Location = new System.Drawing.Point(27, 198);
            this.buttonPopulateCountries.Name = "buttonPopulateCountries";
            this.buttonPopulateCountries.Size = new System.Drawing.Size(97, 53);
            this.buttonPopulateCountries.TabIndex = 5;
            this.buttonPopulateCountries.Text = "Populate Countries";
            this.buttonPopulateCountries.UseVisualStyleBackColor = true;
            this.buttonPopulateCountries.Click += new System.EventHandler(this.buttonPopulateCountries_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "please choose from drop down";
            // 
            // comboBoxCountries
            // 
            this.comboBoxCountries.FormattingEnabled = true;
            this.comboBoxCountries.Location = new System.Drawing.Point(15, 292);
            this.comboBoxCountries.Name = "comboBoxCountries";
            this.comboBoxCountries.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCountries.TabIndex = 7;
            // 
            // buttonPopulateCounties
            // 
            this.buttonPopulateCounties.Location = new System.Drawing.Point(347, 198);
            this.buttonPopulateCounties.Name = "buttonPopulateCounties";
            this.buttonPopulateCounties.Size = new System.Drawing.Size(97, 53);
            this.buttonPopulateCounties.TabIndex = 8;
            this.buttonPopulateCounties.Text = "Populate Counties";
            this.buttonPopulateCounties.UseVisualStyleBackColor = true;
            this.buttonPopulateCounties.Click += new System.EventHandler(this.buttonPopulateCounties_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "please choose from drop down";
            // 
            // comboBoxCounties
            // 
            this.comboBoxCounties.FormattingEnabled = true;
            this.comboBoxCounties.Location = new System.Drawing.Point(334, 292);
            this.comboBoxCounties.Name = "comboBoxCounties";
            this.comboBoxCounties.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCounties.TabIndex = 10;
            // 
            // buttonPopulateTowns
            // 
            this.buttonPopulateTowns.Location = new System.Drawing.Point(610, 198);
            this.buttonPopulateTowns.Name = "buttonPopulateTowns";
            this.buttonPopulateTowns.Size = new System.Drawing.Size(97, 53);
            this.buttonPopulateTowns.TabIndex = 11;
            this.buttonPopulateTowns.Text = "Populate Towns";
            this.buttonPopulateTowns.UseVisualStyleBackColor = true;
            this.buttonPopulateTowns.Click += new System.EventHandler(this.buttonPopulateTowns_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(579, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "please choose from drop down";
            // 
            // comboBoxTowns
            // 
            this.comboBoxTowns.FormattingEnabled = true;
            this.comboBoxTowns.Location = new System.Drawing.Point(598, 292);
            this.comboBoxTowns.Name = "comboBoxTowns";
            this.comboBoxTowns.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTowns.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxTowns);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonPopulateTowns);
            this.Controls.Add(this.comboBoxCounties);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonPopulateCounties);
            this.Controls.Add(this.comboBoxCountries);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonPopulateCountries);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAPIKey);
            this.Controls.Add(this.buttonAPIKey);
            this.Controls.Add(this.textBoxUsername);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Button buttonAPIKey;
        private System.Windows.Forms.TextBox textBoxAPIKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonPopulateCountries;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxCountries;
        private System.Windows.Forms.Button buttonPopulateCounties;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxCounties;
        private System.Windows.Forms.Button buttonPopulateTowns;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxTowns;
    }
}

