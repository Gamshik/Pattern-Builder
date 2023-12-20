using DesignPattern.Interface;

namespace DesignPattern.Directors
{
    public class BurgerDirector
    {
        private IBurgerBuilder _builder;
        public BurgerDirector(IBurgerBuilder builder)
        {
            _builder = builder;
        }
        public void ChangeBuilder(IBurgerBuilder builder) => _builder = builder;
        public void BuildSpicyBurger()
        {
            _builder.AddBuns()
                .AddCutlets()
                .AddOnionRings()
                .AddSauce()
                .AddTomatoes()
                .AddBuns();
        }
        public void BuildDefaultBurger()
        {
            _builder.AddBuns()
                .AddOnionRings()
                .AddTomatoes()
                .AddCutlets()
                .AddSauce()
                .AddBuns();
        }
    }
}
