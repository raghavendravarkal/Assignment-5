using System.Data;
using System.ServiceModel;

namespace StudentInfoService
{
    [ServiceContract]
    public interface IStudentInfoService
    {

        [OperationContract]
        string GetStudentInfoByID(int studentID);
    }
}
