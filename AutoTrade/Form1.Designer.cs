﻿namespace AutoTrade
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                master.stop();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox_status = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.axYuantaQuote1 = new AxYuantaQuoteLib.AxYuantaQuote();
            this.textBox_status2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_sym = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefPri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpenPri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HighPri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LowPri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpPri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DnPri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatchTim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatchPri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatchQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TolMatchQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axYuantaQuote1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_status);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox3.Size = new System.Drawing.Size(419, 206);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Yuanta Quote API 連線資訊";
            // 
            // textBox_status
            // 
            this.textBox_status.Location = new System.Drawing.Point(104, 166);
            this.textBox_status.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_status.Name = "textBox_status";
            this.textBox_status.Size = new System.Drawing.Size(294, 29);
            this.textBox_status.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "狀態";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.axYuantaQuote1);
            this.groupBox1.Controls.Add(this.textBox_status2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox_sym);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(419, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(439, 206);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yuanta Quote API 商品訂閱資訊";
            // 
            // axYuantaQuote1
            // 
            this.axYuantaQuote1.Enabled = true;
            this.axYuantaQuote1.Location = new System.Drawing.Point(138, 100);
            this.axYuantaQuote1.Name = "axYuantaQuote1";
            this.axYuantaQuote1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axYuantaQuote1.OcxState")));
            this.axYuantaQuote1.Size = new System.Drawing.Size(100, 50);
            this.axYuantaQuote1.TabIndex = 23;
            this.axYuantaQuote1.OnGetMktAll += new AxYuantaQuoteLib._DYuantaQuoteEvents_OnGetMktAllEventHandler(this.axYuantaQuote1_OnGetMktAll);
            this.axYuantaQuote1.OnMktStatusChange += new AxYuantaQuoteLib._DYuantaQuoteEvents_OnMktStatusChangeEventHandler(this.axYuantaQuote1_OnMktStatusChange);
            this.axYuantaQuote1.OnRegError += new AxYuantaQuoteLib._DYuantaQuoteEvents_OnRegErrorEventHandler(this.axYuantaQuote1_OnRegError);
            // 
            // textBox_status2
            // 
            this.textBox_status2.Location = new System.Drawing.Point(126, 166);
            this.textBox_status2.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_status2.Name = "textBox_status2";
            this.textBox_status2.Size = new System.Drawing.Size(294, 29);
            this.textBox_status2.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 171);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "狀態";
            // 
            // textBox_sym
            // 
            this.textBox_sym.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_sym.Location = new System.Drawing.Point(126, 25);
            this.textBox_sym.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_sym.Name = "textBox_sym";
            this.textBox_sym.Size = new System.Drawing.Size(294, 29);
            this.textBox_sym.TabIndex = 6;
            this.textBox_sym.Text = "TXFJ4";
            this.textBox_sym.Click += new System.EventHandler(this.textBox_sym_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 29);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "商品代碼";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 206);
            this.panel1.TabIndex = 18;
            // 
            // key
            // 
            this.key.DataPropertyName = "商品代碼";
            this.key.Frozen = true;
            this.key.HeaderText = "商品代碼";
            this.key.Name = "key";
            this.key.ReadOnly = true;
            this.key.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // RefPri
            // 
            this.RefPri.DataPropertyName = "參考價";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.RefPri.DefaultCellStyle = dataGridViewCellStyle1;
            this.RefPri.HeaderText = "參考價";
            this.RefPri.Name = "RefPri";
            this.RefPri.ReadOnly = true;
            this.RefPri.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // OpenPri
            // 
            this.OpenPri.DataPropertyName = "開盤價";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.OpenPri.DefaultCellStyle = dataGridViewCellStyle2;
            this.OpenPri.HeaderText = "開盤價";
            this.OpenPri.Name = "OpenPri";
            this.OpenPri.ReadOnly = true;
            this.OpenPri.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // HighPri
            // 
            this.HighPri.DataPropertyName = "最高價";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.HighPri.DefaultCellStyle = dataGridViewCellStyle3;
            this.HighPri.HeaderText = "最高價";
            this.HighPri.Name = "HighPri";
            this.HighPri.ReadOnly = true;
            // 
            // LowPri
            // 
            this.LowPri.DataPropertyName = "最低價";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.LowPri.DefaultCellStyle = dataGridViewCellStyle4;
            this.LowPri.HeaderText = "最低價";
            this.LowPri.Name = "LowPri";
            this.LowPri.ReadOnly = true;
            // 
            // UpPri
            // 
            this.UpPri.DataPropertyName = "漲停價";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.UpPri.DefaultCellStyle = dataGridViewCellStyle5;
            this.UpPri.HeaderText = "漲停價";
            this.UpPri.Name = "UpPri";
            this.UpPri.ReadOnly = true;
            // 
            // DnPri
            // 
            this.DnPri.DataPropertyName = "跌停價";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.DnPri.DefaultCellStyle = dataGridViewCellStyle6;
            this.DnPri.HeaderText = "跌停價";
            this.DnPri.Name = "DnPri";
            this.DnPri.ReadOnly = true;
            // 
            // MatchTim
            // 
            this.MatchTim.DataPropertyName = "成交時間";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MatchTim.DefaultCellStyle = dataGridViewCellStyle7;
            this.MatchTim.HeaderText = "成交時間";
            this.MatchTim.Name = "MatchTim";
            this.MatchTim.ReadOnly = true;
            this.MatchTim.Width = 120;
            // 
            // MatchPri
            // 
            this.MatchPri.DataPropertyName = "成交價位";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.MatchPri.DefaultCellStyle = dataGridViewCellStyle8;
            this.MatchPri.HeaderText = "成交價位";
            this.MatchPri.Name = "MatchPri";
            this.MatchPri.ReadOnly = true;
            // 
            // MatchQty
            // 
            this.MatchQty.DataPropertyName = "成交數量";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.MatchQty.DefaultCellStyle = dataGridViewCellStyle9;
            this.MatchQty.HeaderText = "成交數量";
            this.MatchQty.Name = "MatchQty";
            this.MatchQty.ReadOnly = true;
            // 
            // TolMatchQty
            // 
            this.TolMatchQty.DataPropertyName = "總成交量";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.TolMatchQty.DefaultCellStyle = dataGridViewCellStyle10;
            this.TolMatchQty.HeaderText = "總成交量";
            this.TolMatchQty.Name = "TolMatchQty";
            this.TolMatchQty.ReadOnly = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 240);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 12F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " # # # # # 自動下單機V0.02  # # # # # ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axYuantaQuote1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_status2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_sym;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        //private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn key;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefPri;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpenPri;
        private System.Windows.Forms.DataGridViewTextBoxColumn HighPri;
        private System.Windows.Forms.DataGridViewTextBoxColumn LowPri;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpPri;
        private System.Windows.Forms.DataGridViewTextBoxColumn DnPri;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatchTim;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatchPri;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatchQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn TolMatchQty;
        private AxYuantaQuoteLib.AxYuantaQuote axYuantaQuote1;
    }
}
