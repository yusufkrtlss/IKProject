using IKProject.DataAccessLayer.Abstract;
using IKProject.DataAccessLayer.Concrete;
using IKProject.DataAccessLayer.Repository;
using IKProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using MigraDoc.Rendering;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace IKProject.DataAccessLayer.EntityFramework
{
    public class EFApplicationDal : GenericRepository<Application>, IApplicationDal
    {
        public void UploadPdfFile(string fileName, byte[] fileContent)
        {
            using var _dbContext = new StoreContext();
            var document = new Document();
            var section = document.AddSection(); // Create a section

            section.AddParagraph("This is a paragraph in the section.");

            var renderer = new PdfDocumentRenderer();
            renderer.Document = document;
            renderer.RenderDocument();

            using (var stream = new MemoryStream())
            {
                renderer.Save(stream, false);
                var pdfDocument = new Application
                {
                    FileName = fileName,
                    PdfData = stream.ToArray(),
                    ApplicationTime = DateTime.Now
                };

                _dbContext.PdfDocuments.Add(pdfDocument);
                _dbContext.SaveChanges();
            }
        }
    }
}
