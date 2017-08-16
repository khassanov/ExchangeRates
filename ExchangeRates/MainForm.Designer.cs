namespace ExchangeRates
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonUSD = new System.Windows.Forms.Button();
            this.buttonEUR = new System.Windows.Forms.Button();
            this.buttonRUB = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonUSD
            // 
            this.buttonUSD.Location = new System.Drawing.Point(394, 13);
            this.buttonUSD.Name = "buttonUSD";
            this.buttonUSD.Size = new System.Drawing.Size(75, 23);
            this.buttonUSD.TabIndex = 1;
            this.buttonUSD.Text = "USD";
            this.buttonUSD.UseVisualStyleBackColor = true;
            this.buttonUSD.Click += new System.EventHandler(this.buttonUSD_Click);
            // 
            // buttonEUR
            // 
            this.buttonEUR.Location = new System.Drawing.Point(393, 57);
            this.buttonEUR.Name = "buttonEUR";
            this.buttonEUR.Size = new System.Drawing.Size(75, 23);
            this.buttonEUR.TabIndex = 2;
            this.buttonEUR.Text = "EUR";
            this.buttonEUR.UseVisualStyleBackColor = true;
            this.buttonEUR.Click += new System.EventHandler(this.buttonEUR_Click);
            // 
            // buttonRUB
            // 
            this.buttonRUB.Location = new System.Drawing.Point(394, 108);
            this.buttonRUB.Name = "buttonRUB";
            this.buttonRUB.Size = new System.Drawing.Size(75, 23);
            this.buttonRUB.TabIndex = 3;
            this.buttonRUB.Text = "RUB";
            this.buttonRUB.UseVisualStyleBackColor = true;
            this.buttonRUB.Click += new System.EventHandler(this.buttonRUB_Click);
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox.Location = new System.Drawing.Point(4, 13);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(371, 118);
            this.textBox.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ExchangeRates.Properties.Resources.money_515058_960_720;
            this.ClientSize = new System.Drawing.Size(480, 145);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.buttonRUB);
            this.Controls.Add(this.buttonEUR);
            this.Controls.Add(this.buttonUSD);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Курсы продажи валют";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonUSD;
        private System.Windows.Forms.Button buttonEUR;
        private System.Windows.Forms.Button buttonRUB;
        private System.Windows.Forms.TextBox textBox;
    }
}

