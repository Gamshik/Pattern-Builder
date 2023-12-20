using DesignPattern.Interface;
using DesignPattern.Models;

namespace DesignPattern.Builders
{
    public class DefaultBurgerBuilder : IBurgerBuilder
    {
        private Burger _burger;
        public DefaultBurgerBuilder()
        {
            _burger = new Burger();
        }
        public IBurgerBuilder AddBuns()
        {
            _burger.Buns = "Default buns";
            return this;
        }
        public IBurgerBuilder AddSauce()
        {
            _burger.Sauce = "Ketchup and mayonnaise";
            return this;
        }
        public IBurgerBuilder AddCutlets()
        {
            _burger.Cutlets = "Crab cutlets";
            return this;
        }
        public IBurgerBuilder AddOnionRings()
        {
            _burger.OnionRings = "Default onion rings";
            return this;
        }
        public IBurgerBuilder AddTomatoes()
        {
            _burger.Tomatoes = "Pink tomatoes";
            return this;
        }
        public Burger GetBurger()
        {
            Burger burger = _burger;

            _burger = new();

            return burger;
        }
    }
}
