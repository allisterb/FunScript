namespace FunScript

[<AutoOpen>]
module Interop = 
    let stub<'a> : 'a = failwith "This method is a stub for a JavaScript method."
    
    [<JSEmitInline("({})")>]
    let createEmpty<'a> (): 'a = stub