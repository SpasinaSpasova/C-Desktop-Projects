
namespace film
{
    partial class FilmForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilmForm));
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.genreLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.nameLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.yearTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.infpLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.yearLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.submitButton = new DevExpress.XtraEditors.SimpleButton();
            this.FilmPictureBox = new System.Windows.Forms.PictureBox();
            this.sizeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.sizeLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.GenreComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.AddGenreSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.ImageSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.IMDBtextEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.IMDBlabelControl7 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilmPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenreComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMDBtextEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.Location = new System.Drawing.Point(85, 104);
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Size = new System.Drawing.Size(316, 20);
            this.nameTextEdit.TabIndex = 6;
            // 
            // genreLabelControl
            // 
            this.genreLabelControl.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genreLabelControl.Appearance.Options.UseFont = true;
            this.genreLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.genreLabelControl.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.genreLabelControl.Location = new System.Drawing.Point(21, 190);
            this.genreLabelControl.Name = "genreLabelControl";
            this.genreLabelControl.Size = new System.Drawing.Size(58, 27);
            this.genreLabelControl.TabIndex = 5;
            this.genreLabelControl.Text = "Genre:";
            // 
            // nameLabelControl
            // 
            this.nameLabelControl.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabelControl.Appearance.Options.UseFont = true;
            this.nameLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.nameLabelControl.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.nameLabelControl.Location = new System.Drawing.Point(21, 98);
            this.nameLabelControl.Name = "nameLabelControl";
            this.nameLabelControl.Size = new System.Drawing.Size(58, 27);
            this.nameLabelControl.TabIndex = 4;
            this.nameLabelControl.Text = "Name:";
            // 
            // yearTextEdit
            // 
            this.yearTextEdit.Location = new System.Drawing.Point(85, 245);
            this.yearTextEdit.Name = "yearTextEdit";
            this.yearTextEdit.Properties.BeepOnError = false;
            this.yearTextEdit.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.yearTextEdit.Properties.MaskSettings.Set("mask", "d");
            this.yearTextEdit.Size = new System.Drawing.Size(73, 20);
            this.yearTextEdit.TabIndex = 8;
            // 
            // infpLabelControl
            // 
            this.infpLabelControl.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infpLabelControl.Appearance.Options.UseFont = true;
            this.infpLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.infpLabelControl.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.infpLabelControl.Location = new System.Drawing.Point(12, 323);
            this.infpLabelControl.Name = "infpLabelControl";
            this.infpLabelControl.Size = new System.Drawing.Size(102, 27);
            this.infpLabelControl.TabIndex = 9;
            this.infpLabelControl.Text = "Description:";
            // 
            // yearLabelControl
            // 
            this.yearLabelControl.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearLabelControl.Appearance.Options.UseFont = true;
            this.yearLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.yearLabelControl.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.yearLabelControl.Location = new System.Drawing.Point(21, 240);
            this.yearLabelControl.Name = "yearLabelControl";
            this.yearLabelControl.Size = new System.Drawing.Size(58, 27);
            this.yearLabelControl.TabIndex = 8;
            this.yearLabelControl.Text = "Year:";
            // 
            // cancelButton
            // 
            this.cancelButton.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Appearance.Options.UseFont = true;
            this.cancelButton.Location = new System.Drawing.Point(273, 453);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.cancelButton.Size = new System.Drawing.Size(125, 29);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.submitButton.Appearance.Options.UseFont = true;
            this.submitButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.submitButton.Location = new System.Drawing.Point(8, 453);
            this.submitButton.Name = "submitButton";
            this.submitButton.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.submitButton.Size = new System.Drawing.Size(125, 29);
            this.submitButton.TabIndex = 11;
            this.submitButton.Text = "Submit";
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // FilmPictureBox
            // 
            this.FilmPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("FilmPictureBox.Image")));
            this.FilmPictureBox.InitialImage = null;
            this.FilmPictureBox.Location = new System.Drawing.Point(85, 6);
            this.FilmPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FilmPictureBox.Name = "FilmPictureBox";
            this.FilmPictureBox.Size = new System.Drawing.Size(128, 80);
            this.FilmPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FilmPictureBox.TabIndex = 14;
            this.FilmPictureBox.TabStop = false;
            // 
            // sizeTextEdit
            // 
            this.sizeTextEdit.Location = new System.Drawing.Point(85, 292);
            this.sizeTextEdit.Name = "sizeTextEdit";
            this.sizeTextEdit.Properties.BeepOnError = false;
            this.sizeTextEdit.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.sizeTextEdit.Properties.MaskSettings.Set("mask", "n");
            this.sizeTextEdit.Size = new System.Drawing.Size(73, 20);
            this.sizeTextEdit.TabIndex = 9;
            // 
            // sizeLabelControl
            // 
            this.sizeLabelControl.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sizeLabelControl.Appearance.Options.UseFont = true;
            this.sizeLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.sizeLabelControl.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.sizeLabelControl.Location = new System.Drawing.Point(21, 287);
            this.sizeLabelControl.Name = "sizeLabelControl";
            this.sizeLabelControl.Size = new System.Drawing.Size(58, 27);
            this.sizeLabelControl.TabIndex = 15;
            this.sizeLabelControl.Text = "Size:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(10, 103);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(6, 19);
            this.labelControl1.TabIndex = 27;
            this.labelControl1.Text = "*";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(10, 195);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(6, 19);
            this.labelControl2.TabIndex = 28;
            this.labelControl2.Text = "*";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(10, 244);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(6, 19);
            this.labelControl3.TabIndex = 29;
            this.labelControl3.Text = "*";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(10, 292);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(6, 19);
            this.labelControl4.TabIndex = 30;
            this.labelControl4.Text = "*";
            // 
            // GenreComboBoxEdit
            // 
            this.GenreComboBoxEdit.Location = new System.Drawing.Point(85, 197);
            this.GenreComboBoxEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GenreComboBoxEdit.Name = "GenreComboBoxEdit";
            this.GenreComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.GenreComboBoxEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.GenreComboBoxEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GenreComboBoxEdit.Size = new System.Drawing.Size(193, 20);
            this.GenreComboBoxEdit.TabIndex = 7;
            // 
            // AddGenreSimpleButton
            // 
            this.AddGenreSimpleButton.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddGenreSimpleButton.Appearance.Options.UseFont = true;
            this.AddGenreSimpleButton.Location = new System.Drawing.Point(142, 453);
            this.AddGenreSimpleButton.Name = "AddGenreSimpleButton";
            this.AddGenreSimpleButton.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.AddGenreSimpleButton.Size = new System.Drawing.Size(125, 29);
            this.AddGenreSimpleButton.TabIndex = 12;
            this.AddGenreSimpleButton.Text = "Add Genre";
            this.AddGenreSimpleButton.Click += new System.EventHandler(this.AddGenreSimpleButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 356);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(389, 91);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl6.Location = new System.Drawing.Point(164, 287);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(28, 27);
            this.labelControl6.TabIndex = 35;
            this.labelControl6.Text = "GB";
            // 
            // ImageSimpleButton
            // 
            this.ImageSimpleButton.Location = new System.Drawing.Point(222, 37);
            this.ImageSimpleButton.Name = "ImageSimpleButton";
            this.ImageSimpleButton.Size = new System.Drawing.Size(106, 26);
            this.ImageSimpleButton.TabIndex = 36;
            this.ImageSimpleButton.Text = "Add Image";
            this.ImageSimpleButton.Click += new System.EventHandler(this.ImageSimpleButton_Click);
            // 
            // IMDBtextEdit1
            // 
            this.IMDBtextEdit1.Location = new System.Drawing.Point(85, 151);
            this.IMDBtextEdit1.Name = "IMDBtextEdit1";
            this.IMDBtextEdit1.Size = new System.Drawing.Size(316, 20);
            this.IMDBtextEdit1.TabIndex = 38;
            // 
            // IMDBlabelControl7
            // 
            this.IMDBlabelControl7.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IMDBlabelControl7.Appearance.Options.UseFont = true;
            this.IMDBlabelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.IMDBlabelControl7.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.IMDBlabelControl7.Location = new System.Drawing.Point(21, 145);
            this.IMDBlabelControl7.Name = "IMDBlabelControl7";
            this.IMDBlabelControl7.Size = new System.Drawing.Size(58, 27);
            this.IMDBlabelControl7.TabIndex = 37;
            this.IMDBlabelControl7.Text = "IMDB: ";
            // 
            // FilmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 492);
            this.Controls.Add(this.IMDBtextEdit1);
            this.Controls.Add(this.IMDBlabelControl7);
            this.Controls.Add(this.ImageSimpleButton);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.AddGenreSimpleButton);
            this.Controls.Add(this.GenreComboBoxEdit);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.sizeTextEdit);
            this.Controls.Add(this.sizeLabelControl);
            this.Controls.Add(this.FilmPictureBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.yearTextEdit);
            this.Controls.Add(this.infpLabelControl);
            this.Controls.Add(this.yearLabelControl);
            this.Controls.Add(this.nameTextEdit);
            this.Controls.Add(this.genreLabelControl);
            this.Controls.Add(this.nameLabelControl);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("FilmForm.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FilmForm";
            this.Text = "Add Film";
            this.Load += new System.EventHandler(this.FilmForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilmPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenreComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMDBtextEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private DevExpress.XtraEditors.LabelControl genreLabelControl;
        private DevExpress.XtraEditors.LabelControl nameLabelControl;
        private DevExpress.XtraEditors.TextEdit yearTextEdit;
        private DevExpress.XtraEditors.LabelControl infpLabelControl;
        private DevExpress.XtraEditors.LabelControl yearLabelControl;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
        private DevExpress.XtraEditors.SimpleButton submitButton;
        private System.Windows.Forms.PictureBox FilmPictureBox;
        private DevExpress.XtraEditors.TextEdit sizeTextEdit;
        private DevExpress.XtraEditors.LabelControl sizeLabelControl;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit GenreComboBoxEdit;
        private DevExpress.XtraEditors.SimpleButton AddGenreSimpleButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton ImageSimpleButton;
        private DevExpress.XtraEditors.TextEdit IMDBtextEdit1;
        private DevExpress.XtraEditors.LabelControl IMDBlabelControl7;
    }
}