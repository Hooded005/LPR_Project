namespace Project
{
    partial class bnbDisplay
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
            this.tb_bnb = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tb_bnb
            // 
            this.tb_bnb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.tb_bnb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_bnb.ForeColor = System.Drawing.Color.GhostWhite;
            this.tb_bnb.Location = new System.Drawing.Point(12, 12);
            this.tb_bnb.Name = "tb_bnb";
            this.tb_bnb.Size = new System.Drawing.Size(1363, 671);
            this.tb_bnb.TabIndex = 0;
            this.tb_bnb.Text = "";
            this.tb_bnb.TextChanged += new System.EventHandler(this.tb_bnb_TextChanged);
            // 
            // bnbDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 695);
            this.Controls.Add(this.tb_bnb);
            this.Name = "bnbDisplay";
            this.Text = "bnbDisplay";
            this.Load += new System.EventHandler(this.bnbDisplay_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox tb_bnb;
    }
}