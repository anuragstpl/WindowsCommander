namespace CommandWorker
{
    partial class Form1
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
            this.rbdWhoAmIUser = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.radSchTasks = new System.Windows.Forms.RadioButton();
            this.radNetStat = new System.Windows.Forms.RadioButton();
            this.radIpConfig = new System.Windows.Forms.RadioButton();
            this.radTaskSVC = new System.Windows.Forms.RadioButton();
            this.radSystemInfo = new System.Windows.Forms.RadioButton();
            this.radDate = new System.Windows.Forms.RadioButton();
            this.radTime = new System.Windows.Forms.RadioButton();
            this.radWhoAmI = new System.Windows.Forms.RadioButton();
            this.radWhoAmIUser = new System.Windows.Forms.RadioButton();
            this.radWhoAmIGroup = new System.Windows.Forms.RadioButton();
            this.radTaskList = new System.Windows.Forms.RadioButton();
            this.radTaskListSort = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radHandle = new System.Windows.Forms.RadioButton();
            this.radlstDLL = new System.Windows.Forms.RadioButton();
            this.radAccessCHK = new System.Windows.Forms.RadioButton();
            this.radAccessEnum = new System.Windows.Forms.RadioButton();
            this.radShareEnum = new System.Windows.Forms.RadioButton();
            this.radTCPView = new System.Windows.Forms.RadioButton();
            this.radProcessExplorer = new System.Windows.Forms.RadioButton();
            this.radPsInfo = new System.Windows.Forms.RadioButton();
            this.radPsFile = new System.Windows.Forms.RadioButton();
            this.radProcessMonitor = new System.Windows.Forms.RadioButton();
            this.radVersion = new System.Windows.Forms.RadioButton();
            this.radAutoruns = new System.Windows.Forms.RadioButton();
            this.radPsList = new System.Windows.Forms.RadioButton();
            this.rbdWhoAmIUser.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbdWhoAmIUser
            // 
            this.rbdWhoAmIUser.Controls.Add(this.tableLayoutPanel1);
            this.rbdWhoAmIUser.Location = new System.Drawing.Point(22, 24);
            this.rbdWhoAmIUser.Margin = new System.Windows.Forms.Padding(4);
            this.rbdWhoAmIUser.Name = "rbdWhoAmIUser";
            this.rbdWhoAmIUser.Padding = new System.Windows.Forms.Padding(4);
            this.rbdWhoAmIUser.Size = new System.Drawing.Size(934, 169);
            this.rbdWhoAmIUser.TabIndex = 0;
            this.rbdWhoAmIUser.TabStop = false;
            this.rbdWhoAmIUser.Text = "Commands";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.01754F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.98246F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.radProcessMonitor, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.radSchTasks, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.radNetStat, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.radIpConfig, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.radTaskSVC, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.radSystemInfo, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.radDate, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.radTime, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.radWhoAmI, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.radWhoAmIUser, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.radWhoAmIGroup, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.radTaskList, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.radTaskListSort, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.radHandle, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.radlstDLL, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.radAccessCHK, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.radAccessEnum, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.radShareEnum, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.radTCPView, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.radProcessExplorer, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.radPsInfo, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.radPsFile, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.radVersion, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.radAutoruns, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.radPsList, 3, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(22, 23);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(891, 139);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // radSchTasks
            // 
            this.radSchTasks.AutoSize = true;
            this.radSchTasks.Location = new System.Drawing.Point(546, 38);
            this.radSchTasks.Name = "radSchTasks";
            this.radSchTasks.Size = new System.Drawing.Size(74, 20);
            this.radSchTasks.TabIndex = 12;
            this.radSchTasks.TabStop = true;
            this.radSchTasks.Text = "schtasks";
            this.radSchTasks.UseVisualStyleBackColor = true;
            // 
            // radNetStat
            // 
            this.radNetStat.AutoSize = true;
            this.radNetStat.Location = new System.Drawing.Point(415, 38);
            this.radNetStat.Name = "radNetStat";
            this.radNetStat.Size = new System.Drawing.Size(102, 20);
            this.radNetStat.TabIndex = 11;
            this.radNetStat.TabStop = true;
            this.radNetStat.Text = "NetStat -ano";
            this.radNetStat.UseVisualStyleBackColor = true;
            // 
            // radIpConfig
            // 
            this.radIpConfig.AutoSize = true;
            this.radIpConfig.Location = new System.Drawing.Point(305, 38);
            this.radIpConfig.Name = "radIpConfig";
            this.radIpConfig.Size = new System.Drawing.Size(98, 20);
            this.radIpConfig.TabIndex = 10;
            this.radIpConfig.TabStop = true;
            this.radIpConfig.Text = "ipConfig/all";
            this.radIpConfig.UseVisualStyleBackColor = true;
            // 
            // radTaskSVC
            // 
            this.radTaskSVC.AutoSize = true;
            this.radTaskSVC.Location = new System.Drawing.Point(175, 38);
            this.radTaskSVC.Name = "radTaskSVC";
            this.radTaskSVC.Size = new System.Drawing.Size(104, 20);
            this.radTaskSVC.TabIndex = 9;
            this.radTaskSVC.TabStop = true;
            this.radTaskSVC.Text = "Task List/SVC";
            this.radTaskSVC.UseVisualStyleBackColor = true;
            // 
            // radSystemInfo
            // 
            this.radSystemInfo.AutoSize = true;
            this.radSystemInfo.Location = new System.Drawing.Point(688, 3);
            this.radSystemInfo.Name = "radSystemInfo";
            this.radSystemInfo.Size = new System.Drawing.Size(95, 20);
            this.radSystemInfo.TabIndex = 6;
            this.radSystemInfo.TabStop = true;
            this.radSystemInfo.Text = "System Info";
            this.radSystemInfo.UseVisualStyleBackColor = true;
            // 
            // radDate
            // 
            this.radDate.AutoSize = true;
            this.radDate.Location = new System.Drawing.Point(3, 3);
            this.radDate.Name = "radDate";
            this.radDate.Size = new System.Drawing.Size(55, 20);
            this.radDate.TabIndex = 0;
            this.radDate.TabStop = true;
            this.radDate.Text = "Date";
            this.radDate.UseVisualStyleBackColor = true;
            // 
            // radTime
            // 
            this.radTime.AutoSize = true;
            this.radTime.Location = new System.Drawing.Point(175, 3);
            this.radTime.Name = "radTime";
            this.radTime.Size = new System.Drawing.Size(55, 20);
            this.radTime.TabIndex = 1;
            this.radTime.TabStop = true;
            this.radTime.Text = "Time";
            this.radTime.UseVisualStyleBackColor = true;
            // 
            // radWhoAmI
            // 
            this.radWhoAmI.AutoSize = true;
            this.radWhoAmI.Location = new System.Drawing.Point(305, 3);
            this.radWhoAmI.Name = "radWhoAmI";
            this.radWhoAmI.Size = new System.Drawing.Size(91, 20);
            this.radWhoAmI.TabIndex = 2;
            this.radWhoAmI.TabStop = true;
            this.radWhoAmI.Text = "Who am I ?";
            this.radWhoAmI.UseVisualStyleBackColor = true;
            // 
            // radWhoAmIUser
            // 
            this.radWhoAmIUser.AutoSize = true;
            this.radWhoAmIUser.Location = new System.Drawing.Point(415, 3);
            this.radWhoAmIUser.Name = "radWhoAmIUser";
            this.radWhoAmIUser.Size = new System.Drawing.Size(124, 20);
            this.radWhoAmIUser.TabIndex = 3;
            this.radWhoAmIUser.TabStop = true;
            this.radWhoAmIUser.Text = "Who am I/User ?";
            this.radWhoAmIUser.UseVisualStyleBackColor = true;
            // 
            // radWhoAmIGroup
            // 
            this.radWhoAmIGroup.AutoSize = true;
            this.radWhoAmIGroup.Location = new System.Drawing.Point(546, 3);
            this.radWhoAmIGroup.Name = "radWhoAmIGroup";
            this.radWhoAmIGroup.Size = new System.Drawing.Size(134, 20);
            this.radWhoAmIGroup.TabIndex = 4;
            this.radWhoAmIGroup.TabStop = true;
            this.radWhoAmIGroup.Text = "Who am I/Group ?";
            this.radWhoAmIGroup.UseVisualStyleBackColor = true;
            // 
            // radTaskList
            // 
            this.radTaskList.AutoSize = true;
            this.radTaskList.Location = new System.Drawing.Point(796, 3);
            this.radTaskList.Name = "radTaskList";
            this.radTaskList.Size = new System.Drawing.Size(74, 20);
            this.radTaskList.TabIndex = 7;
            this.radTaskList.TabStop = true;
            this.radTaskList.Text = "Task List";
            this.radTaskList.UseVisualStyleBackColor = true;
            // 
            // radTaskListSort
            // 
            this.radTaskListSort.AutoSize = true;
            this.radTaskListSort.Location = new System.Drawing.Point(3, 38);
            this.radTaskListSort.Name = "radTaskListSort";
            this.radTaskListSort.Size = new System.Drawing.Size(104, 20);
            this.radTaskListSort.TabIndex = 8;
            this.radTaskListSort.TabStop = true;
            this.radTaskListSort.Text = "Task List/Sort";
            this.radTaskListSort.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(825, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Execute Command";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Location = new System.Drawing.Point(22, 337);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(934, 113);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(22, 23);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(891, 83);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(22, 207);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(934, 98);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parameters";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Paramater Status";
            // 
            // radHandle
            // 
            this.radHandle.AutoSize = true;
            this.radHandle.Location = new System.Drawing.Point(688, 38);
            this.radHandle.Name = "radHandle";
            this.radHandle.Size = new System.Drawing.Size(70, 20);
            this.radHandle.TabIndex = 14;
            this.radHandle.TabStop = true;
            this.radHandle.Text = "Handle";
            this.radHandle.UseVisualStyleBackColor = true;
            // 
            // radlstDLL
            // 
            this.radlstDLL.AutoSize = true;
            this.radlstDLL.Location = new System.Drawing.Point(796, 38);
            this.radlstDLL.Name = "radlstDLL";
            this.radlstDLL.Size = new System.Drawing.Size(76, 20);
            this.radlstDLL.TabIndex = 15;
            this.radlstDLL.TabStop = true;
            this.radlstDLL.Text = "List DLLs";
            this.radlstDLL.UseVisualStyleBackColor = true;
            // 
            // radAccessCHK
            // 
            this.radAccessCHK.AutoSize = true;
            this.radAccessCHK.Location = new System.Drawing.Point(3, 73);
            this.radAccessCHK.Name = "radAccessCHK";
            this.radAccessCHK.Size = new System.Drawing.Size(94, 20);
            this.radAccessCHK.TabIndex = 16;
            this.radAccessCHK.TabStop = true;
            this.radAccessCHK.Text = "Access CHK";
            this.radAccessCHK.UseVisualStyleBackColor = true;
            // 
            // radAccessEnum
            // 
            this.radAccessEnum.AutoSize = true;
            this.radAccessEnum.Location = new System.Drawing.Point(175, 73);
            this.radAccessEnum.Name = "radAccessEnum";
            this.radAccessEnum.Size = new System.Drawing.Size(101, 20);
            this.radAccessEnum.TabIndex = 17;
            this.radAccessEnum.TabStop = true;
            this.radAccessEnum.Text = "Access Enum";
            this.radAccessEnum.UseVisualStyleBackColor = true;
            // 
            // radShareEnum
            // 
            this.radShareEnum.AutoSize = true;
            this.radShareEnum.Location = new System.Drawing.Point(305, 73);
            this.radShareEnum.Name = "radShareEnum";
            this.radShareEnum.Size = new System.Drawing.Size(97, 20);
            this.radShareEnum.TabIndex = 18;
            this.radShareEnum.TabStop = true;
            this.radShareEnum.Text = "Share Enum";
            this.radShareEnum.UseVisualStyleBackColor = true;
            // 
            // radTCPView
            // 
            this.radTCPView.AutoSize = true;
            this.radTCPView.Location = new System.Drawing.Point(415, 73);
            this.radTCPView.Name = "radTCPView";
            this.radTCPView.Size = new System.Drawing.Size(81, 20);
            this.radTCPView.TabIndex = 19;
            this.radTCPView.TabStop = true;
            this.radTCPView.Text = "TCP View";
            this.radTCPView.UseVisualStyleBackColor = true;
            // 
            // radProcessExplorer
            // 
            this.radProcessExplorer.AutoSize = true;
            this.radProcessExplorer.Location = new System.Drawing.Point(546, 73);
            this.radProcessExplorer.Name = "radProcessExplorer";
            this.radProcessExplorer.Size = new System.Drawing.Size(122, 20);
            this.radProcessExplorer.TabIndex = 20;
            this.radProcessExplorer.TabStop = true;
            this.radProcessExplorer.Text = "Process Explorer";
            this.radProcessExplorer.UseVisualStyleBackColor = true;
            // 
            // radPsInfo
            // 
            this.radPsInfo.AutoSize = true;
            this.radPsInfo.Location = new System.Drawing.Point(688, 73);
            this.radPsInfo.Name = "radPsInfo";
            this.radPsInfo.Size = new System.Drawing.Size(63, 20);
            this.radPsInfo.TabIndex = 22;
            this.radPsInfo.TabStop = true;
            this.radPsInfo.Text = "PsInfo";
            this.radPsInfo.UseVisualStyleBackColor = true;
            // 
            // radPsFile
            // 
            this.radPsFile.AutoSize = true;
            this.radPsFile.Location = new System.Drawing.Point(796, 73);
            this.radPsFile.Name = "radPsFile";
            this.radPsFile.Size = new System.Drawing.Size(61, 20);
            this.radPsFile.TabIndex = 23;
            this.radPsFile.TabStop = true;
            this.radPsFile.Text = "PsFile";
            this.radPsFile.UseVisualStyleBackColor = true;
            // 
            // radProcessMonitor
            // 
            this.radProcessMonitor.AutoSize = true;
            this.radProcessMonitor.Location = new System.Drawing.Point(3, 107);
            this.radProcessMonitor.Name = "radProcessMonitor";
            this.radProcessMonitor.Size = new System.Drawing.Size(120, 20);
            this.radProcessMonitor.TabIndex = 24;
            this.radProcessMonitor.TabStop = true;
            this.radProcessMonitor.Text = "Process Monitor";
            this.radProcessMonitor.UseVisualStyleBackColor = true;
            // 
            // radVersion
            // 
            this.radVersion.AutoSize = true;
            this.radVersion.Location = new System.Drawing.Point(175, 107);
            this.radVersion.Name = "radVersion";
            this.radVersion.Size = new System.Drawing.Size(46, 20);
            this.radVersion.TabIndex = 25;
            this.radVersion.TabStop = true;
            this.radVersion.Text = "Ver";
            this.radVersion.UseVisualStyleBackColor = true;
            // 
            // radAutoruns
            // 
            this.radAutoruns.AutoSize = true;
            this.radAutoruns.Location = new System.Drawing.Point(305, 107);
            this.radAutoruns.Name = "radAutoruns";
            this.radAutoruns.Size = new System.Drawing.Size(81, 20);
            this.radAutoruns.TabIndex = 26;
            this.radAutoruns.TabStop = true;
            this.radAutoruns.Text = "Autoruns";
            this.radAutoruns.UseVisualStyleBackColor = true;
            // 
            // radPsList
            // 
            this.radPsList.AutoSize = true;
            this.radPsList.Location = new System.Drawing.Point(415, 107);
            this.radPsList.Name = "radPsList";
            this.radPsList.Size = new System.Drawing.Size(59, 20);
            this.radPsList.TabIndex = 27;
            this.radPsList.TabStop = true;
            this.radPsList.Text = "PsList";
            this.radPsList.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 473);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rbdWhoAmIUser);
            this.Font = new System.Drawing.Font("Miramonte", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Windows Command Worker";
            this.rbdWhoAmIUser.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox rbdWhoAmIUser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton radWhoAmIUser;
        private System.Windows.Forms.RadioButton radDate;
        private System.Windows.Forms.RadioButton radTime;
        private System.Windows.Forms.RadioButton radWhoAmI;
        private System.Windows.Forms.RadioButton radWhoAmIGroup;
        private System.Windows.Forms.RadioButton radSchTasks;
        private System.Windows.Forms.RadioButton radNetStat;
        private System.Windows.Forms.RadioButton radIpConfig;
        private System.Windows.Forms.RadioButton radTaskSVC;
        private System.Windows.Forms.RadioButton radSystemInfo;
        private System.Windows.Forms.RadioButton radTaskList;
        private System.Windows.Forms.RadioButton radTaskListSort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RadioButton radHandle;
        private System.Windows.Forms.RadioButton radlstDLL;
        private System.Windows.Forms.RadioButton radAccessCHK;
        private System.Windows.Forms.RadioButton radAccessEnum;
        private System.Windows.Forms.RadioButton radShareEnum;
        private System.Windows.Forms.RadioButton radTCPView;
        private System.Windows.Forms.RadioButton radProcessMonitor;
        private System.Windows.Forms.RadioButton radProcessExplorer;
        private System.Windows.Forms.RadioButton radPsInfo;
        private System.Windows.Forms.RadioButton radPsFile;
        private System.Windows.Forms.RadioButton radVersion;
        private System.Windows.Forms.RadioButton radAutoruns;
        private System.Windows.Forms.RadioButton radPsList;
    }
}

