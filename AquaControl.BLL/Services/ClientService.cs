using AquaControl.Common.Models;

namespace AquaControl.BLL.Services
{
    public class ClientService
    {
        public string RegisterClient(Client client)
        {
            return $"Клиент {client.FullName} успешно зарегистрирован в системе AquaControl";
        }
    }
}