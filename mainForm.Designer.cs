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
            this.gp_sensitivity = new System.Windows.Forms.GroupBox();
            this.btn_Duality = new System.Windows.Forms.Button();
            this.btn_Shadow = new System.Windows.Forms.Button();
            this.btn_Constraint = new System.Windows.Forms.Button();
            this.btn_NBV = new System.Windows.Forms.Button();
            this.btn_Activity = new System.Windows.Forms.Button();
            this.btn_BV = new System.Windows.Forms.Button();
            this.btn_NBVC = new System.Windows.Forms.Button();
            this.btn_RHS = new System.Windows.Forms.Button();
            this.btn_output = new System.Windows.Forms.Button();
            this.gb_algorithms.SuspendLayout();
            this.gb_controls.SuspendLayout();
            this.gb_errors.SuspendLayout();
            this.gp_sensitivity.SuspendLayout();
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
            this.btn_Simplex.Click += new System.EventHandler(this.btn_Simplex_Click);
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
            this.gb_algorithms.Location = new System.Drawing.Point(33, 295);
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
            this.gb_controls.Location = new System.Drawing.Point(33, 44);
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
            // gp_sensitivity
            // 
            this.gp_sensitivity.Controls.Add(this.btn_output);
            this.gp_sensitivity.Controls.Add(this.btn_Duality);
            this.gp_sensitivity.Controls.Add(this.btn_Shadow);
            this.gp_sensitivity.Controls.Add(this.btn_Constraint);
            this.gp_sensitivity.Controls.Add(this.btn_NBV);
            this.gp_sensitivity.Controls.Add(this.btn_Activity);
            this.gp_sensitivity.Controls.Add(this.btn_BV);
            this.gp_sensitivity.Controls.Add(this.btn_NBVC);
            this.gp_sensitivity.Controls.Add(this.btn_RHS);
            this.gp_sensitivity.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_sensitivity.ForeColor = System.Drawing.Color.Cyan;
            this.gp_sensitivity.Location = new System.Drawing.Point(1091, 77);
            this.gp_sensitivity.Name = "gp_sensitivity";
            this.gp_sensitivity.Size = new System.Drawing.Size(213, 413);
            this.gp_sensitivity.TabIndex = 7;
            this.gp_sensitivity.TabStop = false;
            this.gp_sensitivity.Text = "Sensitivity";
            this.gp_sensitivity.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_Duality
            // 
            this.btn_Duality.FlatAppearance.BorderSize = 10;
            this.btn_Duality.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Duality.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_Duality.Location = new System.Drawing.Point(8, 327);
            this.btn_Duality.Name = "btn_Duality";
            this.btn_Duality.Size = new System.Drawing.Size(199, 36);
            this.btn_Duality.TabIndex = 8;
            this.btn_Duality.Text = "Duality";
            this.btn_Duality.UseVisualStyleBackColor = true;
            // 
            // btn_Shadow
            // 
            this.btn_Shadow.FlatAppearance.BorderSize = 10;
            this.btn_Shadow.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Shadow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_Shadow.Location = new System.Drawing.Point(8, 285);
            this.btn_Shadow.Name = "btn_Shadow";
            this.btn_Shadow.Size = new System.Drawing.Size(199, 36);
            this.btn_Shadow.TabIndex = 7;
            this.btn_Shadow.Text = "Shadow Price";
            this.btn_Shadow.UseVisualStyleBackColor = true;
            // 
            // btn_Constraint
            // 
            this.btn_Constraint.FlatAppearance.BorderSize = 10;
            this.btn_Constraint.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Constraint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_Constraint.Location = new System.Drawing.Point(8, 243);
            this.btn_Constraint.Name = "btn_Constraint";
            this.btn_Constraint.Size = new System.Drawing.Size(199, 36);
            this.btn_Constraint.TabIndex = 6;
            this.btn_Constraint.Text = "Add Constraint";
            this.btn_Constraint.UseVisualStyleBackColor = true;
            // 
            // btn_NBV
            // 
            this.btn_NBV.FlatAppearance.BorderSize = 10;
            this.btn_NBV.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NBV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_NBV.Location = new System.Drawing.Point(6, 33);
            this.btn_NBV.Name = "btn_NBV";
            this.btn_NBV.Size = new System.Drawing.Size(199, 36);
            this.btn_NBV.TabIndex = 1;
            this.btn_NBV.Text = "Non-Basic";
            this.btn_NBV.UseVisualStyleBackColor = true;
            // 
            // btn_Activity
            // 
            this.btn_Activity.FlatAppearance.BorderSize = 10;
            this.btn_Activity.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Activity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_Activity.Location = new System.Drawing.Point(6, 201);
            this.btn_Activity.Name = "btn_Activity";
            this.btn_Activity.Size = new System.Drawing.Size(199, 36);
            this.btn_Activity.TabIndex = 5;
            this.btn_Activity.Text = "Add Variable";
            this.btn_Activity.UseVisualStyleBackColor = true;
            // 
            // btn_BV
            // 
            this.btn_BV.FlatAppearance.BorderSize = 10;
            this.btn_BV.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_BV.Location = new System.Drawing.Point(6, 75);
            this.btn_BV.Name = "btn_BV";
            this.btn_BV.Size = new System.Drawing.Size(199, 36);
            this.btn_BV.TabIndex = 2;
            this.btn_BV.Text = "Basic";
            this.btn_BV.UseVisualStyleBackColor = true;
            // 
            // btn_NBVC
            // 
            this.btn_NBVC.FlatAppearance.BorderSize = 10;
            this.btn_NBVC.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NBVC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_NBVC.Location = new System.Drawing.Point(6, 159);
            this.btn_NBVC.Name = "btn_NBVC";
            this.btn_NBVC.Size = new System.Drawing.Size(199, 36);
            this.btn_NBVC.TabIndex = 4;
            this.btn_NBVC.Text = "NBV Column";
            this.btn_NBVC.UseVisualStyleBackColor = true;
            // 
            // btn_RHS
            // 
            this.btn_RHS.FlatAppearance.BorderSize = 10;
            this.btn_RHS.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RHS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_RHS.Location = new System.Drawing.Point(6, 117);
            this.btn_RHS.Name = "btn_RHS";
            this.btn_RHS.Size = new System.Drawing.Size(199, 36);
            this.btn_RHS.TabIndex = 3;
            this.btn_RHS.Text = "RHS";
            this.btn_RHS.UseVisualStyleBackColor = true;
            // 
            // btn_output
            // 
            this.btn_output.FlatAppearance.BorderSize = 10;
            this.btn_output.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_output.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_output.Location = new System.Drawing.Point(8, 369);
            this.btn_output.Name = "btn_output";
            this.btn_output.Size = new System.Drawing.Size(199, 36);
            this.btn_output.TabIndex = 9;
            this.btn_output.Text = "Display Output";
            this.btn_output.UseVisualStyleBackColor = true;
            this.btn_output.Click += new System.EventHandler(this.btn_output_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1352, 674);
            this.Controls.Add(this.gp_sensitivity);
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
            this.gp_sensitivity.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox gp_sensitivity;
        private System.Windows.Forms.Button btn_NBV;
        private System.Windows.Forms.Button btn_Activity;
        private System.Windows.Forms.Button btn_BV;
        private System.Windows.Forms.Button btn_NBVC;
        private System.Windows.Forms.Button btn_RHS;
        private System.Windows.Forms.Button btn_Duality;
        private System.Windows.Forms.Button btn_Shadow;
        private System.Windows.Forms.Button btn_Constraint;
        private System.Windows.Forms.Button btn_output;
    }
}

