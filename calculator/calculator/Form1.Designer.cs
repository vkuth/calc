namespace calculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.multipli = new System.Windows.Forms.Button();
            this.divizion = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sin = new System.Windows.Forms.Button();
            this.cos = new System.Windows.Forms.Button();
            this.log2 = new System.Windows.Forms.Button();
            this.mod = new System.Windows.Forms.Button();
            this.tan = new System.Windows.Forms.Button();
            this.logxy = new System.Windows.Forms.Button();
            this.frdegree = new System.Windows.Forms.Button();
            this.modul = new System.Windows.Forms.Button();
            this.anti = new System.Windows.Forms.Button();
            this.twox = new System.Windows.Forms.Button();
            this.tenx = new System.Windows.Forms.Button();
            this.arif = new System.Windows.Forms.Button();
            this.exp = new System.Windows.Forms.Button();
            this.ln = new System.Windows.Forms.Button();
            this.log10 = new System.Windows.Forms.Button();
            this.oneonx = new System.Windows.Forms.Button();
            this.arctanx = new System.Windows.Forms.Button();
            this.arccosx = new System.Windows.Forms.Button();
            this.arcsinx = new System.Windows.Forms.Button();
            this.ctanx = new System.Windows.Forms.Button();
            this.xony = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(90, 163);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(56, 54);
            this.plus.TabIndex = 0;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.calculeted);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(202, 163);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(56, 54);
            this.minus.TabIndex = 1;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.calculeted);
            // 
            // multipli
            // 
            this.multipli.Location = new System.Drawing.Point(90, 281);
            this.multipli.Name = "multipli";
            this.multipli.Size = new System.Drawing.Size(56, 54);
            this.multipli.TabIndex = 2;
            this.multipli.Text = "*";
            this.multipli.UseVisualStyleBackColor = true;
            this.multipli.Click += new System.EventHandler(this.calculeted);
            // 
            // divizion
            // 
            this.divizion.Location = new System.Drawing.Point(202, 281);
            this.divizion.Name = "divizion";
            this.divizion.Size = new System.Drawing.Size(56, 54);
            this.divizion.TabIndex = 3;
            this.divizion.Text = "/";
            this.divizion.UseVisualStyleBackColor = true;
            this.divizion.Click += new System.EventHandler(this.calculeted);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(98, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(269, 92);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(98, 22);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(505, 92);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(98, 22);
            this.textBox3.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Первый аргумент";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Второй аргумент";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(502, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "результат";
            // 
            // sin
            // 
            this.sin.Location = new System.Drawing.Point(311, 163);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(56, 54);
            this.sin.TabIndex = 10;
            this.sin.Text = "sin";
            this.sin.UseVisualStyleBackColor = true;
            this.sin.Click += new System.EventHandler(this.sincos);
            // 
            // cos
            // 
            this.cos.Location = new System.Drawing.Point(311, 281);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(56, 54);
            this.cos.TabIndex = 11;
            this.cos.Text = "cos";
            this.cos.UseVisualStyleBackColor = true;
            this.cos.Click += new System.EventHandler(this.sincos);
            // 
            // log2
            // 
            this.log2.Location = new System.Drawing.Point(399, 163);
            this.log2.Name = "log2";
            this.log2.Size = new System.Drawing.Size(56, 54);
            this.log2.TabIndex = 12;
            this.log2.Text = "log2";
            this.log2.UseVisualStyleBackColor = true;
            // 
            // mod
            // 
            this.mod.Location = new System.Drawing.Point(399, 281);
            this.mod.Name = "mod";
            this.mod.Size = new System.Drawing.Size(56, 54);
            this.mod.TabIndex = 13;
            this.mod.Text = "residue";
            this.mod.UseVisualStyleBackColor = true;
            this.mod.Click += new System.EventHandler(this.calculeted);
            // 
            // tan
            // 
            this.tan.Location = new System.Drawing.Point(505, 163);
            this.tan.Name = "tan";
            this.tan.Size = new System.Drawing.Size(56, 54);
            this.tan.TabIndex = 14;
            this.tan.Text = "tan";
            this.tan.UseVisualStyleBackColor = true;
            this.tan.Click += new System.EventHandler(this.sincos);
            // 
            // logxy
            // 
            this.logxy.Location = new System.Drawing.Point(505, 281);
            this.logxy.Name = "logxy";
            this.logxy.Size = new System.Drawing.Size(72, 54);
            this.logxy.TabIndex = 15;
            this.logxy.Text = "logx(y)";
            this.logxy.UseVisualStyleBackColor = true;
            this.logxy.Click += new System.EventHandler(this.calculeted);
            // 
            // frdegree
            // 
            this.frdegree.Location = new System.Drawing.Point(588, 163);
            this.frdegree.Name = "frdegree";
            this.frdegree.Size = new System.Drawing.Size(60, 54);
            this.frdegree.TabIndex = 16;
            this.frdegree.Text = "x^(1/y)";
            this.frdegree.UseVisualStyleBackColor = true;
            this.frdegree.Click += new System.EventHandler(this.calculeted);
            // 
            // modul
            // 
            this.modul.Location = new System.Drawing.Point(588, 281);
            this.modul.Name = "modul";
            this.modul.Size = new System.Drawing.Size(60, 54);
            this.modul.TabIndex = 17;
            this.modul.Text = "|x|";
            this.modul.UseVisualStyleBackColor = true;
            this.modul.Click += new System.EventHandler(this.sincos);
            // 
            // anti
            // 
            this.anti.Location = new System.Drawing.Point(671, 163);
            this.anti.Name = "anti";
            this.anti.Size = new System.Drawing.Size(60, 54);
            this.anti.TabIndex = 18;
            this.anti.Text = "-x";
            this.anti.UseVisualStyleBackColor = true;
            this.anti.Click += new System.EventHandler(this.sincos);
            // 
            // twox
            // 
            this.twox.Location = new System.Drawing.Point(671, 281);
            this.twox.Name = "twox";
            this.twox.Size = new System.Drawing.Size(60, 54);
            this.twox.TabIndex = 19;
            this.twox.Text = "2^x";
            this.twox.UseVisualStyleBackColor = true;
            this.twox.Click += new System.EventHandler(this.sincos);
            // 
            // tenx
            // 
            this.tenx.Location = new System.Drawing.Point(764, 163);
            this.tenx.Name = "tenx";
            this.tenx.Size = new System.Drawing.Size(60, 54);
            this.tenx.TabIndex = 20;
            this.tenx.Text = "10^x";
            this.tenx.UseVisualStyleBackColor = true;
            this.tenx.Click += new System.EventHandler(this.sincos);
            // 
            // arif
            // 
            this.arif.Location = new System.Drawing.Point(764, 281);
            this.arif.Name = "arif";
            this.arif.Size = new System.Drawing.Size(60, 54);
            this.arif.TabIndex = 21;
            this.arif.Text = "x+y/2";
            this.arif.UseVisualStyleBackColor = true;
            this.arif.Click += new System.EventHandler(this.calculeted);
            // 
            // exp
            // 
            this.exp.Location = new System.Drawing.Point(86, 377);
            this.exp.Name = "exp";
            this.exp.Size = new System.Drawing.Size(60, 54);
            this.exp.TabIndex = 22;
            this.exp.Text = "e^x";
            this.exp.UseVisualStyleBackColor = true;
            this.exp.Click += new System.EventHandler(this.sincos);
            // 
            // ln
            // 
            this.ln.Location = new System.Drawing.Point(198, 377);
            this.ln.Name = "ln";
            this.ln.Size = new System.Drawing.Size(60, 54);
            this.ln.TabIndex = 23;
            this.ln.Text = "ln(x)";
            this.ln.UseVisualStyleBackColor = true;
            this.ln.Click += new System.EventHandler(this.sincos);
            // 
            // log10
            // 
            this.log10.Location = new System.Drawing.Point(307, 377);
            this.log10.Name = "log10";
            this.log10.Size = new System.Drawing.Size(60, 54);
            this.log10.TabIndex = 24;
            this.log10.Text = "log10(x)";
            this.log10.UseVisualStyleBackColor = true;
            this.log10.Click += new System.EventHandler(this.sincos);
            // 
            // oneonx
            // 
            this.oneonx.Location = new System.Drawing.Point(399, 377);
            this.oneonx.Name = "oneonx";
            this.oneonx.Size = new System.Drawing.Size(60, 54);
            this.oneonx.TabIndex = 25;
            this.oneonx.Text = "1/x";
            this.oneonx.UseVisualStyleBackColor = true;
            this.oneonx.Click += new System.EventHandler(this.sincos);
            // 
            // arctanx
            // 
            this.arctanx.Location = new System.Drawing.Point(517, 377);
            this.arctanx.Name = "arctanx";
            this.arctanx.Size = new System.Drawing.Size(60, 54);
            this.arctanx.TabIndex = 26;
            this.arctanx.Text = "arctan(x)";
            this.arctanx.UseVisualStyleBackColor = true;
            this.arctanx.Click += new System.EventHandler(this.sincos);
            // 
            // arccosx
            // 
            this.arccosx.Location = new System.Drawing.Point(588, 377);
            this.arccosx.Name = "arccosx";
            this.arccosx.Size = new System.Drawing.Size(60, 54);
            this.arccosx.TabIndex = 27;
            this.arccosx.Text = "arccos(x)";
            this.arccosx.UseVisualStyleBackColor = true;
            this.arccosx.Click += new System.EventHandler(this.sincos);
            // 
            // arcsinx
            // 
            this.arcsinx.Location = new System.Drawing.Point(671, 377);
            this.arcsinx.Name = "arcsinx";
            this.arcsinx.Size = new System.Drawing.Size(60, 54);
            this.arcsinx.TabIndex = 28;
            this.arcsinx.Text = "arcsin(x)";
            this.arcsinx.UseVisualStyleBackColor = true;
            this.arcsinx.Click += new System.EventHandler(this.sincos);
            // 
            // ctanx
            // 
            this.ctanx.Location = new System.Drawing.Point(764, 377);
            this.ctanx.Name = "ctanx";
            this.ctanx.Size = new System.Drawing.Size(60, 54);
            this.ctanx.TabIndex = 29;
            this.ctanx.Text = "ctan(x)";
            this.ctanx.UseVisualStyleBackColor = true;
            this.ctanx.Click += new System.EventHandler(this.sincos);
            // 
            // xony
            // 
            this.xony.Location = new System.Drawing.Point(86, 470);
            this.xony.Name = "xony";
            this.xony.Size = new System.Drawing.Size(60, 54);
            this.xony.TabIndex = 30;
            this.xony.Text = "x^y";
            this.xony.UseVisualStyleBackColor = true;
            this.xony.Click += new System.EventHandler(this.calculeted);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(198, 470);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(60, 54);
            this.button10.TabIndex = 31;
            this.button10.Text = "x+y/2";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1209, 549);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.xony);
            this.Controls.Add(this.ctanx);
            this.Controls.Add(this.arcsinx);
            this.Controls.Add(this.arccosx);
            this.Controls.Add(this.arctanx);
            this.Controls.Add(this.oneonx);
            this.Controls.Add(this.log10);
            this.Controls.Add(this.ln);
            this.Controls.Add(this.exp);
            this.Controls.Add(this.arif);
            this.Controls.Add(this.tenx);
            this.Controls.Add(this.twox);
            this.Controls.Add(this.anti);
            this.Controls.Add(this.modul);
            this.Controls.Add(this.frdegree);
            this.Controls.Add(this.logxy);
            this.Controls.Add(this.tan);
            this.Controls.Add(this.mod);
            this.Controls.Add(this.log2);
            this.Controls.Add(this.cos);
            this.Controls.Add(this.sin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.divizion);
            this.Controls.Add(this.multipli);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Olive;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button multipli;
        private System.Windows.Forms.Button divizion;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sin;
        private System.Windows.Forms.Button cos;
        private System.Windows.Forms.Button log2;
        private System.Windows.Forms.Button mod;
        private System.Windows.Forms.Button tan;
        private System.Windows.Forms.Button logxy;
        private System.Windows.Forms.Button frdegree;
        private System.Windows.Forms.Button modul;
        private System.Windows.Forms.Button anti;
        private System.Windows.Forms.Button twox;
        private System.Windows.Forms.Button tenx;
        private System.Windows.Forms.Button arif;
        private System.Windows.Forms.Button exp;
        private System.Windows.Forms.Button ln;
        private System.Windows.Forms.Button log10;
        private System.Windows.Forms.Button oneonx;
        private System.Windows.Forms.Button arctanx;
        private System.Windows.Forms.Button arccosx;
        private System.Windows.Forms.Button arcsinx;
        private System.Windows.Forms.Button ctanx;
        private System.Windows.Forms.Button xony;
        private System.Windows.Forms.Button button10;
    }
}

