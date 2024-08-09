using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class MessageCategoryManager : IMessageCategoryService
    {
        private readonly ImessageCategoryDal _ımessageCategoryDal;

        public MessageCategoryManager(ImessageCategoryDal ımessageCategoryDal)
        {
            _ımessageCategoryDal = ımessageCategoryDal;
        }

        public void TDelete(MessageCategory t)
        {
            _ımessageCategoryDal.Delete(t);
        }

        public MessageCategory TGetById(int id)
        {
           return _ımessageCategoryDal.GetById(id);
        }

        public List<MessageCategory> TGetList()
        {
            return _ımessageCategoryDal.GetList();
        }

        public void TInsert(MessageCategory t)
        {
            _ımessageCategoryDal.Insert(t);
        }

        public void TUpdate(MessageCategory t)
        {
           _ımessageCategoryDal.Update(t);
        }
    }
}
