using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService_ahorcando_devs
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        public IEnumerable<Juego> GetData()
        {
            IEnumerable<Juego> juegos;

            using (var bd = new EntitiesAhorcandoDevs())
            {
                juegos = bd.Juego.ToList();
            }

            return juegos;
        }

        public Juego Getgame(int id)
        {
            Juego juego;
            using (var bd = new EntitiesAhorcandoDevs()){
                juego = bd.Juego.Find(id);
            }
            return juego;
        }

    }
}
