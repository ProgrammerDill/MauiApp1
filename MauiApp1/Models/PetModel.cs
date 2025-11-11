using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Models
{
    // This class represents the data for the page.
    public class PetModel
    {
        public string Name { get; set; } = "James Bond";
        public string Breed { get; set; } = "Corgi";
        public string Age { get; set; } = "1 Year Old";
        public string OwnerName { get; set; } = "Mai";
        public string PostedDate { get; set; } = "21.10.2025";
        public string Location { get; set; } = "3B, Lorong 88, Taman Rantau Panjang, 96000 Sibu, Sarawak";
        public string Description { get; set; } = "Hi! James is a bright-eyed Corgi that has a burst of ginger and white fluff, ready to charm the world!";

        // This property will track if the pet is officially 'adopted' in the model.
        public bool IsAdopted { get; set; } = false;
    }
}
