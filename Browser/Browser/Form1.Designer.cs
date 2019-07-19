namespace Browser
{
    partial class Form1
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
            this.txtUrl = new MetroFramework.Controls.MetroTextBox();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.btnToolbar = new MetroFramework.Controls.MetroButton();
            this.btnNewTab = new MetroFramework.Controls.MetroButton();
            this.btnGO = new MetroFramework.Controls.MetroButton();
            this.InkForward = new MetroFramework.Controls.MetroLink();
            this.InkBack = new MetroFramework.Controls.MetroLink();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.SuspendLayout();
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtUrl.CustomButton.Image = null;
            this.txtUrl.CustomButton.Location = new System.Drawing.Point(324, 2);
            this.txtUrl.CustomButton.Name = "";
            this.txtUrl.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtUrl.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUrl.CustomButton.TabIndex = 1;
            this.txtUrl.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUrl.CustomButton.UseSelectable = true;
            this.txtUrl.CustomButton.Visible = false;
            this.txtUrl.Lines = new string[0];
            this.txtUrl.Location = new System.Drawing.Point(104, 51);
            this.txtUrl.MaxLength = 32767;
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.PasswordChar = '\0';
            this.txtUrl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUrl.SelectedText = "";
            this.txtUrl.SelectionLength = 0;
            this.txtUrl.SelectionStart = 0;
            this.txtUrl.ShortcutsEnabled = true;
            this.txtUrl.Size = new System.Drawing.Size(358, 36);
            this.txtUrl.TabIndex = 2;
            this.txtUrl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUrl.UseSelectable = true;
            this.txtUrl.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUrl.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton4
            // 
            this.metroButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton4.Location = new System.Drawing.Point(615, 51);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(43, 36);
            this.metroButton4.TabIndex = 6;
            this.metroButton4.Text = "metroButton4";
            this.metroButton4.UseSelectable = true;
            // 
            // btnToolbar
            // 
            this.btnToolbar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToolbar.BackgroundImage = global::Browser.Properties.Resources._2931175___agenda_calendar_calender_date_month_schedule_timetable;
            this.btnToolbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnToolbar.Location = new System.Drawing.Point(566, 51);
            this.btnToolbar.Name = "btnToolbar";
            this.btnToolbar.Size = new System.Drawing.Size(43, 36);
            this.btnToolbar.TabIndex = 5;
            this.btnToolbar.UseSelectable = true;
            this.btnToolbar.Click += new System.EventHandler(this.BtnToolbar_Click);
            // 
            // btnNewTab
            // 
            this.btnNewTab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewTab.BackgroundImage = global::Browser.Properties.Resources._2931153___clipboard_clone_copy_duplicate_multiply;
            this.btnNewTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNewTab.Location = new System.Drawing.Point(517, 51);
            this.btnNewTab.Name = "btnNewTab";
            this.btnNewTab.Size = new System.Drawing.Size(43, 36);
            this.btnNewTab.TabIndex = 4;
            this.btnNewTab.UseSelectable = true;
            this.btnNewTab.Click += new System.EventHandler(this.BtnNewTab_Click);
            // 
            // btnGO
            // 
            this.btnGO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGO.BackgroundImage = global::Browser.Properties.Resources._2931184___glass_magnifier_magnifying_normal_regular_search_zoom;
            this.btnGO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGO.Location = new System.Drawing.Point(468, 51);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(43, 36);
            this.btnGO.TabIndex = 3;
            this.btnGO.UseSelectable = true;
            this.btnGO.Click += new System.EventHandler(this.BtnGO_Click);
            // 
            // InkForward
            // 
            this.InkForward.Image = global::Browser.Properties.Resources._2931159___arrow_forward_move_navigation_next_right;
            this.InkForward.Location = new System.Drawing.Point(55, 51);
            this.InkForward.Name = "InkForward";
            this.InkForward.Size = new System.Drawing.Size(36, 32);
            this.InkForward.TabIndex = 1;
            this.InkForward.UseSelectable = true;
            this.InkForward.Click += new System.EventHandler(this.InkForward_Click);
            // 
            // InkBack
            // 
            this.InkBack.Image = global::Browser.Properties.Resources._2931162___arrow_back_direction_left_move_navigation;
            this.InkBack.Location = new System.Drawing.Point(20, 51);
            this.InkBack.Name = "InkBack";
            this.InkBack.Size = new System.Drawing.Size(29, 32);
            this.InkBack.TabIndex = 0;
            this.InkBack.UseSelectable = true;
            this.InkBack.Click += new System.EventHandler(this.InkBack_Click);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTabControl1.Location = new System.Drawing.Point(25, 105);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.Size = new System.Drawing.Size(748, 324);
            this.metroTabControl1.TabIndex = 7;
            this.metroTabControl1.UseSelectable = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.btnToolbar);
            this.Controls.Add(this.btnNewTab);
            this.Controls.Add(this.btnGO);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.InkForward);
            this.Controls.Add(this.InkBack);
            this.Name = "Form1";
            this.Text = "Project: Morpheus";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink InkBack;
        private MetroFramework.Controls.MetroLink InkForward;
        private MetroFramework.Controls.MetroTextBox txtUrl;
        private MetroFramework.Controls.MetroButton btnGO;
        private MetroFramework.Controls.MetroButton btnNewTab;
        private MetroFramework.Controls.MetroButton btnToolbar;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
    }
}

