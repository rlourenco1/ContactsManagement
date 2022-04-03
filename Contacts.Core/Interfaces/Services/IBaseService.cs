using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Core.Interfaces.Services
{
    public interface IBaseService<TViewModel, TEntity> where TEntity : class where TViewModel : class
    {
        TViewModel Create(TViewModel viewModel);
        TViewModel Update(TViewModel viewModel);
        void Delete(TViewModel viewModel);
        TViewModel GetById(int id);
        void DeleteById(int id);

        IEnumerable<TViewModel> GetAll();
    }
}
