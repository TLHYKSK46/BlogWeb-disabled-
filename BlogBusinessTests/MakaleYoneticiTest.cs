using BlogBusiness.Concreate;
using BlogDataAccess.Abstract;
using BlogEntities.BlogDb;
using FluentValidation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NUnit.Framework;
namespace BlogBusinessTests
{
    [TestClass]
    public class MakaleYoneticiTest
    {
        //[SetUp]
        //public void Setup()
        //{
        //}
        [ExpectedException(typeof(ValidationException))]
        [TestMethod]
        public void Makale_Validation_Test()
        {
            Mock<IMakaleDal> mock = new Mock<IMakaleDal>();

            MakaleYonetici makaleYonetici = new MakaleYonetici(mock.Object);

            makaleYonetici.Ekle(new Makale());
            //Assert.AreEqual(true,true);
        }
    }
}