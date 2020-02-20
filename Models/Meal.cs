using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FamousPortal.Models
{
    public class Meal
    {
        // [PrimaryKey, AutoIncrement]
        public string Id { get; set; }
        public int mealId { get; set; }
        public int categoryId { get; set; }
        public string mealName { get; set; }
        public int mealPrice { get; set; }

        [Display (Name = "Description")]
        public string mealDescription { get; set; }
        public string nutritionValues { get; set; }

        public bool available { get; set; }

        /*

       // [Microsoft.WindowsAzure.MobileServices.CreatedAt]
        
        public string CreatedAt { get; set; }

      //  [Microsoft.WindowsAzure.MobileServices.UpdatedAt]
        public string UpdatedAt { get; set; }
      //  [Microsoft.WindowsAzure.MobileServices.Version]
        public string AzureVersion { get; set; }
        */
    }
}
