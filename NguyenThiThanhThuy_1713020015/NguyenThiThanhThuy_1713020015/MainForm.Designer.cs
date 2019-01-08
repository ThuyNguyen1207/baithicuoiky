/*
 * Created by SharpDevelop.
 * User: root
 * Date: 1/8/2019
 * Time: 8:33 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NguyenThiThanhThuy_1713020015
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton tbduongthang;
		private System.Windows.Forms.ToolStripButton tbhinhthoi;
		private System.Windows.Forms.ToolStripButton tbhinhtamgiac;
		private System.Windows.Forms.ToolStripButton Save;
		private System.Windows.Forms.ToolStripButton tbload;
		private System.Windows.Forms.PictureBox pbDraws;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tbduongthang = new System.Windows.Forms.ToolStripButton();
			this.tbhinhthoi = new System.Windows.Forms.ToolStripButton();
			this.tbhinhtamgiac = new System.Windows.Forms.ToolStripButton();
			this.Save = new System.Windows.Forms.ToolStripButton();
			this.tbload = new System.Windows.Forms.ToolStripButton();
			this.pbDraws = new System.Windows.Forms.PictureBox();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbDraws)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.tbduongthang,
			this.tbhinhthoi,
			this.tbhinhtamgiac,
			this.Save,
			this.tbload});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(847, 61);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tbduongthang
			// 
			this.tbduongthang.BackColor = System.Drawing.Color.Transparent;
			this.tbduongthang.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbduongthang.Image = ((System.Drawing.Image)(resources.GetObject("tbduongthang.Image")));
			this.tbduongthang.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbduongthang.Name = "tbduongthang";
			this.tbduongthang.Size = new System.Drawing.Size(133, 58);
			this.tbduongthang.Text = "Đường thẳng";
			this.tbduongthang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tbduongthang.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbDrawsMouseDown);
			this.tbduongthang.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PbDrawsMouseMove);
			this.tbduongthang.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbDrawsMouseUp);
			// 
			// tbhinhthoi
			// 
			this.tbhinhthoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbhinhthoi.Image = ((System.Drawing.Image)(resources.GetObject("tbhinhthoi.Image")));
			this.tbhinhthoi.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbhinhthoi.Name = "tbhinhthoi";
			this.tbhinhthoi.Size = new System.Drawing.Size(97, 58);
			this.tbhinhthoi.Text = "Hình thoi";
			this.tbhinhthoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// tbhinhtamgiac
			// 
			this.tbhinhtamgiac.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbhinhtamgiac.Image = ((System.Drawing.Image)(resources.GetObject("tbhinhtamgiac.Image")));
			this.tbhinhtamgiac.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbhinhtamgiac.Name = "tbhinhtamgiac";
			this.tbhinhtamgiac.Size = new System.Drawing.Size(142, 58);
			this.tbhinhtamgiac.Text = " Hình tam giác";
			this.tbhinhtamgiac.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// Save
			// 
			this.Save.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Save.Image = ((System.Drawing.Image)(resources.GetObject("Save.Image")));
			this.Save.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Save.Name = "Save";
			this.Save.Size = new System.Drawing.Size(63, 58);
			this.Save.Text = "Save";
			this.Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// tbload
			// 
			this.tbload.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbload.Image = ((System.Drawing.Image)(resources.GetObject("tbload.Image")));
			this.tbload.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbload.Name = "tbload";
			this.tbload.Size = new System.Drawing.Size(64, 58);
			this.tbload.Text = "Load";
			this.tbload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// pbDraws
			// 
			this.pbDraws.Location = new System.Drawing.Point(0, 99);
			this.pbDraws.Name = "pbDraws";
			this.pbDraws.Size = new System.Drawing.Size(823, 301);
			this.pbDraws.TabIndex = 1;
			this.pbDraws.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(847, 402);
			this.Controls.Add(this.pbDraws);
			this.Controls.Add(this.toolStrip1);
			this.Name = "MainForm";
			this.Text = "NguyenThiThanhThuy_1713020015";
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbDraws)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
