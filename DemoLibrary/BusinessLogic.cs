using DemoLibrary.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class BusinessLogic : IBusinessLogic
    {
        // variables de clase privadas
        IDataAccess _dataAccess;
        ILogger _logger;

        public BusinessLogic (ILogger logger,IDataAccess dataAccess) //constructor inyection
        {
            _logger = logger;
            _dataAccess = dataAccess;
        }

        public void ProcessData()
        {
           // Logger logger = new Logger();
           // DataAccess dataAccess = new DataAccess();

            _logger.Log("Starting the processing of data.");
            Console.WriteLine("Processing the data");
            _dataAccess.LoadData();
            _dataAccess.SaveData("ProcessedInfo");
            _logger.Log("Finished processing of the data.");
        }
    }
}
