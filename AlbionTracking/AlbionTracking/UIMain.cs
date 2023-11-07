using __Entidades;
using System.Drawing.Drawing2D;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace AlbionTracking
{
    public partial class UIMain : Form
    {
        bool statusLoadItem;
        string statusResponseItems;
        bool statusLoadWorld;
        string statusResponseWorld;
        List<Items>? listItems;
        List<Items>? listWorld;
        List<ModelDataGrid> modelDataView;

        string pathItemsFilterGroup;
        List<ECitysMarketID> citys;
        bool[] qualitys;
        Dictionary<int, string[]> imageData;
        List<HistoryAVG>? listHistory_h;
        List<HistoryAVG>? listHistory_d;

        public UIMain()
        {
            InitializeComponent();
            listItems = Items.LoadItemsFromJson(out statusLoadItem, out statusResponseItems, _Configuration.JSON_FILE_ITEM);
            listWorld = Items.LoadItemsFromJson(out statusLoadWorld, out statusResponseWorld, _Configuration.JSON_FILE_WORLD);
        }

        private void UIMain_Load(object sender, EventArgs e)
        {
            LoadInit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.btnSearch.Enabled = false;
            GetData();
            LoadDataView();
            this.btnSearch.Enabled = true;
        }

        private async Task LoadDataView()
        {
            Task<List<HistoryAVG>?> res_h = QueryManager.EXE_QueryHistory(pathItemsFilterGroup, citys, qualitys, 1);
            await Task.WhenAll(res_h);
            if (res_h.IsCompletedSuccessfully)
            {
                listHistory_h = new List<HistoryAVG>();
                listHistory_h = res_h.Result;

                foreach (var item in listHistory_h)
                {
                    item.data = item.data.OrderByDescending(entry => entry.timestamp).ToList();
                }

                this.listBoxLog.Items.Add($"AVG History data hour load. Count: {listHistory_h.Count}");
            }

            Task<List<HistoryAVG>?> res_d = QueryManager.EXE_QueryHistory(pathItemsFilterGroup, citys, qualitys, 24);
            await Task.WhenAll(res_d);

            if (res_d.IsCompletedSuccessfully)
            {
                listHistory_d = new List<HistoryAVG>();
                listHistory_d = res_d.Result;

                foreach (var item in listHistory_d)
                {
                    item.data = item.data.OrderByDescending(entry => entry.timestamp).ToList();
                }

                this.listBoxLog.Items.Add($"AVG History data day load. Count: {listHistory_d.Count}");
            }

            Task<List<MarketResponse>?> res1 = QueryManager.EXE_QueryPrices(pathItemsFilterGroup, citys, qualitys);
            await Task.WhenAll(res1);


            if (res1.IsCompletedSuccessfully)
            {
                List<MarketResponse>? marketResponses = res1.Result;

                if (marketResponses != null)
                {
                    dataGridView.Columns.Clear();
                    modelDataView = ModelDataGrid.ArmarDataGridView(marketResponses, listItems);
                    this.dataGridView.DataSource = modelDataView;

                    #region CONFIG DataGridView
                    dataGridView.AutoGenerateColumns = true;

                    var imageColumn = new DataGridViewImageColumn();
                    imageColumn.HeaderText = "IMG";
                    imageColumn.Name = "ImageColumn";
                    imageColumn.DataPropertyName = "imgConvert";
                    dataGridView.Columns.Insert(0, imageColumn);

                    dataGridView.AutoResizeColumns();

                    imageData = new Dictionary<int, string[]>();
                    string[] imageDataString;

                    int rowIndex = 0;
                    foreach (ModelDataGrid i in modelDataView)
                    {
                        i.imgConvert = Image.FromFile(i.img);
                        imageDataString = new string[4];
                        imageDataString[0] = i.id;
                        imageDataString[1] = i.img;
                        imageDataString[2] = i.name;
                        imageDataString[3] = i.quality;
                        imageData.Add(rowIndex, imageDataString);

                        DataGridViewCell cell = dataGridView.Rows[rowIndex].Cells["IMG"];
                        cell.Value = i.imgConvert;
                        // Set the Row height.
                        dataGridView.Rows[cell.RowIndex].Height = ((Image)i.imgConvert).Height;
                        // Set the Column height.
                        dataGridView.Columns["ImageColumn"].Width = ((Image)i.imgConvert).Width;
                        rowIndex++;
                    }

                    // Ocultar la columna "id"
                    dataGridView.Columns["id"].Visible = false;
                    dataGridView.Columns["img"].Visible = false;
                    dataGridView.Columns["imgConvert"].Visible = false;

                    dataGridView.Columns["bm_sell_min"].Visible = false;
                    dataGridView.Columns["bm_sell_max"].Visible = false;
                    dataGridView.Columns["bm_buy_min"].Visible = false;

                    //HASTA QUE HAGA EL AVG
                    dataGridView.Columns["bm_avg_d"].Visible = false;
                    dataGridView.Columns["bm_avg_m"].Visible = false;
                    //

                    dataGridView.Columns["c_sell_max"].Visible = false;
                    dataGridView.Columns["c_buy_min"].Visible = false;
                    dataGridView.Columns["c_buy_max"].Visible = false;

                    dataGridView.Columns["l_sell_max"].Visible = false;
                    dataGridView.Columns["l_buy_min"].Visible = false;
                    dataGridView.Columns["l_buy_max"].Visible = false;

                    dataGridView.Columns["f_sell_max"].Visible = false;
                    dataGridView.Columns["f_buy_min"].Visible = false;
                    dataGridView.Columns["f_buy_max"].Visible = false;

                    dataGridView.Columns["t_sell_max"].Visible = false;
                    dataGridView.Columns["t_buy_min"].Visible = false;
                    dataGridView.Columns["t_buy_max"].Visible = false;

                    dataGridView.Columns["m_sell_max"].Visible = false;
                    dataGridView.Columns["m_buy_min"].Visible = false;
                    dataGridView.Columns["m_buy_max"].Visible = false;

                    dataGridView.Columns["b_sell_max"].Visible = false;
                    dataGridView.Columns["b_buy_min"].Visible = false;
                    dataGridView.Columns["b_buy_max"].Visible = false;

                    dataGridView.Columns["quality"].HeaderText = "QUEALITY";
                    dataGridView.Columns["name"].HeaderText = "ITEM NAME";
                    dataGridView.Columns["bm_dateTime"].HeaderText = "TIME";
                    dataGridView.Columns["bm_buy_max"].HeaderText = "BUY";
                    dataGridView.Columns["c_sell_min"].HeaderText = "SELL C";
                    dataGridView.Columns["f_sell_min"].HeaderText = "SELL F";
                    dataGridView.Columns["l_sell_min"].HeaderText = "SELL L";
                    dataGridView.Columns["b_sell_min"].HeaderText = "SELL B";
                    dataGridView.Columns["m_sell_min"].HeaderText = "SELL M";
                    dataGridView.Columns["t_sell_min"].HeaderText = "SELL T";
                    #endregion
                }

                dataGridView.Refresh(); dataGridView.Update();
            }
        }

        private void LoadInit()
        {
            //FILES
            this.listBoxLog.Items.Add($"STATUS LOAD ITEMS FILE: {statusLoadItem}");
            this.listBoxLog.Items.Add($"RESPONSE ITEMS IN MEMORY: {statusResponseItems}");
            this.listBoxLog.Items.Add($"STATUS LOAD WORLD FILE: {statusLoadWorld}");
            this.listBoxLog.Items.Add($"RESPONSE WORLD IN MEMORY: {statusResponseWorld}");
            //COMBO GROUP
            this.listBoxLog.Items.Add($"Load list filter group... Init");
            foreach (EPaths _enum in Enum.GetValues(typeof(EPaths)))
            {
                this.cmbGroup.Items.Add(_enum);
            }
            this.cmbGroup.SelectedIndex = 0;
            this.listBoxLog.Items.Add($"Load list filter group... Finally");
            //COMBO QUALITY
            this.listBoxLog.Items.Add($"Load list filter quality... Init");
            //this.cmbQuality.Items.Add(EQuality.ALL);
            this.cmbQuality.Items.Add(EQuality.Normal);
            this.cmbQuality.Items.Add(EQuality.Bueno);
            this.cmbQuality.Items.Add(EQuality.Notable);
            this.cmbQuality.Items.Add(EQuality.Sobresaliente);
            this.cmbQuality.Items.Add(EQuality.ObraMaestra);
            this.cmbQuality.SelectedIndex = 0;
            this.listBoxLog.Items.Add($"Load list filter quality... Finally");
            //COMBO ORDER BY
            this.listBoxLog.Items.Add($"Load list filter order by... Init");
            this.cmbOrder.Items.Add("MOST RECENT");
            this.cmbOrder.SelectedIndex = 0;
            this.listBoxLog.Items.Add($"Load list filter order by... Finally");
            //SET LENGUAGE
            _Configuration.SetLenguage(ELocalizedNames.Español);
            //SET CONFIG
            foreach (ELocalizedNames item in Enum.GetValues(typeof(ELocalizedNames)))
            {
                this.cmbLenguage.Items.Add(item);
            }
            this.cmbLenguage.SelectedItem = ELocalizedNames.Español;
        }

        private void GetData()
        {
            //GROUP
            pathItemsFilterGroup = _Configuration.paths[(EPaths)this.cmbGroup.SelectedItem];

            //CITYS
            citys = new List<ECitysMarketID> { ECitysMarketID.BlackMarket };
            if (cBoxT.Checked) { citys.Add(ECitysMarketID.Thetford); }
            if (cBoxL.Checked) { citys.Add(ECitysMarketID.Lymhurst); }
            if (cBoxM.Checked) { citys.Add(ECitysMarketID.Martlock); }
            if (cBoxB.Checked) { citys.Add(ECitysMarketID.Bridgewatch); }
            if (cBoxF.Checked) { citys.Add(ECitysMarketID.FortSterling); }
            if (cBoxF.Checked) { citys.Add(ECitysMarketID.Caerleon); }

            //QUALITY
            qualitys = new bool[5];
            switch (this.cmbQuality.SelectedItem)
            {
                case EQuality.Normal:
                    qualitys[0] = true;
                    break;
                case EQuality.Bueno:
                    qualitys[1] = true;
                    break;
                case EQuality.Notable:
                    qualitys[2] = true;
                    break;
                case EQuality.Sobresaliente:
                    qualitys[3] = true;
                    break;
                case EQuality.ObraMaestra:
                    qualitys[4] = true;
                    break;
                case EQuality.ALL:
                    qualitys[0] = true;
                    qualitys[1] = true;
                    qualitys[2] = true;
                    qualitys[3] = true;
                    qualitys[4] = true;
                    break;
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dataGridView.Columns[e.ColumnIndex] is DataGridViewImageColumn)
                {
                    Image image = (Image)dataGridView[e.ColumnIndex, e.RowIndex].Value;
                    string[] dataImageSave = imageData[e.RowIndex];

                    HistoryAVG? h = listHistory_h.FirstOrDefault(item => item.item_id == dataImageSave[0]);
                    HistoryAVG? d = listHistory_d.FirstOrDefault(item => item.item_id == dataImageSave[0]);
                    //Console.WriteLine($"{s[0]}\n{s[1]}\n{s[2]}c1:{listHistory_h.Count}c2:{listHistory_d.Count}-- h:{h.data.Count}");

                    if (h != null && d != null)
                    {
                        if (h.data.Count == 0 && d.data.Count == 0)
                        {
                            MessageBox.Show("Not info in history.", "Ups! :(", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            PopUp p = new PopUp(h, d, image, dataImageSave);
                            p.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Not info in history.", "Ups! :(", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void cmbLenguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Configuration.SetLenguage((ELocalizedNames)this.cmbLenguage.SelectedItem);
            btnSearch_Click(sender, e);
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            Task t = ExcelSaveAsync();
            if (t.IsCompletedSuccessfully)
            {
                MessageBox.Show("Completed successfully.", "Export data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async Task ExcelSaveAsync()
        {
            Dictionary<string, List<MarketResponse>?> dataExcel = new Dictionary<string, List<MarketResponse>?>();

            //CITYS
            citys = new List<ECitysMarketID> 
            { 
                ECitysMarketID.BlackMarket, 
                ECitysMarketID.Thetford, 
                ECitysMarketID.Lymhurst, 
                ECitysMarketID.Martlock, 
                ECitysMarketID.Bridgewatch, 
                ECitysMarketID.FortSterling, 
                ECitysMarketID.Caerleon
            };

            //QUALITY
            qualitys = new bool[5];
            qualitys[0] = true;
            qualitys[1] = true;
            qualitys[2] = true;
            qualitys[3] = true;
            qualitys[4] = true;

            this.listBoxLog.Items.Add("Init export data...");
            foreach (EPaths path in Enum.GetValues(typeof(EPaths)))
            {
                this.listBoxLog.Items.Add($"Export init {path.ToString()}...");
                Task<List<MarketResponse>?> res = QueryManager.EXE_QueryPrices(_Configuration.paths[path], citys, qualitys);
                await Task.WhenAll(res);

                if (res.IsCompletedSuccessfully)
                {
                    dataExcel.Add(path.ToString(), res.Result);
                }
                this.listBoxLog.Items.Add($"Export finnish {path.ToString()}...");
            }
            this.listBoxLog.Items.Add($"Save data...");
            DataManager.SaveToExcel(dataExcel, "files_h");
            this.listBoxLog.Items.Add($"Save data... ");
        }

    }
}