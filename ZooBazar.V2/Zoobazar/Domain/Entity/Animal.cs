

namespace Domain.Entity
{
    public class Animal
    {

        public DateTime LastFeedTime { get; set; } // Last feed time of the animal

        // Constructor
        public Animal( DateTime lastFeedTime)
        {
            
            LastFeedTime = lastFeedTime;
        }

        
        public virtual string Feed()
        {
            LastFeedTime = DateTime.Now;
            return "Feeding the animal.";
        }
               

    }
}
