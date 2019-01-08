/*
 * Created by SharpDevelop.
 * User: root
 * Date: 1/8/2019
 * Time: 8:33 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Web.Script.Serialization;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace Newtonsoft.Json
{
	
}

namespace NguyenThiThanhThuy_1713020015
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		clsDiem d1 = new clsDiem();
		clsDiem d2 = new clsDiem();
		bool isDrawing = false;
		List<clsPoint> clsDiem = new List<clsPoint>();
		public MainForm()
		{
		
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void PbDrawsMouseUp(object sender, MouseEventArgs e)
		{
			d2.x = e.X;
			d2.y = e.Y;
			System.Drawing.Graphics g = pbDraws.CreateGraphics();
			g.DrawLine(new Pen(Color.Black,3),d1.x,d1.y,d2.x,d2.y);
			isDrawing = false;
		}
		
		
		void PbDrawsMouseMove(object sender, MouseEventArgs e)
		{
			System.Drawing.Graphics g = pbDraws.CreateGraphics();
			if(isDrawing == true)
			{
			g.DrawLine(new Pen(Color.White),d1.x,d1.y,d2.x,d2.y);
			d2.x = e.X;
			d2.y = e.Y;
			g.DrawLine( new Pen(Color.Black),d1.x,d1.y,d2.x,d2.y);
			}
		}
		
		void PbDrawsMouseDown(object sender, MouseEventArgs e)
		{
			isDrawing = true;
			d1.x = e.X;
			d1.y = e.Y;
		}
		void SaveClick(object sender, EventArgs e)
		{
			SaveFileDialog Save = new SaveFileDialog();
			Save.Filter = "Json Filter | *.json|All Filter|*.*";
			if ( Save.ShowDialog() == DialogResult.OK)
			{
				string fileName = Save.FileName;
				JavaScriptSerializer serializer = new JavaScriptSerializer();
				var json = serializer.Serialize(clsDiem);
				StreamWriter writer = new StreamWriter(fileName);
				writer.Write(json);
				writer.Close();
				MessageBox.Show("success");
			}
		}
		
			void LoadClick(object sender, EventArgs e)
		{
			OpenFileDialog Load = new OpenFileDialog();
			Load.Filter =  "Json Filter | *.json|All Filter|*.*";
			if ( Load.ShowDialog() == DialogResult.OK)
			{
				string sFileName = Load.FileName;
				JavaScriptSerializer serializer = new JavaScriptSerializer();
				StreamReader reader = new StreamReader(sFileName);
				string json = reader.ReadToEnd();
				reader.Close();
				var DeserializeObject = serializer.Deserialize<List<clsDiem>>(json);
				reader.Close();
				foreach ( var element in DeserializeObject)
				{
				
				}
				MessageBox.Show("Load OK");
		}
	}
			
	}
}
