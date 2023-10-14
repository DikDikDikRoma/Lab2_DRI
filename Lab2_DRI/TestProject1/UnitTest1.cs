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
            // Подготовка Arrange
            var expect = ("False", "Пустая строка в качестве логина");

            // Действие Act
            var actual = Register.CheckRegister(a, b, c);


            // Проверка Assert
            Assert.That(actual, Is.EqualTo(expect));
        }

        [TestCase("1234", "Rr@35RFf", "Rr@35RFf")]
        [TestCase("12345", "Rr@35RFf", "Rr@35RFf")] //тест проходить не должен
        public void Login_long_chislo(string a, string b, string c)
        {
            // Подготовка Arrange
            var expect = ("False", "Длина логина меньше 5 символов");

            // Действие Act
            var actual = Register.CheckRegister(a, b, c);


            // Проверка Assert
            Assert.That(actual, Is.EqualTo(expect));
        }

        [TestCase("user11", "Rr@35RFf", "Rr@35RFf")]
        [TestCase("user22", "Rr@35RFf", "Rr@35RFf")]
        [TestCase("user33", "Rr@35RFf", "Rr@35RFf")]
        public void CheckExistUser(string a, string b, string c)
        {
            // Подготовка Arrange
            var expect = ("False", "Пользователь с таким логином уже зарегистрирован");

            // Действие Act
            var actual = Register.CheckRegister(a, b, c);


            // Проверка Assert
            Assert.That(actual, Is.EqualTo(expect));
        }

        [TestCase("+x-xxx-xxx-xxxx", "Rr@35RFf", "Rr@35RFf")]
        [TestCase("+11111111111", "Rr@35RFf ", "")]
        [TestCase("+0 000 000 0000", "Rr@35RFf", "Rr@35RFf")]
        public void CheckLoginContent_Phone(string a, string b, string c)
        {
            // Подготовка Arrange
            var expect = ("False", "Номер телефона не удовлетворяет заданному формату +x-xxx-xxx-xxxx");

            // Действие Act
            var actual = Register.CheckRegister(a, b, c);


            // Проверка Assert
            Assert.That(actual, Is.EqualTo(expect));
        }

        [TestCase("@may.com", "Rr@35RFf", "Rr@35RFf")]
        [TestCase("@@@@@@@", "Rr@35RFf", "Rr@35RFf")]
        [TestCase("123@123", "Rr@35RFf", "Rr@35RFf")]//должен быть верным
        public void CheckLoginContent_Email(string a, string b, string c)
        {
            // Подготовка Arrange
            var expect = ("False", "Email не удовлетворяет общему формату xxx@xxx.xxx");

            // Действие Act
            var actual = Register.CheckRegister(a, b, c);


            // Проверка Assert
            Assert.That(actual, Is.EqualTo(expect));
        }

        [TestCase("ya-www-rom2013@ya.ru", "", "Rr@35RFf")]
        public void Password_lang_empty(string a, string b, string c)
        {
            // Подготовка Arrange
            var expect = ("False", "Пустая строка в качестве пароля");

            // Действие Act
            var actual = Register.CheckRegister(a, b, c);


            // Проверка Assert
            Assert.That(actual, Is.EqualTo(expect));
        }

        [TestCase("ya-www-rom2013@ya.ru", "123456", "")]
        public void Password_long_menshe_semi(string a, string b, string c)
        {
            // Подготовка Arrange
            var expect = ("False", "Длина пароля меньше 7 символов");

            // Действие Act
            var actual = Register.CheckRegister(a, b, c);


            // Проверка Assert
            Assert.That(actual, Is.EqualTo(expect));
        }

        [TestCase("ya-www-rom2013@ya.ru", "123456789", "12345678")] //должно проходить, но не проходит
        [TestCase("ya-www-rom2013@ya.ru", "12345678", "123456789")]
        public void Password_not_same(string a, string b, string c)
        {
            // Подготовка Arrange
            var expect = ("False", "Заданные пароли не совпадают");

            // Действие Act
            var actual = Register.CheckRegister(a, b, c);


            // Проверка Assert
            Assert.That(actual, Is.EqualTo(expect));
        }

        [TestCase("ya-www-rom2013@ya.ru", "qwertyyy", "qwertyyy")] //должно проходить, но не проходит
        public void Password_havnt_A(string a, string b, string c)
        {
            // Подготовка Arrange
            var expect = ("False", "В пароле отсутствует минимум одна заглавная буква");

            // Действие Act
            var actual = Register.CheckRegister(a, b, c);


            // Проверка Assert
            Assert.That(actual, Is.EqualTo(expect));
        }

        [TestCase("ya-www-rom2013@ya.ru", "QWERTYYY", "QWERTYYY")] //должно проходить, но не проходит
        public void Password_havnt_a(string a, string b, string c)
        {
            // Подготовка Arrange
            var expect = ("False", "В пароле отсутствует минимум одна строчная буква");

            // Действие Act
            var actual = Register.CheckRegister(a, b, c);


            // Проверка Assert
            Assert.That(actual, Is.EqualTo(expect));
        }

        [TestCase("ya-www-rom2013@ya.ru", "AAAAAaaaa", "AAAAAaaaa")] //должно проходить, но не проходит
        public void Password_havnt_number(string a, string b, string c)
        {
            // Подготовка Arrange
            var expect = ("False", "В пароле отсутствует минимум одна цифра");

            // Действие Act
            var actual = Register.CheckRegister(a, b, c);


            // Проверка Assert
            Assert.That(actual, Is.EqualTo(expect));
        }

        [TestCase("ya-www-rom2013@ya.ru", "AAAaa123", "AAAaa123")] //должно проходить, но не проходит
        public void Password_havnt_spez(string a, string b, string c)
        {
            // Подготовка Arrange
            var expect = ("False", "В пароле отсутствует минимум один специальный символ");

            // Действие Act
            var actual = Register.CheckRegister(a, b, c);


            // Проверка Assert
            Assert.That(actual, Is.EqualTo(expect));
        }

        [TestCase("ya-www-rom2013@ya.ru", "Rr@35RFf", "Rr@35RFf")] //должно проходить, но не проходит
        public void All_Right(string a, string b, string c)
        {
            // Подготовка Arrange
            var expect = ("True", "");

            // Действие Act
            var actual = Register.CheckRegister(a, b, c);


            // Проверка Assert
            Assert.That(actual, Is.EqualTo(expect));
        }
    }
}