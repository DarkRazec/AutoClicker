namespace AutoClicker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            AutoClicker = new System.Windows.Forms.Timer(components);
            btnToggle = new Button();
            CPMToolbar = new TrackBar();
            CPMValue = new Label();
            ((System.ComponentModel.ISupportInitialize)CPMToolbar).BeginInit();
            SuspendLayout();
            // 
            // AutoClicker
            // 
            AutoClicker.Tick += AutoClicker_Tick;
            // 
            // btnToggle
            // 
            btnToggle.BackColor = SystemColors.ControlLightLight;
            btnToggle.BackgroundImageLayout = ImageLayout.None;
            btnToggle.FlatAppearance.BorderColor = Color.LightGray;
            btnToggle.FlatAppearance.BorderSize = 2;
            btnToggle.FlatStyle = FlatStyle.Flat;
            btnToggle.Font = new Font("MS Gothic", 20F, FontStyle.Bold);
            btnToggle.Location = new Point(12, 12);
            btnToggle.Name = "btnToggle";
            btnToggle.Size = new Size(197, 71);
            btnToggle.TabIndex = 0;
            btnToggle.Text = "enable";
            btnToggle.UseVisualStyleBackColor = false;
            btnToggle.TextChanged += btnToggle_TextChanged;
            btnToggle.Click += btnToggle_Click;
            // 
            // CPMToolbar
            // 
            CPMToolbar.BackColor = SystemColors.Window;
            CPMToolbar.Location = new Point(12, 91);
            CPMToolbar.Maximum = 5;
            CPMToolbar.Minimum = 1;
            CPMToolbar.Name = "CPMToolbar";
            CPMToolbar.Size = new Size(197, 45);
            CPMToolbar.TabIndex = 1;
            CPMToolbar.TickStyle = TickStyle.None;
            CPMToolbar.Value = 1;
            CPMToolbar.Scroll += CPM_Scroll;
            // 
            // CPMValue
            // 
            CPMValue.Font = new Font("Microsoft YaHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CPMValue.Location = new Point(1, 107);
            CPMValue.Name = "CPMValue";
            CPMValue.Size = new Size(219, 39);
            CPMValue.TabIndex = 2;
            CPMValue.Text = "1 click per minute";
            CPMValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.Window;
            ClientSize = new Size(223, 151);
            Controls.Add(CPMValue);
            Controls.Add(CPMToolbar);
            Controls.Add(btnToggle);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            Text = "AutoClicker";
            ((System.ComponentModel.ISupportInitialize)CPMToolbar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer AutoClicker;
        private Button btnToggle;
        private TrackBar CPMToolbar;
        private Label CPMValue;
    }
}
