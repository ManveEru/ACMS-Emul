
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
            this.ContentLayoutLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.ContentLayoutMiddle = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMidleZone = new System.Windows.Forms.Label();
            this.lblCurLocation = new System.Windows.Forms.Label();
            this.btnGoOut = new System.Windows.Forms.Button();
            this.ContentLayoutRight = new System.Windows.Forms.FlowLayoutPanel();
            this.cmbLocations = new System.Windows.Forms.ComboBox();
            this.cmbDoors = new System.Windows.Forms.ComboBox();
            this.btnGoIn = new System.Windows.Forms.Button();
            this.pbLoad = new System.Windows.Forms.ProgressBar();
            this.ContentLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.MainLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.ContentLayoutLeft.SuspendLayout();
            this.ContentLayoutMiddle.SuspendLayout();
            this.ContentLayoutRight.SuspendLayout();
            this.ContentLayout.SuspendLayout();
            this.MainLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbEmployees
            // 
            this.lbEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbEmployees.FormattingEnabled = true;
            this.lbEmployees.ItemHeight = 25;
            this.lbEmployees.Location = new System.Drawing.Point(3, 61);
            this.lbEmployees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbEmployees.Name = "lbEmployees";
            this.lbEmployees.Size = new System.Drawing.Size(336, 404);
            this.lbEmployees.TabIndex = 0;
            this.lbEmployees.SelectedIndexChanged += new System.EventHandler(this.lbEmployees_SelectedIndexChanged);
            // 
            // tbEmployees
            // 
            this.tbEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEmployees.Location = new System.Drawing.Point(3, 27);
            this.tbEmployees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEmployees.Name = "tbEmployees";
            this.tbEmployees.Size = new System.Drawing.Size(336, 30);
            this.tbEmployees.TabIndex = 1;
            this.tbEmployees.TextChanged += new System.EventHandler(this.TbEmployees_TextChanged);
            // 
            // lblEmployees
            // 
            this.lblEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEmployees.Location = new System.Drawing.Point(3, 0);
            this.lblEmployees.Name = "lblEmployees";
            this.lblEmployees.Size = new System.Drawing.Size(336, 25);
            this.lblEmployees.TabIndex = 2;
            this.lblEmployees.Text = "Список сотрудников";
            // 
            // ContentLayoutLeft
            // 
            this.ContentLayoutLeft.Controls.Add(this.lblEmployees);
            this.ContentLayoutLeft.Controls.Add(this.tbEmployees);
            this.ContentLayoutLeft.Controls.Add(this.lbEmployees);
            this.ContentLayoutLeft.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ContentLayoutLeft.Location = new System.Drawing.Point(3, 2);
            this.ContentLayoutLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ContentLayoutLeft.Name = "ContentLayoutLeft";
            this.ContentLayoutLeft.Size = new System.Drawing.Size(340, 491);
            this.ContentLayoutLeft.TabIndex = 3;
            this.ContentLayoutLeft.Visible = false;
            // 
            // ContentLayoutMiddle
            // 
            this.ContentLayoutMiddle.Controls.Add(this.lblMidleZone);
            this.ContentLayoutMiddle.Controls.Add(this.lblCurLocation);
            this.ContentLayoutMiddle.Controls.Add(this.btnGoOut);
            this.ContentLayoutMiddle.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ContentLayoutMiddle.Location = new System.Drawing.Point(349, 2);
            this.ContentLayoutMiddle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ContentLayoutMiddle.Name = "ContentLayoutMiddle";
            this.ContentLayoutMiddle.Size = new System.Drawing.Size(345, 491);
            this.ContentLayoutMiddle.TabIndex = 4;
            this.ContentLayoutMiddle.Visible = false;
            // 
            // lblMidleZone
            // 
            this.lblMidleZone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMidleZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMidleZone.Location = new System.Drawing.Point(3, 0);
            this.lblMidleZone.Name = "lblMidleZone";
            this.lblMidleZone.Size = new System.Drawing.Size(341, 49);
            this.lblMidleZone.TabIndex = 0;
            this.lblMidleZone.Text = "Текущее местоположение сотрудника";
            // 
            // lblCurLocation
            // 
            this.lblCurLocation.AutoSize = true;
            this.lblCurLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCurLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCurLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurLocation.Location = new System.Drawing.Point(3, 61);
            this.lblCurLocation.Margin = new System.Windows.Forms.Padding(3, 12, 3, 74);
            this.lblCurLocation.Name = "lblCurLocation";
            this.lblCurLocation.Size = new System.Drawing.Size(341, 27);
            this.lblCurLocation.TabIndex = 1;
            this.lblCurLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGoOut
            // 
            this.btnGoOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGoOut.Enabled = false;
            this.btnGoOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGoOut.Location = new System.Drawing.Point(3, 164);
            this.btnGoOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGoOut.Name = "btnGoOut";
            this.btnGoOut.Size = new System.Drawing.Size(341, 174);
            this.btnGoOut.TabIndex = 2;
            this.btnGoOut.Text = "Выйти";
            this.btnGoOut.UseVisualStyleBackColor = true;
            this.btnGoOut.Click += new System.EventHandler(this.btnGoOut_Click);
            // 
            // ContentLayoutRight
            // 
            this.ContentLayoutRight.Controls.Add(this.cmbLocations);
            this.ContentLayoutRight.Controls.Add(this.cmbDoors);
            this.ContentLayoutRight.Controls.Add(this.btnGoIn);
            this.ContentLayoutRight.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ContentLayoutRight.Location = new System.Drawing.Point(700, 2);
            this.ContentLayoutRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ContentLayoutRight.Name = "ContentLayoutRight";
            this.ContentLayoutRight.Size = new System.Drawing.Size(300, 491);
            this.ContentLayoutRight.TabIndex = 5;
            this.ContentLayoutRight.Visible = false;
            // 
            // cmbLocations
            // 
            this.cmbLocations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbLocations.FormattingEnabled = true;
            this.cmbLocations.Location = new System.Drawing.Point(3, 2);
            this.cmbLocations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbLocations.Name = "cmbLocations";
            this.cmbLocations.Size = new System.Drawing.Size(297, 33);
            this.cmbLocations.TabIndex = 0;
            this.cmbLocations.SelectedIndexChanged += new System.EventHandler(this.cmbLocations_SelectedIndexChanged);
            // 
            // cmbDoors
            // 
            this.cmbDoors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbDoors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbDoors.FormattingEnabled = true;
            this.cmbDoors.Location = new System.Drawing.Point(3, 39);
            this.cmbDoors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 18);
            this.cmbDoors.Name = "cmbDoors";
            this.cmbDoors.Size = new System.Drawing.Size(297, 33);
            this.cmbDoors.TabIndex = 1;
            // 
            // btnGoIn
            // 
            this.btnGoIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGoIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGoIn.Location = new System.Drawing.Point(3, 160);
            this.btnGoIn.Margin = new System.Windows.Forms.Padding(3, 70, 3, 2);
            this.btnGoIn.Name = "btnGoIn";
            this.btnGoIn.Size = new System.Drawing.Size(297, 174);
            this.btnGoIn.TabIndex = 2;
            this.btnGoIn.Text = "Войти";
            this.btnGoIn.UseVisualStyleBackColor = true;
            this.btnGoIn.Click += new System.EventHandler(this.btnGoIn_Click);
            // 
            // pbLoad
            // 
            this.pbLoad.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pbLoad.Location = new System.Drawing.Point(251, 506);
            this.pbLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbLoad.Name = "pbLoad";
            this.pbLoad.Size = new System.Drawing.Size(509, 34);
            this.pbLoad.TabIndex = 6;
            // 
            // ContentLayout
            // 
            this.ContentLayout.Controls.Add(this.ContentLayoutLeft);
            this.ContentLayout.Controls.Add(this.ContentLayoutMiddle);
            this.ContentLayout.Controls.Add(this.ContentLayoutRight);
            this.ContentLayout.Location = new System.Drawing.Point(4, 4);
            this.ContentLayout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ContentLayout.Name = "ContentLayout";
            this.ContentLayout.Size = new System.Drawing.Size(1003, 496);
            this.ContentLayout.TabIndex = 7;
            // 
            // MainLayout
            // 
            this.MainLayout.Controls.Add(this.ContentLayout);
            this.MainLayout.Controls.Add(this.pbLoad);
            this.MainLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.MainLayout.Location = new System.Drawing.Point(16, 15);
            this.MainLayout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.Size = new System.Drawing.Size(1011, 543);
            this.MainLayout.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 560);
            this.Controls.Add(this.MainLayout);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ContentLayoutLeft.ResumeLayout(false);
            this.ContentLayoutLeft.PerformLayout();
            this.ContentLayoutMiddle.ResumeLayout(false);
            this.ContentLayoutMiddle.PerformLayout();
            this.ContentLayoutRight.ResumeLayout(false);
            this.ContentLayout.ResumeLayout(false);
            this.MainLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbEmployees;
        private System.Windows.Forms.TextBox tbEmployees;
        private System.Windows.Forms.Label lblEmployees;
        private System.Windows.Forms.FlowLayoutPanel ContentLayoutLeft;
        private System.Windows.Forms.FlowLayoutPanel ContentLayoutMiddle;
        private System.Windows.Forms.Label lblMidleZone;
        private System.Windows.Forms.Label lblCurLocation;
        private System.Windows.Forms.Button btnGoOut;
        private System.Windows.Forms.FlowLayoutPanel ContentLayoutRight;
        private System.Windows.Forms.ComboBox cmbLocations;
        private System.Windows.Forms.ComboBox cmbDoors;
        private System.Windows.Forms.Button btnGoIn;
        private System.Windows.Forms.ProgressBar pbLoad;
        private System.Windows.Forms.FlowLayoutPanel ContentLayout;
        private System.Windows.Forms.FlowLayoutPanel MainLayout;
    }
}

