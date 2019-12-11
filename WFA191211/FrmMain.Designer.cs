namespace WFA191211
{
    partial class FrmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.utasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szerkesztésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keresésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idegenvezetőToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szállásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.útvonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.túraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTurak = new System.Windows.Forms.DataGridView();
            this.lblMa = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurak)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utasToolStripMenuItem,
            this.idegenvezetőToolStripMenuItem,
            this.szállásToolStripMenuItem,
            this.útvonalToolStripMenuItem,
            this.túraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(993, 100);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // utasToolStripMenuItem
            // 
            this.utasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.szerkesztésToolStripMenuItem,
            this.keresésToolStripMenuItem});
            this.utasToolStripMenuItem.Image = global::WFA191211.Properties.Resources.utas1;
            this.utasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.utasToolStripMenuItem.Name = "utasToolStripMenuItem";
            this.utasToolStripMenuItem.Size = new System.Drawing.Size(78, 96);
            this.utasToolStripMenuItem.Text = "Utas";
            this.utasToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // szerkesztésToolStripMenuItem
            // 
            this.szerkesztésToolStripMenuItem.Name = "szerkesztésToolStripMenuItem";
            this.szerkesztésToolStripMenuItem.Size = new System.Drawing.Size(196, 32);
            this.szerkesztésToolStripMenuItem.Text = "Szerkesztés";
            // 
            // keresésToolStripMenuItem
            // 
            this.keresésToolStripMenuItem.Name = "keresésToolStripMenuItem";
            this.keresésToolStripMenuItem.Size = new System.Drawing.Size(196, 32);
            this.keresésToolStripMenuItem.Text = "Keresés";
            // 
            // idegenvezetőToolStripMenuItem
            // 
            this.idegenvezetőToolStripMenuItem.Image = global::WFA191211.Properties.Resources.idegenvezeto;
            this.idegenvezetőToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.idegenvezetőToolStripMenuItem.Name = "idegenvezetőToolStripMenuItem";
            this.idegenvezetőToolStripMenuItem.Size = new System.Drawing.Size(144, 96);
            this.idegenvezetőToolStripMenuItem.Text = "Idegenvezető";
            this.idegenvezetőToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // szállásToolStripMenuItem
            // 
            this.szállásToolStripMenuItem.Image = global::WFA191211.Properties.Resources.szallas;
            this.szállásToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.szállásToolStripMenuItem.Name = "szállásToolStripMenuItem";
            this.szállásToolStripMenuItem.Size = new System.Drawing.Size(83, 96);
            this.szállásToolStripMenuItem.Text = "Szállás";
            this.szállásToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // útvonalToolStripMenuItem
            // 
            this.útvonalToolStripMenuItem.Image = global::WFA191211.Properties.Resources.utvonal;
            this.útvonalToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.útvonalToolStripMenuItem.Name = "útvonalToolStripMenuItem";
            this.útvonalToolStripMenuItem.Size = new System.Drawing.Size(95, 96);
            this.útvonalToolStripMenuItem.Text = "Útvonal";
            this.útvonalToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // túraToolStripMenuItem
            // 
            this.túraToolStripMenuItem.Image = global::WFA191211.Properties.Resources.tura;
            this.túraToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.túraToolStripMenuItem.Name = "túraToolStripMenuItem";
            this.túraToolStripMenuItem.Size = new System.Drawing.Size(78, 96);
            this.túraToolStripMenuItem.Text = "Túra";
            this.túraToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Túrák:";
            // 
            // dgvTurak
            // 
            this.dgvTurak.AllowUserToAddRows = false;
            this.dgvTurak.AllowUserToDeleteRows = false;
            this.dgvTurak.AllowUserToResizeColumns = false;
            this.dgvTurak.AllowUserToResizeRows = false;
            this.dgvTurak.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTurak.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTurak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurak.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTurak.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTurak.Location = new System.Drawing.Point(17, 196);
            this.dgvTurak.Name = "dgvTurak";
            this.dgvTurak.RowHeadersVisible = false;
            this.dgvTurak.RowHeadersWidth = 51;
            this.dgvTurak.RowTemplate.Height = 24;
            this.dgvTurak.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTurak.Size = new System.Drawing.Size(964, 208);
            this.dgvTurak.TabIndex = 2;
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMa.Location = new System.Drawing.Point(12, 433);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(105, 25);
            this.lblMa.TabIndex = 1;
            this.lblMa.Text = "###ma###";
            // 
            // Column1
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.FillWeight = 3F;
            this.Column1.HeaderText = "kód";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.FillWeight = 8F;
            this.Column3.HeaderText = "cél";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.FillWeight = 8F;
            this.Column2.HeaderText = "kezdet";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column4.FillWeight = 8F;
            this.Column4.HeaderText = "vég";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.FillWeight = 10F;
            this.Column5.HeaderText = "idegenvezető";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.FillWeight = 11F;
            this.Column6.HeaderText = "szállás";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column7.FillWeight = 6F;
            this.Column7.HeaderText = "ár (Ft)";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 477);
            this.Controls.Add(this.dgvTurak);
            this.Controls.Add(this.lblMa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Napos Oldal Utazási Iroda";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurak)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem utasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem idegenvezetőToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szállásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem útvonalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem túraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szerkesztésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keresésToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTurak;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}

