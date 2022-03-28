using AutomobileLibrary.BussinessObject;
using AutomobileLibrary.DataAccess;
using System.Collections.Generic;

namespace AutomobileLibrary.Reponsitory
{
    public class CarRepository : ICarRepository
    {
        public Car GetCarByID(int carID) => CarDBContext.Instance.GetCarByID(carID);

        public IEnumerable<Car> GetCars() => CarDBContext.Instance.GetCarList();

        public void InsertCar(Car car) => CarDBContext.Instance.AddNew(car);

        public void DeleteCar(int carID) => CarDBContext.Instance.Remove(carID);

        public void UpdateCar(Car car) => CarDBContext.Instance.Update(car);
    }
}
