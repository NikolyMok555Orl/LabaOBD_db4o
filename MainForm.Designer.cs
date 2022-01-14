
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
            this.buttonTest = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxModelRental = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelThisOutRental = new System.Windows.Forms.Label();
            this.dataGridViewRental = new System.Windows.Forms.DataGridView();
            this.panelCarRepair = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.labelThisOutSTO = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panelCarRental.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRental)).BeginInit();
            this.panelCarRepair.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            this.panelCarRental.Location = new System.Drawing.Point(12, 12);
            this.panelCarRental.Name = "panelCarRental";
            this.panelCarRental.Size = new System.Drawing.Size(475, 587);
            this.panelCarRental.TabIndex = 0;
            // 
            // buttonSaveRental
            // 
            this.buttonSaveRental.Location = new System.Drawing.Point(136, 551);
            this.buttonSaveRental.Name = "buttonSaveRental";
            this.buttonSaveRental.Size = new System.Drawing.Size(75, 23);
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
            this.comboBoxActionRental.Location = new System.Drawing.Point(9, 553);
            this.comboBoxActionRental.Name = "comboBoxActionRental";
            this.comboBoxActionRental.Size = new System.Drawing.Size(121, 21);
            this.comboBoxActionRental.TabIndex = 10;
            this.comboBoxActionRental.SelectedIndexChanged += new System.EventHandler(this.comboBoxActionRental_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonTest);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.comboBox2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.comboBoxModelRental);
            this.panel3.Location = new System.Drawing.Point(6, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(466, 150);
            this.panel3.TabIndex = 9;
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(320, 110);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(75, 23);
            this.buttonTest.TabIndex = 4;
            this.buttonTest.Text = "button6";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
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
            this.label3.Location = new System.Drawing.Point(165, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Аренда автомобилей";
            // 
            // labelThisOutRental
            // 
            this.labelThisOutRental.AutoSize = true;
            this.labelThisOutRental.Location = new System.Drawing.Point(215, 176);
            this.labelThisOutRental.Name = "labelThisOutRental";
            this.labelThisOutRental.Size = new System.Drawing.Size(35, 13);
            this.labelThisOutRental.TabIndex = 4;
            this.labelThisOutRental.Text = "label1";
            // 
            // dataGridViewRental
            // 
            this.dataGridViewRental.AllowUserToAddRows = false;
            this.dataGridViewRental.AllowUserToDeleteRows = false;
            this.dataGridViewRental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRental.Location = new System.Drawing.Point(3, 195);
            this.dataGridViewRental.Name = "dataGridViewRental";
            this.dataGridViewRental.Size = new System.Drawing.Size(469, 352);
            this.dataGridViewRental.TabIndex = 0;
            // 
            // panelCarRepair
            // 
            this.panelCarRepair.Controls.Add(this.label4);
            this.panelCarRepair.Controls.Add(this.labelThisOutSTO);
            this.panelCarRepair.Controls.Add(this.dataGridView2);
            this.panelCarRepair.Location = new System.Drawing.Point(497, 12);
            this.panelCarRepair.Name = "panelCarRepair";
            this.panelCarRepair.Size = new System.Drawing.Size(475, 587);
            this.panelCarRepair.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "СТО";
            // 
            // labelThisOutSTO
            // 
            this.labelThisOutSTO.AutoSize = true;
            this.labelThisOutSTO.Location = new System.Drawing.Point(229, 176);
            this.labelThisOutSTO.Name = "labelThisOutSTO";
            this.labelThisOutSTO.Size = new System.Drawing.Size(35, 13);
            this.labelThisOutSTO.TabIndex = 5;
            this.labelThisOutSTO.Text = "label2";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 195);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(469, 352);
            this.dataGridView2.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxModelRental;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.ComboBox comboBoxActionRental;
        private System.Windows.Forms.Button buttonSaveRental;
    }
}

