namespace M3U8Parser.Tests

open Microsoft.VisualStudio.TestTools.UnitTesting
open System.IO

[<TestClass>]
type TestClass() =
    
    [<TestMethod>]
    member this.TestMethodPassing() =
        let content = File.ReadAllText("./res/basic.m3u8")
        let a = 3
        Assert.AreEqual(3, a)
