/*
 * Author: Brian Parks
 * Class name: Menu.cs
 * Purpose: Static class used to get specific lists of menu options, such as the list of entrees, drinks, sides, and all.
 */

using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BleakwindBuffet.Data {

    public static class Menu {

        /// <summary>
        /// Gets a list of all entrees on the menu.
        /// </summary>
        /// <returns>A list of IOrderItem objects that contains all entrees.</returns>
        public static IEnumerable<IOrderItem> Entrees() {
            List<IOrderItem> entrees = new List<IOrderItem>();
            entrees.Add(new BriarheartBurger());
            entrees.Add(new DoubleDraugr());
            entrees.Add(new GardenOrcOmelette());
            entrees.Add(new PhillyPoacher());
            entrees.Add(new SmokehouseSkeleton());
            entrees.Add(new ThalmorTriple());
            entrees.Add(new ThugsTBone());
            return entrees;
        }

        /// <summary>
        /// Gets a list of all sides on the menu.
        /// </summary>
        /// <returns>A list of IOrderItem objects that contains all sides.</returns>
        public static IEnumerable<IOrderItem> Sides() {
            List<IOrderItem> sides = new List<IOrderItem>();
            Side s;

            //DragonbornWaffleFries
            foreach (Size size in Enum.GetValues(typeof(Size))) {
                s = new DragonbornWaffleFries();
                s.Size = size;
                sides.Add(s);
            }

            //FriedMiraak
            foreach (Size size in Enum.GetValues(typeof(Size))) {
                s = new FriedMiraak();
                s.Size = size;
                sides.Add(s);
            }

            //MadOtarGrits
            foreach (Size size in Enum.GetValues(typeof(Size))) {
                s = new MadOtarGrits();
                s.Size = size;
                sides.Add(s);
            }

            //VokunSalad
            foreach (Size size in Enum.GetValues(typeof(Size))) {
                s = new VokunSalad();
                s.Size = size;
                sides.Add(s);
            }

            return sides;
        }

        /// <summary>
        /// Gets a list of all drinks on the menu.
        /// </summary>
        /// <returns>A list of IOrderItem objects that contains all drinks.</returns>
        public static IEnumerable<IOrderItem> Drinks() {
            List<IOrderItem> drinks = new List<IOrderItem>();
            Drink d;

            //AretinoAppleJuice
            foreach (Size size in Enum.GetValues(typeof(Size))) {
                d = new AretinoAppleJuice();
                d.Size = size;
                drinks.Add(d);
            }

            //CandlehearthCoffee
            foreach (Size size in Enum.GetValues(typeof(Size))) {
                d = new CandlehearthCoffee();
                d.Size = size;
                drinks.Add(d);
            }

            //MarkarthMilk
            foreach (Size size in Enum.GetValues(typeof(Size))) {
                d = new MarkarthMilk();
                d.Size = size;
                drinks.Add(d);
            }

            //WarriorWater
            foreach (Size size in Enum.GetValues(typeof(Size))) {
                d = new WarriorWater();
                d.Size = size;
                drinks.Add(d);
            }

            //Sailor Soda
            foreach (SodaFlavor sf in Enum.GetValues(typeof(SodaFlavor))) {
                foreach (Size size in Enum.GetValues(typeof(Size))) {
                    d = new SailorSoda();
                    d.Size = size;
                    ((SailorSoda)d).Flavor = sf;
                    drinks.Add(d);
                }
            }

            return drinks;
        }

        /// <summary>
        /// Gets a list of all items on the menu.
        /// </summary>
        /// <returns>A list of IOrderItem objects that contains all items.</returns>
        public static IEnumerable<IOrderItem> FullMenu() {
            List<IOrderItem> fullMenu = new List<IOrderItem>();
            foreach (IOrderItem i in Menu.Entrees()) {
                fullMenu.Add(i);
            }
            foreach (IOrderItem i in Menu.Sides()) {
                fullMenu.Add(i);
            }
            foreach (IOrderItem i in Menu.Drinks()) {
                fullMenu.Add(i);
            }
            return fullMenu;
        }

        /// <summary>
        /// Filters out all of the items that does not contain one of the search terms.
        /// </summary>
        /// <param name="baseItems">The items to search through.</param>
        /// <param name="terms">The terms to search by.</param>
        /// <returns>Returns a list of IOrderItem objects.</returns>
        public static IEnumerable<IOrderItem> Search(IEnumerable<IOrderItem> baseItems, string terms) {
            if (terms == null || baseItems == null) {
                return baseItems;
            }
            baseItems = baseItems.Where(item => {
                if (item == null || item.ItemName == null || item.Description == null) {
                    return false;
                }
                foreach (string s in terms.Split(' ')) if (s != "") {
                        if (item.ItemName.ToLower().Contains(s.ToLower()) || item.Description.ToLower().Contains(s.ToLower())) {
                            return true;
                        }
                    }
                return false;
            });
            return baseItems;
        }

        /// <summary>
        /// Filters out all of the items that are not within the min and maximum calorie value.
        /// </summary>
        /// <param name="items">The items to search through.</param>
        /// <param name="min">The minimum calorie value.</param>
        /// <param name="max">The maximum calorie value.</param>
        /// <returns>Returns a list of IOrderItem objects.</returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> items, uint? min, uint? max) {
            if (min != null) {
                items = items.Where(item => {
                    if (item == null) {
                        return false;
                    }
                    if (item.Calories >= min) {
                        return true;
                    }
                    return false;
                });
            }
            if (max != null) {
                items = items.Where(item => {
                    if (item == null) {
                        return false;
                    }
                    if (item.Calories <= max) {
                        return true;
                    }
                    return false;
                });
            }
            return items;
        }

        /// <summary>
        /// Filters out all of the items that are not within the min and maximum price value.
        /// </summary>
        /// <param name="items">The items to search through.</param>
        /// <param name="min">The minimum price value.</param>
        /// <param name="max">The maximum price value.</param>
        /// <returns>Returns a list of IOrderItem objects.</returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> items, double? min, double? max) {
            if (min != null) {
                items = items.Where(item => {
                    if (item == null) {
                        return false;
                    }
                    if (item.Price >= min) {
                        return true;
                    }
                    return false;
                });
            }
            if (max != null) {
                items = items.Where(item => {
                    if (item == null) {
                        return false;
                    }
                    if (item.Price <= max) {
                        return true;
                    }
                    return false;
                });
            }
            return items;
        }
    }
}