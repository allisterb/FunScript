namespace FunScript

open System

type JS = ReflectedDefinitionAttribute

[<AttributeUsage(AttributeTargets.Class||| AttributeTargets.Module ||| AttributeTargets.Field|||AttributeTargets.Property|||AttributeTargets.Method)>]
type InlineAttribute() =
   inherit System.Attribute()

[<AttributeUsage(AttributeTargets.Property|||AttributeTargets.Method)>]
type JSEmitAttribute(emit:string) =
   inherit System.Attribute()
   member __.Emit = emit

[<AttributeUsage(AttributeTargets.Property|||AttributeTargets.Method)>]
type JSEmitInlineAttribute(emit:string) =
   inherit System.Attribute()
   member __.Emit = emit

type EmitAttribute = JSEmitInlineAttribute

/// Compile union type as string literal
[<AttributeUsage(AttributeTargets.Class)>]
type StringUnionAttribute() =
    inherit Attribute()
    new (caseRules: CaseRules) = StringUnionAttribute()

and CaseRules =
    | None = 0
    /// FooBar -> fooBar
    | LowerFirst = 1
    /// FooBar -> foo_bar
    | SnakeCase = 2
    /// FooBar -> FOO_BAR
    | SnakeCaseAllCaps = 3
    /// FooBar -> foo-bar
    | KebabCase = 4

type StringEnumAttribute = StringUnionAttribute

namespace global

open FunScript

[<AutoOpen>]
module TypeExtensions =
    
    [<JSEmitInlineAttribute("({})")>]
    let createEmpty<'a>() : 'a = failwith "never"