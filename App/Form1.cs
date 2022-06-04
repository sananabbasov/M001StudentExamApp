using Business;
using Entities;

namespace App
{
    public partial class Form1 : Form
    {
        ExamManager _examManager = new();
        public Form1()
        {
            InitializeComponent();
        }

        int currentQuestion = 0;
        int cVa = 0;
        int groupId = 2;


        public void CheckQuestion(string choise)
        {
            var correct = _examManager.GetGroupQuestion(currentQuestion, groupId).Question.CorrectVariant;
            if (choise == correct)
            {
                cVa++;
            }
            VariantA.Checked = true;
        }


        public void RenderQuestion(int nextQuestion = 0)
        {
            if (_examManager.GetGroupQuestion(nextQuestion, groupId) == null)
            {
                lblCorrect.Text = $"{nextQuestion}/{cVa.ToString()} Ugurlar";
                PnlExam.Visible = false;
            }
            else
            {
                LblQuestion.Text = _examManager.GetGroupQuestion(nextQuestion, groupId).Question.QuestionText;
                VariantA.Text = _examManager.GetGroupQuestion(nextQuestion, groupId).Question.VariantA;
                VariantB.Text = _examManager.GetGroupQuestion(nextQuestion, groupId).Question.VariantB;
                VariantC.Text = _examManager.GetGroupQuestion(nextQuestion, groupId).Question.VariantC;
                VariantD.Text = _examManager.GetGroupQuestion(nextQuestion, groupId).Question.VariantD;

                lblCorrect.Text = cVa.ToString();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 951;
            this.Height = 538;
            this.Location = new Point(
                this.ClientSize.Width / 2,
                this.ClientSize.Height / 2
            );

            RenderQuestion();
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {

            var vA = VariantA;
            var vB = VariantB;
            var vC = VariantC;
            var vD = VariantD;

            if (vA.Checked == true)
            {
                CheckQuestion(vA.Text);
            }
            if (vB.Checked == true)
            {
                CheckQuestion(vB.Text);
            }
            if (vC.Checked == true)
            {
                CheckQuestion(vC.Text);
            }
            if (vD.Checked == true)
            {
                CheckQuestion(vD.Text);
            }

            currentQuestion += 1;
            RenderQuestion(currentQuestion);
        }

        private void BtnStartQuiz_Click(object sender, EventArgs e)
        {
            PnlExam.Visible = true;
            PnlStartQuiz.Visible = false;
        }


        private void BtnLogin_Click(object sender, EventArgs e)
        {

            TlbLogin.Visible = false;

            this.WindowState = FormWindowState.Maximized;

            PnlStartQuiz.Location = new Point(
                this.ClientSize.Width / 2 - PnlStartQuiz.Size.Width / 2,
                this.ClientSize.Height / 2 - PnlStartQuiz.Size.Height / 2
            );

            PnlExam.Location = new Point(
                this.ClientSize.Width / 2 - PnlExam.Size.Width / 2,
                this.ClientSize.Height / 2 - PnlExam.Size.Height / 2
            );
        }
    }
}