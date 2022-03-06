

using Portafolio.Models;

namespace Portafolio.Servicios
{
    public interface IRepositorioProyectos
    {
        List<ProyectoDTO> ObtenerProyectos();
    }
    public class RepositorioProyectos: IRepositorioProyectos
    {
        
        public List<ProyectoDTO> ObtenerProyectos()
        {
            return new List<ProyectoDTO>() {
                new ProyectoDTO
            {
                Titulo = "Google",
                Descripcion = "L - comerce realizado en asp . Net core",
                Link = "http://google.com",
                ImagenURL = "/imagenes/Logo google.png"


            },
                 new ProyectoDTO
            {
                Titulo = "El colombiano",
                Descripcion = "Pagina de noticias",
                Link = "http://elcolombiano.com",
                ImagenURL = "/imagenes/El colombiano.jpg"


            },
                  new ProyectoDTO
            {
                Titulo = "Facebook",
                Descripcion = "red social mas conocida del mundo",
                Link = "http://facebook.com",
                ImagenURL = "/imagenes/Facebook.png"


            },
                   new ProyectoDTO
            {
                Titulo = "Amazon",
                Descripcion = "Pagina de compra online",
                Link = "https://www.amazon.com",
                ImagenURL = "/imagenes/Amazon.png"


            },
            };

        }
    }
}
