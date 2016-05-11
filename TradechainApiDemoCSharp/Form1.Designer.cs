namespace TradechainApiDemoCSharp
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_cover = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_asset_attachment = new System.Windows.Forms.TextBox();
            this.button_create = new System.Windows.Forms.Button();
            this.textBox_icon = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_shortname = new System.Windows.Forms.TextBox();
            this.textBox_type = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.textBox_image = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown_issue_qty = new System.Windows.Forms.NumericUpDown();
            this.textBox_issue_asset_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_issue = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox_send_addrto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown_send_qty = new System.Windows.Forms.NumericUpDown();
            this.textBox_send_asset_id = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button_send = new System.Windows.Forms.Button();
            this.button_balance = new System.Windows.Forms.Button();
            this.button_txs = new System.Windows.Forms.Button();
            this.button_infos = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.textBox_msg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_apikey = new System.Windows.Forms.TextBox();
            this.textBox_secretkey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_clear = new System.Windows.Forms.Button();
            this.textBox_host = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_definition = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_issue_qty)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_send_qty)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 101);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(683, 356);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBox_cover);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.textBox_asset_attachment);
            this.tabPage1.Controls.Add(this.button_create);
            this.tabPage1.Controls.Add(this.textBox_icon);
            this.tabPage1.Controls.Add(this.textBox_name);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.textBox_shortname);
            this.tabPage1.Controls.Add(this.textBox_type);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.textBox_description);
            this.tabPage1.Controls.Add(this.textBox_image);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(675, 330);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Issue";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 12);
            this.label2.TabIndex = 169;
            this.label2.Text = "Cover Url";
            // 
            // textBox_cover
            // 
            this.textBox_cover.Location = new System.Drawing.Point(278, 201);
            this.textBox_cover.Name = "textBox_cover";
            this.textBox_cover.Size = new System.Drawing.Size(369, 22);
            this.textBox_cover.TabIndex = 168;
            this.textBox_cover.Text = "http://res.web.co/cover/milk789.jpg";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 12);
            this.label5.TabIndex = 167;
            this.label5.Text = "Attachment Url";
            // 
            // textBox_asset_attachment
            // 
            this.textBox_asset_attachment.Location = new System.Drawing.Point(278, 242);
            this.textBox_asset_attachment.Name = "textBox_asset_attachment";
            this.textBox_asset_attachment.Size = new System.Drawing.Size(369, 22);
            this.textBox_asset_attachment.TabIndex = 166;
            // 
            // button_create
            // 
            this.button_create.Location = new System.Drawing.Point(18, 288);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(75, 23);
            this.button_create.TabIndex = 158;
            this.button_create.Text = "Create";
            this.button_create.UseVisualStyleBackColor = true;
            this.button_create.Click += new System.EventHandler(this.button_create_Click);
            // 
            // textBox_icon
            // 
            this.textBox_icon.Location = new System.Drawing.Point(278, 139);
            this.textBox_icon.Name = "textBox_icon";
            this.textBox_icon.Size = new System.Drawing.Size(369, 22);
            this.textBox_icon.TabIndex = 148;
            this.textBox_icon.Text = "http://res.web.co/icon/milk123.jpg";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(71, 25);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 22);
            this.textBox_name.TabIndex = 140;
            this.textBox_name.Text = "Milk CNS3055";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(33, 91);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(29, 12);
            this.label22.TabIndex = 155;
            this.label22.Text = "Type";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(33, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 12);
            this.label14.TabIndex = 141;
            this.label14.Text = "Name";
            // 
            // textBox_shortname
            // 
            this.textBox_shortname.Location = new System.Drawing.Point(99, 55);
            this.textBox_shortname.Name = "textBox_shortname";
            this.textBox_shortname.Size = new System.Drawing.Size(72, 22);
            this.textBox_shortname.TabIndex = 142;
            this.textBox_shortname.Text = "MILKCERT";
            // 
            // textBox_type
            // 
            this.textBox_type.Location = new System.Drawing.Point(99, 85);
            this.textBox_type.Name = "textBox_type";
            this.textBox_type.Size = new System.Drawing.Size(72, 22);
            this.textBox_type.TabIndex = 154;
            this.textBox_type.Text = "Certificate";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(33, 61);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 12);
            this.label15.TabIndex = 143;
            this.label15.Text = "Short Name";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(210, 173);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(52, 12);
            this.label19.TabIndex = 151;
            this.label19.Text = "Image Url";
            // 
            // textBox_description
            // 
            this.textBox_description.Location = new System.Drawing.Point(278, 25);
            this.textBox_description.Multiline = true;
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.Size = new System.Drawing.Size(369, 103);
            this.textBox_description.TabIndex = 146;
            this.textBox_description.Text = "GMP certification";
            // 
            // textBox_image
            // 
            this.textBox_image.Location = new System.Drawing.Point(278, 170);
            this.textBox_image.Name = "textBox_image";
            this.textBox_image.Size = new System.Drawing.Size(369, 22);
            this.textBox_image.TabIndex = 150;
            this.textBox_image.Text = "http://res.web.co/image/milk456.jpg";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(204, 31);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 12);
            this.label17.TabIndex = 147;
            this.label17.Text = "Description";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(218, 142);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 12);
            this.label18.TabIndex = 149;
            this.label18.Text = "Icon Url";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.numericUpDown_issue_qty);
            this.tabPage2.Controls.Add(this.textBox_issue_asset_id);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.button_issue);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(675, 330);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Issue";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 12);
            this.label7.TabIndex = 167;
            this.label7.Text = "Quantity :";
            // 
            // numericUpDown_issue_qty
            // 
            this.numericUpDown_issue_qty.Location = new System.Drawing.Point(93, 85);
            this.numericUpDown_issue_qty.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numericUpDown_issue_qty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_issue_qty.Name = "numericUpDown_issue_qty";
            this.numericUpDown_issue_qty.Size = new System.Drawing.Size(137, 22);
            this.numericUpDown_issue_qty.TabIndex = 166;
            this.numericUpDown_issue_qty.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // textBox_issue_asset_id
            // 
            this.textBox_issue_asset_id.Location = new System.Drawing.Point(93, 40);
            this.textBox_issue_asset_id.Name = "textBox_issue_asset_id";
            this.textBox_issue_asset_id.Size = new System.Drawing.Size(271, 22);
            this.textBox_issue_asset_id.TabIndex = 165;
            this.textBox_issue_asset_id.Text = "AGFBVor9wDFWQro7WC4rWdPNCUmVppfeU5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 12);
            this.label6.TabIndex = 164;
            this.label6.Text = "Asset Id :";
            // 
            // button_issue
            // 
            this.button_issue.Location = new System.Drawing.Point(36, 145);
            this.button_issue.Name = "button_issue";
            this.button_issue.Size = new System.Drawing.Size(75, 23);
            this.button_issue.TabIndex = 159;
            this.button_issue.Text = "Issue";
            this.button_issue.UseVisualStyleBackColor = true;
            this.button_issue.Click += new System.EventHandler(this.button_issue_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox_send_addrto);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.numericUpDown_send_qty);
            this.tabPage3.Controls.Add(this.textBox_send_asset_id);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.button_send);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(675, 330);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Send";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox_send_addrto
            // 
            this.textBox_send_addrto.Location = new System.Drawing.Point(94, 79);
            this.textBox_send_addrto.Name = "textBox_send_addrto";
            this.textBox_send_addrto.Size = new System.Drawing.Size(271, 22);
            this.textBox_send_addrto.TabIndex = 173;
            this.textBox_send_addrto.Text = "XwcaQCGsiqKRjbFq4MGnHaougjNfAhqoW5";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 12);
            this.label10.TabIndex = 172;
            this.label10.Text = "Address To :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 12);
            this.label8.TabIndex = 171;
            this.label8.Text = "Quantity :";
            // 
            // numericUpDown_send_qty
            // 
            this.numericUpDown_send_qty.Location = new System.Drawing.Point(94, 126);
            this.numericUpDown_send_qty.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numericUpDown_send_qty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_send_qty.Name = "numericUpDown_send_qty";
            this.numericUpDown_send_qty.Size = new System.Drawing.Size(137, 22);
            this.numericUpDown_send_qty.TabIndex = 170;
            this.numericUpDown_send_qty.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // textBox_send_asset_id
            // 
            this.textBox_send_asset_id.Location = new System.Drawing.Point(94, 37);
            this.textBox_send_asset_id.Name = "textBox_send_asset_id";
            this.textBox_send_asset_id.Size = new System.Drawing.Size(271, 22);
            this.textBox_send_asset_id.TabIndex = 169;
            this.textBox_send_asset_id.Text = "AGFBVor9wDFWQro7WC4rWdPNCUmVppfeU5";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 12);
            this.label9.TabIndex = 168;
            this.label9.Text = "Asset Id :";
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(37, 194);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(75, 23);
            this.button_send.TabIndex = 159;
            this.button_send.Text = "Send";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // button_balance
            // 
            this.button_balance.Location = new System.Drawing.Point(334, 472);
            this.button_balance.Name = "button_balance";
            this.button_balance.Size = new System.Drawing.Size(120, 23);
            this.button_balance.TabIndex = 172;
            this.button_balance.Text = "Get balance";
            this.button_balance.UseVisualStyleBackColor = true;
            this.button_balance.Click += new System.EventHandler(this.button_balance_Click);
            // 
            // button_txs
            // 
            this.button_txs.Location = new System.Drawing.Point(177, 472);
            this.button_txs.Name = "button_txs";
            this.button_txs.Size = new System.Drawing.Size(132, 23);
            this.button_txs.TabIndex = 171;
            this.button_txs.Text = "Get Transactions";
            this.button_txs.UseVisualStyleBackColor = true;
            this.button_txs.Click += new System.EventHandler(this.button_txs_Click);
            // 
            // button_infos
            // 
            this.button_infos.Location = new System.Drawing.Point(34, 472);
            this.button_infos.Name = "button_infos";
            this.button_infos.Size = new System.Drawing.Size(109, 23);
            this.button_infos.TabIndex = 170;
            this.button_infos.Text = "Get Assets Info";
            this.button_infos.UseVisualStyleBackColor = true;
            this.button_infos.Click += new System.EventHandler(this.button_infos_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(616, 631);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 160;
            this.button_cancel.Text = "Exit";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // textBox_msg
            // 
            this.textBox_msg.BackColor = System.Drawing.Color.White;
            this.textBox_msg.Location = new System.Drawing.Point(17, 514);
            this.textBox_msg.MaxLength = 327670;
            this.textBox_msg.Multiline = true;
            this.textBox_msg.Name = "textBox_msg";
            this.textBox_msg.ReadOnly = true;
            this.textBox_msg.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_msg.Size = new System.Drawing.Size(679, 105);
            this.textBox_msg.TabIndex = 161;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 12);
            this.label3.TabIndex = 162;
            this.label3.Text = "Api Key :";
            // 
            // textBox_apikey
            // 
            this.textBox_apikey.Location = new System.Drawing.Point(74, 58);
            this.textBox_apikey.Name = "textBox_apikey";
            this.textBox_apikey.Size = new System.Drawing.Size(235, 22);
            this.textBox_apikey.TabIndex = 163;
            this.textBox_apikey.Text = "9YONzcXtQleb873ydecRW3tdTogCEihe";
            // 
            // textBox_secretkey
            // 
            this.textBox_secretkey.Location = new System.Drawing.Point(418, 58);
            this.textBox_secretkey.Name = "textBox_secretkey";
            this.textBox_secretkey.Size = new System.Drawing.Size(235, 22);
            this.textBox_secretkey.TabIndex = 165;
            this.textBox_secretkey.Text = "FlwGeV1A0a4vQxAOS1LataBoLTBvioX7";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 12);
            this.label4.TabIndex = 164;
            this.label4.Text = "Secret Key :";
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(525, 631);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(75, 23);
            this.button_clear.TabIndex = 166;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // textBox_host
            // 
            this.textBox_host.Location = new System.Drawing.Point(74, 21);
            this.textBox_host.Name = "textBox_host";
            this.textBox_host.Size = new System.Drawing.Size(235, 22);
            this.textBox_host.TabIndex = 168;
            this.textBox_host.Text = "https://apitest.dtco.co";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 12);
            this.label1.TabIndex = 167;
            this.label1.Text = "Host :";
            // 
            // button_definition
            // 
            this.button_definition.Location = new System.Drawing.Point(480, 472);
            this.button_definition.Name = "button_definition";
            this.button_definition.Size = new System.Drawing.Size(120, 23);
            this.button_definition.TabIndex = 173;
            this.button_definition.Text = "Get Definition";
            this.button_definition.UseVisualStyleBackColor = true;
            this.button_definition.Click += new System.EventHandler(this.button_definition_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 661);
            this.Controls.Add(this.button_definition);
            this.Controls.Add(this.button_balance);
            this.Controls.Add(this.button_txs);
            this.Controls.Add(this.textBox_host);
            this.Controls.Add(this.button_infos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.textBox_secretkey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_apikey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_msg);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button_cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Api Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_issue_qty)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_send_qty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_cover;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_asset_attachment;
        private System.Windows.Forms.Button button_create;
        private System.Windows.Forms.TextBox textBox_icon;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox_shortname;
        private System.Windows.Forms.TextBox textBox_type;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox_description;
        private System.Windows.Forms.TextBox textBox_image;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_issue;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.TextBox textBox_msg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_apikey;
        private System.Windows.Forms.TextBox textBox_secretkey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_infos;
        private System.Windows.Forms.TextBox textBox_host;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_txs;
        private System.Windows.Forms.Button button_balance;
        private System.Windows.Forms.TextBox textBox_issue_asset_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown_issue_qty;
        private System.Windows.Forms.TextBox textBox_send_addrto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown_send_qty;
        private System.Windows.Forms.TextBox textBox_send_asset_id;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_definition;
    }
}

