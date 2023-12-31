
namespace ACMSE
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
            this.lbEmployees = new System.Windows.Forms.ListBox();
            this.tbEmployees = new System.Windows.Forms.TextBox();
            this.lblEmployees = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbEmployees
            // 
            this.lbEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbEmployees.FormattingEnabled = true;
            this.lbEmployees.ItemHeight = 25;
            this.lbEmployees.Location = new System.Drawing.Point(26, 109);
            this.lbEmployees.Name = "lbEmployees";
            this.lbEmployees.Size = new System.Drawing.Size(339, 379);
            this.lbEmployees.TabIndex = 0;
            // 
            // tbEmployees
            // 
            this.tbEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEmployees.Location = new System.Drawing.Point(26, 65);
            this.tbEmployees.Name = "tbEmployees";
            this.tbEmployees.Size = new System.Drawing.Size(339, 30);
            this.tbEmployees.TabIndex = 1;
            this.tbEmployees.TextChanged += new System.EventHandler(this.TbEmployees_TextChanged);
            // 
            // lblEmployees
            // 
            this.lblEmployees.AutoSize = true;
            this.lblEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEmployees.Location = new System.Drawing.Point(21, 31);
            this.lblEmployees.Name = "lblEmployees";
            this.lblEmployees.Size = new System.Drawing.Size(201, 25);
            this.lblEmployees.TabIndex = 2;
            this.lblEmployees.Text = "Список сотрудников";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 517);
            this.Controls.Add(this.lblEmployees);
            this.Controls.Add(this.tbEmployees);
            this.Controls.Add(this.lbEmployees);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbEmployees;
        private System.Windows.Forms.TextBox tbEmployees;
        private System.Windows.Forms.Label lblEmployees;
    }
}

