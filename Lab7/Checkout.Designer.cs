
namespace Lab7
{
    partial class Checkout
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.changeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRecieved = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBillAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.closeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.saveBtn = new Guna.UI2.WinForms.Guna2Button();
            this.txtChange = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(772, 119);
            this.guna2Panel1.TabIndex = 2;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(688, 53);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(174, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Катологи";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.ErrorImage = global::Lab7.Properties.Resources.table;
            this.guna2PictureBox1.Image = global::Lab7.Properties.Resources.table;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.guna2PictureBox1.Location = new System.Drawing.Point(34, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(116, 105);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.changeLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.changeLabel.Location = new System.Drawing.Point(65, 287);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(77, 23);
            this.changeLabel.TabIndex = 16;
            this.changeLabel.Text = "Хариулт:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(389, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Төлсөн:";
            // 
            // txtRecieved
            // 
            this.txtRecieved.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRecieved.DefaultText = "";
            this.txtRecieved.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRecieved.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRecieved.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRecieved.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRecieved.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRecieved.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRecieved.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRecieved.Location = new System.Drawing.Point(393, 224);
            this.txtRecieved.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRecieved.Name = "txtRecieved";
            this.txtRecieved.PasswordChar = '\0';
            this.txtRecieved.PlaceholderText = "";
            this.txtRecieved.SelectedText = "";
            this.txtRecieved.Size = new System.Drawing.Size(285, 48);
            this.txtRecieved.TabIndex = 13;
            this.txtRecieved.TextChanged += new System.EventHandler(this.txtRecieved_TextChanged);
            // 
            // txtBillAmount
            // 
            this.txtBillAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBillAmount.DefaultText = "";
            this.txtBillAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBillAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBillAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBillAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBillAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBillAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBillAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBillAmount.Location = new System.Drawing.Point(69, 224);
            this.txtBillAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBillAmount.Name = "txtBillAmount";
            this.txtBillAmount.PasswordChar = '\0';
            this.txtBillAmount.PlaceholderText = "";
            this.txtBillAmount.SelectedText = "";
            this.txtBillAmount.Size = new System.Drawing.Size(285, 48);
            this.txtBillAmount.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(65, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Нийт дүн:";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.closeBtn);
            this.guna2Panel2.Controls.Add(this.saveBtn);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Panel2.Location = new System.Drawing.Point(0, 425);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(772, 95);
            this.guna2Panel2.TabIndex = 10;
            // 
            // closeBtn
            // 
            this.closeBtn.AutoRoundedCorners = true;
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.BorderRadius = 25;
            this.closeBtn.CustomizableEdges.TopRight = false;
            this.closeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.closeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.closeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.closeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.closeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.closeBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.closeBtn.ForeColor = System.Drawing.Color.Black;
            this.closeBtn.Location = new System.Drawing.Point(492, 24);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(151, 52);
            this.closeBtn.TabIndex = 3;
            this.closeBtn.Text = "ГАРАХ";
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.AutoRoundedCorners = true;
            this.saveBtn.BackColor = System.Drawing.Color.Transparent;
            this.saveBtn.BorderRadius = 25;
            this.saveBtn.CustomizableEdges.TopRight = false;
            this.saveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saveBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.saveBtn.ForeColor = System.Drawing.Color.Black;
            this.saveBtn.Location = new System.Drawing.Point(34, 24);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(151, 52);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "ХАДГАЛАХ";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // txtChange
            // 
            this.txtChange.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtChange.DefaultText = "";
            this.txtChange.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtChange.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtChange.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtChange.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtChange.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtChange.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtChange.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtChange.Location = new System.Drawing.Point(69, 323);
            this.txtChange.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtChange.Name = "txtChange";
            this.txtChange.PasswordChar = '\0';
            this.txtChange.PlaceholderText = "";
            this.txtChange.SelectedText = "";
            this.txtChange.Size = new System.Drawing.Size(285, 48);
            this.txtChange.TabIndex = 17;
            // 
            // Checkout
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(772, 520);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRecieved);
            this.Controls.Add(this.txtBillAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Checkout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checkout";
            this.Load += new System.EventHandler(this.Checkout_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        public System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label label3;
        public Guna.UI2.WinForms.Guna2TextBox txtRecieved;
        public Guna.UI2.WinForms.Guna2TextBox txtBillAmount;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        public Guna.UI2.WinForms.Guna2Button closeBtn;
        public Guna.UI2.WinForms.Guna2Button saveBtn;
        public Guna.UI2.WinForms.Guna2TextBox txtChange;
    }
}