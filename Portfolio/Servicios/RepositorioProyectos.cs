using Portfolio.Models;

namespace Portfolio.Servicios
{
    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyectos();
    }
    public class RepositorioProyectos: IRepositorioProyectos
    {
        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>() {
            new Proyecto
            {
                Titulo="Personal Budget Manager",
                Descripcion="Web app to track income, expenses, and optimize budget.",
                Link="",
                ImagenURL="/Imagenes/personal-budget-manager.png"
            },
            new Proyecto
            {
                Titulo="Blog App",
                Descripcion="You can create your blogs and view them all in one place.",
                Link="",
                ImagenURL="/Imagenes/blog-app.png"
            },
            new Proyecto
            {
                Titulo="Monky Brownies App",
                Descripcion="E-commerce platform focused on selling brownies. ",
                Link="",
                ImagenURL="/Imagenes/monky-app.png"
            },
            new Proyecto
            {
                Titulo="Spotilyst",
                Descripcion="Integrated with the spotify API, gives recomendations based on your preferences",
                Link="",
                ImagenURL="/Imagenes/spotilyst-app.png"
            }

            };
        }
    }
}
