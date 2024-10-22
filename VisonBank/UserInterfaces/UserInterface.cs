using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisonBank.UserInterfaces
{
    internal abstract class UserInterface 
    {
        public static Dictionary<int, UserInterface> Interfaces = new Dictionary<int, UserInterface>();
        public string Title { get; set; }
        protected string line = new string('-', 100);
        protected string textPattern = "{0, -20} {1, 20}";

        public UserInterface(string title)
        {
            this.Title = title;
            Interfaces.Add(Interfaces.Count, this);
        }

        public abstract void Interface();
        public virtual void Redirect(char a) { Console.WriteLine("Redirect não configurado"); }
        public virtual void Redirect(UserInterface inter) { Console.WriteLine("Redirect não configurado"); }
        public static void ReturToTheBeginning()
        {
            Interfaces[1].Interface();
        }
    }
}
