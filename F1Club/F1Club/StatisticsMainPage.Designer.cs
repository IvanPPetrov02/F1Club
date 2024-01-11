namespace F1Club
{
    partial class StatisticsMainPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnTeams = new Button();
            btnDrivers = new Button();
            formsPlot1 = new ScottPlot.FormsPlot();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(22, 12);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(110, 31);
            label1.TabIndex = 21;
            label1.Text = "Statistics";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnTeams
            // 
            btnTeams.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnTeams.Location = new Point(152, 825);
            btnTeams.Margin = new Padding(4, 5, 4, 5);
            btnTeams.Name = "btnTeams";
            btnTeams.Size = new Size(121, 71);
            btnTeams.TabIndex = 18;
            btnTeams.Text = "Teams";
            btnTeams.UseVisualStyleBackColor = true;
            btnTeams.Click += btnTeams_Click;
            // 
            // btnDrivers
            // 
            btnDrivers.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDrivers.Location = new Point(22, 825);
            btnDrivers.Margin = new Padding(4, 5, 4, 5);
            btnDrivers.Name = "btnDrivers";
            btnDrivers.Size = new Size(121, 71);
            btnDrivers.TabIndex = 17;
            btnDrivers.Text = "Drivers";
            btnDrivers.UseVisualStyleBackColor = true;
            btnDrivers.Click += btnDrivers_Click;
            // 
            // formsPlot1
            // 
            formsPlot1.Location = new Point(22, 60);
            formsPlot1.Margin = new Padding(6, 5, 6, 5);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(1664, 752);
            formsPlot1.TabIndex = 23;
            // 
            // StatisticsMainPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(formsPlot1);
            Controls.Add(label1);
            Controls.Add(btnTeams);
            Controls.Add(btnDrivers);
            Name = "StatisticsMainPage";
            Size = new Size(1708, 909);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnTeams;
        private Button btnDrivers;
        private ScottPlot.FormsPlot formsPlot1;
    }
}
