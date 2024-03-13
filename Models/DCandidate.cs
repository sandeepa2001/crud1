using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace crud1.Models
{
    public class DCandidate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mobile{ get; set; }
        public string email { get; set; }

        public int age { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string phone { get; set; }
        public string state { get; set; }
        public string zipcode { get; set; }
        public string city_url { get; set;}


    }
}
