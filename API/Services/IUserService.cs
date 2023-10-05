// aqui se definen dos metodos que estan relacionados con la autenticacion 
using API.Dtos;
using Dominio.Entities;

namespace API.Services;
    public interface IUserService{

        byte[] CreateQR(ref Usuario usuario); //se utiliza para crear un código QR
        bool VerifyCode(string secret, string code); //se utiliza para verificar un código QR
        
    }

//byte: representa el código QR en bytes
//ref: se utiliza para pasar un argumento por referencia a un método


// la configuracion se encuentra en "UserService" que implementara la interfaz IserService y la utilizaremos para proporcionar funcionalidades con la autenticacion de dos factores