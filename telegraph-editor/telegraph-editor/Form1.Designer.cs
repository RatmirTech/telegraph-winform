namespace telegraph_editor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.theDialog = new System.Windows.Forms.OpenFileDialog();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(350, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "Загрузить файлы";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.uploadfilesBtn_click);
            // 
            // theDialog
            // 
            this.theDialog.FileName = "theDialog";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(350, 30);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(250, 139);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 45);
            this.button2.TabIndex = 3;
            this.button2.Text = "Создать главу";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.createChapterBtn_click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 27);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Название Главы";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 63);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(204, 27);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Автор";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 96);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(204, 27);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 247);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(189, 38);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "{\"tag\":\"p\",\"children\":[{\"tag\":\"a\",\"attrs\":{\"href\":\"https:\\/\\/t.me\\/Ontary\",\"targe" +
    "t\":\"_blank\"},\"children\":[\"For Sent\"]}]}";
            this.textBox4.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(12, 303);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(342, 140);
            this.textBox5.TabIndex = 8;
            this.textBox5.Text = "{\"tag\":\"figure\",\"children\":[{\"tag\":\"img\",\"attrs\":{\"src\":\"tech\"}},{\"tag\":\"figcapti" +
    "on\",\"children\":[\"\"]}]}";
            this.textBox5.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 471);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "TelegraphEditor - github RatmirTech";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private OpenFileDialog theDialog;
        private ListView listView1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}