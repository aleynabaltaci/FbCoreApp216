namespace FbCoreApp216.Mvc.DTOs
{
    public class ErrorDto
    {

        public ErrorDto()
        {
            Errors = new List<string>();
        }

        //yukarıdaki yapı ve alttaki satır aynı işlev--constructor
        //public ErrorDto() => new List<string>(); 
        public List<string> Errors { get; set; }

        public int Status { get; set; }

    }
}
