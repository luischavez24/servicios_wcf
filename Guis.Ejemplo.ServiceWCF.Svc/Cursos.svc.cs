using Guis.Ejemplo.ServiceWCF.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Guis.Ejemplo.ServiceWCF.Svc
{
    public class Cursos : ICursos
    {
        public List<string> GetAllCursos()
        {
            var cursos = new List<string>
            {
                "Matematica",
                "Física",
                "Química",
                "Razonamiento Matemático",
                "Historia",
                "Geografia"
            };

            return cursos;
        }
    }
}
