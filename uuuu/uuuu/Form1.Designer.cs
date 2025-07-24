namespace uuuu
{
    partial class 隨機菜單產生器
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.schooltextbox1 = new System.Windows.Forms.TextBox();
            this.schoolreader = new System.Windows.Forms.Button();
            this.schoolwriter = new System.Windows.Forms.Button();
            this.eatschool = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.schooltextbox2 = new System.Windows.Forms.TextBox();
            this.residence = new System.Windows.Forms.Button();
            this.school = new System.Windows.Forms.Button();
            this.fareat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.residenceread = new System.Windows.Forms.Button();
            this.residencewrite = new System.Windows.Forms.Button();
            this.eatresidence = new System.Windows.Forms.Button();
            this.residencetextbox1 = new System.Windows.Forms.TextBox();
            this.residencetextbox2 = new System.Windows.Forms.TextBox();
            this.breakfastradio = new System.Windows.Forms.RadioButton();
            this.LDradio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fareatread = new System.Windows.Forms.Button();
            this.fareatwrite = new System.Windows.Forms.Button();
            this.eatfareat = new System.Windows.Forms.Button();
            this.fareattextbox1 = new System.Windows.Forms.TextBox();
            this.fareattextbox2 = new System.Windows.Forms.TextBox();
            this.residencelabel = new System.Windows.Forms.Label();
            this.schoollabel = new System.Windows.Forms.Label();
            this.fareatlabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // schooltextbox1
            // 
            this.schooltextbox1.Location = new System.Drawing.Point(716, 93);
            this.schooltextbox1.Multiline = true;
            this.schooltextbox1.Name = "schooltextbox1";
            this.schooltextbox1.Size = new System.Drawing.Size(156, 439);
            this.schooltextbox1.TabIndex = 1;
            this.schooltextbox1.Text = "請點選「讀取菜單」";
            this.schooltextbox1.Visible = false;
            this.schooltextbox1.WordWrap = false;
            // 
            // schoolreader
            // 
            this.schoolreader.Location = new System.Drawing.Point(715, 51);
            this.schoolreader.Name = "schoolreader";
            this.schoolreader.Size = new System.Drawing.Size(75, 23);
            this.schoolreader.TabIndex = 2;
            this.schoolreader.Text = "讀取菜單";
            this.schoolreader.UseVisualStyleBackColor = true;
            this.schoolreader.Visible = false;
            this.schoolreader.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // schoolwriter
            // 
            this.schoolwriter.Location = new System.Drawing.Point(797, 51);
            this.schoolwriter.Name = "schoolwriter";
            this.schoolwriter.Size = new System.Drawing.Size(75, 23);
            this.schoolwriter.TabIndex = 3;
            this.schoolwriter.Text = "儲存菜單";
            this.schoolwriter.UseVisualStyleBackColor = true;
            this.schoolwriter.Visible = false;
            this.schoolwriter.Click += new System.EventHandler(this.button2_Click);
            // 
            // eatschool
            // 
            this.eatschool.Location = new System.Drawing.Point(916, 51);
            this.eatschool.Name = "eatschool";
            this.eatschool.Size = new System.Drawing.Size(100, 23);
            this.eatschool.TabIndex = 4;
            this.eatschool.Text = "吃什麼？";
            this.eatschool.UseVisualStyleBackColor = true;
            this.eatschool.Visible = false;
            this.eatschool.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 5;
            // 
            // schooltextbox2
            // 
            this.schooltextbox2.Location = new System.Drawing.Point(916, 93);
            this.schooltextbox2.Multiline = true;
            this.schooltextbox2.Name = "schooltextbox2";
            this.schooltextbox2.ReadOnly = true;
            this.schooltextbox2.Size = new System.Drawing.Size(100, 42);
            this.schooltextbox2.TabIndex = 6;
            this.schooltextbox2.Visible = false;
            this.schooltextbox2.TextChanged += new System.EventHandler(this.schooltextbox2_TextChanged);
            // 
            // residence
            // 
            this.residence.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.residence.Location = new System.Drawing.Point(41, 227);
            this.residence.Name = "residence";
            this.residence.Size = new System.Drawing.Size(80, 60);
            this.residence.TabIndex = 7;
            this.residence.Text = "住宿區";
            this.residence.UseVisualStyleBackColor = true;
            this.residence.Click += new System.EventHandler(this.button4_Click);
            // 
            // school
            // 
            this.school.Location = new System.Drawing.Point(127, 227);
            this.school.Name = "school";
            this.school.Size = new System.Drawing.Size(82, 60);
            this.school.TabIndex = 8;
            this.school.Text = "學校區";
            this.school.UseVisualStyleBackColor = true;
            this.school.Click += new System.EventHandler(this.button5_Click);
            // 
            // fareat
            // 
            this.fareat.Location = new System.Drawing.Point(215, 227);
            this.fareat.Name = "fareat";
            this.fareat.Size = new System.Drawing.Size(82, 61);
            this.fareat.TabIndex = 9;
            this.fareat.Text = "遠食";
            this.fareat.UseVisualStyleBackColor = true;
            this.fareat.Click += new System.EventHandler(this.fareat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(136, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "請選擇";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // residenceread
            // 
            this.residenceread.Location = new System.Drawing.Point(350, 49);
            this.residenceread.Name = "residenceread";
            this.residenceread.Size = new System.Drawing.Size(75, 23);
            this.residenceread.TabIndex = 11;
            this.residenceread.Text = "讀取菜單";
            this.residenceread.UseVisualStyleBackColor = true;
            this.residenceread.Visible = false;
            this.residenceread.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // residencewrite
            // 
            this.residencewrite.Location = new System.Drawing.Point(432, 49);
            this.residencewrite.Name = "residencewrite";
            this.residencewrite.Size = new System.Drawing.Size(75, 23);
            this.residencewrite.TabIndex = 12;
            this.residencewrite.Text = "儲存菜單";
            this.residencewrite.UseVisualStyleBackColor = true;
            this.residencewrite.Visible = false;
            this.residencewrite.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // eatresidence
            // 
            this.eatresidence.Location = new System.Drawing.Point(551, 49);
            this.eatresidence.Name = "eatresidence";
            this.eatresidence.Size = new System.Drawing.Size(100, 23);
            this.eatresidence.TabIndex = 13;
            this.eatresidence.Text = "吃什麼？";
            this.eatresidence.UseVisualStyleBackColor = true;
            this.eatresidence.Visible = false;
            this.eatresidence.Click += new System.EventHandler(this.eatresidence_Click);
            // 
            // residencetextbox1
            // 
            this.residencetextbox1.Location = new System.Drawing.Point(350, 121);
            this.residencetextbox1.Multiline = true;
            this.residencetextbox1.Name = "residencetextbox1";
            this.residencetextbox1.Size = new System.Drawing.Size(156, 410);
            this.residencetextbox1.TabIndex = 14;
            this.residencetextbox1.Text = "請點選「讀取菜單」";
            this.residencetextbox1.Visible = false;
            this.residencetextbox1.TextChanged += new System.EventHandler(this.residencetextbox1_TextChanged);
            // 
            // residencetextbox2
            // 
            this.residencetextbox2.Location = new System.Drawing.Point(551, 93);
            this.residencetextbox2.Multiline = true;
            this.residencetextbox2.Name = "residencetextbox2";
            this.residencetextbox2.ReadOnly = true;
            this.residencetextbox2.Size = new System.Drawing.Size(100, 42);
            this.residencetextbox2.TabIndex = 15;
            this.residencetextbox2.Visible = false;
            this.residencetextbox2.TextChanged += new System.EventHandler(this.residencetextbox2_TextChanged);
            // 
            // breakfastradio
            // 
            this.breakfastradio.AutoSize = true;
            this.breakfastradio.Checked = true;
            this.breakfastradio.Location = new System.Drawing.Point(6, 16);
            this.breakfastradio.Name = "breakfastradio";
            this.breakfastradio.Size = new System.Drawing.Size(47, 16);
            this.breakfastradio.TabIndex = 16;
            this.breakfastradio.TabStop = true;
            this.breakfastradio.Text = "早餐";
            this.breakfastradio.UseVisualStyleBackColor = true;
            this.breakfastradio.CheckedChanged += new System.EventHandler(this.breakfastradio_CheckedChanged);
            // 
            // LDradio
            // 
            this.LDradio.AutoSize = true;
            this.LDradio.Location = new System.Drawing.Point(86, 15);
            this.LDradio.Name = "LDradio";
            this.LDradio.Size = new System.Drawing.Size(47, 16);
            this.LDradio.TabIndex = 17;
            this.LDradio.Text = "午晚";
            this.LDradio.UseVisualStyleBackColor = true;
            this.LDradio.CheckedChanged += new System.EventHandler(this.LDradio_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.breakfastradio);
            this.groupBox1.Controls.Add(this.LDradio);
            this.groupBox1.Location = new System.Drawing.Point(350, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 38);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "分類";
            this.groupBox1.Visible = false;
            // 
            // fareatread
            // 
            this.fareatread.Location = new System.Drawing.Point(1065, 50);
            this.fareatread.Name = "fareatread";
            this.fareatread.Size = new System.Drawing.Size(75, 23);
            this.fareatread.TabIndex = 19;
            this.fareatread.Text = "讀取菜單";
            this.fareatread.UseVisualStyleBackColor = true;
            this.fareatread.Visible = false;
            this.fareatread.Click += new System.EventHandler(this.fareatread_Click);
            // 
            // fareatwrite
            // 
            this.fareatwrite.Location = new System.Drawing.Point(1147, 50);
            this.fareatwrite.Name = "fareatwrite";
            this.fareatwrite.Size = new System.Drawing.Size(75, 23);
            this.fareatwrite.TabIndex = 20;
            this.fareatwrite.Text = "儲存菜單";
            this.fareatwrite.UseVisualStyleBackColor = true;
            this.fareatwrite.Visible = false;
            this.fareatwrite.Click += new System.EventHandler(this.fareatwrite_Click);
            // 
            // eatfareat
            // 
            this.eatfareat.Location = new System.Drawing.Point(1275, 49);
            this.eatfareat.Name = "eatfareat";
            this.eatfareat.Size = new System.Drawing.Size(100, 23);
            this.eatfareat.TabIndex = 21;
            this.eatfareat.Text = "吃什麼？";
            this.eatfareat.UseVisualStyleBackColor = true;
            this.eatfareat.Visible = false;
            this.eatfareat.Click += new System.EventHandler(this.eatfareat_Click);
            // 
            // fareattextbox1
            // 
            this.fareattextbox1.Location = new System.Drawing.Point(1065, 94);
            this.fareattextbox1.Multiline = true;
            this.fareattextbox1.Name = "fareattextbox1";
            this.fareattextbox1.Size = new System.Drawing.Size(156, 438);
            this.fareattextbox1.TabIndex = 22;
            this.fareattextbox1.Text = "請點選「讀取菜單」";
            this.fareattextbox1.Visible = false;
            // 
            // fareattextbox2
            // 
            this.fareattextbox2.Location = new System.Drawing.Point(1275, 95);
            this.fareattextbox2.Multiline = true;
            this.fareattextbox2.Name = "fareattextbox2";
            this.fareattextbox2.ReadOnly = true;
            this.fareattextbox2.Size = new System.Drawing.Size(100, 42);
            this.fareattextbox2.TabIndex = 23;
            this.fareattextbox2.Visible = false;
            // 
            // residencelabel
            // 
            this.residencelabel.AutoSize = true;
            this.residencelabel.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.residencelabel.Location = new System.Drawing.Point(435, 18);
            this.residencelabel.Name = "residencelabel";
            this.residencelabel.Size = new System.Drawing.Size(66, 19);
            this.residencelabel.TabIndex = 24;
            this.residencelabel.Text = "住宿區";
            this.residencelabel.Visible = false;
            // 
            // schoollabel
            // 
            this.schoollabel.AutoSize = true;
            this.schoollabel.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.schoollabel.Location = new System.Drawing.Point(761, 18);
            this.schoollabel.Name = "schoollabel";
            this.schoollabel.Size = new System.Drawing.Size(66, 19);
            this.schoollabel.TabIndex = 25;
            this.schoollabel.Text = "學校區";
            this.schoollabel.Visible = false;
            this.schoollabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // fareatlabel
            // 
            this.fareatlabel.AutoSize = true;
            this.fareatlabel.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fareatlabel.Location = new System.Drawing.Point(1110, 18);
            this.fareatlabel.Name = "fareatlabel";
            this.fareatlabel.Size = new System.Drawing.Size(47, 19);
            this.fareatlabel.TabIndex = 26;
            this.fareatlabel.Text = "遠區";
            this.fareatlabel.Visible = false;
            // 
            // 隨機菜單產生器
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 558);
            this.Controls.Add(this.fareatlabel);
            this.Controls.Add(this.schoollabel);
            this.Controls.Add(this.residencelabel);
            this.Controls.Add(this.fareattextbox2);
            this.Controls.Add(this.fareattextbox1);
            this.Controls.Add(this.eatfareat);
            this.Controls.Add(this.fareatwrite);
            this.Controls.Add(this.fareatread);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.residencetextbox2);
            this.Controls.Add(this.residencetextbox1);
            this.Controls.Add(this.eatresidence);
            this.Controls.Add(this.residencewrite);
            this.Controls.Add(this.residenceread);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fareat);
            this.Controls.Add(this.school);
            this.Controls.Add(this.residence);
            this.Controls.Add(this.schooltextbox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eatschool);
            this.Controls.Add(this.schoolwriter);
            this.Controls.Add(this.schoolreader);
            this.Controls.Add(this.schooltextbox1);
            this.Name = "隨機菜單產生器";
            this.Text = "隨機菜單產生器V4";
            this.Load += new System.EventHandler(this.隨機菜單產生器_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox schooltextbox1;
        private System.Windows.Forms.Button schoolreader;
        private System.Windows.Forms.Button schoolwriter;
        private System.Windows.Forms.Button eatschool;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox schooltextbox2;
        private System.Windows.Forms.Button residence;
        private System.Windows.Forms.Button school;
        private System.Windows.Forms.Button fareat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button residenceread;
        private System.Windows.Forms.Button residencewrite;
        private System.Windows.Forms.Button eatresidence;
        private System.Windows.Forms.TextBox residencetextbox1;
        private System.Windows.Forms.TextBox residencetextbox2;
        private System.Windows.Forms.RadioButton breakfastradio;
        private System.Windows.Forms.RadioButton LDradio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button fareatread;
        private System.Windows.Forms.Button fareatwrite;
        private System.Windows.Forms.Button eatfareat;
        private System.Windows.Forms.TextBox fareattextbox1;
        private System.Windows.Forms.TextBox fareattextbox2;
        private System.Windows.Forms.Label residencelabel;
        private System.Windows.Forms.Label schoollabel;
        private System.Windows.Forms.Label fareatlabel;
    }
}

