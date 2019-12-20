namespace SysPro_Lab_07
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DBDataGridView = new System.Windows.Forms.DataGridView();
            this.LoadButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DeleteRowButton = new System.Windows.Forms.Button();
            this.libraryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new SysPro_Lab_07.DatabaseDataSet();
            this.libraryTableAdapter = new SysPro_Lab_07.DatabaseDataSetTableAdapters.LibraryTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Published_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DBDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // DBDataGridView
            // 
            this.DBDataGridView.AutoGenerateColumns = false;
            this.DBDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DBDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.bookDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.Published_date,
            this.Publisher});
            this.DBDataGridView.DataSource = this.libraryBindingSource;
            resources.ApplyResources(this.DBDataGridView, "DBDataGridView");
            this.DBDataGridView.Name = "DBDataGridView";
            this.DBDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            // 
            // LoadButton
            // 
            resources.ApplyResources(this.LoadButton, "LoadButton");
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // SaveButton
            // 
            resources.ApplyResources(this.SaveButton, "SaveButton");
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DeleteRowButton
            // 
            resources.ApplyResources(this.DeleteRowButton, "DeleteRowButton");
            this.DeleteRowButton.Name = "DeleteRowButton";
            this.DeleteRowButton.UseVisualStyleBackColor = true;
            this.DeleteRowButton.Click += new System.EventHandler(this.DeleteRowButton_Click);
            // 
            // libraryBindingSource
            // 
            this.libraryBindingSource.DataMember = "Library";
            this.libraryBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // libraryTableAdapter
            // 
            this.libraryTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            resources.ApplyResources(this.idDataGridViewTextBoxColumn, "idDataGridViewTextBoxColumn");
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // bookDataGridViewTextBoxColumn
            // 
            this.bookDataGridViewTextBoxColumn.DataPropertyName = "Book";
            resources.ApplyResources(this.bookDataGridViewTextBoxColumn, "bookDataGridViewTextBoxColumn");
            this.bookDataGridViewTextBoxColumn.Name = "bookDataGridViewTextBoxColumn";
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            resources.ApplyResources(this.authorDataGridViewTextBoxColumn, "authorDataGridViewTextBoxColumn");
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            // 
            // Published_date
            // 
            this.Published_date.DataPropertyName = "Published_date";
            resources.ApplyResources(this.Published_date, "Published_date");
            this.Published_date.Name = "Published_date";
            // 
            // Publisher
            // 
            this.Publisher.DataPropertyName = "Publisher";
            resources.ApplyResources(this.Publisher, "Publisher");
            this.Publisher.Name = "Publisher";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DeleteRowButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.DBDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DBDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DBDataGridView;
        private System.Windows.Forms.Button LoadButton;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource libraryBindingSource;
        private DatabaseDataSetTableAdapters.LibraryTableAdapter libraryTableAdapter;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button DeleteRowButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Published_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publisher;
    }
}

