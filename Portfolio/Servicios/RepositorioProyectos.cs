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
                Titulo="Amazon",
                Descripcion="Ecommerce desarrollado en ASP.NET",
                Link="https://amazon.com",
                ImagenURL="/Imagenes/AmazonImg.png"
            },
            new Proyecto
            {
                Titulo="Facebook",
                Descripcion="Red Social desarrollado en PHP",
                Link="https://facebook.com",
                ImagenURL="/Imagenes/FacebookImg.png"
            },
            new Proyecto
            {
                Titulo="Youtube",
                Descripcion="Plataforma digital para ver videos online",
                Link="https://youtube.com",
                ImagenURL="/Imagenes/YoutubeImg.png"
            },
            new Proyecto
            {
                Titulo="Steam",
                Descripcion="Tienda en linea para comprar videojuegos",
                Link="https://store.steampowered.com",
                ImagenURL="/Imagenes/SteamImg.png"
            }

            };
        }
    }
}
