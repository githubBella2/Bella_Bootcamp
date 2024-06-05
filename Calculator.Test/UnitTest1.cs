namespace Calculator.Test;

using System.Reflection.Metadata;
using CalculatorTesting;
public class Tests
{
    private Calculator calculator;
    private Person _person;
    [SetUp]
    public void Setup()
    {
        calculator = new Calculator();
        _person = new Person();
    }
    #region  CALCULATOR
    [Test]
    //membuat method baru
    //Penamaan: terdiri dari nama method yg akan diuji, ekspektasi thp method hasilnya apa

    public void Add_ReturnCorrectValue()
    {
        //Arrange: bikin variabel

        int a = 2;
        int b = 4;
        int expectation = 6;

        // Action : memanggil method
        int result = calculator.Add(a, b);

        // Assert : sesuai gak
        Assert.AreEqual(expectation, result);
    }

    // [TestCase(1, 3, 4)]
    // [TestCase(7, 8, 15)]
    // [TestCase(45, 25, 70)]
    public void Add_ReturnCorrectValue_UsingTestCase(int a, int b, int expected)
    {
        int result = calculator.Add(a, b);

        Assert.AreEqual(expected, result);
    }


    // [TestCase(1, 3, 3)]
    public void Multiply_ReturnCorrectValue_UsingTestCase(int a, int b, int expectation)
    {
        int result = calculator.Multiply(a, b);

        Assert.AreEqual(expectation, result);
    }


    public void Reverse_ReturnReverseWord()
    {
        string kata = "SUTARMAN";
        string expectation = "NAMRATUS";
        string hasil = calculator.ReverseWord(kata);
        Assert.AreEqual(kata, expectation);
    }

    [TestCase("SUTARMAN", "NAMRATUS")]
    public void Reverse_ReturnCorrectValue_UsingTestCase(string word, string expectation)
    {
        string result = calculator.ReverseWord(word);
        Assert.AreEqual(expectation,result);
    }


    public void Reverse_WhenCalledEmptyStringReverseWord()
    {
        string word = null;
        string expectation = null;
        string result = calculator.ReverseWord(word);
        Assert.AreEqual(expectation,result);
    }

    #endregion


    #region  PERSON
    // public void GetFullName_WhenCalledWithValidPerson_ReturnFullName()
    // {
    //     // Arrange
    //     var juned = new Person() { FirstName = "Junaidi", LastName = "Rico" };

    //     // Action
    //     var result = _person.GetFullName(juned);

    //     // Assert
    //     Assert.AreEqual("Junaidi Rico", result);
    // }

    // public void IsEvenNumber_ReturnBool()
    // {
    //     // Arrange
    //     int number = 6;
    //     bool expectationBoolean = true;
    //     // Action
    //     bool result = _person.IsEvenNumber(number);
    //     // Assert
    //     Assert.AreEqual(expectationBoolean, result);
    // }

    // [Test]
    // public void GetFullName_WhenCalledWithNull_ReturnNull()
    // {
    //     // Arrange

    //     // Act
    //     var result = _person.GetFullName(null);
    //     // Assert
    //     Assert.IsNull(result);
    // }
    #endregion
}