using AquaControl.BLL.Services;
using AquaControl.Common.Models;

Client client = new Client
{
    Id = 1,
    FullName = "Иванов Иван",
    Phone = "+7 999 123 45 67",
    Email = "ivanov@mail.ru"
};

ClientService clientService = new ClientService();

Console.WriteLine(clientService.RegisterClient(client)); 