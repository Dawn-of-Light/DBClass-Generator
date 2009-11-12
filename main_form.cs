using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Data.SqlTypes;
using ByteFX.Data.MySqlClient;

#region namespace
namespace WindowsApplication1
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	/// 
	#region main_form class
	public class main_form : System.Windows.Forms.Form
	{
		#region fields
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox UserNameBox;
		private System.Windows.Forms.TextBox ServerNameBox;
		private System.Windows.Forms.GroupBox ConnectionGroup;
		private System.Windows.Forms.TextBox PasswordBox;
		private System.Windows.Forms.GroupBox ViewGroup;
		private System.Windows.Forms.TextBox ViewBox;
		private System.Windows.Forms.Button ExitButton;
		private System.Windows.Forms.Button ConnectButton;
		private System.Windows.Forms.Button GenerateSource;
		private System.Windows.Forms.ComboBox TableBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox TableViewBox;
		private System.Windows.Forms.Button ClearButton;
		private System.Windows.Forms.TextBox DatabaseBox;
		private System.Windows.Forms.TextBox OutputBox;
		private System.Windows.Forms.GroupBox TableGroup;
		private System.Windows.Forms.Label TableLabel;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label SourceLabel;
		private System.ComponentModel.Container components = null;
		#endregion
		#region constructors
		public main_form()
		{
			//
			// Required for Windows Form Designer support
			//
			
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		#endregion
		#region methods
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
			this.ConnectionGroup = new System.Windows.Forms.GroupBox();
			this.DatabaseBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.ConnectButton = new System.Windows.Forms.Button();
			this.ServerNameBox = new System.Windows.Forms.TextBox();
			this.PasswordBox = new System.Windows.Forms.TextBox();
			this.UserNameBox = new System.Windows.Forms.TextBox();
			this.ClearButton = new System.Windows.Forms.Button();
			this.GenerateSource = new System.Windows.Forms.Button();
			this.TableBox = new System.Windows.Forms.ComboBox();
			this.ExitButton = new System.Windows.Forms.Button();
			this.ViewGroup = new System.Windows.Forms.GroupBox();
			this.SourceLabel = new System.Windows.Forms.Label();
			this.ViewBox = new System.Windows.Forms.TextBox();
			this.OutputBox = new System.Windows.Forms.TextBox();
			this.TableLabel = new System.Windows.Forms.Label();
			this.TableViewBox = new System.Windows.Forms.TextBox();
			this.TableGroup = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.ConnectionGroup.SuspendLayout();
			this.ViewGroup.SuspendLayout();
			this.TableGroup.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ConnectionGroup
			// 
			this.ConnectionGroup.Controls.Add(this.DatabaseBox);
			this.ConnectionGroup.Controls.Add(this.label5);
			this.ConnectionGroup.Controls.Add(this.label4);
			this.ConnectionGroup.Controls.Add(this.label2);
			this.ConnectionGroup.Controls.Add(this.label1);
			this.ConnectionGroup.Controls.Add(this.ConnectButton);
			this.ConnectionGroup.Controls.Add(this.ServerNameBox);
			this.ConnectionGroup.Controls.Add(this.PasswordBox);
			this.ConnectionGroup.Controls.Add(this.UserNameBox);
			this.ConnectionGroup.Location = new System.Drawing.Point(16, 0);
			this.ConnectionGroup.Name = "ConnectionGroup";
			this.ConnectionGroup.Size = new System.Drawing.Size(168, 248);
			this.ConnectionGroup.TabIndex = 3;
			this.ConnectionGroup.TabStop = false;
			this.ConnectionGroup.Text = "CONNECTION";
			this.ConnectionGroup.Enter += new System.EventHandler(this.ConnectionGroup_Enter);
			// 
			// DatabaseBox
			// 
			this.DatabaseBox.Location = new System.Drawing.Point(8, 184);
			this.DatabaseBox.Name = "DatabaseBox";
			this.DatabaseBox.Size = new System.Drawing.Size(136, 20);
			this.DatabaseBox.TabIndex = 4;
			this.DatabaseBox.Text = "";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(8, 168);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 16);
			this.label5.TabIndex = 14;
			this.label5.Text = "Database:";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(8, 120);
			this.label4.Name = "label4";
			this.label4.TabIndex = 8;
			this.label4.Text = "Password:";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(8, 64);
			this.label2.Name = "label2";
			this.label2.TabIndex = 6;
			this.label2.Text = "User Name:";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.TabIndex = 5;
			this.label1.Text = "Server:";
			// 
			// ConnectButton
			// 
			this.ConnectButton.Location = new System.Drawing.Point(8, 216);
			this.ConnectButton.Name = "ConnectButton";
			this.ConnectButton.Size = new System.Drawing.Size(136, 23);
			this.ConnectButton.TabIndex = 5;
			this.ConnectButton.Text = "Connect";
			this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
			// 
			// ServerNameBox
			// 
			this.ServerNameBox.Location = new System.Drawing.Point(8, 40);
			this.ServerNameBox.Name = "ServerNameBox";
			this.ServerNameBox.Size = new System.Drawing.Size(136, 20);
			this.ServerNameBox.TabIndex = 1;
			this.ServerNameBox.Text = "";
			// 
			// PasswordBox
			// 
			this.PasswordBox.Location = new System.Drawing.Point(8, 144);
			this.PasswordBox.Name = "PasswordBox";
			this.PasswordBox.PasswordChar = '*';
			this.PasswordBox.Size = new System.Drawing.Size(136, 20);
			this.PasswordBox.TabIndex = 3;
			this.PasswordBox.Text = "";
			// 
			// UserNameBox
			// 
			this.UserNameBox.Location = new System.Drawing.Point(8, 88);
			this.UserNameBox.Name = "UserNameBox";
			this.UserNameBox.Size = new System.Drawing.Size(136, 20);
			this.UserNameBox.TabIndex = 2;
			this.UserNameBox.Text = "";
			// 
			// ClearButton
			// 
			this.ClearButton.Location = new System.Drawing.Point(24, 256);
			this.ClearButton.Name = "ClearButton";
			this.ClearButton.Size = new System.Drawing.Size(136, 23);
			this.ClearButton.TabIndex = 8;
			this.ClearButton.Text = "Disconnect";
			this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
			// 
			// GenerateSource
			// 
			this.GenerateSource.Location = new System.Drawing.Point(8, 48);
			this.GenerateSource.Name = "GenerateSource";
			this.GenerateSource.Size = new System.Drawing.Size(144, 23);
			this.GenerateSource.TabIndex = 7;
			this.GenerateSource.Text = "Generate Source";
			this.GenerateSource.Click += new System.EventHandler(this.GenerateSource_Click);
			// 
			// TableBox
			// 
			this.TableBox.Location = new System.Drawing.Point(8, 16);
			this.TableBox.Name = "TableBox";
			this.TableBox.Size = new System.Drawing.Size(144, 21);
			this.TableBox.TabIndex = 6;
			this.TableBox.Text = "Select Table";
			// 
			// ExitButton
			// 
			this.ExitButton.Location = new System.Drawing.Point(24, 288);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(136, 24);
			this.ExitButton.TabIndex = 9;
			this.ExitButton.Text = "Exit";
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// ViewGroup
			// 
			this.ViewGroup.Controls.Add(this.SourceLabel);
			this.ViewGroup.Controls.Add(this.ViewBox);
			this.ViewGroup.Enabled = false;
			this.ViewGroup.Location = new System.Drawing.Point(192, 0);
			this.ViewGroup.Name = "ViewGroup";
			this.ViewGroup.Size = new System.Drawing.Size(608, 352);
			this.ViewGroup.TabIndex = 5;
			this.ViewGroup.TabStop = false;
			// 
			// SourceLabel
			// 
			this.SourceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.SourceLabel.Location = new System.Drawing.Point(16, 8);
			this.SourceLabel.Name = "SourceLabel";
			this.SourceLabel.Size = new System.Drawing.Size(416, 23);
			this.SourceLabel.TabIndex = 16;
			this.SourceLabel.Text = "Source:";
			// 
			// ViewBox
			// 
			this.ViewBox.Location = new System.Drawing.Point(16, 32);
			this.ViewBox.Multiline = true;
			this.ViewBox.Name = "ViewBox";
			this.ViewBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.ViewBox.Size = new System.Drawing.Size(584, 304);
			this.ViewBox.TabIndex = 13;
			this.ViewBox.Text = "";
			this.ViewBox.WordWrap = false;
			this.ViewBox.TextChanged += new System.EventHandler(this.ViewBox_TextChanged);
			// 
			// OutputBox
			// 
			this.OutputBox.Location = new System.Drawing.Point(344, 40);
			this.OutputBox.Multiline = true;
			this.OutputBox.Name = "OutputBox";
			this.OutputBox.ReadOnly = true;
			this.OutputBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.OutputBox.Size = new System.Drawing.Size(256, 136);
			this.OutputBox.TabIndex = 11;
			this.OutputBox.Text = "";
			this.OutputBox.WordWrap = false;
			// 
			// TableLabel
			// 
			this.TableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.TableLabel.Location = new System.Drawing.Point(8, 16);
			this.TableLabel.Name = "TableLabel";
			this.TableLabel.Size = new System.Drawing.Size(312, 23);
			this.TableLabel.TabIndex = 2;
			this.TableLabel.Text = "Table:";
			// 
			// TableViewBox
			// 
			this.TableViewBox.Location = new System.Drawing.Point(8, 40);
			this.TableViewBox.Multiline = true;
			this.TableViewBox.Name = "TableViewBox";
			this.TableViewBox.ReadOnly = true;
			this.TableViewBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.TableViewBox.Size = new System.Drawing.Size(320, 136);
			this.TableViewBox.TabIndex = 12;
			this.TableViewBox.Text = "";
			this.TableViewBox.WordWrap = false;
			// 
			// TableGroup
			// 
			this.TableGroup.Controls.Add(this.TableBox);
			this.TableGroup.Controls.Add(this.GenerateSource);
			this.TableGroup.Enabled = false;
			this.TableGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.TableGroup.Location = new System.Drawing.Point(16, 352);
			this.TableGroup.Name = "TableGroup";
			this.TableGroup.Size = new System.Drawing.Size(168, 88);
			this.TableGroup.TabIndex = 17;
			this.TableGroup.TabStop = false;
			this.TableGroup.Text = "Tables";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(344, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(168, 23);
			this.label3.TabIndex = 15;
			this.label3.Text = "Messages:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.TableViewBox);
			this.groupBox1.Controls.Add(this.OutputBox);
			this.groupBox1.Controls.Add(this.TableLabel);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new System.Drawing.Point(192, 352);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(608, 192);
			this.groupBox1.TabIndex = 18;
			this.groupBox1.TabStop = false;
			// 
			// main_form
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(824, 550);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.ViewGroup);
			this.Controls.Add(this.ConnectionGroup);
			this.Controls.Add(this.ExitButton);
			this.Controls.Add(this.ClearButton);
			this.Controls.Add(this.TableGroup);
			this.Name = "main_form";
			this.Text = "DOL Source Generator V1.0";
			this.Load += new System.EventHandler(this.main_form_Load);
			this.ConnectionGroup.ResumeLayout(false);
			this.ViewGroup.ResumeLayout(false);
			this.TableGroup.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
		#region main
		[STAThread]
		static void Main() 
		{
			Application.Run(new main_form());
		}

		#endregion
		#region programmer added methods
		private void main_form_Load(object sender, System.EventArgs e)
		{

		}

		private void label2_Click(object sender, System.EventArgs e)
		{
		
		}
		
		//***************************
		//BEGIN CONNECT BUTTON METHOD
		//***************************
		private void ConnectButton_Click(object sender, System.EventArgs e) 
		{
			try
			{
				//*******************************************************
				//Define list to hold the tables of database being used
				//*******************************************************
				ArrayList TableList = new ArrayList();
				//**********************************************************
				//Create connection string from values entered in text boxes
				//**********************************************************
				string CONN_STRING = "Server="+ServerNameBox.Text+";"+
							         "Database="+DatabaseBox.Text+";"+
								     "User ID="+UserNameBox.Text+";"+
								     "Password="+PasswordBox.Text+";";
				//**********************************************************
				//Create DataBaseReader object using above connection string
				//**********************************************************
				DataBaseReader dbreader = new DataBaseReader(CONN_STRING);
				//*****************************
				//Send messages to message box
				//*****************************
				OutputBox.AppendText("Connected to SERVER:"+ServerNameBox.Text+"\r\n");
				OutputBox.AppendText("Using DATABASE:"+DatabaseBox.Text+"\r\n");
				//********************************************************************************
				//Reinitialize table combo box, read tables from database and assign to local list
				//********************************************************************************
				TableBox.Items.Clear();
				dbreader.GetTableList();
				TableList = dbreader.GetTableListArray();
				//***********************************
				//Populate combobox with new tables 
				//***********************************
				for (int z = 0; z < TableList.Count; z++)
				{
					TableBox.Items.Add(TableList[z]);
				}
				//***************************************************************************************
				//Close DataBaseReader object, disable connection controls, give focus to table combobox
				//***************************************************************************************
				dbreader.CloseDBConnection();
				ConnectionGroup.Enabled = false;
				TableGroup.Enabled = true;
				TableBox.Focus();
			} 
			catch (System.Exception caught)
			{
				MessageBox.Show(caught.Message);
			}
		}
		//**************************
		//END CONNECT BUTTON METHOD
		//**************************
		private void ViewBox_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		//***************************
		//BEGIN GenerateSource METHOD
		//***************************
		private void GenerateSource_Click(object sender, System.EventArgs e)
		{
			try 
			{
				
				//************************************************************
				//Create connection string from values entered in text boxes
				//************************************************************
				string CONN_STRING = "Server="+ServerNameBox.Text+";"+
								     "Database="+DatabaseBox.Text+";"+
									 "User ID="+UserNameBox.Text+";"+
									 "Password="+PasswordBox.Text+";";
				//**********************************************************
				//Create DataBaseReader object using above connection string
				//**********************************************************
				DataBaseReader dbreader1 = new DataBaseReader(CONN_STRING);
				dbreader1.ReadDataBase(TableBox.GetItemText(TableBox.Text));
				//*****************************
				//Send messages to message box
				//*****************************
				TableLabel.Text = "Table:"+TableBox.Text;
				SourceLabel.Text = "Source:"+TableBox.Text+".cs";
				OutputBox.AppendText("Parsed Table:"+TableBox.Text+"\r\n");
				//**************************
				//Clear out both View boxes
				//**************************
				TableViewBox.Text = "";
				ViewBox.Text = "";
				ViewGroup.Enabled = true;
				//*************************************************************************
				//Create GenertaeSourceObject for creating the source file				  *
				//*************************************************************************
				GenerateSourceObject gen_source1 = new  //source filename = selected table
					GenerateSourceObject(TableBox.GetItemText(TableBox.Text));
				//*******************************
				//Create the source file
				//*******************************
				gen_source1.WriteStream_const1();
				gen_source1.WriteStream_const2();
				gen_source1.WriteVariableDeclarations 
					(dbreader1.GetTypeArray(),dbreader1.GetFieldArray());
				gen_source1.WriteStream_const3();
				gen_source1.WriteMemberFunctions
					(dbreader1.GetTypeArray(),dbreader1.GetFieldArray(),dbreader1.GetNullListArray(),dbreader1.GetKeyNameArray(),dbreader1.GetIsUniqueArray(),dbreader1.GetColNameArray());
				gen_source1.CloseStream();
				//*******************************
				//Close DataBaseReader connection
				//*******************************
				dbreader1.CloseDBConnection();
				//*************************************************************************
				//Ouput generated source to Source View Box								  *
				//*************************************************************************
				StreamReader Instrm = new StreamReader("sources\\"+TableBox.GetItemText(TableBox.Text)+".cs");
				string line;
				do 
				{
					line = Instrm.ReadLine();
					ViewBox.AppendText(line+"\r\n");
				}
				while (line != null);
				Instrm.Close();
				//**************************************************************************
				//Output table in TableViewBox                                             *
				//**************************************************************************
				ArrayList TypeList = new ArrayList();
				ArrayList FieldList = new ArrayList();
				TypeList = dbreader1.GetMysqlTypeArray();
                FieldList = dbreader1.GetMysqlFieldArray();
				for (int ct = 0; ct < TypeList.Count; ct++)
				{
					TableViewBox.AppendText(TypeList[ct].ToString().PadRight(15)+"\t\t"+FieldList[ct]+"\r\n");
				}
				//**************************************************************************
				//**************************************************************************
			}
			catch (System.Exception caught)
			{
				MessageBox.Show(caught.Message);
			}
		}
		//****************************************
		//END GENERATE SOURCE METHOD
		//****************************************

		//************************************
		//BEGIN EXIT BUTTON METHOD
		//************************************
		private void ExitButton_Click(object sender, System.EventArgs e)
		{
			//**********************
			//Exit application
			//**********************
			Application.Exit();
		}
		//************************************
		//End EXIT BUTTON METHOD
		//************************************

		//************************************
		//BEGIN DISCONNECT BUTTON METHOD
		//************************************
		private void ClearButton_Click(object sender, System.EventArgs e)
		{
			//**************************************
			//Clear all controls except message box
			//**************************************
			OutputBox.AppendText("Disconnected from server:"+ServerNameBox.Text+"\r\n");
			ViewBox.Text = "";
			TableViewBox.Text = "";
			ServerNameBox.Text = "";
			UserNameBox.Text = "";
			PasswordBox.Text = "";
			DatabaseBox.Text = "";
			ViewGroup.Enabled = false;
			TableGroup.Enabled = false;
			ConnectionGroup.Enabled = true;
			SourceLabel.Text = "Source:";
			TableLabel.Text = "Table:";
			TableBox.Items.Clear();
			TableBox.Text = "Select a table";
			ServerNameBox.Focus();
		}

		private void ConnectionGroup_Enter(object sender, System.EventArgs e)
		{
		
		}

		private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
		
		}

		//*****************************
		//END DISCONNECT BUTTON METHOD
		//*****************************
		#endregion
		#endregion
	}
	#endregion
	#region GenerateSourceObject class
	//******************************
    //BEGIN GENERATE SOURCE CLASS
	//******************************
	public class GenerateSourceObject 
	{
		#region fields

		StreamWriter strm;
		string class_name;

		//*******************************
		//Keyword String definitions
		//*******************************
		const string const_1 = "using System;\r\nusing DOL.Database;"+
							   "\r\nusing DOL.Database.Attributes;\r\n\r\nnamespace DOL.Database\r\n{";
		const string const_2 = "\tpublic class ";
		const string const_8 = ":DataObject\r\n\t{\r\n";
		const string const_3 = "\t\tprivate static bool autoSave;";
		const string const_4 = "\t\toverride public bool AutoSave\r\n\t\t{\r\n\t\t\tget"+
						       "\r\n\t\t\t{\r\n\t\t\t\treturn autoSave;\r\n\t\t\t}\r\n\t\t\t"+
							   "set\r\n\t\t\t{\r\n\t\t\t\tautoSave = value;\r\n\t\t\t}\r\n\t\t}";
		const string const_6 = "autoSave = true;";
		//*****************************
		//Attribute string definitons
		//*****************************
		const string const_10 = "\t\t[DataElement(AllowDbNull=false, Unique=true)]";
		const string const_11 = "\t\t[DataElement(AllowDbNull=true, Unique=true)]";
		const string const_12 = "\t\t[DataElement(AllowDbNull=false)]";
		const string const_13 = "\t\t[DataElement(AllowDbNull=true)]";
		const string const_14 = "\t\t[PrimaryKey]";
		//*******************************
		//*******************************
		#endregion
		#region contructors
		//****************************************************
		//Constructor: Open output file, and assign class_name
		//****************************************************
		public GenerateSourceObject(string OutFile)
		{
			strm = new StreamWriter("sources\\"+OutFile+".cs",false);
			class_name = OutFile.Substring(0,1).ToUpper()+OutFile.Substring(1).ToLower();
		}
		#endregion
		#region methods
		
		//***************************************************
		//Methods to write string constants to output file
		//***************************************************
		public void WriteStream(string s)
		{
			strm.WriteLine(s);
		}
		public void WriteStream_const1()
		{
			strm.WriteLine(const_1);
		}
		public void WriteStream_const2()
		{
			strm.WriteLine(const_2+class_name+const_8);
		}
		public void WriteStream_const3()
		{
			strm.WriteLine(const_3);
		}

		//************************************************************
		//Method to write a single variable declaration
		//************************************************************
		public void WriteVariableDeclaration(string type, string name)
		{
			if (type == "datetime")
			{
				type = "DateTime";
			}
			strm.WriteLine("\t\tprivate "+type+" "+name+";");
		}
		//**************************************************************************
		//Method to write all variable declarations using WrtieVariableDeclaration()
		//**************************************************************************
		public void WriteVariableDeclarations(ArrayList T_Array, ArrayList F_Array)
		{
			for (int x = 0; x < T_Array.Count; x++)
			{
				this.WriteVariableDeclaration(T_Array[x].ToString().ToLower(), F_Array[x].ToString().ToLower());
			}
		}
		//**********************************************************************************
		//Method to write the member functions and their corresponding attribute statements
		//**********************************************************************************
		public void WriteMemberFunctions(ArrayList T_Array, ArrayList F_Array, ArrayList N_Array, ArrayList K_Name_Array, ArrayList U_Name_Array,ArrayList C_Name_Array)
		{
			//*************************
			//Write constant strings
			//*************************
			this.WriteStream("\t\tpublic "+class_name+"()\r\n\t\t{\t\t\t\r\n\t\t\t\t"+const_6+"\r\n\t\t}");
			this.WriteStream(const_4);

			//***********************************
			//Figure out what attribute to write
			//***********************************
			for (int x = 0; x < T_Array.Count; x++)
			{
				if (C_Name_Array.Count != 0)
				{
					for (int y = 0; y < C_Name_Array.Count; y++)
					{
						if (C_Name_Array[y].ToString() == F_Array[x].ToString().ToLower())
						{
							
							if (K_Name_Array[y].ToString() == "primary")
							{
								this.WriteStream(const_14);
								y = C_Name_Array.Count;
							}
							else if (U_Name_Array[y].ToString() == "0" && N_Array[x].ToString() == "yes")
							{
								this.WriteStream(const_11);
								y = C_Name_Array.Count;
							}
							else if (U_Name_Array[y].ToString() == "0" && N_Array[x].ToString() == "")
							{
								this.WriteStream(const_10);
								y = C_Name_Array.Count;
							}
						}
						else
						{
							if (N_Array[x].ToString() == "yes")
							{
								this.WriteStream(const_13);
								y = C_Name_Array.Count;
							}
							else if (N_Array[x].ToString() == "")
							{
								this.WriteStream(const_12);
								y = C_Name_Array.Count;
							}
						}
					}
				}
				else
				{
					{
						if (N_Array[x].ToString() == "yes")
						{
							this.WriteStream(const_13);
						}
						else if (N_Array[x].ToString() == "")
						{
							this.WriteStream(const_12);
						}
					}
				}
				//**************************************************
				//Write member function
				//**************************************************
				this.WriteStream("\t\tpublic " +T_Array[x]+" "+F_Array[x]+"\r\n\t\t{"); 
				this.WriteStream("\t\t\tget\r\n\t\t\t{\r\n\t\t\t\treturn "+F_Array[x].ToString().ToLower()+";\r\n\t\t\t}");
				this.WriteStream("\t\t\tset\r\n\t\t\t{\r\n\t\t\t\tDirty = true;\r\n\t\t\t\t"+F_Array[x].ToString().ToLower()+" = value;\r\n\t\t\t}\r\n\t\t}");
			}
			this.WriteStream("\t}\r\n}"); //close file stream
		}
		//*************************
		//BEGIN CLOSE STREAM METHOD
		//*************************
		public void CloseStream()
		{
			strm.Close();//close file stream
		}
		#endregion
	}

	#endregion
	#region DataBaseReader Class
	public class DataBaseReader
	{
		#region fields
		//***************************************
		//Create lists to hold table and key info
		//***************************************
		ArrayList TypeArray = new ArrayList();//C# data types
		ArrayList FieldArray = new ArrayList();//C# variable names
		ArrayList MysqlTypeArray = new ArrayList();//mysql data types
		ArrayList MysqlFieldArray = new ArrayList();//mysql variable names
		ArrayList TableListArray = new ArrayList();//tables
		ArrayList NullListArray = new ArrayList();//table null values
		ArrayList KeyNameArray = new ArrayList();//key type
		ArrayList IsUniqueArray = new ArrayList();//non-unique column
		ArrayList ColNameArray = new ArrayList();//key field
		MySqlConnection dbcon; //database connection
		 
		#endregion
		#region constructors
		//*********************************
		//constructor: open mysql database
		//*********************************
		public DataBaseReader(string connect_string)
		{
			dbcon = new MySqlConnection(connect_string);
			dbcon.Open();
		}
		#endregion
		#region methods
		//*****************************************************************
		//Method to populate TableListArray with all tables in the database
		//*****************************************************************
		public void GetTableList()
		{
			string sql_cmd_get_tables = "SHOW TABLES";
			IDbCommand dbcmd = dbcon.CreateCommand();
			dbcmd.CommandText = sql_cmd_get_tables;
			IDataReader reader = dbcmd.ExecuteReader();
			while(reader.Read())
			{
				string table = (string) reader[0];
				TableListArray.Add(table);
			}
		}
		//**************************************************************************************
		//Method to read the database and populate all other lists with their corresponding data
		//**************************************************************************************
		public void ReadDataBase(string table_name)
		{		

			string sql_cmd_describe_tables = "DESCRIBE " + table_name;
			string sql_cmd_show_index = "SHOW KEYS FROM " + table_name;
			string f_string_left;
			string f_string_right;
			string delimStr = "(";
			char [] delimiter = delimStr.ToCharArray();
			string [] new_type = null;

			IDbCommand dbcmd = dbcon.CreateCommand();
			dbcmd.CommandText = sql_cmd_show_index;
			IDataReader reader_index = dbcmd.ExecuteReader();
			while (reader_index.Read())
			{
				string isunique = reader_index[1].ToString();
				string keyname =  reader_index[2].ToString();
				string ColName =  reader_index[4].ToString();
				KeyNameArray.Add(keyname.ToLower());
				IsUniqueArray.Add(isunique);
				ColNameArray.Add(ColName.ToLower());
			}
			reader_index.Close(); //close reader
			dbcmd.CommandText = sql_cmd_describe_tables;
			IDataReader reader_describe = dbcmd.ExecuteReader();
			while(reader_describe.Read())
			{
				string field = (string) reader_describe[0];
				string type = (string) reader_describe[1];
				string NullField = (string) reader_describe[2];
				string KeyField = (string) reader_describe[3];
				NullListArray.Add(NullField.ToLower());
				MysqlFieldArray.Add(field);
				MysqlTypeArray.Add(type);
				new_type = type.Split(delimiter,2);
				type = new_type[0].ToLower();
				switch (type)
				{
					case "tinyint" : type = "bool";break;
					case "boolean" : type = "bool";break;
					case "bool" : type = "bool";break;
					case "date" : type = "DateTime";break;
					case "datetime" : type = "DateTime"; break;
					case "smallint" : type = "int";break;
					case "mediumint" : type = "int";break;
					case "integer" : type = "int";break;
					case "int" : type = "int";break;
					case "float" : type = "float";break;
					case "double" : type = "double";break;
					case "real" : type = "double";break;
					case "dec" : type = "decimal"; break;
					case "numeric" : type = "decimal";break;
					case "decimal" : type = "decimal";break;
					case "char" : type = "string";break;
					case "tinyblob" : type = "string";break;
					case "tinytext" : type = "string";break;
					case "text" : type = "string";break;
					case "mediumblob" : type = "string";break;
					case "longblob" : type = "string";break;
					case "longtest" : type = "string";break;
					case "varchar" : type = "string";break;
					default: type = "string";break;
				}
				f_string_left = field.Substring(0,1);
				f_string_right = field.Substring(1);
				field = f_string_left.ToUpper()+f_string_right.ToLower();
                FieldArray.Add(field);
				TypeArray.Add(type);
			}
			reader_describe.Close(); //close reader
		}
		//***********************************
		//Method to close database connection
		//***********************************
		public void CloseDBConnection()
		{
			dbcon.Close();
			dbcon = null;
		}
		//*************************************
		//Accessor methods to return ArrayLists
		//*************************************
		public ArrayList GetTypeArray()
		{
			return TypeArray;
		}
		public ArrayList GetMysqlTypeArray()
		{
			return MysqlTypeArray;
		}
		public ArrayList GetMysqlFieldArray()
		{
			return MysqlFieldArray;
		}
		public ArrayList GetFieldArray()
		{
			return FieldArray;
		}
		public ArrayList GetTableListArray()
		{
			return TableListArray;
		}
		public ArrayList GetNullListArray()
		{
			return NullListArray;
		}
		public ArrayList GetKeyNameArray()
		{
			return KeyNameArray;
		}
		public ArrayList GetIsUniqueArray()
		{
			return IsUniqueArray;
		}
		public ArrayList GetColNameArray()
		{
			return ColNameArray;
		}
		#endregion
	}	
	#endregion
}
#endregion
