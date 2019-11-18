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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.destinationLangPane.SuspendLayout();
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
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.txtSrcLang);
            this.panel1.Controls.Add(this.btnDetectSrc);
            this.panel1.Controls.Add(this.richTextSrc);
            this.panel1.Controls.Add(this.btnTranslate);
            this.panel1.Location = new System.Drawing.Point(13, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 364);
            this.panel1.TabIndex = 1;
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
            this.label1.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(49, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 114);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hausa and Igbo Language\r\n           Translator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1035, 541);
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
    }
}

