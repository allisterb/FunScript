namespace FunScript.Bindings.D3

open System

open FunScript
open FunScript.Bindings

type AxisDomain =
    U4<float, string, DateTime, (unit -> float)>

/// A helper interface to describe the minimal contract to be met by a time interval
/// which can be passed into the Axis.ticks(...) or Axis.tickArguments(...) methods when
/// creating time series axes. Under normal circumstances the argument will be of type
/// TimeInterval or CountableTimeInterval as defined in d3-time.
/// NB: This helper interface has been created to avoid tight coupling of d3-axis to
/// d3-time at the level of definition files. I.e. d3-time is not a
/// dependency of d3-axis in the D3 Javascript implementation. This minimal contract
/// is based on an analysis of how d3-axis passes a time interval argument into a time scale,
/// if a time scale was set using Axis.scale(...). And in turn on how a time scale uses
/// the time interval when creating ticks from it.
type [<AllowNullLiteral>] AxisTimeInterval =
    abstract range: start: DateTime * stop: DateTime * ?step: float -> ResizeArray<DateTime>

/// A helper interface to which a scale passed into axis must conform (at a minimum)
/// for axis to use the scale without error.
type [<AllowNullLiteral>] AxisScale<'Domain> =
    [<Emit "$0($1...)">] abstract Invoke: x: 'Domain -> float option
    abstract domain: unit -> ResizeArray<'Domain>
    abstract range: unit -> ResizeArray<float>
    abstract copy: unit -> AxisScale<'Domain>
    abstract bandwidth: unit -> float

type AxisContainerElement =
    U2<SVGSVGElement, SVGGElement>

