namespace M3U8Parser.Tests

open Microsoft.VisualStudio.TestTools.UnitTesting

[<TestClass>]
type TestClass() =

    [<TestMethod>]
    member this.TestMethodPassing() =
        let a = 3
        Assert.AreEqual(3, a)
