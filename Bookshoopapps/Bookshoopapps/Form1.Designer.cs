namespace Bookshoopapps
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.order = new System.Windows.Forms.ComboBox();
            this.saveData = new System.Windows.Forms.Button();
            this.quantity = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.contactNo = new System.Windows.Forms.TextBox();
            this.iNputnAme = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.customarName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(768, 124);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(429, 489);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.order);
            this.groupBox1.Controls.Add(this.saveData);
            this.groupBox1.Controls.Add(this.quantity);
            this.groupBox1.Controls.Add(this.address);
            this.groupBox1.Controls.Add(this.contactNo);
            this.groupBox1.Controls.Add(this.iNputnAme);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.customarName);
            this.groupBox1.Location = new System.Drawing.Point(169, 112);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(500, 501);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Information ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // order
            // 
            this.order.FormattingEnabled = true;
            this.order.Items.AddRange(new object[] {
            "Math",
            "English",
            "Bangla",
            "Art"});
            this.order.Location = new System.Drawing.Point(236, 257);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(235, 34);
            this.order.TabIndex = 12;
            // 
            // saveData
            // 
            this.saveData.Location = new System.Drawing.Point(198, 412);
            this.saveData.Name = "saveData";
            this.saveData.Size = new System.Drawing.Size(112, 46);
            this.saveData.TabIndex = 10;
            this.saveData.Text = "Save";
            this.saveData.UseVisualStyleBackColor = true;
            this.saveData.Click += new System.EventHandler(this.saveData_Click);
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(236, 312);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(235, 33);
            this.quantity.TabIndex = 8;
            this.quantity.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(236, 205);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(235, 33);
            this.address.TabIndex = 7;
            // 
            // contactNo
            // 
            this.contactNo.Location = new System.Drawing.Point(236, 157);
            this.contactNo.Name = "contactNo";
            this.contactNo.Size = new System.Drawing.Size(235, 33);
            this.contactNo.TabIndex = 6;
            // 
            // iNputnAme
            // 
            this.iNputnAme.Location = new System.Drawing.Point(236, 109);
            this.iNputnAme.Name = "iNputnAme";
            this.iNputnAme.Size = new System.Drawing.Size(235, 33);
            this.iNputnAme.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Order";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contact No";
            // 
            // customarName
            // 
            this.customarName.AutoSize = true;
            this.customarName.Location = new System.Drawing.Point(29, 104);
            this.customarName.Name = "customarName";
            this.customarName.Size = new System.Drawing.Size(159, 26);
            this.customarName.TabIndex = 0;
            this.customarName.Text = "Customer Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(605, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = "Book Shop";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Book Shop";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button saveData;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox contactNo;
        private System.Windows.Forms.TextBox iNputnAme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label customarName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox order;
    }
}

