
namespace MyDrive
{
    partial class frmEstimate
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
            this.grpMaterials = new System.Windows.Forms.GroupBox();
            this.rdoGravel = new System.Windows.Forms.RadioButton();
            this.rdoTarmac = new System.Windows.Forms.RadioButton();
            this.rdoConcrete = new System.Windows.Forms.RadioButton();
            this.rdoBrick = new System.Windows.Forms.RadioButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpFoundations = new System.Windows.Forms.GroupBox();
            this.rdoExtrDeep = new System.Windows.Forms.RadioButton();
            this.rdoStandard = new System.Windows.Forms.RadioButton();
            this.lblExcahangeRate = new System.Windows.Forms.Label();
            this.txtExchangeRate = new System.Windows.Forms.TextBox();
            this.lblEuroTop = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtBrick = new System.Windows.Forms.TextBox();
            this.txtConcrete = new System.Windows.Forms.TextBox();
            this.txtTarmac = new System.Windows.Forms.TextBox();
            this.txtGravel = new System.Windows.Forms.TextBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.lblMetresLength = new System.Windows.Forms.Label();
            this.lblMetresWidth = new System.Windows.Forms.Label();
            this.lblGBP = new System.Windows.Forms.Label();
            this.txtGBP = new System.Windows.Forms.TextBox();
            this.txtEuro = new System.Windows.Forms.TextBox();
            this.lblEuroBottom = new System.Windows.Forms.Label();
            this.cmdStart = new System.Windows.Forms.Button();
            this.cmdCalculate = new System.Windows.Forms.Button();
            this.cmdClear = new System.Windows.Forms.Button();
            this.lblOutPut = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.miFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.grpMaterials.SuspendLayout();
            this.grpFoundations.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMaterials
            // 
            this.grpMaterials.Controls.Add(this.rdoGravel);
            this.grpMaterials.Controls.Add(this.rdoTarmac);
            this.grpMaterials.Controls.Add(this.rdoConcrete);
            this.grpMaterials.Controls.Add(this.rdoBrick);
            this.grpMaterials.Location = new System.Drawing.Point(54, 163);
            this.grpMaterials.Name = "grpMaterials";
            this.grpMaterials.Size = new System.Drawing.Size(300, 179);
            this.grpMaterials.TabIndex = 0;
            this.grpMaterials.TabStop = false;
            this.grpMaterials.Text = "Materials";
            // 
            // rdoGravel
            // 
            this.rdoGravel.AutoSize = true;
            this.rdoGravel.Location = new System.Drawing.Point(60, 144);
            this.rdoGravel.Name = "rdoGravel";
            this.rdoGravel.Size = new System.Drawing.Size(99, 29);
            this.rdoGravel.TabIndex = 3;
            this.rdoGravel.TabStop = true;
            this.rdoGravel.Text = "GRAVEL";
            this.rdoGravel.UseVisualStyleBackColor = true;
            // 
            // rdoTarmac
            // 
            this.rdoTarmac.AutoSize = true;
            this.rdoTarmac.Location = new System.Drawing.Point(60, 109);
            this.rdoTarmac.Name = "rdoTarmac";
            this.rdoTarmac.Size = new System.Drawing.Size(107, 29);
            this.rdoTarmac.TabIndex = 2;
            this.rdoTarmac.TabStop = true;
            this.rdoTarmac.Text = "TARMAC";
            this.rdoTarmac.UseVisualStyleBackColor = true;
            // 
            // rdoConcrete
            // 
            this.rdoConcrete.AutoSize = true;
            this.rdoConcrete.Location = new System.Drawing.Point(60, 74);
            this.rdoConcrete.Name = "rdoConcrete";
            this.rdoConcrete.Size = new System.Drawing.Size(124, 29);
            this.rdoConcrete.TabIndex = 1;
            this.rdoConcrete.TabStop = true;
            this.rdoConcrete.Text = "CONCRETE";
            this.rdoConcrete.UseVisualStyleBackColor = true;
            // 
            // rdoBrick
            // 
            this.rdoBrick.AutoSize = true;
            this.rdoBrick.Location = new System.Drawing.Point(60, 39);
            this.rdoBrick.Name = "rdoBrick";
            this.rdoBrick.Size = new System.Drawing.Size(84, 29);
            this.rdoBrick.TabIndex = 0;
            this.rdoBrick.TabStop = true;
            this.rdoBrick.Text = "BRICK";
            this.rdoBrick.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(240, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(548, 56);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Euro Drives or Patios";
            // 
            // grpFoundations
            // 
            this.grpFoundations.Controls.Add(this.rdoExtrDeep);
            this.grpFoundations.Controls.Add(this.rdoStandard);
            this.grpFoundations.Location = new System.Drawing.Point(704, 163);
            this.grpFoundations.Name = "grpFoundations";
            this.grpFoundations.Size = new System.Drawing.Size(300, 129);
            this.grpFoundations.TabIndex = 1;
            this.grpFoundations.TabStop = false;
            this.grpFoundations.Text = "Foundations";
            // 
            // rdoExtrDeep
            // 
            this.rdoExtrDeep.AutoSize = true;
            this.rdoExtrDeep.Location = new System.Drawing.Point(64, 76);
            this.rdoExtrDeep.Name = "rdoExtrDeep";
            this.rdoExtrDeep.Size = new System.Drawing.Size(135, 29);
            this.rdoExtrDeep.TabIndex = 5;
            this.rdoExtrDeep.TabStop = true;
            this.rdoExtrDeep.Text = "EXTRA DEEP";
            this.rdoExtrDeep.UseVisualStyleBackColor = true;
            // 
            // rdoStandard
            // 
            this.rdoStandard.AutoSize = true;
            this.rdoStandard.Location = new System.Drawing.Point(64, 39);
            this.rdoStandard.Name = "rdoStandard";
            this.rdoStandard.Size = new System.Drawing.Size(129, 29);
            this.rdoStandard.TabIndex = 4;
            this.rdoStandard.TabStop = true;
            this.rdoStandard.Text = "STANDARD";
            this.rdoStandard.UseVisualStyleBackColor = true;
            // 
            // lblExcahangeRate
            // 
            this.lblExcahangeRate.AutoSize = true;
            this.lblExcahangeRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblExcahangeRate.Location = new System.Drawing.Point(94, 93);
            this.lblExcahangeRate.Name = "lblExcahangeRate";
            this.lblExcahangeRate.Size = new System.Drawing.Size(230, 22);
            this.lblExcahangeRate.TabIndex = 0;
            this.lblExcahangeRate.Text = "EXCHANGE RATE: £1 =";
            // 
            // txtExchangeRate
            // 
            this.txtExchangeRate.Location = new System.Drawing.Point(360, 88);
            this.txtExchangeRate.Name = "txtExchangeRate";
            this.txtExchangeRate.Size = new System.Drawing.Size(97, 31);
            this.txtExchangeRate.TabIndex = 2;
            this.txtExchangeRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtExchangeRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressEnterTxtFields);
            this.txtExchangeRate.Leave += new System.EventHandler(this.LeaveTxtField);
            // 
            // lblEuroTop
            // 
            this.lblEuroTop.AutoSize = true;
            this.lblEuroTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEuroTop.Location = new System.Drawing.Point(486, 93);
            this.lblEuroTop.Name = "lblEuroTop";
            this.lblEuroTop.Size = new System.Drawing.Size(79, 22);
            this.lblEuroTop.TabIndex = 3;
            this.lblEuroTop.Text = "EUROS";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrice.Location = new System.Drawing.Point(384, 163);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(277, 22);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "PRICE PER SQUARE METER";
            // 
            // txtBrick
            // 
            this.txtBrick.Location = new System.Drawing.Point(399, 200);
            this.txtBrick.Name = "txtBrick";
            this.txtBrick.Size = new System.Drawing.Size(241, 31);
            this.txtBrick.TabIndex = 5;
            this.txtBrick.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBrick.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressEnterTxtFields);
            this.txtBrick.Leave += new System.EventHandler(this.LeaveTxtField);
            // 
            // txtConcrete
            // 
            this.txtConcrete.Location = new System.Drawing.Point(399, 237);
            this.txtConcrete.Name = "txtConcrete";
            this.txtConcrete.Size = new System.Drawing.Size(241, 31);
            this.txtConcrete.TabIndex = 6;
            this.txtConcrete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtConcrete.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressEnterTxtFields);
            this.txtConcrete.Leave += new System.EventHandler(this.LeaveTxtField);
            // 
            // txtTarmac
            // 
            this.txtTarmac.Location = new System.Drawing.Point(399, 274);
            this.txtTarmac.Name = "txtTarmac";
            this.txtTarmac.Size = new System.Drawing.Size(241, 31);
            this.txtTarmac.TabIndex = 7;
            this.txtTarmac.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTarmac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressEnterTxtFields);
            this.txtTarmac.Leave += new System.EventHandler(this.LeaveTxtField);
            // 
            // txtGravel
            // 
            this.txtGravel.Location = new System.Drawing.Point(399, 311);
            this.txtGravel.Name = "txtGravel";
            this.txtGravel.Size = new System.Drawing.Size(241, 31);
            this.txtGravel.TabIndex = 8;
            this.txtGravel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtGravel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressEnterTxtFields);
            this.txtGravel.Leave += new System.EventHandler(this.LeaveTxtField);
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLength.Location = new System.Drawing.Point(360, 409);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(90, 22);
            this.lblLength.TabIndex = 9;
            this.lblLength.Text = "LENGTH";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWidth.Location = new System.Drawing.Point(360, 459);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(74, 22);
            this.lblWidth.TabIndex = 10;
            this.lblWidth.Text = "WIDTH";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(486, 404);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(133, 31);
            this.txtLength.TabIndex = 11;
            this.txtLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressEnterTxtFields);
            this.txtLength.Leave += new System.EventHandler(this.LeaveTxtField);
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(486, 454);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(133, 31);
            this.txtWidth.TabIndex = 12;
            this.txtWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressEnterTxtFields);
            this.txtWidth.Leave += new System.EventHandler(this.LeaveTxtField);
            // 
            // lblMetresLength
            // 
            this.lblMetresLength.AutoSize = true;
            this.lblMetresLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetresLength.Location = new System.Drawing.Point(655, 409);
            this.lblMetresLength.Name = "lblMetresLength";
            this.lblMetresLength.Size = new System.Drawing.Size(91, 22);
            this.lblMetresLength.TabIndex = 13;
            this.lblMetresLength.Text = "METRES";
            // 
            // lblMetresWidth
            // 
            this.lblMetresWidth.AutoSize = true;
            this.lblMetresWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetresWidth.Location = new System.Drawing.Point(655, 459);
            this.lblMetresWidth.Name = "lblMetresWidth";
            this.lblMetresWidth.Size = new System.Drawing.Size(91, 22);
            this.lblMetresWidth.TabIndex = 14;
            this.lblMetresWidth.Text = "METRES";
            // 
            // lblGBP
            // 
            this.lblGBP.AutoSize = true;
            this.lblGBP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGBP.Location = new System.Drawing.Point(273, 536);
            this.lblGBP.Name = "lblGBP";
            this.lblGBP.Size = new System.Drawing.Size(51, 22);
            this.lblGBP.TabIndex = 15;
            this.lblGBP.Text = "GBP";
            // 
            // txtGBP
            // 
            this.txtGBP.Enabled = false;
            this.txtGBP.Location = new System.Drawing.Point(340, 531);
            this.txtGBP.Name = "txtGBP";
            this.txtGBP.Size = new System.Drawing.Size(133, 31);
            this.txtGBP.TabIndex = 16;
            this.txtGBP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtEuro
            // 
            this.txtEuro.Enabled = false;
            this.txtEuro.Location = new System.Drawing.Point(635, 526);
            this.txtEuro.Name = "txtEuro";
            this.txtEuro.Size = new System.Drawing.Size(133, 31);
            this.txtEuro.TabIndex = 18;
            this.txtEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblEuroBottom
            // 
            this.lblEuroBottom.AutoSize = true;
            this.lblEuroBottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEuroBottom.Location = new System.Drawing.Point(568, 531);
            this.lblEuroBottom.Name = "lblEuroBottom";
            this.lblEuroBottom.Size = new System.Drawing.Size(66, 22);
            this.lblEuroBottom.TabIndex = 17;
            this.lblEuroBottom.Text = "EURO";
            // 
            // cmdStart
            // 
            this.cmdStart.Location = new System.Drawing.Point(464, 678);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(115, 32);
            this.cmdStart.TabIndex = 20;
            this.cmdStart.Text = "START";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cmdCalculate
            // 
            this.cmdCalculate.Location = new System.Drawing.Point(343, 678);
            this.cmdCalculate.Name = "cmdCalculate";
            this.cmdCalculate.Size = new System.Drawing.Size(115, 32);
            this.cmdCalculate.TabIndex = 21;
            this.cmdCalculate.Text = "CALCULATE";
            this.cmdCalculate.UseVisualStyleBackColor = true;
            this.cmdCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // cmdClear
            // 
            this.cmdClear.Location = new System.Drawing.Point(585, 678);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(115, 32);
            this.cmdClear.TabIndex = 22;
            this.cmdClear.Text = "CLEAR";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblOutPut
            // 
            this.lblOutPut.AutoSize = true;
            this.lblOutPut.BackColor = System.Drawing.Color.White;
            this.lblOutPut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOutPut.ForeColor = System.Drawing.Color.Black;
            this.lblOutPut.Location = new System.Drawing.Point(273, 598);
            this.lblOutPut.MinimumSize = new System.Drawing.Size(500, 0);
            this.lblOutPut.Name = "lblOutPut";
            this.lblOutPut.Size = new System.Drawing.Size(500, 22);
            this.lblOutPut.TabIndex = 23;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1082, 33);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // miFile
            // 
            this.miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miExit});
            this.miFile.Name = "miFile";
            this.miFile.Size = new System.Drawing.Size(54, 29);
            this.miFile.Text = "File";
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(141, 34);
            this.miExit.Text = "Exit";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // frmEstimate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 754);
            this.Controls.Add(this.lblOutPut);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.cmdCalculate);
            this.Controls.Add(this.cmdStart);
            this.Controls.Add(this.txtEuro);
            this.Controls.Add(this.lblEuroBottom);
            this.Controls.Add(this.txtGBP);
            this.Controls.Add(this.lblGBP);
            this.Controls.Add(this.lblMetresWidth);
            this.Controls.Add(this.lblMetresLength);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.txtGravel);
            this.Controls.Add(this.txtTarmac);
            this.Controls.Add(this.txtConcrete);
            this.Controls.Add(this.txtBrick);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblEuroTop);
            this.Controls.Add(this.txtExchangeRate);
            this.Controls.Add(this.lblExcahangeRate);
            this.Controls.Add(this.grpFoundations);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpMaterials);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmEstimate";
            this.Text = "Form1";
            this.grpMaterials.ResumeLayout(false);
            this.grpMaterials.PerformLayout();
            this.grpFoundations.ResumeLayout(false);
            this.grpFoundations.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMaterials;
        private System.Windows.Forms.RadioButton rdoGravel;
        private System.Windows.Forms.RadioButton rdoTarmac;
        private System.Windows.Forms.RadioButton rdoConcrete;
        private System.Windows.Forms.RadioButton rdoBrick;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpFoundations;
        private System.Windows.Forms.RadioButton rdoExtrDeep;
        private System.Windows.Forms.RadioButton rdoStandard;
        private System.Windows.Forms.Label lblExcahangeRate;
        private System.Windows.Forms.TextBox txtExchangeRate;
        private System.Windows.Forms.Label lblEuroTop;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtBrick;
        private System.Windows.Forms.TextBox txtConcrete;
        private System.Windows.Forms.TextBox txtTarmac;
        private System.Windows.Forms.TextBox txtGravel;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label lblMetresLength;
        private System.Windows.Forms.Label lblMetresWidth;
        private System.Windows.Forms.Label lblGBP;
        private System.Windows.Forms.TextBox txtGBP;
        private System.Windows.Forms.TextBox txtEuro;
        private System.Windows.Forms.Label lblEuroBottom;
        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.Button cmdCalculate;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.Label lblOutPut;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miFile;
        private System.Windows.Forms.ToolStripMenuItem miExit;
    }
}

