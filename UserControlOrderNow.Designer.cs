
namespace Catering_Service_Online
{
    partial class UserControlOrderNow
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
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonOrderConfirm = new System.Windows.Forms.Button();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.buttonRequest = new System.Windows.Forms.Button();
            this.richTextBoxCancelOrder = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDeliveryTime = new System.Windows.Forms.DateTimePicker();
            this.cbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.ForeColor = System.Drawing.Color.Black;
            this.lblTotalCost.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotalCost.Location = new System.Drawing.Point(97, 259);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(30, 32);
            this.lblTotalCost.TabIndex = 1;
            this.lblTotalCost.Text = "0";
            this.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.FlatAppearance.BorderSize = 0;
            this.buttonCalculate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalculate.Location = new System.Drawing.Point(14, 327);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(195, 25);
            this.buttonCalculate.TabIndex = 3;
            this.buttonCalculate.Text = "calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(47, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 33);
            this.label9.TabIndex = 59;
            this.label9.Text = "Total Cost";
            // 
            // buttonOrderConfirm
            // 
            this.buttonOrderConfirm.BackColor = System.Drawing.Color.Maroon;
            this.buttonOrderConfirm.FlatAppearance.BorderSize = 0;
            this.buttonOrderConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrderConfirm.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrderConfirm.ForeColor = System.Drawing.Color.White;
            this.buttonOrderConfirm.Location = new System.Drawing.Point(237, 329);
            this.buttonOrderConfirm.Name = "buttonOrderConfirm";
            this.buttonOrderConfirm.Size = new System.Drawing.Size(195, 25);
            this.buttonOrderConfirm.TabIndex = 61;
            this.buttonOrderConfirm.Text = "Order Confirm";
            this.buttonOrderConfirm.UseVisualStyleBackColor = false;
            this.buttonOrderConfirm.Click += new System.EventHandler(this.buttonOrderConfirm_Click);
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewOrder.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Location = new System.Drawing.Point(14, 33);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.Size = new System.Drawing.Size(767, 148);
            this.dataGridViewOrder.TabIndex = 62;
            // 
            // buttonRequest
            // 
            this.buttonRequest.BackColor = System.Drawing.Color.Maroon;
            this.buttonRequest.FlatAppearance.BorderSize = 0;
            this.buttonRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRequest.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRequest.ForeColor = System.Drawing.Color.White;
            this.buttonRequest.Location = new System.Drawing.Point(484, 327);
            this.buttonRequest.Name = "buttonRequest";
            this.buttonRequest.Size = new System.Drawing.Size(297, 27);
            this.buttonRequest.TabIndex = 65;
            this.buttonRequest.Text = "Request Submit";
            this.buttonRequest.UseVisualStyleBackColor = false;
            this.buttonRequest.Click += new System.EventHandler(this.buttonRequest_Click);
            // 
            // richTextBoxCancelOrder
            // 
            this.richTextBoxCancelOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxCancelOrder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxCancelOrder.Location = new System.Drawing.Point(484, 232);
            this.richTextBoxCancelOrder.Name = "richTextBoxCancelOrder";
            this.richTextBoxCancelOrder.Size = new System.Drawing.Size(297, 82);
            this.richTextBoxCancelOrder.TabIndex = 64;
            this.richTextBoxCancelOrder.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(480, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 24);
            this.label3.TabIndex = 63;
            this.label3.Text = "Request Order Cancellation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 66;
            this.label1.Text = "Delivery Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(243, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 24);
            this.label2.TabIndex = 67;
            this.label2.Text = "Payment Method";
            // 
            // dtpDeliveryTime
            // 
            this.dtpDeliveryTime.Location = new System.Drawing.Point(237, 232);
            this.dtpDeliveryTime.Name = "dtpDeliveryTime";
            this.dtpDeliveryTime.Size = new System.Drawing.Size(195, 20);
            this.dtpDeliveryTime.TabIndex = 68;
            // 
            // cbPaymentMethod
            // 
            this.cbPaymentMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPaymentMethod.FormattingEnabled = true;
            this.cbPaymentMethod.Location = new System.Drawing.Point(237, 292);
            this.cbPaymentMethod.Name = "cbPaymentMethod";
            this.cbPaymentMethod.Size = new System.Drawing.Size(195, 21);
            this.cbPaymentMethod.TabIndex = 69;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(235, 24);
            this.label6.TabIndex = 70;
            this.label6.Text = "Customer Order Table";
            // 
            // UserControlOrderNow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbPaymentMethod);
            this.Controls.Add(this.dtpDeliveryTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRequest);
            this.Controls.Add(this.richTextBoxCancelOrder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewOrder);
            this.Controls.Add(this.buttonOrderConfirm);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.lblTotalCost);
            this.Name = "UserControlOrderNow";
            this.Size = new System.Drawing.Size(800, 362);
            this.Load += new System.EventHandler(this.UserControlOrderNow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonOrderConfirm;
        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.Button buttonRequest;
        private System.Windows.Forms.RichTextBox richTextBoxCancelOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDeliveryTime;
        private System.Windows.Forms.ComboBox cbPaymentMethod;
        private System.Windows.Forms.Label label6;
    }
}
