namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("", "", "")]
        public void Login_long_null(string a, string b, string c)
        {
            // ���������� Arrange
            var expect = ("False", "������ ������ � �������� ������");

            // �������� Act
            var actual = Register.CheckRegister(a, b, c);


            // �������� Assert
            Assert.That(actual, Is.EqualTo(expect));
        }

        [TestCase("1234", "", "")]
        [TestCase("12345", "", "")] //���� ��������� �� ������
        public void Login_long_chislo(string a, string b, string c)
        {
            // ���������� Arrange
            var expect = ("False", "����� ������ ������ 5 ��������");

            // �������� Act
            var actual = Register.CheckRegister(a, b, c);


            // �������� Assert
            Assert.That(actual, Is.EqualTo(expect));
        }

        [TestCase("user11", "", "")]
        [TestCase("user22", "", "")]
        [TestCase("user33", "", "")]
        public void CheckExistUser(string a, string b, string c)
        {
            // ���������� Arrange
            var expect = ("False", "������������ � ����� ������� ��� ���������������");

            // �������� Act
            var actual = Register.CheckRegister(a, b, c);


            // �������� Assert
            Assert.That(actual, Is.EqualTo(expect));
        }

        [TestCase("+x-xxx-xxx-xxxx", "", "")]
        [TestCase("+11111111111", "", "")]
        [TestCase("+0 000 000 0000", "", "")]
        public void CheckLoginContent_Phone(string a, string b, string c)
        {
            // ���������� Arrange
            var expect = ("False", "����� �������� �� ������������� ��������� ������� +x-xxx-xxx-xxxx");

            // �������� Act
            var actual = Register.CheckRegister(a, b, c);


            // �������� Assert
            Assert.That(actual, Is.EqualTo(expect));
        }

        [TestCase("@may.com", "", "")]
        [TestCase("@@@@@@@", "", "")]
        [TestCase("123@123", "", "")]//������ ���� ������
        public void CheckLoginContent_Email(string a, string b, string c)
        {
            // ���������� Arrange
            var expect = ("False", "Email �� ������������� ������ ������� xxx@xxx.xxx");

            // �������� Act
            var actual = Register.CheckRegister(a, b, c);


            // �������� Assert
            Assert.That(actual, Is.EqualTo(expect));
        }

        [TestCase("ya-www-rom2013@ya.ru", "", "")]
        public void Password_long_null(string a, string b, string c)
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