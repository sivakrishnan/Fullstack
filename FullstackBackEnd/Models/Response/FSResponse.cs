namespace FullstackBackEnd.Models.Response
{
    public class FSResponse
    {
        public object? Result { get; set; }
        public bool IsSuccess { get; set; } = true;
        public string ResMsg { get; set; } = "";
    }
}
