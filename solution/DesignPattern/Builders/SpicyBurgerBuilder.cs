using DesignPattern.Interface;
using DesignPattern.Models;

namespace DesignPattern.Builders
{
    public class SpicyBurgerBuilder : IBurgerBuilder
    {
        private Burger _burger;
        public SpicyBurgerBuilder()
        {
            _burger = new Burger();
        }
        public IBurgerBuilder AddBuns()
        {
            _burger.Buns = "Sesame buns";
            return this;
        }
        public IBurgerBuilder AddSauce()
        {
            _burger.Sauce = "Ketchup";
            return this;
        }
        public IBurgerBuilder AddCutlets()
        {
            _burger.Cutlets = "Kiev-style cutlets";
            return this;
        }
        public IBurgerBuilder AddOnionRings()
        {
            _burger.OnionRings = "Spicy onion rings";
            return this;
        }
        public IBurgerBuilder AddTomatoes()
        {
            _burger.Tomatoes = "Red tomatoes";
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
