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
            this.btn_cuttingPlane = new System.Windows.Forms.Button();
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
            this.gp_sensitivity = new System.Windows.Forms.GroupBox();
            this.btn_save_sen = new System.Windows.Forms.Button();
            this.btn_output = new System.Windows.Forms.Button();
            this.btn_Duality = new System.Windows.Forms.Button();
            this.btn_Shadow = new System.Windows.Forms.Button();
            this.btn_range = new System.Windows.Forms.Button();
            this.btn_change = new System.Windows.Forms.Button();
            this.gp_range = new System.Windows.Forms.GroupBox();
            this.tb_note = new System.Windows.Forms.RichTextBox();
            this.tb_j_index = new System.Windows.Forms.TextBox();
            this.lbl_j_index = new System.Windows.Forms.Label();
            this.lbl_i_index = new System.Windows.Forms.Label();
            this.tb_i_index = new System.Windows.Forms.TextBox();
            this.gb_algorithms.SuspendLayout();
            this.gb_controls.SuspendLayout();
            this.gb_errors.SuspendLayout();
            this.gp_sensitivity.SuspendLayout();
            this.gp_range.SuspendLayout();
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
            this.btn_Simplex.Location = new System.Drawing.Point(5, 33);
            this.btn_Simplex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Simplex.Name = "btn_Simplex";
            this.btn_Simplex.Size = new System.Drawing.Size(199, 36);
            this.btn_Simplex.TabIndex = 1;
            this.btn_Simplex.Text = "Simplex";
            this.btn_Simplex.UseVisualStyleBackColor = true;
            this.btn_Simplex.Click += new System.EventHandler(this.btn_Simplex_Click);
            // 
            // btn_revised
            // 
            this.btn_revised.FlatAppearance.BorderSize = 10;
            this.btn_revised.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_revised.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_revised.Location = new System.Drawing.Point(5, 75);
            this.btn_revised.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btn_bnb.Location = new System.Drawing.Point(5, 117);
            this.btn_bnb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_bnb.Name = "btn_bnb";
            this.btn_bnb.Size = new System.Drawing.Size(199, 36);
            this.btn_bnb.TabIndex = 3;
            this.btn_bnb.Text = "Branch and Bound";
            this.btn_bnb.UseVisualStyleBackColor = true;
            // 
            // btn_cuttingPlane
            // 
            this.btn_cuttingPlane.FlatAppearance.BorderSize = 10;
            this.btn_cuttingPlane.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cuttingPlane.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_cuttingPlane.Location = new System.Drawing.Point(5, 159);
            this.btn_cuttingPlane.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cuttingPlane.Name = "btn_cuttingPlane";
            this.btn_cuttingPlane.Size = new System.Drawing.Size(199, 36);
            this.btn_cuttingPlane.TabIndex = 4;
            this.btn_cuttingPlane.Text = "Cutting Plane";
            this.btn_cuttingPlane.UseVisualStyleBackColor = true;
            this.btn_cuttingPlane.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_knapsack
            // 
            this.btn_knapsack.FlatAppearance.BorderSize = 10;
            this.btn_knapsack.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_knapsack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_knapsack.Location = new System.Drawing.Point(5, 201);
            this.btn_knapsack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.gb_algorithms.Controls.Add(this.btn_cuttingPlane);
            this.gb_algorithms.Controls.Add(this.btn_bnb);
            this.gb_algorithms.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_algorithms.ForeColor = System.Drawing.Color.Cyan;
            this.gb_algorithms.Location = new System.Drawing.Point(33, 295);
            this.gb_algorithms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_algorithms.Name = "gb_algorithms";
            this.gb_algorithms.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.gb_controls.Location = new System.Drawing.Point(33, 44);
            this.gb_controls.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_controls.Name = "gb_controls";
            this.gb_controls.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btn_Write.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btn_File.Location = new System.Drawing.Point(5, 33);
            this.btn_File.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btn_canonical.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btn_edit.Location = new System.Drawing.Point(5, 117);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.tb_display.Location = new System.Drawing.Point(281, 47);
            this.tb_display.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_display.Name = "tb_display";
            this.tb_display.Size = new System.Drawing.Size(773, 495);
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
            this.gb_errors.Location = new System.Drawing.Point(281, 546);
            this.gb_errors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_errors.Name = "gb_errors";
            this.gb_errors.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_errors.Size = new System.Drawing.Size(773, 114);
            this.gb_errors.TabIndex = 9;
            this.gb_errors.TabStop = false;
            this.gb_errors.Text = "Solution";
            // 
            // lblDVans
            // 
            this.lblDVans.AutoSize = true;
            this.lblDVans.ForeColor = System.Drawing.Color.White;
            this.lblDVans.Location = new System.Drawing.Point(219, 59);
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
            this.lblDV.Location = new System.Drawing.Point(5, 59);
            this.lblDV.Name = "lblDV";
            this.lblDV.Size = new System.Drawing.Size(198, 23);
            this.lblDV.TabIndex = 11;
            this.lblDV.Text = "Decision Variables:";
            // 
            // lblZ
            // 
            this.lblZ.AutoSize = true;
            this.lblZ.ForeColor = System.Drawing.Color.White;
            this.lblZ.Location = new System.Drawing.Point(5, 27);
            this.lblZ.Name = "lblZ";
            this.lblZ.Size = new System.Drawing.Size(45, 23);
            this.lblZ.TabIndex = 10;
            this.lblZ.Text = "Z = ";
            // 
            // gp_sensitivity
            // 
            this.gp_sensitivity.Controls.Add(this.btn_save_sen);
            this.gp_sensitivity.Controls.Add(this.btn_output);
            this.gp_sensitivity.Controls.Add(this.btn_Duality);
            this.gp_sensitivity.Controls.Add(this.btn_Shadow);
            this.gp_sensitivity.Controls.Add(this.btn_range);
            this.gp_sensitivity.Controls.Add(this.btn_change);
            this.gp_sensitivity.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_sensitivity.ForeColor = System.Drawing.Color.Cyan;
            this.gp_sensitivity.Location = new System.Drawing.Point(1092, 47);
            this.gp_sensitivity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gp_sensitivity.Name = "gp_sensitivity";
            this.gp_sensitivity.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gp_sensitivity.Size = new System.Drawing.Size(230, 278);
            this.gp_sensitivity.TabIndex = 7;
            this.gp_sensitivity.TabStop = false;
            this.gp_sensitivity.Text = "Sensitivity";
            this.gp_sensitivity.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_save_sen
            // 
            this.btn_save_sen.FlatAppearance.BorderSize = 10;
            this.btn_save_sen.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_sen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_save_sen.Location = new System.Drawing.Point(9, 112);
            this.btn_save_sen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_save_sen.Name = "btn_save_sen";
            this.btn_save_sen.Size = new System.Drawing.Size(199, 36);
            this.btn_save_sen.TabIndex = 8;
            this.btn_save_sen.Text = "Save";
            this.btn_save_sen.UseVisualStyleBackColor = true;
            this.btn_save_sen.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_output
            // 
            this.btn_output.FlatAppearance.BorderSize = 10;
            this.btn_output.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_output.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_output.Location = new System.Drawing.Point(9, 234);
            this.btn_output.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_output.Name = "btn_output";
            this.btn_output.Size = new System.Drawing.Size(199, 36);
            this.btn_output.TabIndex = 9;
            this.btn_output.Text = "Display Output";
            this.btn_output.UseVisualStyleBackColor = true;
            this.btn_output.Click += new System.EventHandler(this.btn_output_Click);
            // 
            // btn_Duality
            // 
            this.btn_Duality.FlatAppearance.BorderSize = 10;
            this.btn_Duality.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Duality.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_Duality.Location = new System.Drawing.Point(9, 192);
            this.btn_Duality.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Duality.Name = "btn_Duality";
            this.btn_Duality.Size = new System.Drawing.Size(199, 36);
            this.btn_Duality.TabIndex = 8;
            this.btn_Duality.Text = "Duality";
            this.btn_Duality.UseVisualStyleBackColor = true;
            this.btn_Duality.Click += new System.EventHandler(this.btn_Duality_Click);
            // 
            // btn_Shadow
            // 
            this.btn_Shadow.FlatAppearance.BorderSize = 10;
            this.btn_Shadow.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Shadow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_Shadow.Location = new System.Drawing.Point(9, 152);
            this.btn_Shadow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Shadow.Name = "btn_Shadow";
            this.btn_Shadow.Size = new System.Drawing.Size(199, 36);
            this.btn_Shadow.TabIndex = 7;
            this.btn_Shadow.Text = "Shadow Price";
            this.btn_Shadow.UseVisualStyleBackColor = true;
            this.btn_Shadow.Click += new System.EventHandler(this.btn_Shadow_Click);
            // 
            // btn_range
            // 
            this.btn_range.FlatAppearance.BorderSize = 10;
            this.btn_range.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_range.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_range.Location = new System.Drawing.Point(9, 31);
            this.btn_range.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_range.Name = "btn_range";
            this.btn_range.Size = new System.Drawing.Size(199, 36);
            this.btn_range.TabIndex = 1;
            this.btn_range.Text = "Range";
            this.btn_range.UseVisualStyleBackColor = true;
            this.btn_range.Click += new System.EventHandler(this.btn_range_Click);
            // 
            // btn_change
            // 
            this.btn_change.FlatAppearance.BorderSize = 10;
            this.btn_change.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_change.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_change.Location = new System.Drawing.Point(9, 72);
            this.btn_change.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(199, 36);
            this.btn_change.TabIndex = 2;
            this.btn_change.Text = "Edit";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // gp_range
            // 
            this.gp_range.Controls.Add(this.tb_note);
            this.gp_range.Controls.Add(this.tb_j_index);
            this.gp_range.Controls.Add(this.lbl_j_index);
            this.gp_range.Controls.Add(this.lbl_i_index);
            this.gp_range.Controls.Add(this.tb_i_index);
            this.gp_range.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_range.ForeColor = System.Drawing.Color.Cyan;
            this.gp_range.Location = new System.Drawing.Point(1092, 330);
            this.gp_range.Name = "gp_range";
            this.gp_range.Size = new System.Drawing.Size(230, 211);
            this.gp_range.TabIndex = 10;
            this.gp_range.TabStop = false;
            this.gp_range.Text = "Range";
            // 
            // tb_note
            // 
            this.tb_note.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.tb_note.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_note.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tb_note.Location = new System.Drawing.Point(6, 158);
            this.tb_note.Name = "tb_note";
            this.tb_note.ReadOnly = true;
            this.tb_note.Size = new System.Drawing.Size(199, 47);
            this.tb_note.TabIndex = 14;
            this.tb_note.Text = "Enter the row and column index of a variable before running a command";
            // 
            // tb_j_index
            // 
            this.tb_j_index.Location = new System.Drawing.Point(6, 118);
            this.tb_j_index.Name = "tb_j_index";
            this.tb_j_index.Size = new System.Drawing.Size(199, 34);
            this.tb_j_index.TabIndex = 14;
            this.tb_j_index.Text = "0";
            // 
            // lbl_j_index
            // 
            this.lbl_j_index.AutoSize = true;
            this.lbl_j_index.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_j_index.ForeColor = System.Drawing.Color.White;
            this.lbl_j_index.Location = new System.Drawing.Point(6, 94);
            this.lbl_j_index.Name = "lbl_j_index";
            this.lbl_j_index.Size = new System.Drawing.Size(146, 17);
            this.lbl_j_index.TabIndex = 13;
            this.lbl_j_index.Text = "Column of Variable";
            // 
            // lbl_i_index
            // 
            this.lbl_i_index.AutoSize = true;
            this.lbl_i_index.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_i_index.ForeColor = System.Drawing.Color.White;
            this.lbl_i_index.Location = new System.Drawing.Point(6, 30);
            this.lbl_i_index.Name = "lbl_i_index";
            this.lbl_i_index.Size = new System.Drawing.Size(123, 17);
            this.lbl_i_index.TabIndex = 12;
            this.lbl_i_index.Text = "Row of Variable";
            // 
            // tb_i_index
            // 
            this.tb_i_index.Location = new System.Drawing.Point(5, 54);
            this.tb_i_index.Name = "tb_i_index";
            this.tb_i_index.Size = new System.Drawing.Size(199, 34);
            this.tb_i_index.TabIndex = 11;
            this.tb_i_index.Text = "0";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1352, 674);
            this.Controls.Add(this.gp_range);
            this.Controls.Add(this.gp_sensitivity);
            this.Controls.Add(this.gb_errors);
            this.Controls.Add(this.tb_display);
            this.Controls.Add(this.gb_controls);
            this.Controls.Add(this.gb_algorithms);
            this.Controls.Add(this.lbl01);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "mainForm";
            this.Text = "Solver";
            this.gb_algorithms.ResumeLayout(false);
            this.gb_controls.ResumeLayout(false);
            this.gb_errors.ResumeLayout(false);
            this.gb_errors.PerformLayout();
            this.gp_sensitivity.ResumeLayout(false);
            this.gp_range.ResumeLayout(false);
            this.gp_range.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl01;
        private System.Windows.Forms.Button btn_Simplex;
        private System.Windows.Forms.Button btn_revised;
        private System.Windows.Forms.Button btn_bnb;
        private System.Windows.Forms.Button btn_cuttingPlane;
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
        private System.Windows.Forms.GroupBox gp_sensitivity;
        private System.Windows.Forms.Button btn_range;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.Button btn_Duality;
        private System.Windows.Forms.Button btn_Shadow;
        private System.Windows.Forms.Button btn_output;
        private System.Windows.Forms.Button btn_save_sen;
        private System.Windows.Forms.GroupBox gp_range;
        private System.Windows.Forms.TextBox tb_j_index;
        private System.Windows.Forms.Label lbl_j_index;
        private System.Windows.Forms.Label lbl_i_index;
        private System.Windows.Forms.TextBox tb_i_index;
        private System.Windows.Forms.RichTextBox tb_note;
    }
}

