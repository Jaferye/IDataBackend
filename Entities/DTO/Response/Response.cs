namespace Entities.DTO.Response
{
    public class Response
    {
        public bool Succeded { get; set; }
        public string Message { get; set; }
        public string Error { get; set; }
        public object Data { get; set; }


        public Response()
        {

        }

        public Response(object data)
        {
            this.Succeded = true;
            this.Message = "Process completed successfully.";
            this.Data = data;
        }
    }
}
