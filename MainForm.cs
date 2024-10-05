/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 10/5/2024
 * Time: 3:08 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace tape
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public List<char> d = new List<char>();
		public void addc(char c)
		{
			d.Add(c);
		}
		public string pntc(int i)
		{
			return d[i].ToString();
		}
		public int cntd()
		{
			return d.Count;
		}
		public void delc(int i)
		{
			d.RemoveAt(i);
		}
		public void insc(int i, char c)
		{
			d.Insert(i,c);
		}
		public void printAllTape()
		{
			int x = cntd();
			for(int i = 0 ; i < x ; i++)
			{
				textBox1.Text += d[i].ToString() + " ";
			}
		}
		public string printTape2String()
		{
			string s = "";
			int x = cntd();
			for(int i = 0 ; i < x ; i++)
			{
				s += d[i].ToString() + " ";
			}
			return s;
		}
		public void addStringToTake(string s)
		{
			int x = s.Length;
			char[] cx = s.ToCharArray();
			for(int i = 0 ; i < x ; i++)
			{
				addc(cx[i]);
			}
		}
		public void clearTape()
		{
			d.Clear();
		}
		public void clearScreen()
		{
			textBox1.Text = "";
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		public void refreshing()
		{
			clearScreen();
			printAllTape();
		}
		void Button1Click(object sender, EventArgs e)
		{
			
			addStringToTake("0123456789.,abcdefghijklmnopqrstuvxzwy+-/*=<>()[]{};:'\"&^%$#@!~`|\\ ");
			refreshing();
	
		}
		void Button2Click(object sender, EventArgs e)
		{
			delc(10);
			refreshing();
		}
		void Button3Click(object sender, EventArgs e)
		{
			insc(10,'g');
			refreshing();
		}
		
	}
}
