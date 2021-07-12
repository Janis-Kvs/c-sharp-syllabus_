# Tests

## You should create tests for these exercises:

### Arrays
- Exercise 6

### Arithmetics
- Exercise 1
- Exercise 2
- Exercise 6
- Exercise 7
- Exercise 8
- Exercise 10

### Collections
- Exercise 5
- Exercise 6
- Exercise 8
- Exercise 9

### Classes and Objects
- Exercise 1
- Exercise 5
- Exercise 12

### Polymorphism
- Exercise 1
- Exercise 6

When creating tests, each test method should be in the form UsedMethod_WhatIsGiven_WhatIsExpected. Test example:
```
	    [TestMethod]
        public void CheckNumbers_InputNo15_ReturnsFalse()
        {
            // Arrange
            int a = 1;
            int b = 1;

            // Act
            var result = _test.CheckNumbers(a, b);

            // Assert
            Assert.AreEqual(false, result);
        }
```

If you want to create similar tests with different given parameters. you can use 
```
[DataTestMethod]
[DataRow(12,3,4)]
[DataRow(12,2,6)]
[DataRow(12,4,3)]
public void DivideTest(int n, int d, int q)
{
	// Act
	var result = _calculation.Devide(a,b)

	// Assert
	Assert.AreEqual(result, q);
}
```