module EulerSolutions.Tests

open NUnit.Framework
open EulerSolutions

[<TestFixture>]
type TestClass () = 

    [<Test>]
    member thi.IsMultipleOfThree_ReturnsTrue_ForThree() =
        let resutl = EulerSolutions.EulerOne.isMultipleOfThree(3)
        Assert.IsTrue(resutl)
        

    [<Test>]
    member this.IsMultipleOfThree_ReturnsFalse_ForFour() =
        let resutl = EulerSolutions.EulerOne.isMultipleOfThree(4)
        Assert.IsFalse(resutl)
        
    [<Test>]                                                            
    member this.IsMultipleOfFive_ReturnsFalse_ForFour() =
        let resutl = EulerSolutions.EulerOne.isMultipleOfFive(4)
        Assert.IsFalse(resutl)

    [<Test>]
    member this.IsMultipleOfFive_ReturnsTrue_ForFive() =
        let resutl = EulerSolutions.EulerOne.isMultipleOfFive(5)
        Assert.IsTrue(resutl)

    [<Test>]
    member this.MainInt_When_N_Is_Zero_Returns_Sum() =
        let sum = 5
        let result = EulerSolutions.EulerOne.mainInt 0 sum
        Assert.AreEqual(sum, result)

    [<Test>]
    member this.Main_When_N_Is_Ten_Returns_23() =
        let result = EulerSolutions.EulerOne.main(9)
        Assert.AreEqual(23, result)

    [<Test>]
    member this.Main_Euler() =
        let result = EulerSolutions.EulerOne.main(233168)
        Assert.AreEqual(23, result)

