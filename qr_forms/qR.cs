using Excel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace qr_forms
{
    public partial class qR : Form
    {
        private Button currb;
        private int initX;
        private int initY;
        private int mL;
        private int mT;

        private const string excelFile = "QuestionsData.xlsx";
        private const string panelNamePrefix = "pA";
        private const string buttonNamePrefix = "btnA";
        private const string labelQPrefix = "lblQ";
        private const string lblStatusFormat = "Current card is {0} of {1}";
        private const string lblSetCorrectFormat = "This set correct matches: {0}";

        private int qNumber;
        private int qCorrect;

        private int totalQuestions;
        private Dictionary<string, string> questionSet;
        private int currentSetCorrect;

        public qR()
        {
            InitializeComponent();

            this.ActiveControl = tbQ;
        }

        private void RegisterEventsToButton(Button b)
        {
            b.MouseDown += mD;
            b.MouseUp += mU;
            b.MouseMove += mM;
        }

        private void mD(object sender, MouseEventArgs e)
        {
            if (IsOver())
                return;

            if (sender.GetType() != typeof(Button))
                return;

            currb = sender as Button;
            initX = MousePosition.X;
            initY = MousePosition.Y;
            mL = currb.Left;
            mT = currb.Top;
        }

        private void mU(object sender, MouseEventArgs e)
        {
            if (IsOver())
                return;

            if (currb == null)
                return;

            var pName = panelNamePrefix + currb.Name.Split('A')[1];
            var aPanel = (Panel)Controls.Find(pName, true).FirstOrDefault();
            if (aPanel != null && currb.Left + 45 > aPanel.Left && currb.Right - 45 < aPanel.Right
                                && currb.Top + 7 > aPanel.Top && currb.Bottom - 7 < aPanel.Bottom)
            {
                qCorrect++;

                currb.Left = aPanel.Left + (aPanel.Width - currb.Width) / 2;
                currb.Top = aPanel.Top + (aPanel.Height - currb.Height) / 2;
            }
            else
            {
                currb.Left = mL;
                currb.Top = mT;
            }

            currb = null;

            if (IsOver())
            {
                currentSetCorrect++;
                MessageBox.Show("Great work!");
                lblEnd.Text = "BRAVO!";
                lblSetCorrect.Text = string.Format(lblSetCorrectFormat, currentSetCorrect);
            }
        }

        private bool IsOver()
        {
            return qNumber == qCorrect;
        }

        private void mM(object sender, MouseEventArgs e)
        {
            if (IsOver())
                return;

            if (currb == null)
                return;

            currb.Left = mL + MousePosition.X - initX;
            currb.Top = mT + MousePosition.Y - initY;
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            currentSetCorrect = 0;

            lblEnd.Text = "";

            ClearForm();

            // read excel file and get questions
            try
            {
                List<int> questionsNumbers = GetQuestionsNumbers();

                if (questionsNumbers.Count > 0)
                {
                    lblSetCorrect.Text = string.Format(lblSetCorrectFormat, currentSetCorrect);
                }
                else
                {
                    lblSetCorrect.Text = "";
                    lblStatus0.Text = "";

                    return;
                }

                if (questionsNumbers.Count > 100)
                {
                    MessageBox.Show("Maximum number of questions is 100." + Environment.NewLine + "Check your input.");
                    return;
                }

                Dictionary<string, string> QAndA = GetQuestionsFromFile(questionsNumbers);

                questionSet = QAndA;

                PutQuestionsOnForm(QAndA);

                qNumber = QAndA.Keys.Count;
                qCorrect = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            ClearForm();
            PutQuestionsOnForm(questionSet);

            lblEnd.Text = "";
            qCorrect = 0;
        }

        private void ClearForm()
        {
            List<Control> toremove = new List<Control>();

            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(Button))
                {
                    var b = c as Button;

                    if (b.Name.StartsWith(buttonNamePrefix))
                    {
                        toremove.Add(c);
                    }
                }

                if (c.GetType() == typeof(Label))
                {
                    var l = c as Label;
                    if (l.Name.StartsWith(labelQPrefix))
                    {
                        toremove.Add(c);
                    }
                }

                if (c.GetType() == typeof(Panel))
                {
                    var p = c as Panel;
                    if (p.Name.StartsWith(panelNamePrefix))
                    {
                        toremove.Add(c);
                    }
                }
            }

            for (int i = 0; i < toremove.Count; i++)
            {
                this.Controls.Remove(toremove[i]);
            }
        }

        private void PutQuestionsOnForm(Dictionary<string, string> QAndA)
        {
            Size panelSize = pTemplate.Size;
            Size buttonSize = btnTemplate.Size;
            Size lblSize = new Size(330, panelSize.Height);

            int tp = pTemplate.Top + pTemplate.Size.Height + 6;
            int lp = pTemplate.Left;

            int tl = tp + 10;
            int ll = 12;

            int tb = tp;
            int lb = btnTemplate.Left;

            List<Button> answers = new List<Button>();

            int c = 1;
            // make them
            foreach (var qa in QAndA)
            {
                var lblQ = new Label();
                lblQ.Name = labelQPrefix + c;

                var pan = new Panel();
                pan.Name = panelNamePrefix + c;

                var btn = new Button();
                btn.Name = buttonNamePrefix + c;

                btn.Font = new Font(btn.Font.FontFamily, 7);
                btn.AutoSize = true;
                btn.MaximumSize = new Size(panelSize.Width - 3, panelSize.Height - 3);

                pan.Size = panelSize;
                btn.Size = buttonSize;
                btn.AutoSize = false;

                lblQ.Text = qa.Key;
                toolTip1.SetToolTip(lblQ, qa.Key);
                btn.Text = qa.Value;
                toolTip1.SetToolTip(btn, qa.Value);

                lblQ.Top = tl;
                lblQ.Left = ll;
                lblQ.MaximumSize = lblSize;
                lblQ.Size = lblSize;

                pan.Top = tp;
                pan.Left = lp;

                pan.BorderStyle = BorderStyle.Fixed3D;
                pan.BackColor = Color.Beige;

                this.Controls.Add(lblQ);
                this.Controls.Add(pan);

                RegisterEventsToButton(btn);

                answers.Add(btn);

                // update positions
                tp = tp + pTemplate.Size.Height + 6;
                tl = tp + 10;
                tb = tp;

                c++;
            }

            answers.Shuffle();

            // reset positions
            tp = pTemplate.Top + pTemplate.Size.Height + 6;
            tl = tp + 14;
            tb = tp;

            // put buttons
            for (int i = 0; i < answers.Count; i++)
            {
                var b = answers[i];

                b.Top = tb;
                b.Left = lb;

                // update positions
                tp = tp + pTemplate.Size.Height + 6;
                tl = tp + 14;
                tb = tp;

                // todo check problem with QUESTIONS labels
                this.Controls.Add(b);
                b.BringToFront();
            }

            lblStatus0.Text = string.Format(lblStatusFormat, answers.Count, totalQuestions);
        }

        private List<int> GetQuestionsNumbers()
        {
            var numsTmp = tbQ.Text.Split(',');

            List<int> nums = new List<int>();
            foreach (var n in numsTmp)
            {
                string trimmed = n.Trim();
                if (trimmed.Contains('-'))
                {
                    string[] range = trimmed.Split('-');
                    int start;
                    int end;
                    if (range.Length >= 2 && int.TryParse(range[0].Trim(), out start) && int.TryParse(range[1].Trim(), out end))
                    {
                        for (int i = start; i <= end; i++)
                        {
                            nums.Add(i);
                        }
                    }
                }
                else
                {
                    int a;
                    if (int.TryParse(trimmed, out a))
                    {
                        nums.Add(a);
                    }
                }
            }

            return nums;
        }

        private Dictionary<string, string> GetQuestionsFromFile(List<int> questionsNumbers)
        {
            FileStream stream = File.Open(excelFile, FileMode.Open, FileAccess.Read);

            // Reading from a OpenXml Excel file (2003 format; *.xls)
            //IExcelDataReader excelReader = ExcelReaderFactory.CreateBinaryReader(stream);

            // Reading from a OpenXml Excel file (2007 format; *.xlsx)
            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);

            Dictionary<string, string> QAndA = new Dictionary<string, string>();

            int curr = 1;
            totalQuestions = 0;
            // Data Reader methods
            while (excelReader.Read())
            {
                if (questionsNumbers.Contains(curr) && curr <= questionsNumbers.Max())
                {
                    var cols = excelReader.FieldCount;
                    var t1 = excelReader.GetValue(0);

                    string q = excelReader.GetString(0);
                    string a = excelReader.GetString(1);

                    if (!QAndA.ContainsKey(q))
                    {
                        QAndA.Add(q, a);
                    }
                }

                curr++;
                totalQuestions++;
            }

            // Free resources (IExcelDataReader is IDisposable)
            excelReader.Close();

            return QAndA;
        }
    }
}