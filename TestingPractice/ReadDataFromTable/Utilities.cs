using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingPractice.ReadDataFromTable
{
    public class Utilities:Base
    {
        List<TableDatasetcollec> TDS =new List<TableDatasetcollec>();

        public void ReadTable(IWebElement table)
        {
            var noofRows = table.FindElements(By.TagName("//tr"));
            int rowcount = 0;
            var noOfcolumns = table.FindElements(By.TagName("//th"));
            foreach(var row in noofRows)
            {
                int colcount = 0;
                var  colValues = row.FindElements(By.TagName("//td"));
                foreach (var column in colValues )
                {
                    TDS.Add(new TableDatasetcollec
                    {
                        rowNum = rowcount,
                        colName = noOfcolumns[colcount].Text,
                        colVal = column.Text
                    }) ;
                    Console.WriteLine(rowcount + " " + noOfcolumns[colcount].Text + " " + column.Text);
                    colcount++;
                }
                rowcount++;
            }
        }
        public void getCellData(string colmnName,int rowNumber)
        {
            foreach(var val in TDS)
            {
                Console.WriteLine(val);
                if (val.rowNum == rowNumber && val.colName == colmnName)
                {
                    Console.WriteLine("yes");
                    Console.WriteLine(val.colVal);
                }
            }
        }
    }
    public class TableDatasetcollec
    {
        public int rowNum { get; set; }
        public string colName { get; set; }
        public string colVal { get; set; }

    }
}
