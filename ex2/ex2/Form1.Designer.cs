
namespace ex2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.Имя = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Фамилия = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Возраст = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addbutt = new System.Windows.Forms.Button();
            this.redactbutt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Имя,
            this.Фамилия,
            this.Возраст});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(39, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(273, 91);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.VirtualMode = true;
            this.listView1.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.listView1_RetrieveVirtualItem_1);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Имя
            // 
            this.Имя.Text = "Имя";
            this.Имя.Width = 97;
            // 
            // Фамилия
            // 
            this.Фамилия.Text = "Фамилия";
            this.Фамилия.Width = 102;
            // 
            // Возраст
            // 
            this.Возраст.Text = "Возраст";
            this.Возраст.Width = 122;
            // 
            // addbutt
            // 
            this.addbutt.Location = new System.Drawing.Point(39, 110);
            this.addbutt.Name = "addbutt";
            this.addbutt.Size = new System.Drawing.Size(75, 23);
            this.addbutt.TabIndex = 1;
            this.addbutt.Text = "Добавить";
            this.addbutt.UseVisualStyleBackColor = true;
            this.addbutt.Click += new System.EventHandler(this.addbutt_Click);
            // 
            // redactbutt
            // 
            this.redactbutt.Location = new System.Drawing.Point(244, 110);
            this.redactbutt.Name = "redactbutt";
            this.redactbutt.Size = new System.Drawing.Size(142, 23);
            this.redactbutt.TabIndex = 2;
            this.redactbutt.Text = "редактироват";
            this.redactbutt.UseVisualStyleBackColor = true;
            this.redactbutt.Click += new System.EventHandler(this.redactbutt_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "посмотреть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(39, 151);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(347, 180);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 343);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.redactbutt);
            this.Controls.Add(this.addbutt);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Имя;
        private System.Windows.Forms.ColumnHeader Фамилия;
        private System.Windows.Forms.ColumnHeader Возраст;
        private System.Windows.Forms.Button addbutt;
        private System.Windows.Forms.Button redactbutt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

