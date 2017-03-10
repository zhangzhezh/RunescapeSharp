using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RunescapeSharp;
using RunescapeSharp.Enumerations;

namespace TestConsoleApp
{
    public class Program
    {
        public static void Main()
        {
            var API = RunescapeAPI.GetInstance();

            #region GE Tests

            var GE = API.GrandExchange;

            var Result = GE.GetCategoryByLetter(3);
            var Runedate = GE.GetRunedate();

            var Category = GE.GetItemsInCategory(GrandExchangeCategories.Bolts, "a", 1);

            var Item = GE.GetItemDetail(Category.Items?[0].Id);
            var Sprite = GE.GetIconUrl(IconTypes.Sprite, Category.Items?[0].Id);

            var Graph = GE.GetGraph(Category.Items?[0].Id);

            #endregion

            #region Hiscore Tests

            #endregion

        }
    }
}
