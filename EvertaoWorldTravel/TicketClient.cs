using RestSharp;

namespace EvertaoWorldTravel
{
    internal class TicketClient
    {
        private readonly RestClient _restClient;

        public TicketClient()
        {
            const string ticketApiBaseUrl = "https://localhost:7025/";

            _restClient = new RestClient(ticketApiBaseUrl);
        }

        public List<Ticket> GetTickets()
        {
            var request = new RestRequest("api/GetTickets");

            var tickets = _restClient.Get<List<Ticket>>(request);

            return tickets;
        }

        public void DeleteTicket(int id)
        {
            var request = new RestRequest($"api/DeleteTicket/{id}");

            _restClient.Delete(request);
        }
    }
}
