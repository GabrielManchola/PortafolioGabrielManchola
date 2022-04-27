

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
                Titulo = "Manejo Presupuestos",
                Descripcion = "Proyecto de manejo de presupuestos con .Net core",
                Link = "https://manejopresupuesto20220426205629.azurewebsites.net",
                ImagenURL = "/imagenes/net-1.png"


            },
                
                
            };

        }
    }
}
