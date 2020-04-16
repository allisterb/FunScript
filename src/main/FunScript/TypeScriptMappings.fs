namespace FunScript

open System
open System.Collections.Generic
open System.Text.RegularExpressions

open FunScript.Bindings

[<AutoOpen>]
module TypeScriptMappings =

    let components = [
        ExpressionReplacer.createUnsafe <@ fun x -> U2.Case1 x @> <@fun x -> id x @>
        ExpressionReplacer.createUnsafe <@ fun x -> U2.Case2 x @> <@fun x -> id x @>

        ExpressionReplacer.createUnsafe <@ fun x -> U3.Case1 x @> <@fun x -> id x @>
        ExpressionReplacer.createUnsafe <@ fun x -> U3.Case2 x @> <@fun x -> id x @>
        ExpressionReplacer.createUnsafe <@ fun x -> U3.Case3 x @> <@fun x -> id x @>
    //let GlobalVars = new List<string>()

    //let postProcess s = 
      //  let removeGlobals (s:string) = s.Replace("Globals__", "")

      //  let removeUx (s:string) =
      //      let vars = new Regex("var\\s+U\\d_\\S+\\s", RegexOptions.Compiled)
      //      vars.Replace(s, "")
        
       // s// |> removeGlobals |> removeUx
    ] 
    let compile expr = Compiler.Compiler.Compile(expr, components, true)
        
        

