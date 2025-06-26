﻿using Newtonsoft.Json;

namespace DrinksInfo.Jasmine330.Models
{
   public class Category
    {
        public string strCategory { get; set; }
    }

    public class Categories
    {
        [JsonProperty("drinks")]
        public List<Category> CategoriesList { get; set; }
    }
}
