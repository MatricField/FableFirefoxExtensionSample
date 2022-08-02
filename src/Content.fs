module FableFirefoxExtensionSample.Content

open Browser.Runtime
open Fable.Core

do
    promise{
        let! result = Browser.Runtime.sendMessage(123)
        match result with
        |"test" -> ()
        |_ -> invalidOp "Unexpected message"
    }|>Promise.start