using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private MedicalClaimsDataSet medicalClaimsDataSet;
        private BindingSource pATIENTBindingSource;
        private IContainer components;
        private MedicalClaimsDataSetTableAdapters.PATIENTTableAdapter pATIENTTableAdapter;
        private MedicalClaimsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BindingNavigator pATIENTBindingNavigator;
        private ToolStripButton bindingNavigatorAddNewItem;
        private ToolStripLabel bindingNavigatorCountItem;
        private ToolStripButton bindingNavigatorDeleteItem;
        private ToolStripButton bindingNavigatorMoveFirstItem;
        private ToolStripButton bindingNavigatorMovePreviousItem;
        private ToolStripSeparator bindingNavigatorSeparator;
        private ToolStripTextBox bindingNavigatorPositionItem;
        private ToolStripSeparator bindingNavigatorSeparator1;
        private ToolStripButton bindingNavigatorMoveNextItem;
        private ToolStripButton bindingNavigatorMoveLastItem;
        private ToolStripSeparator bindingNavigatorSeparator2;
        private TextBox p_LNAMETextBox;
        private TextBox p_FNAMETextBox;
        private TextBox p_ADDR1TextBox;
        private TextBox p_ADDR2TextBox;
        private TextBox p_CITYTextBox;
        private TextBox p_STTextBox;
        private TextBox p_ZIPTextBox;
        private TextBox p_AREATextBox;
        private TextBox p_PHONETextBox;
        private TextBox p_MARRIEDTextBox;
        private TextBox p_STUDENTTextBox;
        private TextBox p_EMPLOYEDTextBox;
        private TextBox i_IDTextBox;
        private TextBox p_RELTextBox;
        private TextBox p_ENT_DTTextBox;
        private TextBox p_UPD_DTTextBox;
        private TextBox p_NUMBERTextBox;
        private ToolStripButton pATIENTBindingNavigatorSaveItem;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medicalClaimsDataSet.PATIENT' table. You can move, or remove it, as needed.
            this.pATIENTTableAdapter.Fill(this.medicalClaimsDataSet.PATIENT);

        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label p_LNAMELabel;
            System.Windows.Forms.Label p_FNAMELabel;
            System.Windows.Forms.Label p_ADDR1Label;
            System.Windows.Forms.Label p_ADDR2Label;
            System.Windows.Forms.Label p_CITYLabel;
            System.Windows.Forms.Label p_STLabel;
            System.Windows.Forms.Label p_ZIPLabel;
            System.Windows.Forms.Label p_AREALabel;
            System.Windows.Forms.Label p_MARRIEDLabel;
            System.Windows.Forms.Label p_STUDENTLabel;
            System.Windows.Forms.Label p_EMPLOYEDLabel;
            System.Windows.Forms.Label i_IDLabel;
            System.Windows.Forms.Label p_RELLabel;
            System.Windows.Forms.Label p_ENT_DTLabel;
            System.Windows.Forms.Label p_UPD_DTLabel;
            System.Windows.Forms.Label p_NUMBERLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.medicalClaimsDataSet = new WindowsFormsApp1.MedicalClaimsDataSet();
            this.pATIENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pATIENTTableAdapter = new WindowsFormsApp1.MedicalClaimsDataSetTableAdapters.PATIENTTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.MedicalClaimsDataSetTableAdapters.TableAdapterManager();
            this.pATIENTBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pATIENTBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.p_LNAMETextBox = new System.Windows.Forms.TextBox();
            this.p_FNAMETextBox = new System.Windows.Forms.TextBox();
            this.p_ADDR1TextBox = new System.Windows.Forms.TextBox();
            this.p_ADDR2TextBox = new System.Windows.Forms.TextBox();
            this.p_CITYTextBox = new System.Windows.Forms.TextBox();
            this.p_STTextBox = new System.Windows.Forms.TextBox();
            this.p_ZIPTextBox = new System.Windows.Forms.TextBox();
            this.p_AREATextBox = new System.Windows.Forms.TextBox();
            this.p_PHONETextBox = new System.Windows.Forms.TextBox();
            this.p_MARRIEDTextBox = new System.Windows.Forms.TextBox();
            this.p_STUDENTTextBox = new System.Windows.Forms.TextBox();
            this.p_EMPLOYEDTextBox = new System.Windows.Forms.TextBox();
            this.i_IDTextBox = new System.Windows.Forms.TextBox();
            this.p_RELTextBox = new System.Windows.Forms.TextBox();
            this.p_ENT_DTTextBox = new System.Windows.Forms.TextBox();
            this.p_UPD_DTTextBox = new System.Windows.Forms.TextBox();
            this.p_NUMBERTextBox = new System.Windows.Forms.TextBox();
            p_LNAMELabel = new System.Windows.Forms.Label();
            p_FNAMELabel = new System.Windows.Forms.Label();
            p_ADDR1Label = new System.Windows.Forms.Label();
            p_ADDR2Label = new System.Windows.Forms.Label();
            p_CITYLabel = new System.Windows.Forms.Label();
            p_STLabel = new System.Windows.Forms.Label();
            p_ZIPLabel = new System.Windows.Forms.Label();
            p_AREALabel = new System.Windows.Forms.Label();
            p_MARRIEDLabel = new System.Windows.Forms.Label();
            p_STUDENTLabel = new System.Windows.Forms.Label();
            p_EMPLOYEDLabel = new System.Windows.Forms.Label();
            i_IDLabel = new System.Windows.Forms.Label();
            p_RELLabel = new System.Windows.Forms.Label();
            p_ENT_DTLabel = new System.Windows.Forms.Label();
            p_UPD_DTLabel = new System.Windows.Forms.Label();
            p_NUMBERLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.medicalClaimsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTBindingNavigator)).BeginInit();
            this.pATIENTBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_LNAMELabel
            // 
            p_LNAMELabel.AutoSize = true;
            p_LNAMELabel.Location = new System.Drawing.Point(88, 75);
            p_LNAMELabel.Name = "p_LNAMELabel";
            p_LNAMELabel.Size = new System.Drawing.Size(58, 13);
            p_LNAMELabel.TabIndex = 1;
            p_LNAMELabel.Text = "LastName:";
            // 
            // p_FNAMELabel
            // 
            p_FNAMELabel.AutoSize = true;
            p_FNAMELabel.Location = new System.Drawing.Point(332, 75);
            p_FNAMELabel.Name = "p_FNAMELabel";
            p_FNAMELabel.Size = new System.Drawing.Size(55, 13);
            p_FNAMELabel.TabIndex = 3;
            p_FNAMELabel.Text = "Firstname:";
            // 
            // p_ADDR1Label
            // 
            p_ADDR1Label.AutoSize = true;
            p_ADDR1Label.Location = new System.Drawing.Point(91, 100);
            p_ADDR1Label.Name = "p_ADDR1Label";
            p_ADDR1Label.Size = new System.Drawing.Size(57, 13);
            p_ADDR1Label.TabIndex = 5;
            p_ADDR1Label.Text = "P ADDR1:";
            // 
            // p_ADDR2Label
            // 
            p_ADDR2Label.AutoSize = true;
            p_ADDR2Label.Location = new System.Drawing.Point(88, 126);
            p_ADDR2Label.Name = "p_ADDR2Label";
            p_ADDR2Label.Size = new System.Drawing.Size(57, 13);
            p_ADDR2Label.TabIndex = 7;
            p_ADDR2Label.Text = "P ADDR2:";
            // 
            // p_CITYLabel
            // 
            p_CITYLabel.AutoSize = true;
            p_CITYLabel.Location = new System.Drawing.Point(101, 152);
            p_CITYLabel.Name = "p_CITYLabel";
            p_CITYLabel.Size = new System.Drawing.Size(44, 13);
            p_CITYLabel.TabIndex = 9;
            p_CITYLabel.Text = "P CITY:";
            // 
            // p_STLabel
            // 
            p_STLabel.AutoSize = true;
            p_STLabel.Location = new System.Drawing.Point(295, 155);
            p_STLabel.Name = "p_STLabel";
            p_STLabel.Size = new System.Drawing.Size(34, 13);
            p_STLabel.TabIndex = 11;
            p_STLabel.Text = "P ST:";
            // 
            // p_ZIPLabel
            // 
            p_ZIPLabel.AutoSize = true;
            p_ZIPLabel.Location = new System.Drawing.Point(396, 155);
            p_ZIPLabel.Name = "p_ZIPLabel";
            p_ZIPLabel.Size = new System.Drawing.Size(37, 13);
            p_ZIPLabel.TabIndex = 13;
            p_ZIPLabel.Text = "P ZIP:";
            // 
            // p_AREALabel
            // 
            p_AREALabel.AutoSize = true;
            p_AREALabel.Location = new System.Drawing.Point(96, 180);
            p_AREALabel.Name = "p_AREALabel";
            p_AREALabel.Size = new System.Drawing.Size(49, 13);
            p_AREALabel.TabIndex = 15;
            p_AREALabel.Text = "P AREA:";
            // 
            // p_MARRIEDLabel
            // 
            p_MARRIEDLabel.AutoSize = true;
            p_MARRIEDLabel.Location = new System.Drawing.Point(78, 206);
            p_MARRIEDLabel.Name = "p_MARRIEDLabel";
            p_MARRIEDLabel.Size = new System.Drawing.Size(70, 13);
            p_MARRIEDLabel.TabIndex = 19;
            p_MARRIEDLabel.Text = "P MARRIED:";
            // 
            // p_STUDENTLabel
            // 
            p_STUDENTLabel.AutoSize = true;
            p_STUDENTLabel.Location = new System.Drawing.Point(272, 209);
            p_STUDENTLabel.Name = "p_STUDENTLabel";
            p_STUDENTLabel.Size = new System.Drawing.Size(72, 13);
            p_STUDENTLabel.TabIndex = 21;
            p_STUDENTLabel.Text = "P STUDENT:";
            // 
            // p_EMPLOYEDLabel
            // 
            p_EMPLOYEDLabel.AutoSize = true;
            p_EMPLOYEDLabel.Location = new System.Drawing.Point(465, 212);
            p_EMPLOYEDLabel.Name = "p_EMPLOYEDLabel";
            p_EMPLOYEDLabel.Size = new System.Drawing.Size(79, 13);
            p_EMPLOYEDLabel.TabIndex = 23;
            p_EMPLOYEDLabel.Text = "P EMPLOYED:";
            // 
            // i_IDLabel
            // 
            i_IDLabel.AutoSize = true;
            i_IDLabel.Location = new System.Drawing.Point(721, 78);
            i_IDLabel.Name = "i_IDLabel";
            i_IDLabel.Size = new System.Drawing.Size(68, 13);
            i_IDLabel.TabIndex = 25;
            i_IDLabel.Text = "InsuranceID:";
            // 
            // p_RELLabel
            // 
            p_RELLabel.AutoSize = true;
            p_RELLabel.Location = new System.Drawing.Point(748, 104);
            p_RELLabel.Name = "p_RELLabel";
            p_RELLabel.Size = new System.Drawing.Size(41, 13);
            p_RELLabel.TabIndex = 27;
            p_RELLabel.Text = "P REL:";
            // 
            // p_ENT_DTLabel
            // 
            p_ENT_DTLabel.AutoSize = true;
            p_ENT_DTLabel.Location = new System.Drawing.Point(729, 130);
            p_ENT_DTLabel.Name = "p_ENT_DTLabel";
            p_ENT_DTLabel.Size = new System.Drawing.Size(60, 13);
            p_ENT_DTLabel.TabIndex = 29;
            p_ENT_DTLabel.Text = "P ENT DT:";
            // 
            // p_UPD_DTLabel
            // 
            p_UPD_DTLabel.AutoSize = true;
            p_UPD_DTLabel.Location = new System.Drawing.Point(728, 156);
            p_UPD_DTLabel.Name = "p_UPD_DTLabel";
            p_UPD_DTLabel.Size = new System.Drawing.Size(61, 13);
            p_UPD_DTLabel.TabIndex = 31;
            p_UPD_DTLabel.Text = "P UPD DT:";
            // 
            // p_NUMBERLabel
            // 
            p_NUMBERLabel.AutoSize = true;
            p_NUMBERLabel.Location = new System.Drawing.Point(82, 54);
            p_NUMBERLabel.Name = "p_NUMBERLabel";
            p_NUMBERLabel.Size = new System.Drawing.Size(67, 13);
            p_NUMBERLabel.TabIndex = 32;
            p_NUMBERLabel.Text = "P NUMBER:";
            // 
            // medicalClaimsDataSet
            // 
            this.medicalClaimsDataSet.DataSetName = "MedicalClaimsDataSet";
            this.medicalClaimsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pATIENTBindingSource
            // 
            this.pATIENTBindingSource.DataMember = "PATIENT";
            this.pATIENTBindingSource.DataSource = this.medicalClaimsDataSet;
            // 
            // pATIENTTableAdapter
            // 
            this.pATIENTTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AMBTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BPOSCODETableAdapter = null;
            this.tableAdapterManager.CLAIMINSTableAdapter = null;
            this.tableAdapterManager.CLAIMRPTableAdapter = null;
            this.tableAdapterManager.CLAIMSTableAdapter = null;
            this.tableAdapterManager.CTYPETableAdapter = null;
            this.tableAdapterManager.DIAGTableAdapter = null;
            this.tableAdapterManager.DOCTableAdapter = null;
            this.tableAdapterManager.DOCTORTableAdapter = null;
            this.tableAdapterManager.DRTableAdapter = null;
            this.tableAdapterManager.E_RECSTableAdapter = null;
            this.tableAdapterManager.GA0TableAdapter = null;
            this.tableAdapterManager.HA0TableAdapter = null;
            this.tableAdapterManager.HOSPITALTableAdapter = null;
            this.tableAdapterManager.ICD10TableAdapter = null;
            this.tableAdapterManager.INSUREDTableAdapter = null;
            this.tableAdapterManager.MISCTableAdapter = null;
            this.tableAdapterManager.MPOSCODETableAdapter = null;
            this.tableAdapterManager.PATDIAGTableAdapter = null;
            this.tableAdapterManager.PATIENTTableAdapter = this.pATIENTTableAdapter;
            this.tableAdapterManager.PAYDETTableAdapter = null;
            this.tableAdapterManager.PAYHISTTableAdapter = null;
            this.tableAdapterManager.PHCODETableAdapter = null;
            this.tableAdapterManager.PMSCODETableAdapter = null;
            this.tableAdapterManager.PRCODETableAdapter = null;
            this.tableAdapterManager.PROCTableAdapter = null;
            this.tableAdapterManager.TOSCODETableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.MedicalClaimsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pATIENTBindingNavigator
            // 
            this.pATIENTBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pATIENTBindingNavigator.BindingSource = this.pATIENTBindingSource;
            this.pATIENTBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pATIENTBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pATIENTBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.pATIENTBindingNavigatorSaveItem});
            this.pATIENTBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pATIENTBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pATIENTBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pATIENTBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pATIENTBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pATIENTBindingNavigator.Name = "pATIENTBindingNavigator";
            this.pATIENTBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pATIENTBindingNavigator.Size = new System.Drawing.Size(1246, 25);
            this.pATIENTBindingNavigator.TabIndex = 0;
            this.pATIENTBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // pATIENTBindingNavigatorSaveItem
            // 
            this.pATIENTBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pATIENTBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pATIENTBindingNavigatorSaveItem.Image")));
            this.pATIENTBindingNavigatorSaveItem.Name = "pATIENTBindingNavigatorSaveItem";
            this.pATIENTBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pATIENTBindingNavigatorSaveItem.Text = "Save Data";
            this.pATIENTBindingNavigatorSaveItem.Click += new System.EventHandler(this.pATIENTBindingNavigatorSaveItem_Click);
            // 
            // p_LNAMETextBox
            // 
            this.p_LNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pATIENTBindingSource, "P_LNAME", true));
            this.p_LNAMETextBox.Location = new System.Drawing.Point(154, 72);
            this.p_LNAMETextBox.Name = "p_LNAMETextBox";
            this.p_LNAMETextBox.Size = new System.Drawing.Size(175, 20);
            this.p_LNAMETextBox.TabIndex = 2;
            // 
            // p_FNAMETextBox
            // 
            this.p_FNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pATIENTBindingSource, "P_FNAME", true));
            this.p_FNAMETextBox.Location = new System.Drawing.Point(395, 72);
            this.p_FNAMETextBox.Name = "p_FNAMETextBox";
            this.p_FNAMETextBox.Size = new System.Drawing.Size(100, 20);
            this.p_FNAMETextBox.TabIndex = 4;
            // 
            // p_ADDR1TextBox
            // 
            this.p_ADDR1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pATIENTBindingSource, "P_ADDR1", true));
            this.p_ADDR1TextBox.Location = new System.Drawing.Point(154, 97);
            this.p_ADDR1TextBox.Name = "p_ADDR1TextBox";
            this.p_ADDR1TextBox.Size = new System.Drawing.Size(341, 20);
            this.p_ADDR1TextBox.TabIndex = 6;
            // 
            // p_ADDR2TextBox
            // 
            this.p_ADDR2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pATIENTBindingSource, "P_ADDR2", true));
            this.p_ADDR2TextBox.Location = new System.Drawing.Point(154, 123);
            this.p_ADDR2TextBox.Name = "p_ADDR2TextBox";
            this.p_ADDR2TextBox.Size = new System.Drawing.Size(344, 20);
            this.p_ADDR2TextBox.TabIndex = 8;
            // 
            // p_CITYTextBox
            // 
            this.p_CITYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pATIENTBindingSource, "P_CITY", true));
            this.p_CITYTextBox.Location = new System.Drawing.Point(154, 149);
            this.p_CITYTextBox.Name = "p_CITYTextBox";
            this.p_CITYTextBox.Size = new System.Drawing.Size(141, 20);
            this.p_CITYTextBox.TabIndex = 10;
            // 
            // p_STTextBox
            // 
            this.p_STTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pATIENTBindingSource, "P_ST", true));
            this.p_STTextBox.Location = new System.Drawing.Point(335, 152);
            this.p_STTextBox.Name = "p_STTextBox";
            this.p_STTextBox.Size = new System.Drawing.Size(47, 20);
            this.p_STTextBox.TabIndex = 12;
            // 
            // p_ZIPTextBox
            // 
            this.p_ZIPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pATIENTBindingSource, "P_ZIP", true));
            this.p_ZIPTextBox.Location = new System.Drawing.Point(439, 152);
            this.p_ZIPTextBox.Name = "p_ZIPTextBox";
            this.p_ZIPTextBox.Size = new System.Drawing.Size(100, 20);
            this.p_ZIPTextBox.TabIndex = 14;
            // 
            // p_AREATextBox
            // 
            this.p_AREATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pATIENTBindingSource, "P_AREA", true));
            this.p_AREATextBox.Location = new System.Drawing.Point(154, 177);
            this.p_AREATextBox.Name = "p_AREATextBox";
            this.p_AREATextBox.Size = new System.Drawing.Size(54, 20);
            this.p_AREATextBox.TabIndex = 16;
            // 
            // p_PHONETextBox
            // 
            this.p_PHONETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pATIENTBindingSource, "P_PHONE", true));
            this.p_PHONETextBox.Location = new System.Drawing.Point(211, 175);
            this.p_PHONETextBox.Name = "p_PHONETextBox";
            this.p_PHONETextBox.Size = new System.Drawing.Size(100, 20);
            this.p_PHONETextBox.TabIndex = 18;
            // 
            // p_MARRIEDTextBox
            // 
            this.p_MARRIEDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pATIENTBindingSource, "P_MARRIED", true));
            this.p_MARRIEDTextBox.Location = new System.Drawing.Point(154, 203);
            this.p_MARRIEDTextBox.Name = "p_MARRIEDTextBox";
            this.p_MARRIEDTextBox.Size = new System.Drawing.Size(100, 20);
            this.p_MARRIEDTextBox.TabIndex = 20;
            // 
            // p_STUDENTTextBox
            // 
            this.p_STUDENTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pATIENTBindingSource, "P_STUDENT", true));
            this.p_STUDENTTextBox.Location = new System.Drawing.Point(350, 206);
            this.p_STUDENTTextBox.Name = "p_STUDENTTextBox";
            this.p_STUDENTTextBox.Size = new System.Drawing.Size(100, 20);
            this.p_STUDENTTextBox.TabIndex = 22;
            // 
            // p_EMPLOYEDTextBox
            // 
            this.p_EMPLOYEDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pATIENTBindingSource, "P_EMPLOYED", true));
            this.p_EMPLOYEDTextBox.Location = new System.Drawing.Point(550, 209);
            this.p_EMPLOYEDTextBox.Name = "p_EMPLOYEDTextBox";
            this.p_EMPLOYEDTextBox.Size = new System.Drawing.Size(100, 20);
            this.p_EMPLOYEDTextBox.TabIndex = 24;
            // 
            // i_IDTextBox
            // 
            this.i_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pATIENTBindingSource, "I_ID", true));
            this.i_IDTextBox.Location = new System.Drawing.Point(795, 75);
            this.i_IDTextBox.Name = "i_IDTextBox";
            this.i_IDTextBox.Size = new System.Drawing.Size(120, 20);
            this.i_IDTextBox.TabIndex = 26;
            // 
            // p_RELTextBox
            // 
            this.p_RELTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pATIENTBindingSource, "P_REL", true));
            this.p_RELTextBox.Location = new System.Drawing.Point(795, 101);
            this.p_RELTextBox.Name = "p_RELTextBox";
            this.p_RELTextBox.Size = new System.Drawing.Size(100, 20);
            this.p_RELTextBox.TabIndex = 28;
            // 
            // p_ENT_DTTextBox
            // 
            this.p_ENT_DTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pATIENTBindingSource, "P_ENT_DT", true));
            this.p_ENT_DTTextBox.Location = new System.Drawing.Point(795, 127);
            this.p_ENT_DTTextBox.Name = "p_ENT_DTTextBox";
            this.p_ENT_DTTextBox.Size = new System.Drawing.Size(100, 20);
            this.p_ENT_DTTextBox.TabIndex = 30;
            // 
            // p_UPD_DTTextBox
            // 
            this.p_UPD_DTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pATIENTBindingSource, "P_UPD_DT", true));
            this.p_UPD_DTTextBox.Location = new System.Drawing.Point(795, 153);
            this.p_UPD_DTTextBox.Name = "p_UPD_DTTextBox";
            this.p_UPD_DTTextBox.Size = new System.Drawing.Size(100, 20);
            this.p_UPD_DTTextBox.TabIndex = 32;
            // 
            // p_NUMBERTextBox
            // 
            this.p_NUMBERTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pATIENTBindingSource, "P_NUMBER", true));
            this.p_NUMBERTextBox.Location = new System.Drawing.Point(154, 51);
            this.p_NUMBERTextBox.Name = "p_NUMBERTextBox";
            this.p_NUMBERTextBox.Size = new System.Drawing.Size(100, 20);
            this.p_NUMBERTextBox.TabIndex = 33;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1246, 540);
            this.Controls.Add(p_NUMBERLabel);
            this.Controls.Add(this.p_NUMBERTextBox);
            this.Controls.Add(p_UPD_DTLabel);
            this.Controls.Add(this.p_UPD_DTTextBox);
            this.Controls.Add(p_ENT_DTLabel);
            this.Controls.Add(this.p_ENT_DTTextBox);
            this.Controls.Add(p_RELLabel);
            this.Controls.Add(this.p_RELTextBox);
            this.Controls.Add(i_IDLabel);
            this.Controls.Add(this.i_IDTextBox);
            this.Controls.Add(p_EMPLOYEDLabel);
            this.Controls.Add(this.p_EMPLOYEDTextBox);
            this.Controls.Add(p_STUDENTLabel);
            this.Controls.Add(this.p_STUDENTTextBox);
            this.Controls.Add(p_MARRIEDLabel);
            this.Controls.Add(this.p_MARRIEDTextBox);
            this.Controls.Add(this.p_PHONETextBox);
            this.Controls.Add(p_AREALabel);
            this.Controls.Add(this.p_AREATextBox);
            this.Controls.Add(p_ZIPLabel);
            this.Controls.Add(this.p_ZIPTextBox);
            this.Controls.Add(p_STLabel);
            this.Controls.Add(this.p_STTextBox);
            this.Controls.Add(p_CITYLabel);
            this.Controls.Add(this.p_CITYTextBox);
            this.Controls.Add(p_ADDR2Label);
            this.Controls.Add(this.p_ADDR2TextBox);
            this.Controls.Add(p_ADDR1Label);
            this.Controls.Add(this.p_ADDR1TextBox);
            this.Controls.Add(p_FNAMELabel);
            this.Controls.Add(this.p_FNAMETextBox);
            this.Controls.Add(p_LNAMELabel);
            this.Controls.Add(this.p_LNAMETextBox);
            this.Controls.Add(this.pATIENTBindingNavigator);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.medicalClaimsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTBindingNavigator)).EndInit();
            this.pATIENTBindingNavigator.ResumeLayout(false);
            this.pATIENTBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void pATIENTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pATIENTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.medicalClaimsDataSet);

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medicalClaimsDataSet.PATIENT' table. You can move, or remove it, as needed.
            this.pATIENTTableAdapter.Fill(this.medicalClaimsDataSet.PATIENT);

        }

        private void pATIENTDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
