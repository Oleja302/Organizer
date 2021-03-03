namespace Organizer
{
    partial class FormA
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
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.L = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.P = new System.Windows.Forms.Label();
            this.buttonCANCEL = new System.Windows.Forms.Button();
            this.Show = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LoginText = new System.Windows.Forms.TextBox();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Enter your password here";
            // 
            // toolTip2
            // 
            this.toolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip2.ToolTipTitle = "Enter your login here";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 315);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(418, 0);
            this.flowLayoutPanel1.TabIndex = 7;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // L
            // 
            this.L.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.L.AutoSize = true;
            this.L.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.L.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.L.Location = new System.Drawing.Point(11, 38);
            this.L.Margin = new System.Windows.Forms.Padding(11, 0, 3, 0);
            this.L.Name = "L";
            this.L.Size = new System.Drawing.Size(71, 25);
            this.L.TabIndex = 0;
            this.L.Text = " Login";
            this.L.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonOK
            // 
            this.buttonOK.AutoSize = true;
            this.buttonOK.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK.Location = new System.Drawing.Point(10, 255);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(189, 57);
            this.buttonOK.TabIndex = 8;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // P
            // 
            this.P.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.P.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.P.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.P.Location = new System.Drawing.Point(0, 150);
            this.P.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(142, 39);
            this.P.TabIndex = 2;
            this.P.Text = "Password";
            this.P.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.P.Click += new System.EventHandler(this.P_Click);
            // 
            // buttonCANCEL
            // 
            this.buttonCANCEL.AutoSize = true;
            this.buttonCANCEL.BackColor = System.Drawing.Color.Crimson;
            this.buttonCANCEL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCANCEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCANCEL.Location = new System.Drawing.Point(219, 255);
            this.buttonCANCEL.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.buttonCANCEL.Name = "buttonCANCEL";
            this.buttonCANCEL.Size = new System.Drawing.Size(189, 57);
            this.buttonCANCEL.TabIndex = 7;
            this.buttonCANCEL.Text = "CANCEL";
            this.buttonCANCEL.UseVisualStyleBackColor = false;
            this.buttonCANCEL.Click += new System.EventHandler(this.buttonCANCEL_Click);
            // 
            // Show
            // 
            this.Show.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Show.AutoSize = true;
            this.Show.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Show.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Show.Location = new System.Drawing.Point(271, 157);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(84, 29);
            this.Show.TabIndex = 6;
            this.Show.Text = "Show";
            this.Show.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Show.UseVisualStyleBackColor = false;
            this.Show.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Show_MouseClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Show, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.LoginText, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.PasswordText, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonOK, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonCANCEL, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.L, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.P, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(418, 315);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // LoginText
            // 
            this.LoginText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginText.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.LoginText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.LoginText, 2);
            this.LoginText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginText.Location = new System.Drawing.Point(25, 75);
            this.LoginText.Margin = new System.Windows.Forms.Padding(25, 3, 25, 3);
            this.LoginText.Multiline = true;
            this.LoginText.Name = "LoginText";
            this.LoginText.Size = new System.Drawing.Size(368, 38);
            this.LoginText.TabIndex = 1;
            this.LoginText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LoginText.WordWrap = false;
            this.LoginText.MouseHover += new System.EventHandler(this.LoginText_MouseHover);
            // 
            // PasswordText
            // 
            this.PasswordText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordText.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.PasswordText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.PasswordText, 2);
            this.PasswordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordText.Location = new System.Drawing.Point(25, 201);
            this.PasswordText.Margin = new System.Windows.Forms.Padding(25, 3, 25, 3);
            this.PasswordText.Multiline = true;
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(368, 38);
            this.PasswordText.TabIndex = 3;
            this.PasswordText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PasswordText.WordWrap = false;
            this.PasswordText.MouseHover += new System.EventHandler(this.PasswordText_MouseHover);
            // 
            // FormA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(418, 315);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(16, 35);
            this.Name = "FormA";
            this.Text = "Authorization";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormA_FormClosing);
            this.Load += new System.EventHandler(this.FormA_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label L;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label P;
        private System.Windows.Forms.Button buttonCANCEL;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox Show;
        private System.Windows.Forms.TextBox LoginText;
        private System.Windows.Forms.TextBox PasswordText;
    }
}

