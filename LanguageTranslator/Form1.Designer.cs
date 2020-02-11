namespace LanguageTranslator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnTranslate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.offlineTranslate = new System.Windows.Forms.Button();
            this.OfflineDetect = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtSrcLang = new System.Windows.Forms.TextBox();
            this.btnDetectSrc = new System.Windows.Forms.Button();
            this.richTextSrc = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.destinationLangPane = new System.Windows.Forms.Panel();
            this.DestRichT = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnOffline = new System.Windows.Forms.Button();
            this.addwordPanel = new System.Windows.Forms.Panel();
            this.offlineClear = new System.Windows.Forms.Button();
            this.richHausa = new System.Windows.Forms.RichTextBox();
            this.richIgbo = new System.Windows.Forms.RichTextBox();
            this.richEnglish = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnwordAdd = new System.Windows.Forms.Button();
            this.btnEnglish = new System.Windows.Forms.Button();
            this.btnIgbo = new System.Windows.Forms.Button();
            this.btnHausa = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.destinationLangPane.SuspendLayout();
            this.addwordPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTranslate
            // 
            this.btnTranslate.BackColor = System.Drawing.Color.DarkViolet;
            this.btnTranslate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTranslate.ForeColor = System.Drawing.Color.White;
            this.btnTranslate.Location = new System.Drawing.Point(411, 296);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(129, 47);
            this.btnTranslate.TabIndex = 0;
            this.btnTranslate.Text = "Translate";
            this.btnTranslate.UseVisualStyleBackColor = false;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(65)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.offlineTranslate);
            this.panel1.Controls.Add(this.OfflineDetect);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.txtSrcLang);
            this.panel1.Controls.Add(this.btnDetectSrc);
            this.panel1.Controls.Add(this.richTextSrc);
            this.panel1.Controls.Add(this.btnTranslate);
            this.panel1.Location = new System.Drawing.Point(13, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 364);
            this.panel1.TabIndex = 1;
            // 
            // offlineTranslate
            // 
            this.offlineTranslate.BackColor = System.Drawing.Color.DarkViolet;
            this.offlineTranslate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offlineTranslate.ForeColor = System.Drawing.Color.White;
            this.offlineTranslate.Location = new System.Drawing.Point(411, 296);
            this.offlineTranslate.Name = "offlineTranslate";
            this.offlineTranslate.Size = new System.Drawing.Size(129, 47);
            this.offlineTranslate.TabIndex = 10;
            this.offlineTranslate.Text = "Translate";
            this.offlineTranslate.UseVisualStyleBackColor = false;
            this.offlineTranslate.Visible = false;
            this.offlineTranslate.Click += new System.EventHandler(this.offlineTranslate_Click);
            // 
            // OfflineDetect
            // 
            this.OfflineDetect.BackColor = System.Drawing.Color.Black;
            this.OfflineDetect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OfflineDetect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OfflineDetect.ForeColor = System.Drawing.Color.White;
            this.OfflineDetect.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OfflineDetect.Location = new System.Drawing.Point(9, 269);
            this.OfflineDetect.Name = "OfflineDetect";
            this.OfflineDetect.Size = new System.Drawing.Size(183, 41);
            this.OfflineDetect.TabIndex = 9;
            this.OfflineDetect.Text = "Detect Language";
            this.OfflineDetect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OfflineDetect.UseVisualStyleBackColor = false;
            this.OfflineDetect.Visible = false;
            this.OfflineDetect.Click += new System.EventHandler(this.OfflineDetect_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Maroon;
            this.btnClear.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(9, 225);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(121, 38);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear fields";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Visible = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(194, 266);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(269, 231);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(281, 32);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "Please Select Language";
            // 
            // txtSrcLang
            // 
            this.txtSrcLang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSrcLang.Location = new System.Drawing.Point(9, 320);
            this.txtSrcLang.Multiline = true;
            this.txtSrcLang.Name = "txtSrcLang";
            this.txtSrcLang.Size = new System.Drawing.Size(245, 33);
            this.txtSrcLang.TabIndex = 3;
            this.txtSrcLang.Visible = false;
            // 
            // btnDetectSrc
            // 
            this.btnDetectSrc.BackColor = System.Drawing.Color.Black;
            this.btnDetectSrc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetectSrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetectSrc.ForeColor = System.Drawing.Color.White;
            this.btnDetectSrc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDetectSrc.Location = new System.Drawing.Point(9, 269);
            this.btnDetectSrc.Name = "btnDetectSrc";
            this.btnDetectSrc.Size = new System.Drawing.Size(183, 41);
            this.btnDetectSrc.TabIndex = 2;
            this.btnDetectSrc.Text = "Detect Language";
            this.btnDetectSrc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetectSrc.UseVisualStyleBackColor = false;
            this.btnDetectSrc.Click += new System.EventHandler(this.btnDetectSrc_Click);
            // 
            // richTextSrc
            // 
            this.richTextSrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextSrc.Location = new System.Drawing.Point(9, 9);
            this.richTextSrc.Name = "richTextSrc";
            this.richTextSrc.Size = new System.Drawing.Size(541, 208);
            this.richTextSrc.TabIndex = 1;
            this.richTextSrc.Text = "";
            this.richTextSrc.TextChanged += new System.EventHandler(this.richTextSrc_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(577, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(444, 258);
            this.panel2.TabIndex = 2;
            // 
            // destinationLangPane
            // 
            this.destinationLangPane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(65)))), ((int)(((byte)(79)))));
            this.destinationLangPane.Controls.Add(this.DestRichT);
            this.destinationLangPane.Location = new System.Drawing.Point(577, 279);
            this.destinationLangPane.Name = "destinationLangPane";
            this.destinationLangPane.Size = new System.Drawing.Size(444, 253);
            this.destinationLangPane.TabIndex = 3;
            this.destinationLangPane.Visible = false;
            // 
            // DestRichT
            // 
            this.DestRichT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestRichT.Location = new System.Drawing.Point(4, 8);
            this.DestRichT.Name = "DestRichT";
            this.DestRichT.Size = new System.Drawing.Size(434, 237);
            this.DestRichT.TabIndex = 2;
            this.DestRichT.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(568, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "English, Hausa and Igbo Language Dictionary";
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnNew.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(52, 62);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(193, 34);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "Add New Words";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnOffline
            // 
            this.btnOffline.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnOffline.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOffline.ForeColor = System.Drawing.Color.White;
            this.btnOffline.Location = new System.Drawing.Point(313, 62);
            this.btnOffline.Name = "btnOffline";
            this.btnOffline.Size = new System.Drawing.Size(193, 34);
            this.btnOffline.TabIndex = 6;
            this.btnOffline.Text = "Offline Dictionary";
            this.btnOffline.UseVisualStyleBackColor = false;
            this.btnOffline.Click += new System.EventHandler(this.btnOffline_Click);
            // 
            // addwordPanel
            // 
            this.addwordPanel.Controls.Add(this.offlineClear);
            this.addwordPanel.Controls.Add(this.richHausa);
            this.addwordPanel.Controls.Add(this.richIgbo);
            this.addwordPanel.Controls.Add(this.richEnglish);
            this.addwordPanel.Controls.Add(this.label4);
            this.addwordPanel.Controls.Add(this.label3);
            this.addwordPanel.Controls.Add(this.label2);
            this.addwordPanel.Location = new System.Drawing.Point(12, 112);
            this.addwordPanel.Name = "addwordPanel";
            this.addwordPanel.Size = new System.Drawing.Size(558, 364);
            this.addwordPanel.TabIndex = 7;
            this.addwordPanel.Visible = false;
            // 
            // offlineClear
            // 
            this.offlineClear.BackColor = System.Drawing.Color.Maroon;
            this.offlineClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offlineClear.ForeColor = System.Drawing.Color.White;
            this.offlineClear.Location = new System.Drawing.Point(365, 324);
            this.offlineClear.Name = "offlineClear";
            this.offlineClear.Size = new System.Drawing.Size(129, 33);
            this.offlineClear.TabIndex = 9;
            this.offlineClear.Text = "Clear Fields";
            this.offlineClear.UseVisualStyleBackColor = false;
            this.offlineClear.Visible = false;
            // 
            // richHausa
            // 
            this.richHausa.Location = new System.Drawing.Point(53, 246);
            this.richHausa.Name = "richHausa";
            this.richHausa.Size = new System.Drawing.Size(447, 72);
            this.richHausa.TabIndex = 1;
            this.richHausa.Text = "";
            // 
            // richIgbo
            // 
            this.richIgbo.Location = new System.Drawing.Point(53, 140);
            this.richIgbo.Name = "richIgbo";
            this.richIgbo.Size = new System.Drawing.Size(447, 72);
            this.richIgbo.TabIndex = 1;
            this.richIgbo.Text = "";
            // 
            // richEnglish
            // 
            this.richEnglish.Location = new System.Drawing.Point(53, 35);
            this.richEnglish.Name = "richEnglish";
            this.richEnglish.Size = new System.Drawing.Size(447, 72);
            this.richEnglish.TabIndex = 1;
            this.richEnglish.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hausa words(Meaning)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Igbo words(Meaning)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "English words(Meaning)";
            // 
            // btnwordAdd
            // 
            this.btnwordAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.btnwordAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnwordAdd.ForeColor = System.Drawing.Color.White;
            this.btnwordAdd.Location = new System.Drawing.Point(13, 491);
            this.btnwordAdd.Name = "btnwordAdd";
            this.btnwordAdd.Size = new System.Drawing.Size(141, 41);
            this.btnwordAdd.TabIndex = 8;
            this.btnwordAdd.Text = "Add Words";
            this.btnwordAdd.UseVisualStyleBackColor = false;
            this.btnwordAdd.Visible = false;
            // 
            // btnEnglish
            // 
            this.btnEnglish.BackColor = System.Drawing.Color.Transparent;
            this.btnEnglish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnglish.ForeColor = System.Drawing.Color.White;
            this.btnEnglish.Location = new System.Drawing.Point(218, 488);
            this.btnEnglish.Name = "btnEnglish";
            this.btnEnglish.Size = new System.Drawing.Size(105, 41);
            this.btnEnglish.TabIndex = 9;
            this.btnEnglish.Text = "English";
            this.btnEnglish.UseVisualStyleBackColor = false;
            this.btnEnglish.Visible = false;
            // 
            // btnIgbo
            // 
            this.btnIgbo.BackColor = System.Drawing.Color.Transparent;
            this.btnIgbo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIgbo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgbo.ForeColor = System.Drawing.Color.White;
            this.btnIgbo.Location = new System.Drawing.Point(337, 488);
            this.btnIgbo.Name = "btnIgbo";
            this.btnIgbo.Size = new System.Drawing.Size(105, 41);
            this.btnIgbo.TabIndex = 10;
            this.btnIgbo.Text = "Igbo";
            this.btnIgbo.UseVisualStyleBackColor = false;
            this.btnIgbo.Visible = false;
            // 
            // btnHausa
            // 
            this.btnHausa.BackColor = System.Drawing.Color.Transparent;
            this.btnHausa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHausa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHausa.ForeColor = System.Drawing.Color.White;
            this.btnHausa.Location = new System.Drawing.Point(456, 489);
            this.btnHausa.Name = "btnHausa";
            this.btnHausa.Size = new System.Drawing.Size(105, 41);
            this.btnHausa.TabIndex = 11;
            this.btnHausa.Text = "Hausa";
            this.btnHausa.UseVisualStyleBackColor = false;
            this.btnHausa.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1035, 541);
            this.Controls.Add(this.addwordPanel);
            this.Controls.Add(this.btnHausa);
            this.Controls.Add(this.btnIgbo);
            this.Controls.Add(this.btnEnglish);
            this.Controls.Add(this.btnwordAdd);
            this.Controls.Add(this.btnOffline);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.destinationLangPane);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.destinationLangPane.ResumeLayout(false);
            this.addwordPanel.ResumeLayout(false);
            this.addwordPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtSrcLang;
        private System.Windows.Forms.Button btnDetectSrc;
        private System.Windows.Forms.RichTextBox richTextSrc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel destinationLangPane;
        private System.Windows.Forms.RichTextBox DestRichT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnOffline;
        private System.Windows.Forms.Panel addwordPanel;
        private System.Windows.Forms.RichTextBox richHausa;
        private System.Windows.Forms.RichTextBox richIgbo;
        private System.Windows.Forms.RichTextBox richEnglish;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnwordAdd;
        private System.Windows.Forms.Button btnEnglish;
        private System.Windows.Forms.Button btnIgbo;
        private System.Windows.Forms.Button btnHausa;
        private System.Windows.Forms.Button offlineTranslate;
        private System.Windows.Forms.Button OfflineDetect;
        private System.Windows.Forms.Button offlineClear;
    }
}

