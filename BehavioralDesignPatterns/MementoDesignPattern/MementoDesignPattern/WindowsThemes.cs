using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoDesignPattern
{
    public class WindowsThemes
    {
        public string ThemeName { get; set; }
        public MementoWindowsThemes Save()
        {
            MementoWindowsThemes memento = new MementoWindowsThemes();
            memento.ThemeName = this.ThemeName;
            return memento;
        }
        public void Undo(MementoWindowsThemes memento)
        {
            this.ThemeName = memento.ThemeName;
        }
    }
}