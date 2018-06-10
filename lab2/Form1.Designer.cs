namespace lab2
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_N = new System.Windows.Forms.TextBox();
            this.drawButton = new System.Windows.Forms.Button();
            this.countLabel1 = new System.Windows.Forms.Label();
            this.y_graph = new ZedGraph.ZedGraphControl();
            this.z_graph = new ZedGraph.ZedGraphControl();
            this.convolution_graph = new ZedGraph.ZedGraphControl();
            this.convolutionFFT_graph = new ZedGraph.ZedGraphControl();
            this.correlation_graph = new ZedGraph.ZedGraphControl();
            this.correlationFFT_graph = new ZedGraph.ZedGraphControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.y_graph, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.z_graph, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.convolutionFFT_graph, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.correlation_graph, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.convolution_graph, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.correlationFFT_graph, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1240, 513);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_N);
            this.panel1.Controls.Add(this.drawButton);
            this.panel1.Controls.Add(this.countLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1234, 59);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Количество отсчётов, N";
            // 
            // textBox_N
            // 
            this.textBox_N.Location = new System.Drawing.Point(154, 28);
            this.textBox_N.Name = "textBox_N";
            this.textBox_N.Size = new System.Drawing.Size(100, 20);
            this.textBox_N.TabIndex = 25;
            this.textBox_N.Text = "16";
            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(298, 18);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(91, 30);
            this.drawButton.TabIndex = 24;
            this.drawButton.Text = "Draw";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // countLabel1
            // 
            this.countLabel1.AutoSize = true;
            this.countLabel1.Location = new System.Drawing.Point(0, 58);
            this.countLabel1.Name = "countLabel1";
            this.countLabel1.Size = new System.Drawing.Size(0, 13);
            this.countLabel1.TabIndex = 23;
            // 
            // y_graph
            // 
            this.y_graph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.y_graph.Location = new System.Drawing.Point(3, 68);
            this.y_graph.Name = "y_graph";
            this.y_graph.ScrollGrace = 0D;
            this.y_graph.ScrollMaxX = 0D;
            this.y_graph.ScrollMaxY = 0D;
            this.y_graph.ScrollMaxY2 = 0D;
            this.y_graph.ScrollMinX = 0D;
            this.y_graph.ScrollMinY = 0D;
            this.y_graph.ScrollMinY2 = 0D;
            this.y_graph.Size = new System.Drawing.Size(407, 218);
            this.y_graph.TabIndex = 14;
            this.y_graph.ZoomButtons = System.Windows.Forms.MouseButtons.None;
            // 
            // z_graph
            // 
            this.z_graph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.z_graph.Location = new System.Drawing.Point(3, 292);
            this.z_graph.Name = "z_graph";
            this.z_graph.ScrollGrace = 0D;
            this.z_graph.ScrollMaxX = 0D;
            this.z_graph.ScrollMaxY = 0D;
            this.z_graph.ScrollMaxY2 = 0D;
            this.z_graph.ScrollMinX = 0D;
            this.z_graph.ScrollMinY = 0D;
            this.z_graph.ScrollMinY2 = 0D;
            this.z_graph.Size = new System.Drawing.Size(407, 218);
            this.z_graph.TabIndex = 16;
            this.z_graph.ZoomButtons = System.Windows.Forms.MouseButtons.None;
            // 
            // convolution_graph
            // 
            this.convolution_graph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.convolution_graph.Location = new System.Drawing.Point(829, 68);
            this.convolution_graph.Name = "convolution_graph";
            this.convolution_graph.ScrollGrace = 0D;
            this.convolution_graph.ScrollMaxX = 0D;
            this.convolution_graph.ScrollMaxY = 0D;
            this.convolution_graph.ScrollMaxY2 = 0D;
            this.convolution_graph.ScrollMinX = 0D;
            this.convolution_graph.ScrollMinY = 0D;
            this.convolution_graph.ScrollMinY2 = 0D;
            this.convolution_graph.Size = new System.Drawing.Size(408, 218);
            this.convolution_graph.TabIndex = 17;
            this.convolution_graph.ZoomButtons = System.Windows.Forms.MouseButtons.None;
            // 
            // convolutionFFT_graph
            // 
            this.convolutionFFT_graph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.convolutionFFT_graph.Location = new System.Drawing.Point(829, 292);
            this.convolutionFFT_graph.Name = "convolutionFFT_graph";
            this.convolutionFFT_graph.ScrollGrace = 0D;
            this.convolutionFFT_graph.ScrollMaxX = 0D;
            this.convolutionFFT_graph.ScrollMaxY = 0D;
            this.convolutionFFT_graph.ScrollMaxY2 = 0D;
            this.convolutionFFT_graph.ScrollMinX = 0D;
            this.convolutionFFT_graph.ScrollMinY = 0D;
            this.convolutionFFT_graph.ScrollMinY2 = 0D;
            this.convolutionFFT_graph.Size = new System.Drawing.Size(408, 218);
            this.convolutionFFT_graph.TabIndex = 15;
            this.convolutionFFT_graph.ZoomButtons = System.Windows.Forms.MouseButtons.None;
            // 
            // correlation_graph
            // 
            this.correlation_graph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.correlation_graph.Location = new System.Drawing.Point(416, 68);
            this.correlation_graph.Name = "correlation_graph";
            this.correlation_graph.ScrollGrace = 0D;
            this.correlation_graph.ScrollMaxX = 0D;
            this.correlation_graph.ScrollMaxY = 0D;
            this.correlation_graph.ScrollMaxY2 = 0D;
            this.correlation_graph.ScrollMinX = 0D;
            this.correlation_graph.ScrollMinY = 0D;
            this.correlation_graph.ScrollMinY2 = 0D;
            this.correlation_graph.Size = new System.Drawing.Size(407, 218);
            this.correlation_graph.TabIndex = 18;
            this.correlation_graph.ZoomButtons = System.Windows.Forms.MouseButtons.None;
            // 
            // correlationFFT_graph
            // 
            this.correlationFFT_graph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.correlationFFT_graph.Location = new System.Drawing.Point(416, 292);
            this.correlationFFT_graph.Name = "correlationFFT_graph";
            this.correlationFFT_graph.ScrollGrace = 0D;
            this.correlationFFT_graph.ScrollMaxX = 0D;
            this.correlationFFT_graph.ScrollMaxY = 0D;
            this.correlationFFT_graph.ScrollMaxY2 = 0D;
            this.correlationFFT_graph.ScrollMinX = 0D;
            this.correlationFFT_graph.ScrollMinY = 0D;
            this.correlationFFT_graph.ScrollMinY2 = 0D;
            this.correlationFFT_graph.Size = new System.Drawing.Size(407, 218);
            this.correlationFFT_graph.TabIndex = 19;
            this.correlationFFT_graph.ZoomButtons = System.Windows.Forms.MouseButtons.None;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 513);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "ЛР2. Вариант 8. Корреляция и свёртка";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_N;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.Label countLabel1;
        private ZedGraph.ZedGraphControl y_graph;
        private ZedGraph.ZedGraphControl z_graph;
        private ZedGraph.ZedGraphControl convolution_graph;
        private ZedGraph.ZedGraphControl convolutionFFT_graph;
        private ZedGraph.ZedGraphControl correlation_graph;
        private ZedGraph.ZedGraphControl correlationFFT_graph;



    }
}

