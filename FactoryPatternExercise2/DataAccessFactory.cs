using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise2
{
    public static class DataAccessFactory
    {
        public static IDataAccess GetDataAccess(string DataType)
        {
            
            
            
            if (DataType.ToLower() == "list")
            {
                var NewListDataAccess = new ListDataAccess();
                return NewListDataAccess;
            }
            else if (DataType.ToLower() == "sql")
            {
                var NewSQLDataAccess = new SQLDataAccess();
                return NewSQLDataAccess;
            }
            else if (DataType.ToLower() == "mongo")
            {
                var NewMongoDataAccess = new MongoDataAccess();
                return NewMongoDataAccess;
            }
            
                return null;
            
        }
    }


}
