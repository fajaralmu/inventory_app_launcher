namespace MedicalInventoryLauncher
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSelectTomcatHome = new System.Windows.Forms.Button();
            this.btnSelectPgHome = new System.Windows.Forms.Button();
            this.btnSelectPgData = new System.Windows.Forms.Button();
            this.textBoxTomcatPth = new System.Windows.Forms.TextBox();
            this.textBoxPgHomePath = new System.Windows.Forms.TextBox();
            this.textBoxDataPath = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.btnOpenTomcatHome = new System.Windows.Forms.Button();
            this.btnOpenPgHome = new System.Windows.Forms.Button();
            this.btnOpenPgData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tomcat Home Directory";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PostgreSql Home Directory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "PostgreSql Data Directory";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(180, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Settings";
            // 
            // btnSelectTomcatHome
            // 
            this.btnSelectTomcatHome.Location = new System.Drawing.Point(331, 75);
            this.btnSelectTomcatHome.Name = "btnSelectTomcatHome";
            this.btnSelectTomcatHome.Size = new System.Drawing.Size(75, 23);
            this.btnSelectTomcatHome.TabIndex = 7;
            this.btnSelectTomcatHome.Text = "Browse";
            this.btnSelectTomcatHome.UseVisualStyleBackColor = true;
            this.btnSelectTomcatHome.Click += new System.EventHandler(this.btnSelectTomcatHome_Click);
            // 
            // btnSelectPgHome
            // 
            this.btnSelectPgHome.Location = new System.Drawing.Point(331, 121);
            this.btnSelectPgHome.Name = "btnSelectPgHome";
            this.btnSelectPgHome.Size = new System.Drawing.Size(75, 23);
            this.btnSelectPgHome.TabIndex = 8;
            this.btnSelectPgHome.Text = "Browse";
            this.btnSelectPgHome.UseVisualStyleBackColor = true;
            this.btnSelectPgHome.Click += new System.EventHandler(this.btnSelectPgHome_Click);
            // 
            // btnSelectPgData
            // 
            this.btnSelectPgData.Location = new System.Drawing.Point(331, 169);
            this.btnSelectPgData.Name = "btnSelectPgData";
            this.btnSelectPgData.Size = new System.Drawing.Size(75, 23);
            this.btnSelectPgData.TabIndex = 9;
            this.btnSelectPgData.Text = "Browse";
            this.btnSelectPgData.UseVisualStyleBackColor = true;
            this.btnSelectPgData.Click += new System.EventHandler(this.btnSelectPgData_Click);
            // 
            // textBoxTomcatPth
            // 
            this.textBoxTomcatPth.Enabled = false;
            this.textBoxTomcatPth.Location = new System.Drawing.Point(24, 78);
            this.textBoxTomcatPth.Name = "textBoxTomcatPth";
            this.textBoxTomcatPth.Size = new System.Drawing.Size(288, 20);
            this.textBoxTomcatPth.TabIndex = 10;
            // 
            // textBoxPgHomePath
            // 
            this.textBoxPgHomePath.Enabled = false;
            this.textBoxPgHomePath.Location = new System.Drawing.Point(24, 124);
            this.textBoxPgHomePath.Name = "textBoxPgHomePath";
            this.textBoxPgHomePath.Size = new System.Drawing.Size(288, 20);
            this.textBoxPgHomePath.TabIndex = 11;
            // 
            // textBoxDataPath
            // 
            this.textBoxDataPath.Enabled = false;
            this.textBoxDataPath.Location = new System.Drawing.Point(24, 172);
            this.textBoxDataPath.Name = "textBoxDataPath";
            this.textBoxDataPath.Size = new System.Drawing.Size(288, 20);
            this.textBoxDataPath.TabIndex = 12;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(24, 221);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 13;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // btnOpenTomcatHome
            // 
            this.btnOpenTomcatHome.Location = new System.Drawing.Point(424, 74);
            this.btnOpenTomcatHome.Name = "btnOpenTomcatHome";
            this.btnOpenTomcatHome.Size = new System.Drawing.Size(75, 23);
            this.btnOpenTomcatHome.TabIndex = 14;
            this.btnOpenTomcatHome.Text = "Open";
            this.btnOpenTomcatHome.UseVisualStyleBackColor = true;
            this.btnOpenTomcatHome.Click += new System.EventHandler(this.btnOpenTomcatHome_Click);
            // 
            // btnOpenPgHome
            // 
            this.btnOpenPgHome.Location = new System.Drawing.Point(424, 121);
            this.btnOpenPgHome.Name = "btnOpenPgHome";
            this.btnOpenPgHome.Size = new System.Drawing.Size(75, 23);
            this.btnOpenPgHome.TabIndex = 15;
            this.btnOpenPgHome.Text = "Open";
            this.btnOpenPgHome.UseVisualStyleBackColor = true;
            this.btnOpenPgHome.Click += new System.EventHandler(this.btnOpenPgHome_Click);
            // 
            // btnOpenPgData
            // 
            this.btnOpenPgData.Location = new System.Drawing.Point(424, 169);
            this.btnOpenPgData.Name = "btnOpenPgData";
            this.btnOpenPgData.Size = new System.Drawing.Size(75, 23);
            this.btnOpenPgData.TabIndex = 16;
            this.btnOpenPgData.Text = "Open";
            this.btnOpenPgData.UseVisualStyleBackColor = true;
            this.btnOpenPgData.Click += new System.EventHandler(this.btnOpenPgData_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 406);
            this.Controls.Add(this.btnOpenPgData);
            this.Controls.Add(this.btnOpenPgHome);
            this.Controls.Add(this.btnOpenTomcatHome);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxDataPath);
            this.Controls.Add(this.textBoxPgHomePath);
            this.Controls.Add(this.textBoxTomcatPth);
            this.Controls.Add(this.btnSelectPgData);
            this.Controls.Add(this.btnSelectPgHome);
            this.Controls.Add(this.btnSelectTomcatHome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSelectTomcatHome;
        private System.Windows.Forms.Button btnSelectPgHome;
        private System.Windows.Forms.Button btnSelectPgData;
        private System.Windows.Forms.TextBox textBoxTomcatPth;
        private System.Windows.Forms.TextBox textBoxPgHomePath;
        private System.Windows.Forms.TextBox textBoxDataPath;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button btnOpenTomcatHome;
        private System.Windows.Forms.Button btnOpenPgHome;
        private System.Windows.Forms.Button btnOpenPgData;
    }
}