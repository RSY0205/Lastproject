namespace Lastproject
{
    partial class taskmanage
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.검색 = new System.Windows.Forms.TabControl();
            this.tapTaskManage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonDelTaskLog = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonSaveTask = new System.Windows.Forms.Button();
            this.dataGridViewTask = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.treeViewTaskManager = new System.Windows.Forms.TreeView();
            this.tapTaskmaster = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxMid = new System.Windows.Forms.TextBox();
            this.textBoxMain = new System.Windows.Forms.TextBox();
            this.textBoxSub = new System.Windows.Forms.TextBox();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.treeViewTask = new System.Windows.Forms.TreeView();
            this.검색.SuspendLayout();
            this.tapTaskManage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTask)).BeginInit();
            this.tapTaskmaster.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // 검색
            // 
            this.검색.Controls.Add(this.tapTaskManage);
            this.검색.Controls.Add(this.tapTaskmaster);
            this.검색.Location = new System.Drawing.Point(0, 0);
            this.검색.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.검색.Name = "검색";
            this.검색.SelectedIndex = 0;
            this.검색.Size = new System.Drawing.Size(699, 492);
            this.검색.TabIndex = 0;
            // 
            // tapTaskManage
            // 
            this.tapTaskManage.Controls.Add(this.groupBox1);
            this.tapTaskManage.Location = new System.Drawing.Point(4, 22);
            this.tapTaskManage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tapTaskManage.Name = "tapTaskManage";
            this.tapTaskManage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tapTaskManage.Size = new System.Drawing.Size(691, 466);
            this.tapTaskManage.TabIndex = 0;
            this.tapTaskManage.Text = "업무 관리";
            this.tapTaskManage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Controls.Add(this.buttonDelTaskLog);
            this.groupBox1.Controls.Add(this.buttonModify);
            this.groupBox1.Controls.Add(this.buttonSaveTask);
            this.groupBox1.Controls.Add(this.dataGridViewTask);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePickerEnd);
            this.groupBox1.Controls.Add(this.dateTimePickerStart);
            this.groupBox1.Controls.Add(this.treeViewTaskManager);
            this.groupBox1.Location = new System.Drawing.Point(0, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(691, 449);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "업무 관리";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(481, 380);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(78, 52);
            this.buttonSearch.TabIndex = 33;
            this.buttonSearch.Text = "검색";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonDelTaskLog
            // 
            this.buttonDelTaskLog.Location = new System.Drawing.Point(565, 380);
            this.buttonDelTaskLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDelTaskLog.Name = "buttonDelTaskLog";
            this.buttonDelTaskLog.Size = new System.Drawing.Size(78, 52);
            this.buttonDelTaskLog.TabIndex = 32;
            this.buttonDelTaskLog.Text = "삭제";
            this.buttonDelTaskLog.UseVisualStyleBackColor = true;
            this.buttonDelTaskLog.Click += new System.EventHandler(this.buttonDelTaskLog_Click);
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(397, 380);
            this.buttonModify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(78, 52);
            this.buttonModify.TabIndex = 31;
            this.buttonModify.Text = "수정";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // buttonSaveTask
            // 
            this.buttonSaveTask.Location = new System.Drawing.Point(313, 380);
            this.buttonSaveTask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSaveTask.Name = "buttonSaveTask";
            this.buttonSaveTask.Size = new System.Drawing.Size(78, 52);
            this.buttonSaveTask.TabIndex = 30;
            this.buttonSaveTask.Text = "저장";
            this.buttonSaveTask.UseVisualStyleBackColor = true;
            this.buttonSaveTask.Click += new System.EventHandler(this.buttonSaveTask_Click);
            // 
            // dataGridViewTask
            // 
            this.dataGridViewTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTask.Location = new System.Drawing.Point(284, 19);
            this.dataGridViewTask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewTask.Name = "dataGridViewTask";
            this.dataGridViewTask.RowHeadersWidth = 51;
            this.dataGridViewTask.RowTemplate.Height = 27;
            this.dataGridViewTask.Size = new System.Drawing.Size(403, 356);
            this.dataGridViewTask.TabIndex = 29;
            this.dataGridViewTask.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTask_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 28;
            this.label1.Text = "종료 시간";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 27;
            this.label2.Text = "시작 시간";
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(66, 409);
            this.dateTimePickerEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(180, 21);
            this.dateTimePickerEnd.TabIndex = 26;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(66, 384);
            this.dateTimePickerStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(180, 21);
            this.dateTimePickerStart.TabIndex = 25;
            // 
            // treeViewTaskManager
            // 
            this.treeViewTaskManager.Location = new System.Drawing.Point(6, 19);
            this.treeViewTaskManager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treeViewTaskManager.Name = "treeViewTaskManager";
            this.treeViewTaskManager.Size = new System.Drawing.Size(249, 356);
            this.treeViewTaskManager.TabIndex = 24;
            this.treeViewTaskManager.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView2_AfterSelect);
            // 
            // tapTaskmaster
            // 
            this.tapTaskmaster.Controls.Add(this.groupBox2);
            this.tapTaskmaster.Location = new System.Drawing.Point(4, 22);
            this.tapTaskmaster.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tapTaskmaster.Name = "tapTaskmaster";
            this.tapTaskmaster.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tapTaskmaster.Size = new System.Drawing.Size(691, 466);
            this.tapTaskmaster.TabIndex = 1;
            this.tapTaskmaster.Text = "업무 마스터";
            this.tapTaskmaster.UseVisualStyleBackColor = true;
            this.tapTaskmaster.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBoxMid);
            this.groupBox2.Controls.Add(this.textBoxMain);
            this.groupBox2.Controls.Add(this.textBoxSub);
            this.groupBox2.Controls.Add(this.buttonDel);
            this.groupBox2.Controls.Add(this.buttonSave);
            this.groupBox2.Controls.Add(this.treeViewTask);
            this.groupBox2.Location = new System.Drawing.Point(3, 7);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(679, 419);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "업무 마스터";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 21;
            this.label8.Text = "소분류";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 20;
            this.label7.Text = "중분류";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 19;
            this.label6.Text = "대분류";
            // 
            // textBoxMid
            // 
            this.textBoxMid.Location = new System.Drawing.Point(105, 177);
            this.textBoxMid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMid.Name = "textBoxMid";
            this.textBoxMid.Size = new System.Drawing.Size(192, 21);
            this.textBoxMid.TabIndex = 18;
            // 
            // textBoxMain
            // 
            this.textBoxMain.Location = new System.Drawing.Point(105, 140);
            this.textBoxMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMain.Name = "textBoxMain";
            this.textBoxMain.Size = new System.Drawing.Size(192, 21);
            this.textBoxMain.TabIndex = 17;
            // 
            // textBoxSub
            // 
            this.textBoxSub.Location = new System.Drawing.Point(105, 211);
            this.textBoxSub.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSub.Name = "textBoxSub";
            this.textBoxSub.Size = new System.Drawing.Size(192, 21);
            this.textBoxSub.TabIndex = 16;
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(431, 345);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(129, 51);
            this.buttonDel.TabIndex = 15;
            this.buttonDel.Text = "삭제";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(130, 241);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(129, 51);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.Text = "수정";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // treeViewTask
            // 
            this.treeViewTask.Location = new System.Drawing.Point(383, 28);
            this.treeViewTask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treeViewTask.Name = "treeViewTask";
            this.treeViewTask.Size = new System.Drawing.Size(249, 313);
            this.treeViewTask.TabIndex = 13;
            this.treeViewTask.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewTask_AfterSelect);
            // 
            // taskmanage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 472);
            this.Controls.Add(this.검색);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "taskmanage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.taskmanage_Load);
            this.검색.ResumeLayout(false);
            this.tapTaskManage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTask)).EndInit();
            this.tapTaskmaster.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl 검색;
        private System.Windows.Forms.TabPage tapTaskmaster;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TreeView treeViewTask;
        private System.Windows.Forms.TextBox textBoxSub;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxMid;
        private System.Windows.Forms.TextBox textBoxMain;
        private System.Windows.Forms.TabPage tapTaskManage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonDelTaskLog;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonSaveTask;
        private System.Windows.Forms.DataGridView dataGridViewTask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.TreeView treeViewTaskManager;
    }
}

