using DesignPattern.Builders;
using DesignPattern.Directors;

var spicyBurgerBuilder = new SpicyBurgerBuilder();
var defaultBurgerBuilder = new DefaultBurgerBuilder();

var burgerDirector = new BurgerDirector(spicyBurgerBuilder);

// Build spici burger
burgerDirector.BuildSpicyBurger();

var spicyBurger = spicyBurgerBuilder.GetBurger();
Console.WriteLine("Spicy " + spicyBurger);

// Сhanging the builder to build a default burger
burgerDirector.ChangeBuilder(defaultBurgerBuilder);

// Build default burger
burgerDirector.BuildDefaultBurger();

var defaultBurger = defaultBurgerBuilder.GetBurger();
Console.WriteLine("Default " + defaultBurger);


//----------------------------------------------------------------------------


// If done without a director, the code would be like this

//var spicyBurgerBuilder = new SpicyBurgerBuilder();
//var defaultBurgerBuilder = new DefaultBurgerBuilder();

//spicyBurgerBuilder.AddBuns()
//                .AddCutlets()
//                .AddOnionRings()
//                .AddSauce()
//                .AddTomatoes()
//                .AddBuns();

//var spicyBurger = spicyBurgerBuilder.GetBurger();
//Console.WriteLine("Spicy " + spicyBurger);

//defaultBurgerBuilder.AddBuns()
//                .AddOnionRings()
//                .AddTomatoes()
//                .AddCutlets()
//                .AddSauce()
//                .AddBuns();

//var defaultBurger = defaultBurgerBuilder.GetBurger();
//Console.WriteLine("Default " + defaultBurger);