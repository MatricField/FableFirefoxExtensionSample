module Browser
open Fable.Core
module Runtime =
    module Types =
        
        type MessageSender = {
            tab: obj option
            frameId: int option

        }
        type FuncSendRespond<'Msg> = 'Msg -> unit
        type MessageListener<'Msg, 'Res> = 'Msg * MessageSender * FuncSendRespond<'Res> -> bool
        type AsyncMessageListener<'Msg, 'Res> = 'Msg * MessageSender -> JS.Promise<'Res>
        type MessageTarget =
            abstract addListener: MessageListener<'Msg, 'Res> -> unit

        type IMessagePort =
            abstract sendMessage: message:'Msg * ?options: 'Opt  -> JS.Promise<'Res>
            abstract sendMessage: id:int * message:'Msg * options: 'Opt  -> JS.Promise<'Res>

        type IRuntime =
            inherit IMessagePort

open Runtime.Types

let [<Global("brower.runtime")>] Runtime: IRuntime = jsNative