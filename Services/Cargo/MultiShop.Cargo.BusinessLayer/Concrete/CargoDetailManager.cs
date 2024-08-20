using MultiShop.Cargo.BusinessLayer.Abstract;
using MultiShop.Cargo.DataAccessLayer.Abstract;
using MultiShop.Cargo.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Cargo.BusinessLayer.Concrete
{
	public class CargoDetailManager : ICargoDetailService
	{
		private readonly ICargoDetailDal _cargoDetailDal;

		public CargoDetailManager(ICargoDetailDal cargoDetailDal)
		{
			_cargoDetailDal = cargoDetailDal;
		}

		public void Delete(int id)
		{
			_cargoDetailDal.Delete(id);
		}

		public List<CargoDetail> GetAll()
		{
			return _cargoDetailDal.GetAll();
		}

		public CargoDetail GetById(int id)
		{
			return _cargoDetailDal.GetById(id);
		}

		public void Insert(CargoDetail entity)
		{
			_cargoDetailDal.Insert(entity);
		}

		public void Update(CargoDetail entity)
		{
			_cargoDetailDal.Update(entity);
		}
	}
}
