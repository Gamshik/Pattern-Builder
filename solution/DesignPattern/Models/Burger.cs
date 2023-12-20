using System.Text;

namespace DesignPattern.Models
{
    public class Burger
    {
        public string Buns { get; set; }
        public string Sauce { get; set; }
        public string Cutlets { get; set; }
        public string OnionRings { get; set; }
        public string Tomatoes { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder("Burger:\n");
            sb.Append(Buns + "\n" + Sauce + "\n" + Cutlets + "\n" + OnionRings + "\n" + Tomatoes + "\n");
            return sb.ToString();
        }
    }
}
