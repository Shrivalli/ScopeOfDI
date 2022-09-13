namespace ScopeOfAPI.Repository
{
    //https://www.c-sharpcorner.com/article/understanding-addtransient-vs-addscoped-vs-addsingleton-in-asp-net-core/
    public class Sample
    {
        public string? transient1 { get; set; }
        public string? transient2 { get; set; }
        public string? scoped1 { get; set; }
        public string? scoped2 {get;set;}
        public string? singleton1 { get; set; }
        public string? singleton2 { get; set; }
    }
}
