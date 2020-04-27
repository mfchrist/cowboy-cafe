using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using CowboyCafe.Data;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// The items to display on the index page 
        /// </summary>
        public IEnumerable<IOrderItem> Items { get; protected set; }

        /// <summary>
        /// The current search terms 
        /// </summary>
        [BindProperty]
        public string SearchTerms { get; set; } = "";

        /// <summary>
        /// The minimum calories
        /// </summary>
        [BindProperty]
        public int? CalorieMin { get; set; }

        /// <summary>
        /// The maximum calories
        /// </summary>
        [BindProperty]
        public int? CalorieMax { get; set; }

        /// <summary>
        /// The minimum Price
        /// </summary>
        [BindProperty]
        public double? PriceMin { get; set; }

        /// <summary>
        /// The maximum Price
        /// </summary>
        [BindProperty]
        public double? PriceMax { get; set; }

        /// <summary>
        /// The filtered menu categories
        /// </summary>
        [BindProperty]
        public string[] Categories { get; set; }

        public void OnGet(int? CalorieMin, int? CalorieMax, double? PriceMin, double? PriceMax)
        {
            this.CalorieMin = CalorieMin;
            this.CalorieMax = CalorieMax;
            this.PriceMin = PriceMin;
            this.PriceMax = PriceMax;

            Items = Menu.Search(SearchTerms);
            Items = Menu.FilterByCalories(Items, CalorieMin, CalorieMax);
            Items = Menu.FilterByPrice(Items, PriceMin, PriceMax);
            //Items = Menu.FilterByCategory(Items, Categories);
        }
    }
}
