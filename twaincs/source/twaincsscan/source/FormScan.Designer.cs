namespace TWAINCSScan
{
    partial class FormScan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      this.m_buttonScan = new System.Windows.Forms.Button();
      this.m_buttonSetup = new System.Windows.Forms.Button();
      this.m_buttonClose = new System.Windows.Forms.Button();
      this.m_buttonOpen = new System.Windows.Forms.Button();
      this.m_buttonStop = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // m_buttonScan
      // 
      this.m_buttonScan.Location = new System.Drawing.Point(414, 260);
      this.m_buttonScan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.m_buttonScan.Name = "m_buttonScan";
      this.m_buttonScan.Size = new System.Drawing.Size(195, 58);
      this.m_buttonScan.TabIndex = 1;
      this.m_buttonScan.Text = "Scan";
      this.m_buttonScan.UseVisualStyleBackColor = true;
      this.m_buttonScan.Click += new System.EventHandler(this.m_buttonScan_Click);
      // 
      // m_buttonSetup
      // 
      this.m_buttonSetup.Location = new System.Drawing.Point(123, 260);
      this.m_buttonSetup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.m_buttonSetup.Name = "m_buttonSetup";
      this.m_buttonSetup.Size = new System.Drawing.Size(195, 58);
      this.m_buttonSetup.TabIndex = 3;
      this.m_buttonSetup.Text = "Configurar";
      this.m_buttonSetup.UseVisualStyleBackColor = true;
      this.m_buttonSetup.Click += new System.EventHandler(this.m_buttonSetup_Click);
      // 
      // m_buttonClose
      // 
      this.m_buttonClose.Location = new System.Drawing.Point(553, 143);
      this.m_buttonClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.m_buttonClose.Name = "m_buttonClose";
      this.m_buttonClose.Size = new System.Drawing.Size(194, 58);
      this.m_buttonClose.TabIndex = 5;
      this.m_buttonClose.Text = "Cerrar Conexión";
      this.m_buttonClose.UseVisualStyleBackColor = true;
      this.m_buttonClose.Click += new System.EventHandler(this.m_buttonClose_Click);
      // 
      // m_buttonOpen
      // 
      this.m_buttonOpen.Location = new System.Drawing.Point(289, 143);
      this.m_buttonOpen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.m_buttonOpen.Name = "m_buttonOpen";
      this.m_buttonOpen.Size = new System.Drawing.Size(195, 58);
      this.m_buttonOpen.TabIndex = 6;
      this.m_buttonOpen.Text = "Conectar Escaner";
      this.m_buttonOpen.UseVisualStyleBackColor = true;
      this.m_buttonOpen.Click += new System.EventHandler(this.m_buttonOpen_Click);
      // 
      // m_buttonStop
      // 
      this.m_buttonStop.Location = new System.Drawing.Point(695, 260);
      this.m_buttonStop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.m_buttonStop.Name = "m_buttonStop";
      this.m_buttonStop.Size = new System.Drawing.Size(195, 58);
      this.m_buttonStop.TabIndex = 7;
      this.m_buttonStop.Text = "Parar Escaneo";
      this.m_buttonStop.UseVisualStyleBackColor = true;
      this.m_buttonStop.Click += new System.EventHandler(this.m_buttonStop_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(390, 44);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(256, 46);
      this.label1.TabIndex = 8;
      this.label1.Text = "FBS Escaner";
      // 
      // FormScan
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1053, 429);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.m_buttonStop);
      this.Controls.Add(this.m_buttonOpen);
      this.Controls.Add(this.m_buttonClose);
      this.Controls.Add(this.m_buttonSetup);
      this.Controls.Add(this.m_buttonScan);
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Name = "FormScan";
      this.Text = "TWAIN C# Scan";
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button m_buttonScan;
        private System.Windows.Forms.Button m_buttonSetup;
        private System.Windows.Forms.Button m_buttonClose;
        private System.Windows.Forms.Button m_buttonOpen;
        private System.Windows.Forms.Button m_buttonStop;
        private System.Windows.Forms.Label label1;
    }
}