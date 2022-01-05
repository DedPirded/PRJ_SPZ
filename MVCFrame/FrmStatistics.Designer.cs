
namespace MVCFrame
{
    partial class FrmStatistics
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.StatName = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbAvgReadyQueueLength = new System.Windows.Forms.TextBox();
            this.tbAvgTurnAroundTime = new System.Windows.Forms.TextBox();
            this.tbAvgWaitingTime = new System.Windows.Forms.TextBox();
            this.tbSystemPerfomance = new System.Windows.Forms.TextBox();
            this.tbCpuUtilization = new System.Windows.Forms.TextBox();
            this.tbMaxReadyQueueLength = new System.Windows.Forms.TextBox();
            this.tbCommonTurnAroundTime = new System.Windows.Forms.TextBox();
            this.tbCommonWaitingTime = new System.Windows.Forms.TextBox();
            this.tbCompletedProc = new System.Windows.Forms.TextBox();
            this.tbCpuTime = new System.Windows.Forms.TextBox();
            this.tbRejectedProc = new System.Windows.Forms.TextBox();
            this.tbArrivalProc = new System.Windows.Forms.TextBox();
            this.tbCommonTime = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.StatName.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.StatName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, -1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(343, 365);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // StatName
            // 
            this.StatName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatName.AutoSize = true;
            this.StatName.Controls.Add(this.label13);
            this.StatName.Controls.Add(this.label12);
            this.StatName.Controls.Add(this.label11);
            this.StatName.Controls.Add(this.label10);
            this.StatName.Controls.Add(this.label9);
            this.StatName.Controls.Add(this.label8);
            this.StatName.Controls.Add(this.label7);
            this.StatName.Controls.Add(this.label6);
            this.StatName.Controls.Add(this.label5);
            this.StatName.Controls.Add(this.label4);
            this.StatName.Controls.Add(this.label3);
            this.StatName.Controls.Add(this.label2);
            this.StatName.Controls.Add(this.label1);
            this.StatName.Location = new System.Drawing.Point(3, 3);
            this.StatName.Name = "StatName";
            this.StatName.Size = new System.Drawing.Size(165, 359);
            this.StatName.TabIndex = 0;
            this.StatName.TabStop = false;
            this.StatName.Text = "Параметры";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 337);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "AvgReadyQueueLength:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 311);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "AvgTurnAroundTime:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 285);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "AvgWaitingTime:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 258);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "SystemPerfomance:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "CpuUtilization:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "MaxReadyQueueLength: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "CommonTurnAroundTime: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "CommonWaitingTime: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "CompletedProcessesCount: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "CpuTime: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "RejectedProcessesCount: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ArrivalProcessesCount: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CommonTime: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.tbAvgReadyQueueLength);
            this.groupBox2.Controls.Add(this.tbAvgTurnAroundTime);
            this.groupBox2.Controls.Add(this.tbAvgWaitingTime);
            this.groupBox2.Controls.Add(this.tbSystemPerfomance);
            this.groupBox2.Controls.Add(this.tbCpuUtilization);
            this.groupBox2.Controls.Add(this.tbMaxReadyQueueLength);
            this.groupBox2.Controls.Add(this.tbCommonTurnAroundTime);
            this.groupBox2.Controls.Add(this.tbCommonWaitingTime);
            this.groupBox2.Controls.Add(this.tbCompletedProc);
            this.groupBox2.Controls.Add(this.tbCpuTime);
            this.groupBox2.Controls.Add(this.tbRejectedProc);
            this.groupBox2.Controls.Add(this.tbArrivalProc);
            this.groupBox2.Controls.Add(this.tbCommonTime);
            this.groupBox2.Location = new System.Drawing.Point(174, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(166, 359);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Значения";
            // 
            // tbAvgReadyQueueLength
            // 
            this.tbAvgReadyQueueLength.Location = new System.Drawing.Point(7, 334);
            this.tbAvgReadyQueueLength.Name = "tbAvgReadyQueueLength";
            this.tbAvgReadyQueueLength.Size = new System.Drawing.Size(133, 20);
            this.tbAvgReadyQueueLength.TabIndex = 12;
            // 
            // tbAvgTurnAroundTime
            // 
            this.tbAvgTurnAroundTime.Location = new System.Drawing.Point(7, 308);
            this.tbAvgTurnAroundTime.Name = "tbAvgTurnAroundTime";
            this.tbAvgTurnAroundTime.Size = new System.Drawing.Size(133, 20);
            this.tbAvgTurnAroundTime.TabIndex = 11;
            // 
            // tbAvgWaitingTime
            // 
            this.tbAvgWaitingTime.Location = new System.Drawing.Point(7, 282);
            this.tbAvgWaitingTime.Name = "tbAvgWaitingTime";
            this.tbAvgWaitingTime.Size = new System.Drawing.Size(133, 20);
            this.tbAvgWaitingTime.TabIndex = 10;
            // 
            // tbSystemPerfomance
            // 
            this.tbSystemPerfomance.Location = new System.Drawing.Point(7, 255);
            this.tbSystemPerfomance.Name = "tbSystemPerfomance";
            this.tbSystemPerfomance.Size = new System.Drawing.Size(133, 20);
            this.tbSystemPerfomance.TabIndex = 9;
            // 
            // tbCpuUtilization
            // 
            this.tbCpuUtilization.Location = new System.Drawing.Point(7, 228);
            this.tbCpuUtilization.Name = "tbCpuUtilization";
            this.tbCpuUtilization.Size = new System.Drawing.Size(133, 20);
            this.tbCpuUtilization.TabIndex = 8;
            // 
            // tbMaxReadyQueueLength
            // 
            this.tbMaxReadyQueueLength.Location = new System.Drawing.Point(7, 201);
            this.tbMaxReadyQueueLength.Name = "tbMaxReadyQueueLength";
            this.tbMaxReadyQueueLength.Size = new System.Drawing.Size(133, 20);
            this.tbMaxReadyQueueLength.TabIndex = 7;
            // 
            // tbCommonTurnAroundTime
            // 
            this.tbCommonTurnAroundTime.Location = new System.Drawing.Point(7, 175);
            this.tbCommonTurnAroundTime.Name = "tbCommonTurnAroundTime";
            this.tbCommonTurnAroundTime.Size = new System.Drawing.Size(133, 20);
            this.tbCommonTurnAroundTime.TabIndex = 6;
            // 
            // tbCommonWaitingTime
            // 
            this.tbCommonWaitingTime.Location = new System.Drawing.Point(7, 147);
            this.tbCommonWaitingTime.Name = "tbCommonWaitingTime";
            this.tbCommonWaitingTime.Size = new System.Drawing.Size(133, 20);
            this.tbCommonWaitingTime.TabIndex = 5;
            // 
            // tbCompletedProc
            // 
            this.tbCompletedProc.Location = new System.Drawing.Point(7, 121);
            this.tbCompletedProc.Name = "tbCompletedProc";
            this.tbCompletedProc.Size = new System.Drawing.Size(133, 20);
            this.tbCompletedProc.TabIndex = 4;
            // 
            // tbCpuTime
            // 
            this.tbCpuTime.Location = new System.Drawing.Point(7, 95);
            this.tbCpuTime.Name = "tbCpuTime";
            this.tbCpuTime.Size = new System.Drawing.Size(133, 20);
            this.tbCpuTime.TabIndex = 3;
            // 
            // tbRejectedProc
            // 
            this.tbRejectedProc.Location = new System.Drawing.Point(7, 69);
            this.tbRejectedProc.Name = "tbRejectedProc";
            this.tbRejectedProc.Size = new System.Drawing.Size(133, 20);
            this.tbRejectedProc.TabIndex = 2;
            // 
            // tbArrivalProc
            // 
            this.tbArrivalProc.Location = new System.Drawing.Point(7, 43);
            this.tbArrivalProc.Name = "tbArrivalProc";
            this.tbArrivalProc.Size = new System.Drawing.Size(133, 20);
            this.tbArrivalProc.TabIndex = 1;
            // 
            // tbCommonTime
            // 
            this.tbCommonTime.Location = new System.Drawing.Point(7, 16);
            this.tbCommonTime.Name = "tbCommonTime";
            this.tbCommonTime.Size = new System.Drawing.Size(133, 20);
            this.tbCommonTime.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FrmStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 366);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmStatistics";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "FrmStatistics";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmStatistics_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.StatName.ResumeLayout(false);
            this.StatName.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox StatName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbMaxReadyQueueLength;
        private System.Windows.Forms.TextBox tbCommonTurnAroundTime;
        private System.Windows.Forms.TextBox tbCommonWaitingTime;
        private System.Windows.Forms.TextBox tbCompletedProc;
        private System.Windows.Forms.TextBox tbCpuTime;
        private System.Windows.Forms.TextBox tbRejectedProc;
        private System.Windows.Forms.TextBox tbArrivalProc;
        private System.Windows.Forms.TextBox tbCommonTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbAvgTurnAroundTime;
        private System.Windows.Forms.TextBox tbAvgWaitingTime;
        private System.Windows.Forms.TextBox tbSystemPerfomance;
        private System.Windows.Forms.TextBox tbCpuUtilization;
        private System.Windows.Forms.TextBox tbAvgReadyQueueLength;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}