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
    }
}
