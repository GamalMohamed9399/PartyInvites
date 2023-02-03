namespace PartyInvites.Models
{
    public class Repository
    {
        private static List<GuestResponse> _response= new ();
        public static IEnumerable<GuestResponse> Response => _response; 

        public static void AddResponse(GuestResponse response)
        {
            Console.WriteLine("Response");
            _response.Add(response);    
        }
    }
}
