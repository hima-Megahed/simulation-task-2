namespace NewspaperSellerSimulation
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
            this.btn_run = new System.Windows.Forms.Button();
            this.purch_price_txt = new System.Windows.Forms.TextBox();
            this.selling_price_txt = new System.Windows.Forms.TextBox();
            this.scrap_price_txt = new System.Windows.Forms.TextBox();
            this.purch_num_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.out_GV = new System.Windows.Forms.DataGridView();
            this.day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Random_day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demand_random = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Demand_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Excess_demand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scrap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daily_profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.revenue_txt = new System.Windows.Forms.TextBox();
            this.cost_txt = new System.Windows.Forms.TextBox();
            this.excess_lost_txt = new System.Windows.Forms.TextBox();
            this.scrap_txt = new System.Windows.Forms.TextBox();
            this.net_profit_txt = new System.Windows.Forms.TextBox();
            this.excess_days_txt = new System.Windows.Forms.TextBox();
            this.scrap_days_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.days_count_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.input_GV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.input2_GV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.out_GV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_GV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input2_GV)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_run
            // 
            this.btn_run.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_run.Location = new System.Drawing.Point(391, 268);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(115, 46);
            this.btn_run.TabIndex = 1;
            this.btn_run.Text = "Run";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // purch_price_txt
            // 
            this.purch_price_txt.Location = new System.Drawing.Point(948, 164);
            this.purch_price_txt.Name = "purch_price_txt";
            this.purch_price_txt.Size = new System.Drawing.Size(100, 20);
            this.purch_price_txt.TabIndex = 3;
            // 
            // selling_price_txt
            // 
            this.selling_price_txt.Location = new System.Drawing.Point(948, 203);
            this.selling_price_txt.Name = "selling_price_txt";
            this.selling_price_txt.Size = new System.Drawing.Size(100, 20);
            this.selling_price_txt.TabIndex = 4;
            // 
            // scrap_price_txt
            // 
            this.scrap_price_txt.Location = new System.Drawing.Point(948, 242);
            this.scrap_price_txt.Name = "scrap_price_txt";
            this.scrap_price_txt.Size = new System.Drawing.Size(100, 20);
            this.scrap_price_txt.TabIndex = 5;
            // 
            // purch_num_txt
            // 
            this.purch_num_txt.Location = new System.Drawing.Point(786, 47);
            this.purch_num_txt.Name = "purch_num_txt";
            this.purch_num_txt.Size = new System.Drawing.Size(100, 20);
            this.purch_num_txt.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(925, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Purchase Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(925, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Selling price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(925, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Scrap price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(748, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Number Of Newspapers";
            // 
            // out_GV
            // 
            this.out_GV.AllowUserToAddRows = false;
            this.out_GV.AllowUserToDeleteRows = false;
            this.out_GV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.out_GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.out_GV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.day,
            this.Random_day,
            this.day_type,
            this.demand_random,
            this.Demand_count,
            this.sales,
            this.Excess_demand,
            this.scrap,
            this.daily_profit});
            this.out_GV.Location = new System.Drawing.Point(12, 320);
            this.out_GV.Name = "out_GV";
            this.out_GV.ReadOnly = true;
            this.out_GV.Size = new System.Drawing.Size(1070, 401);
            this.out_GV.TabIndex = 11;
            // 
            // day
            // 
            this.day.HeaderText = "Day";
            this.day.Name = "day";
            // 
            // Random_day
            // 
            this.Random_day.HeaderText = "Random Digits Type Newsday";
            this.Random_day.Name = "Random_day";
            // 
            // day_type
            // 
            this.day_type.HeaderText = "Type of Newsday";
            this.day_type.Name = "day_type";
            // 
            // demand_random
            // 
            this.demand_random.HeaderText = "Random Digits For Demand";
            this.demand_random.Name = "demand_random";
            // 
            // Demand_count
            // 
            this.Demand_count.HeaderText = "Demand";
            this.Demand_count.Name = "Demand_count";
            // 
            // sales
            // 
            this.sales.HeaderText = "Sales Revenue";
            this.sales.Name = "sales";
            // 
            // Excess_demand
            // 
            this.Excess_demand.HeaderText = "Lost Profit Excess demand";
            this.Excess_demand.Name = "Excess_demand";
            // 
            // scrap
            // 
            this.scrap.HeaderText = "Scrap Salvage";
            this.scrap.Name = "scrap";
            // 
            // daily_profit
            // 
            this.daily_profit.HeaderText = "Daily Profit";
            this.daily_profit.Name = "daily_profit";
            // 
            // revenue_txt
            // 
            this.revenue_txt.Location = new System.Drawing.Point(786, 125);
            this.revenue_txt.Name = "revenue_txt";
            this.revenue_txt.ReadOnly = true;
            this.revenue_txt.Size = new System.Drawing.Size(100, 20);
            this.revenue_txt.TabIndex = 12;
            // 
            // cost_txt
            // 
            this.cost_txt.Location = new System.Drawing.Point(786, 164);
            this.cost_txt.Name = "cost_txt";
            this.cost_txt.ReadOnly = true;
            this.cost_txt.Size = new System.Drawing.Size(100, 20);
            this.cost_txt.TabIndex = 13;
            // 
            // excess_lost_txt
            // 
            this.excess_lost_txt.Location = new System.Drawing.Point(786, 203);
            this.excess_lost_txt.Name = "excess_lost_txt";
            this.excess_lost_txt.ReadOnly = true;
            this.excess_lost_txt.Size = new System.Drawing.Size(100, 20);
            this.excess_lost_txt.TabIndex = 14;
            // 
            // scrap_txt
            // 
            this.scrap_txt.Location = new System.Drawing.Point(786, 242);
            this.scrap_txt.Name = "scrap_txt";
            this.scrap_txt.ReadOnly = true;
            this.scrap_txt.Size = new System.Drawing.Size(100, 20);
            this.scrap_txt.TabIndex = 15;
            // 
            // net_profit_txt
            // 
            this.net_profit_txt.Location = new System.Drawing.Point(948, 47);
            this.net_profit_txt.Name = "net_profit_txt";
            this.net_profit_txt.ReadOnly = true;
            this.net_profit_txt.Size = new System.Drawing.Size(100, 20);
            this.net_profit_txt.TabIndex = 16;
            // 
            // excess_days_txt
            // 
            this.excess_days_txt.Location = new System.Drawing.Point(948, 86);
            this.excess_days_txt.Name = "excess_days_txt";
            this.excess_days_txt.ReadOnly = true;
            this.excess_days_txt.Size = new System.Drawing.Size(100, 20);
            this.excess_days_txt.TabIndex = 17;
            // 
            // scrap_days_txt
            // 
            this.scrap_days_txt.Location = new System.Drawing.Point(948, 125);
            this.scrap_days_txt.Name = "scrap_days_txt";
            this.scrap_days_txt.ReadOnly = true;
            this.scrap_days_txt.Size = new System.Drawing.Size(100, 20);
            this.scrap_days_txt.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(748, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Total sales revenue";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(748, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Total purchase cost";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(748, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Total lost from excess demand";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(748, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Total salvage from scrap";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(925, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Net profit";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(925, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Days with excess demands";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(925, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Days with scrap";
            // 
            // days_count_txt
            // 
            this.days_count_txt.Location = new System.Drawing.Point(786, 86);
            this.days_count_txt.Name = "days_count_txt";
            this.days_count_txt.Size = new System.Drawing.Size(100, 20);
            this.days_count_txt.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(748, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Number of days";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(66, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(188, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Distribution of Newspapers Demanded";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(407, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(229, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Random-Digit Assignment for Type of Newsday";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::NewspaperSellerSimulation.Properties.Resources.Blank;
            this.pictureBox2.Location = new System.Drawing.Point(801, 269);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(237, 2);
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NewspaperSellerSimulation.Properties.Resources.Blank;
            this.pictureBox1.Location = new System.Drawing.Point(911, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2, 153);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // input_GV
            // 
            this.input_GV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.input_GV.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.input_GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.input_GV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.input_GV.Location = new System.Drawing.Point(317, 25);
            this.input_GV.Name = "input_GV";
            this.input_GV.Size = new System.Drawing.Size(403, 237);
            this.input_GV.TabIndex = 33;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Type Of Newsday";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Propability";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Cummlative Probability";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Random-Digit Assignment";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // input2_GV
            // 
            this.input2_GV.AllowUserToDeleteRows = false;
            this.input2_GV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.input2_GV.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.input2_GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.input2_GV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.input2_GV.GridColor = System.Drawing.SystemColors.ControlLight;
            this.input2_GV.Location = new System.Drawing.Point(12, 25);
            this.input2_GV.Name = "input2_GV";
            this.input2_GV.Size = new System.Drawing.Size(299, 237);
            this.input2_GV.TabIndex = 34;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Demand";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Good";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Fair";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Poor";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 733);
            this.Controls.Add(this.input2_GV);
            this.Controls.Add(this.input_GV);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.days_count_txt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.scrap_days_txt);
            this.Controls.Add(this.excess_days_txt);
            this.Controls.Add(this.net_profit_txt);
            this.Controls.Add(this.scrap_txt);
            this.Controls.Add(this.excess_lost_txt);
            this.Controls.Add(this.cost_txt);
            this.Controls.Add(this.revenue_txt);
            this.Controls.Add(this.out_GV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.purch_num_txt);
            this.Controls.Add(this.scrap_price_txt);
            this.Controls.Add(this.selling_price_txt);
            this.Controls.Add(this.purch_price_txt);
            this.Controls.Add(this.btn_run);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.out_GV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_GV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input2_GV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.TextBox purch_price_txt;
        private System.Windows.Forms.TextBox selling_price_txt;
        private System.Windows.Forms.TextBox scrap_price_txt;
        private System.Windows.Forms.TextBox purch_num_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView out_GV;
        private System.Windows.Forms.TextBox revenue_txt;
        private System.Windows.Forms.TextBox cost_txt;
        private System.Windows.Forms.TextBox excess_lost_txt;
        private System.Windows.Forms.TextBox scrap_txt;
        private System.Windows.Forms.TextBox net_profit_txt;
        private System.Windows.Forms.TextBox excess_days_txt;
        private System.Windows.Forms.TextBox scrap_days_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox days_count_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn day;
        private System.Windows.Forms.DataGridViewTextBoxColumn Random_day;
        private System.Windows.Forms.DataGridViewTextBoxColumn day_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn demand_random;
        private System.Windows.Forms.DataGridViewTextBoxColumn Demand_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn sales;
        private System.Windows.Forms.DataGridViewTextBoxColumn Excess_demand;
        private System.Windows.Forms.DataGridViewTextBoxColumn scrap;
        private System.Windows.Forms.DataGridViewTextBoxColumn daily_profit;
        private System.Windows.Forms.DataGridView input_GV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView input2_GV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}