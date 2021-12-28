using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService_ahorcando_devs
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        // listar preguntas del juego
        IEnumerable<Juego> GetData();

        [OperationContract]
        // obtener pregunta
        Juego Getgame(int id);

        [OperationContract]
        // validar palabra
        bool IsCorrect(string palabra);

        [OperationContract]
        // listar personajes
        IEnumerable<Personajes> GetPersonajes();

        [OperationContract]
        // listar Ranking
        IEnumerable<Ranking> GetRanking();


        [OperationContract]
        void SetDataRanking(ContracRanking ranking);

    }
}
