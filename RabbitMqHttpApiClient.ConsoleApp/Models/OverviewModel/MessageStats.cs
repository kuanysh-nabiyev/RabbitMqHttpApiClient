namespace RabbitMqHttpApiClient.ConsoleApp.Models.OverviewModel
{
    public class MessageStats
    {
        public int deliver { get; set; }
        public RateDetails deliver_details { get; set; }
        public int deliver_no_ack { get; set; }
        public RateDetails deliver_no_ack_details { get; set; }
        public int get { get; set; }
        public RateDetails get_details { get; set; }
        public int get_no_ack { get; set; }
        public RateDetails get_no_ack_details { get; set; }
        public int publish { get; set; }
        public RateDetails publish_details { get; set; }
        public int publish_in { get; set; }
        public RateDetails publish_in_details { get; set; }
        public int publish_out { get; set; }
        public RateDetails publish_out_details { get; set; }
        public int ack { get; set; }
        public RateDetails ack_details { get; set; }
        public int deliver_get { get; set; }
        public RateDetails deliver_get_details { get; set; }
        public int confirm { get; set; }
        public RateDetails confirm_details { get; set; }
        public int return_unroutable { get; set; }
        public RateDetails return_unroutable_details { get; set; }
        public int redeliver { get; set; }
        public RateDetails redeliver_details { get; set; }
    }
}