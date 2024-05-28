using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInvesntario.AccesoDatos.Repositorio.IRepositorio
{
    public interface IUnidedadTrabajo : IDisposable
    {
        IBodegaRepositorio Bodega { get; }

        Task Guardar();


    }
}
