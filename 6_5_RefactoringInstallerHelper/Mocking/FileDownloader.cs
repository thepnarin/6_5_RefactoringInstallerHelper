﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _6_5_RefactoringInstallerHelper.Mocking
{
    public interface IFileDownloader
    {
        void DownloadFile(string url, string path);
    }

    public class FileDownloader : IFileDownloader
    {
        public void DownloadFile(string url, string path)
        {
            var client = new WebClient();
            client.DownloadFile(url, path);
        }
    }
}
