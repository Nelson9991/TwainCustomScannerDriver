namespace TWAINCSScan
{
    partial class FormSetup
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSetup));
      this.m_labelUseUiSettings = new System.Windows.Forms.Label();
      this.m_buttonShowDriverUi = new System.Windows.Forms.Button();
      this.m_buttonSaveUiSettings = new System.Windows.Forms.Button();
      this.m_buttonUseUiSettings = new System.Windows.Forms.Button();
      this.m_textboxUseUiSettings = new System.Windows.Forms.TextBox();
      this.m_groupboxCreateUiSetting = new System.Windows.Forms.GroupBox();
      this.m_groupboxManageSettings = new System.Windows.Forms.GroupBox();
      this.m_buttonDeleteSetting = new System.Windows.Forms.Button();
      this.m_groupboxCreateUiSetting.SuspendLayout();
      this.m_groupboxManageSettings.SuspendLayout();
      this.SuspendLayout();
      // 
      // m_labelUseUiSettings
      // 
      this.m_labelUseUiSettings.AutoSize = true;
      this.m_labelUseUiSettings.Location = new System.Drawing.Point(45, 288);
      this.m_labelUseUiSettings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.m_labelUseUiSettings.Name = "m_labelUseUiSettings";
      this.m_labelUseUiSettings.Size = new System.Drawing.Size(614, 20);
      this.m_labelUseUiSettings.TabIndex = 1;
      this.m_labelUseUiSettings.Text = "Seleccione opción para el siguiente escaneo (si se deja en blanco el programa esc" +
    "oje)";
      // 
      // m_buttonShowDriverUi
      // 
      this.m_buttonShowDriverUi.Location = new System.Drawing.Point(128, 49);
      this.m_buttonShowDriverUi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.m_buttonShowDriverUi.Name = "m_buttonShowDriverUi";
      this.m_buttonShowDriverUi.Size = new System.Drawing.Size(441, 35);
      this.m_buttonShowDriverUi.TabIndex = 1;
      this.m_buttonShowDriverUi.Text = "Cambiar opciones del escaner (presione aquí primero)";
      this.m_buttonShowDriverUi.UseVisualStyleBackColor = true;
      this.m_buttonShowDriverUi.Click += new System.EventHandler(this.m_buttonSetup_Click);
      // 
      // m_buttonSaveUiSettings
      // 
      this.m_buttonSaveUiSettings.Location = new System.Drawing.Point(128, 106);
      this.m_buttonSaveUiSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.m_buttonSaveUiSettings.Name = "m_buttonSaveUiSettings";
      this.m_buttonSaveUiSettings.Size = new System.Drawing.Size(441, 35);
      this.m_buttonSaveUiSettings.TabIndex = 2;
      this.m_buttonSaveUiSettings.Text = "Salvar las opciones del escaner (presione aquí despues)";
      this.m_buttonSaveUiSettings.UseVisualStyleBackColor = true;
      this.m_buttonSaveUiSettings.Click += new System.EventHandler(this.m_buttonSaveas_Click);
      // 
      // m_buttonUseUiSettings
      // 
      this.m_buttonUseUiSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("m_buttonUseUiSettings.BackgroundImage")));
      this.m_buttonUseUiSettings.Location = new System.Drawing.Point(577, 75);
      this.m_buttonUseUiSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.m_buttonUseUiSettings.Name = "m_buttonUseUiSettings";
      this.m_buttonUseUiSettings.Size = new System.Drawing.Size(36, 37);
      this.m_buttonUseUiSettings.TabIndex = 8;
      this.m_buttonUseUiSettings.UseVisualStyleBackColor = true;
      this.m_buttonUseUiSettings.Click += new System.EventHandler(this.m_buttonUseUiSettings_Click);
      // 
      // m_textboxUseUiSettings
      // 
      this.m_textboxUseUiSettings.Location = new System.Drawing.Point(27, 80);
      this.m_textboxUseUiSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.m_textboxUseUiSettings.Name = "m_textboxUseUiSettings";
      this.m_textboxUseUiSettings.Size = new System.Drawing.Size(541, 26);
      this.m_textboxUseUiSettings.TabIndex = 7;
      // 
      // m_groupboxCreateUiSetting
      // 
      this.m_groupboxCreateUiSetting.Controls.Add(this.m_buttonShowDriverUi);
      this.m_groupboxCreateUiSetting.Controls.Add(this.m_buttonSaveUiSettings);
      this.m_groupboxCreateUiSetting.Location = new System.Drawing.Point(22, 42);
      this.m_groupboxCreateUiSetting.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.m_groupboxCreateUiSetting.Name = "m_groupboxCreateUiSetting";
      this.m_groupboxCreateUiSetting.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.m_groupboxCreateUiSetting.Size = new System.Drawing.Size(647, 168);
      this.m_groupboxCreateUiSetting.TabIndex = 9;
      this.m_groupboxCreateUiSetting.TabStop = false;
      this.m_groupboxCreateUiSetting.Text = "Crear Opciones del Escaner";
      // 
      // m_groupboxManageSettings
      // 
      this.m_groupboxManageSettings.Controls.Add(this.m_textboxUseUiSettings);
      this.m_groupboxManageSettings.Controls.Add(this.m_buttonUseUiSettings);
      this.m_groupboxManageSettings.Controls.Add(this.m_buttonDeleteSetting);
      this.m_groupboxManageSettings.Location = new System.Drawing.Point(22, 240);
      this.m_groupboxManageSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.m_groupboxManageSettings.Name = "m_groupboxManageSettings";
      this.m_groupboxManageSettings.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.m_groupboxManageSettings.Size = new System.Drawing.Size(647, 175);
      this.m_groupboxManageSettings.TabIndex = 10;
      this.m_groupboxManageSettings.TabStop = false;
      this.m_groupboxManageSettings.Text = "Seleccione opciones para el escaner";
      // 
      // m_buttonDeleteSetting
      // 
      this.m_buttonDeleteSetting.Location = new System.Drawing.Point(461, 123);
      this.m_buttonDeleteSetting.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.m_buttonDeleteSetting.Name = "m_buttonDeleteSetting";
      this.m_buttonDeleteSetting.Size = new System.Drawing.Size(176, 42);
      this.m_buttonDeleteSetting.TabIndex = 0;
      this.m_buttonDeleteSetting.Text = "Delete setting...";
      this.m_buttonDeleteSetting.UseVisualStyleBackColor = true;
      this.m_buttonDeleteSetting.Click += new System.EventHandler(this.m_buttonDeleteSetting_Click);
      // 
      // FormSetup
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(697, 465);
      this.Controls.Add(this.m_labelUseUiSettings);
      this.Controls.Add(this.m_groupboxCreateUiSetting);
      this.Controls.Add(this.m_groupboxManageSettings);
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Name = "FormSetup";
      this.Text = "Setup TWAIN Scan";
      this.m_groupboxCreateUiSetting.ResumeLayout(false);
      this.m_groupboxManageSettings.ResumeLayout(false);
      this.m_groupboxManageSettings.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label m_labelUseUiSettings;
        private System.Windows.Forms.Button m_buttonShowDriverUi;
        private System.Windows.Forms.Button m_buttonSaveUiSettings;
        private System.Windows.Forms.Button m_buttonUseUiSettings;
        private System.Windows.Forms.TextBox m_textboxUseUiSettings;
        private System.Windows.Forms.GroupBox m_groupboxCreateUiSetting;
        private System.Windows.Forms.GroupBox m_groupboxManageSettings;
        private System.Windows.Forms.Button m_buttonDeleteSetting;
    }
}