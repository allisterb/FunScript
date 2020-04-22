namespace FunScript

open FSharp.Quotations

open FunScript.AST
open FunScript.Bindings

[<AutoOpen>]
module TypeScriptMappings =

    let components = [
        CompilerComponent.unary <@ U2.Case1 @> id
        CompilerComponent.unary <@ U2.Case2 @> id

        CompilerComponent.unary <@ U3.Case1 @> id
        CompilerComponent.unary <@ U3.Case1 @> id
        CompilerComponent.unary <@ U3.Case3 @> id

        CompilerComponent.unary <@ U4.Case1 @> id
        CompilerComponent.unary <@ U4.Case1 @> id
        CompilerComponent.unary <@ U4.Case3 @> id
        CompilerComponent.unary <@ U4.Case4 @> id
        //ExpressionReplacer.createUnsafe <@ fun x -> U2.Case1 x @> <@fun x -> id x @>
        //ExpressionReplacer.createUnsafe <@ fun x -> U2.Case2 x @> <@fun x -> id x @>

        //ExpressionReplacer.createUnsafe <@ fun x -> U3.Case1 x @> <@fun x -> id x @>
        //ExpressionReplacer.createUnsafe <@ fun x -> U3.Case2 x @> <@fun x -> id x @>
        //ExpressionReplacer.createUnsafe <@ fun x -> U3.Case3 x @> <@fun x -> id x @>
    //let GlobalVars = new List<string>()

    //let postProcess s = 
      //  let removeGlobals (s:string) = s.Replace("Globals__", "")

      //  let removeUx (s:string) =
      //      let vars = new Regex("var\\s+U\\d_\\S+\\s", RegexOptions.Compiled)
      //      vars.Replace(s, "")
        
       // s// |> removeGlobals |> removeUx
    ] 
    let compile expr = Compiler.Compiler.Compile(expr, components, true)
        
        

