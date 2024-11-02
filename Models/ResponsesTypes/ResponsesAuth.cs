namespace CarApi.Models.ResponsesTypes
{
    public class ResponseSignUp
    {
        public Guid UserId { get; set; }
        public string Message { get; set; }
    }

    public class ResponseLogIn
    {
        public Guid UserId {  get; set; }
        public string Token { get; set; }
    }

}
