namespace Project
{
    partial class mainForm
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
            this.lbl01 = new System.Windows.Forms.Label();
            this.btn_Simplex = new System.Windows.Forms.Button();
            this.btn_revised = new System.Windows.Forms.Button();
            this.btn_bnb = new System.Windows.Forms.Button();
            this.btn_cp = new System.Windows.Forms.Button();
            this.btn_knapsack = new System.Windows.Forms.Button();
            this.gb_algorithms = new System.Windows.Forms.GroupBox();
            this.gb_controls = new System.Windows.Forms.GroupBox();
            this.btn_Write = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_File = new System.Windows.Forms.Button();
            this.btn_canonical = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.tb_display = new System.Windows.Forms.RichTextBox();
            this.gb_errors = new System.Windows.Forms.GroupBox();
            this.lblDVans = new System.Windows.Forms.Label();
            this.lblZans = new System.Windows.Forms.Label();
            this.lblDV = new System.Windows.Forms.Label();
            this.lblZ = new System.Windows.Forms.Label();
            this.gb_algorithms.SuspendLayout();
            this.gb_controls.SuspendLayout();
            this.gb_errors.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl01
            // 
            this.lbl01.AutoSize = true;
            this.lbl01.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl01.ForeColor = System.Drawing.Color.Cyan;
            this.lbl01.Location = new System.Drawing.Point(516, 9);
            this.lbl01.Name = "lbl01";
            this.lbl01.Size = new System.Drawing.Size(311, 32);
            this.lbl01.TabIndex = 0;
            this.lbl01.Text = "LPR Project Group 19";
            // 
            // btn_Simplex
            // 
            this.btn_Simplex.FlatAppearance.BorderSize = 10;
            this.btn_Simplex.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Simplex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_Simplex.Location = new System.Drawing.Point(6, 33);
            this.btn_Simplex.Name = "btn_Simplex";
            this.btn_Simplex.Size = new System.Drawing.Size(199, 36);
            this.btn_Simplex.TabIndex = 1;
            this.btn_Simplex.Text = "Simplex";
            this.btn_Simplex.UseVisualStyleBackColor = true;
            // 
            // btn_revised
            // 
            this.btn_revised.FlatAppearance.BorderSize = 10;
            this.btn_revised.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_revised.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_revised.Location = new System.Drawing.Point(6, 75);
            this.btn_revised.Name = "btn_revised";
            this.btn_revised.Size = new System.Drawing.Size(199, 36);
            this.btn_revised.TabIndex = 2;
            this.btn_revised.Text = "Revised";
            this.btn_revised.UseVisualStyleBackColor = true;
            this.btn_revised.Click += new System.EventHandler(this.btn_revised_Click);
            // 
            // btn_bnb
            // 
            this.btn_bnb.FlatAppearance.BorderSize = 10;
            this.btn_bnb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bnb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_bnb.Location = new System.Drawing.Point(6, 117);
            this.btn_bnb.Name = "btn_bnb";
            this.btn_bnb.Size = new System.Drawing.Size(199, 36);
            this.btn_bnb.TabIndex = 3;
            this.btn_bnb.Text = "Branch and Bound";
            this.btn_bnb.UseVisualStyleBackColor = true;
            // 
            // btn_cp
            // 
            this.btn_cp.FlatAppearance.BorderSize = 10;
            this.btn_cp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_cp.Location = new System.Drawing.Point(6, 159);
            this.btn_cp.Name = "btn_cp";
            this.btn_cp.Size = new System.Drawing.Size(199, 36);
            this.btn_cp.TabIndex = 4;
            this.btn_cp.Text = "Cutting Plane";
            this.btn_cp.UseVisualStyleBackColor = true;
            this.btn_cp.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_knapsack
            // 
            this.btn_knapsack.FlatAppearance.BorderSize = 10;
            this.btn_knapsack.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_knapsack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_knapsack.Location = new System.Drawing.Point(6, 201);
            this.btn_knapsack.Name = "btn_knapsack";
            this.btn_knapsack.Size = new System.Drawing.Size(199, 36);
            this.btn_knapsack.TabIndex = 5;
            this.btn_knapsack.Text = "Knapsack";
            this.btn_knapsack.UseVisualStyleBackColor = true;
            this.btn_knapsack.Click += new System.EventHandler(this.btn_knapsack_Click);
            // 
            // gb_algorithms
            // 
            this.gb_algorithms.Controls.Add(this.btn_Simplex);
            this.gb_algorithms.Controls.Add(this.btn_knapsack);
            this.gb_algorithms.Controls.Add(this.btn_revised);
            this.gb_algorithms.Controls.Add(this.btn_cp);
            this.gb_algorithms.Controls.Add(this.btn_bnb);
            this.gb_algorithms.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_algorithms.ForeColor = System.Drawing.Color.Cyan;
            this.gb_algorithms.Location = new System.Drawing.Point(1090, 173);
            this.gb_algorithms.Name = "gb_algorithms";
            this.gb_algorithms.Size = new System.Drawing.Size(213, 246);
            this.gb_algorithms.TabIndex = 6;
            this.gb_algorithms.TabStop = false;
            this.gb_algorithms.Text = "Algorithms";
            // 
            // gb_controls
            // 
            this.gb_controls.Controls.Add(this.btn_Write);
            this.gb_controls.Controls.Add(this.btn_save);
            this.gb_controls.Controls.Add(this.btn_File);
            this.gb_controls.Controls.Add(this.btn_canonical);
            this.gb_controls.Controls.Add(this.btn_edit);
            this.gb_controls.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_controls.ForeColor = System.Drawing.Color.Cyan;
            this.gb_controls.Location = new System.Drawing.Point(27, 173);
            this.gb_controls.Name = "gb_controls";
            this.gb_controls.Size = new System.Drawing.Size(212, 246);
            this.gb_controls.TabIndex = 7;
            this.gb_controls.TabStop = false;
            this.gb_controls.Text = "Controls";
            // 
            // btn_Write
            // 
            this.btn_Write.FlatAppearance.BorderSize = 10;
            this.btn_Write.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Write.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_Write.Location = new System.Drawing.Point(7, 201);
            this.btn_Write.Name = "btn_Write";
            this.btn_Write.Size = new System.Drawing.Size(199, 36);
            this.btn_Write.TabIndex = 7;
            this.btn_Write.Text = "Save Output";
            this.btn_Write.UseVisualStyleBackColor = true;
            this.btn_Write.Click += new System.EventHandler(this.btn_Write_Click);
            // 
            // btn_save
            // 
            this.btn_save.FlatAppearance.BorderSize = 10;
            this.btn_save.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_save.Location = new System.Drawing.Point(7, 159);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(199, 36);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_File
            // 
            this.btn_File.FlatAppearance.BorderSize = 10;
            this.btn_File.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_File.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_File.Location = new System.Drawing.Point(6, 33);
            this.btn_File.Name = "btn_File";
            this.btn_File.Size = new System.Drawing.Size(199, 36);
            this.btn_File.TabIndex = 1;
            this.btn_File.Text = "Upload File";
            this.btn_File.UseVisualStyleBackColor = true;
            this.btn_File.Click += new System.EventHandler(this.btn_File_Click);
            // 
            // btn_canonical
            // 
            this.btn_canonical.FlatAppearance.BorderSize = 10;
            this.btn_canonical.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_canonical.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_canonical.Location = new System.Drawing.Point(7, 75);
            this.btn_canonical.Name = "btn_canonical";
            this.btn_canonical.Size = new System.Drawing.Size(199, 36);
            this.btn_canonical.TabIndex = 5;
            this.btn_canonical.Text = "Canonical Form";
            this.btn_canonical.UseVisualStyleBackColor = true;
            this.btn_canonical.Click += new System.EventHandler(this.btn_canonical_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.FlatAppearance.BorderSize = 10;
            this.btn_edit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_edit.Location = new System.Drawing.Point(6, 117);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(199, 36);
            this.btn_edit.TabIndex = 2;
            this.btn_edit.Text = "Edit File";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // tb_display
            // 
            this.tb_display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.tb_display.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_display.ForeColor = System.Drawing.Color.White;
            this.tb_display.Location = new System.Drawing.Point(281, 44);
            this.tb_display.Name = "tb_display";
            this.tb_display.Size = new System.Drawing.Size(773, 497);
            this.tb_display.TabIndex = 8;
            this.tb_display.Text = "";
            // 
            // gb_errors
            // 
            this.gb_errors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.gb_errors.Controls.Add(this.lblDVans);
            this.gb_errors.Controls.Add(this.lblZans);
            this.gb_errors.Controls.Add(this.lblDV);
            this.gb_errors.Controls.Add(this.lblZ);
            this.gb_errors.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_errors.ForeColor = System.Drawing.Color.White;
            this.gb_errors.Location = new System.Drawing.Point(281, 547);
            this.gb_errors.Name = "gb_errors";
            this.gb_errors.Size = new System.Drawing.Size(773, 115);
            this.gb_errors.TabIndex = 9;
            this.gb_errors.TabStop = false;
            this.gb_errors.Text = "Solution";
            // 
            // lblDVans
            // 
            this.lblDVans.AutoSize = true;
            this.lblDVans.ForeColor = System.Drawing.Color.White;
            this.lblDVans.Location = new System.Drawing.Point(218, 59);
            this.lblDVans.Name = "lblDVans";
            this.lblDVans.Size = new System.Drawing.Size(40, 23);
            this.lblDVans.TabIndex = 13;
            this.lblDVans.Text = "n/a";
            // 
            // lblZans
            // 
            this.lblZans.AutoSize = true;
            this.lblZans.ForeColor = System.Drawing.Color.White;
            this.lblZans.Location = new System.Drawing.Point(47, 27);
            this.lblZans.Name = "lblZans";
            this.lblZans.Size = new System.Drawing.Size(22, 23);
            this.lblZans.TabIndex = 12;
            this.lblZans.Text = "0";
            // 
            // lblDV
            // 
            this.lblDV.AutoSize = true;
            this.lblDV.ForeColor = System.Drawing.Color.White;
            this.lblDV.Location = new System.Drawing.Point(6, 59);
            this.lblDV.Name = "lblDV";
            this.lblDV.Size = new System.Drawing.Size(198, 23);
            this.lblDV.TabIndex = 11;
            this.lblDV.Text = "Decision Variables:";
            // 
            // lblZ
            // 
            this.lblZ.AutoSize = true;
            this.lblZ.ForeColor = System.Drawing.Color.White;
            this.lblZ.Location = new System.Drawing.Point(6, 27);
            this.lblZ.Name = "lblZ";
            this.lblZ.Size = new System.Drawing.Size(45, 23);
            this.lblZ.TabIndex = 10;
            this.lblZ.Text = "Z = ";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1352, 674);
            this.Controls.Add(this.gb_errors);
            this.Controls.Add(this.tb_display);
            this.Controls.Add(this.gb_controls);
            this.Controls.Add(this.gb_algorithms);
            this.Controls.Add(this.lbl01);
            this.Name = "mainForm";
            this.Text = "Solver";
            this.gb_algorithms.ResumeLayout(false);
            this.gb_controls.ResumeLayout(false);
            this.gb_errors.ResumeLayout(false);
            this.gb_errors.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl01;
        private System.Windows.Forms.Button btn_Simplex;
        private System.Windows.Forms.Button btn_revised;
        private System.Windows.Forms.Button btn_bnb;
        private System.Windows.Forms.Button btn_cp;
        private System.Windows.Forms.Button btn_knapsack;
        private System.Windows.Forms.GroupBox gb_algorithms;
        private System.Windows.Forms.GroupBox gb_controls;
        private System.Windows.Forms.Button btn_File;
        private System.Windows.Forms.Button btn_canonical;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.RichTextBox tb_display;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.GroupBox gb_errors;
        private System.Windows.Forms.Button btn_Write;
        private System.Windows.Forms.Label lblZ;
        private System.Windows.Forms.Label lblDV;
        private System.Windows.Forms.Label lblDVans;
        private System.Windows.Forms.Label lblZans;
    }
}

