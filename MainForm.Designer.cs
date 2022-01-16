
namespace LabaOBD
{
    partial class MainForm
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
            this.panelCarRental = new System.Windows.Forms.Panel();
            this.buttonSaveRental = new System.Windows.Forms.Button();
            this.comboBoxActionRental = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxModelRental = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelThisOutRental = new System.Windows.Forms.Label();
            this.dataGridViewRental = new System.Windows.Forms.DataGridView();
            this.panelCarRepair = new System.Windows.Forms.Panel();
            this.dataGridViewSto = new System.Windows.Forms.DataGridView();
            this.buttonSaveSto = new System.Windows.Forms.Button();
            this.comboBoxActionSto = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxModelSto = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelThisOutSTO = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonTest = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panelCarRental.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRental)).BeginInit();
            this.panelCarRepair.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSto)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCarRental
            // 
            this.panelCarRental.Controls.Add(this.buttonSaveRental);
            this.panelCarRental.Controls.Add(this.comboBoxActionRental);
            this.panelCarRental.Controls.Add(this.panel3);
            this.panelCarRental.Controls.Add(this.label3);
            this.panelCarRental.Controls.Add(this.labelThisOutRental);
            this.panelCarRental.Controls.Add(this.dataGridViewRental);
            this.panelCarRental.Location = new System.Drawing.Point(12, 133);
            this.panelCarRental.Name = "panelCarRental";
            this.panelCarRental.Size = new System.Drawing.Size(475, 505);
            this.panelCarRental.TabIndex = 0;
            // 
            // buttonSaveRental
            // 
            this.buttonSaveRental.Location = new System.Drawing.Point(136, 469);
            this.buttonSaveRental.Name = "buttonSaveRental";
            this.buttonSaveRental.Size = new System.Drawing.Size(336, 23);
            this.buttonSaveRental.TabIndex = 5;
            this.buttonSaveRental.Text = "Применить";
            this.buttonSaveRental.UseVisualStyleBackColor = true;
            this.buttonSaveRental.Click += new System.EventHandler(this.buttonSaveRental_Click);
            // 
            // comboBoxActionRental
            // 
            this.comboBoxActionRental.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxActionRental.FormattingEnabled = true;
            this.comboBoxActionRental.Items.AddRange(new object[] {
            "добавить",
            "изменить",
            "удалить"});
            this.comboBoxActionRental.Location = new System.Drawing.Point(6, 469);
            this.comboBoxActionRental.Name = "comboBoxActionRental";
            this.comboBoxActionRental.Size = new System.Drawing.Size(121, 21);
            this.comboBoxActionRental.TabIndex = 10;
            this.comboBoxActionRental.SelectedIndexChanged += new System.EventHandler(this.comboBoxActionRental_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.comboBox2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.comboBoxModelRental);
            this.panel3.Location = new System.Drawing.Point(6, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(466, 108);
            this.panel3.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Отчёты";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(3, 65);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Модель";
            // 
            // comboBoxModelRental
            // 
            this.comboBoxModelRental.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModelRental.FormattingEnabled = true;
            this.comboBoxModelRental.Location = new System.Drawing.Point(3, 20);
            this.comboBoxModelRental.Name = "comboBoxModelRental";
            this.comboBoxModelRental.Size = new System.Drawing.Size(121, 21);
            this.comboBoxModelRental.TabIndex = 0;
            this.comboBoxModelRental.SelectedIndexChanged += new System.EventHandler(this.comboBoxModelRental_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Аренда автомобилей";
            // 
            // labelThisOutRental
            // 
            this.labelThisOutRental.AutoSize = true;
            this.labelThisOutRental.Location = new System.Drawing.Point(216, 146);
            this.labelThisOutRental.Name = "labelThisOutRental";
            this.labelThisOutRental.Size = new System.Drawing.Size(35, 13);
            this.labelThisOutRental.TabIndex = 4;
            this.labelThisOutRental.Text = "label1";
            this.labelThisOutRental.Click += new System.EventHandler(this.labelThisOutRental_Click);
            // 
            // dataGridViewRental
            // 
            this.dataGridViewRental.AllowUserToAddRows = false;
            this.dataGridViewRental.AllowUserToDeleteRows = false;
            this.dataGridViewRental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRental.Location = new System.Drawing.Point(3, 162);
            this.dataGridViewRental.MultiSelect = false;
            this.dataGridViewRental.Name = "dataGridViewRental";
            this.dataGridViewRental.ReadOnly = true;
            this.dataGridViewRental.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRental.Size = new System.Drawing.Size(469, 301);
            this.dataGridViewRental.TabIndex = 0;
            // 
            // panelCarRepair
            // 
            this.panelCarRepair.Controls.Add(this.dataGridViewSto);
            this.panelCarRepair.Controls.Add(this.buttonSaveSto);
            this.panelCarRepair.Controls.Add(this.comboBoxActionSto);
            this.panelCarRepair.Controls.Add(this.panel1);
            this.panelCarRepair.Controls.Add(this.label4);
            this.panelCarRepair.Controls.Add(this.labelThisOutSTO);
            this.panelCarRepair.Location = new System.Drawing.Point(497, 133);
            this.panelCarRepair.Name = "panelCarRepair";
            this.panelCarRepair.Size = new System.Drawing.Size(475, 505);
            this.panelCarRepair.TabIndex = 1;
            // 
            // dataGridViewSto
            // 
            this.dataGridViewSto.AllowUserToAddRows = false;
            this.dataGridViewSto.AllowUserToDeleteRows = false;
            this.dataGridViewSto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSto.Location = new System.Drawing.Point(6, 162);
            this.dataGridViewSto.MultiSelect = false;
            this.dataGridViewSto.Name = "dataGridViewSto";
            this.dataGridViewSto.ReadOnly = true;
            this.dataGridViewSto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSto.Size = new System.Drawing.Size(469, 304);
            this.dataGridViewSto.TabIndex = 11;
            // 
            // buttonSaveSto
            // 
            this.buttonSaveSto.Location = new System.Drawing.Point(136, 469);
            this.buttonSaveSto.Name = "buttonSaveSto";
            this.buttonSaveSto.Size = new System.Drawing.Size(336, 23);
            this.buttonSaveSto.TabIndex = 11;
            this.buttonSaveSto.Text = "Применить";
            this.buttonSaveSto.UseVisualStyleBackColor = true;
            this.buttonSaveSto.Click += new System.EventHandler(this.buttonSaveSto_Click);
            // 
            // comboBoxActionSto
            // 
            this.comboBoxActionSto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxActionSto.FormattingEnabled = true;
            this.comboBoxActionSto.Items.AddRange(new object[] {
            "добавить",
            "изменить",
            "удалить"});
            this.comboBoxActionSto.Location = new System.Drawing.Point(6, 472);
            this.comboBoxActionSto.Name = "comboBoxActionSto";
            this.comboBoxActionSto.Size = new System.Drawing.Size(121, 21);
            this.comboBoxActionSto.TabIndex = 12;
            this.comboBoxActionSto.SelectedIndexChanged += new System.EventHandler(this.comboBoxActionSto_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.comboBoxModelSto);
            this.panel1.Location = new System.Drawing.Point(9, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 108);
            this.panel1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Отчёты";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Модель";
            // 
            // comboBoxModelSto
            // 
            this.comboBoxModelSto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModelSto.FormattingEnabled = true;
            this.comboBoxModelSto.Location = new System.Drawing.Point(3, 20);
            this.comboBoxModelSto.Name = "comboBoxModelSto";
            this.comboBoxModelSto.Size = new System.Drawing.Size(121, 21);
            this.comboBoxModelSto.TabIndex = 0;
            this.comboBoxModelSto.SelectedIndexChanged += new System.EventHandler(this.comboBoxModelSto_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "СТО";
            // 
            // labelThisOutSTO
            // 
            this.labelThisOutSTO.AutoSize = true;
            this.labelThisOutSTO.Location = new System.Drawing.Point(229, 146);
            this.labelThisOutSTO.Name = "labelThisOutSTO";
            this.labelThisOutSTO.Size = new System.Drawing.Size(35, 13);
            this.labelThisOutSTO.TabIndex = 5;
            this.labelThisOutSTO.Text = "label2";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonTest);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(12, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(957, 124);
            this.panel2.TabIndex = 2;
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(497, 22);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(234, 97);
            this.buttonTest.TabIndex = 3;
            this.buttonTest.Text = "Тест";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(257, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(234, 97);
            this.button2.TabIndex = 2;
            this.button2.Text = "Вернуть из ремонта";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 97);
            this.button1.TabIndex = 1;
            this.button1.Text = "Отправить в ремонт";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(455, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Транзитные действия";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 650);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelCarRepair);
            this.Controls.Add(this.panelCarRental);
            this.Name = "MainForm";
            this.Text = "Аренда или ремонт";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelCarRental.ResumeLayout(false);
            this.panelCarRental.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRental)).EndInit();
            this.panelCarRepair.ResumeLayout(false);
            this.panelCarRepair.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCarRental;
        private System.Windows.Forms.Panel panelCarRepair;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelThisOutRental;
        private System.Windows.Forms.DataGridView dataGridViewRental;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelThisOutSTO;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxModelRental;
        private System.Windows.Forms.ComboBox comboBoxActionRental;
        private System.Windows.Forms.Button buttonSaveRental;
        private System.Windows.Forms.Button buttonSaveSto;
        private System.Windows.Forms.ComboBox comboBoxActionSto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxModelSto;
        private System.Windows.Forms.DataGridView dataGridViewSto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

