using Day24;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void UseCase1()
        {
            try
            {
                string name = "Dhanashri";
                bool expected = true;
                demo program = new demo();
                bool actual = program.validname(name);
                Assert.AreEqual(expected, actual);
            }
            catch (InvalidCastException ex)
            {
                Assert.AreEqual("invalid first name", ex.Message);
            }
        }

        [TestMethod]
        public void UseCase2()
        {
            try
            {
                string lastname = "KrishnaRa";
                bool expected = true;
                demo program = new demo();
                bool actual = program.validlname(lastname);
                Assert.AreEqual(expected, actual);
            }
            catch (InvalidCastException ex)
            {
                Assert.AreEqual("invalid Last name", ex.Message);
            }
        }

        [TestMethod]
        public void UseCase3()
        {
            try
            {
                string[] emails = new string[3] { "abc.xyz@bl.co.in", "b689@bl.co.in", "xhh56@bl.co" };

                for (int i = 0; i < 3; i++)
                {

                    bool expected = true;
                    demo program = new demo();
                    bool actual = program.validmail(emails[i]);
                    Assert.AreEqual(expected, actual);
                }
            }
            catch (InvalidCastException ex)
            {
                Assert.AreEqual("invalid Email", ex.Message);
            }
        }

        [TestMethod]
        public void UseCase4()
        {
            try
            {
                string mb = "91 9465962366";
                bool expected = true;
                demo program = new demo();
                bool actual = program.validmobile(mb);
                Assert.AreEqual(expected, actual);
            }
            catch (InvalidCastException ex)
            {
                Assert.AreEqual("invalid Mobile Number", ex.Message);
            }
        }
        [TestMethod]
        public void UseCase5()
        {
            try
            {
                string password = "Godzilla";
                bool expected = true;
                demo program = new demo();
                bool actual = program.validpwd1(password);
                Assert.AreEqual(expected, actual);
            }
            catch (InvalidCastException ex)
            {
                Assert.AreEqual("invalid Password", ex.Message);
            }
        }

        [TestMethod]
        public void UseCase6()
        {
            try
            {
                string password = "Preranaaa";
                bool expected = true;
                demo program = new demo();
                bool actual = program.validpwd2(password);
                Assert.AreEqual(expected, actual);
            }
            catch (InvalidCastException ex)
            {
                Assert.AreEqual("invalid Password", ex.Message);
            }
        }

        [TestMethod]
        public void UseCase7()
        {
            try
            {
                string password = "Prerana5";
                bool expected = true;
                demo program = new demo();
                bool actual = program.validpwd3(password);
                Assert.AreEqual(expected, actual);
            }
            catch (InvalidCastException ex)
            {
                Assert.AreEqual("invalid Password", ex.Message);
            }
        }

        [TestMethod]
        public void UseCase8()
        {
            try
            {
                string password = "Krishna#2";
                bool expected = true;
                demo program = new demo();
                bool actual = program.validpwd(password);
                Assert.AreEqual(expected, actual);
            }
            catch (InvalidCastException ex)
            {
                Assert.AreEqual("invalid Password", ex.Message);
            }
        }

        [TestMethod]
        public void UseCase9()
        {
            try
            {
                string email1 = "abc.xyz@gmail.com";
                bool expected = true;
                demo program = new demo();
                bool actual = program.validmail(email1);
                Assert.AreEqual(expected, actual);
            }
            catch (InvalidCastException ex)
            {
                Assert.AreEqual("invalid Password", ex.Message);
            }
        }
    }
}
