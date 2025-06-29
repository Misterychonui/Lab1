
namespace Lab1
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
            this.Data = new System.Windows.Forms.Button();
            this.Binary = new System.Windows.Forms.Button();
            this.XML = new System.Windows.Forms.Button();
            this.JSON = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Data
            // 
            this.Data.Location = new System.Drawing.Point(25, 9);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(75, 23);
            this.Data.TabIndex = 0;
            this.Data.Text = "Show data";
            this.Data.UseVisualStyleBackColor = true;
            this.Data.Click += new System.EventHandler(this.Data_Click);
            // 
            // Binary
            // 
            this.Binary.Location = new System.Drawing.Point(116, 9);
            this.Binary.Name = "Binary";
            this.Binary.Size = new System.Drawing.Size(75, 23);
            this.Binary.TabIndex = 1;
            this.Binary.Text = "Binary";
            this.Binary.UseVisualStyleBackColor = true;
            this.Binary.Click += new System.EventHandler(this.Binary_Click);
            // 
            // XML
            // 
            this.XML.Location = new System.Drawing.Point(212, 9);
            this.XML.Name = "XML";
            this.XML.Size = new System.Drawing.Size(75, 23);
            this.XML.TabIndex = 2;
            this.XML.Text = "XML";
            this.XML.UseVisualStyleBackColor = true;
            this.XML.Click += new System.EventHandler(this.XML_Click);
            // 
            // JSON
            // 
            this.JSON.Location = new System.Drawing.Point(312, 9);
            this.JSON.Name = "JSON";
            this.JSON.Size = new System.Drawing.Size(75, 23);
            this.JSON.TabIndex = 3;
            this.JSON.Text = "JSON";
            this.JSON.UseVisualStyleBackColor = true;
            this.JSON.Click += new System.EventHandler(this.JSON_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(25, 113);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(362, 82);
            this.listBox1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(436, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 68);
            this.button1.TabIndex = 6;
            this.button1.Text = "Deserelization Binary";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(436, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 68);
            this.button2.TabIndex = 7;
            this.button2.Text = "Deserelization XML";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(436, 172);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 68);
            this.button3.TabIndex = 8;
            this.button3.Text = "Deserelization JSON";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.JSON);
            this.Controls.Add(this.XML);
            this.Controls.Add(this.Binary);
            this.Controls.Add(this.Data);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Data;
        private System.Windows.Forms.Button Binary;
        private System.Windows.Forms.Button XML;
        private System.Windows.Forms.Button JSON;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

