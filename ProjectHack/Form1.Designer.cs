
namespace ProjectHack
{
    public partial class Form1
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.label1 = new System.Windows.Forms.Label();
            this.Add_Report_Button = new System.Windows.Forms.Button();
            this.Reporting_History_Button = new System.Windows.Forms.Button();
            this.City_Hall_Access_Button = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(955, 782);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // map
            // 
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemory = 5;
            this.map.Location = new System.Drawing.Point(12, 12);
            this.map.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(943, 601);
            this.map.TabIndex = 1;
            this.map.Zoom = 0D;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(964, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome";
            // 
            // Add_Report_Button
            // 
            this.Add_Report_Button.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Report_Button.Location = new System.Drawing.Point(999, 106);
            this.Add_Report_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Add_Report_Button.Name = "Add_Report_Button";
            this.Add_Report_Button.Size = new System.Drawing.Size(126, 40);
            this.Add_Report_Button.TabIndex = 4;
            this.Add_Report_Button.Text = "Add Report";
            this.Add_Report_Button.UseVisualStyleBackColor = true;
            this.Add_Report_Button.Click += new System.EventHandler(this.Add_Report_Button_Click);
            // 
            // Reporting_History_Button
            // 
            this.Reporting_History_Button.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reporting_History_Button.Location = new System.Drawing.Point(986, 176);
            this.Reporting_History_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Reporting_History_Button.Name = "Reporting_History_Button";
            this.Reporting_History_Button.Size = new System.Drawing.Size(170, 42);
            this.Reporting_History_Button.TabIndex = 5;
            this.Reporting_History_Button.Text = "Reporting History";
            this.Reporting_History_Button.UseVisualStyleBackColor = true;
            this.Reporting_History_Button.Click += new System.EventHandler(this.Reporting_History_Button_Click);
            // 
            // City_Hall_Access_Button
            // 
            this.City_Hall_Access_Button.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.City_Hall_Access_Button.Location = new System.Drawing.Point(986, 249);
            this.City_Hall_Access_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.City_Hall_Access_Button.Name = "City_Hall_Access_Button";
            this.City_Hall_Access_Button.Size = new System.Drawing.Size(170, 36);
            this.City_Hall_Access_Button.TabIndex = 6;
            this.City_Hall_Access_Button.Text = "City Hall Access";
            this.City_Hall_Access_Button.UseVisualStyleBackColor = true;
            this.City_Hall_Access_Button.Click += new System.EventHandler(this.City_Hall_Access_Button_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 782);
            this.Controls.Add(this.City_Hall_Access_Button);
            this.Controls.Add(this.Reporting_History_Button);
            this.Controls.Add(this.Add_Report_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.map);
            this.Controls.Add(this.splitter1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Add_Report_Button;
        private System.Windows.Forms.Button Reporting_History_Button;
        private System.Windows.Forms.Button City_Hall_Access_Button;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}