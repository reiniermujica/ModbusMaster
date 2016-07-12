/*
 * Created by SharpDevelop.
 * User: Reinier
 * Date: 24/05/2015
 * Time: 12:30 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ModbusMaster
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label11 = new System.Windows.Forms.Label();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.conButton = new System.Windows.Forms.Button();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button9 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.button6 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.button5 = new System.Windows.Forms.Button();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.button10 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.comboBox3);
			this.groupBox1.Controls.Add(this.conButton);
			this.groupBox1.Controls.Add(this.comboBox2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Location = new System.Drawing.Point(12, 19);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(377, 143);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Configurar puerto serie";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(11, 108);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(72, 23);
			this.label11.TabIndex = 14;
			this.label11.Text = "Paridad:";
			// 
			// comboBox3
			// 
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(129, 105);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(121, 21);
			this.comboBox3.TabIndex = 13;
			// 
			// conButton
			// 
			this.conButton.Location = new System.Drawing.Point(260, 99);
			this.conButton.Name = "conButton";
			this.conButton.Size = new System.Drawing.Size(100, 27);
			this.conButton.TabIndex = 12;
			this.conButton.Text = "Conectar";
			this.conButton.UseVisualStyleBackColor = true;
			this.conButton.Click += new System.EventHandler(this.ConButtonClick);
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(129, 65);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(121, 21);
			this.comboBox2.TabIndex = 11;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(11, 68);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(121, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "Velocidad (Baudios):";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(11, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 18);
			this.label1.TabIndex = 9;
			this.label1.Text = "Puerto:";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(128, 25);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 8;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.button9);
			this.groupBox2.Controls.Add(this.button8);
			this.groupBox2.Controls.Add(this.button7);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.textBox8);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.textBox7);
			this.groupBox2.Controls.Add(this.button6);
			this.groupBox2.Controls.Add(this.button1);
			this.groupBox2.Controls.Add(this.textBox5);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.button4);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.textBox4);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.textBox3);
			this.groupBox2.Location = new System.Drawing.Point(12, 168);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(514, 210);
			this.groupBox2.TabIndex = 11;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Funciones de Modbus";
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(260, 112);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(154, 23);
			this.button9.TabIndex = 33;
			this.button9.Text = "Leer registros de entrada (04)";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.Button9Click);
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(260, 82);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(154, 23);
			this.button8.TabIndex = 32;
			this.button8.Text = "Leer registros de salida (03)";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.Button8Click);
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(260, 172);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(154, 23);
			this.button7.TabIndex = 31;
			this.button7.Text = "Modificar Registro (06)";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.Button7Click);
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(14, 175);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(75, 23);
			this.label10.TabIndex = 30;
			this.label10.Text = "Nuevo valor";
			// 
			// textBox8
			// 
			this.textBox8.Location = new System.Drawing.Point(140, 172);
			this.textBox8.MaxLength = 5;
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(65, 20);
			this.textBox8.TabIndex = 28;
			this.textBox8.Text = "0";
			this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(14, 137);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(103, 23);
			this.label9.TabIndex = 27;
			this.label9.Text = "Bobina o Registro";
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(140, 134);
			this.textBox7.MaxLength = 5;
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(65, 20);
			this.textBox7.TabIndex = 26;
			this.textBox7.Text = "1";
			this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(260, 142);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(154, 23);
			this.button6.TabIndex = 25;
			this.button6.Text = "Forzar bobina (05)";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.Button6Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(260, 52);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(154, 23);
			this.button1.TabIndex = 24;
			this.button1.Text = "Leer Entradas (02)";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(140, 99);
			this.textBox5.MaxLength = 5;
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(65, 20);
			this.textBox5.TabIndex = 23;
			this.textBox5.Text = "1";
			this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(14, 99);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(75, 17);
			this.label7.TabIndex = 22;
			this.label7.Text = "Cantidad";
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(260, 22);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(154, 23);
			this.button4.TabIndex = 21;
			this.button4.Text = "Leer Coils (01)";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(14, 63);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(52, 17);
			this.label6.TabIndex = 20;
			this.label6.Text = "Inicio";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(140, 60);
			this.textBox4.MaxLength = 5;
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(65, 20);
			this.textBox4.TabIndex = 19;
			this.textBox4.Text = "1";
			this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(14, 24);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(118, 14);
			this.label5.TabIndex = 18;
			this.label5.Text = "Dirección del esclavo";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(140, 24);
			this.textBox3.MaxLength = 3;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(65, 20);
			this.textBox3.TabIndex = 17;
			this.textBox3.Text = "05";
			this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(3, 130);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(103, 19);
			this.label4.TabIndex = 14;
			this.label4.Text = "Datos recibidos";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(431, 122);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 15;
			this.button2.Text = "Enviar";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(412, 79);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(121, 15);
			this.label2.TabIndex = 12;
			this.label2.Text = "Enviar byte de prueba";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(417, 95);
			this.textBox1.MaxLength = 1;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(102, 20);
			this.textBox1.TabIndex = 11;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(4, 22);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 24;
			this.label8.Text = "Datos enviados";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(433, 194);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 18;
			this.button3.Text = "Limpiar";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(6, 152);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox2.Size = new System.Drawing.Size(421, 79);
			this.textBox2.TabIndex = 17;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.button5);
			this.groupBox3.Controls.Add(this.textBox6);
			this.groupBox3.Controls.Add(this.textBox2);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.button3);
			this.groupBox3.Location = new System.Drawing.Point(12, 384);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(514, 237);
			this.groupBox3.TabIndex = 25;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Comunicación";
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(433, 86);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 23);
			this.button5.TabIndex = 26;
			this.button5.Text = "Limpiar";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(6, 42);
			this.textBox6.Multiline = true;
			this.textBox6.Name = "textBox6";
			this.textBox6.ReadOnly = true;
			this.textBox6.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox6.Size = new System.Drawing.Size(421, 79);
			this.textBox6.TabIndex = 25;
			// 
			// button10
			// 
			this.button10.Location = new System.Drawing.Point(491, 19);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(28, 23);
			this.button10.TabIndex = 26;
			this.button10.Text = "?";
			this.button10.UseVisualStyleBackColor = true;
			this.button10.Click += new System.EventHandler(this.Button10Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(536, 632);
			this.Controls.Add(this.button10);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Modbus Master";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button conButton;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label4;
		public System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		
		
	}
}
