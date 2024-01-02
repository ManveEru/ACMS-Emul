
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMidleZone = new System.Windows.Forms.Label();
            this.lblCurLocation = new System.Windows.Forms.Label();
            this.btnGoOut = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.cmbLocations = new System.Windows.Forms.ComboBox();
            this.cmbDoors = new System.Windows.Forms.ComboBox();
            this.btnGoIn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbEmployees
            // 
            this.lbEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbEmployees.FormattingEnabled = true;
            this.lbEmployees.ItemHeight = 25;
            this.lbEmployees.Location = new System.Drawing.Point(3, 72);
            this.lbEmployees.Name = "lbEmployees";
            this.lbEmployees.Size = new System.Drawing.Size(365, 429);
            this.lbEmployees.TabIndex = 0;
            this.lbEmployees.SelectedIndexChanged += new System.EventHandler(this.lbEmployees_SelectedIndexChanged);
            // 
            // tbEmployees
            // 
            this.tbEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEmployees.Location = new System.Drawing.Point(3, 28);
            this.tbEmployees.Name = "tbEmployees";
            this.tbEmployees.Size = new System.Drawing.Size(365, 30);
            this.tbEmployees.TabIndex = 1;
            this.tbEmployees.TextChanged += new System.EventHandler(this.TbEmployees_TextChanged);
            // 
            // lblEmployees
            // 
            this.lblEmployees.AutoSize = true;
            this.lblEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEmployees.Location = new System.Drawing.Point(3, 0);
            this.lblEmployees.Name = "lblEmployees";
            this.lblEmployees.Size = new System.Drawing.Size(201, 25);
            this.lblEmployees.TabIndex = 2;
            this.lblEmployees.Text = "Список сотрудников";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblEmployees);
            this.flowLayoutPanel1.Controls.Add(this.tbEmployees);
            this.flowLayoutPanel1.Controls.Add(this.lbEmployees);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(37, 32);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(370, 517);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.lblMidleZone);
            this.flowLayoutPanel2.Controls.Add(this.lblCurLocation);
            this.flowLayoutPanel2.Controls.Add(this.btnGoOut);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(461, 32);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(344, 517);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // lblMidleZone
            // 
            this.lblMidleZone.AutoSize = true;
            this.lblMidleZone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMidleZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMidleZone.Location = new System.Drawing.Point(4, 0);
            this.lblMidleZone.Name = "lblMidleZone";
            this.lblMidleZone.Size = new System.Drawing.Size(338, 63);
            this.lblMidleZone.TabIndex = 0;
            this.lblMidleZone.Text = "Текущее местоположение сотрудника";
            // 
            // lblCurLocation
            // 
            this.lblCurLocation.AutoSize = true;
            this.lblCurLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCurLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCurLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurLocation.Location = new System.Drawing.Point(3, 100);
            this.lblCurLocation.Margin = new System.Windows.Forms.Padding(3, 50, 3, 50);
            this.lblCurLocation.Name = "lblCurLocation";
            this.lblCurLocation.Size = new System.Drawing.Size(270, 27);
            this.lblCurLocation.TabIndex = 1;
            this.lblCurLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGoOut
            // 
            this.btnGoOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGoOut.Enabled = false;
            this.btnGoOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGoOut.Location = new System.Drawing.Point(4, 225);
            this.btnGoOut.Name = "btnGoOut";
            this.btnGoOut.Size = new System.Drawing.Size(338, 174);
            this.btnGoOut.TabIndex = 2;
            this.btnGoOut.Text = "Выйти";
            this.btnGoOut.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.cmbLocations);
            this.flowLayoutPanel3.Controls.Add(this.cmbDoors);
            this.flowLayoutPanel3.Controls.Add(this.btnGoIn);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(828, 32);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(304, 517);
            this.flowLayoutPanel3.TabIndex = 5;
            // 
            // cmbLocations
            // 
            this.cmbLocations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbLocations.FormattingEnabled = true;
            this.cmbLocations.Location = new System.Drawing.Point(3, 3);
            this.cmbLocations.Name = "cmbLocations";
            this.cmbLocations.Size = new System.Drawing.Size(298, 33);
            this.cmbLocations.TabIndex = 0;
            this.cmbLocations.SelectedIndexChanged += new System.EventHandler(this.cmbLocations_SelectedIndexChanged);
            // 
            // cmbDoors
            // 
            this.cmbDoors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbDoors.FormattingEnabled = true;
            this.cmbDoors.Location = new System.Drawing.Point(3, 42);
            this.cmbDoors.Name = "cmbDoors";
            this.cmbDoors.Size = new System.Drawing.Size(301, 33);
            this.cmbDoors.TabIndex = 1;
            // 
            // btnGoIn
            // 
            this.btnGoIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGoIn.Location = new System.Drawing.Point(3, 139);
            this.btnGoIn.Margin = new System.Windows.Forms.Padding(3, 70, 3, 3);
            this.btnGoIn.Name = "btnGoIn";
            this.btnGoIn.Size = new System.Drawing.Size(300, 117);
            this.btnGoIn.TabIndex = 2;
            this.btnGoIn.Text = "Войти";
            this.btnGoIn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 569);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbEmployees;
        private System.Windows.Forms.TextBox tbEmployees;
        private System.Windows.Forms.Label lblEmployees;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label lblMidleZone;
        private System.Windows.Forms.Label lblCurLocation;
        private System.Windows.Forms.Button btnGoOut;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.ComboBox cmbLocations;
        private System.Windows.Forms.ComboBox cmbDoors;
        private System.Windows.Forms.Button btnGoIn;
    }
}

