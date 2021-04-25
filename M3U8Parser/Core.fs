module Core

open PrefixConstants.HeaderConstants
open PrefixConstants.BodyConstants
open System

let parseVersion (text: string) = ""
let parseMedia (text: string) = ""
let parseStreamInf (text: string) = ""

let parseLine (line: string) =
    let parts = line.Split [| ':' |]
    let prefix = parts.[0]

    let dd =
        match prefix with
        | STREAM_INF -> parseStreamInf parts.[1]
        | VERSION -> parseVersion parts.[1]
        | MEDIA -> parseMedia (parts.[1])
        | _ -> ""

    dd