/// Interface defining an axis generator. The generic <Domain> is the type of the axis domain.
type [<AllowNullLiteral>] Axis<'Domain> =
    /// <summary>Render the axis to the given context.</summary>
    /// <param name="context">A selection of SVG containers (either SVG or G elements).</param>
    [<Emit "$0($1...)">] abstract Invoke: context: U2<Selection<SVGSVGElement, obj option, obj option, obj option>, Selection<SVGGElement, obj option, obj option, obj option>> -> unit
    /// <summary>Render the axis to the given context.</summary>
    /// <param name="context">A transition defined on SVG containers (either SVG or G elements).</param>
    [<Emit "$0($1...)">] abstract Invoke: context: U2<TransitionLike<SVGSVGElement, obj option>, TransitionLike<SVGGElement, obj option>> -> unit
    /// Gets the current scale underlying the axis.
    abstract scale: unit -> 'A
    /// <summary>Sets the scale and returns the axis.</summary>
    /// <param name="scale">The scale to be used for axis generation.</param>
    abstract scale: scale: AxisScale<'Domain> -> Axis<'Domain>
    /// <summary>Sets the arguments that will be passed to scale.ticks and scale.tickFormat when the axis is rendered, and returns the axis generator.
    /// 
    /// This method has no effect if the scale does not implement scale.ticks, as with band and point scales.
    /// 
    /// This method is also a convenience function for axis.tickArguments.</summary>
    /// <param name="count">Number of ticks that should be rendered.</param>
    /// <param name="specifier">An optional format specifier to customize how the tick values are formatted.</param>
    abstract ticks: count: float * ?specifier: string -> Axis<'Domain>
    /// <summary>Sets the arguments that will be passed to scale.ticks and scale.tickFormat when the axis is rendered, and returns the axis generator.
    /// Use with a TIME SCALE ONLY.
    /// 
    /// This method is also a convenience function for axis.tickArguments.</summary>
    /// <param name="interval">A time interval used to generate date-based ticks. This is typically a TimeInterval/CountableTimeInterval as defined
    /// in d3-time. E.g. as obtained by passing in d3.timeMinute.every(15).</param>
    /// <param name="specifier">An optional format specifier to customize how the tick values are formatted.</param>
    abstract ticks: interval: AxisTimeInterval * ?specifier: string -> Axis<'Domain>
    /// Sets the arguments that will be passed to scale.ticks and scale.tickFormat when the axis is rendered, and returns the axis generator.
    /// 
    /// The meaning of the arguments depends on the axis’ scale type: most commonly, the arguments are a suggested count for the number of ticks
    /// (or a time interval for time scales), and an optional format specifier to customize how the tick values are formatted.
    /// 
    /// This method has no effect if the scale does not implement scale.ticks, as with band and point scales.
    /// 
    /// To set the tick values explicitly, use axis.tickValues. To set the tick format explicitly, use axis.tickFormat.
    /// 
    /// This method is also a convenience function for axis.tickArguments.
    abstract ticks: arg0: obj option * [<ParamArray>] args: ResizeArray<obj option> -> Axis<'Domain>
    /// Get an array containing the currently set arguments to be passed into scale.ticks and scale.tickFormat, which defaults to the empty array.
    abstract tickArguments: unit -> ResizeArray<obj option>
    /// <summary>Sets the arguments that will be passed to scale.ticks and scale.tickFormat when the axis is rendered, and returns the axis generator.
    /// 
    /// This method has no effect if the scale does not implement scale.ticks, as with band and point scales.
    /// To set the tick values explicitly, use axis.tickValues. To set the tick format explicitly, use axis.tickFormat.
    /// 
    /// See also axis.ticks.</summary>
    /// <param name="args">An array containing a single element representing the count, i.e. number of ticks to be rendered.</param>
    abstract tickArguments: args: float -> Axis<'Domain>
    /// <summary>Sets the arguments that will be passed to scale.ticks and scale.tickFormat when the axis is rendered, and returns the axis generator.
    /// 
    /// This method has no effect if the scale does not implement scale.ticks, as with band and point scales.
    /// To set the tick values explicitly, use axis.tickValues. To set the tick format explicitly, use axis.tickFormat.
    /// 
    /// See also axis.ticks.</summary>
    /// <param name="args">An array containing two elements. The first element represents the count, i.e. number of ticks to be rendered. The second
    /// element is a string representing the format specifier to customize how the tick values are formatted.</param>
    abstract tickArguments: args: float * string -> Axis<'Domain>
    /// <summary>Sets the arguments that will be passed to scale.ticks and scale.tickFormat when the axis is rendered, and returns the axis generator.
    /// Use with a TIME SCALE ONLY.
    /// 
    /// See also axis.ticks.</summary>
    /// <param name="args">An array containing a single element representing a time interval used to generate date-based ticks.
    /// This is typically a TimeInterval/CountableTimeInterval as defined in d3-time. E.g. as obtained by passing in d3.timeMinute.every(15).</param>
    abstract tickArguments: args: AxisTimeInterval -> Axis<'Domain>
    /// <summary>Sets the arguments that will be passed to scale.ticks and scale.tickFormat when the axis is rendered, and returns the axis generator.
    /// Use with a TIME SCALE ONLY.
    /// 
    /// See also axis.ticks.</summary>
    /// <param name="args">An array containing two elements. The first element represents a time interval used to generate date-based ticks.
    /// This is typically a TimeInterval/CountableTimeInterval as defined in d3-time. E.g. as obtained by passing in d3.timeMinute.every(15).
    /// The second element is a string representing the format specifier to customize how the tick values are formatted.</param>
    abstract tickArguments: args: AxisTimeInterval * string -> Axis<'Domain>
    /// <summary>Sets the arguments that will be passed to scale.ticks and scale.tickFormat when the axis is rendered, and returns the axis generator.
    /// 
    /// This method has no effect if the scale does not implement scale.ticks, as with band and point scales.
    /// To set the tick values explicitly, use axis.tickValues. To set the tick format explicitly, use axis.tickFormat.
    /// 
    /// See also axis.ticks.</summary>
    /// <param name="args">An array with arguments suitable for the scale to be used for tick generation.</param>
    abstract tickArguments: args: ResizeArray<obj option> -> Axis<'Domain>
    /// Returns the current tick values, which defaults to null.
    abstract tickValues: unit -> ResizeArray<'Domain> option
    /// <summary>Specified values to be used for ticks rather than using the scale’s automatic tick generator.
    /// The explicit tick values take precedent over the tick arguments set by axis.tickArguments.
    /// However, any tick arguments will still be passed to the scale’s tickFormat function if a
    /// tick format is not also set.</summary>
    /// <param name="values">An array with values from the Domain of the scale underlying the axis.</param>
    abstract tickValues: values: ResizeArray<'Domain> -> Axis<'Domain>
    /// <summary>Clears any previously-set explicit tick values and reverts back to the scale’s tick generator.</summary>
    /// <param name="values">null</param>
    abstract tickValues: values: obj -> Axis<'Domain>
    /// Returns the currently set tick format function, which defaults to null.
    abstract tickFormat: unit -> ('Domain -> float -> string) option
    /// <summary>Sets the tick format function and returns the axis.</summary>
    /// <param name="format">A function mapping a value from the axis Domain to a formatted string
    /// for display purposes. When invoked, the format function is also passed a second argument representing the zero-based index
    /// of the tick label in the array of generated tick labels.</param>
    abstract tickFormat: format: ('Domain -> float -> string) -> Axis<'Domain>
    /// <summary>Reset the tick format function. A null format indicates that the scale’s
    /// default formatter should be used, which is generated by calling scale.tickFormat.
    /// In this case, the arguments specified by axis.tickArguments
    /// are likewise passed to scale.tickFormat.</summary>
    /// <param name="format">null</param>
    abstract tickFormat: format: obj -> Axis<'Domain>
    /// Get the current inner tick size, which defaults to 6.
    abstract tickSize: unit -> float
    /// <summary>Set the inner and outer tick size to the specified value and return the axis.</summary>
    /// <param name="size">Tick size in pixels (Default is 6).</param>
    abstract tickSize: size: float -> Axis<'Domain>
    /// Get the current inner tick size, which defaults to 6.
    /// The inner tick size controls the length of the tick lines,
    /// offset from the native position of the axis.
    abstract tickSizeInner: unit -> float
    /// <summary>Set the inner tick size to the specified value and return the axis.
    /// The inner tick size controls the length of the tick lines,
    /// offset from the native position of the axis.</summary>
    /// <param name="size">Tick size in pixels (Default is 6).</param>
    abstract tickSizeInner: size: float -> Axis<'Domain>
    /// Get the current outer tick size, which defaults to 6.
    /// The outer tick size controls the length of the square ends of the domain path,
    /// offset from the native position of the axis. Thus, the “outer ticks” are not actually
    /// ticks but part of the domain path, and their position is determined by the associated
    /// scale’s domain extent. Thus, outer ticks may overlap with the first or last inner tick.
    /// An outer tick size of 0 suppresses the square ends of the domain path,
    /// instead producing a straight line.
    abstract tickSizeOuter: unit -> float
    /// <summary>Set the current outer tick size and return the axis.
    /// The outer tick size controls the length of the square ends of the domain path,
    /// offset from the native position of the axis. Thus, the “outer ticks” are not actually
    /// ticks but part of the domain path, and their position is determined by the associated
    /// scale’s domain extent. Thus, outer ticks may overlap with the first or last inner tick.
    /// An outer tick size of 0 suppresses the square ends of the domain path,
    /// instead producing a straight line.</summary>
    /// <param name="size">Tick size in pixels (Default is 6).</param>
    abstract tickSizeOuter: size: float -> Axis<'Domain>
    /// Get the current padding, which defaults to 3.
    abstract tickPadding: unit -> float
    /// <summary>Set the current padding and return the axis.</summary>
    /// <param name="padding">Padding in pixels (Default is 3).</param>
    abstract tickPadding: padding: float -> Axis<'Domain>