using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests.ValueObjects
{
    [TestClass]
    public class DocumentTests
    {

        [TestMethod]
        public void ShouldReturnErrorWhenCNPJIsInvalid(){

            var doc = new Document("123",EDocumentType.CNPJ);
            Assert.IsTrue(doc.Invalid);
        }
        
        [TestMethod]
        public void ShouldReturnSucessWhenCNPJIsValid(){

            var doc = new Document("12345678912345",EDocumentType.CNPJ);
            Assert.IsTrue(doc.Valid);
        }

                [TestMethod]
        public void ShouldReturnErrorWhenCPFIsInvalid(){

            var doc = new Document("123",EDocumentType.CPF);
            Assert.IsTrue(doc.Invalid);
        }
        
        [TestMethod]
        public void ShouldReturnSucessWhenCPFIsValid(){

            var doc = new Document("12345678911",EDocumentType.CPF);
            Assert.IsTrue(doc.Valid);
        }
    }
}