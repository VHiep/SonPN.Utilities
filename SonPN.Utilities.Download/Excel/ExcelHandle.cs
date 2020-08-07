using NLog;
using OfficeOpenXml;
using SonPN.Utilities.Download.Base;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;

namespace SonPN.Utilities.Download.Excel
{
    public class ExcelHandle:IFileHandle
    {
        private readonly ILogger _logger = LogManager.GetCurrentClassLogger();
        public ExcelHandle(int uriIndex, int imageNameIndex)
        {
            UriIndex = uriIndex;
            ImageNameIndex = imageNameIndex;
        }

        public ExcelHandle() { }

        public int UriIndex { get; set; }
        public int ImageNameIndex { get; set; }
        public Collection<NwImage> ReadFile(string path)
        {
            _logger.Trace($"Invoked with argument {path}");

            try
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                Collection<NwImage> imageList = new Collection<NwImage>();
                using (ExcelPackage excelPackage = new ExcelPackage(new FileInfo(path)))
                {
                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.FirstOrDefault();
                    if (worksheet == null) { return new Collection<NwImage>(); }
                
                    int rows = worksheet.Dimension.Rows;

                    if (UriIndex == ImageNameIndex && UriIndex == 0)
                    {
                        _logger.Trace("Setting default value for index of Uri to 1 and ImageName to 2");

                        UriIndex = 1;
                        ImageNameIndex = 2;
                    }
                
                    _logger.Trace($"Uri index is {UriIndex}, Imagename index is {ImageNameIndex}.");
                
                    for (int i = 1; i < rows; i++)
                    {
                        imageList.Add(new NwImage
                        {
                            Url = worksheet.Cells[i, UriIndex == 0 ? 1 : UriIndex].Value.ToString(),
                            Name = worksheet.Cells[i, ImageNameIndex == 0 ? 2 : ImageNameIndex].Value.ToString()
                        });
                    }

                }

                return imageList;
            }
            catch (Exception e)
            {
                _logger.Error(e, $"Exception when read excel file {path}");
                throw;
            }
        }
        public bool WriteFile(Collection<NwImage> nwData, string path)
        {
            throw new NotImplementedException();
        }
    }
}