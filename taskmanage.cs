using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lastproject
{
    public partial class taskmanage : Form
    {
        public taskmanage()
        {
            InitializeComponent();
            InitialzieDateTimePicker();
            InitializeTreeView();
            InitializeTreViewtaskManage();
        }
        private void InitializeTreViewtaskManage() {
            treeViewTaskManager.Nodes.Clear();
            int checkmain = 0, checkmid = 0, checksub = 0;
            String query = "SELECT * FROM tasklist";//SELECT 쿼리 작성
            List<string> task = new List<string>();
            task = null;//초기화
            task = DBManager.GetInstance().SelectTaskList(query);//DB 입력
            for (int i = 0; i < task.Count;)
            {
                if (i == 0)
                {
                    treeViewTaskManager.Nodes.Add(task[i + 1]);
                    treeViewTaskManager.Nodes[0].Nodes.Add(task[i + 2]);
                    treeViewTaskManager.Nodes[0].Nodes[0].Nodes.Add(task[i + 3]);
                }
                else
                {
                    for (int j = 0; j < treeViewTaskManager.Nodes.Count; j++)
                    {
                        if (treeViewTaskManager.Nodes[j].Text == task[i + 1])
                        {
                            checkmain = 1;
                            for (int z = 0; z < treeViewTaskManager.Nodes[j].Nodes.Count; z++)
                            {
                                if (treeViewTaskManager.Nodes[j].Nodes[z].Text == task[i + 2])
                                {
                                    checkmid = 1;
                                    treeViewTaskManager.Nodes[j].Nodes[z].Nodes.Add(task[i + 3]);
                                    break;
                                }

                                else
                                {
                                    int temp1 = treeViewTaskManager.Nodes.Count - 1;
                                    treeViewTaskManager.Nodes[temp1].Nodes.Add(task[i + 2]);
                                    int temp2 = treeViewTaskManager.Nodes[temp1].Nodes.Count - 1;
                                    treeViewTaskManager.Nodes[temp1].Nodes[temp2].Nodes.Add(task[i + 3]);
                                    break;

                                }

                            }
                        }

                    }

                    if (checkmain == 0)
                    {
                        treeViewTaskManager.Nodes.Add(task[i + 1]);
                        int temp1 = treeViewTaskManager.Nodes.Count - 1;
                        treeViewTaskManager.Nodes[temp1].Nodes.Add(task[i + 2]);
                        int temp2 = treeViewTaskManager.Nodes[temp1].Nodes.Count - 1;
                        treeViewTaskManager.Nodes[temp1].Nodes[temp2].Nodes.Add(task[i + 3]);

                    }
                }
                i += 4;
                checkmain = 0;
                checkmid = 0;
            }

        }
        private void InitialzieDateTimePicker()
        {
            dateTimePickerStart.CustomFormat = "yy년 MM월 dd일 HH시 mm분";
            dateTimePickerStart.Format = DateTimePickerFormat.Custom;
            dateTimePickerEnd.CustomFormat = "yy년 MM월 dd일 HH시 mm분";
            dateTimePickerEnd.Format = DateTimePickerFormat.Custom;
        }

        private void InitializeTreeView() 
        {
            treeViewTask.Nodes.Clear();
            int checkmain = 0, checkmid = 0,checksub=0 ;
            String query = "SELECT * FROM tasklist";//SELECT 쿼리 작성
            List<string> task=new List<string>();
            task = null;//초기화
            task=DBManager.GetInstance().SelectTaskList(query);
            for(int i = 0; i < task.Count;) {
                if (i == 0)
                {
                    treeViewTask.Nodes.Add(task[i + 1]);
                    treeViewTask.Nodes[0].Nodes.Add(task[i + 2]);
                    treeViewTask.Nodes[0].Nodes[0].Nodes.Add(task[i + 3]);
                }
                else
                {
                    for (int j = 0; j < treeViewTask.Nodes.Count; j++)
                    {
                        if (treeViewTask.Nodes[j].Text == task[i + 1])
                        {
                            checkmain = 1;
                            for (int z = 0; z < treeViewTask.Nodes[j].Nodes.Count; z++)
                            {
                                if (treeViewTask.Nodes[j].Nodes[z].Text == task[i + 2])
                                {
                                    checkmid = 1;
                                    treeViewTask.Nodes[j].Nodes[z].Nodes.Add(task[i + 3]);
                                    break;
                                }

                                else {
                                    int temp1 = treeViewTask.Nodes.Count - 1;
                                    treeViewTask.Nodes[temp1].Nodes.Add(task[i + 2]);
                                    int temp2 = treeViewTask.Nodes[temp1].Nodes.Count - 1;
                                    treeViewTask.Nodes[temp1].Nodes[temp2].Nodes.Add(task[i + 3]);
                                    break;
                                    }

                                }
                            }

                        }

                    if (checkmain == 0){
                        treeViewTask.Nodes.Add(task[i + 1]);
                        int temp1 = treeViewTask.Nodes.Count - 1;
                        treeViewTask.Nodes[temp1].Nodes.Add(task[i + 2]);
                        int temp2 = treeViewTask.Nodes[temp1].Nodes.Count - 1;
                        treeViewTask.Nodes[temp1].Nodes[temp2].Nodes.Add(task[i + 3]);
                        //break;
                                        }
                }
                i += 4;
                checkmain = 0;
                checkmid = 0;
                //MessageBox.Show(Convert.ToString(i));
            }            
        }


        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO tasklist(maincategory,middlecategory,subcategory) values('" + textBoxMain.Text + "','" + textBoxMid.Text + "','" + textBoxSub.Text + "')";
            DBManager.GetInstance().SendQuery(query);
            InitializeTreeView();
            InitializeTreViewtaskManage();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (treeViewTask.SelectedNode == null) { MessageBox.Show("삭제할 값을 선택해주세요"); }
            else
            {
                String temp = treeViewTask.SelectedNode.FullPath;
                String Query = null;
                String[] split_temp;

                split_temp = temp.Split('\\');
                if (split_temp.Length == 1)
                {
                    Query = "delete from tasklist where maincategory='" + split_temp[0] + "'";
                }
                else if (split_temp.Length == 2)
                {
                    Query = "delete from tasklist where middlecategory='" + split_temp[1] + "'";
                }
                else if (split_temp.Length == 3)
                {
                    Query = "delete from tasklist where subcategory='" + split_temp[2] + "'";
                }
                DBManager.GetInstance().SendQuery(Query);
                InitializeTreeView();
                InitializeTreViewtaskManage();
            }
        }

        private void comboBoxMid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void taskmanage_Load(object sender, EventArgs e)
        {

        }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void buttonSaveTask_Click(object sender, EventArgs e)
        {
            if (treeViewTaskManager.SelectedNode == null) { MessageBox.Show("등록할 업무를 선택해주세요"); }
            else {
            String temp = treeViewTaskManager.SelectedNode.FullPath;
            String[] split_temp = new String[3] {null,null,null} ;
                split_temp=temp.Split('\\');

            String ID = "test";
            String name = "tester";
                //for (int i = 0; i < 3; i++) { MessageBox.Show(split_temp[i]); }

            if (split_temp.Length < 1) { MessageBox.Show("대분류를 선택해주세요"); }
            else if (split_temp.Length < 2) { MessageBox.Show("중분류를 선택해주세요"); }
            else if (split_temp.Length < 3) { MessageBox.Show("소분류를 선택해주세요"); }
            else{
                String query = "INSERT INTO taskhistory(starttime,endtime,user_id,name,maincategory,middlecategory,subcategory) values('" + dateTimePickerStart.Text + "','" + dateTimePickerEnd.Text + "','" + ID + "','" + name + "','" + split_temp[0] + "','" + split_temp[1] + "','" + split_temp[2] + "')";
                DBManager.GetInstance().SendQuery(query);
                MessageBox.Show("업무등록을 완료하였습니다!");
            }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            String ID = "test";
            String query ="SELECT id as 번호, starttime as 시작시간, endtime as 종료시간, user_id as 사용자ID, name as 이름, maincategory as 대분류, middlecategory as 중분류, subcategory as 소분류 FROM taskhistory WhERE user_id='"+ID+"'";
            DBManager.GetInstance().showdataGridView(query, dataGridViewTask);


        }

        private void dataGridViewTask_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void buttonDelTaskLog_Click(object sender, EventArgs e)
        {
            if (dataGridViewTask.Rows[dataGridViewTask.CurrentCellAddress.Y].Cells[0].Value.ToString() == null) { MessageBox.Show("잘못된 접근입니다."); }
            else
            {
                String seldel = dataGridViewTask.Rows[dataGridViewTask.CurrentCellAddress.Y].Cells[0].Value.ToString();
                if (MessageBox.Show("선택하신 업무 기록이 삭제됩니다.\n 선택한 번호는 " + seldel + "입니다.", "YesOrNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    String Query = "delete from taskhistory where id='" + seldel + "'";            
                    DBManager.GetInstance().SendQuery(Query);
                    MessageBox.Show("삭제 되었습니다.");
                    String ID = "test";
                    String query = "SELECT id as 번호, starttime as 시작시간, endtime as 종료시간, user_id as 사용자ID, name as 이름, maincategory as 대분류, middlecategory as 중분류, subcategory as 소분류 FROM taskhistory WhERE user_id='" + ID + "'";
                    DBManager.GetInstance().showdataGridView(query, dataGridViewTask);
                }
                else
                {
                    MessageBox.Show("취소 되었습니다.");
                }
            }

        }                                                            
        }
}
