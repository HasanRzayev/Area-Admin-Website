namespace UltraWebsite.Helpers
{
    public static class UploadFileHelper
    {
        public async static Task<string> UploadFile(IFormFile file)
        {
            string link = Guid.NewGuid().ToString();
            var fs = new FileStream(@$"wwwroot/{link}{Path.GetExtension(file.FileName)}", FileMode.Create);

            await file.CopyToAsync(fs);

            return @$"~/{link}{Path.GetExtension(file.FileName)}";
        }
    }
}
