namespace 医生工作站
{
    partial class PatientBed_Assign
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
            this.lsb_patient = new System.Windows.Forms.ListBox();
            this.lbl_list = new System.Windows.Forms.Label();
            this.lsb_bed = new System.Windows.Forms.ListBox();
            this.lbl_bed = new System.Windows.Forms.Label();
            this.btn_assign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsb_patient
            // 
            this.lsb_patient.FormattingEnabled = true;
            this.lsb_patient.ItemHeight = 12;
            this.lsb_patient.Location = new System.Drawing.Point(100, 65);
            this.lsb_patient.Name = "lsb_patient";
            this.lsb_patient.Size = new System.Drawing.Size(210, 232);
            this.lsb_patient.TabIndex = 1;
            // 
            // lbl_list
            // 
            this.lbl_list.AutoSize = true;
            this.lbl_list.Location = new System.Drawing.Point(98, 50);
            this.lbl_list.Name = "lbl_list";
            this.lbl_list.Size = new System.Drawing.Size(41, 12);
            this.lbl_list.TabIndex = 2;
            this.lbl_list.Text = "病人：";
            // 
            // lsb_bed
            // 
            this.lsb_bed.FormattingEnabled = true;
            this.lsb_bed.ItemHeight = 12;
            this.lsb_bed.Location = new System.Drawing.Point(465, 65);
            this.lsb_bed.Name = "lsb_bed";
            this.lsb_bed.Size = new System.Drawing.Size(210, 232);
            this.lsb_bed.TabIndex = 3;
            // 
            // lbl_bed
            // 
            this.lbl_bed.AutoSize = true;
            this.lbl_bed.Location = new System.Drawing.Point(465, 50);
            this.lbl_bed.Name = "lbl_bed";
            this.lbl_bed.Size = new System.Drawing.Size(41, 12);
            this.lbl_bed.TabIndex = 4;
            this.lbl_bed.Text = "病床：";
            // 
            // btn_assign
            // 
            this.btn_assign.BackColor = System.Drawing.Color.LightPink;
            this.btn_assign.FlatAppearance.BorderSize = 0;
            this.btn_assign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_assign.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_assign.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_assign.Location = new System.Drawing.Point(310, 347);
            this.btn_assign.Name = "btn_assign";
            this.btn_assign.Size = new System.Drawing.Size(153, 48);
            this.btn_assign.TabIndex = 5;
            this.btn_assign.Text = "分配";
            this.btn_assign.UseVisualStyleBackColor = false;
            // 
            // PatientBed_Assign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(792, 418);
            this.Controls.Add(this.btn_assign);
            this.Controls.Add(this.lbl_bed);
            this.Controls.Add(this.lsb_bed);
            this.Controls.Add(this.lbl_list);
            this.Controls.Add(this.lsb_patient);
            this.Name = "PatientBed_Assign";
            this.Text = "PatientBed_Assign";
            this.Load += new System.EventHandler(this.PatientBed_Assign_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsb_patient;
        private System.Windows.Forms.Label lbl_list;
        private System.Windows.Forms.ListBox lsb_bed;
        private System.Windows.Forms.Label lbl_bed;
        private System.Windows.Forms.Button btn_assign;
    }
}