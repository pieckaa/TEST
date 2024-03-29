using GemBox.Spreadsheet.WinFormsUtilities;
using GemBox.Spreadsheet;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter =
            "XLS (*.xls)|*.xls|" +
            "XLT (*.xlt)|*.xlt|" +
            "XLSX (*.xlsx)|*.xlsx|" +
            "XLSM (*.xlsm)|*.xlsm|" +
            "XLTX (*.xltx)|*.xltx|" +
            "XLTM (*.xltm)|*.xltm|" +
            "ODS (*.ods)|*.ods|" +
            "OTS (*.ots)|*.ots|" +
            "CSV (*.csv)|*.csv|" +
            "TSV (*.tsv)|*.tsv|" +
            "HTML (*.html)|*.html|" +
            "MHTML (.mhtml)|*.mhtml|" +
            "PDF (*.pdf)|*.pdf|" +
            "XPS (*.xps)|*.xps|" +
            "BMP (*.bmp)|*.bmp|" +
            "GIF (*.gif)|*.gif|" +
            "JPEG (*.jpg)|*.jpg|" +
            "PNG (*.png)|*.png|" +
            "TIFF (*.tif)|*.tif|" +
            "WMP (*.wdp)|*.wdp";
            saveFileDialog.FilterIndex = 3;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var workbook = new ExcelFile();
                var worksheet = workbook.Worksheets.Add("Sheet1");

                DataGridViewConverter.ImportFromDataGridView(worksheet, this.dgvClassList, new ImportFromDataGridViewOptions() { ColumnHeaders = true });
                workbook.Save(saveFileDialog.FileName);
            }
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter =
            "XLS files (*.xls, *.xlt)|*.xls;*.xlt|" +
            "XLSX files (*.xlsx, *.xlsm, *.xltx, *.xltm)|*.xlsx;*.xlsm;*.xltx;*.xltm|" +
            "ODS files (*.ods, *.ots)|*.ods;*.ots|" +
            "CSV files (*.csv, *.tsv)|*.csv;*.tsv|" +
            "HTML files (*.html, *.htm)|*.html;*.htm";
            openFileDialog.FilterIndex = 2;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var workbook = ExcelFile.Load(openFileDialog.FileName);
                var worksheet = workbook.Worksheets.ActiveWorksheet;

                DataGridViewConverter.ExportToDataGridView(worksheet, this.dgvClassList, new ExportToDataGridViewOptions() { ColumnHeaders = true }); ;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            dgvClassList.Rows.Clear();
        }
    }
}
