using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

using BLL;
namespace OES
{
    public partial class frmExamPanel : Form
    {
        System.Timers.Timer t;
        int h, m, s;
        QuestionList questions;
        int[] Answers = new int[10];
        int CurrentIndex;
        Student Student;
        Exam exam;
        public frmExamPanel(Exam exam,Student _student)
        {
            InitializeComponent();
            CurrentIndex = 0;
            Student = _student;
            this.exam = exam;
            questions = exam.questions;
            ExambindingSource.DataSource = questions;
            lblQuestion.ResetText();
            lblQuestion.DataBindings.Add("Text", ExambindingSource, "Ques_Desc");
            chkAnswers.Items.Clear();
            chkAnswers.Items.AddRange(questions[CurrentIndex]?.ChoiceList.Select(c=>c.Choice_Desc).ToArray());
        }
        private void Exam_Panel_Load(object sender, EventArgs e)
        {
            t = new System.Timers.Timer();
            t.Interval = 12;
            t.Elapsed += OnTimeEvent;
            t.Start();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int iSelectedIndex = chkAnswers.SelectedIndex;
            if (iSelectedIndex == -1)
                return;
            for (int iIndex = 0; iIndex < chkAnswers.Items.Count; iIndex++)
                chkAnswers.SetItemCheckState(iIndex, CheckState.Unchecked);
            chkAnswers.SetItemCheckState(iSelectedIndex, CheckState.Checked);
        }

        private void submit_bttn_Click(object sender, EventArgs e)
        {
            ExamManager.spCorrectExam(Student.St_Id, exam.Exam_No, exam.CrsID, Answers);
            this.Close();
        }

        private void prev_Click(object sender, EventArgs e)
        {            
           // lblQuestion.ResetText();

         
            ExambindingSource.MovePrevious();
            Answers[CurrentIndex--] = chkAnswers.SelectedIndex + 1;
            lblQuNo.ResetText();
            lblQuNo.Text = $"{CurrentIndex + 1}";
            chkAnswers.Items.Clear();
            chkAnswers.Items.AddRange(questions[CurrentIndex].ChoiceList.Select(c => c.Choice_Desc).ToArray());
            
        }

        private void next_Click(object sender, EventArgs e)
        {
           

            ExambindingSource.MoveNext();
           // lblQuestion.ResetText();
            Answers[CurrentIndex++] = chkAnswers.SelectedIndex + 1;

            lblQuNo.ResetText();
            lblQuNo.Text = $"{CurrentIndex + 1}";
            chkAnswers.Items.Clear();
            chkAnswers.Items.AddRange(questions[CurrentIndex].ChoiceList.Select(c => c.Choice_Desc).ToArray());
           
        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            
            Invoke(new Action(() =>
            {
                s += 1;
                if (s == 60)
                {
                    s = 0;
                    m += 1;
                }
                if (m == 60)
                {
                    m = 0;
                    h += 1;
                }
                timer_txt.Text = string.Format($"{h.ToString().PadLeft(2, '0')},{m.ToString().PadLeft(2, '0')},{s.ToString().PadLeft(2, '0')}");
            }));

            if(h==1)
            {
                t.Stop();
                MessageBox.Show("Time is Up!! Thank you");

                submit_bttn_Click( sender, e);
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
