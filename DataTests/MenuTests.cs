/*
 * Author: Brian Parks
 * Class: MenuTests.cs
 * Purpose: Test the Menu.cs class in the Data library
 */
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.DataTests.UnitTests.MockImplementation;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace BleakwindBuffet.DataTests {
    public class MenuTests {
        [Fact]
        public void CheckCorrectEntrees() {
            Assert.Collection(Menu.Entrees(),
                item => Assert.IsType<BriarheartBurger>(item),
                item => Assert.IsType<DoubleDraugr>(item),
                item => Assert.IsType<GardenOrcOmelette>(item),
                item => Assert.IsType<PhillyPoacher>(item),
                item => Assert.IsType<SmokehouseSkeleton>(item),
                item => Assert.IsType<ThalmorTriple>(item),
                item => Assert.IsType<ThugsTBone>(item));
        }

        [Fact]
        public void CheckCorrectSides() {
            Assert.Collection(Menu.Sides(),
                //DragonbornWaffleFries
                item => {
                    Assert.IsType<DragonbornWaffleFries>(item);
                    DragonbornWaffleFries dbwf = (DragonbornWaffleFries)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Small, dbwf.Size);
                },
                item => {
                    Assert.IsType<DragonbornWaffleFries>(item);
                    DragonbornWaffleFries dbwf = (DragonbornWaffleFries)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Medium, dbwf.Size);
                },
                item => {
                    Assert.IsType<DragonbornWaffleFries>(item);
                    DragonbornWaffleFries dbwf = (DragonbornWaffleFries)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Large, dbwf.Size);
                },
                //FriedMiraak
                item => {
                    Assert.IsType<FriedMiraak>(item);
                    FriedMiraak fm = (FriedMiraak)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Small, fm.Size);
                },
                item => {
                    Assert.IsType<FriedMiraak>(item);
                    FriedMiraak fm = (FriedMiraak)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Medium, fm.Size);
                },
                item => {
                    Assert.IsType<FriedMiraak>(item);
                    FriedMiraak fm = (FriedMiraak)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Large, fm.Size);
                },
                //MadOtarGrits
                item => {
                    Assert.IsType<MadOtarGrits>(item);
                    MadOtarGrits mog = (MadOtarGrits)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Small, mog.Size);
                },
                item => {
                    Assert.IsType<MadOtarGrits>(item);
                    MadOtarGrits mog = (MadOtarGrits)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Medium, mog.Size);
                },
                item => {
                    Assert.IsType<MadOtarGrits>(item);
                    MadOtarGrits mog = (MadOtarGrits)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Large, mog.Size);
                },
                //VokunSalad
                item => {
                    Assert.IsType<VokunSalad>(item);
                    VokunSalad vs = (VokunSalad)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Small, vs.Size);
                },
                item => {
                    Assert.IsType<VokunSalad>(item);
                    VokunSalad vs = (VokunSalad)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Medium, vs.Size);
                },
                item => {
                    Assert.IsType<VokunSalad>(item);
                    VokunSalad vs = (VokunSalad)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Large, vs.Size);
                });
        }

        [Fact]
        public void CheckCorrectDrinks() {
            Assert.Collection(Menu.Drinks(),
                //AretinoAppleJuice
                item => {
                    Assert.IsType<AretinoAppleJuice>(item);
                    AretinoAppleJuice aa = (AretinoAppleJuice)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Small, aa.Size);
                },
                item => {
                    Assert.IsType<AretinoAppleJuice>(item);
                    AretinoAppleJuice aa = (AretinoAppleJuice)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Medium, aa.Size);
                },
                item => {
                    Assert.IsType<AretinoAppleJuice>(item);
                    AretinoAppleJuice aa = (AretinoAppleJuice)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Large, aa.Size);
                },
                //CandlehearthCofffee
                item => {
                    Assert.IsType<CandlehearthCoffee>(item);
                    CandlehearthCoffee chc = (CandlehearthCoffee)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Small, chc.Size);
                },
                item => {
                    Assert.IsType<CandlehearthCoffee>(item);
                    CandlehearthCoffee chc = (CandlehearthCoffee)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Medium, chc.Size);
                },
                item => {
                    Assert.IsType<CandlehearthCoffee>(item);
                    CandlehearthCoffee chc = (CandlehearthCoffee)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Large, chc.Size);
                },
                //MarkarthMilk
                item => {
                    Assert.IsType<MarkarthMilk>(item);
                    MarkarthMilk mm = (MarkarthMilk)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Small, mm.Size);
                },
                item => {
                    Assert.IsType<MarkarthMilk>(item);
                    MarkarthMilk mm = (MarkarthMilk)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Medium, mm.Size);
                },
                item => {
                    Assert.IsType<MarkarthMilk>(item);
                    MarkarthMilk mm = (MarkarthMilk)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Large, mm.Size);
                },
                //Warrior Water.
                item => {
                    Assert.IsType<WarriorWater>(item);
                    WarriorWater ww = (WarriorWater)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Small, ww.Size);
                },
                item => {
                    Assert.IsType<WarriorWater>(item);
                    WarriorWater ww = (WarriorWater)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Medium, ww.Size);
                },
                item => {
                    Assert.IsType<WarriorWater>(item);
                    WarriorWater ww = (WarriorWater)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Large, ww.Size);
                },
                //SailorSoda

                //Blackberry
                item => {
                    Assert.IsType<SailorSoda>(item);
                    SailorSoda ss = (SailorSoda)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Small, ss.Size);
                    Assert.Equal(SodaFlavor.Blackberry, ss.Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    SailorSoda ss = (SailorSoda)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Medium, ss.Size);
                    Assert.Equal(SodaFlavor.Blackberry, ss.Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    SailorSoda ss = (SailorSoda)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Large, ss.Size);
                    Assert.Equal(SodaFlavor.Blackberry, ss.Flavor);
                },

                //Cherry
                item => {
                    Assert.IsType<SailorSoda>(item);
                    SailorSoda ss = (SailorSoda)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Small, ss.Size);
                    Assert.Equal(SodaFlavor.Cherry, ss.Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    SailorSoda ss = (SailorSoda)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Medium, ss.Size);
                    Assert.Equal(SodaFlavor.Cherry, ss.Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    SailorSoda ss = (SailorSoda)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Large, ss.Size);
                    Assert.Equal(SodaFlavor.Cherry, ss.Flavor);
                },

                //Grapefruit
                item => {
                    Assert.IsType<SailorSoda>(item);
                    SailorSoda ss = (SailorSoda)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Small, ss.Size);
                    Assert.Equal(SodaFlavor.Grapefruit, ss.Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    SailorSoda ss = (SailorSoda)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Medium, ss.Size);
                    Assert.Equal(SodaFlavor.Grapefruit, ss.Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    SailorSoda ss = (SailorSoda)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Large, ss.Size);
                    Assert.Equal(SodaFlavor.Grapefruit, ss.Flavor);
                },

                //Lemon
                item => {
                    Assert.IsType<SailorSoda>(item);
                    SailorSoda ss = (SailorSoda)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Small, ss.Size);
                    Assert.Equal(SodaFlavor.Lemon, ss.Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    SailorSoda ss = (SailorSoda)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Medium, ss.Size);
                    Assert.Equal(SodaFlavor.Lemon, ss.Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    SailorSoda ss = (SailorSoda)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Large, ss.Size);
                    Assert.Equal(SodaFlavor.Lemon, ss.Flavor);
                },

                //Peach
                item => {
                    Assert.IsType<SailorSoda>(item);
                    SailorSoda ss = (SailorSoda)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Small, ss.Size);
                    Assert.Equal(SodaFlavor.Peach, ss.Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    SailorSoda ss = (SailorSoda)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Medium, ss.Size);
                    Assert.Equal(SodaFlavor.Peach, ss.Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    SailorSoda ss = (SailorSoda)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Large, ss.Size);
                    Assert.Equal(SodaFlavor.Peach, ss.Flavor);
                },

                //Watermelon
                item => {
                    Assert.IsType<SailorSoda>(item);
                    SailorSoda ss = (SailorSoda)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Small, ss.Size);
                    Assert.Equal(SodaFlavor.Watermelon, ss.Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    SailorSoda ss = (SailorSoda)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Medium, ss.Size);
                    Assert.Equal(SodaFlavor.Watermelon, ss.Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    SailorSoda ss = (SailorSoda)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Large, ss.Size);
                    Assert.Equal(SodaFlavor.Watermelon, ss.Flavor);
                });
        }

        [Fact]
        public void CheckCorrectFullMenu() {
            Assert.Collection(Menu.FullMenu(),
                //Entrees
                item => Assert.IsType<BriarheartBurger>(item),
                item => Assert.IsType<DoubleDraugr>(item),
                item => Assert.IsType<GardenOrcOmelette>(item),
                item => Assert.IsType<PhillyPoacher>(item),
                item => Assert.IsType<SmokehouseSkeleton>(item),
                item => Assert.IsType<ThalmorTriple>(item),
                item => Assert.IsType<ThugsTBone>(item),

                                //Sides
                                item => {
                                    Assert.IsType<DragonbornWaffleFries>(item);
                                    DragonbornWaffleFries dbwf = (DragonbornWaffleFries)item;//Should be safe as it was asserted above for type
                                    Assert.Equal(Size.Small, dbwf.Size);
                                },
                item => {
                    Assert.IsType<DragonbornWaffleFries>(item);
                    DragonbornWaffleFries dbwf = (DragonbornWaffleFries)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Medium, dbwf.Size);
                },
                item => {
                    Assert.IsType<DragonbornWaffleFries>(item);
                    DragonbornWaffleFries dbwf = (DragonbornWaffleFries)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Large, dbwf.Size);
                },
                //FriedMiraak
                item => {
                    Assert.IsType<FriedMiraak>(item);
                    FriedMiraak fm = (FriedMiraak)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Small, fm.Size);
                },
                item => {
                    Assert.IsType<FriedMiraak>(item);
                    FriedMiraak fm = (FriedMiraak)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Medium, fm.Size);
                },
                item => {
                    Assert.IsType<FriedMiraak>(item);
                    FriedMiraak fm = (FriedMiraak)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Large, fm.Size);
                },
                //MadOtarGrits
                item => {
                    Assert.IsType<MadOtarGrits>(item);
                    MadOtarGrits mog = (MadOtarGrits)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Small, mog.Size);
                },
                item => {
                    Assert.IsType<MadOtarGrits>(item);
                    MadOtarGrits mog = (MadOtarGrits)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Medium, mog.Size);
                },
                item => {
                    Assert.IsType<MadOtarGrits>(item);
                    MadOtarGrits mog = (MadOtarGrits)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Large, mog.Size);
                },
                //VokunSalad
                item => {
                    Assert.IsType<VokunSalad>(item);
                    VokunSalad vs = (VokunSalad)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Small, vs.Size);
                },
                item => {
                    Assert.IsType<VokunSalad>(item);
                    VokunSalad vs = (VokunSalad)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Medium, vs.Size);
                },
                item => {
                    Assert.IsType<VokunSalad>(item);
                    VokunSalad vs = (VokunSalad)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Large, vs.Size);
                },

                //Drinks

                //AretinoAppleJuice
                item => {
                    Assert.IsType<AretinoAppleJuice>(item);
                    AretinoAppleJuice aa = (AretinoAppleJuice)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Small, aa.Size);
                },
                item => {
                    Assert.IsType<AretinoAppleJuice>(item);
                    AretinoAppleJuice aa = (AretinoAppleJuice)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Medium, aa.Size);
                },
                item => {
                    Assert.IsType<AretinoAppleJuice>(item);
                    AretinoAppleJuice aa = (AretinoAppleJuice)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Large, aa.Size);
                },
                //CandlehearthCofffee
                item => {
                    Assert.IsType<CandlehearthCoffee>(item);
                    CandlehearthCoffee chc = (CandlehearthCoffee)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Small, chc.Size);
                },
                item => {
                    Assert.IsType<CandlehearthCoffee>(item);
                    CandlehearthCoffee chc = (CandlehearthCoffee)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Medium, chc.Size);
                },
                item => {
                    Assert.IsType<CandlehearthCoffee>(item);
                    CandlehearthCoffee chc = (CandlehearthCoffee)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Large, chc.Size);
                },
                //MarkarthMilk
                item => {
                    Assert.IsType<MarkarthMilk>(item);
                    MarkarthMilk mm = (MarkarthMilk)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Small, mm.Size);
                },
                item => {
                    Assert.IsType<MarkarthMilk>(item);
                    MarkarthMilk mm = (MarkarthMilk)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Medium, mm.Size);
                },
                item => {
                    Assert.IsType<MarkarthMilk>(item);
                    MarkarthMilk mm = (MarkarthMilk)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Large, mm.Size);
                },
                //Warrior Water.
                item => {
                    Assert.IsType<WarriorWater>(item);
                    WarriorWater ww = (WarriorWater)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Small, ww.Size);
                },
                item => {
                    Assert.IsType<WarriorWater>(item);
                    WarriorWater ww = (WarriorWater)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Medium, ww.Size);
                },
                item => {
                    Assert.IsType<WarriorWater>(item);
                    WarriorWater ww = (WarriorWater)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Large, ww.Size);
                },
                //SailorSoda

                //Blackberry
                item => {
                    Assert.IsType<SailorSoda>(item);
                    SailorSoda ss = (SailorSoda)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Small, ss.Size);
                    Assert.Equal(SodaFlavor.Blackberry, ss.Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    SailorSoda ss = (SailorSoda)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Medium, ss.Size);
                    Assert.Equal(SodaFlavor.Blackberry, ss.Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    SailorSoda ss = (SailorSoda)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Large, ss.Size);
                    Assert.Equal(SodaFlavor.Blackberry, ss.Flavor);
                },

                //Cherry
                item => {
                    Assert.IsType<SailorSoda>(item);
                    SailorSoda ss = (SailorSoda)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Small, ss.Size);
                    Assert.Equal(SodaFlavor.Cherry, ss.Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    SailorSoda ss = (SailorSoda)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Medium, ss.Size);
                    Assert.Equal(SodaFlavor.Cherry, ss.Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    SailorSoda ss = (SailorSoda)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Large, ss.Size);
                    Assert.Equal(SodaFlavor.Cherry, ss.Flavor);
                },

                //Grapefruit
                item => {
                    Assert.IsType<SailorSoda>(item);
                    SailorSoda ss = (SailorSoda)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Small, ss.Size);
                    Assert.Equal(SodaFlavor.Grapefruit, ss.Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    SailorSoda ss = (SailorSoda)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Medium, ss.Size);
                    Assert.Equal(SodaFlavor.Grapefruit, ss.Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    SailorSoda ss = (SailorSoda)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Large, ss.Size);
                    Assert.Equal(SodaFlavor.Grapefruit, ss.Flavor);
                },

                //Lemon
                item => {
                    Assert.IsType<SailorSoda>(item);
                    SailorSoda ss = (SailorSoda)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Small, ss.Size);
                    Assert.Equal(SodaFlavor.Lemon, ss.Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    SailorSoda ss = (SailorSoda)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Medium, ss.Size);
                    Assert.Equal(SodaFlavor.Lemon, ss.Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    SailorSoda ss = (SailorSoda)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Large, ss.Size);
                    Assert.Equal(SodaFlavor.Lemon, ss.Flavor);
                },

                //Peach
                item => {
                    Assert.IsType<SailorSoda>(item);
                    SailorSoda ss = (SailorSoda)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Small, ss.Size);
                    Assert.Equal(SodaFlavor.Peach, ss.Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    SailorSoda ss = (SailorSoda)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Medium, ss.Size);
                    Assert.Equal(SodaFlavor.Peach, ss.Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    SailorSoda ss = (SailorSoda)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Large, ss.Size);
                    Assert.Equal(SodaFlavor.Peach, ss.Flavor);
                },

                //Watermelon
                item => {
                    Assert.IsType<SailorSoda>(item);
                    SailorSoda ss = (SailorSoda)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Small, ss.Size);
                    Assert.Equal(SodaFlavor.Watermelon, ss.Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    SailorSoda ss = (SailorSoda)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Medium, ss.Size);
                    Assert.Equal(SodaFlavor.Watermelon, ss.Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    SailorSoda ss = (SailorSoda)item;//Should be safe as it was asserted above for type
                    Assert.Equal(Size.Large, ss.Size);
                    Assert.Equal(SodaFlavor.Watermelon, ss.Flavor);
                });
        }
        [Fact]
        public void ShouldSearchName() {
            //Only a Garden Orc Omelette has the string "Garden" in it's name
            IEnumerable<IOrderItem> items = Menu.Entrees();
            items = Menu.Search(items, "Garden");
            Assert.Single(items);
            Assert.Collection(items, item => Assert.IsType<GardenOrcOmelette>(item));
        }

        [Fact]
        public void ShouldSearchDescription() {
            //Only a Thugs T-Bone has the string "Juicy" in it's description
            IEnumerable<IOrderItem> items = Menu.Entrees();
            items = Menu.Search(items, "Juicy");
            Assert.Single(items);
            Assert.Collection(items, item => Assert.IsType<ThugsTBone>(item));
        }

        [Fact]
        public void ShouldSearchBoth() {
            //Search with 2 terms, one in descriptions, 1 in names
            IEnumerable<IOrderItem> items = Menu.Entrees();
            items = Menu.Search(items, "Garden patty");
            Assert.Equal(4, items.Count());
            Assert.Collection(items,
                item => Assert.IsType<BriarheartBurger>(item),
                item => Assert.IsType<DoubleDraugr>(item),
                item => Assert.IsType<GardenOrcOmelette>(item),
                item => Assert.IsType<ThalmorTriple>(item)
                );
        }
        [Fact]
        public void ShouldNotChangeSearchOnNullTerms() {
            IEnumerable<IOrderItem> items = Menu.Entrees();
            items = Menu.Search(items, null);
            Assert.Collection(Menu.Entrees(),
                item => Assert.IsType<BriarheartBurger>(item),
                item => Assert.IsType<DoubleDraugr>(item),
                item => Assert.IsType<GardenOrcOmelette>(item),
                item => Assert.IsType<PhillyPoacher>(item),
                item => Assert.IsType<SmokehouseSkeleton>(item),
                item => Assert.IsType<ThalmorTriple>(item),
                item => Assert.IsType<ThugsTBone>(item));
        }
        [Fact]
        public void ShouldNotFailSearchOnNullItem() {
            IEnumerable<IOrderItem> items = Menu.Entrees();
            items = Menu.Search(null, "Test");
            Assert.Equal(null, items);
        }
        [Fact]
        public void ShouldNotChangeSearchOnNullItemAndTerms() {
            IEnumerable<IOrderItem> items = Menu.Entrees();
            items = Menu.Search(null, null);
            Assert.Collection(Menu.Entrees(),
                item => Assert.IsType<BriarheartBurger>(item),
                item => Assert.IsType<DoubleDraugr>(item),
                item => Assert.IsType<GardenOrcOmelette>(item),
                item => Assert.IsType<PhillyPoacher>(item),
                item => Assert.IsType<SmokehouseSkeleton>(item),
                item => Assert.IsType<ThalmorTriple>(item),
                item => Assert.IsType<ThugsTBone>(item));
        }
        [Fact]
        public void ShouldFilterByMinimumCalories() {
            List<IOrderItem> items = new List<IOrderItem>();
            items.Add(new MockEntreeImplementation(5, 400));
            items.Add(new MockEntreeImplementation(5, 600));
            items.Add(new MockEntreeImplementation(5, 900));
            items.Add(new MockEntreeImplementation(5, 1200));
            items = Menu.FilterByCalories(items, 700, null).ToList<IOrderItem>();
            Assert.Collection(items,
                item => {
                    Assert.IsType<MockEntreeImplementation>(item);
                    Assert.Equal((uint?)900, item.Calories);
                },
                item => {
                    Assert.IsType<MockEntreeImplementation>(item);
                    Assert.Equal((uint?)1200, item.Calories);
                }
                );
        }
        [Fact]
        public void ShouldFilterByMaximumCalories() {
            List<IOrderItem> items = new List<IOrderItem>();
            items.Add(new MockEntreeImplementation(5, 400));
            items.Add(new MockEntreeImplementation(5, 600));
            items.Add(new MockEntreeImplementation(5, 900));
            items.Add(new MockEntreeImplementation(5, 1200));
            items = Menu.FilterByCalories(items, null, 700).ToList<IOrderItem>();
            Assert.Collection(items,
                item => {
                    Assert.IsType<MockEntreeImplementation>(item);
                    Assert.Equal((uint?)400, item.Calories);
                },
                item => {
                    Assert.IsType<MockEntreeImplementation>(item);
                    Assert.Equal((uint?)600, item.Calories);
                }
                );
        }
        [Fact]
        public void ShouldFilterByMinimumMaximumCalories() {
            List<IOrderItem> items = new List<IOrderItem>();
            items.Add(new MockEntreeImplementation(5, 400));
            items.Add(new MockEntreeImplementation(5, 600));
            items.Add(new MockEntreeImplementation(5, 900));
            items.Add(new MockEntreeImplementation(5, 1200));
            items = Menu.FilterByCalories(items, 500, 1100).ToList<IOrderItem>();
            Assert.Collection(items,
                item => {
                    Assert.IsType<MockEntreeImplementation>(item);
                    Assert.Equal((uint?)600, item.Calories);
                },
                item => {
                    Assert.IsType<MockEntreeImplementation>(item);
                    Assert.Equal((uint?)900, item.Calories);
                }
                );
        }
        [Fact]
        public void ShouldFilterByMinimumPrice() {
            List<IOrderItem> items = new List<IOrderItem>();
            items.Add(new MockEntreeImplementation(2.15, 400));
            items.Add(new MockEntreeImplementation(94.54, 600));
            items.Add(new MockEntreeImplementation(5.45, 900));
            items.Add(new MockEntreeImplementation(12.34, 1200));
            items = Menu.FilterByPrice(items, 6, null).ToList<IOrderItem>();
            Assert.Collection(items,
                item => {
                    Assert.IsType<MockEntreeImplementation>(item);
                    Assert.Equal(94.54, item.Price);
                },
                item => {
                    Assert.IsType<MockEntreeImplementation>(item);
                    Assert.Equal(12.34, item.Price);
                }
                );
        }
        [Fact]
        public void ShouldFilterByMaximumPrice() {
            List<IOrderItem> items = new List<IOrderItem>();
            items.Add(new MockEntreeImplementation(2.15, 400));
            items.Add(new MockEntreeImplementation(94.54, 600));
            items.Add(new MockEntreeImplementation(5.45, 900));
            items.Add(new MockEntreeImplementation(12.34, 1200));
            items = Menu.FilterByPrice(items, null, 12).ToList<IOrderItem>();
            Assert.Collection(items,
                item => {
                    Assert.IsType<MockEntreeImplementation>(item);
                    Assert.Equal(2.15, item.Price);
                },
                item => {
                    Assert.IsType<MockEntreeImplementation>(item);
                    Assert.Equal(5.45, item.Price);
                }
                );
        }
        [Fact]
        public void ShouldFilterByMinimumMaximumPrice() {
            List<IOrderItem> items = new List<IOrderItem>();
            items.Add(new MockEntreeImplementation(2.15, 400));
            items.Add(new MockEntreeImplementation(94.54, 600));
            items.Add(new MockEntreeImplementation(5.45, 900));
            items.Add(new MockEntreeImplementation(12.34, 1200));
            items = Menu.FilterByPrice(items, 3, 80).ToList<IOrderItem>();
            Assert.Collection(items,
                item => {
                    Assert.IsType<MockEntreeImplementation>(item);
                    Assert.Equal(5.45, item.Price);
                },
                item => {
                    Assert.IsType<MockEntreeImplementation>(item);
                    Assert.Equal(12.34, item.Price);
                }
                );
        }
    }
}
