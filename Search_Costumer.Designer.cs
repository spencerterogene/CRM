namespace CRM
{
    partial class Search_Costumer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search_Costumer));
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxusername = new System.Windows.Forms.ComboBox();
            this.comboBoxcostumerinfo = new System.Windows.Forms.ComboBox();
            this.lblcostumerinfo = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.lblsearch = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.lblsalesmanname = new System.Windows.Forms.Label();
            this.dataGridViewcostumerinfos = new System.Windows.Forms.DataGridView();
            this.lblcostumerdatasingle = new System.Windows.Forms.Label();
            this.dataGridViewcostumerdatasingle = new System.Windows.Forms.DataGridView();
            this.groupBoxcostumersdata = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcostumerinfos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcostumerdatasingle)).BeginInit();
            this.groupBoxcostumersdata.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(348, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(494, 32);
            this.label2.TabIndex = 36;
            this.label2.Text = "Customer RelationShip Management ";
            // 
            // comboBoxusername
            // 
            this.comboBoxusername.ForeColor = System.Drawing.Color.Black;
            this.comboBoxusername.FormattingEnabled = true;
            this.comboBoxusername.Location = new System.Drawing.Point(359, 57);
            this.comboBoxusername.Name = "comboBoxusername";
            this.comboBoxusername.Size = new System.Drawing.Size(188, 29);
            this.comboBoxusername.TabIndex = 60;
            this.comboBoxusername.Text = "Choose User";
            // 
            // comboBoxcostumerinfo
            // 
            this.comboBoxcostumerinfo.ForeColor = System.Drawing.Color.Black;
            this.comboBoxcostumerinfo.FormattingEnabled = true;
            this.comboBoxcostumerinfo.Location = new System.Drawing.Point(675, 57);
            this.comboBoxcostumerinfo.Name = "comboBoxcostumerinfo";
            this.comboBoxcostumerinfo.Size = new System.Drawing.Size(188, 29);
            this.comboBoxcostumerinfo.TabIndex = 59;
            this.comboBoxcostumerinfo.Text = "Choose Info+";
            // 
            // lblcostumerinfo
            // 
            this.lblcostumerinfo.AutoSize = true;
            this.lblcostumerinfo.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcostumerinfo.Location = new System.Drawing.Point(671, 25);
            this.lblcostumerinfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcostumerinfo.Name = "lblcostumerinfo";
            this.lblcostumerinfo.Size = new System.Drawing.Size(54, 19);
            this.lblcostumerinfo.TabIndex = 58;
            this.lblcostumerinfo.Text = " Info+:";
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.White;
            this.btnsearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(1002, 59);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(87, 28);
            this.btnsearch.TabIndex = 56;
            this.btnsearch.Text = "SEARCH";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearch.Location = new System.Drawing.Point(355, 25);
            this.lblsearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(155, 19);
            this.lblsearch.TabIndex = 55;
            this.lblsearch.Text = "Customer Username:";
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.White;
            this.btnback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(615, 413);
            this.btnback.Margin = new System.Windows.Forms.Padding(2);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(161, 41);
            this.btnback.TabIndex = 44;
            this.btnback.Text = "BACK";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // lblsalesmanname
            // 
            this.lblsalesmanname.AutoSize = true;
            this.lblsalesmanname.Font = new System.Drawing.Font("Gadugi", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsalesmanname.Location = new System.Drawing.Point(597, 297);
            this.lblsalesmanname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsalesmanname.Name = "lblsalesmanname";
            this.lblsalesmanname.Size = new System.Drawing.Size(164, 21);
            this.lblsalesmanname.TabIndex = 40;
            this.lblsalesmanname.Text = "Costumer Infos +";
            // 
            // dataGridViewcostumerinfos
            // 
            this.dataGridViewcostumerinfos.AllowDrop = true;
            this.dataGridViewcostumerinfos.AllowUserToAddRows = false;
            this.dataGridViewcostumerinfos.AllowUserToDeleteRows = false;
            this.dataGridViewcostumerinfos.AllowUserToResizeColumns = false;
            this.dataGridViewcostumerinfos.AllowUserToResizeRows = false;
            this.dataGridViewcostumerinfos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewcostumerinfos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewcostumerinfos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewcostumerinfos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewcostumerinfos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewcostumerinfos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewcostumerinfos.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewcostumerinfos.Location = new System.Drawing.Point(572, 324);
            this.dataGridViewcostumerinfos.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewcostumerinfos.Name = "dataGridViewcostumerinfos";
            this.dataGridViewcostumerinfos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewcostumerinfos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewcostumerinfos.RowHeadersVisible = false;
            this.dataGridViewcostumerinfos.RowHeadersWidth = 88;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewcostumerinfos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewcostumerinfos.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewcostumerinfos.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewcostumerinfos.RowTemplate.Height = 60;
            this.dataGridViewcostumerinfos.ShowCellErrors = false;
            this.dataGridViewcostumerinfos.ShowCellToolTips = false;
            this.dataGridViewcostumerinfos.ShowEditingIcon = false;
            this.dataGridViewcostumerinfos.ShowRowErrors = false;
            this.dataGridViewcostumerinfos.Size = new System.Drawing.Size(235, 78);
            this.dataGridViewcostumerinfos.TabIndex = 39;
            // 
            // lblcostumerdatasingle
            // 
            this.lblcostumerdatasingle.AutoSize = true;
            this.lblcostumerdatasingle.Font = new System.Drawing.Font("Gadugi", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcostumerdatasingle.Location = new System.Drawing.Point(52, 65);
            this.lblcostumerdatasingle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcostumerdatasingle.Name = "lblcostumerdatasingle";
            this.lblcostumerdatasingle.Size = new System.Drawing.Size(216, 21);
            this.lblcostumerdatasingle.TabIndex = 31;
            this.lblcostumerdatasingle.Text = "Customer\'s Single Data";
            // 
            // dataGridViewcostumerdatasingle
            // 
            this.dataGridViewcostumerdatasingle.AllowDrop = true;
            this.dataGridViewcostumerdatasingle.AllowUserToAddRows = false;
            this.dataGridViewcostumerdatasingle.AllowUserToDeleteRows = false;
            this.dataGridViewcostumerdatasingle.AllowUserToResizeColumns = false;
            this.dataGridViewcostumerdatasingle.AllowUserToResizeRows = false;
            this.dataGridViewcostumerdatasingle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewcostumerdatasingle.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewcostumerdatasingle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewcostumerdatasingle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewcostumerdatasingle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewcostumerdatasingle.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewcostumerdatasingle.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewcostumerdatasingle.Location = new System.Drawing.Point(2, 91);
            this.dataGridViewcostumerdatasingle.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewcostumerdatasingle.Name = "dataGridViewcostumerdatasingle";
            this.dataGridViewcostumerdatasingle.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewcostumerdatasingle.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewcostumerdatasingle.RowHeadersVisible = false;
            this.dataGridViewcostumerdatasingle.RowHeadersWidth = 88;
            this.dataGridViewcostumerdatasingle.RowTemplate.Height = 60;
            this.dataGridViewcostumerdatasingle.ShowCellErrors = false;
            this.dataGridViewcostumerdatasingle.ShowCellToolTips = false;
            this.dataGridViewcostumerdatasingle.ShowEditingIcon = false;
            this.dataGridViewcostumerdatasingle.ShowRowErrors = false;
            this.dataGridViewcostumerdatasingle.Size = new System.Drawing.Size(1256, 204);
            this.dataGridViewcostumerdatasingle.TabIndex = 32;
            // 
            // groupBoxcostumersdata
            // 
            this.groupBoxcostumersdata.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBoxcostumersdata.Controls.Add(this.comboBoxusername);
            this.groupBoxcostumersdata.Controls.Add(this.comboBoxcostumerinfo);
            this.groupBoxcostumersdata.Controls.Add(this.lblcostumerinfo);
            this.groupBoxcostumersdata.Controls.Add(this.btnsearch);
            this.groupBoxcostumersdata.Controls.Add(this.lblsearch);
            this.groupBoxcostumersdata.Controls.Add(this.btnback);
            this.groupBoxcostumersdata.Controls.Add(this.lblsalesmanname);
            this.groupBoxcostumersdata.Controls.Add(this.dataGridViewcostumerinfos);
            this.groupBoxcostumersdata.Controls.Add(this.lblcostumerdatasingle);
            this.groupBoxcostumersdata.Controls.Add(this.dataGridViewcostumerdatasingle);
            this.groupBoxcostumersdata.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxcostumersdata.Location = new System.Drawing.Point(1, 61);
            this.groupBoxcostumersdata.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxcostumersdata.Name = "groupBoxcostumersdata";
            this.groupBoxcostumersdata.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxcostumersdata.Size = new System.Drawing.Size(1260, 456);
            this.groupBoxcostumersdata.TabIndex = 38;
            this.groupBoxcostumersdata.TabStop = false;
            this.groupBoxcostumersdata.Text = "Customer\'s Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(538, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "S E A R C H  C O S T U M E R S";
            // 
            // Search_Costumer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1282, 518);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBoxcostumersdata);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Search_Costumer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search_Costumer";
            this.Load += new System.EventHandler(this.Search_Costumer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcostumerinfos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcostumerdatasingle)).EndInit();
            this.groupBoxcostumersdata.ResumeLayout(false);
            this.groupBoxcostumersdata.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxusername;
        private System.Windows.Forms.ComboBox comboBoxcostumerinfo;
        private System.Windows.Forms.Label lblcostumerinfo;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Label lblsalesmanname;
        private System.Windows.Forms.DataGridView dataGridViewcostumerinfos;
        private System.Windows.Forms.Label lblcostumerdatasingle;
        private System.Windows.Forms.DataGridView dataGridViewcostumerdatasingle;
        private System.Windows.Forms.GroupBox groupBoxcostumersdata;
        private System.Windows.Forms.Label label3;
    }
}