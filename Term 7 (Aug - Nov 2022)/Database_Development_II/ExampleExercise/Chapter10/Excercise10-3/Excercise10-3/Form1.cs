using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Printing;


namespace Excercise10_3
{
    public partial class frmWeather : Form
    {
        SqlConnection WeatherConnection;
        SqlCommand WeatherCommand;
        SqlDataAdapter WeatherAdapter;
        DataTable WeatherTable;
        int tempPlot = 0;
        int precipPlot = 0;
        int pageNumber;


        public frmWeather()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //close any open database
            CloseConnection();
            try
            {
                // get filename
                if (dlgSave.ShowDialog() == DialogResult.OK)
                {
                    // create table
                    File.Copy(Application.StartupPath + "\\SQLWeatherDBBlank.mdf", dlgSave.FileName);
                    // connect to database
                    OpenConnection(dlgSave.FileName);
                    //fill dates
                    DateTime TableDate = new DateTime(Convert.ToInt32(cboYear.Text), 1, 1);
                    DateTime nextYear = new DateTime(Convert.ToInt32(cboYear.Text) + 1, 1, 1);
                    int nDays = (nextYear - TableDate).Days;
                    DataRow newRow;
                    for (int n = 1; n <= nDays; n++)
                    {
                        newRow = WeatherTable.NewRow();
                        newRow["WeatherDate"] = TableDate;
                        WeatherTable.Rows.Add(newRow);
                        TableDate += new TimeSpan(1, 0, 0, 0);
                    }
                    grdWeather_CellClick(null, null);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Creating Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmWeather_Load(object sender, EventArgs e)
        {
            // point to help file
            hlpWeather.HelpNamespace = Application.StartupPath + "\\weather.chm";
            for (int y = 1900; y <= 2100; y++)
            {
                cboYear.Items.Add(y.ToString());
            }
            cboYear.Text = calDate.SelectionStart.Year.ToString();
            tabWeather.SelectedTab = tabPageData;
            grdWeather.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdWeather.AllowUserToAddRows = false;
        }

        private void CloseConnection()
        {

            try
            {
                if (!(WeatherConnection == null))
                {
                    if (WeatherConnection.State == ConnectionState.Open)
                    {

                        // bind controls
                        WeatherAdapter.Update(WeatherTable);
                        WeatherConnection.Close();
                        WeatherConnection.Dispose();
                        WeatherCommand.Dispose();
                        WeatherAdapter.Dispose();
                        WeatherTable.Dispose();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Saving Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }
        private void OpenConnection(String fname)
        {
            WeatherConnection = new SqlConnection("Data Source=.\\SQLEXPRESS; AttachDbFilename=" + fname + ";  Integrated Security=True; Connect Timeout=30; User Instance=True;");
            WeatherConnection.Open();
            // establish inventory command object
            WeatherCommand = new SqlCommand("SELECT * FROM Weather ORDER BY WeatherDate", WeatherConnection);
            // establish inventory data adapter/data table
            WeatherAdapter = new SqlDataAdapter();
            WeatherAdapter.SelectCommand = WeatherCommand;
            WeatherTable = new DataTable();
            WeatherAdapter.Fill(WeatherTable);
            grdWeather.DataSource = WeatherTable;
            grdWeather.Columns[0].ReadOnly = true;
            grdWeather_CellClick(null, null);

        }
        private void grdWeather_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            this.grdWeather.EditingControl.KeyPress -= new KeyPressEventHandler(this.grdWeather_KeyPress);
            this.grdWeather.EditingControl.KeyPress += new KeyPressEventHandler(this.grdWeather_KeyPress);
        }

      

        private void frmWeather_FormClosed(object sender, FormClosedEventArgs e)
        {
            // close connection
            CloseConnection();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                //close connection if open
                CloseConnection();
                // get filename
                if (dlgOpen.ShowDialog() == DialogResult.OK)
                {
                    // connect to database
                    OpenConnection(dlgOpen.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Opening File", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            grdWeather_CellClick(null, null);

        }
        private void calDate_DateChanged(object sender,DateRangeEventArgs e)
        {
            // match selected date to grid (if possible)
            if (!(WeatherConnection == null))
            {
                WeatherTable.DefaultView.Sort = "WeatherDate";
                int dateRow = WeatherTable.DefaultView.Find(calDate.SelectionStart)
                ;
                if (dateRow != -1)
                {
                    grdWeather.CurrentCell = grdWeather[1,
                    dateRow];
                }
            }
        }

        private void grdWeather_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            calDate.SelectionStart = Convert.ToDateTime(grdWeather[0,grdWeather.CurrentCell.RowIndex].Value);
        }

        private void TemperatureData()
        {
            // make sure there is a data table
            if (WeatherConnection == null)
                return;
            float temp;
            int xStart = 0, xEnd = 0, nDays, isLeap;
            float tempHH, tempHL;
            float tempLH, tempLL;
            float sumH, sumL;
            int nH, nL;
            double sxH, sx2H, sxyH;
            double sxL, sx2L, sxyL;
            float a1H, a1L;
            bool noData;
            float[] highTemp = new float[366];
            float[] lowTemp = new float[366];
            if (WeatherTable.Rows.Count == 365)
                isLeap = 0;
            else
                isLeap = 1;
            switch (tempPlot)
            {
                case 0:
                    xStart = 0;
                    xEnd = 364 + isLeap;
                    break;
                case 1:
                    xStart = 0;
                    xEnd = 89 + isLeap;
                    break;
                case 2:
                    xStart = 90 + isLeap;
                    xEnd = 180 + isLeap;
                    break;
                case 3:
                    xStart = 181 + isLeap;
                    xEnd = 272 + isLeap;
                    break;
                case 4:
                    xStart = 273 + isLeap;
                    xEnd = 364 + isLeap;
                    break;
            }
            nDays = xEnd - xStart + 1;
            // temperature data
            tempHH = -1000; tempHL = 1000;
            tempLH = -1000; tempLL = 1000;
            sumH = 0; nH = 0;
            sumL = 0; nL = 0;
            sxH = 0; sx2H = 0; sxyH = 0;
            sxL = 0; sx2L = 0; sxyL = 0;
            for (int x = xStart; x <= xEnd; x++)
            {
                if (WeatherTable.Rows[x]["HighTemp"] != DBNull.Value)
                {
                    temp = Convert.ToSingle(WeatherTable.Rows[x]["HighTemp"]);
                    highTemp[x - xStart] = temp;
                    if (temp > tempHH)
                        tempHH = temp;
                    if (temp < tempHL)
                        tempHL = temp;
                    sumH += temp;
                    nH++;
                    sxH += x;
                    sx2H += x * x;
                    sxyH += x * temp;
                }
                else
                {
                    highTemp[x - xStart] = -1000.0F;
                }
                if (WeatherTable.Rows[x]["LowTemp"] != DBNull.Value)
                {
                    temp = Convert.ToSingle(WeatherTable.Rows[x]["LowTemp"]);
                    lowTemp[x - xStart] = temp;
                    if (temp > tempLH)
                        tempLH = temp;
                    if (temp < tempLL)
                        tempLL = temp;
                    sumL += temp;
                    nL++;
                    sxL += x;
                    sx2L += x * x;
                    sxyL += x * temp;
                }
                else
                {
                    lowTemp[x - xStart] = -1000.0F;
                }
            }
            if (tempLL >= tempHH)
                noData = true;
            else
                noData = false;
            if (!noData)
            {
                lblTHH.Text = String.Format("{0:f1}", tempHH);
                lblTHL.Text = String.Format("{0:f1}", tempHL);
                lblTLH.Text = String.Format("{0:f1}", tempLH);
                lblTLL.Text = String.Format("{0:f1}", tempLL);
                if (nH > 1)
                {
                    a1H = Convert.ToSingle((nH * sxyH - sxH * sumH) /(nH * sx2H - sxH * sxH));
                    if (a1H >= 0)
                        lblTHT.Text = "+" + String.Format("{0:f1}", (nDays - 1) * a1H);
                    else
                        lblTHT.Text = String.Format("{0:f1}",(nDays - 1) * a1H);
                }
                if (nL > 1)
                {
                    a1L = Convert.ToSingle((nL * sxyL - sxL * sumL) / (nL * sx2L - sxL * sxL));
                    if (a1L >= 0)
                        lblTLT.Text = "+" + String.Format("{0:f1}", (nDays - 1) * a1L);
                    else
                        lblTLT.Text = String.Format("{0:f1}",(nDays - 1) * a1L);
                }
                lblTHA.Text = String.Format("{0:f1}", sumH / nH);
                lblTLA.Text = String.Format("{0:f1}", sumL / nL);
            }
            else
            {
                lblTHH.Text = "---";
                lblTLH.Text = "---";
                lblTHL.Text = "---";
                lblTLL.Text = "---";
                lblTHA.Text = "---";
                lblTLA.Text = "---";
                lblTHT.Text = "---";
                lblTLT.Text = "---";

            }
            TempPlot temperaturePlot = new TempPlot(pnlTempPlot);
            if (!noData)
                temperaturePlot.Draw(nDays, highTemp, lowTemp);

        }

        private void tabWeather_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabWeather.SelectedIndex)
            {
                case 1:
                    TemperatureData();
                    break;
                case 2:
                    PrecipitationData();
                    break;
            }

        }

        private void rdoTempPlot_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton whichButton = (RadioButton)sender;
            switch (whichButton.Name)
            {
                case "rdoTempYear":
                    tempPlot = 0;
                    break;
                case "rdoTempWinter":
                    tempPlot = 1;
                    break;
                case "rdoTempSpring":
                    tempPlot = 2;
                    break;
                case "rdoTempSummer":
                    tempPlot = 3;
                    break;
                case "rdoTempAutumn":
                    tempPlot = 4;
                    break;
            }
            TemperatureData();
        }

        private void PrecipitationData()
        {
            // make sure there is a data table
            if (WeatherConnection == null)
                return;
            float prec;
            int xStart = 0, xEnd = 0, nDays, isLeap;
            float precH, precT;
            bool noData;
            float[] precip = new float[366];
            if (WeatherTable.Rows.Count == 365)
                isLeap = 0;
            else
                isLeap = 1;
            switch (precipPlot)
            {
                case 0:
                    xStart = 0;
                    xEnd = 364 + isLeap;
                    break;
                case 1:
                    xStart = 0;
                    xEnd = 89 + isLeap;
                    break;
                case 2:
                    xStart = 90 + isLeap;
                    xEnd = 180 + isLeap;
                    break;
                case 3:
                    xStart = 181 + isLeap;
                    xEnd = 272 + isLeap;
                    break;
                case 4:
                    xStart = 273 + isLeap;
                    xEnd = 364 + isLeap;
                    break;
            }
            nDays = xEnd - xStart + 1;
            // precipitation data
            precH = -1000; precT = 0;
            noData = true;
            for (int x = xStart; x <= xEnd; x++)
            {
                if (WeatherTable.Rows[x]["Precip"] != DBNull.Value)
                {
                    prec = Convert.ToSingle(WeatherTable.Rows[x]["Precip"]);
                    noData = false;
                }
                else
                {
                    prec = 0.0F;
                }
                precip[x - xStart] = prec;
                if (prec > precH)
                    precH = prec;
                precT += prec;
            }
            if (!noData)
            {
                lblPH.Text = String.Format("{0:f2}", precH);
                lblPT.Text = String.Format("{0:f1}", precT);
            }
            else
            {
                lblPH.Text = "---";
                lblPT.Text = "---";
            }
            PrecipPlot precipitationPlot = new PrecipPlot(pnlPrecipPlot);
            if (!noData)
                precipitationPlot.Draw(nDays, precip);
        }

        private void rdoPrecipPlot_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton whichButton = (RadioButton)sender;
            switch (whichButton.Name)
            {
                case "rdoPrecipYear":
                    precipPlot = 0;
                    break;
                case "rdoPrecipWinter":
                    precipPlot = 1;
                    break;
                case "rdoPrecipSpring":
                    precipPlot = 2;
                    break;
                case "rdoPrecipSummer":
                    precipPlot = 3;
                    break;
                case "rdoPrecipAutumn":
                    precipPlot = 4;
                    break;
            }
            PrecipitationData();
        }

        private void btnPrint_Click(object sender, EventArgs
e)
        {
            // make sure there is a data table
            if (WeatherConnection == null)
                return;
            // Declare the document
            PrintDocument recordDocument;
            // Create the document and name it
            recordDocument = new PrintDocument();
            recordDocument.DocumentName = "Weather Data";
            // Add code handler based on button pressed
            Button whichButton = (Button)sender;
            switch (whichButton.Name)
            {
                case "btnPrintData":
                    recordDocument.PrintPage += new PrintPageEventHandler(this.PrintDataReport);
                    break;
                case "btnPrintTemp":
                    recordDocument.PrintPage += new PrintPageEventHandler(this.PrintTemperatureReport);
                    break;
                case "btnPrintPrecip":
                    recordDocument.PrintPage += new PrintPageEventHandler(this.PrintPrecipitationReport);
                    break;
            }
            // Preview document
            pageNumber = 1;
            dlgPreview.Document = recordDocument;
            dlgPreview.ShowDialog();
            // Dispose of document when done printing
            recordDocument.Dispose();
        }

        private void PrintDataReport(object sender, PrintPageEventArgs e)
        {
            Font myFont;
            int y;
            const int daysPerPage = 40;
            myFont = new Font("Courier New", 14, FontStyle.Bold);
            y = e.MarginBounds.Top + 50;
            // Print header
            e.Graphics.DrawString("Weather Data - Page " + pageNumber.ToString(), myFont, Brushes.Black, e.MarginBounds.Left, y);
            y += 2 * Convert.ToInt32(myFont.GetHeight(e.Graphics));
            myFont = new Font("Courier New", 12,FontStyle.Bold | FontStyle.Underline);
            e.Graphics.DrawString("Date", myFont,Brushes.Black, e.MarginBounds.Left, y);
            e.Graphics.DrawString("HighTemp", myFont,Brushes.Black, e.MarginBounds.Left + 125, y);
            e.Graphics.DrawString("LowTemp", myFont,Brushes.Black, e.MarginBounds.Left + 225, y);
            e.Graphics.DrawString("Precip", myFont, Brushes.Black, e.MarginBounds.Left + 325, y);
            e.Graphics.DrawString("Comment", myFont,Brushes.Black, e.MarginBounds.Left + 425, y);
            myFont = new Font("Courier New", 12, FontStyle.Regular);
            y += Convert.ToInt32(myFont.GetHeight(e.Graphics));
            int n1 = 1 + (pageNumber - 1) * daysPerPage;
            int n2 = n1 + daysPerPage - 1;
            if (n2 > WeatherTable.Rows.Count)
                n2 = WeatherTable.Rows.Count;
            string s;
            for (int n = n1; n <= n2; n++)
            {
                e.Graphics.DrawString(Convert.ToDateTime(WeatherTable.Rows[n - 1]["WeatherDate"]).ToShortDateString(), myFont,Brushes.Black,e.MarginBounds.X, y);
                if (WeatherTable.Rows[n - 1]["HighTemp"] != DBNull.Value)
                    s = String.Format("{0:f1}", WeatherTable.Rows[n - 1]["HighTemp"]);
                else
                    s = "";
                e.Graphics.DrawString(s, myFont, Brushes.Black, e.MarginBounds.X + 200 - e.Graphics.MeasureString(s, myFont).Width, y);
                if (WeatherTable.Rows[n - 1]["LowTemp"] != DBNull.Value)
                    s = String.Format("{0:f1}", WeatherTable.Rows[n - 1]["LowTemp"]);
                else
                    s = "";
                e.Graphics.DrawString(s, myFont, Brushes.Black,e.MarginBounds.X + 300 - e.Graphics.MeasureString(s,myFont).Width, y);
                if (WeatherTable.Rows[n - 1]["Precip"] != DBNull.Value)
                    s = String.Format("{0:f1}", WeatherTable.Rows[n - 1]["Precip"]);
                else
                    s = "";
                e.Graphics.DrawString(s, myFont, Brushes.Black, e.MarginBounds.X + 375 - e.Graphics.MeasureString(s,myFont).Width, y);
                s = WeatherTable.Rows[n - 1] ["Comment"].ToString();
                // limit length of comment to 20 characters
                if (s.Length > 20)
                    s = s.Substring(0, 20);
                e.Graphics.DrawString(s, myFont, Brushes.Black, e.MarginBounds.X + 425, y);
                y += Convert.ToInt32(myFont.GetHeight(e.Graphics));
            }
            if (n2 != WeatherTable.Rows.Count)
            {
                pageNumber++;
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
                pageNumber = 1;
            }
        }

        private void PrintTemperatureReport(object sender,PrintPageEventArgs e)
        {
            Font myFont = new Font("Courier New", 12, FontStyle.Regular);
            int y = 125;
            e.Graphics.DrawString("Weather Monitor", myFont, Brushes.Black, e.MarginBounds.X, y);
            y += Convert.ToInt32(2 * myFont.GetHeight(e.Graphics));
            myFont = new Font("Courier New", 12, FontStyle.Regular | FontStyle.Underline);
            e.Graphics.DrawString("Temperatures:", myFont, Brushes.Black, e.MarginBounds.X, y);
            y += Convert.ToInt32(2 * myFont.GetHeight(e.Graphics));
            myFont = new Font("Courier New", 12,FontStyle.Regular);
            e.Graphics.DrawString("High Temperature", myFont,Brushes.Black, 150, y);
            e.Graphics.DrawString("Low Temperature", myFont,Brushes.Black, 400, y);
            y += Convert.ToInt32(myFont.GetHeight(e.Graphics));
            e.Graphics.DrawString(" High = " + lblTHH.Text,myFont, Brushes.Black, 150, y);
            e.Graphics.DrawString(" High = " + lblTLH.Text, myFont, Brushes.Black, 400, y);
            y += Convert.ToInt32(myFont.GetHeight(e.Graphics));
            e.Graphics.DrawString(" Ave = " + lblTHA.Text, myFont, Brushes.Black, 150, y);
            e.Graphics.DrawString(" Ave = " + lblTLA.Text, myFont, Brushes.Black, 400, y);
            y += Convert.ToInt32(myFont.GetHeight(e.Graphics));
            e.Graphics.DrawString(" Low = " + lblTHL.Text,myFont, Brushes.Black, 150, y);
            e.Graphics.DrawString(" Low = " + lblTLL.Text, myFont, Brushes.Black, 400, y);
            y += Convert.ToInt32(myFont.GetHeight(e.Graphics));
            e.Graphics.DrawString(" Trend = " + lblTHT.Text, myFont, Brushes.Black, 150, y);
            e.Graphics.DrawString(" Trend = " + lblTLT.Text,
            myFont, Brushes.Black, 400, y);
            if (pnlTempPlot.BackgroundImage != null)
                e.Graphics.DrawImage(pnlTempPlot.BackgroundImage, 150,300, 500, Convert.ToInt32(500 * pnlTempPlot.ClientSize.Height /pnlTempPlot.ClientSize.Height));
            e.HasMorePages = false;
        }

        private void PrintPrecipitationReport(object sender,
PrintPageEventArgs e)
        {
            Font myFont = new Font("Courier New", 12,
            FontStyle.Regular);
            int y = 125;
            e.Graphics.DrawString("Weather Monitor", myFont,
            Brushes.Black, e.MarginBounds.X, y);
            y += Convert.ToInt32(2 *
            myFont.GetHeight(e.Graphics));
            myFont = new Font("Courier New", 12,
            FontStyle.Regular |
            FontStyle.Underline);
            e.Graphics.DrawString("Precipitation:", myFont,
            Brushes.Black, e.MarginBounds.X, y);
            y += Convert.ToInt32(2 *
            myFont.GetHeight(e.Graphics));
            myFont = new Font("Courier New", 12,
            FontStyle.Regular);
            e.Graphics.DrawString(" High = " + lblPH.Text,
            myFont,
            Brushes.Black, 150, y);
            e.Graphics.DrawString(" Total = " + lblPT.Text,
            myFont,
            Brushes.Black, 400, y);
            if (pnlPrecipPlot.BackgroundImage != null)
                e.Graphics.DrawImage(pnlPrecipPlot.BackgroundImage,150, 250, 500, Convert.ToInt32(500 *pnlTempPlot.ClientSize.Height /pnlTempPlot.ClientSize.Height));
            e.HasMorePages = false;
        }

        private void btnHelpData_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, hlpWeather.HelpNamespace);
        }
        private void grdWeather_KeyPress(object sender, KeyPressEventArgs e)
        {
            int currentColumn = grdWeather.CurrentCell.ColumnIndex;
            if (currentColumn > 0 && currentColumn < 4)
            {
                if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '-' || e.KeyChar == '.' || (int)e.KeyChar == 8)
                {
                    if ((e.KeyChar == '-' || e.KeyChar == '.') &&
                        grdWeather.CurrentCell.EditedFormattedValue.ToString().Contains(e.KeyChar.ToString()))
                        e.Handled = true;
                    else e.Handled = false;
                }
                else
                    e.Handled = true;
            }
        }
    }
}





