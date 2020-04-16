namespace FunScript.Bindings

open System

open FunScript

type [<AllowNullLiteral>] Promise<'T> =
    abstract ``then``: ?onfulfilled: ('T->'TResult) * ?onrejected: (obj->'TResult) -> Promise<'TResult>
    abstract catch: ?onrejected: (obj->'T) -> Promise<'T>

and [<AllowNullLiteral>] PromiseConstructor =
    [<Emit("new $0($1...)")>] abstract Create: executor: ((obj->unit) -> (obj->unit) -> unit) -> Promise<'T>
    abstract all: [<ParamArray>] values: obj[] -> Promise<obj>
    abstract race: values: obj seq -> Promise<obj>
    abstract reject: reason: obj -> Promise<unit>
    abstract reject: reason: obj -> Promise<'T>
    abstract resolve: value: 'T -> Promise<'T>
    abstract resolve: unit -> Promise<unit>

type CaseRules =
    | None = 0
    /// FooBar -> fooBar
    | LowerFirst = 1
    /// FooBar -> foo_bar
    | SnakeCase = 2
    /// FooBar -> FOO_BAR
    | SnakeCaseAllCaps = 3
    /// FooBar -> foo-bar
    | KebabCase = 4

   
/// Compile union types as string literals.
/// More info: http://fable.io/docs/interacting.html#StringEnum-attribute
[<AttributeUsage(AttributeTargets.Class)>]
type StringEnumAttribute() =
    inherit Attribute()
    new (caseRules: CaseRules) = StringEnumAttribute()

/// Erased union type to represent one of two possible values.
/// More info: http://fable.io/docs/interacting.html#Erase-attribute
type U2<'a, 'b> =
    | Case1 of 'a
    | Case2 of 'b
    static member op_ErasedCast(x:'a) = Case1 x
    static member op_ErasedCast(x:'b) = Case2 x

/// Erased union type to represent one of three possible values.
/// More info: http://fable.io/docs/interacting.html#Erase-attribute
type U3<'a, 'b, 'c> =
    | Case1 of 'a
    | Case2 of 'b
    | Case3 of 'c
    static member op_ErasedCast(x:'a) = Case1 x
    static member op_ErasedCast(x:'b) = Case2 x
    static member op_ErasedCast(x:'c) = Case3 x

/// Erased union type to represent one of four possible values.
/// More info: http://fable.io/docs/interacting.html#Erase-attribute
type U4<'a, 'b, 'c, 'd> =
    | Case1 of 'a
    | Case2 of 'b
    | Case3 of 'c
    | Case4 of 'd
    static member op_ErasedCast(x:'a) = Case1 x
    static member op_ErasedCast(x:'b) = Case2 x
    static member op_ErasedCast(x:'c) = Case3 x
    static member op_ErasedCast(x:'d) = Case4 x

/// Erased union type to represent one of five possible values.
/// More info: http://fable.io/docs/interacting.html#Erase-attribute
type U5<'a, 'b, 'c, 'd, 'e> =
    | Case1 of 'a
    | Case2 of 'b
    | Case3 of 'c
    | Case4 of 'd
    | Case5 of 'e
    static member op_ErasedCast(x:'a) = Case1 x
    static member op_ErasedCast(x:'b) = Case2 x
    static member op_ErasedCast(x:'c) = Case3 x
    static member op_ErasedCast(x:'d) = Case4 x
    static member op_ErasedCast(x:'e) = Case5 x

/// Erased union type to represent one of six possible values.
/// More info: http://fable.io/docs/interacting.html#Erase-attribute
type U6<'a, 'b, 'c, 'd, 'e, 'f> =
    | Case1 of 'a
    | Case2 of 'b
    | Case3 of 'c
    | Case4 of 'd
    | Case5 of 'e
    | Case6 of 'f
    static member op_ErasedCast(x:'a) = Case1 x
    static member op_ErasedCast(x:'b) = Case2 x
    static member op_ErasedCast(x:'c) = Case3 x
    static member op_ErasedCast(x:'d) = Case4 x
    static member op_ErasedCast(x:'e) = Case5 x
    static member op_ErasedCast(x:'f) = Case6 x

/// Erased union type to represent one of seven possible values.
/// More info: http://fable.io/docs/interacting.html#Erase-attribute
type U7<'a, 'b, 'c, 'd, 'e, 'f, 'g> =
    | Case1 of 'a
    | Case2 of 'b
    | Case3 of 'c
    | Case4 of 'd
    | Case5 of 'e
    | Case6 of 'f
    | Case7 of 'g
    static member op_ErasedCast(x:'a) = Case1 x
    static member op_ErasedCast(x:'b) = Case2 x
    static member op_ErasedCast(x:'c) = Case3 x
    static member op_ErasedCast(x:'d) = Case4 x
    static member op_ErasedCast(x:'e) = Case5 x
    static member op_ErasedCast(x:'f) = Case6 x
    static member op_ErasedCast(x:'g) = Case7 x

/// Erased union type to represent one of eight possible values.
/// More info: http://fable.io/docs/interacting.html#Erase-attribute
type U8<'a, 'b, 'c, 'd, 'e, 'f, 'g, 'h> =
    | Case1 of 'a
    | Case2 of 'b
    | Case3 of 'c
    | Case4 of 'd
    | Case5 of 'e
    | Case6 of 'f
    | Case7 of 'g
    | Case8 of 'h
    static member op_ErasedCast(x:'a) = Case1 x
    static member op_ErasedCast(x:'b) = Case2 x
    static member op_ErasedCast(x:'c) = Case3 x
    static member op_ErasedCast(x:'d) = Case4 x
    static member op_ErasedCast(x:'e) = Case5 x
    static member op_ErasedCast(x:'f) = Case6 x
    static member op_ErasedCast(x:'g) = Case7 x
    static member op_ErasedCast(x:'h) = Case8 x
