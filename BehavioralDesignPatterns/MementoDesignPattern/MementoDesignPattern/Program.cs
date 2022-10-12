using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WindowsThemes theme = new WindowsThemes();
            CareTakerWindowsThemes careTaker = new
           CareTakerWindowsThemes();
            theme.ThemeName = "Rainly Day";
            careTaker.Theme = theme.Save();
            Console.WriteLine(theme.ThemeName);
            theme.ThemeName = "Windows Classic";
            Console.WriteLine(theme.ThemeName);
            theme.Undo(careTaker.Theme);
            Console.WriteLine(theme.ThemeName);
            Console.ReadLine();
        }
    }
}
