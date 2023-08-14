module EulerSolutions.Tests

open NUnit.Framework
open EulerSolutions

[<TestFixture>]
type TestClass () = 

    [<Test>]
    member this.IsMultipleOfThree_ReturnsTrue_ForThree() =
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
