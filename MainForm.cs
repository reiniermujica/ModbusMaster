/*
 * Created by SharpDevelop.
 * User: Reinier
 * Date: 24/05/2015
 * Time: 12:30 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Text;

namespace ModbusMaster
{	
	public partial class MainForm : Form
	{
		SerialPort sp1 = null;
		ModbusMaster master = new ModbusMaster();
		string cad = "";			
		
		public MainForm()
		{			
			InitializeComponent();		
		}
		
		public void tx_char(SerialPort SBUF, string x)
		{
			if (SBUF == null ) return;			
			if ( SBUF.IsOpen == false )
				SBUF.Open();		
			
			byte[] mBuffer = Encoding.ASCII.GetBytes(x);
			SBUF.Write(mBuffer, 0, mBuffer.Length);	
		}		
				
		void MainFormLoad(object sender, EventArgs e)
		{
			string[] ports = SerialPort.GetPortNames(); 
			comboBox1.Items.Clear(); 			
			foreach(string port in ports) 
			{ 
				comboBox1.Items.Add(port); 
			} 
			
			if (comboBox1.Items.Count > 0)
			{
				comboBox1.Text = comboBox1.Items[0].ToString();
			}
			else
			{
				conButton.Enabled = false;
			}
			
			comboBox2.Items.Add("1200");
			comboBox2.Items.Add("2400"); 
			comboBox2.Items.Add("4800"); 
			comboBox2.Items.Add("9600"); 
			comboBox2.Items.Add("19200"); 
			comboBox2.Text = "2400"; 	
			comboBox3.Items.Add(Parity.Even.ToString()); 
			comboBox3.Items.Add(Parity.Mark.ToString()); 
			comboBox3.Items.Add(Parity.None.ToString()); 
			comboBox3.Items.Add(Parity.Odd.ToString()); 
			comboBox3.Items.Add(Parity.Space.ToString()); 
			comboBox3.Text = "None";
		}							
		
		private void port_DataReceived(object sender, SerialDataReceivedEventArgs e) 
		{ 			 					
			cad = sp1.ReadExisting();			
			this.Invoke(new EventHandler(Actualizar));
		}
		
		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
			if ( sp1 != null && sp1.IsOpen )
				sp1.Close();			
		}
		
		void ConButtonClick(object sender, EventArgs e)
		{
			if ( sp1 == null || sp1.IsOpen == false )
			{
				Parity Paridad = Parity.None; 
				switch (comboBox3.Text)
				{
					case "Even" : Paridad = Parity.Even; 
								  break;								  
					case "Mark" : Paridad = Parity.Mark; 
								  break;
					case "Odd"  : Paridad = Parity.Odd; 
								  break;
					case "Space": Paridad = Parity.Space; 					
								  break;																	  
					default		: Paridad = Parity.None;
								  break;
				}													
				sp1 = new SerialPort(comboBox1.Text,Convert.ToInt16(comboBox2.Text),Paridad,8,StopBits.One);
				sp1.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived); 
				sp1.Open();
				conButton.Text = "Desconectar";
			}
			else
			{				
				sp1.Close();
				conButton.Text = "Conectar";
			}
		}
		
		private void Actualizar(object s, EventArgs e)
		{															
			this.textBox2.AppendText(cad);
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			if ( sp1 != null && sp1.IsOpen == true && textBox1.Text.Length != 0 )
			{				
				textBox6.AppendText(textBox1.Text);
				this.tx_char(sp1,textBox1.Text);
			}	 						
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			textBox2.Clear();
		}
		
		void Button5Click(object sender, System.EventArgs e)
		{
			textBox6.Clear();
		}
		void Button1Click(object sender, EventArgs e)
		{
			if ( sp1 == null || sp1.IsOpen == false )
				return;				
				 				
			try
			{
				int dir = Convert.ToInt32(textBox3.Text.ToString());
				int start = Convert.ToInt32(textBox4.Text.ToString());
				int cant = Convert.ToInt32(textBox5.Text.ToString());
				
				master.ReadInputStatus_02(dir,start,cant);
				master.tx_ascii_frame(sp1);
				textBox6.AppendText(master.ascii_frame);
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}	
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			if ( sp1 == null || sp1.IsOpen == false )
				return;				
				 				
			try
			{
				int dir = Convert.ToInt32(textBox3.Text.ToString());
				int start = Convert.ToInt32(textBox4.Text.ToString());
				int cant = Convert.ToInt32(textBox5.Text.ToString());
				
				master.ReadCoilStatus_01(dir,start,cant);
				master.tx_ascii_frame(sp1);
				textBox6.AppendText(master.ascii_frame);
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			if ( sp1 == null || sp1.IsOpen == false )
				return;				
				 				
			try
			{
				int dir = Convert.ToInt32(textBox3.Text.ToString());
				int start = Convert.ToInt32(textBox7.Text.ToString());
				int val = Convert.ToInt32(textBox8.Text.ToString());
				
				master.ForceSingleCoil_05(dir,start,val);
				master.tx_ascii_frame(sp1);
				textBox6.AppendText(master.ascii_frame);
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		
		void Button7Click(object sender, EventArgs e)
		{
			
			if ( sp1 == null || sp1.IsOpen == false )
				return;				
				 				
			try
			{
				int dir = Convert.ToInt32(textBox3.Text.ToString());
				int start = Convert.ToInt32(textBox7.Text.ToString());
				int val = Convert.ToInt32(textBox8.Text.ToString());
				
				master.PresetSingleRegister_06(dir,start,val);
				master.tx_ascii_frame(sp1);
				textBox6.AppendText(master.ascii_frame);
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		
		void Button8Click(object sender, EventArgs e)
		{
			if ( sp1 == null || sp1.IsOpen == false )
				return;				
				 				
			try
			{
				int dir = Convert.ToInt32(textBox3.Text.ToString());
				int start = Convert.ToInt32(textBox4.Text.ToString());
				int cant = Convert.ToInt32(textBox5.Text.ToString());
				
				master.ReadHoldingRegisters_03(dir,start,cant);
				master.tx_ascii_frame(sp1);
				textBox6.AppendText(master.ascii_frame);				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		
		void Button9Click(object sender, EventArgs e)
		{
			if ( sp1 == null || sp1.IsOpen == false )
				return;				
				 				
			try
			{
				int dir = Convert.ToInt32(textBox3.Text.ToString());
				int start = Convert.ToInt32(textBox4.Text.ToString());
				int cant = Convert.ToInt32(textBox5.Text.ToString());
				
				master.ReadInputRegisters_04(dir,start,cant);
				master.tx_ascii_frame(sp1);
				textBox6.AppendText(master.ascii_frame);				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		
		void Button10Click(object sender, EventArgs e)
		{
			MessageBox.Show("Aplicación creada por Reinier César Mujica Hernández - 5to Telecomunicaciones y Electrónica" +
							"     13/06/2015 " + "   email: remujica@uclv.cu  reinier.mujica@gmail.com.");
		}
	}
	
}
