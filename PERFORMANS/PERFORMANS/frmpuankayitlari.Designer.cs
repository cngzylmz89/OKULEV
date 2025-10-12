namespace PERFORMANS
{
    partial class frmpuankayitlari
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmpuankayitlari));
            this.raporBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pERFORMANSISTEMIDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pERFORMANSISTEMIDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.raporBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pERFORMANSISTEMIDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnpuanlanmamisogrt = new System.Windows.Forms.Button();
            this.btnpuanlamamisogrtrapor = new System.Windows.Forms.Button();
            this.btnpuanlanmamisdersrapor = new System.Windows.Forms.Button();
            this.btnpuanlanmamisders = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblpuanderssayi = new System.Windows.Forms.Label();
            this.lblpuansizderssayi = new System.Windows.Forms.Label();
            this.lblpuanogretmensayi = new System.Windows.Forms.Label();
            this.lblpuansizogretmensayi = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.raporBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERFORMANSISTEMIDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pERFORMANSISTEMIDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raporBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERFORMANSISTEMIDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // raporBindingSource1
            // 
            this.raporBindingSource1.DataMember = "rapor";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1175, 379);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "RAPOR AL(BÜTÜN NOTLAR)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.reportViewer2);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(4, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1181, 398);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer2.Location = new System.Drawing.Point(3, 16);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(1175, 379);
            this.reportViewer2.TabIndex = 1;
            this.reportViewer2.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.splitContainer1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1161, 96);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // btnpuanlanmamisogrt
            // 
            this.btnpuanlanmamisogrt.Location = new System.Drawing.Point(173, 9);
            this.btnpuanlanmamisogrt.Name = "btnpuanlanmamisogrt";
            this.btnpuanlanmamisogrt.Size = new System.Drawing.Size(201, 23);
            this.btnpuanlanmamisogrt.TabIndex = 2;
            this.btnpuanlanmamisogrt.Text = "PUANLAMAMIŞ ÖĞRETMENLER";
            this.btnpuanlanmamisogrt.UseVisualStyleBackColor = true;
            // 
            // btnpuanlamamisogrtrapor
            // 
            this.btnpuanlamamisogrtrapor.Location = new System.Drawing.Point(228, 38);
            this.btnpuanlamamisogrtrapor.Name = "btnpuanlamamisogrtrapor";
            this.btnpuanlamamisogrtrapor.Size = new System.Drawing.Size(84, 23);
            this.btnpuanlamamisogrtrapor.TabIndex = 3;
            this.btnpuanlamamisogrtrapor.Text = "RAPOR AL";
            this.btnpuanlamamisogrtrapor.UseVisualStyleBackColor = true;
            // 
            // btnpuanlanmamisdersrapor
            // 
            this.btnpuanlanmamisdersrapor.Location = new System.Drawing.Point(445, 38);
            this.btnpuanlanmamisdersrapor.Name = "btnpuanlanmamisdersrapor";
            this.btnpuanlanmamisdersrapor.Size = new System.Drawing.Size(84, 23);
            this.btnpuanlanmamisdersrapor.TabIndex = 5;
            this.btnpuanlanmamisdersrapor.Text = "RAPOR AL";
            this.btnpuanlanmamisdersrapor.UseVisualStyleBackColor = true;
            // 
            // btnpuanlanmamisders
            // 
            this.btnpuanlanmamisders.Location = new System.Drawing.Point(389, 9);
            this.btnpuanlanmamisders.Name = "btnpuanlanmamisders";
            this.btnpuanlanmamisders.Size = new System.Drawing.Size(201, 23);
            this.btnpuanlanmamisders.TabIndex = 4;
            this.btnpuanlanmamisders.Text = "PUANLANMAMIŞ DERSLER";
            this.btnpuanlanmamisders.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(3, 16);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnpuanlanmamisdersrapor);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.btnpuanlanmamisders);
            this.splitContainer1.Panel1.Controls.Add(this.btnpuanlanmamisogrt);
            this.splitContainer1.Panel1.Controls.Add(this.btnpuanlamamisogrtrapor);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(1155, 77);
            this.splitContainer1.SplitterDistance = 606;
            this.splitContainer1.TabIndex = 6;
            // 
            // lblpuanderssayi
            // 
            this.lblpuanderssayi.AutoSize = true;
            this.lblpuanderssayi.Location = new System.Drawing.Point(3, 0);
            this.lblpuanderssayi.Name = "lblpuanderssayi";
            this.lblpuanderssayi.Size = new System.Drawing.Size(146, 13);
            this.lblpuanderssayi.TabIndex = 0;
            this.lblpuanderssayi.Text = "PUANLANAN DERS SAYISI:";
            // 
            // lblpuansizderssayi
            // 
            this.lblpuansizderssayi.AutoSize = true;
            this.lblpuansizderssayi.Location = new System.Drawing.Point(3, 38);
            this.lblpuansizderssayi.Name = "lblpuansizderssayi";
            this.lblpuansizderssayi.Size = new System.Drawing.Size(169, 13);
            this.lblpuansizderssayi.TabIndex = 1;
            this.lblpuansizderssayi.Text = "PUANLANMAYAN DERS SAYISI:";
            // 
            // lblpuanogretmensayi
            // 
            this.lblpuanogretmensayi.AutoSize = true;
            this.lblpuanogretmensayi.Location = new System.Drawing.Point(275, 0);
            this.lblpuanogretmensayi.Name = "lblpuanogretmensayi";
            this.lblpuanogretmensayi.Size = new System.Drawing.Size(177, 13);
            this.lblpuanogretmensayi.TabIndex = 2;
            this.lblpuanogretmensayi.Text = "PUANLAYAN ÖĞRETMEN SAYISI:";
            // 
            // lblpuansizogretmensayi
            // 
            this.lblpuansizogretmensayi.AutoSize = true;
            this.lblpuansizogretmensayi.Location = new System.Drawing.Point(275, 38);
            this.lblpuansizogretmensayi.Name = "lblpuansizogretmensayi";
            this.lblpuansizogretmensayi.Size = new System.Drawing.Size(193, 13);
            this.lblpuansizogretmensayi.TabIndex = 3;
            this.lblpuansizogretmensayi.Text = "PUANLAMAYAN ÖĞRETMEN SAYISI:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblpuansizogretmensayi, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblpuansizderssayi, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblpuanogretmensayi, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblpuanderssayi, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(545, 77);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // frmpuankayitlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 517);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmpuankayitlari";
            this.Text = "PUAN KAYITLARI";
            this.Load += new System.EventHandler(this.frmpuankayitlari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.raporBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERFORMANSISTEMIDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pERFORMANSISTEMIDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raporBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERFORMANSISTEMIDataSet2BindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
       // private PERFORMANSISTEMIDataSet5 pERFORMANSISTEMIDataSet5;
        private System.Windows.Forms.BindingSource pERFORMANSISTEMIDataSet1BindingSource;
       // private PERFORMANSISTEMIDataSet1 pERFORMANSISTEMIDataSet1;
        private System.Windows.Forms.BindingSource pERFORMANSISTEMIDataSet3BindingSource;
        //private PERFORMANSISTEMIDataSet3 pERFORMANSISTEMIDataSet3;
        private System.Windows.Forms.BindingSource raporBindingSource;
       // private PERFORMANSISTEMIDataSet3TableAdapters.raporTableAdapter raporTableAdapter;
       // private PERFORMANSISTEMIDataSet6 pERFORMANSISTEMIDataSet6;
        private System.Windows.Forms.BindingSource raporBindingSource1;
       // private PERFORMANSISTEMIDataSet2 pERFORMANSISTEMIDataSet2;
        private System.Windows.Forms.BindingSource pERFORMANSISTEMIDataSet2BindingSource;
       // private System.Windows.Forms.BindingSource raporBindingSource2;
        //private PERFORMANSISTEMIDataSet2TableAdapters.raporTableAdapter raporTableAdapter;
        //private System.Windows.Forms.BindingSource raporBindingSource3;
      //  private PERFORMANSISTEMIDataSet4 pERFORMANSISTEMIDataSet4;
        //private System.Windows.Forms.BindingSource raporBindingSource4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.Button btnpuanlamamisogrtrapor;
        private System.Windows.Forms.Button btnpuanlanmamisogrt;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnpuanlanmamisdersrapor;
        private System.Windows.Forms.Button btnpuanlanmamisders;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblpuansizogretmensayi;
        private System.Windows.Forms.Label lblpuanogretmensayi;
        private System.Windows.Forms.Label lblpuansizderssayi;
        private System.Windows.Forms.Label lblpuanderssayi;
        // private PERFORMANSISTEMIDataSet4TableAdapters.raporTableAdapter raporTableAdapter1;
        // private PERFORMANSISTEMIDataSet6TableAdapters.raporTableAdapter raporTableAdapter1;
    }
}