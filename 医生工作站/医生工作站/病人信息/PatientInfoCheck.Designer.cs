namespace 医生工作站
{
    partial class PatientInfoCheck
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_patient_info = new System.Windows.Forms.DataGridView();
            this.lbl_picture = new System.Windows.Forms.Label();
            this.ptb_Photo = new System.Windows.Forms.PictureBox();
            this.btn_open_picture = new System.Windows.Forms.Button();
            this.btn_modify = new System.Windows.Forms.Button();
            this.txb_nameSearch = new System.Windows.Forms.TextBox();
            this.btn_nameSearch = new System.Windows.Forms.Button();
            this.btn_noSearch = new System.Windows.Forms.Button();
            this.txb_noSearch = new System.Windows.Forms.TextBox();
            this.lbl_notice = new System.Windows.Forms.Label();
            this.pnl_Moreinfo = new System.Windows.Forms.Panel();
            this.rdb_nonlocal = new System.Windows.Forms.RadioButton();
            this.rdb_local = new System.Windows.Forms.RadioButton();
            this.lbl_home_indictor = new System.Windows.Forms.Label();
            this.txb_mailAddress = new System.Windows.Forms.TextBox();
            this.lbl_mailAddress = new System.Windows.Forms.Label();
            this.lbl_idNo = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txb_relationship = new System.Windows.Forms.TextBox();
            this.lbl_relation = new System.Windows.Forms.Label();
            this.txb_contactPhone = new System.Windows.Forms.TextBox();
            this.lbl_contactPhone = new System.Windows.Forms.Label();
            this.txb_contactName = new System.Windows.Forms.TextBox();
            this.lbl_contactName = new System.Windows.Forms.Label();
            this.txb_workUnit = new System.Windows.Forms.TextBox();
            this.lbl_workUnit = new System.Windows.Forms.Label();
            this.txb_birthPlace = new System.Windows.Forms.TextBox();
            this.lbl_birthPlace = new System.Windows.Forms.Label();
            this.dtp_birth = new System.Windows.Forms.DateTimePicker();
            this.lbl_birth = new System.Windows.Forms.Label();
            this.lbl_more = new System.Windows.Forms.Label();
            this.pnl_left = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_pySearch = new System.Windows.Forms.TextBox();
            this.pnl_dgv = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_patient_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Photo)).BeginInit();
            this.pnl_Moreinfo.SuspendLayout();
            this.pnl_left.SuspendLayout();
            this.pnl_dgv.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_patient_info
            // 
            this.dgv_patient_info.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_patient_info.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_patient_info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_patient_info.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_patient_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_patient_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_patient_info.Location = new System.Drawing.Point(0, 0);
            this.dgv_patient_info.Name = "dgv_patient_info";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_patient_info.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_patient_info.RowTemplate.Height = 23;
            this.dgv_patient_info.Size = new System.Drawing.Size(900, 384);
            this.dgv_patient_info.TabIndex = 0;
            this.dgv_patient_info.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_patient_info_CellContentClick);
            // 
            // lbl_picture
            // 
            this.lbl_picture.AutoSize = true;
            this.lbl_picture.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_picture.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_picture.Location = new System.Drawing.Point(13, 10);
            this.lbl_picture.Name = "lbl_picture";
            this.lbl_picture.Size = new System.Drawing.Size(58, 21);
            this.lbl_picture.TabIndex = 1;
            this.lbl_picture.Text = "照片：";
            // 
            // ptb_Photo
            // 
            this.ptb_Photo.Location = new System.Drawing.Point(17, 34);
            this.ptb_Photo.Name = "ptb_Photo";
            this.ptb_Photo.Size = new System.Drawing.Size(128, 128);
            this.ptb_Photo.TabIndex = 2;
            this.ptb_Photo.TabStop = false;
            // 
            // btn_open_picture
            // 
            this.btn_open_picture.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_open_picture.FlatAppearance.BorderSize = 0;
            this.btn_open_picture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_open_picture.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_open_picture.Location = new System.Drawing.Point(17, 169);
            this.btn_open_picture.Name = "btn_open_picture";
            this.btn_open_picture.Size = new System.Drawing.Size(128, 30);
            this.btn_open_picture.TabIndex = 3;
            this.btn_open_picture.Text = "上传照片";
            this.btn_open_picture.UseVisualStyleBackColor = false;
            this.btn_open_picture.Click += new System.EventHandler(this.btn_open_picture_Click);
            // 
            // btn_modify
            // 
            this.btn_modify.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_modify.FlatAppearance.BorderSize = 0;
            this.btn_modify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modify.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_modify.Location = new System.Drawing.Point(17, 494);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Size = new System.Drawing.Size(128, 52);
            this.btn_modify.TabIndex = 4;
            this.btn_modify.Text = "信息修改";
            this.btn_modify.UseVisualStyleBackColor = false;
            this.btn_modify.Click += new System.EventHandler(this.btn_modify_Click);
            // 
            // txb_nameSearch
            // 
            this.txb_nameSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_nameSearch.Location = new System.Drawing.Point(17, 281);
            this.txb_nameSearch.Name = "txb_nameSearch";
            this.txb_nameSearch.Size = new System.Drawing.Size(128, 21);
            this.txb_nameSearch.TabIndex = 6;
            // 
            // btn_nameSearch
            // 
            this.btn_nameSearch.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_nameSearch.FlatAppearance.BorderSize = 0;
            this.btn_nameSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nameSearch.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_nameSearch.Location = new System.Drawing.Point(17, 310);
            this.btn_nameSearch.Name = "btn_nameSearch";
            this.btn_nameSearch.Size = new System.Drawing.Size(128, 26);
            this.btn_nameSearch.TabIndex = 7;
            this.btn_nameSearch.Text = "根据名称搜索";
            this.btn_nameSearch.UseVisualStyleBackColor = false;
            this.btn_nameSearch.Click += new System.EventHandler(this.btn_nameSearch_Click);
            // 
            // btn_noSearch
            // 
            this.btn_noSearch.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_noSearch.FlatAppearance.BorderSize = 0;
            this.btn_noSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_noSearch.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_noSearch.Location = new System.Drawing.Point(17, 248);
            this.btn_noSearch.Name = "btn_noSearch";
            this.btn_noSearch.Size = new System.Drawing.Size(128, 26);
            this.btn_noSearch.TabIndex = 9;
            this.btn_noSearch.Text = "根据编号搜索";
            this.btn_noSearch.UseVisualStyleBackColor = false;
            this.btn_noSearch.Click += new System.EventHandler(this.btn_noSearch_Click);
            // 
            // txb_noSearch
            // 
            this.txb_noSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_noSearch.Location = new System.Drawing.Point(17, 220);
            this.txb_noSearch.Name = "txb_noSearch";
            this.txb_noSearch.Size = new System.Drawing.Size(128, 21);
            this.txb_noSearch.TabIndex = 8;
            // 
            // lbl_notice
            // 
            this.lbl_notice.AutoSize = true;
            this.lbl_notice.ForeColor = System.Drawing.Color.Red;
            this.lbl_notice.Location = new System.Drawing.Point(56, 17);
            this.lbl_notice.Name = "lbl_notice";
            this.lbl_notice.Size = new System.Drawing.Size(89, 12);
            this.lbl_notice.TabIndex = 10;
            this.lbl_notice.Text = "该病人暂无照片";
            // 
            // pnl_Moreinfo
            // 
            this.pnl_Moreinfo.Controls.Add(this.rdb_nonlocal);
            this.pnl_Moreinfo.Controls.Add(this.rdb_local);
            this.pnl_Moreinfo.Controls.Add(this.lbl_home_indictor);
            this.pnl_Moreinfo.Controls.Add(this.txb_mailAddress);
            this.pnl_Moreinfo.Controls.Add(this.lbl_mailAddress);
            this.pnl_Moreinfo.Controls.Add(this.lbl_idNo);
            this.pnl_Moreinfo.Controls.Add(this.lbl_id);
            this.pnl_Moreinfo.Controls.Add(this.txb_relationship);
            this.pnl_Moreinfo.Controls.Add(this.lbl_relation);
            this.pnl_Moreinfo.Controls.Add(this.txb_contactPhone);
            this.pnl_Moreinfo.Controls.Add(this.lbl_contactPhone);
            this.pnl_Moreinfo.Controls.Add(this.txb_contactName);
            this.pnl_Moreinfo.Controls.Add(this.lbl_contactName);
            this.pnl_Moreinfo.Controls.Add(this.txb_workUnit);
            this.pnl_Moreinfo.Controls.Add(this.lbl_workUnit);
            this.pnl_Moreinfo.Controls.Add(this.txb_birthPlace);
            this.pnl_Moreinfo.Controls.Add(this.lbl_birthPlace);
            this.pnl_Moreinfo.Controls.Add(this.dtp_birth);
            this.pnl_Moreinfo.Controls.Add(this.lbl_birth);
            this.pnl_Moreinfo.Controls.Add(this.lbl_more);
            this.pnl_Moreinfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Moreinfo.Location = new System.Drawing.Point(0, 384);
            this.pnl_Moreinfo.Name = "pnl_Moreinfo";
            this.pnl_Moreinfo.Size = new System.Drawing.Size(900, 219);
            this.pnl_Moreinfo.TabIndex = 11;
            // 
            // rdb_nonlocal
            // 
            this.rdb_nonlocal.AutoSize = true;
            this.rdb_nonlocal.Location = new System.Drawing.Point(443, 46);
            this.rdb_nonlocal.Name = "rdb_nonlocal";
            this.rdb_nonlocal.Size = new System.Drawing.Size(47, 16);
            this.rdb_nonlocal.TabIndex = 19;
            this.rdb_nonlocal.TabStop = true;
            this.rdb_nonlocal.Text = "外地";
            this.rdb_nonlocal.UseVisualStyleBackColor = true;
            // 
            // rdb_local
            // 
            this.rdb_local.AutoSize = true;
            this.rdb_local.Location = new System.Drawing.Point(390, 46);
            this.rdb_local.Name = "rdb_local";
            this.rdb_local.Size = new System.Drawing.Size(47, 16);
            this.rdb_local.TabIndex = 18;
            this.rdb_local.TabStop = true;
            this.rdb_local.Text = "本地";
            this.rdb_local.UseVisualStyleBackColor = true;
            // 
            // lbl_home_indictor
            // 
            this.lbl_home_indictor.AutoSize = true;
            this.lbl_home_indictor.Location = new System.Drawing.Point(320, 48);
            this.lbl_home_indictor.Name = "lbl_home_indictor";
            this.lbl_home_indictor.Size = new System.Drawing.Size(65, 12);
            this.lbl_home_indictor.TabIndex = 17;
            this.lbl_home_indictor.Text = "地址标志：";
            // 
            // txb_mailAddress
            // 
            this.txb_mailAddress.Location = new System.Drawing.Point(653, 42);
            this.txb_mailAddress.Name = "txb_mailAddress";
            this.txb_mailAddress.Size = new System.Drawing.Size(141, 21);
            this.txb_mailAddress.TabIndex = 16;
            // 
            // lbl_mailAddress
            // 
            this.lbl_mailAddress.AutoSize = true;
            this.lbl_mailAddress.Location = new System.Drawing.Point(582, 47);
            this.lbl_mailAddress.Name = "lbl_mailAddress";
            this.lbl_mailAddress.Size = new System.Drawing.Size(65, 12);
            this.lbl_mailAddress.TabIndex = 15;
            this.lbl_mailAddress.Text = "联系地址：";
            // 
            // lbl_idNo
            // 
            this.lbl_idNo.AutoSize = true;
            this.lbl_idNo.Location = new System.Drawing.Point(121, 48);
            this.lbl_idNo.Name = "lbl_idNo";
            this.lbl_idNo.Size = new System.Drawing.Size(35, 12);
            this.lbl_idNo.TabIndex = 14;
            this.lbl_idNo.Text = "id_no";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(52, 48);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(65, 12);
            this.lbl_id.TabIndex = 13;
            this.lbl_id.Text = "身份证号：";
            // 
            // txb_relationship
            // 
            this.txb_relationship.Location = new System.Drawing.Point(653, 140);
            this.txb_relationship.Name = "txb_relationship";
            this.txb_relationship.Size = new System.Drawing.Size(141, 21);
            this.txb_relationship.TabIndex = 12;
            // 
            // lbl_relation
            // 
            this.lbl_relation.AutoSize = true;
            this.lbl_relation.Location = new System.Drawing.Point(570, 145);
            this.lbl_relation.Name = "lbl_relation";
            this.lbl_relation.Size = new System.Drawing.Size(77, 12);
            this.lbl_relation.TabIndex = 11;
            this.lbl_relation.Text = "联系人关系：";
            // 
            // txb_contactPhone
            // 
            this.txb_contactPhone.Location = new System.Drawing.Point(390, 141);
            this.txb_contactPhone.Name = "txb_contactPhone";
            this.txb_contactPhone.Size = new System.Drawing.Size(141, 21);
            this.txb_contactPhone.TabIndex = 10;
            // 
            // lbl_contactPhone
            // 
            this.lbl_contactPhone.AutoSize = true;
            this.lbl_contactPhone.Location = new System.Drawing.Point(308, 145);
            this.lbl_contactPhone.Name = "lbl_contactPhone";
            this.lbl_contactPhone.Size = new System.Drawing.Size(77, 12);
            this.lbl_contactPhone.TabIndex = 9;
            this.lbl_contactPhone.Text = "联系人电话：";
            // 
            // txb_contactName
            // 
            this.txb_contactName.Location = new System.Drawing.Point(123, 140);
            this.txb_contactName.Name = "txb_contactName";
            this.txb_contactName.Size = new System.Drawing.Size(141, 21);
            this.txb_contactName.TabIndex = 8;
            // 
            // lbl_contactName
            // 
            this.lbl_contactName.AutoSize = true;
            this.lbl_contactName.Location = new System.Drawing.Point(64, 145);
            this.lbl_contactName.Name = "lbl_contactName";
            this.lbl_contactName.Size = new System.Drawing.Size(53, 12);
            this.lbl_contactName.TabIndex = 7;
            this.lbl_contactName.Text = "联系人：";
            // 
            // txb_workUnit
            // 
            this.txb_workUnit.Location = new System.Drawing.Point(653, 89);
            this.txb_workUnit.Name = "txb_workUnit";
            this.txb_workUnit.Size = new System.Drawing.Size(141, 21);
            this.txb_workUnit.TabIndex = 6;
            // 
            // lbl_workUnit
            // 
            this.lbl_workUnit.AutoSize = true;
            this.lbl_workUnit.Location = new System.Drawing.Point(582, 94);
            this.lbl_workUnit.Name = "lbl_workUnit";
            this.lbl_workUnit.Size = new System.Drawing.Size(65, 12);
            this.lbl_workUnit.TabIndex = 5;
            this.lbl_workUnit.Text = "工作单位：";
            // 
            // txb_birthPlace
            // 
            this.txb_birthPlace.Location = new System.Drawing.Point(390, 89);
            this.txb_birthPlace.Name = "txb_birthPlace";
            this.txb_birthPlace.Size = new System.Drawing.Size(141, 21);
            this.txb_birthPlace.TabIndex = 4;
            // 
            // lbl_birthPlace
            // 
            this.lbl_birthPlace.AutoSize = true;
            this.lbl_birthPlace.Location = new System.Drawing.Point(332, 95);
            this.lbl_birthPlace.Name = "lbl_birthPlace";
            this.lbl_birthPlace.Size = new System.Drawing.Size(53, 12);
            this.lbl_birthPlace.TabIndex = 3;
            this.lbl_birthPlace.Text = "出生地：";
            // 
            // dtp_birth
            // 
            this.dtp_birth.Location = new System.Drawing.Point(123, 86);
            this.dtp_birth.Name = "dtp_birth";
            this.dtp_birth.Size = new System.Drawing.Size(141, 21);
            this.dtp_birth.TabIndex = 2;
            // 
            // lbl_birth
            // 
            this.lbl_birth.AutoSize = true;
            this.lbl_birth.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbl_birth.Location = new System.Drawing.Point(76, 92);
            this.lbl_birth.Name = "lbl_birth";
            this.lbl_birth.Size = new System.Drawing.Size(41, 12);
            this.lbl_birth.TabIndex = 1;
            this.lbl_birth.Text = "生日：";
            // 
            // lbl_more
            // 
            this.lbl_more.AutoSize = true;
            this.lbl_more.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_more.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_more.Location = new System.Drawing.Point(3, 3);
            this.lbl_more.Name = "lbl_more";
            this.lbl_more.Size = new System.Drawing.Size(104, 19);
            this.lbl_more.TabIndex = 0;
            this.lbl_more.Text = "更多信息：";
            // 
            // pnl_left
            // 
            this.pnl_left.Controls.Add(this.label1);
            this.pnl_left.Controls.Add(this.txb_pySearch);
            this.pnl_left.Controls.Add(this.btn_open_picture);
            this.pnl_left.Controls.Add(this.btn_modify);
            this.pnl_left.Controls.Add(this.txb_nameSearch);
            this.pnl_left.Controls.Add(this.btn_nameSearch);
            this.pnl_left.Controls.Add(this.txb_noSearch);
            this.pnl_left.Controls.Add(this.btn_noSearch);
            this.pnl_left.Controls.Add(this.lbl_notice);
            this.pnl_left.Controls.Add(this.lbl_picture);
            this.pnl_left.Controls.Add(this.ptb_Photo);
            this.pnl_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_left.Location = new System.Drawing.Point(0, 0);
            this.pnl_left.Name = "pnl_left";
            this.pnl_left.Size = new System.Drawing.Size(166, 603);
            this.pnl_left.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "根据拼音缩写搜索：";
            // 
            // txb_pySearch
            // 
            this.txb_pySearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_pySearch.Location = new System.Drawing.Point(17, 363);
            this.txb_pySearch.Name = "txb_pySearch";
            this.txb_pySearch.Size = new System.Drawing.Size(128, 21);
            this.txb_pySearch.TabIndex = 12;
            this.txb_pySearch.TextChanged += new System.EventHandler(this.txb_pySearch_TextChanged);
            // 
            // pnl_dgv
            // 
            this.pnl_dgv.Controls.Add(this.dgv_patient_info);
            this.pnl_dgv.Controls.Add(this.pnl_Moreinfo);
            this.pnl_dgv.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_dgv.Location = new System.Drawing.Point(164, 0);
            this.pnl_dgv.Name = "pnl_dgv";
            this.pnl_dgv.Size = new System.Drawing.Size(900, 603);
            this.pnl_dgv.TabIndex = 13;
            // 
            // PatientInfoCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.pnl_dgv);
            this.Controls.Add(this.pnl_left);
            this.Name = "PatientInfoCheck";
            this.Size = new System.Drawing.Size(1064, 603);
            this.Load += new System.EventHandler(this.PatientInfoCheck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_patient_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Photo)).EndInit();
            this.pnl_Moreinfo.ResumeLayout(false);
            this.pnl_Moreinfo.PerformLayout();
            this.pnl_left.ResumeLayout(false);
            this.pnl_left.PerformLayout();
            this.pnl_dgv.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_patient_info;
        private System.Windows.Forms.Label lbl_picture;
        private System.Windows.Forms.PictureBox ptb_Photo;
        private System.Windows.Forms.Button btn_open_picture;
        private System.Windows.Forms.Button btn_modify;
        private System.Windows.Forms.TextBox txb_nameSearch;
        private System.Windows.Forms.Button btn_nameSearch;
        private System.Windows.Forms.Button btn_noSearch;
        private System.Windows.Forms.TextBox txb_noSearch;
        private System.Windows.Forms.Label lbl_notice;
        private System.Windows.Forms.Panel pnl_Moreinfo;
        private System.Windows.Forms.Panel pnl_left;
        private System.Windows.Forms.Panel pnl_dgv;
        private System.Windows.Forms.Label lbl_more;
        private System.Windows.Forms.RadioButton rdb_nonlocal;
        private System.Windows.Forms.RadioButton rdb_local;
        private System.Windows.Forms.Label lbl_home_indictor;
        private System.Windows.Forms.TextBox txb_mailAddress;
        private System.Windows.Forms.Label lbl_mailAddress;
        private System.Windows.Forms.Label lbl_idNo;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txb_relationship;
        private System.Windows.Forms.Label lbl_relation;
        private System.Windows.Forms.TextBox txb_contactPhone;
        private System.Windows.Forms.Label lbl_contactPhone;
        private System.Windows.Forms.TextBox txb_contactName;
        private System.Windows.Forms.Label lbl_contactName;
        private System.Windows.Forms.TextBox txb_workUnit;
        private System.Windows.Forms.Label lbl_workUnit;
        private System.Windows.Forms.TextBox txb_birthPlace;
        private System.Windows.Forms.Label lbl_birthPlace;
        private System.Windows.Forms.DateTimePicker dtp_birth;
        private System.Windows.Forms.Label lbl_birth;
        private System.Windows.Forms.TextBox txb_pySearch;
        private System.Windows.Forms.Label label1;
    }
}
