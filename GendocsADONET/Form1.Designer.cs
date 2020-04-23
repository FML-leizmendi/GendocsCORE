namespace GendocsADONET
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label codBusquedaLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.genDoc_sysDataSet = new GendocsADONET.GenDoc_sysDataSet();
            this.sysBusquedasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sysBusquedasTableAdapter = new GendocsADONET.GenDoc_sysDataSetTableAdapters.sysBusquedasTableAdapter();
            this.tableAdapterManager = new GendocsADONET.GenDoc_sysDataSetTableAdapters.TableAdapterManager();
            this.sysBusquedasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.sysBusquedasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.codBusquedaTextBox = new System.Windows.Forms.TextBox();
            this.sysBusquedasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            codBusquedaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.genDoc_sysDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysBusquedasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysBusquedasBindingNavigator)).BeginInit();
            this.sysBusquedasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sysBusquedasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(194, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 63);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // genDoc_sysDataSet
            // 
            this.genDoc_sysDataSet.DataSetName = "GenDoc_sysDataSet";
            this.genDoc_sysDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sysBusquedasBindingSource
            // 
            this.sysBusquedasBindingSource.DataMember = "sysBusquedas";
            this.sysBusquedasBindingSource.DataSource = this.genDoc_sysDataSet;
            // 
            // sysBusquedasTableAdapter
            // 
            this.sysBusquedasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.sysAnchurasTableAdapter = null;
            this.tableAdapterManager.sysBusquedasTableAdapter = this.sysBusquedasTableAdapter;
            this.tableAdapterManager.sysColoresTableAdapter = null;
            this.tableAdapterManager.sysExportCabTableAdapter = null;
            this.tableAdapterManager.sysExportDetTableAdapter = null;
            this.tableAdapterManager.sysFuncionesTableAdapter = null;
            this.tableAdapterManager.sysGenesisCamposCabTableAdapter = null;
            this.tableAdapterManager.sysGenesisCamposDetTableAdapter = null;
            this.tableAdapterManager.sysIdSelectTableAdapter = null;
            this.tableAdapterManager.sysOpcionesTableAdapter = null;
            this.tableAdapterManager.sysSeleccionesVariasTableAdapter = null;
            this.tableAdapterManager.sysTiposDatosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GendocsADONET.GenDoc_sysDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sysBusquedasBindingNavigator
            // 
            this.sysBusquedasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sysBusquedasBindingNavigator.BindingSource = this.sysBusquedasBindingSource;
            this.sysBusquedasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sysBusquedasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sysBusquedasBindingNavigator.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.sysBusquedasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.sysBusquedasBindingNavigatorSaveItem});
            this.sysBusquedasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sysBusquedasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sysBusquedasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sysBusquedasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sysBusquedasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sysBusquedasBindingNavigator.Name = "sysBusquedasBindingNavigator";
            this.sysBusquedasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sysBusquedasBindingNavigator.Size = new System.Drawing.Size(2021, 44);
            this.sysBusquedasBindingNavigator.TabIndex = 3;
            this.sysBusquedasBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(40, 19);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(40, 32);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 35);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(65, 30);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(40, 32);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(40, 32);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(40, 38);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(40, 32);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // sysBusquedasBindingNavigatorSaveItem
            // 
            this.sysBusquedasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sysBusquedasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sysBusquedasBindingNavigatorSaveItem.Image")));
            this.sysBusquedasBindingNavigatorSaveItem.Name = "sysBusquedasBindingNavigatorSaveItem";
            this.sysBusquedasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.sysBusquedasBindingNavigatorSaveItem.Text = "Guardar datos";
            this.sysBusquedasBindingNavigatorSaveItem.Click += new System.EventHandler(this.sysBusquedasBindingNavigatorSaveItem_Click);
            // 
            // codBusquedaLabel
            // 
            codBusquedaLabel.AutoSize = true;
            codBusquedaLabel.Location = new System.Drawing.Point(342, 122);
            codBusquedaLabel.Name = "codBusquedaLabel";
            codBusquedaLabel.Size = new System.Drawing.Size(149, 25);
            codBusquedaLabel.TabIndex = 4;
            codBusquedaLabel.Text = "Cod Busqueda:";
            // 
            // codBusquedaTextBox
            // 
            this.codBusquedaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sysBusquedasBindingSource, "CodBusqueda", true));
            this.codBusquedaTextBox.Location = new System.Drawing.Point(497, 118);
            this.codBusquedaTextBox.Name = "codBusquedaTextBox";
            this.codBusquedaTextBox.Size = new System.Drawing.Size(100, 29);
            this.codBusquedaTextBox.TabIndex = 5;
            // 
            // sysBusquedasDataGridView
            // 
            this.sysBusquedasDataGridView.AutoGenerateColumns = false;
            this.sysBusquedasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sysBusquedasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewCheckBoxColumn1});
            this.sysBusquedasDataGridView.DataSource = this.sysBusquedasBindingSource;
            this.sysBusquedasDataGridView.Location = new System.Drawing.Point(12, 196);
            this.sysBusquedasDataGridView.Name = "sysBusquedasDataGridView";
            this.sysBusquedasDataGridView.RowHeadersWidth = 72;
            this.sysBusquedasDataGridView.RowTemplate.Height = 31;
            this.sysBusquedasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sysBusquedasDataGridView.Size = new System.Drawing.Size(2002, 630);
            this.sysBusquedasDataGridView.TabIndex = 5;
            this.sysBusquedasDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sysBusquedasDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CodBusqueda";
            this.dataGridViewTextBoxColumn1.HeaderText = "CodBusqueda";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 175;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "strSQL";
            this.dataGridViewTextBoxColumn2.HeaderText = "strSQL";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 175;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NumColumnas";
            this.dataGridViewTextBoxColumn3.HeaderText = "NumColumnas";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 175;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "AnchoColumnas";
            this.dataGridViewTextBoxColumn4.HeaderText = "AnchoColumnas";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 175;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ColumnaDependiente";
            this.dataGridViewTextBoxColumn5.HeaderText = "ColumnaDependiente";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 175;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "AnchoLst";
            this.dataGridViewTextBoxColumn6.HeaderText = "AnchoLst";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 175;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "AltoLst";
            this.dataGridViewTextBoxColumn7.HeaderText = "AltoLst";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 175;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Titulo";
            this.dataGridViewTextBoxColumn8.HeaderText = "Titulo";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 175;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "CodOtraBusqueda";
            this.dataGridViewTextBoxColumn9.HeaderText = "CodOtraBusqueda";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 175;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "TextoOtra";
            this.dataGridViewTextBoxColumn10.HeaderText = "TextoOtra";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 175;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Predeterminada";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Predeterminada";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 9;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 175;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2021, 838);
            this.Controls.Add(this.sysBusquedasDataGridView);
            this.Controls.Add(codBusquedaLabel);
            this.Controls.Add(this.codBusquedaTextBox);
            this.Controls.Add(this.sysBusquedasBindingNavigator);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.genDoc_sysDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysBusquedasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysBusquedasBindingNavigator)).EndInit();
            this.sysBusquedasBindingNavigator.ResumeLayout(false);
            this.sysBusquedasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sysBusquedasDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private GenDoc_sysDataSet genDoc_sysDataSet;
        private System.Windows.Forms.BindingSource sysBusquedasBindingSource;
        private GenDoc_sysDataSetTableAdapters.sysBusquedasTableAdapter sysBusquedasTableAdapter;
        private GenDoc_sysDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sysBusquedasBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton sysBusquedasBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox codBusquedaTextBox;
        private System.Windows.Forms.DataGridView sysBusquedasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}

