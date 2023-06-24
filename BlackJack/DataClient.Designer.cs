namespace BlackJack
{
    partial class DataClient
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
            this.datatClient = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datatClient)).BeginInit();
            this.SuspendLayout();
            // 
            // datatClient
            // 
            this.datatClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datatClient.Location = new System.Drawing.Point(16, 15);
            this.datatClient.Margin = new System.Windows.Forms.Padding(4);
            this.datatClient.Name = "datatClient";
            this.datatClient.RowHeadersWidth = 51;
            this.datatClient.Size = new System.Drawing.Size(559, 185);
            this.datatClient.TabIndex = 1;
            this.datatClient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datatClient_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 239);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "Refesh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DataClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 394);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.datatClient);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DataClient";
            this.Text = "DataClient";
            this.Load += new System.EventHandler(this.DataClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datatClient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView datatClient;
        private System.Windows.Forms.Button button2;
    }
}