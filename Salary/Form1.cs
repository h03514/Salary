using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salary
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

	
		class Emplyee{
			public string Name { get; set; }
			public string Salary { get; set; }

			public void PrintData()
			{
				MessageBox.Show(Name +" 員工 薪水是 " +Salary);
			}

			public void ErrorSalary()
			{
				MessageBox.Show("你給的薪水太低或太高了");
			}
		}
		private void button1_Click(object sender, EventArgs e)
		{
			Emplyee emplyee = new Emplyee();
			emplyee.Name = textBox1.Text;
			emplyee.Salary = textBox2.Text;

			if(int.Parse(textBox2.Text)<20000 || int.Parse(textBox2.Text) >40000)
			{
				emplyee.ErrorSalary();
			}
			else
			{
				emplyee.PrintData();
			}

		}
	}
}
