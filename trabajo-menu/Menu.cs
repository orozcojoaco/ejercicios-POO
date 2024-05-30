using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer2
{
    class Menu
    {
        public string[] items;
        public string nombreMenu;
        public int posMenu;

        public Menu(int posMenu, string nombreMenu, string[] opciones)
        {
            this.items = opciones;
            this.nombreMenu = nombreMenu;
            this.posMenu = posMenu;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] menu1 = { "Nuevo ", "Abrir", "Clonar Repositorio" };
            string[] menu2 = { "Ir a", "Buscar y Reemplazar", "Ir a base" };
            string[] menu3 = { "Codigo", "Abrir", "Abrir con" };

            var menus = new Dictionary<string, string[]>
            {
                { "Archivo", menu1 }, { "Editar", menu2 }, { "Ver", menu3}
            };

            MenuPrincipal menu = new MenuPrincipal(menus);
            menu.Navegar();
        }
    }
}