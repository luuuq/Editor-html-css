namespace EditorHtml
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rtb1 = new System.Windows.Forms.RichTextBox();
            this.rtb2 = new System.Windows.Forms.RichTextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.lbl_html = new System.Windows.Forms.Label();
            this.lbl_css = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.save_html_btn = new System.Windows.Forms.Button();
            this.save_css_btn = new System.Windows.Forms.Button();
            this.load_html_btn = new System.Windows.Forms.Button();
            this.Load_css_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtb1
            // 
            this.rtb1.Location = new System.Drawing.Point(13, 30);
            this.rtb1.Name = "rtb1";
            this.rtb1.Size = new System.Drawing.Size(284, 183);
            this.rtb1.TabIndex = 0;
            this.rtb1.Text = "";
            this.rtb1.TextChanged += new System.EventHandler(this.rtb1_TextChanged);
            this.rtb1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.rtb1_KeyUp_1);
            // 
            // rtb2
            // 
            this.rtb2.Location = new System.Drawing.Point(12, 232);
            this.rtb2.Name = "rtb2";
            this.rtb2.Size = new System.Drawing.Size(284, 190);
            this.rtb2.TabIndex = 1;
            this.rtb2.Text = "";
            this.rtb2.TextChanged += new System.EventHandler(this.rtb2_TextChanged);
            this.rtb2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.rtb2_KeyUp);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(317, 30);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(302, 430);
            this.webBrowser1.TabIndex = 2;
            // 
            // lbl_html
            // 
            this.lbl_html.AutoSize = true;
            this.lbl_html.BackColor = System.Drawing.Color.Transparent;
            this.lbl_html.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_html.Location = new System.Drawing.Point(12, 9);
            this.lbl_html.Name = "lbl_html";
            this.lbl_html.Size = new System.Drawing.Size(37, 13);
            this.lbl_html.TabIndex = 3;
            this.lbl_html.Text = "HTML";
            // 
            // lbl_css
            // 
            this.lbl_css.AutoSize = true;
            this.lbl_css.BackColor = System.Drawing.Color.Transparent;
            this.lbl_css.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_css.Location = new System.Drawing.Point(12, 216);
            this.lbl_css.Name = "lbl_css";
            this.lbl_css.Size = new System.Drawing.Size(28, 13);
            this.lbl_css.TabIndex = 4;
            this.lbl_css.Text = "CSS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(314, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "WebBrowser";
            // 
            // save_html_btn
            // 
            this.save_html_btn.Location = new System.Drawing.Point(13, 466);
            this.save_html_btn.Name = "save_html_btn";
            this.save_html_btn.Size = new System.Drawing.Size(111, 31);
            this.save_html_btn.TabIndex = 6;
            this.save_html_btn.Text = "Save Html";
            this.save_html_btn.UseVisualStyleBackColor = true;
            this.save_html_btn.Click += new System.EventHandler(this.save_html_btn_Click);
            // 
            // save_css_btn
            // 
            this.save_css_btn.Location = new System.Drawing.Point(181, 428);
            this.save_css_btn.Name = "save_css_btn";
            this.save_css_btn.Size = new System.Drawing.Size(115, 32);
            this.save_css_btn.TabIndex = 7;
            this.save_css_btn.Text = "Save Css";
            this.save_css_btn.UseVisualStyleBackColor = true;
            this.save_css_btn.Click += new System.EventHandler(this.save_css_btn_Click);
            // 
            // load_html_btn
            // 
            this.load_html_btn.Location = new System.Drawing.Point(12, 428);
            this.load_html_btn.Name = "load_html_btn";
            this.load_html_btn.Size = new System.Drawing.Size(112, 32);
            this.load_html_btn.TabIndex = 8;
            this.load_html_btn.Text = "Load Html";
            this.load_html_btn.UseVisualStyleBackColor = true;
            this.load_html_btn.Click += new System.EventHandler(this.load_html_btn_Click);
            // 
            // Load_css_btn
            // 
            this.Load_css_btn.Location = new System.Drawing.Point(181, 466);
            this.Load_css_btn.Name = "Load_css_btn";
            this.Load_css_btn.Size = new System.Drawing.Size(116, 31);
            this.Load_css_btn.TabIndex = 9;
            this.Load_css_btn.Text = "Load Css";
            this.Load_css_btn.UseVisualStyleBackColor = true;
            this.Load_css_btn.Click += new System.EventHandler(this.Load_css_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(413, 467);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(107, 30);
            this.exit_btn.TabIndex = 10;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(631, 501);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.Load_css_btn);
            this.Controls.Add(this.load_html_btn);
            this.Controls.Add(this.save_css_btn);
            this.Controls.Add(this.save_html_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_css);
            this.Controls.Add(this.lbl_html);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.rtb2);
            this.Controls.Add(this.rtb1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb1;
        private System.Windows.Forms.RichTextBox rtb2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label lbl_html;
        private System.Windows.Forms.Label lbl_css;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button save_html_btn;
        private System.Windows.Forms.Button save_css_btn;
        private System.Windows.Forms.Button load_html_btn;
        private System.Windows.Forms.Button Load_css_btn;
        private System.Windows.Forms.Button exit_btn;
    }
}

