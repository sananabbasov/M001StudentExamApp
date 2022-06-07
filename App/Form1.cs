using Business;
using Entities;

namespace App
{
    public partial class Form1 : Form
    {
        ExamManager _examManager = new();
        AuthManager _authManager = new();
        ExamResultManager _examResultManager = new();
        public Form1()
        {
            InitializeComponent();
        }

        int currentQuestion = 0;
        double cVa = 0;
        int userId = 0;
        int groupId = 0;
        int examResultId = 0;


        public void CheckQuestion(string choise)
        {
            var correct = _examManager.GetGroupQuestion(currentQuestion, groupId).Question.CorrectVariant;
            if (choise == correct)
            {
                cVa++;
            }
            VariantA.Checked = true;
        }


        public void RenderQuestion(double nextQuestion = 0)
        {
            if (_examManager.GetGroupQuestion(Convert.ToInt32(nextQuestion), groupId) == null)
            {
                lblCorrect.Text = $"{nextQuestion}/{cVa.ToString()} Ugurlar";
                PnlExam.Visible = false;
                var finishExam = _examResultManager.GetById(examResultId);
                double examResult = (cVa / nextQuestion) * 100;
                finishExam.Result = examResult;
                finishExam.IsFinished = true;
                finishExam.EndTime = DateTime.Now;

                _examResultManager.Yenile(finishExam);

                
            }
            else
            {
                LblQuestion.Text = _examManager.GetGroupQuestion(Convert.ToInt32(nextQuestion), groupId).Question.QuestionText;
                VariantA.Text = _examManager.GetGroupQuestion(Convert.ToInt32(nextQuestion), groupId).Question.VariantA;
                VariantB.Text = _examManager.GetGroupQuestion(Convert.ToInt32(nextQuestion), groupId).Question.VariantB;
                VariantC.Text = _examManager.GetGroupQuestion(Convert.ToInt32(nextQuestion), groupId).Question.VariantC;
                VariantD.Text = _examManager.GetGroupQuestion(Convert.ToInt32(nextQuestion), groupId).Question.VariantD;

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

            ExamResult result = new()
            {
                UserId = userId,
                StartTime = DateTime.Now,
                Result = 0
            };
            var examResultAdded = _examResultManager.Create(result);
            examResultId = examResultAdded.Id;
            RenderQuestion();
        }


        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var email = TxtEmail.Text;
            var password = TxtPassword.Text;
            var user = _authManager.Login(email);

            if (user == null)
            {
                MessageBox.Show("Bele bir istifadeci tapilmadi");
            }
            else
            {
                if (user.Password == password)
                {
                    userId = user.Id;
                    groupId = user.GroupId;
                    LblUserName.Visible = true;
                    LblUserName.Text = $"Xos gelmissiniz {user.Name} {user.Surname}";
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
                else
                {
                    MessageBox.Show("Email ve ya sifre sehdi");
                }
            }

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}