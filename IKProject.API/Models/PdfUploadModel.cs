namespace IKProject.API.Models
{
    public class PdfUploadModel
    {
        public string FileName { get; set; }
        public byte[] PdfData { get; set; }
    }
}
