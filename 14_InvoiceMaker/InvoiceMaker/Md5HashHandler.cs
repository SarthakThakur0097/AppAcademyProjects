using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace InvoiceMaker
{
    public class Md5HashHandler: IHttpHandler
    {

        public bool IsReusable
        {
            get { return false; }
        }

        public void ProcessRequest(HttpContext context)
        {
            string fullPath = context.Request.FilePath;
            string fileExtension = Path.GetExtension(fullPath);

            // Remove the leading slash (i.e. "/") and
            // the file extension.
            string valueToHash = fullPath
                .Substring(1).Replace(fileExtension, string.Empty);

            // Hash the value.
            using (MD5 md5Hash = MD5.Create())
            {
                switch (fileExtension)
                {
                    case ".hash":
                        WriteTextResponse(context, valueToHash, md5Hash);
                        break;
                    case ".binhash":
                        WriteBinaryResponse(context, valueToHash, md5Hash);
                        break;
                    default:
                        throw new Exception("Unexpected file extension: " + fileExtension);
                }
            }
        }

        private static void WriteTextResponse(HttpContext context, string valueToHash, MD5 md5Hash)
        {
            string hash = GetMd5HashText(md5Hash, valueToHash);
            context.Response.ContentType = "text/plain";
            context.Response.Write(hash);
        }

        private static string GetMd5HashText(MD5 md5Hash, string valueToHash)
        {
            throw new NotImplementedException();
        }

        private static void WriteBinaryResponse(HttpContext context, string valueToHash, MD5 md5Hash)
        {
            byte[] hash = GetMd5HashBinary(md5Hash, valueToHash);
            context.Response.ContentType = "application/octet-stream";
            context.Response.AppendHeader("Content-Disposition", "attachment; filename=BinaryHash.bin");
            context.Response.BinaryWrite(hash);
        }

        private static byte[] GetMd5HashBinary(MD5 md5Hash, string valueToHash)
        {
            throw new NotImplementedException();
        }
    }
}