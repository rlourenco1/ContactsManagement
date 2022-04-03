using AutoMapper;
using Contacts.Core.Interfaces.Repositories;
using Contacts.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Core.Services
{
    public abstract class BaseService<TViewModel, TEntity> : IBaseService<TViewModel, TEntity>
    where TEntity : class where TViewModel : class
    {
        private readonly IBaseRepository<TEntity> _repository;
        private readonly IMapper _mapper;

        public BaseService(
            IBaseRepository<TEntity> repository,
            IMapper mapper) 
        {
            this._repository = repository;
            this._mapper = mapper;
        }

        public TViewModel Create(TViewModel viewModel)
        {
            try
            {
                var model = _mapper.Map<TEntity>(viewModel);

                this._repository.Create(model);

                this._repository.SaveChanges();

                return _mapper.Map<TViewModel>(model);
            }
            catch (Exception ex)
            {

            }

            return null;
        }

        public TViewModel Update(TViewModel viewModel)
        {
            try
            {
                var model = _mapper.Map<TEntity>(viewModel);

                this._repository.Update(model);

                this._repository.SaveChanges();

                return viewModel;
            }
            catch (Exception ex)
            {

            }

            return null;
        }

        public void Delete(TViewModel viewModel)
        {
            try
            {
                var model = _mapper.Map<TEntity>(viewModel);

                this._repository.Delete(model);

                this._repository.SaveChanges();
            }
            catch (Exception ex)
            {

            }
        }

        public void DeleteById(int id)
        {
            try
            {
                var model = this._repository.GetById(id);

                this._repository.Delete(model);

                this._repository.SaveChanges();
            }
            catch (Exception ex)
            {

            }
        }

        public TViewModel GetById(int id)
        {
            try
            {
                var model = this._repository.GetById(id);

                return _mapper.Map<TViewModel>(model);
            }
            catch (Exception ex)
            {

            }

            return null;
        }

        public IEnumerable<TViewModel> GetAll()
        {
            try
            {
                return _mapper.Map<IEnumerable<TViewModel>>(this._repository.GetAll());
            }
            catch (Exception ex)
            {

            }

            return null;
        }
    }
}
