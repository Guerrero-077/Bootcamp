using Business.Interfases;
using Data.Interfases;
using Entity.Models.Base;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Implementations.Base
{
    public class BaseBusiness<T, D> : IBaseBusiness<T, D> where T : BaseModel where D : BaseModel
    {
        public readonly IBaseData<T> _data;

        public BaseBusiness(IBaseData<T> data)
        {
            _data = data;
        }

        public async Task<int?> Delete(int id)
        {
            try
            {
                return await _data.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar.", ex);
            }

        }

        public async Task<IEnumerable<D>> GetAll()
        {
            try
            {
                var lista = await _data.GetAll();
                return lista.Adapt<IEnumerable<D>>();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar todos los registros",ex);
            }
        }

        public async Task<D> GetById(int id)
        {
            try
            {
                var entity = await _data.GetById(id);
                return entity.Adapt<D>();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el registro con Id: {id}", ex);
            }
        }

        public async Task<D> Save(D entity)
        {
            try
            {
                var entityNew = entity.Adapt<T>();
                await _data.Save(entityNew);
                return entityNew.Adapt<D>();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar el registro ", ex);
            }
        }

        public async Task<D> Update(D entity)
        {
            var id = entity.Id;
            if(id <= 0) throw new Exception("Id inválido para actualizar");

            try
            {
                var entityUpdate = entity.Adapt<T>();
                await _data.Update(entityUpdate);
                return entityUpdate.Adapt<D>();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el reistro con id {id}", ex);
            }
        }
    }
}
