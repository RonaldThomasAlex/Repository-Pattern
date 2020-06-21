namespace BusinessLogic.Interface
{
    public interface IBusinessLogic
    {
        /// <summary>
        /// Method that establishes connection to external service method and performs
        /// needed logic changes and return the reponses
        /// </summary>
        /// <param name="input1"></param>
        /// <param name="input2"></param>
        void GetDataFromExternalService(string input1, string input2);
        /// <summary>
        /// Method that establishes connection to DataAccess service method and performs
        /// needed logic changes and return the reponses
        /// </summary>
        void SaveDataToDb();
    }
}
