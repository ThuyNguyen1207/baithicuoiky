/*
 * Created by SharpDevelop.
 * User: root
 * Date: 1/8/2019
 * Time: 10:27 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;

namespace NguyenThiThanhThuy_1713020015
{
	/// <summary>
	/// Description of clsPoint.
	/// </summary>
	public class clsPoint
	{
        public List<clsDiem> Save = new List<clsDiem>();

        public clsPoint()
        {

        }
     
        public void LoadData(Dictionary<string, List<clsDiem>> input, string input_Name)
        {
            foreach (var item in input)
            {
                if (item.Key == input_Name)
                {
                    Save = item.Value;
                }
            }
        }
        public List<clsDiem> SaveData()
        {
            List<clsDiem> temp = new List<clsDiem>();
            temp = Save;
            return temp;
        }
    }
    class Line : clsPoint
    {
        public clsDiem begin = new clsDiem();
        public clsDiem end = new clsDiem();      
        public Line()
        {
            begin = new clsDiem(0, 0);
            end = new clsDiem(0, 0);
        }
        public Line(clsDiem A, clsDiem B)
        {
            begin = A;
            end = B;
        } 
       
        public  void Draw(Graphics g, Pen pen)
        {
        	foreach (var item in Save)
            {
                for (int i = 0; i < Save.Count - 1; i += 2)
                {
                    g.DrawLine(pen, Save[i].x, Save[i].y, Save[i + 1].x, Save[i + 1].y);
                }
            }
        }
        public void AddPoint()
        {
            try
            {
                Save.Add(begin);
                Save.Add(end);
            }
            catch (Exception)
            {
            }
        }
    }
    class Ellipse : clsPoint
    {
        public clsDiem begin = new clsDiem();
        public clsDiem end = new clsDiem();         
        public Ellipse()
        {
            begin = new clsDiem(0, 0);
            end = new clsDiem(0, 0);
        }
        public Ellipse(clsDiem A, clsDiem B)
        {
            begin = A;
            end = B;
        }
        public void Draw(Graphics g, Pen pen)
        {
            Rectangle rect = new Rectangle();
            foreach (var item in Save)
            {
                for (int i = 0; i < Save.Count - 1; i += 2)
                {
                    rect.X = Save[i].x;
                    rect.Y = Save[i].y;
                    rect.Size = new Size(Save[i+1].x - Save[i].x, Save[i + 1].y - Save[i].y);
                    g.DrawEllipse(pen, rect);
                }
            }
        }
        public void AddPoin()
        {
            try
            {
                Save.Add(begin);
                Save.Add(end);
            }
            catch (Exception)
            {
            }
        }
    }
    
}