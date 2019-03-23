namespace CipherCompilerLexicalAnalyzer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.codeTxtBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numLstView = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.unLstView = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.binlstView = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.conLstView = new System.Windows.Forms.ListView();
            this.label7 = new System.Windows.Forms.Label();
            this.resLstView = new System.Windows.Forms.ListView();
            this.label8 = new System.Windows.Forms.Label();
            this.PuncLstView = new System.Windows.Forms.ListView();
            this.label9 = new System.Windows.Forms.Label();
            this.TerminatorLstView = new System.Windows.Forms.ListView();
            this.label11 = new System.Windows.Forms.Label();
            this.idLstView = new System.Windows.Forms.ListView();
            this.btnGenerateTokens = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // codeTxtBox
            // 
            this.codeTxtBox.DetectUrls = false;
            this.codeTxtBox.Location = new System.Drawing.Point(12, 66);
            this.codeTxtBox.Name = "codeTxtBox";
            this.codeTxtBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.codeTxtBox.Size = new System.Drawing.Size(503, 368);
            this.codeTxtBox.TabIndex = 0;
            this.codeTxtBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Forte", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(72, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cipher Compiler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(538, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Numerics:";
            // 
            // numLstView
            // 
            this.numLstView.Location = new System.Drawing.Point(541, 82);
            this.numLstView.Name = "numLstView";
            this.numLstView.Size = new System.Drawing.Size(116, 387);
            this.numLstView.TabIndex = 4;
            this.numLstView.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(660, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Uninary Operator:";
            // 
            // unLstView
            // 
            this.unLstView.Location = new System.Drawing.Point(663, 285);
            this.unLstView.Name = "unLstView";
            this.unLstView.Size = new System.Drawing.Size(116, 184);
            this.unLstView.TabIndex = 8;
            this.unLstView.UseCompatibleStateImageBehavior = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(660, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Binary Operator:";
            // 
            // binlstView
            // 
            this.binlstView.Location = new System.Drawing.Point(663, 82);
            this.binlstView.Name = "binlstView";
            this.binlstView.Size = new System.Drawing.Size(116, 184);
            this.binlstView.TabIndex = 6;
            this.binlstView.UseCompatibleStateImageBehavior = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(782, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Console Operator:";
            // 
            // conLstView
            // 
            this.conLstView.Location = new System.Drawing.Point(785, 285);
            this.conLstView.Name = "conLstView";
            this.conLstView.Size = new System.Drawing.Size(116, 184);
            this.conLstView.TabIndex = 12;
            this.conLstView.UseCompatibleStateImageBehavior = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(782, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Reserve Word:";
            // 
            // resLstView
            // 
            this.resLstView.Location = new System.Drawing.Point(785, 82);
            this.resLstView.Name = "resLstView";
            this.resLstView.Size = new System.Drawing.Size(116, 184);
            this.resLstView.TabIndex = 10;
            this.resLstView.UseCompatibleStateImageBehavior = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(904, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Punctuation:";
            // 
            // PuncLstView
            // 
            this.PuncLstView.Location = new System.Drawing.Point(907, 285);
            this.PuncLstView.Name = "PuncLstView";
            this.PuncLstView.Size = new System.Drawing.Size(116, 184);
            this.PuncLstView.TabIndex = 16;
            this.PuncLstView.UseCompatibleStateImageBehavior = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(904, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Terminator:";
            // 
            // TerminatorLstView
            // 
            this.TerminatorLstView.Location = new System.Drawing.Point(907, 82);
            this.TerminatorLstView.Name = "TerminatorLstView";
            this.TerminatorLstView.Size = new System.Drawing.Size(116, 184);
            this.TerminatorLstView.TabIndex = 14;
            this.TerminatorLstView.UseCompatibleStateImageBehavior = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1026, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Identifier:";
            // 
            // idLstView
            // 
            this.idLstView.Location = new System.Drawing.Point(1029, 82);
            this.idLstView.Name = "idLstView";
            this.idLstView.Size = new System.Drawing.Size(116, 387);
            this.idLstView.TabIndex = 18;
            this.idLstView.UseCompatibleStateImageBehavior = false;
            // 
            // btnGenerateTokens
            // 
            this.btnGenerateTokens.BackColor = System.Drawing.SystemColors.Control;
            this.btnGenerateTokens.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateTokens.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnGenerateTokens.Location = new System.Drawing.Point(286, 441);
            this.btnGenerateTokens.Name = "btnGenerateTokens";
            this.btnGenerateTokens.Size = new System.Drawing.Size(228, 28);
            this.btnGenerateTokens.TabIndex = 20;
            this.btnGenerateTokens.Text = "Generate Tokens";
            this.btnGenerateTokens.UseVisualStyleBackColor = false;
            this.btnGenerateTokens.Click += new System.EventHandler(this.btnGenerateTokens_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 484);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Error Window:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.ForeColor = System.Drawing.Color.Red;
            this.richTextBox1.Location = new System.Drawing.Point(16, 501);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(1131, 193);
            this.richTextBox1.TabIndex = 22;
            this.richTextBox1.Text = "";
            // 
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.Color.LimeGreen;
            this.progressBar.Location = new System.Drawing.Point(541, 37);
            this.progressBar.MarqueeAnimationSpeed = 15;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(604, 23);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 23;
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Location = new System.Drawing.Point(12, 441);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(106, 28);
            this.btnClear.TabIndex = 24;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(1159, 706);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnGenerateTokens);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.idLstView);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PuncLstView);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TerminatorLstView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.conLstView);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.resLstView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.unLstView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.binlstView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numLstView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.codeTxtBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Cipher Compiler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox codeTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView numLstView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView unLstView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView binlstView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView conLstView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView resLstView;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView PuncLstView;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView TerminatorLstView;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListView idLstView;
        private System.Windows.Forms.Button btnGenerateTokens;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnClear;
    }
}

