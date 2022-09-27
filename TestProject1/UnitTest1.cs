using UserRegistrationLambdaExpression;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidateFirstName_ReturnTrue()
        {
            string FirstName = "Lokesh";
            Patterns pattern = new Patterns();
            bool result = pattern.IsValidFirstName(FirstName);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void ValidateLastName_ReturnTrue()
        {
            string LastName = "Kiran";
            Patterns pattern = new Patterns();
            bool result = pattern.IsValidLastName(LastName);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void ValidateEmail_ReturnTrue()
        {
            string Email = "lokesh@gmail.com";
            Patterns pattern = new Patterns();
            bool result = pattern.IsValidEmail(Email);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void ValidatePhoneNo_ReturnTrue()
        {
            string Phone = "91 9775648945";
            Patterns pattern = new Patterns();
            bool result = pattern.IsValidPhoneNo(Phone);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void ValidatePassword_ReturnTrue()
        {
            string Password = "Lokesh@2012";
            Patterns pattern = new Patterns();
            bool result = pattern.IsValidPasswordRule(Password);
            Assert.IsTrue(result);
        }
    }
}