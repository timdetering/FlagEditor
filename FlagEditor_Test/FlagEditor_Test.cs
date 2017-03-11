using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace FlagEditor_Test
{
	[Flags,
	Editor(typeof(STUP.ComponentModel.Design.FlagsEditor), typeof(System.Drawing.Design.UITypeEditor))]
	public enum EnumerationTest
	{
		[Description("Description for the first tested value.")]
		firstValue = 1,
		[Description("Description for the second tested value.")]
		secondValue = 2,
		[Description("Description for the third tested value.")]
		thirdValue = 4
	}

	public class MyEditedClass
	{
		public MyEditedClass()
		{
			myEnumValue = EnumerationTest.firstValue | EnumerationTest.thirdValue;
		}

		private EnumerationTest myEnumValue;
		
		/// <summary>
		/// Property MyEnumValue (EnumerationTest)
		/// </summary>
		public EnumerationTest MyEnumValue
		{
			get
			{
				return this.myEnumValue;
			}
			set
			{
				this.myEnumValue = value;
			}
		}
	}

	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class FlagEditor_Test : System.Windows.Forms.Form
	{
		private System.Windows.Forms.PropertyGrid propertyGrid1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FlagEditor_Test()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			
			propertyGrid1.SelectedObject = new MyEditedClass();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
			this.SuspendLayout();
			// 
			// propertyGrid1
			// 
			this.propertyGrid1.CommandsVisibleIfAvailable = true;
			this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.propertyGrid1.LargeButtons = false;
			this.propertyGrid1.LineColor = System.Drawing.SystemColors.ScrollBar;
			this.propertyGrid1.Name = "propertyGrid1";
			this.propertyGrid1.Size = new System.Drawing.Size(292, 273);
			this.propertyGrid1.TabIndex = 0;
			this.propertyGrid1.Text = "propertyGrid1";
			this.propertyGrid1.ViewBackColor = System.Drawing.SystemColors.Window;
			this.propertyGrid1.ViewForeColor = System.Drawing.SystemColors.WindowText;
			// 
			// FlagEditor_Test
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.propertyGrid1});
			this.Name = "FlagEditor_Test";
			this.Text = "FlagEditor_Test";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new FlagEditor_Test());
		}
	}
}
