namespace FsUnit.Test

open Xunit
open FsUnit.Xunit

type ``be lessThanOrEqualTo tests``() =

    [<Fact>]
    member _.``10 should be less than 11``() =
        10 |> should be (lessThanOrEqualTo 11)

    [<Fact>]
    member _.``10[dot]0 should be less than 10[dot]1``() =
        10.0 |> should be (lessThanOrEqualTo 10.1)

    [<Fact>]
    member _.``10 should not be less than 9``() =
        10 |> should not' (be lessThanOrEqualTo 9)

    [<Fact>]
    member _.``9[dot]2 should not be less than 9[dot]1``() =
        9.2 |> should not' (be lessThanOrEqualTo 9.1)

    [<Fact>]
    member _.``9[dot]1 should be less than or equal to 9[dot]1``() =
        9.1 |> should be (lessThanOrEqualTo 9.1)
