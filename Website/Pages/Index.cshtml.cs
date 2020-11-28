/*
 * Author: Brian Parks
 * Class name: Index.cshtml.cs
 * Purpose: This is the data model for the index page of the bleakwind buffet website.
 */

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Website.Pages {

    /// <summary>
    /// This is the model class for the index of the bleakwind buffet website.
    /// </summary>
    public class IndexModel : PageModel {

        /// <summary>
        /// This is an enumerable object of entrees in the data model.
        /// </summary>
        public IEnumerable<IOrderItem> Entrees { get; set; }

        /// <summary>
        /// This is a dictionary of all sides in the data model. The key is the name of the item without any size of flavor indications such as "Dragonborn Waffle Fries" The List<IOrderItem> is a list of all permutations of items there are of that type. So for key "Dragonborn Waffle Fries" There would be 3 IOrderItems in that list, all being the 3 different sizes of the dragon born waffle fries.
        /// </summary>
        public Dictionary<string, List<IOrderItem>> Sides { get; set; } = new Dictionary<string, List<IOrderItem>>();

        /// <summary>
        /// This is a dictionary of all drinks in the data model. The key is the name of the item without any size of flavor indications such as "Sailor Soda" The List<IOrderItem> is a list of all permutations of items there are of that type. So for key "Sailor Soda" There would be many IOrderItems in that list. These items would be the different sizes for each different flavor of the sailor soda.
        /// </summary>
        public Dictionary<string, List<IOrderItem>> Drinks { get; set; } = new Dictionary<string, List<IOrderItem>>();

        /// <summary>
        /// This represents the minimum calories value given by the client.
        /// </summary>
        public uint? CaloriesMin { get; set; }

        /// <summary>
        /// This represents the maximum calories value given by the client.
        /// </summary>
        public uint? CaloriesMax { get; set; }

        /// <summary>
        /// This represents the minimum price given by the client.
        /// </summary>
        public double? PriceMin { get; set; }

        /// <summary>
        /// This is the maximum price given by the client.
        /// </summary>
        public double? PriceMax { get; set; }

        /// <summary>
        /// This is a string of the search terms given by the client.
        /// </summary>
        public string Terms { get; set; }

        /// <summary>
        /// This denotes whether to show the entrees or hide them.
        /// </summary>
        public bool ShowEntrees { get; set; } = true;

        /// <summary>
        /// This denotes whether to show the sides or hide them.
        /// </summary>
        public bool ShowSides { get; set; } = true;

        /// <summary>
        /// This denotes whether to show the drinks or hide them.
        /// </summary>
        public bool ShowDrinks { get; set; } = true;

        /// <summary>
        /// This is the OnGet method for the data model. This handles what to do when the client tries to get data from the website.
        /// </summary>
        /// <param name="Terms">The search terms that were sent by the client.</param>
        /// <param name="CaloriesMin">The minimum caloires that was sent by the client.</param>
        /// <param name="CaloriesMax">The maximum calories that was sent by the client.</param>
        /// <param name="PriceMin">The minimum price that was sent by the client.</param>
        /// <param name="PriceMax">The maximum price that was sent by the client.</param>
        /// <param name="ShowEntrees">Whether or not to show the entrees tab as sent by the client.</param>
        /// <param name="ShowDrinks">Whether or not to show the drinks tab as sent by the client.</param>
        /// <param name="ShowSides">Whether or not to show the sides tab as sent by the client.</param>
        public void OnGet(string Terms, uint? CaloriesMin, uint? CaloriesMax, double? PriceMin, double? PriceMax, bool ShowEntrees, bool ShowDrinks, bool ShowSides) {
            this.Terms = Terms;
            this.CaloriesMin = CaloriesMin;
            this.CaloriesMax = CaloriesMax;
            this.PriceMin = PriceMin;
            this.PriceMax = PriceMax;

            //Since the request only contains the key if they are checked, and only time query count is 0 is on first load to prevent from auto-disabling.
            if (Request.Query.Count != 0) {
                this.ShowEntrees = Request.Query.ContainsKey("ShowEntrees");
                this.ShowDrinks = Request.Query.ContainsKey("ShowDrinks");
                this.ShowSides = Request.Query.ContainsKey("ShowSides");
            }

            //Add all items to the bases here.
            if (this.ShowEntrees) {
                Entrees = Menu.Entrees();
                Entrees = Menu.FilterByCalories(Entrees, CaloriesMin, CaloriesMax);
                Entrees = Menu.FilterByPrice(Entrees, PriceMin, PriceMax);
                Entrees = Menu.Search(Entrees, Terms);
            }

            Dictionary<string, List<IOrderItem>> TempDrinks = new Dictionary<string, List<IOrderItem>>();
            Dictionary<string, List<IOrderItem>> TempSides = new Dictionary<string, List<IOrderItem>>();
            //Drinks
            if (this.ShowDrinks) {
                //Generate a temp dictionary of all possible drink items.
                foreach (IOrderItem drink in Menu.Drinks()) {
                    List<IOrderItem> res;
                    string key = "";
                    if (drink is SailorSoda) {
                        key = drink.ItemName.Substring(drink.ItemName.IndexOf(" ") + 1 + drink.ItemName.Substring(drink.ItemName.IndexOf(" ") + 1).IndexOf(" ") + 1);
                    } else {
                        key = drink.ItemName.Substring(drink.ItemName.IndexOf(" ") + 1);
                    }

                    if (TempDrinks.TryGetValue(key, out res)) {
                        //Handle the multiple types of Sailor Soda
                        if (res.Count != Enum.GetNames(typeof(Size)).Length) {
                            res.Add(drink);
                        }
                    } else {
                        List<IOrderItem> t = new List<IOrderItem>();
                        t.Add(drink);
                        TempDrinks.Add(key, t);
                    }
                }
                //Filter the items from the temp drinks dictionary and add the ones that make it through the filters into the real drinks dictionary.
                foreach (string key in TempDrinks.Keys) {
                    List<IOrderItem> outList;
                    if (TempDrinks.TryGetValue(key, out outList)) {
                        outList = Menu.FilterByCalories(outList, CaloriesMin, CaloriesMax).ToList();
                        outList = Menu.FilterByPrice(outList, PriceMin, PriceMax).ToList();
                        outList = Menu.Search(outList, Terms).ToList();
                        if (outList.Count != 0) {
                            Drinks.Add(key, outList);
                        }
                    }
                }
            }

            //Sides
            if (this.ShowSides) {
                //Generate a temp dictionary of all possible side items.
                foreach (IOrderItem side in Menu.Sides()) {
                    List<IOrderItem> res;
                    string key = side.ItemName.Substring(side.ItemName.IndexOf(" ") + 1);
                    if (TempSides.TryGetValue(key, out res)) {
                        res.Add(side);
                    } else {
                        List<IOrderItem> t = new List<IOrderItem>();
                        t.Add(side);
                        TempSides.Add(key, t);
                    }
                }
                //Filter the items from the temp drinks dictionary and add the ones that make it through the filters into the real sides dictionary.
                foreach (string key in TempSides.Keys) {
                    List<IOrderItem> outList;
                    if (TempSides.TryGetValue(key, out outList)) {
                        outList = Menu.FilterByCalories(outList, CaloriesMin, CaloriesMax).ToList();
                        outList = Menu.FilterByPrice(outList, PriceMin, PriceMax).ToList();
                        outList = Menu.Search(outList, Terms).ToList();
                        if (outList.Count != 0) {
                            Sides.Add(key, outList);
                        }
                    }
                }
            }
        }
    }
}