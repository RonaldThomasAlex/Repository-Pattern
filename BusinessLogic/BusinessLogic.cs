using BusinessLogic.Interface;
using BusinessLogic.Interface.DataAccess;
using BusinessLogic.Interface.ExternalService;

namespace BusinessLogic
{
    public class BusinessLogic : IBusinessLogic
    {
        private readonly IExternalService _externalSerice;
        private readonly IDataAccess _dataaccess;
        public BusinessLogic(IExternalService externalService, IDataAccess dataAccess)
        {
            _dataaccess = dataAccess;
            _externalSerice = externalService;
        }
        public void GetDataFromExternalService(string input1, string input2)
        {
            _externalSerice.GetDataFromExternalApi(input1, input2);
        }

        public void SaveDataToDb()
        {
            _dataaccess.SaveDataToDatabase();
        }
    }
}
