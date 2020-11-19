using System;
using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class Movie
    {
        
        /*
            *  The Movie class contains:

            The ID field is required by the database for the primary key.
            

            [DataType(DataType.Date)]: The DataType attribute specifies the type of the data(Date).With this attribute:


            The user is not required to enter time information in the date field.
            Only the date is displayed, not time information.
        */

        public int ID { get; set; }

        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public string Genre { get; set; }

        public decimal Price { get; set; }
    }
}

