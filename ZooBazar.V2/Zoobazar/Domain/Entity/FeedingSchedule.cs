using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class FeedingSchedule
    {
        public string Species { get; set; }
        public string Habitat {  get; set; }
        public List<TimeSpan> FeedingTimes { get; set; }
        public FeedingSchedule(string species, string habitat, List<TimeSpan> feedingTimes)
        {
            Species = species;
            Habitat = habitat;
            FeedingTimes = feedingTimes;
        }

        public static List<FeedingSchedule> GetFeedingSchedules()
        {
            return new List<FeedingSchedule>
            {
                new FeedingSchedule("Shark", "Aqua Odyssey", new List<TimeSpan> {new TimeSpan(15, 0, 0)})
            };   
        }
    }
}
