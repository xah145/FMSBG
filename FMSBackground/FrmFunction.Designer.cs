namespace FMSBackground
{
    partial class FrmFunction
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tvFunction = new System.Windows.Forms.TreeView();
            this.gbDetail = new System.Windows.Forms.GroupBox();
            this.authBtnEdit = new FMSBackground.Control.AuthButton();
            this.authBtnDelete = new FMSBackground.Control.AuthButton();
            this.authBtnAdd = new FMSBackground.Control.AuthButton();
            this.lblError2 = new System.Windows.Forms.Label();
            this.lblError1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cboFunction = new System.Windows.Forms.ComboBox();
            this.txtFunctionControl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFunctionName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pnlAction = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.gbDetail.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.pnlAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.tvFunction);
            this.groupBox1.Location = new System.Drawing.Point(13, 48);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(343, 646);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "功能列表";
            // 
            // tvFunction
            // 
            this.tvFunction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvFunction.HideSelection = false;
            this.tvFunction.Location = new System.Drawing.Point(4, 22);
            this.tvFunction.Margin = new System.Windows.Forms.Padding(4);
            this.tvFunction.Name = "tvFunction";
            this.tvFunction.Size = new System.Drawing.Size(335, 620);
            this.tvFunction.TabIndex = 0;
    
            this.tvFunction.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvFunction_NodeMouseClick);
            // 
            // gbDetail
            // 
            this.gbDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDetail.Controls.Add(this.lblError2);
            this.gbDetail.Controls.Add(this.lblError1);
            this.gbDetail.Controls.Add(this.btnCancel);
            this.gbDetail.Controls.Add(this.btnSave);
            this.gbDetail.Controls.Add(this.cboFunction);
            this.gbDetail.Controls.Add(this.txtFunctionControl);
            this.gbDetail.Controls.Add(this.label3);
            this.gbDetail.Controls.Add(this.label2);
            this.gbDetail.Controls.Add(this.txtFunctionName);
            this.gbDetail.Controls.Add(this.label1);
            this.gbDetail.Enabled = false;
            this.gbDetail.Location = new System.Drawing.Point(364, 48);
            this.gbDetail.Margin = new System.Windows.Forms.Padding(4);
            this.gbDetail.Name = "gbDetail";
            this.gbDetail.Padding = new System.Windows.Forms.Padding(4);
            this.gbDetail.Size = new System.Drawing.Size(393, 642);
            this.gbDetail.TabIndex = 5;
            this.gbDetail.TabStop = false;
            this.gbDetail.Text = "功能详细信息";
            // 
            // authBtnEdit
            // 
            this.authBtnEdit.Location = new System.Drawing.Point(189, 3);
            this.authBtnEdit.Name = "authBtnEdit";
            this.authBtnEdit.Size = new System.Drawing.Size(75, 39);
            this.authBtnEdit.TabIndex = 19;
            this.authBtnEdit.Tag = "User/Edit";
            this.authBtnEdit.Text = "编辑";
            this.authBtnEdit.UseVisualStyleBackColor = true;
            this.authBtnEdit.Click += new FMSBackground.Control.AuthEventHandler(this.authBtnEdit_Click);
            // 
            // authBtnDelete
            // 
            this.authBtnDelete.Location = new System.Drawing.Point(93, 3);
            this.authBtnDelete.Name = "authBtnDelete";
            this.authBtnDelete.Size = new System.Drawing.Size(75, 39);
            this.authBtnDelete.TabIndex = 18;
            this.authBtnDelete.Tag = "User/Delete";
            this.authBtnDelete.Text = "删除";
            this.authBtnDelete.UseVisualStyleBackColor = true;
            this.authBtnDelete.Click += new FMSBackground.Control.AuthEventHandler(this.authBtnDelete_Click);
            // 
            // authBtnAdd
            // 
            this.authBtnAdd.Location = new System.Drawing.Point(0, 3);
            this.authBtnAdd.Name = "authBtnAdd";
            this.authBtnAdd.Size = new System.Drawing.Size(75, 39);
            this.authBtnAdd.TabIndex = 17;
            this.authBtnAdd.Tag = "User/Add";
            this.authBtnAdd.Text = "添加";
            this.authBtnAdd.UseVisualStyleBackColor = true;
            this.authBtnAdd.Click += new FMSBackground.Control.AuthEventHandler(this.authBtnAdd_Click);
            // 
            // lblError2
            // 
            this.lblError2.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblError2.ForeColor = System.Drawing.Color.Red;
            this.lblError2.Location = new System.Drawing.Point(147, 151);
            this.lblError2.Name = "lblError2";
            this.lblError2.Size = new System.Drawing.Size(251, 23);
            this.lblError2.TabIndex = 14;
            // 
            // lblError1
            // 
            this.lblError1.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblError1.ForeColor = System.Drawing.Color.Red;
            this.lblError1.Location = new System.Drawing.Point(152, 53);
            this.lblError1.Name = "lblError1";
            this.lblError1.Size = new System.Drawing.Size(225, 23);
            this.lblError1.TabIndex = 13;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(280, 189);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 32);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = " 放弃";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(200, 189);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 32);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cboFunction
            // 
            this.cboFunction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboFunction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFunction.FormattingEnabled = true;
            this.cboFunction.Location = new System.Drawing.Point(145, 74);
            this.cboFunction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboFunction.Name = "cboFunction";
            this.cboFunction.Size = new System.Drawing.Size(208, 23);
            this.cboFunction.TabIndex = 6;
            // 
            // txtFunctionControl
            // 
            this.txtFunctionControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFunctionControl.Location = new System.Drawing.Point(145, 122);
            this.txtFunctionControl.Margin = new System.Windows.Forms.Padding(4);
            this.txtFunctionControl.Name = "txtFunctionControl";
            this.txtFunctionControl.Size = new System.Drawing.Size(208, 25);
            this.txtFunctionControl.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "功能控件ID(*):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "上层管理(*):";
            // 
            // txtFunctionName
            // 
            this.txtFunctionName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFunctionName.Location = new System.Drawing.Point(145, 24);
            this.txtFunctionName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFunctionName.Name = "txtFunctionName";
            this.txtFunctionName.Size = new System.Drawing.Size(208, 25);
            this.txtFunctionName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "功能名称(*):";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Location = new System.Drawing.Point(769, 48);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(277, 646);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "课操作的角色";
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(4, 22);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(269, 620);
            this.listBox1.TabIndex = 0;
            // 
            // pnlAction
            // 
            this.pnlAction.Controls.Add(this.authBtnEdit);
            this.pnlAction.Controls.Add(this.authBtnAdd);
            this.pnlAction.Controls.Add(this.authBtnDelete);
            this.pnlAction.Location = new System.Drawing.Point(8, 0);
            this.pnlAction.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAction.Name = "pnlAction";
            this.pnlAction.Size = new System.Drawing.Size(324, 45);
            this.pnlAction.TabIndex = 8;
            // 
            // FrmFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 701);
            this.Controls.Add(this.pnlAction);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbDetail);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmFunction";
            this.TabText = "功能管理";
            this.Text = "功能管理";
            this.Load += new System.EventHandler(this.FrmFunction_Load);
            this.groupBox1.ResumeLayout(false);
            this.gbDetail.ResumeLayout(false);
            this.gbDetail.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.pnlAction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView tvFunction;
        private System.Windows.Forms.GroupBox gbDetail;
        private System.Windows.Forms.ComboBox cboFunction;
        private System.Windows.Forms.TextBox txtFunctionControl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFunctionName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlAction;
        private System.Windows.Forms.Label lblError1;
        private System.Windows.Forms.Label lblError2;
        private Control.AuthButton authBtnAdd;
        private Control.AuthButton authBtnDelete;
        private Control.AuthButton authBtnEdit;
    }
}