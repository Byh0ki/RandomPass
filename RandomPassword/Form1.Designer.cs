namespace RandomPassword
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_title = new System.Windows.Forms.Label();
            this.checkBox_number = new System.Windows.Forms.CheckBox();
            this.checkBox_lowercase = new System.Windows.Forms.CheckBox();
            this.checkbox_uppercase = new System.Windows.Forms.CheckBox();
            this.checkBox_special = new System.Windows.Forms.CheckBox();
            this.checkBox_noSimilar = new System.Windows.Forms.CheckBox();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_nbPass = new System.Windows.Forms.NumericUpDown();
            this.button_generate = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_nbPass)).BeginInit();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(12, 38);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(536, 38);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Générateur de mot de passe aléatoire";
            // 
            // checkBox_number
            // 
            this.checkBox_number.AutoSize = true;
            this.checkBox_number.Checked = true;
            this.checkBox_number.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_number.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_number.Location = new System.Drawing.Point(36, 114);
            this.checkBox_number.Name = "checkBox_number";
            this.checkBox_number.Size = new System.Drawing.Size(259, 20);
            this.checkBox_number.TabIndex = 1;
            this.checkBox_number.Text = "Avec des chiffres [ 0 1 2 3 4 5 6 7 8 9 ]";
            this.checkBox_number.UseVisualStyleBackColor = true;
            // 
            // checkBox_lowercase
            // 
            this.checkBox_lowercase.AutoSize = true;
            this.checkBox_lowercase.Checked = true;
            this.checkBox_lowercase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_lowercase.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_lowercase.Location = new System.Drawing.Point(36, 150);
            this.checkBox_lowercase.Name = "checkBox_lowercase";
            this.checkBox_lowercase.Size = new System.Drawing.Size(341, 20);
            this.checkBox_lowercase.TabIndex = 2;
            this.checkBox_lowercase.Text = "Avec des lettres minuscules [ a b c d e f g h ... x y z ]";
            this.checkBox_lowercase.UseVisualStyleBackColor = true;
            // 
            // checkbox_uppercase
            // 
            this.checkbox_uppercase.AutoSize = true;
            this.checkbox_uppercase.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox_uppercase.Location = new System.Drawing.Point(36, 185);
            this.checkbox_uppercase.Name = "checkbox_uppercase";
            this.checkbox_uppercase.Size = new System.Drawing.Size(359, 20);
            this.checkbox_uppercase.TabIndex = 3;
            this.checkbox_uppercase.Text = "Avec des lettres majuscules [ A B C D E F G H ... X Y Z ]";
            this.checkbox_uppercase.UseVisualStyleBackColor = true;
            // 
            // checkBox_special
            // 
            this.checkBox_special.AutoSize = true;
            this.checkBox_special.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_special.Location = new System.Drawing.Point(36, 222);
            this.checkBox_special.Name = "checkBox_special";
            this.checkBox_special.Size = new System.Drawing.Size(485, 20);
            this.checkBox_special.TabIndex = 4;
            this.checkBox_special.Text = "Avec des caractères spéciaux [ ~ ! @ # $ % ^ & * ( ) - _ = + [ ] { } ; : , . < > " +
    "/ ? ]";
            this.checkBox_special.UseVisualStyleBackColor = true;
            // 
            // checkBox_noSimilar
            // 
            this.checkBox_noSimilar.AutoSize = true;
            this.checkBox_noSimilar.Checked = true;
            this.checkBox_noSimilar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_noSimilar.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_noSimilar.Location = new System.Drawing.Point(36, 258);
            this.checkBox_noSimilar.Name = "checkBox_noSimilar";
            this.checkBox_noSimilar.Size = new System.Drawing.Size(332, 20);
            this.checkBox_noSimilar.TabIndex = 5;
            this.checkBox_noSimilar.Text = "Ne pas inclure les caractères similaires [ 0 O I 1 l ]";
            this.checkBox_noSimilar.UseVisualStyleBackColor = true;
            // 
            // numericUpDown
            // 
            this.numericUpDown.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown.Location = new System.Drawing.Point(60, 314);
            this.numericUpDown.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.numericUpDown.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown.TabIndex = 7;
            this.numericUpDown.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // numericUpDown_nbPass
            // 
            this.numericUpDown_nbPass.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_nbPass.Location = new System.Drawing.Point(60, 370);
            this.numericUpDown_nbPass.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown_nbPass.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_nbPass.Name = "numericUpDown_nbPass";
            this.numericUpDown_nbPass.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_nbPass.TabIndex = 1;
            this.numericUpDown_nbPass.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button_generate
            // 
            this.button_generate.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_generate.Location = new System.Drawing.Point(278, 314);
            this.button_generate.Name = "button_generate";
            this.button_generate.Size = new System.Drawing.Size(171, 76);
            this.button_generate.TabIndex = 8;
            this.button_generate.Text = "Générer";
            this.button_generate.UseVisualStyleBackColor = true;
            this.button_generate.Click += new System.EventHandler(this.button_generate_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(36, 407);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(495, 181);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(355, 598);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Copier dans le presse papier";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 635);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button_generate);
            this.Controls.Add(this.numericUpDown_nbPass);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.checkBox_noSimilar);
            this.Controls.Add(this.checkBox_special);
            this.Controls.Add(this.checkbox_uppercase);
            this.Controls.Add(this.checkBox_lowercase);
            this.Controls.Add(this.checkBox_number);
            this.Controls.Add(this.label_title);
            this.Name = "Form1";
            this.Text = "Générateur de mot de passe aléatoire";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_nbPass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.CheckBox checkBox_number;
        private System.Windows.Forms.CheckBox checkBox_lowercase;
        private System.Windows.Forms.CheckBox checkbox_uppercase;
        private System.Windows.Forms.CheckBox checkBox_special;
        private System.Windows.Forms.CheckBox checkBox_noSimilar;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.NumericUpDown numericUpDown_nbPass;
        private System.Windows.Forms.Button button_generate;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
    }
}

