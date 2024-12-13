namespace Scratchpad
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
            this.MainDataGridView = new System.Windows.Forms.DataGridView();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Update_Button = new System.Windows.Forms.Button();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MainTextBox = new System.Windows.Forms.TextBox();
            this.MainNumber_TextBox = new System.Windows.Forms.TextBox();
            this.MaindateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MainDataGridView
            // 
            this.MainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainDataGridView.Location = new System.Drawing.Point(12, 85);
            this.MainDataGridView.Name = "MainDataGridView";
            this.MainDataGridView.Size = new System.Drawing.Size(776, 136);
            this.MainDataGridView.TabIndex = 0;
            this.MainDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainDataGridView_CellContentClick);
            this.MainDataGridView.SelectionChanged += new System.EventHandler(this.MainDataGridView_SelectionChanged);
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(502, 256);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(161, 44);
            this.Add_Button.TabIndex = 1;
            this.Add_Button.Text = "Add";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Update_Button
            // 
            this.Update_Button.Location = new System.Drawing.Point(502, 314);
            this.Update_Button.Name = "Update_Button";
            this.Update_Button.Size = new System.Drawing.Size(161, 44);
            this.Update_Button.TabIndex = 2;
            this.Update_Button.Text = "Update";
            this.Update_Button.UseVisualStyleBackColor = true;
            this.Update_Button.Click += new System.EventHandler(this.UpdateTable_Button_Click);
            // 
            // Delete_Button
            // 
            this.Delete_Button.Location = new System.Drawing.Point(502, 373);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(161, 44);
            this.Delete_Button.TabIndex = 3;
            this.Delete_Button.Text = "Delete";
            this.Delete_Button.UseVisualStyleBackColor = true;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(44, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(44, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(44, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Number";
            // 
            // MainTextBox
            // 
            this.MainTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainTextBox.Location = new System.Drawing.Point(123, 314);
            this.MainTextBox.Name = "MainTextBox";
            this.MainTextBox.Size = new System.Drawing.Size(198, 24);
            this.MainTextBox.TabIndex = 4;
            this.MainTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.MainTextBox_Validating);
            // 
            // MainNumber_TextBox
            // 
            this.MainNumber_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainNumber_TextBox.Location = new System.Drawing.Point(123, 355);
            this.MainNumber_TextBox.Name = "MainNumber_TextBox";
            this.MainNumber_TextBox.Size = new System.Drawing.Size(198, 24);
            this.MainNumber_TextBox.TabIndex = 4;
            this.MainNumber_TextBox.Validating += new System.ComponentModel.CancelEventHandler(this.MainNumber_TextBox_Validating);
            // 
            // MaindateTimePicker
            // 
            this.MaindateTimePicker.Location = new System.Drawing.Point(123, 268);
            this.MaindateTimePicker.Name = "MaindateTimePicker";
            this.MaindateTimePicker.Size = new System.Drawing.Size(198, 20);
            this.MaindateTimePicker.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 201);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MaindateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainNumber_TextBox);
            this.Controls.Add(this.MainTextBox);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.Update_Button);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.MainDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Notes";
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MainDataGridView;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Button Update_Button;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MainTextBox;
        private System.Windows.Forms.TextBox MainNumber_TextBox;
        private System.Windows.Forms.DateTimePicker MaindateTimePicker;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

