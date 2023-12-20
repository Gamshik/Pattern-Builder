using DesignPattern.Models;

namespace DesignPattern.Interface
{
    public interface IBurgerBuilder
    {
        IBurgerBuilder AddBuns();
        IBurgerBuilder AddSauce();
        IBurgerBuilder AddCutlets();
        IBurgerBuilder AddOnionRings();
        IBurgerBuilder AddTomatoes();
        Burger GetBurger();
    }
}
