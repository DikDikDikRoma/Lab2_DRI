namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("", "Rr@35RFf", "Rr@35RFf")]
        public void Login_lang_empty(string a, string b, string c)
        {
            // ���������� Arrange
            var expect = ("False", "������ ������ � �������� ������");

            // �������� Act
            var actual = Register.CheckRegister(a, b, c);


            // �������� Assert
            Assert.That(actual, Is.EqualTo(expect));
        }

        [TestCase("1234", "Rr@35RFf", "Rr@35RFf")]
        [TestCase("12345", "Rr@35RFf", "Rr@35RFf")] //���� ��������� �� ������
        public void Login_long_chislo(string a, string b, string c)
        {
            // ���������� Arrange
            var expect = ("False", "����� ������ ������ 5 ��������");

            // �������� Act
            var actual = Register.CheckRegister(a, b, c);


            // �������� Assert
            Assert.That(actual, Is.EqualTo(expect));
        }

        [TestCase("user11", "Rr@35RFf", "Rr@35RFf")]
        [TestCase("user22", "Rr@35RFf", "Rr@35RFf")]
        [TestCase("user33", "Rr@35RFf", "Rr@35RFf")]
        public void CheckExistUser(string a, string b, string c)
        {
            // ���������� Arrange
            var expect = ("False", "������������ � ����� ������� ��� ���������������");

            // �������� Act
            var actual = Register.CheckRegister(a, b, c);


            // �������� Assert
            Assert.That(actual, Is.EqualTo(expect));
        }

        [TestCase("+x-xxx-xxx-xxxx", "Rr@35RFf", "Rr@35RFf")]
        [TestCase("+11111111111", "Rr@35RFf ", "")]
        [TestCase("+0 000 000 0000", "Rr@35RFf", "Rr@35RFf")]
        public void CheckLoginContent_Phone(string a, string b, string c)
        {
            // ���������� Arrange
            var expect = ("False", "����� �������� �� ������������� ��������� ������� +x-xxx-xxx-xxxx");

            // �������� Act
            var actual = Register.CheckRegister(a, b, c);


            // �������� Assert
            Assert.That(actual, Is.EqualTo(expect));
        }

        [TestCase("@may.com", "Rr@35RFf", "Rr@35RFf")]
        [TestCase("@@@@@@@", "Rr@35RFf", "Rr@35RFf")]
        [TestCase("123@123", "Rr@35RFf", "Rr@35RFf")]//������ ���� ������
        public void CheckLoginContent_Email(string a, string b, string c)
        {
            // ���������� Arrange
            var expect = ("False", "Email �� ������������� ������ ������� xxx@xxx.xxx");

            // �������� Act
            var actual = Register.CheckRegister(a, b, c);


            // �������� Assert
            Assert.That(actual, Is.EqualTo(expect));
        }

        [TestCase("ya-www-rom2013@ya.ru", "", "Rr@35RFf")]
        public void Password_lang_empty(string a, string b, string c)
        {
            // ���������� Arrange
            var expect = ("False", "������ ������ � �������� ������");

            // �������� Act
            var actual = Register.CheckRegister(a, b, c);


            // �������� Assert
            Assert.That(actual, Is.EqualTo(expect));
        }

        [TestCase("ya-www-rom2013@ya.ru", "123456", "")]
        public void Password_long_menshe_semi(string a, string b, string c)
        {
            // ���������� Arrange
            var expect = ("False", "����� ������ ������ 7 ��������");

            // �������� Act
            var actual = Register.CheckRegister(a, b, c);


            // �������� Assert
            Assert.That(actual, Is.EqualTo(expect));
        }

        [TestCase("ya-www-rom2013@ya.ru", "123456789", "12345678")] //������ ���������, �� �� ��������
        [TestCase("ya-www-rom2013@ya.ru", "12345678", "123456789")]
        public void Password_not_same(string a, string b, string c)
        {
            // ���������� Arrange
            var expect = ("False", "�������� ������ �� ���������");

            // �������� Act
            var actual = Register.CheckRegister(a, b, c);


            // �������� Assert
            Assert.That(actual, Is.EqualTo(expect));
        }

        [TestCase("ya-www-rom2013@ya.ru", "qwertyyy", "qwertyyy")] //������ ���������, �� �� ��������
        public void Password_havnt_A(string a, string b, string c)
        {
            // ���������� Arrange
            var expect = ("False", "� ������ ����������� ������� ���� ��������� �����");

            // �������� Act
            var actual = Register.CheckRegister(a, b, c);


            // �������� Assert
            Assert.That(actual, Is.EqualTo(expect));
        }

        [TestCase("ya-www-rom2013@ya.ru", "QWERTYYY", "QWERTYYY")] //������ ���������, �� �� ��������
        public void Password_havnt_a(string a, string b, string c)
        {
            // ���������� Arrange
            var expect = ("False", "� ������ ����������� ������� ���� �������� �����");

            // �������� Act
            var actual = Register.CheckRegister(a, b, c);


            // �������� Assert
            Assert.That(actual, Is.EqualTo(expect));
        }

        [TestCase("ya-www-rom2013@ya.ru", "AAAAAaaaa", "AAAAAaaaa")] //������ ���������, �� �� ��������
        public void Password_havnt_number(string a, string b, string c)
        {
            // ���������� Arrange
            var expect = ("False", "� ������ ����������� ������� ���� �����");

            // �������� Act
            var actual = Register.CheckRegister(a, b, c);


            // �������� Assert
            Assert.That(actual, Is.EqualTo(expect));
        }

        [TestCase("ya-www-rom2013@ya.ru", "AAAaa123", "AAAaa123")] //������ ���������, �� �� ��������
        public void Password_havnt_spez(string a, string b, string c)
        {
            // ���������� Arrange
            var expect = ("False", "� ������ ����������� ������� ���� ����������� ������");

            // �������� Act
            var actual = Register.CheckRegister(a, b, c);


            // �������� Assert
            Assert.That(actual, Is.EqualTo(expect));
        }

        [TestCase("ya-www-rom2013@ya.ru", "Rr@35RFf", "Rr@35RFf")] //������ ���������, �� �� ��������
        public void All_Right(string a, string b, string c)
        {
            // ���������� Arrange
            var expect = ("True", "");

            // �������� Act
            var actual = Register.CheckRegister(a, b, c);


            // �������� Assert
            Assert.That(actual, Is.EqualTo(expect));
        }
    }
}