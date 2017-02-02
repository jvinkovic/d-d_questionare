namespace qr_forms
{
    partial class qR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(qR));
            this.btnTemplate = new System.Windows.Forms.Button();
            this.pTemplate = new System.Windows.Forms.Panel();
            this.lblSetCorrect = new System.Windows.Forms.Label();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnGet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbQ = new System.Windows.Forms.TextBox();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblStatus0 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pTemplate.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTemplate
            // 
            this.btnTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTemplate.Location = new System.Drawing.Point(770, 13);
            this.btnTemplate.Margin = new System.Windows.Forms.Padding(4);
            this.btnTemplate.Name = "btnTemplate";
            this.btnTemplate.Size = new System.Drawing.Size(259, 28);
            this.btnTemplate.TabIndex = 4;
            this.btnTemplate.Text = "StartButton";
            this.btnTemplate.UseVisualStyleBackColor = true;
            this.btnTemplate.Visible = false;
            // 
            // pTemplate
            // 
            this.pTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pTemplate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pTemplate.Controls.Add(this.lblStatus);
            this.pTemplate.Location = new System.Drawing.Point(481, 2);
            this.pTemplate.Margin = new System.Windows.Forms.Padding(4);
            this.pTemplate.Name = "pTemplate";
            this.pTemplate.Size = new System.Drawing.Size(281, 39);
            this.pTemplate.TabIndex = 4;
            this.pTemplate.Visible = false;
            // 
            // lblSetCorrect
            // 
            this.lblSetCorrect.AutoSize = true;
            this.lblSetCorrect.Location = new System.Drawing.Point(137, -3);
            this.lblSetCorrect.Name = "lblSetCorrect";
            this.lblSetCorrect.Size = new System.Drawing.Size(62, 16);
            this.lblSetCorrect.TabIndex = 16;
            this.lblSetCorrect.Text = "                  ";
            // 
            // btnShuffle
            // 
            this.btnShuffle.Location = new System.Drawing.Point(968, 12);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(84, 29);
            this.btnShuffle.TabIndex = 16;
            this.btnShuffle.Text = "Shuffle";
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(71, 18);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 16);
            this.lblStatus.TabIndex = 14;
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(363, 15);
            this.btnGet.Margin = new System.Windows.Forms.Padding(4);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(111, 28);
            this.btnGet.TabIndex = 11;
            this.btnGet.Text = "Get questions";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "What questions?";
            // 
            // tbQ
            // 
            this.tbQ.Location = new System.Drawing.Point(140, 17);
            this.tbQ.Margin = new System.Windows.Forms.Padding(4);
            this.tbQ.Name = "tbQ";
            this.tbQ.Size = new System.Drawing.Size(213, 22);
            this.tbQ.TabIndex = 13;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.ForeColor = System.Drawing.Color.Red;
            this.lblEnd.Location = new System.Drawing.Point(771, 21);
            this.lblEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(0, 16);
            this.lblEnd.TabIndex = 14;
            // 
            // lblStatus0
            // 
            this.lblStatus0.AutoSize = true;
            this.lblStatus0.Location = new System.Drawing.Point(771, 2);
            this.lblStatus0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus0.Name = "lblStatus0";
            this.lblStatus0.Size = new System.Drawing.Size(0, 16);
            this.lblStatus0.TabIndex = 15;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 400;
            this.toolTip1.IsBalloon = true;
            // 
            // qR
            // 
            this.AcceptButton = this.btnGet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1064, 506);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.lblSetCorrect);
            this.Controls.Add(this.lblStatus0);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.tbQ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.pTemplate);
            this.Controls.Add(this.btnTemplate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1080, 545);
            this.Name = "qR";
            this.Text = "qR";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mM);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mU);
            this.pTemplate.ResumeLayout(false);
            this.pTemplate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTemplate;
        private System.Windows.Forms.Panel pTemplate;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbQ;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblStatus0;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Label lblSetCorrect;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

