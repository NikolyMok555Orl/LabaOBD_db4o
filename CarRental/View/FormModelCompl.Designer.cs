
namespace LabaOBD.CarRental.View
{
    partial class FormModelCompl
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNameComplete = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCostModel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxEngine = new System.Windows.Forms.ComboBox();
            this.textBoxRentPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAmountSeat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxGearboxTypes = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Location = new System.Drawing.Point(647, 109);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(153, 52);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonBack.Location = new System.Drawing.Point(463, 109);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(178, 52);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название";
            // 
            // textBoxNameComplete
            // 
            this.textBoxNameComplete.Location = new System.Drawing.Point(64, 13);
            this.textBoxNameComplete.Name = "textBoxNameComplete";
            this.textBoxNameComplete.Size = new System.Drawing.Size(100, 20);
            this.textBoxNameComplete.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cost";
            // 
            // textBoxCostModel
            // 
            this.textBoxCostModel.Location = new System.Drawing.Point(379, 12);
            this.textBoxCostModel.Name = "textBoxCostModel";
            this.textBoxCostModel.Size = new System.Drawing.Size(100, 20);
            this.textBoxCostModel.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Двиг";
            // 
            // comboBoxEngine
            // 
            this.comboBoxEngine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEngine.FormattingEnabled = true;
            this.comboBoxEngine.Location = new System.Drawing.Point(211, 11);
            this.comboBoxEngine.Name = "comboBoxEngine";
            this.comboBoxEngine.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEngine.TabIndex = 7;
            // 
            // textBoxRentPrice
            // 
            this.textBoxRentPrice.Location = new System.Drawing.Point(527, 12);
            this.textBoxRentPrice.Name = "textBoxRentPrice";
            this.textBoxRentPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxRentPrice.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(486, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Rent";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Gearbox";
            // 
            // textBoxAmountSeat
            // 
            this.textBoxAmountSeat.Location = new System.Drawing.Point(232, 55);
            this.textBoxAmountSeat.Name = "textBoxAmountSeat";
            this.textBoxAmountSeat.Size = new System.Drawing.Size(100, 20);
            this.textBoxAmountSeat.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(191, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Мест";
            // 
            // comboBoxGearboxTypes
            // 
            this.comboBoxGearboxTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGearboxTypes.FormattingEnabled = true;
            this.comboBoxGearboxTypes.Location = new System.Drawing.Point(64, 55);
            this.comboBoxGearboxTypes.Name = "comboBoxGearboxTypes";
            this.comboBoxGearboxTypes.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGearboxTypes.TabIndex = 14;
            // 
            // FormModelCompl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 162);
            this.Controls.Add(this.comboBoxGearboxTypes);
            this.Controls.Add(this.textBoxAmountSeat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxRentPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxEngine);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCostModel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNameComplete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonSave);
            this.Name = "FormModelCompl";
            this.Text = "Комплектация";
            this.Load += new System.EventHandler(this.FormModelCompl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNameComplete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCostModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxEngine;
        private System.Windows.Forms.TextBox textBoxRentPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxAmountSeat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxGearboxTypes;
    }
}