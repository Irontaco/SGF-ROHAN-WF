namespace SGF_ROHAN_WF
{
    partial class CreateQuotation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label_ClientNameSearchBar = new System.Windows.Forms.Label();
            this.label_RegisteredBusiness = new System.Windows.Forms.Label();
            this.label_Email = new System.Windows.Forms.Label();
            this.label_PhoneNumber = new System.Windows.Forms.Label();
            this.label_NetTotal = new System.Windows.Forms.Label();
            this.label_IvaPercentage = new System.Windows.Forms.Label();
            this.label_TotalPrice = new System.Windows.Forms.Label();
            this.label_DateEmitted = new System.Windows.Forms.Label();
            this.label_QuotationId = new System.Windows.Forms.Label();
            this.textBox_QuotationId = new System.Windows.Forms.TextBox();
            this.button_NewClient = new System.Windows.Forms.Button();
            this.listBox_ClientNameList = new System.Windows.Forms.ListBox();
            this.textBox_ClientNameSearchBar = new System.Windows.Forms.TextBox();
            this.DateEmitted = new System.Windows.Forms.Label();
            this.label_EmailData = new System.Windows.Forms.Label();
            this.label_PhoneNumberData = new System.Windows.Forms.Label();
            this.label_RegisteredBusinessData = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGrid_Quotation = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button_GeneratePDF = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label_NetTotalData = new System.Windows.Forms.Label();
            this.label_IvaData = new System.Windows.Forms.Label();
            this.label_TotalPriceData = new System.Windows.Forms.Label();
            this.Button_DeleteClient = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_DeleteEntry = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.p2_Textbox_ProdSpecsVertical = new System.Windows.Forms.TextBox();
            this.p2_label_specsX = new System.Windows.Forms.Label();
            this.p2_Combobox_Scale = new System.Windows.Forms.ComboBox();
            this.p2_label_ProductQuantity = new System.Windows.Forms.Label();
            this.p2_textBox_ProductQuantity = new System.Windows.Forms.TextBox();
            this.p2_label_ProductDiscount = new System.Windows.Forms.Label();
            this.p2_textBox_ProductDiscount = new System.Windows.Forms.TextBox();
            this.p2_button_UpdateProduct = new System.Windows.Forms.Button();
            this.p2_button_RemoveProduct = new System.Windows.Forms.Button();
            this.p2_button_ClearFields = new System.Windows.Forms.Button();
            this.p2_button_AddProductToQuotation = new System.Windows.Forms.Button();
            this.p2_label_ProductPrice = new System.Windows.Forms.Label();
            this.p2_textBox_ProductPrice = new System.Windows.Forms.TextBox();
            this.p2_label_ProductSpecifications = new System.Windows.Forms.Label();
            this.p2_TextBox_ProdSpecsHorizontal = new System.Windows.Forms.TextBox();
            this.p2_label_ProductDescription = new System.Windows.Forms.Label();
            this.p2_TextBox_ProductDescription = new System.Windows.Forms.TextBox();
            this.p2_label_ProductName = new System.Windows.Forms.Label();
            this.p2_textBox_ProductName = new System.Windows.Forms.TextBox();
            this.p2_button_CreateProductInData = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataSet1 = new SGF_ROHAN_WF.DataSet1();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTTableAdapter = new SGF_ROHAN_WF.DataSet1TableAdapters.CLIENTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Quotation)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_ClientNameSearchBar
            // 
            this.label_ClientNameSearchBar.AutoSize = true;
            this.label_ClientNameSearchBar.Location = new System.Drawing.Point(9, 36);
            this.label_ClientNameSearchBar.Name = "label_ClientNameSearchBar";
            this.label_ClientNameSearchBar.Size = new System.Drawing.Size(39, 13);
            this.label_ClientNameSearchBar.TabIndex = 0;
            this.label_ClientNameSearchBar.Text = "Cliente";
            // 
            // label_RegisteredBusiness
            // 
            this.label_RegisteredBusiness.AutoSize = true;
            this.label_RegisteredBusiness.Location = new System.Drawing.Point(9, 133);
            this.label_RegisteredBusiness.Name = "label_RegisteredBusiness";
            this.label_RegisteredBusiness.Size = new System.Drawing.Size(48, 13);
            this.label_RegisteredBusiness.TabIndex = 1;
            this.label_RegisteredBusiness.Text = "Empresa";
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Location = new System.Drawing.Point(9, 106);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(32, 13);
            this.label_Email.TabIndex = 2;
            this.label_Email.Text = "Email";
            // 
            // label_PhoneNumber
            // 
            this.label_PhoneNumber.AutoSize = true;
            this.label_PhoneNumber.Location = new System.Drawing.Point(9, 119);
            this.label_PhoneNumber.Name = "label_PhoneNumber";
            this.label_PhoneNumber.Size = new System.Drawing.Size(49, 13);
            this.label_PhoneNumber.TabIndex = 3;
            this.label_PhoneNumber.Text = "Telefono";
            // 
            // label_NetTotal
            // 
            this.label_NetTotal.AutoSize = true;
            this.label_NetTotal.Location = new System.Drawing.Point(669, 342);
            this.label_NetTotal.Name = "label_NetTotal";
            this.label_NetTotal.Size = new System.Drawing.Size(37, 13);
            this.label_NetTotal.TabIndex = 4;
            this.label_NetTotal.Text = "NETO";
            // 
            // label_IvaPercentage
            // 
            this.label_IvaPercentage.AutoSize = true;
            this.label_IvaPercentage.Location = new System.Drawing.Point(682, 355);
            this.label_IvaPercentage.Name = "label_IvaPercentage";
            this.label_IvaPercentage.Size = new System.Drawing.Size(24, 13);
            this.label_IvaPercentage.TabIndex = 5;
            this.label_IvaPercentage.Text = "IVA";
            // 
            // label_TotalPrice
            // 
            this.label_TotalPrice.AutoSize = true;
            this.label_TotalPrice.Location = new System.Drawing.Point(664, 368);
            this.label_TotalPrice.Name = "label_TotalPrice";
            this.label_TotalPrice.Size = new System.Drawing.Size(42, 13);
            this.label_TotalPrice.TabIndex = 6;
            this.label_TotalPrice.Text = "TOTAL";
            // 
            // label_DateEmitted
            // 
            this.label_DateEmitted.AutoSize = true;
            this.label_DateEmitted.Location = new System.Drawing.Point(599, 13);
            this.label_DateEmitted.Name = "label_DateEmitted";
            this.label_DateEmitted.Size = new System.Drawing.Size(37, 13);
            this.label_DateEmitted.TabIndex = 7;
            this.label_DateEmitted.Text = "Fecha";
            // 
            // label_QuotationId
            // 
            this.label_QuotationId.AutoSize = true;
            this.label_QuotationId.Location = new System.Drawing.Point(9, 9);
            this.label_QuotationId.Name = "label_QuotationId";
            this.label_QuotationId.Size = new System.Drawing.Size(71, 13);
            this.label_QuotationId.TabIndex = 8;
            this.label_QuotationId.Text = "Cotización N°";
            // 
            // textBox_QuotationId
            // 
            this.textBox_QuotationId.Location = new System.Drawing.Point(89, 6);
            this.textBox_QuotationId.Name = "textBox_QuotationId";
            this.textBox_QuotationId.Size = new System.Drawing.Size(32, 20);
            this.textBox_QuotationId.TabIndex = 9;
            // 
            // button_NewClient
            // 
            this.button_NewClient.Location = new System.Drawing.Point(349, 32);
            this.button_NewClient.Name = "button_NewClient";
            this.button_NewClient.Size = new System.Drawing.Size(104, 20);
            this.button_NewClient.TabIndex = 10;
            this.button_NewClient.Text = "Nuevo Cliente";
            this.button_NewClient.UseVisualStyleBackColor = true;
            this.button_NewClient.Click += new System.EventHandler(this.button_NewClient_Click);
            // 
            // listBox_ClientNameList
            // 
            this.listBox_ClientNameList.FormattingEnabled = true;
            this.listBox_ClientNameList.Location = new System.Drawing.Point(89, 58);
            this.listBox_ClientNameList.Name = "listBox_ClientNameList";
            this.listBox_ClientNameList.Size = new System.Drawing.Size(254, 43);
            this.listBox_ClientNameList.TabIndex = 11;
            this.listBox_ClientNameList.SelectedIndexChanged += new System.EventHandler(this.listBox_ClientNameList_SelectedIndexChanged);
            // 
            // textBox_ClientNameSearchBar
            // 
            this.textBox_ClientNameSearchBar.Location = new System.Drawing.Point(89, 32);
            this.textBox_ClientNameSearchBar.Name = "textBox_ClientNameSearchBar";
            this.textBox_ClientNameSearchBar.Size = new System.Drawing.Size(254, 20);
            this.textBox_ClientNameSearchBar.TabIndex = 12;
            // 
            // DateEmitted
            // 
            this.DateEmitted.AutoSize = true;
            this.DateEmitted.Location = new System.Drawing.Point(645, 13);
            this.DateEmitted.Name = "DateEmitted";
            this.DateEmitted.Size = new System.Drawing.Size(35, 13);
            this.DateEmitted.TabIndex = 14;
            this.DateEmitted.Text = "label1";
            // 
            // label_EmailData
            // 
            this.label_EmailData.AutoSize = true;
            this.label_EmailData.Location = new System.Drawing.Point(86, 106);
            this.label_EmailData.Name = "label_EmailData";
            this.label_EmailData.Size = new System.Drawing.Size(35, 13);
            this.label_EmailData.TabIndex = 15;
            this.label_EmailData.Text = "label1";
            // 
            // label_PhoneNumberData
            // 
            this.label_PhoneNumberData.AutoSize = true;
            this.label_PhoneNumberData.Location = new System.Drawing.Point(86, 120);
            this.label_PhoneNumberData.Name = "label_PhoneNumberData";
            this.label_PhoneNumberData.Size = new System.Drawing.Size(35, 13);
            this.label_PhoneNumberData.TabIndex = 16;
            this.label_PhoneNumberData.Text = "label1";
            // 
            // label_RegisteredBusinessData
            // 
            this.label_RegisteredBusinessData.AutoSize = true;
            this.label_RegisteredBusinessData.Location = new System.Drawing.Point(86, 133);
            this.label_RegisteredBusinessData.Name = "label_RegisteredBusinessData";
            this.label_RegisteredBusinessData.Size = new System.Drawing.Size(35, 13);
            this.label_RegisteredBusinessData.TabIndex = 17;
            this.label_RegisteredBusinessData.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Productos a Cotizar";
            // 
            // dataGrid_Quotation
            // 
            this.dataGrid_Quotation.AllowDrop = true;
            this.dataGrid_Quotation.AllowUserToAddRows = false;
            this.dataGrid_Quotation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_Quotation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Quotation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Quantity,
            this.ProductName,
            this.Description,
            this.UnitPrice,
            this.TotalPrice,
            this.Discount,
            this.FinalPrice});
            this.dataGrid_Quotation.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGrid_Quotation.Location = new System.Drawing.Point(6, 189);
            this.dataGrid_Quotation.Name = "dataGrid_Quotation";
            this.dataGrid_Quotation.ReadOnly = true;
            this.dataGrid_Quotation.Size = new System.Drawing.Size(776, 150);
            this.dataGrid_Quotation.TabIndex = 19;
            this.dataGrid_Quotation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Quotation_CellContentClick);
            // 
            // Item
            // 
            this.Item.FillWeight = 20.52175F;
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            this.Item.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Quantity
            // 
            this.Quantity.FillWeight = 30F;
            this.Quantity.HeaderText = "Cantidad";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Nombre";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Descripción";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // UnitPrice
            // 
            this.UnitPrice.FillWeight = 57.98869F;
            this.UnitPrice.HeaderText = "Precio Unit.";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            // 
            // TotalPrice
            // 
            this.TotalPrice.FillWeight = 57.98869F;
            this.TotalPrice.HeaderText = "Precio Total";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            // 
            // Discount
            // 
            this.Discount.FillWeight = 57.98869F;
            this.Discount.HeaderText = "Descuento";
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            // 
            // FinalPrice
            // 
            this.FinalPrice.FillWeight = 57.98869F;
            this.FinalPrice.HeaderText = "Precio Final";
            this.FinalPrice.Name = "FinalPrice";
            this.FinalPrice.ReadOnly = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(672, 390);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 24);
            this.button2.TabIndex = 20;
            this.button2.Text = "Guardar Cotización";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button_GeneratePDF
            // 
            this.button_GeneratePDF.Location = new System.Drawing.Point(582, 390);
            this.button_GeneratePDF.Name = "button_GeneratePDF";
            this.button_GeneratePDF.Size = new System.Drawing.Size(84, 24);
            this.button_GeneratePDF.TabIndex = 21;
            this.button_GeneratePDF.Text = "Generar PDF";
            this.button_GeneratePDF.UseVisualStyleBackColor = true;
            this.button_GeneratePDF.Click += new System.EventHandler(this.button_GeneratePDF_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(11, 390);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 24);
            this.button4.TabIndex = 22;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label_NetTotalData
            // 
            this.label_NetTotalData.AutoSize = true;
            this.label_NetTotalData.Location = new System.Drawing.Point(712, 342);
            this.label_NetTotalData.Name = "label_NetTotalData";
            this.label_NetTotalData.Size = new System.Drawing.Size(30, 13);
            this.label_NetTotalData.TabIndex = 23;
            this.label_NetTotalData.Text = "temp";
            // 
            // label_IvaData
            // 
            this.label_IvaData.AutoSize = true;
            this.label_IvaData.Location = new System.Drawing.Point(712, 355);
            this.label_IvaData.Name = "label_IvaData";
            this.label_IvaData.Size = new System.Drawing.Size(30, 13);
            this.label_IvaData.TabIndex = 24;
            this.label_IvaData.Text = "temp";
            // 
            // label_TotalPriceData
            // 
            this.label_TotalPriceData.AutoSize = true;
            this.label_TotalPriceData.Location = new System.Drawing.Point(712, 368);
            this.label_TotalPriceData.Name = "label_TotalPriceData";
            this.label_TotalPriceData.Size = new System.Drawing.Size(30, 13);
            this.label_TotalPriceData.TabIndex = 25;
            this.label_TotalPriceData.Text = "temp";
            // 
            // Button_DeleteClient
            // 
            this.Button_DeleteClient.Location = new System.Drawing.Point(349, 58);
            this.Button_DeleteClient.Name = "Button_DeleteClient";
            this.Button_DeleteClient.Size = new System.Drawing.Size(104, 20);
            this.Button_DeleteClient.TabIndex = 27;
            this.Button_DeleteClient.Text = "Eliminar Cliente";
            this.Button_DeleteClient.UseVisualStyleBackColor = true;
            this.Button_DeleteClient.Click += new System.EventHandler(this.Button_DeleteClient_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_DeleteEntry);
            this.panel1.Controls.Add(this.Button_DeleteClient);
            this.panel1.Controls.Add(this.label_TotalPriceData);
            this.panel1.Controls.Add(this.label_IvaData);
            this.panel1.Controls.Add(this.label_NetTotalData);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button_GeneratePDF);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label_RegisteredBusinessData);
            this.panel1.Controls.Add(this.label_PhoneNumberData);
            this.panel1.Controls.Add(this.label_EmailData);
            this.panel1.Controls.Add(this.DateEmitted);
            this.panel1.Controls.Add(this.textBox_ClientNameSearchBar);
            this.panel1.Controls.Add(this.listBox_ClientNameList);
            this.panel1.Controls.Add(this.button_NewClient);
            this.panel1.Controls.Add(this.textBox_QuotationId);
            this.panel1.Controls.Add(this.label_QuotationId);
            this.panel1.Controls.Add(this.label_DateEmitted);
            this.panel1.Controls.Add(this.label_TotalPrice);
            this.panel1.Controls.Add(this.label_IvaPercentage);
            this.panel1.Controls.Add(this.label_NetTotal);
            this.panel1.Controls.Add(this.label_PhoneNumber);
            this.panel1.Controls.Add(this.label_Email);
            this.panel1.Controls.Add(this.label_RegisteredBusiness);
            this.panel1.Controls.Add(this.label_ClientNameSearchBar);
            this.panel1.Controls.Add(this.dataGrid_Quotation);
            this.panel1.Location = new System.Drawing.Point(6, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 446);
            this.panel1.TabIndex = 28;
            // 
            // button_DeleteEntry
            // 
            this.button_DeleteEntry.Location = new System.Drawing.Point(6, 345);
            this.button_DeleteEntry.Name = "button_DeleteEntry";
            this.button_DeleteEntry.Size = new System.Drawing.Size(170, 23);
            this.button_DeleteEntry.TabIndex = 28;
            this.button_DeleteEntry.Text = "Eliminar Producto de Cotización";
            this.button_DeleteEntry.UseVisualStyleBackColor = true;
            this.button_DeleteEntry.Click += new System.EventHandler(this.button_DeleteEntry_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.p2_Textbox_ProdSpecsVertical);
            this.panel2.Controls.Add(this.p2_label_specsX);
            this.panel2.Controls.Add(this.p2_Combobox_Scale);
            this.panel2.Controls.Add(this.p2_label_ProductQuantity);
            this.panel2.Controls.Add(this.p2_textBox_ProductQuantity);
            this.panel2.Controls.Add(this.p2_label_ProductDiscount);
            this.panel2.Controls.Add(this.p2_textBox_ProductDiscount);
            this.panel2.Controls.Add(this.p2_button_UpdateProduct);
            this.panel2.Controls.Add(this.p2_button_RemoveProduct);
            this.panel2.Controls.Add(this.p2_button_ClearFields);
            this.panel2.Controls.Add(this.p2_button_AddProductToQuotation);
            this.panel2.Controls.Add(this.p2_label_ProductPrice);
            this.panel2.Controls.Add(this.p2_textBox_ProductPrice);
            this.panel2.Controls.Add(this.p2_label_ProductSpecifications);
            this.panel2.Controls.Add(this.p2_TextBox_ProdSpecsHorizontal);
            this.panel2.Controls.Add(this.p2_label_ProductDescription);
            this.panel2.Controls.Add(this.p2_TextBox_ProductDescription);
            this.panel2.Controls.Add(this.p2_label_ProductName);
            this.panel2.Controls.Add(this.p2_textBox_ProductName);
            this.panel2.Controls.Add(this.p2_button_CreateProductInData);
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Location = new System.Drawing.Point(805, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(302, 446);
            this.panel2.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Escala";
            // 
            // p2_Textbox_ProdSpecsVertical
            // 
            this.p2_Textbox_ProdSpecsVertical.Location = new System.Drawing.Point(113, 267);
            this.p2_Textbox_ProdSpecsVertical.Name = "p2_Textbox_ProdSpecsVertical";
            this.p2_Textbox_ProdSpecsVertical.Size = new System.Drawing.Size(80, 20);
            this.p2_Textbox_ProdSpecsVertical.TabIndex = 50;
            // 
            // p2_label_specsX
            // 
            this.p2_label_specsX.AutoSize = true;
            this.p2_label_specsX.Location = new System.Drawing.Point(93, 272);
            this.p2_label_specsX.Name = "p2_label_specsX";
            this.p2_label_specsX.Size = new System.Drawing.Size(14, 13);
            this.p2_label_specsX.TabIndex = 49;
            this.p2_label_specsX.Text = "X";
            // 
            // p2_Combobox_Scale
            // 
            this.p2_Combobox_Scale.FormattingEnabled = true;
            this.p2_Combobox_Scale.Items.AddRange(new object[] {
            "Metros",
            "Cm",
            "Mm"});
            this.p2_Combobox_Scale.Location = new System.Drawing.Point(199, 267);
            this.p2_Combobox_Scale.Name = "p2_Combobox_Scale";
            this.p2_Combobox_Scale.Size = new System.Drawing.Size(97, 21);
            this.p2_Combobox_Scale.TabIndex = 48;
            // 
            // p2_label_ProductQuantity
            // 
            this.p2_label_ProductQuantity.AutoSize = true;
            this.p2_label_ProductQuantity.Location = new System.Drawing.Point(4, 290);
            this.p2_label_ProductQuantity.Name = "p2_label_ProductQuantity";
            this.p2_label_ProductQuantity.Size = new System.Drawing.Size(49, 13);
            this.p2_label_ProductQuantity.TabIndex = 46;
            this.p2_label_ProductQuantity.Text = "Cantidad";
            // 
            // p2_textBox_ProductQuantity
            // 
            this.p2_textBox_ProductQuantity.Location = new System.Drawing.Point(7, 306);
            this.p2_textBox_ProductQuantity.Name = "p2_textBox_ProductQuantity";
            this.p2_textBox_ProductQuantity.Size = new System.Drawing.Size(80, 20);
            this.p2_textBox_ProductQuantity.TabIndex = 35;
            // 
            // p2_label_ProductDiscount
            // 
            this.p2_label_ProductDiscount.AutoSize = true;
            this.p2_label_ProductDiscount.Location = new System.Drawing.Point(213, 290);
            this.p2_label_ProductDiscount.Name = "p2_label_ProductDiscount";
            this.p2_label_ProductDiscount.Size = new System.Drawing.Size(76, 13);
            this.p2_label_ProductDiscount.TabIndex = 44;
            this.p2_label_ProductDiscount.Text = "Descuento (%)";
            // 
            // p2_textBox_ProductDiscount
            // 
            this.p2_textBox_ProductDiscount.Location = new System.Drawing.Point(216, 306);
            this.p2_textBox_ProductDiscount.Name = "p2_textBox_ProductDiscount";
            this.p2_textBox_ProductDiscount.Size = new System.Drawing.Size(80, 20);
            this.p2_textBox_ProductDiscount.TabIndex = 39;
            // 
            // p2_button_UpdateProduct
            // 
            this.p2_button_UpdateProduct.Location = new System.Drawing.Point(7, 134);
            this.p2_button_UpdateProduct.Name = "p2_button_UpdateProduct";
            this.p2_button_UpdateProduct.Size = new System.Drawing.Size(122, 23);
            this.p2_button_UpdateProduct.TabIndex = 42;
            this.p2_button_UpdateProduct.Text = "Actualizar Producto";
            this.p2_button_UpdateProduct.UseVisualStyleBackColor = true;
            // 
            // p2_button_RemoveProduct
            // 
            this.p2_button_RemoveProduct.Location = new System.Drawing.Point(174, 134);
            this.p2_button_RemoveProduct.Name = "p2_button_RemoveProduct";
            this.p2_button_RemoveProduct.Size = new System.Drawing.Size(122, 23);
            this.p2_button_RemoveProduct.TabIndex = 41;
            this.p2_button_RemoveProduct.Text = "Eliminar Producto";
            this.p2_button_RemoveProduct.UseVisualStyleBackColor = true;
            // 
            // p2_button_ClearFields
            // 
            this.p2_button_ClearFields.Location = new System.Drawing.Point(7, 390);
            this.p2_button_ClearFields.Name = "p2_button_ClearFields";
            this.p2_button_ClearFields.Size = new System.Drawing.Size(289, 23);
            this.p2_button_ClearFields.TabIndex = 40;
            this.p2_button_ClearFields.Text = "Limpiar Campos";
            this.p2_button_ClearFields.UseVisualStyleBackColor = true;
            // 
            // p2_button_AddProductToQuotation
            // 
            this.p2_button_AddProductToQuotation.Location = new System.Drawing.Point(7, 361);
            this.p2_button_AddProductToQuotation.Name = "p2_button_AddProductToQuotation";
            this.p2_button_AddProductToQuotation.Size = new System.Drawing.Size(289, 23);
            this.p2_button_AddProductToQuotation.TabIndex = 39;
            this.p2_button_AddProductToQuotation.Text = "Añadir Producto a Cotización";
            this.p2_button_AddProductToQuotation.UseVisualStyleBackColor = true;
            this.p2_button_AddProductToQuotation.Click += new System.EventHandler(this.p2_button_AddProductToQuotation_Click);
            // 
            // p2_label_ProductPrice
            // 
            this.p2_label_ProductPrice.AutoSize = true;
            this.p2_label_ProductPrice.Location = new System.Drawing.Point(111, 290);
            this.p2_label_ProductPrice.Name = "p2_label_ProductPrice";
            this.p2_label_ProductPrice.Size = new System.Drawing.Size(76, 13);
            this.p2_label_ProductPrice.TabIndex = 36;
            this.p2_label_ProductPrice.Text = "Precio Unitario";
            // 
            // p2_textBox_ProductPrice
            // 
            this.p2_textBox_ProductPrice.Location = new System.Drawing.Point(93, 306);
            this.p2_textBox_ProductPrice.Name = "p2_textBox_ProductPrice";
            this.p2_textBox_ProductPrice.Size = new System.Drawing.Size(117, 20);
            this.p2_textBox_ProductPrice.TabIndex = 37;
            // 
            // p2_label_ProductSpecifications
            // 
            this.p2_label_ProductSpecifications.AutoSize = true;
            this.p2_label_ProductSpecifications.Location = new System.Drawing.Point(41, 251);
            this.p2_label_ProductSpecifications.Name = "p2_label_ProductSpecifications";
            this.p2_label_ProductSpecifications.Size = new System.Drawing.Size(125, 13);
            this.p2_label_ProductSpecifications.TabIndex = 34;
            this.p2_label_ProductSpecifications.Text = "Especificaciones ( 0 x 0 )";
            // 
            // p2_TextBox_ProdSpecsHorizontal
            // 
            this.p2_TextBox_ProdSpecsHorizontal.Location = new System.Drawing.Point(7, 267);
            this.p2_TextBox_ProdSpecsHorizontal.Name = "p2_TextBox_ProdSpecsHorizontal";
            this.p2_TextBox_ProdSpecsHorizontal.Size = new System.Drawing.Size(80, 20);
            this.p2_TextBox_ProdSpecsHorizontal.TabIndex = 33;
            // 
            // p2_label_ProductDescription
            // 
            this.p2_label_ProductDescription.AutoSize = true;
            this.p2_label_ProductDescription.Location = new System.Drawing.Point(4, 212);
            this.p2_label_ProductDescription.Name = "p2_label_ProductDescription";
            this.p2_label_ProductDescription.Size = new System.Drawing.Size(124, 13);
            this.p2_label_ProductDescription.TabIndex = 32;
            this.p2_label_ProductDescription.Text = "Descripción de Producto";
            // 
            // p2_TextBox_ProductDescription
            // 
            this.p2_TextBox_ProductDescription.Location = new System.Drawing.Point(7, 228);
            this.p2_TextBox_ProductDescription.Name = "p2_TextBox_ProductDescription";
            this.p2_TextBox_ProductDescription.Size = new System.Drawing.Size(289, 20);
            this.p2_TextBox_ProductDescription.TabIndex = 31;
            // 
            // p2_label_ProductName
            // 
            this.p2_label_ProductName.AutoSize = true;
            this.p2_label_ProductName.Location = new System.Drawing.Point(4, 173);
            this.p2_label_ProductName.Name = "p2_label_ProductName";
            this.p2_label_ProductName.Size = new System.Drawing.Size(105, 13);
            this.p2_label_ProductName.TabIndex = 30;
            this.p2_label_ProductName.Text = "Nombre de Producto";
            // 
            // p2_textBox_ProductName
            // 
            this.p2_textBox_ProductName.Location = new System.Drawing.Point(7, 189);
            this.p2_textBox_ProductName.Name = "p2_textBox_ProductName";
            this.p2_textBox_ProductName.Size = new System.Drawing.Size(289, 20);
            this.p2_textBox_ProductName.TabIndex = 28;
            // 
            // p2_button_CreateProductInData
            // 
            this.p2_button_CreateProductInData.Location = new System.Drawing.Point(7, 332);
            this.p2_button_CreateProductInData.Name = "p2_button_CreateProductInData";
            this.p2_button_CreateProductInData.Size = new System.Drawing.Size(289, 23);
            this.p2_button_CreateProductInData.TabIndex = 27;
            this.p2_button_CreateProductInData.Text = "Registrar Producto en Listado";
            this.p2_button_CreateProductInData.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(7, 7);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(289, 121);
            this.listBox1.TabIndex = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "CLIENT";
            this.bindingSource1.DataSource = this.dataSet1;
            // 
            // cLIENTTableAdapter
            // 
            this.cLIENTTableAdapter.ClearBeforeFill = true;
            // 
            // CreateQuotation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 423);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CreateQuotation";
            this.Text = "Sistema de Gestión Financiera ROHAN - Cotización Nueva";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Quotation)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_ClientNameSearchBar;
        private System.Windows.Forms.Label label_RegisteredBusiness;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label_PhoneNumber;
        private System.Windows.Forms.Label label_NetTotal;
        private System.Windows.Forms.Label label_IvaPercentage;
        private System.Windows.Forms.Label label_TotalPrice;
        private System.Windows.Forms.Label label_DateEmitted;
        private System.Windows.Forms.Label label_QuotationId;
        private System.Windows.Forms.TextBox textBox_QuotationId;
        private System.Windows.Forms.Button button_NewClient;
        private System.Windows.Forms.ListBox listBox_ClientNameList;
        private System.Windows.Forms.TextBox textBox_ClientNameSearchBar;
        private System.Windows.Forms.Label DateEmitted;
        private System.Windows.Forms.Label label_EmailData;
        private System.Windows.Forms.Label label_PhoneNumberData;
        private System.Windows.Forms.Label label_RegisteredBusinessData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGrid_Quotation;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_GeneratePDF;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label_NetTotalData;
        private System.Windows.Forms.Label label_IvaData;
        private System.Windows.Forms.Label label_TotalPriceData;
        private System.Windows.Forms.Button Button_DeleteClient;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button p2_button_CreateProductInData;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label p2_label_ProductPrice;
        private System.Windows.Forms.TextBox p2_textBox_ProductPrice;
        private System.Windows.Forms.Label p2_label_ProductSpecifications;
        private System.Windows.Forms.TextBox p2_TextBox_ProdSpecsHorizontal;
        private System.Windows.Forms.Label p2_label_ProductDescription;
        private System.Windows.Forms.TextBox p2_TextBox_ProductDescription;
        private System.Windows.Forms.Label p2_label_ProductName;
        private System.Windows.Forms.TextBox p2_textBox_ProductName;
        private System.Windows.Forms.Button p2_button_ClearFields;
        private System.Windows.Forms.Button p2_button_AddProductToQuotation;
        private System.Windows.Forms.Button p2_button_UpdateProduct;
        private System.Windows.Forms.Button p2_button_RemoveProduct;
        private System.Windows.Forms.Label p2_label_ProductDiscount;
        private System.Windows.Forms.TextBox p2_textBox_ProductDiscount;
        private System.Windows.Forms.Label p2_label_ProductQuantity;
        private System.Windows.Forms.TextBox p2_textBox_ProductQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalPrice;
        private System.Windows.Forms.Button button_DeleteEntry;
        private System.Windows.Forms.Label p2_label_specsX;
        private System.Windows.Forms.ComboBox p2_Combobox_Scale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox p2_Textbox_ProdSpecsVertical;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DataSet1TableAdapters.CLIENTTableAdapter cLIENTTableAdapter;
    }
}

