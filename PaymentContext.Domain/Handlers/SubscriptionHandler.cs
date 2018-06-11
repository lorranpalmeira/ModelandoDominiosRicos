using System;
using Flunt.Notifications;
using Flunt.Validations;
using PaymentContext.Domain.Commands;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.Repositories;
using PaymentContext.Domain.ValueObjects;
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

            // Gerrar os VOs

            var name =  new Name(command.FirstName,command.LastName);
            var document = new Document(command.Document,EDocumentType.CPF);;
            var address = new Address(command.Street,command.Number,command.Neighborhood, command.City,command.State,command.Country,command.ZipCode);
            var email = new Email(command.Email);

            var student = new Student(name,document,email);
            var subscription =  new Subscription(DateTime.Now.AddMonths(1));
            var payment = new BoletoPayment();

            //AddNotifications(new Contract());


            return new CommandResult(true,"Assinatura realizada com sucesso");
        }
    }
}