using Flunt.Notifications;
using Flunt.Validations;
using PaymentContext.Domain.Commands;
using PaymentContext.Domain.Repositories;
using PaymentContext.Shared.Handlers;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.Handlers
{
    public class SubscriptionHandler : Notifiable, IHandler<CreateBoletoSubscriptionCommand>
    {

        private readonly IStudentRepository _repository;

        public SubscriptionHandler(IStudentRepository repository)
        {
            _repository = repository;
        }
        public ICommandResult Handle(CreateBoletoSubscriptionCommand command)
        {
            //Verificar se documento está cadastrado
            command.Validate();
            if(command.Invalid){
                AddNotifications(command);
                return new CommandResult(false,"Não foi possível realizar sua assinatura.");
            }

            /* 
            // Verificar se Documento já está cadastrado.
            if(_repository.DocumentExists(command.Document))
                AddNotification("Document","Este CPF já está em uso");

            // Email ja cadastrado
            if(_repository.EmailExists(command.Email))
                AddNotification("Email","Este Email já está em uso");
            */

            AddNotifications(new Contract());


            return new CommandResult(true,"Assinatura realizada com sucesso");
        }
    }
}