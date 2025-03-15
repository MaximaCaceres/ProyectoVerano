using WebApplication1.DAOs.MSSDAOs;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    //Recibe los datos del modelo (ALUMNO), aplica la lógica de negocio y puede
    //interactuar con el AlumnoDAO para persistir los cambios.
    public class AlumnoService
    {
        readonly private AlumnoMSSDAO _AlumnoDao;

        public AlumnoService(AlumnoMSSDAO AlumnoDao)//intectamos dependencias.
        {
            _AlumnoDao = AlumnoDao;
        }

        async public Task<List<Alumno>> GettAll()
        {
            return await _AlumnoDao.GetAll();
        }

        async public Task<Alumno?> GetById(int id)
        {
            return await _AlumnoDao.GetByKey(id);
        }

        async public Task CrearNuevo(Alumno objeto)
        {
            await _AlumnoDao.Insert(objeto);
        }

        async public Task Actualizar(Alumno objeto)
        {
            await _AlumnoDao.Update(objeto);
        }

        public async Task<bool> Eliminar(int LU)
        {
            return await _AlumnoDao.Delete(LU);
        }
    }
}
