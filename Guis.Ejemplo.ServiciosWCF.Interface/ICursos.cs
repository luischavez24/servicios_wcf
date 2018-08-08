using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Guis.Ejemplo.ServiceWCF.Interface
{
    [ServiceContract]
    public interface ICursos
    {
        [OperationContract]
        [WebGet(
            BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/Cursos/GetAllCursos")]
        List<string> GetAllCursos();
    }

}
