namespace FunScript.Bindings.D3

open System

open FunScript
open FunScript.Bindings

type [<AllowNullLiteral>] ScaleImplicit =
    abstract name: string with get, set

and [<AllowNullLiteral>] ScaleContinuousNumericInvoke =
    abstract valueOf: unit -> float
/// An Interpolator factory returns an interpolator function.
/// 
/// The first generic corresponds to the data type of the interpolation boundaries.
/// The second generic corresponds to the data type of the return type of the interpolator.
type [<AllowNullLiteral>] InterpolatorFactory<'T, 'U> =
    /// <summary>Construct a new interpolator function, based on the provided interpolation boundaries.</summary>
    /// <param name="a">Start boundary of the interpolation interval.</param>
    /// <param name="b">End boundary of the interpolation interval.</param>
    [<Emit "$0($1...)">] abstract Invoke: a: 'T * b: 'T -> (float -> 'U)

/// A helper interface for a continuous scale defined over a numeric domain.
type [<AllowNullLiteral>] ScaleContinuousNumeric<'Range, 'Output> =
    /// <summary>Given a value from the domain, returns the corresponding value from the range, subject to interpolation, if any.
    /// 
    /// If the given value is outside the domain, and clamping is not enabled, the mapping may be extrapolated such that the returned value is outside the range.
    /// 
    /// Note: The interpolation function applied by the scale may change the output type from the range type as part of the interpolation.</summary>
    /// <param name="value">A numeric value from the domain.</param>
    [<Emit "$0($1...)">] abstract Invoke: value: U2<float, ScaleContinuousNumericInvoke> -> 'Output
    /// <summary>Given a value from the range, returns the corresponding value from the domain. Inversion is useful for interaction,
    /// say to determine the data value corresponding to the position of the mouse.
    /// 
    /// If the given value is outside the range, and clamping is not enabled, the mapping may be extrapolated such that the returned value is outside the domain.
    /// 
    /// IMPORTANT: This method is only supported if the range is numeric. If the range is not numeric, returns NaN.
    /// 
    /// For a valid value y in the range, continuous(continuous.invert(y)) approximately equals y;
    /// similarly, for a valid value x in the domain, continuous.invert(continuous(x)) approximately equals x.
    /// The scale and its inverse may not be exact due to the limitations of floating point precision.</summary>
    /// <param name="value">A numeric value from the range.</param>
    abstract invert: value: U2<float, ScaleContinuousNumericInvoke> -> float
    /// Returns a copy of the scale’s current domain.
    abstract domain: unit -> Array<float>
    /// <summary>Sets the scale’s domain to the specified array of numbers. The array must contain two or more elements.
    /// If the elements in the given array are not numbers, they will be coerced to numbers
    /// 
    /// Although continuous scales typically have two values each in their domain and range, specifying more than two values produces a piecewise scale.
    /// 
    /// Internally, a piecewise scale performs a binary search for the range interpolator corresponding to the given domain value.
    /// Thus, the domain must be in ascending or descending order. If the domain and range have different lengths N and M, only the first min(N,M) elements in each are observed.</summary>
    /// <param name="domain">Array of numeric domain values.</param>
    abstract domain: domain: Array<U2<float, ScaleContinuousNumericInvoke>> -> ScaleContinuousNumeric<'Range, 'Output>
    /// Returns a copy of the scale’s current range.
    abstract range: unit -> Array<'Range>
    /// <summary>Sets the scale’s range to the specified array of values.
    /// 
    /// The array must contain two or more elements. Unlike the domain, elements in the given array need not be numbers;
    /// any value that is supported by the underlying interpolator will work, though note that numeric ranges are required for invert.</summary>
    /// <param name="range">Array of range values.</param>
    abstract range: range: Array<'Range> -> ScaleContinuousNumeric<'Range, 'Output>
    /// <summary>Sets the scale’s range to the specified array of values while also setting the scale’s interpolator to interpolateRound.
    /// 
    /// The rounding interpolator is sometimes useful for avoiding antialiasing artifacts,
    /// though also consider the shape-rendering “crispEdges” styles. Note that this interpolator can only be used with numeric ranges.
    /// 
    /// The array must contain two or more elements. Unlike the domain, elements in the given array need not be numbers;
    /// any value that is supported by the underlying interpolator will work, though note that numeric ranges are required for invert.</summary>
    /// <param name="range">Array of range values.</param>
    abstract rangeRound: range: Array<U2<float, ScaleContinuousNumericInvoke>> -> ScaleContinuousNumeric<'Range, 'Output>
    /// Returns whether or not the scale currently clamps values to within the range.
    abstract clamp: unit -> bool
    /// <summary>Enables or disables clamping, respectively. If clamping is disabled and the scale is passed a value outside the domain,
    /// the scale may return a value outside the range through extrapolation.
    /// 
    /// If clamping is enabled, the return value of the scale is always within the scale’s range. Clamping similarly applies to the "invert" method.</summary>
    /// <param name="clamp">A flag to enable (true) or disable (false) clamping.</param>
    abstract clamp: clamp: bool -> ScaleContinuousNumeric<'Range, 'Output>
    /// <summary>Returns approximately count representative values from the scale’s domain.
    /// 
    /// If count is not specified, it defaults to 10.
    /// 
    /// The returned tick values are uniformly spaced, have human-readable values (such as multiples of powers of 10),
    /// and are guaranteed to be within the extent of the domain. Ticks are often used to display reference lines, or tick marks, in conjunction with the visualized data.
    /// The specified count is only a hint; the scale may return more or fewer values depending on the domain. See also d3-array’s ticks.</summary>
    /// <param name="count">Optional approximate number of ticks to be returned. If count is not specified, it defaults to 10.</param>
    abstract ticks: ?count: float -> Array<float>
    /// <summary>Returns a number format function suitable for displaying a tick value, automatically computing the appropriate precision based on the fixed interval between tick values.
    /// The specified count should have the same value as the count that is used to generate the tick values.</summary>
    /// <param name="count">Approximate number of ticks to be used when calculating precision for the number format function.</param>
    /// <param name="specifier">An optional valid format specifier string which allows a custom format where the precision of the format is automatically set by the scale as appropriate for the tick interval.
    /// If specifier uses the format type "s", the scale will return a SI-prefix format based on the largest value in the domain.
    /// If the specifier already specifies a precision, this method is equivalent to locale.format.</param>
    abstract tickFormat: ?count: float * ?specifier: string -> (U2<float, ScaleContinuousNumericInvoke> -> string)
    /// <summary>Extends the domain so that it starts and ends on nice round values.
    /// This method typically modifies the scale’s domain, and may only extend the bounds to the nearest round value.
    /// An optional tick count argument allows greater control over the step size used to extend the bounds,
    /// guaranteeing that the returned ticks will exactly cover the domain.
    /// Nicing is useful if the domain is computed from data, say using extent, and may be irregular.
    /// For example, for a domain of [0.201479…, 0.996679…], a nice domain might be [0.2, 1.0].
    /// If the domain has more than two values, nicing the domain only affects the first and last value.
    /// 
    /// Nicing a scale only modifies the current domain; it does not automatically nice domains that are subsequently set using continuous.domain.
    /// You must re-nice the scale after setting the new domain, if desired.</summary>
    /// <param name="count">An optional number of ticks expected to be used.</param>
    abstract nice: ?count: float -> ScaleContinuousNumeric<'Range, 'Output>
    /// Returns an exact copy of this scale. Changes to this scale will not affect the returned scale, and vice versa.
    abstract copy: unit -> ScaleContinuousNumeric<'Range, 'Output>

/// A linear continuous scale defined over a numeric domain.
/// 
/// Continuous scales map a continuous, quantitative input domain to a continuous output range.
/// Each range value y can be expressed as a function of the domain value x: y = mx + b.
/// 
/// If the range is also numeric, the mapping may be inverted.
/// 
/// Note that the data types of the range and output of the scale must be compatible with the interpolator applied by the scale.
/// 
/// The first generic corresponds to the data type of the range elements.
/// 
/// The second generic corresponds to the data type of the output elements generated by the scale.
/// 
/// If range element and output element type differ, the interpolator factory used with the scale must match this behavior and
/// convert the interpolated range element to a corresponding output element.
and [<AllowNullLiteral>] ScaleLinear<'Range, 'Output> =
    inherit ScaleContinuousNumeric<'Range, 'Output>
    /// Returns the scale’s current interpolator factory, which defaults to interpolate.
    abstract interpolate: unit -> InterpolatorFactory<obj option, obj option>
    /// <summary>Sets the scale’s range interpolator factory. This interpolator factory is used to create interpolators for each adjacent pair of values from the range;
    /// these interpolators then map a normalized domain parameter t in [0, 1] to the corresponding value in the range.
    /// 
    /// Note: the default interpolator may reuse return values. For example, if the range values are objects, then the value interpolator always returns the same object, modifying it in-place.
    /// If the scale is used to set an attribute or style, this is typically acceptable (and desirable for performance);
    /// however, if you need to store the scale’s return value, you must specify your own interpolator or make a copy as appropriate.
    /// 
    /// As part of the interpolation process the interpolated value from the range may be converted to a corresponding output value.</summary>
    /// <param name="interpolate">An interpolation factory. The generics for Range and Output of the scale must correspond to the interpolation factory applied to the scale.</param>
    abstract interpolate: interpolate: InterpolatorFactory<'Range, 'Output> -> ScaleLinear<'Range, 'Output>
    /// <summary>Sets the scale’s range interpolator factory. This interpolator factory is used to create interpolators for each adjacent pair of values from the range;
    /// these interpolators then map a normalized domain parameter t in [0, 1] to the corresponding value in the range.
    /// 
    /// Note: the default interpolator may reuse return values. For example, if the range values are objects, then the value interpolator always returns the same object, modifying it in-place.
    /// If the scale is used to set an attribute or style, this is typically acceptable (and desirable for performance);
    /// however, if you need to store the scale’s return value, you must specify your own interpolator or make a copy as appropriate.
    /// 
    /// As part of the interpolation process the interpolated value from the range may be converted to a corresponding output value.
    /// 
    /// The generic "NewOutput" can be used to change the scale to have a different output element type corresponding to the new interpolation factory.</summary>
    /// <param name="interpolate">An interpolation factory. The generics for Range and Output of the scale must correspond to the interpolation factory applied to the scale.</param>
    abstract interpolate: interpolate: InterpolatorFactory<'Range, 'NewOutput> -> ScaleLinear<'Range, 'NewOutput>

/// A continuous power scale defined over a numeric domain.
/// 
/// Continuous scales map a continuous, quantitative input domain to a continuous output range.
/// 
/// Each range value y can be expressed as a function of the domain value x: y = mx^k + b, where k is the exponent value.
/// Power scales also support negative domain values, in which case the input value and the resulting output value are multiplied by -1.
/// 
/// If the range is also numeric, the mapping may be inverted.
/// 
/// Note that the data types of the range and output of the scale must be compatible with the interpolator applied by the scale.
/// 
/// The first generic corresponds to the data type of the range elements.
/// 
/// The second generic corresponds to the data type of the output elements generated by the scale.
/// 
/// If range element and output element type differ, the interpolator factory used with the scale must match this behavior and
/// convert the interpolated range element to a corresponding output element.
and [<AllowNullLiteral>] ScalePower<'Range, 'Output> =
    inherit ScaleContinuousNumeric<'Range, 'Output>
    /// Returns the scale’s current interpolator factory, which defaults to interpolate.
    abstract interpolate: unit -> InterpolatorFactory<obj option, obj option>
    /// <summary>Sets the scale’s range interpolator factory. This interpolator factory is used to create interpolators for each adjacent pair of values from the range;
    /// these interpolators then map a normalized domain parameter t in [0, 1] to the corresponding value in the range.
    /// 
    /// Note: the default interpolator may reuse return values. For example, if the range values are objects, then the value interpolator always returns the same object, modifying it in-place.
    /// If the scale is used to set an attribute or style, this is typically acceptable (and desirable for performance);
    /// however, if you need to store the scale’s return value, you must specify your own interpolator or make a copy as appropriate.
    /// 
    /// As part of the interpolation process the interpolated value from the range may be converted to a corresponding output value.</summary>
    /// <param name="interpolate">An interpolation factory. The generics for Range and Output of the scale must correspond to the interpolation factory applied to the scale.</param>
    abstract interpolate: interpolate: InterpolatorFactory<'Range, 'Output> -> ScalePower<'Range, 'Output>
    /// <summary>Sets the scale’s range interpolator factory. This interpolator factory is used to create interpolators for each adjacent pair of values from the range;
    /// these interpolators then map a normalized domain parameter t in [0, 1] to the corresponding value in the range.
    /// 
    /// Note: the default interpolator may reuse return values. For example, if the range values are objects, then the value interpolator always returns the same object, modifying it in-place.
    /// If the scale is used to set an attribute or style, this is typically acceptable (and desirable for performance);
    /// however, if you need to store the scale’s return value, you must specify your own interpolator or make a copy as appropriate.
    /// 
    /// As part of the interpolation process the interpolated value from the range may be converted to a corresponding output value.
    /// 
    /// The generic "NewOutput" can be used to change the scale to have a different output element type corresponding to the new interpolation factory.</summary>
    /// <param name="interpolate">An interpolation factory. The generics for Range and Output of the scale must correspond to the interpolation factory applied to the scale.</param>
    abstract interpolate: interpolate: InterpolatorFactory<'Range, 'NewOutput> -> ScalePower<'Range, 'NewOutput>
    /// If exponent is not specified, returns the current exponent, which defaults to 1.
    /// (Note that this is effectively a linear scale until you set a different exponent.)
    abstract exponent: unit -> float
    /// Sets the current exponent to the given numeric value.
    /// (Note that this is effectively a linear scale until you set a different exponent.)
    abstract exponent: exponent: float -> ScalePower<'Range, 'Output>

/// A continuous logarithmic scale defined over a numeric domain.
/// 
/// Continuous scales map a continuous, quantitative input domain to a continuous output range.
/// 
/// The mapping to the range value y can be expressed as a function of the domain value x: y = m log(x) + b.
/// 
/// As log(0) = -∞, a log scale domain must be strictly-positive or strictly-negative; the domain must not include or cross zero.
/// A log scale with a positive domain has a well-defined behavior for positive values, and a log scale with a negative domain has a well-defined behavior for negative values.
/// (For a negative domain, input and output values are implicitly multiplied by -1.)
/// The behavior of the scale is undefined if you pass a negative value to a log scale with a positive domain or vice versa.
/// 
/// If the range is also numeric, the mapping may be inverted.
/// 
/// Note that the data types of the range and output of the scale must be compatible with the interpolator applied by the scale.
/// 
/// The first generic corresponds to the data type of the range elements.
/// 
/// The second generic corresponds to the data type of the output elements generated by the scale.
/// 
/// If range element and output element type differ, the interpolator factory used with the scale must match this behavior and
/// convert the interpolated range element to a corresponding output element.
and [<AllowNullLiteral>] ScaleLogarithmic<'Range, 'Output> =
    inherit ScaleContinuousNumeric<'Range, 'Output>
    /// Returns a copy of the scale’s current domain.
    abstract domain: unit -> Array<float>
    /// <summary>Sets the scale’s domain to the specified array of numbers. The array must contain two or more elements.
    /// If the elements in the given array are not numbers, they will be coerced to numbers
    /// 
    /// As log(0) = -∞, a log scale domain must be strictly-positive or strictly-negative; the domain must not include or cross zero.
    /// A log scale with a positive domain has a well-defined behavior for positive values, and a log scale with a negative domain has a well-defined behavior for negative values.
    /// (For a negative domain, input and output values are implicitly multiplied by -1.)
    /// The behavior of the scale is undefined if you pass a negative value to a log scale with a positive domain or vice versa.
    /// 
    /// Although continuous scales typically have two values each in their domain and range, specifying more than two values produces a piecewise scale.
    /// 
    /// Internally, a piecewise scale performs a binary search for the range interpolator corresponding to the given domain value.
    /// Thus, the domain must be in ascending or descending order. If the domain and range have different lengths N and M, only the first min(N,M) elements in each are observed.</summary>
    /// <param name="domain">Array of numeric domain values.</param>
    abstract domain: domain: Array<U2<float, ScaleContinuousNumericInvoke>> -> ScaleLogarithmic<'Range, 'Output>
    /// Returns the scale’s current interpolator factory, which defaults to interpolate.
    abstract interpolate: unit -> InterpolatorFactory<obj option, obj option>
    /// <summary>Sets the scale’s range interpolator factory. This interpolator factory is used to create interpolators for each adjacent pair of values from the range;
    /// these interpolators then map a normalized domain parameter t in [0, 1] to the corresponding value in the range.
    /// 
    /// Note: the default interpolator may reuse return values. For example, if the range values are objects, then the value interpolator always returns the same object, modifying it in-place.
    /// If the scale is used to set an attribute or style, this is typically acceptable (and desirable for performance);
    /// however, if you need to store the scale’s return value, you must specify your own interpolator or make a copy as appropriate.
    /// 
    /// As part of the interpolation process the interpolated value from the range may be converted to a corresponding output value.</summary>
    /// <param name="interpolate">An interpolation factory. The generics for Range and Output of the scale must correspond to the interpolation factory applied to the scale.</param>
    abstract interpolate: interpolate: InterpolatorFactory<'Range, 'Output> -> ScaleLogarithmic<'Range, 'Output>
    /// <summary>Sets the scale’s range interpolator factory. This interpolator factory is used to create interpolators for each adjacent pair of values from the range;
    /// these interpolators then map a normalized domain parameter t in [0, 1] to the corresponding value in the range.
    /// 
    /// Note: the default interpolator may reuse return values. For example, if the range values are objects, then the value interpolator always returns the same object, modifying it in-place.
    /// If the scale is used to set an attribute or style, this is typically acceptable (and desirable for performance);
    /// however, if you need to store the scale’s return value, you must specify your own interpolator or make a copy as appropriate.
    /// 
    /// As part of the interpolation process the interpolated value from the range may be converted to a corresponding output value.
    /// 
    /// The generic "NewOutput" can be used to change the scale to have a different output element type corresponding to the new interpolation factory.</summary>
    /// <param name="interpolate">An interpolation factory. The generics for Range and Output of the scale must correspond to the interpolation factory applied to the scale.</param>
    abstract interpolate: interpolate: InterpolatorFactory<'Range, 'NewOutput> -> ScaleLogarithmic<'Range, 'NewOutput>
    /// <summary>Returns approximately count representative values from the scale’s domain.
    /// 
    /// If count is not specified, it defaults to 10.
    /// 
    /// If the base is an integer, the returned ticks are uniformly spaced within each integer power of base; otherwise, one tick per power of base is returned.
    /// The returned ticks are guaranteed to be within the extent of the domain. If the orders of magnitude in the domain is greater than count, then at most one tick per power is returned.
    /// Otherwise, the tick values are unfiltered, but note that you can use log.tickFormat to filter the display of tick labels.</summary>
    /// <param name="count">Optional approximate number of ticks to be returned. If count is not specified, it defaults to 10.</param>
    abstract ticks: ?count: float -> Array<float>
    /// <summary>Returns a number format function suitable for displaying a tick value, automatically computing the appropriate precision based on the fixed interval between tick values.
    /// 
    /// The specified count typically has the same value as the count that is used to generate the tick values.
    /// If there are too many ticks, the formatter may return the empty string for some of the tick labels;
    /// however, note that the ticks are still shown.
    /// To disable filtering, specify a count of Infinity. When specifying a count, you may also provide a format specifier or format function.
    /// For example, to get a tick formatter that will display 20 ticks of a currency, say log.tickFormat(20, "$,f").
    /// If the specifier does not have a defined precision, the precision will be set automatically by the scale, returning the appropriate format.
    /// This provides a convenient way of specifying a format whose precision will be automatically set by the scale.</summary>
    /// <param name="count">Approximate number of ticks to be used when calculating precision for the number format function.</param>
    /// <param name="specifier">An optional valid format specifier string which allows a custom format where the precision of the format is automatically set by the scale as appropriate for the tick interval.
    /// For example, to get a tick formatter that will display 20 ticks of a currency, say log.tickFormat(20, "$,f").
    /// If the specifier does not have a defined precision, the precision will be set automatically by the scale, returning the appropriate format.
    /// This provides a convenient way of specifying a format whose precision will be automatically set by the scale.</param>
    abstract tickFormat: ?count: float * ?specifier: string -> (U2<float, ScaleContinuousNumericInvoke> -> string)
    /// Extends the domain to integer powers of base. For example, for a domain of [0.201479…, 0.996679…], and base 10, the nice domain is [0.1, 1].
    /// If the domain has more than two values, nicing the domain only affects the first and last value.
    /// 
    /// Nicing a scale only modifies the current domain; it does not automatically nice domains that are subsequently set using continuous.domain.
    /// You must re-nice the scale after setting the new domain, if desired.
    abstract nice: unit -> ScaleLogarithmic<'Range, 'Output>
    /// Returns the current base, which defaults to 10.
    abstract ``base``: unit -> float
    /// Sets the base for this logarithmic scale to the specified value.
    abstract ``base``: ``base``: float -> ScaleLogarithmic<'Range, 'Output>

/// A bi-symmetric log transformation for wide-range data by Webber scale defined over a numeric domain.
/// 
/// Continuous scales map a continuous, quantitative input domain to a continuous output range.
/// 
/// See “A bi-symmetric log transformation for wide-range data” by Webber for more
/// 
/// If the range is also numeric, the mapping may be inverted.
/// 
/// Note that the data types of the range and output of the scale must be compatible with the interpolator applied by the scale.
/// 
/// The first generic corresponds to the data type of the range elements.
/// 
/// The second generic corresponds to the data type of the output elements generated by the scale.
/// 
/// If range element and output element type differ, the interpolator factory used with the scale must match this behavior and
/// convert the interpolated range element to a corresponding output element.
and [<AllowNullLiteral>] ScaleSymLog<'Range, 'Output> =
    inherit ScaleContinuousNumeric<'Range, 'Output>
    /// <summary>Returns a number format function suitable for displaying a tick value, automatically computing the appropriate precision based on the fixed interval between tick values.
    /// 
    /// The specified count typically has the same value as the count that is used to generate the tick values.
    /// If there are too many ticks, the formatter may return the empty string for some of the tick labels;
    /// however, note that the ticks are still shown.
    /// To disable filtering, specify a count of Infinity. When specifying a count, you may also provide a format specifier or format function.
    /// For example, to get a tick formatter that will display 20 ticks of a currency, say log.tickFormat(20, "$,f").
    /// If the specifier does not have a defined precision, the precision will be set automatically by the scale, returning the appropriate format.
    /// This provides a convenient way of specifying a format whose precision will be automatically set by the scale.</summary>
    /// <param name="count">Approximate number of ticks to be used when calculating precision for the number format function.</param>
    /// <param name="specifier">An optional valid format specifier string which allows a custom format where the precision of the format is automatically set by the scale as appropriate for the tick interval.
    /// For example, to get a tick formatter that will display 20 ticks of a currency, say log.tickFormat(20, "$,f").
    /// If the specifier does not have a defined precision, the precision will be set automatically by the scale, returning the appropriate format.
    /// This provides a convenient way of specifying a format whose precision will be automatically set by the scale.</param>
    abstract tickFormat: ?count: float * ?specifier: string -> (U2<float, ScaleContinuousNumericInvoke> -> string)
    /// Returns the current constant, which defaults to 1.
    abstract constant: unit -> float
    /// Sets the symlog constant to the specified number and returns this scale;
    /// otherwise returns the current value of the symlog constant, which defaults to 1. See “A bi-symmetric log transformation for wide-range data” by Webber for more.
    abstract constant: constant: float -> ScaleSymLog<'Range, 'Output>

/// Identity scales are a special case of linear scales where the domain and range are identical; the scale and its invert method are thus the identity function.
/// These scales are occasionally useful when working with pixel coordinates, say in conjunction with an axis or brush.
and [<AllowNullLiteral>] ScaleIdentity =
    /// <summary>Given a value from the domain, returns the corresponding value from the range, subject to interpolation, if any.
    /// 
    /// If the given value is outside the domain, and clamping is not enabled, the mapping may be extrapolated such that the returned value is outside the range.
    /// 
    /// Note: The interpolation function applied by the scale may change the output type from the range type as part of the interpolation.</summary>
    /// <param name="value">A numeric value from the domain.</param>
    [<Emit "$0($1...)">] abstract Invoke: value: U2<float, ScaleContinuousNumericInvoke> -> float
    /// <summary>Given a value from the range, returns the corresponding value from the domain. Inversion is useful for interaction,
    /// say to determine the data value corresponding to the position of the mouse.
    /// 
    /// If the given value is outside the range, and clamping is not enabled, the mapping may be extrapolated such that the returned value is outside the domain.
    /// 
    /// IMPORTANT: This method is only supported if the range is numeric. If the range is not numeric, returns NaN.
    /// 
    /// For a valid value y in the range, continuous(continuous.invert(y)) approximately equals y;
    /// similarly, for a valid value x in the domain, continuous.invert(continuous(x)) approximately equals x.
    /// The scale and its inverse may not be exact due to the limitations of floating point precision.</summary>
    /// <param name="value">A numeric value from the range.</param>
    abstract invert: value: U2<float, ScaleContinuousNumericInvoke> -> float
    /// Returns a copy of the scale’s current domain.
    abstract domain: unit -> Array<float>
    /// <summary>Sets the scale’s domain to the specified array of numbers. The array must contain two or more elements.
    /// If the elements in the given array are not numbers, they will be coerced to numbers
    /// 
    /// Although continuous scales typically have two values each in their domain and range, specifying more than two values produces a piecewise scale.
    /// 
    /// Internally, a piecewise scale performs a binary search for the range interpolator corresponding to the given domain value.
    /// Thus, the domain must be in ascending or descending order. If the domain and range have different lengths N and M, only the first min(N,M) elements in each are observed.</summary>
    /// <param name="domain">Array of numeric domain values.</param>
    abstract domain: domain: Array<U2<float, ScaleContinuousNumericInvoke>> -> ScaleIdentity
    /// Returns a copy of the scale’s current range.
    abstract range: unit -> Array<float>
    /// <summary>Sets the scale’s range to the specified array of values.
    /// 
    /// The array must contain two or more elements. Unlike the domain, elements in the given array need not be numbers;
    /// any value that is supported by the underlying interpolator will work, though note that numeric ranges are required for invert.</summary>
    /// <param name="range">Array of range values.</param>
    abstract range: range: Array<U2<float, ScaleContinuousNumericInvoke>> -> ScaleIdentity
    /// <summary>Returns approximately count representative values from the scale’s domain.
    /// 
    /// If count is not specified, it defaults to 10.
    /// 
    /// The returned tick values are uniformly spaced, have human-readable values (such as multiples of powers of 10),
    /// and are guaranteed to be within the extent of the domain. Ticks are often used to display reference lines, or tick marks, in conjunction with the visualized data.
    /// The specified count is only a hint; the scale may return more or fewer values depending on the domain. See also d3-array’s ticks.</summary>
    /// <param name="count">Optional approximate number of ticks to be returned. If count is not specified, it defaults to 10.</param>
    abstract ticks: ?count: float -> Array<float>
    /// <summary>Returns a number format function suitable for displaying a tick value, automatically computing the appropriate precision based on the fixed interval between tick values.
    /// The specified count should have the same value as the count that is used to generate the tick values.</summary>
    /// <param name="count">Approximate number of ticks to be used when calculating precision for the number format function.</param>
    /// <param name="specifier">An optional valid format specifier string which allows a custom format where the precision of the format is automatically set by the scale as appropriate for the tick interval.
    /// If specifier uses the format type "s", the scale will return a SI-prefix format based on the largest value in the domain.
    /// If the specifier already specifies a precision, this method is equivalent to locale.format.</param>
    abstract tickFormat: ?count: float * ?specifier: string -> (U2<float, ScaleContinuousNumericInvoke> -> string)
    /// <summary>Extends the domain so that it starts and ends on nice round values.
    /// This method typically modifies the scale’s domain, and may only extend the bounds to the nearest round value.
    /// An optional tick count argument allows greater control over the step size used to extend the bounds,
    /// guaranteeing that the returned ticks will exactly cover the domain.
    /// Nicing is useful if the domain is computed from data, say using extent, and may be irregular.
    /// For example, for a domain of [0.201479…, 0.996679…], a nice domain might be [0.2, 1.0].
    /// If the domain has more than two values, nicing the domain only affects the first and last value.
    /// 
    /// Nicing a scale only modifies the current domain; it does not automatically nice domains that are subsequently set using continuous.domain.
    /// You must re-nice the scale after setting the new domain, if desired.</summary>
    /// <param name="count">An optional number of ticks expected to be used.</param>
    abstract nice: ?count: float -> ScaleIdentity
    /// Returns an exact copy of this scale. Changes to this scale will not affect the returned scale, and vice versa.
    abstract copy: unit -> ScaleIdentity

/// A linear scale defined over a temporal domain.
/// 
/// Time scales implement ticks based on calendar intervals, taking the pain out of generating axes for temporal domains.
/// 
/// If the range is numeric, the mapping may be inverted to return a date.
/// 
/// Note that the data types of the range and output of the scale must be compatible with the interpolator applied by the scale.
/// 
/// The first generic corresponds to the data type of the range elements.
/// 
/// The second generic corresponds to the data type of the output elements generated by the scale.
/// 
/// If range element and output element type differ, the interpolator factory used with the scale must match this behavior and
/// convert the interpolated range element to a corresponding output element.
and [<AllowNullLiteral>] ScaleTime<'Range, 'Output> =
    /// <summary>Given a value from the domain, returns the corresponding value from the range, subject to interpolation, if any.
    /// 
    /// If the given value is outside the domain, and clamping is not enabled, the mapping may be extrapolated such that the returned value is outside the range.
    /// 
    /// Note: The interpolation function applied by the scale may change the output type from the range type as part of the interpolation.</summary>
    /// <param name="value">A temporal value from the domain. If the value is not a Date, it will be coerced to Date.</param>
    [<Emit "$0($1...)">] abstract Invoke: value: U3<DateTime, float, ScaleContinuousNumericInvoke> -> 'Output
    /// <summary>Given a value from the range, returns the corresponding value from the domain. Inversion is useful for interaction,
    /// say to determine the data value corresponding to the position of the mouse.
    /// 
    /// If the given value is outside the range, and clamping is not enabled, the mapping may be extrapolated such that the returned value is outside the domain.
    /// 
    /// IMPORTANT: This method is only supported if the range is numeric. If the range is not numeric, returns Invalid Date.
    /// 
    /// For a valid value y in the range, time(time.invert(y)) equals y; similarly, for a valid value x in the domain, time.invert(time(x)) equals x.
    /// The invert method is useful for interaction, say to determine the value in the domain that corresponds to the pixel location under the mouse.</summary>
    /// <param name="value">A numeric value from the range.</param>
    abstract invert: value: U2<float, ScaleContinuousNumericInvoke> -> DateTime
    /// Returns a copy of the scale’s current domain.
    abstract domain: unit -> Array<DateTime>
    /// <summary>Sets the scale’s domain to the specified array of temporal domain values. The array must contain two or more elements.
    /// If the elements in the given array are not dates, they will be coerced to dates.
    /// 
    /// Although continuous scales typically have two values each in their domain and range, specifying more than two values produces a piecewise scale.
    /// 
    /// Internally, a piecewise scale performs a binary search for the range interpolator corresponding to the given domain value.
    /// Thus, the domain must be in ascending or descending order. If the domain and range have different lengths N and M, only the first min(N,M) elements in each are observed.</summary>
    /// <param name="domain">Array of temporal domain values. Numeric values will be coerced to dates.</param>
    abstract domain: domain: Array<U3<DateTime, float, ScaleContinuousNumericInvoke>> -> ScaleTime<'Range, 'Output>
    /// Returns a copy of the scale’s current range.
    abstract range: unit -> Array<'Range>
    /// <summary>Sets the scale’s range to the specified array of values.
    /// 
    /// The array must contain two or more elements. Unlike the domain, elements in the given array need not be temporal domain values;
    /// any value that is supported by the underlying interpolator will work, though note that numeric ranges are required for invert.</summary>
    /// <param name="range">Array of range values.</param>
    abstract range: range: Array<'Range> -> ScaleTime<'Range, 'Output>
    /// <summary>Sets the scale’s range to the specified array of values while also setting the scale’s interpolator to interpolateRound.
    /// 
    /// The rounding interpolator is sometimes useful for avoiding antialiasing artifacts,
    /// though also consider the shape-rendering “crispEdges” styles. Note that this interpolator can only be used with numeric ranges.
    /// 
    /// The array must contain two or more elements. Unlike the domain, elements in the given array need not be temporal domain values;
    /// any value that is supported by the underlying interpolator will work, though note that numeric ranges are required for invert.</summary>
    /// <param name="range">Array of range values.</param>
    abstract rangeRound: range: Array<U2<float, ScaleContinuousNumericInvoke>> -> ScaleTime<'Range, 'Output>
    /// Returns whether or not the scale currently clamps values to within the range.
    abstract clamp: unit -> bool
    /// <summary>Enables or disables clamping, respectively. If clamping is disabled and the scale is passed a value outside the domain,
    /// the scale may return a value outside the range through extrapolation.
    /// 
    /// If clamping is enabled, the return value of the scale is always within the scale’s range. Clamping similarly applies to the "invert" method.</summary>
    /// <param name="clamp">A flag to enable (true) or disable (false) clamping.</param>
    abstract clamp: clamp: bool -> ScaleTime<'Range, 'Output>
    /// Returns the scale’s current interpolator factory, which defaults to interpolate.
    abstract interpolate: unit -> InterpolatorFactory<obj option, obj option>
    /// <summary>Sets the scale’s range interpolator factory. This interpolator factory is used to create interpolators for each adjacent pair of values from the range;
    /// these interpolators then map a normalized domain parameter t in [0, 1] to the corresponding value in the range.
    /// 
    /// Note: the default interpolator may reuse return values. For example, if the range values are objects, then the value interpolator always returns the same object, modifying it in-place.
    /// If the scale is used to set an attribute or style, this is typically acceptable (and desirable for performance);
    /// however, if you need to store the scale’s return value, you must specify your own interpolator or make a copy as appropriate.
    /// 
    /// As part of the interpolation process the interpolated value from the range may be converted to a corresponding output value.</summary>
    /// <param name="interpolate">An interpolation factory. The generics for Range and Output of the scale must correspond to the interpolation factory applied to the scale.</param>
    abstract interpolate: interpolate: InterpolatorFactory<'Range, 'Output> -> ScaleTime<'Range, 'Output>
    /// <summary>Sets the scale’s range interpolator factory. This interpolator factory is used to create interpolators for each adjacent pair of values from the range;
    /// these interpolators then map a normalized domain parameter t in [0, 1] to the corresponding value in the range.
    /// 
    /// Note: the default interpolator may reuse return values. For example, if the range values are objects, then the value interpolator always returns the same object, modifying it in-place.
    /// If the scale is used to set an attribute or style, this is typically acceptable (and desirable for performance);
    /// however, if you need to store the scale’s return value, you must specify your own interpolator or make a copy as appropriate.
    /// 
    /// As part of the interpolation process the interpolated value from the range may be converted to a corresponding output value.
    /// 
    /// The generic "NewOutput" can be used to change the scale to have a different output element type corresponding to the new interpolation factory.</summary>
    /// <param name="interpolate">An interpolation factory. The generics for Range and Output of the scale must correspond to the interpolation factory applied to the scale.</param>
    abstract interpolate: interpolate: InterpolatorFactory<'Range, 'NewOutput> -> ScaleTime<'Range, 'NewOutput>
    /// Returns representative dates from the scale’s domain. The returned tick values are uniformly-spaced (mostly),
    /// have sensible values (such as every day at midnight), and are guaranteed to be within the extent of the domain.
    /// Ticks are often used to display reference lines, or tick marks, in conjunction with the visualized data.
    /// 
    /// Without specifying a count or time interval to control the number of ticks returned, a default count of 10 is used.
    /// The specified count is only a hint; the scale may return more or fewer values depending on the domain.
    abstract ticks: unit -> Array<DateTime>
    /// <summary>Returns representative dates from the scale’s domain. The returned tick values are uniformly-spaced (mostly),
    /// have sensible values (such as every day at midnight), and are guaranteed to be within the extent of the domain.
    /// Ticks are often used to display reference lines, or tick marks, in conjunction with the visualized data.
    /// 
    /// The specified count controls the number of ticks to be returned. The specified count is only a hint;
    /// the scale may return more or fewer values depending on the domain.</summary>
    /// <param name="count">Expected number of ticks.</param>
    abstract ticks: count: float -> Array<DateTime>
    /// <summary>Returns representative dates from the scale’s domain. The returned tick values are uniformly-spaced (mostly),
    /// have sensible values (such as every day at midnight), and are guaranteed to be within the extent of the domain.
    /// Ticks are often used to display reference lines, or tick marks, in conjunction with the visualized data.
    /// 
    /// The specified time interval controls the ticks generated and returned. To prune the generated ticks for a given time interval,
    /// use interval.every(...) or interval.filter(...).</summary>
    /// <param name="interval">A time interval to specify the expected ticks.</param>
    abstract ticks: interval: TimeInterval -> Array<DateTime>
    /// Returns a time format function suitable for displaying tick values.
    /// 
    /// The default multi-scale time format chooses a human-readable representation based on the specified date as follows:
    /// 
    ///   - %Y - for year boundaries, such as 2011.
    ///   - %B - for month boundaries, such as February.
    ///   - %b %d - for week boundaries, such as Feb 06.
    ///   - %a %d - for day boundaries, such as Mon 07.
    ///   - %I %p - for hour boundaries, such as 01 AM.
    ///   - %I:%M - for minute boundaries, such as 01:23.
    ///   - :%S - for second boundaries, such as :45.
    ///   - .%L - milliseconds for all other times, such as .012.
    /// 
    /// Although somewhat unusual, this default behavior has the benefit of providing both local and global context:
    /// for example, formatting a sequence of ticks as [11 PM, Mon 07, 01 AM] reveals information about hours, dates, and day simultaneously,
    /// rather than just the hours [11 PM, 12 AM, 01 AM].
    abstract tickFormat: unit -> (DateTime -> string)
    /// <summary>Returns a time format function suitable for displaying tick values.
    /// 
    /// The specified count is currently ignored, but is accepted for consistency with other scales such as continuous.tickFormat.</summary>
    /// <param name="count">Expected number of ticks. (Currently ignored)</param>
    /// <param name="specifier">An optional valid date format specifier string (see d3-time-format).</param>
    abstract tickFormat: count: float * ?specifier: string -> (DateTime -> string)
    /// <summary>Returns a time format function suitable for displaying tick values.
    /// 
    /// The specified time interval is currently ignored, but is accepted for consistency with other scales such as continuous.tickFormat.</summary>
    /// <param name="interval">A time interval to specify the expected ticks. (Currently ignored)</param>
    /// <param name="specifier">An optional valid date format specifier string (see d3-time-format).</param>
    abstract tickFormat: interval: TimeInterval * ?specifier: string -> (DateTime -> string)
    /// Extends the domain so that it starts and ends on nice round values.
    /// This method typically modifies the scale’s domain, and may only extend the bounds to the nearest round value.
    /// 
    /// Nicing is useful if the domain is computed from data, say using extent, and may be irregular.
    /// For example, for a domain of [2009-07-13T00:02, 2009-07-13T23:48], the nice domain is [2009-07-13, 2009-07-14].
    /// If the domain has more than two values, nicing the domain only affects the first and last value.
    abstract nice: unit -> ScaleTime<'Range, 'Output>
    /// <summary>Extends the domain so that it starts and ends on nice round values.
    /// This method typically modifies the scale’s domain, and may only extend the bounds to the nearest round value.
    /// 
    /// A tick count argument allows greater control over the step size used to extend the bounds, guaranteeing that the returned ticks will exactly cover the domain.
    /// 
    /// Nicing is useful if the domain is computed from data, say using extent, and may be irregular.
    /// For example, for a domain of [2009-07-13T00:02, 2009-07-13T23:48], the nice domain is [2009-07-13, 2009-07-14].
    /// If the domain has more than two values, nicing the domain only affects the first and last value.</summary>
    /// <param name="count">Expected number of ticks.</param>
    abstract nice: count: float -> ScaleTime<'Range, 'Output>
    /// <summary>Extends the domain so that it starts and ends on nice round values.
    /// This method typically modifies the scale’s domain, and may only extend the bounds to the nearest round value.
    /// 
    /// a time interval may be specified to explicitly set the ticks. If an interval is specified, an optional step may also be specified to skip some ticks.
    /// For example, time.nice(d3.timeSecond, 10) will extend the domain to an even ten seconds (0, 10, 20, etc.).
    /// 
    /// Nicing is useful if the domain is computed from data, say using extent, and may be irregular.
    /// For example, for a domain of [2009-07-13T00:02, 2009-07-13T23:48], the nice domain is [2009-07-13, 2009-07-14].
    /// If the domain has more than two values, nicing the domain only affects the first and last value.</summary>
    /// <param name="interval">A time interval to specify the expected ticks.</param>
    /// <param name="step">An optional step number to be applied to the time interval when considering ticks.</param>
    abstract nice: interval: CountableTimeInterval * ?step: float -> ScaleTime<'Range, 'Output>
    /// Returns an exact copy of this scale. Changes to this scale will not affect the returned scale, and vice versa.
    abstract copy: unit -> ScaleTime<'Range, 'Output>

/// Sequential scales are similar to continuous scales in that they map a continuous,
/// numeric input domain to a continuous output range. However, unlike continuous scales,
/// the output range of a sequential scale is fixed by its interpolator and not configurable.
/// 
/// The generic corresponds to the data type of the output of the interpolator underlying the scale.
and [<AllowNullLiteral>] ScaleSequential<'Output> =
    /// <summary>Given a value from the domain, returns the corresponding value from the output range, subject to interpolation.
    /// 
    /// If the given value is outside the domain, and clamping is not enabled, the mapping may be extrapolated such that the returned value is outside the range.</summary>
    /// <param name="value">A numeric value from the domain.</param>
    [<Emit "$0($1...)">] abstract Invoke: value: U2<float, ScaleContinuousNumericInvoke> -> 'Output
    /// Returns a copy of the scale’s current domain.
    abstract domain: unit -> float * float
    /// <summary>Sets the scale’s domain to the specified array of numbers. The array must contain exactly two elements.
    /// If the elements in the given array are not numbers, they will be coerced to numbers</summary>
    /// <param name="domain">A two-element array of numeric domain values.</param>
    abstract domain: domain: U2<float, ScaleContinuousNumericInvoke> * U2<float, ScaleContinuousNumericInvoke> -> ScaleSequential<'Output>
    /// Returns whether or not the scale currently clamps values to within the range.
    abstract clamp: unit -> bool
    /// <summary>Enables or disables clamping, respectively. If clamping is disabled and the scale is passed a value outside the domain,
    /// the scale may return a value outside the range through extrapolation.
    /// 
    /// If clamping is enabled, the return value of the scale is always within the scale’s range. Clamping similarly applies to the "invert" method.</summary>
    /// <param name="clamp">A flag to enable (true) or disable (false) clamping.</param>
    abstract clamp: clamp: bool -> ScaleSequential<'Output>
    /// Returns the current interpolator underlying the scale.
    abstract interpolator: unit -> (float -> 'Output)
    /// <summary>Sets the scale’s interpolator to the specified function.</summary>
    /// <param name="interpolator">An interpolator function mapping a value from the [0, 1] interval to an output value.</param>
    abstract interpolator: interpolator: (float -> 'Output) -> ScaleSequential<'Output>
    /// <summary>Sets the scale’s interpolator to the specified function.
    /// 
    /// The generic corresponds to a the new output type of the scale. The output type of the scale is determined by the output type of the interpolator function.</summary>
    /// <param name="interpolator">An interpolator function mapping a value from the [0, 1] interval to an output value.</param>
    abstract interpolator: interpolator: (float -> 'NewOutput) -> ScaleSequential<'NewOutput>
    /// Returns an exact copy of this scale. Changes to this scale will not affect the returned scale, and vice versa.
    abstract copy: unit -> ScaleSequential<'Output>

/// Diverging scales, like sequential scales, are similar to continuous scales in that they map a continuous, numeric input domain to a continuous output range.
/// However, unlike continuous scales, the output range of a diverging scale is fixed by its interpolator and not configurable.
/// These scales do not expose invert, range, rangeRound and interpolate methods.
/// 
/// The generic corresponds to the data type of the interpolator return type.
and [<AllowNullLiteral>] ScaleDiverging<'Output> =
    /// <summary>Given a value from the domain, returns the corresponding value subject to interpolation.
    /// 
    /// If the given value is outside the domain, and clamping is not enabled, the mapping may be extrapolated such that the returned value is outside the range.</summary>
    /// <param name="value">A numeric value from the domain.</param>
    [<Emit "$0($1...)">] abstract Invoke: value: U2<float, ScaleContinuousNumericInvoke> -> 'Output
    /// Returns a copy of the scale’s current domain.
    abstract domain: unit -> float * float * float
    /// <summary>Sets the scale’s domain to the specified array of numbers.
    /// The domain must be numeric and must contain exactly three values. The default domain is [0, 0.5, 1].
    /// If the elements in the given array are not numbers, they will be coerced to numbers</summary>
    /// <param name="domain">Array of three numeric domain values.</param>
    abstract domain: domain: U2<float, ScaleContinuousNumericInvoke> * U2<float, ScaleContinuousNumericInvoke> * U2<float, ScaleContinuousNumericInvoke> -> ScaleDiverging<'Output>
    /// Returns whether or not the scale currently clamps values to within the range.
    abstract clamp: unit -> bool
    /// <summary>Enables or disables clamping, respectively. If clamping is disabled and the scale is passed a value outside the domain,
    /// the scale may return a value outside the range through extrapolation.
    /// 
    /// If clamping is enabled, the return value of the scale is always within the interpolator scale’s range.</summary>
    /// <param name="clamp">A flag to enable (true) or disable (false) clamping.</param>
    abstract clamp: clamp: bool -> ScaleDiverging<'Output>
    /// Returns the scale’s current interpolator.
    abstract interpolator: unit -> (float -> 'Output)
    /// <summary>Sets the scale’s interpolator to the specified function.</summary>
    /// <param name="interpolator">The scale’s interpolator.</param>
    abstract interpolator: ?interpolator: (float -> 'Output) -> ScaleDiverging<'Output>
    /// Returns an exact copy of this scale. Changes to this scale will not affect the returned scale, and vice versa.
    abstract copy: unit -> ScaleDiverging<'Output>

/// Quantize scales are similar to linear scales, except they use a discrete rather than continuous range.
/// The continuous input domain is divided into uniform segments based on the number of values in (i.e., the cardinality of) the output range.
/// 
/// Each range value y can be expressed as a quantized linear function of the domain value x: y = m round(x) + b.
/// 
/// The generic corresponds to the data type of the range elements.
and [<AllowNullLiteral>] ScaleQuantize<'Range> =
    /// Given a value in the input domain, returns the corresponding value in the output range.
    [<Emit "$0($1...)">] abstract Invoke: value: U2<float, ScaleContinuousNumericInvoke> -> 'Range
    /// <summary>Returns the extent of values in the domain [x0, x1] for the corresponding value in the range: the inverse of quantize.
    /// This method is useful for interaction, say to determine the value in the domain that corresponds to the pixel location under the mouse.
    /// 
    /// If an invalid range value is entered, returns [NaN, NaN].</summary>
    /// <param name="value">A value from the range.</param>
    abstract invertExtent: value: 'Range -> float * float
    /// Returns the scale’s current domain.
    abstract domain: unit -> float * float
    /// <summary>Sets the scale’s domain to the specified two-element array of numbers.
    /// If the elements in the given array are not numbers, they will be coerced to numbers.</summary>
    /// <param name="domain">A two-element array of numeric values defining the domain.</param>
    abstract domain: domain: U2<float, ScaleContinuousNumericInvoke> * U2<float, ScaleContinuousNumericInvoke> -> ScaleQuantize<'Range>
    /// Returns the scale’s current range.
    abstract range: unit -> Array<'Range>
    /// <summary>Sets the scale’s range to the specified array of values. The array may contain any number of discrete values.</summary>
    /// <param name="range">Array of range values.</param>
    abstract range: range: Array<'Range> -> ScaleQuantize<'Range>
    /// <summary>Returns approximately count representative values from the scale’s domain.
    /// 
    /// If count is not specified, it defaults to 10.
    /// 
    /// The returned tick values are uniformly spaced, have human-readable values (such as multiples of powers of 10),
    /// and are guaranteed to be within the extent of the domain. Ticks are often used to display reference lines, or tick marks, in conjunction with the visualized data.
    /// The specified count is only a hint; the scale may return more or fewer values depending on the domain. See also d3-array’s ticks.</summary>
    /// <param name="count">Optional approximate number of ticks to be returned. If count is not specified, it defaults to 10.</param>
    abstract ticks: ?count: float -> Array<float>
    /// <summary>Returns a number format function suitable for displaying a tick value, automatically computing the appropriate precision based on the fixed interval between tick values.
    /// The specified count should have the same value as the count that is used to generate the tick values.</summary>
    /// <param name="count">Approximate number of ticks to be used when calculating precision for the number format function.</param>
    /// <param name="specifier">An optional valid format specifier string which allows a custom format where the precision of the format is automatically set by the scale as appropriate for the tick interval.
    /// If specifier uses the format type "s", the scale will return a SI-prefix format based on the largest value in the domain.
    /// If the specifier already specifies a precision, this method is equivalent to locale.format.</param>
    abstract tickFormat: ?count: float * ?specifier: string -> (U2<float, ScaleContinuousNumericInvoke> -> string)
    /// <summary>Extends the domain so that it starts and ends on nice round values.
    /// This method typically modifies the scale’s domain, and may only extend the bounds to the nearest round value.
    /// 
    /// Nicing is useful if the domain is computed from data, say using extent, and may be irregular.
    /// For example, for a domain of [0.201479…, 0.996679…], a nice domain might be [0.2, 1.0].
    /// 
    /// Nicing a scale only modifies the current domain; it does not automatically nice domains that are subsequently set using continuous.domain.
    /// You must re-nice the scale after setting the new domain, if desired.</summary>
    /// <param name="count">An optional number of ticks expected to be used.</param>
    abstract nice: ?count: float -> ScaleQuantize<'Range>
    /// Returns an exact copy of this scale. Changes to this scale will not affect the returned scale, and vice versa.
    abstract copy: unit -> ScaleQuantize<'Range>

/// Quantile scales map a sampled input domain to a discrete range.
/// The domain is considered continuous and thus the scale will accept any reasonable input value;
/// however, the domain is specified as a discrete set of sample values.
/// The number of values in (the cardinality of) the output range determines the number of quantiles that will be computed from the domain.
/// To compute the quantiles, the domain is sorted, and treated as a population of discrete values; see d3-array’s quantile.
/// 
/// The generic corresponds to the data type of range elements.
and [<AllowNullLiteral>] ScaleQuantile<'Range> =
    /// <summary>Given a value in the input domain, returns the corresponding value in the output range.</summary>
    /// <param name="value">A numeric value in the input domain.</param>
    [<Emit "$0($1...)">] abstract Invoke: value: U2<float, ScaleContinuousNumericInvoke> -> 'Range
    /// <summary>Returns the extent of values in the domain [x0, x1] for the corresponding value in the range: the inverse of quantile.
    /// This method is useful for interaction, say to determine the value in the domain that corresponds to the pixel location under the mouse.</summary>
    /// <param name="value">A value from the range.</param>
    abstract invertExtent: value: 'Range -> float * float
    /// Returns the scale’s current domain.
    abstract domain: unit -> Array<float>
    /// <summary>Sets the domain of the quantile scale to the specified set of discrete numeric values.
    /// The array must not be empty, and must contain at least one numeric value; NaN, null and undefined values are ignored and not considered part of the sample population.
    /// 
    /// If the elements in the given array are not numbers, they will be coerced to numbers. A copy of the input array is sorted and stored internally.</summary>
    /// <param name="domain">Array of domain values.</param>
    abstract domain: domain: Array<U2<float, ScaleContinuousNumericInvoke> option> -> ScaleQuantile<'Range>
    /// Returns the current range.
    abstract range: unit -> Array<'Range>
    /// <summary>Sets the discrete values in the range. The array must not be empty.
    /// The number of values in (the cardinality, or length, of) the range array determines the number of quantiles that are computed.
    /// 
    /// For example, to compute quartiles, range must be an array of four elements such as [0, 1, 2, 3].</summary>
    /// <param name="range">Array of range values.</param>
    abstract range: range: Array<'Range> -> ScaleQuantile<'Range>
    /// Returns the quantile thresholds. If the range contains n discrete values, the returned array will contain n - 1 thresholds.
    /// Values less than the first threshold are considered in the first quantile;
    /// values greater than or equal to the first threshold but less than the second threshold are in the second quantile, and so on.
    /// Internally, the thresholds array is used with bisect to find the output quantile associated with the given input value.
    abstract quantiles: unit -> Array<float>
    /// Returns an exact copy of this scale. Changes to this scale will not affect the returned scale, and vice versa.
    abstract copy: unit -> ScaleQuantile<'Range>

/// Threshold scales are similar to quantize scales, except they allow you to map arbitrary subsets of the domain to discrete values in the range.
/// The input domain is still continuous, and divided into slices based on a set of threshold values.
/// 
/// If the number of values in the scale’s range is N+1, the number of values in the scale’s domain must be N.
/// If there are fewer than N elements in the domain, the additional values in the range are ignored.
/// If there are more than N elements in the domain, the scale may return undefined for some inputs.
/// 
/// The first generic corresponds to the data type of domain values.
/// The second generic corresponds to the data type of range values.
and [<AllowNullLiteral>] ScaleThreshold<'Domain, 'Range> =
    /// <summary>Given a value in the input domain, returns the corresponding value in the output range.</summary>
    /// <param name="value">A domain value.</param>
    [<Emit "$0($1...)">] abstract Invoke: value: 'Domain -> 'Range
    /// <summary>Returns the extent of values in the domain [x0, x1] for the corresponding value in the range, representing the inverse mapping from range to domain.
    /// This method is useful for interaction, say to determine the value in the domain that corresponds to the pixel location under the mouse.</summary>
    /// <param name="value">A range value.</param>
    abstract invertExtent: value: 'Range -> 'Domain option * 'Domain option
    /// Returns the scale’s current domain.
    abstract domain: unit -> Array<'Domain>
    /// <summary>Sets the scale’s domain to the specified array of values. The values must be in sorted ascending order, or the behavior of the scale is undefined.
    /// The values are typically numbers, but any naturally ordered values (such as strings) will work; a threshold scale can be used to encode any type that is ordered.
    /// If the number of values in the scale’s range is N+1, the number of values in the scale’s domain must be N.
    /// If there are fewer than N elements in the domain, the additional values in the range are ignored.
    /// If there are more than N elements in the domain, the scale may return undefined for some inputs.</summary>
    /// <param name="domain">Array of domain values.</param>
    abstract domain: domain: Array<'Domain> -> ScaleThreshold<'Domain, 'Range>
    /// Returns the scale’s current range.
    abstract range: unit -> Array<'Range>
    /// <summary>Sets the scale’s range to the specified array of values. If the number of values in the scale’s domain is N, the number of values in the scale’s range must be N+1.
    /// If there are fewer than N+1 elements in the range, the scale may return undefined for some inputs.
    /// If there are more than N+1 elements in the range, the additional values are ignored.</summary>
    /// <param name="range">Array of range values.</param>
    abstract range: range: Array<'Range> -> ScaleThreshold<'Domain, 'Range>
    /// Returns an exact copy of this scale. Changes to this scale will not affect the returned scale, and vice versa.
    abstract copy: unit -> ScaleThreshold<'Domain, 'Range>

/// Unlike continuous scales, ordinal scales have a discrete domain and range. For example, an ordinal scale might map a set of named categories to a set of colors,
/// or determine the horizontal positions of columns in a column chart.
/// 
/// The first element in the domain will be mapped to the first element in range, the second domain value to the second range value, and so on.
/// If there are fewer elements in the range than in the domain, the scale will reuse values from the start of the range.
/// 
/// The first generic corresponds to the data type of domain values.
/// The second generic corresponds to the data type of range values.
type [<AllowNullLiteral>] ScaleOrdinal<'Domain, 'Range> =
    /// <summary>Given a value in the input domain, returns the corresponding value in the output range.
    /// If the given value is not in the scale’s domain, returns the unknown; or, if the unknown value is implicit (the default),
    /// then the value is implicitly added to the domain and the next-available value in the range is assigned to value,
    /// such that this and subsequent invocations of the scale given the same input value return the same output value.</summary>
    /// <param name="x">A value from the domain.</param>
    [<Emit "$0($1...)">] abstract Invoke: x: 'Domain -> 'Range
    /// Returns the scale's current domain.
    abstract domain: unit -> Array<'Domain>
    /// <summary>Sets the domain to the specified array of values.
    /// 
    /// The first element in domain will be mapped to the first element in the range,
    /// the second domain value to the second range value, and so on.
    /// 
    /// Domain values are stored internally in a map from stringified value to index; the resulting index is then used to retrieve a value from the range.
    /// Thus, an ordinal scale’s values must be coercible to a string, and the stringified version of the domain value uniquely identifies the corresponding range value.
    /// 
    /// Setting the domain on an ordinal scale is optional if the unknown value is implicit (the default).
    /// In this case, the domain will be inferred implicitly from usage by assigning each unique value passed to the scale a new value from the range.
    /// Note that an explicit domain is recommended to ensure deterministic behavior, as inferring the domain from usage will be dependent on ordering.</summary>
    /// <param name="domain">Array of domain values.</param>
    abstract domain: domain: Array<'Domain> -> ScaleOrdinal<'Domain, 'Range>
    /// Returns the scale's current range.
    abstract range: unit -> Array<'Range>
    /// <summary>Sets the range of the ordinal scale to the specified array of values.
    /// 
    /// The first element in the domain will be mapped to the first element in range, the second domain value to the second range value, and so on.
    /// 
    /// If there are fewer elements in the range than in the domain, the scale will reuse values from the start of the range.</summary>
    /// <param name="range">Array of range values.</param>
    abstract range: range: Array<'Range> -> ScaleOrdinal<'Domain, 'Range>
    /// Returns the current unknown value, which defaults to "implicit".
    abstract unknown: unit -> U2<'Range, ScaleImplicit>
    /// <summary>Sets the output value of the scale for unknown input values and returns this scale.
    /// The implicit value enables implicit domain construction. scaleImplicit can be used as a convenience to set the implicit value.</summary>
    /// <param name="value">Unknown value to be used or scaleImplicit to set implicit scale generation.</param>
    abstract unknown: value: U2<'Range, ScaleImplicit> -> ScaleOrdinal<'Domain, 'Range>
    /// Returns an exact copy of this ordinal scale. Changes to this scale will not affect the returned scale, and vice versa.
    abstract copy: unit -> ScaleOrdinal<'Domain, 'Range>

/// Band scales are like ordinal scales except the output range is continuous and numeric.
/// Discrete output values are automatically computed by the scale by dividing the continuous range into uniform bands.
/// Band scales are typically used for bar charts with an ordinal or categorical dimension.
/// The unknown value of a band scale is effectively undefined: they do not allow implicit domain construction.
/// 
/// The generic corresponds to the data type of domain elements.
and [<AllowNullLiteral>] ScaleBand<'Domain> =
    /// <summary>Given a value in the input domain, returns the start of the corresponding band derived from the output range.
    /// If the given value is not in the scale’s domain, returns undefined.</summary>
    /// <param name="x">A value from the domain.</param>
    [<Emit "$0($1...)">] abstract Invoke: x: 'Domain -> float option
    /// Returns to scale's current domain
    abstract domain: unit -> Array<'Domain>
    /// <summary>Sets the domain to the specified array of values. The first element in domain will be mapped to the first band, the second domain value to the second band, and so on.
    /// Domain values are stored internally in a map from stringified value to index; the resulting index is then used to determine the band.
    /// Thus, a band scale’s values must be coercible to a string, and the stringified version of the domain value uniquely identifies the corresponding band.</summary>
    /// <param name="domain">Array of domain values.</param>
    abstract domain: domain: Array<'Domain> -> ScaleBand<'Domain>
    /// Returns the scale’s current range, which defaults to [0, 1].
    abstract range: unit -> float * float
    /// <summary>Sets the scale’s range to the specified two-element array of numbers. If the elements in the given array are not numbers, they will be coerced to numbers.
    /// The default range is [0, 1].</summary>
    /// <param name="range">A two-element array of numeric values.</param>
    abstract range: range: U2<float, ScaleContinuousNumericInvoke> * U2<float, ScaleContinuousNumericInvoke> -> ScaleBand<'Domain>
    /// <summary>Sets the scale’s range to the specified two-element array of numbers while also enabling rounding.
    /// If the elements in the given array are not numbers, they will be coerced to numbers.
    /// 
    /// Rounding is sometimes useful for avoiding antialiasing artifacts, though also consider the shape-rendering “crispEdges” styles.</summary>
    /// <param name="range">A two-element array of numeric values.</param>
    abstract rangeRound: range: U2<float, ScaleContinuousNumericInvoke> * U2<float, ScaleContinuousNumericInvoke> -> ScaleBand<'Domain>
    /// Returns the current rounding status for the scale: enabled (= true) or disabled (= false).
    abstract round: unit -> bool
    /// <summary>Enables or disables rounding accordingly. If rounding is enabled, the start and stop of each band will be integers.
    /// Rounding is sometimes useful for avoiding antialiasing artifacts, though also consider the shape-rendering “crispEdges” styles.
    /// Note that if the width of the domain is not a multiple of the cardinality of the range, there may be leftover unused space, even without padding!
    /// Use band.align to specify how the leftover space is distributed.</summary>
    /// <param name="round">Enable rounding (= true), disable rounding (= false).</param>
    abstract round: round: bool -> ScaleBand<'Domain>
    /// Returns the current inner padding which defaults to 0.
    abstract paddingInner: unit -> float
    /// <summary>Sets the inner padding to the specified value which must be in the range [0, 1].
    /// The inner padding determines the ratio of the range that is reserved for blank space between bands.
    /// 
    /// The default setting is 0.</summary>
    /// <param name="padding">Value for inner padding in [0, 1] interval.</param>
    abstract paddingInner: padding: float -> ScaleBand<'Domain>
    /// Returns the current outer padding which defaults to 0.
    abstract paddingOuter: unit -> float
    /// <summary>Sets the outer padding to the specified value which must be in the range [0, 1].
    /// The outer padding determines the ratio of the range that is reserved for blank space before the first band and after the last band.
    /// 
    /// The default setting is 0.</summary>
    /// <param name="padding">Value for outer padding in [0, 1] interval.</param>
    abstract paddingOuter: padding: float -> ScaleBand<'Domain>
    /// Returns the inner padding.
    abstract padding: unit -> float
    /// <summary>A convenience method for setting the inner and outer padding to the same padding value.</summary>
    /// <param name="padding">Value for inner and outer padding in [0, 1] interval.</param>
    abstract padding: padding: float -> ScaleBand<'Domain>
    /// Returns the current alignment which defaults to 0.5.
    abstract align: unit -> float
    /// <summary>Sets the alignment to the specified value which must be in the range [0, 1].
    /// 
    /// The default is 0.5.
    /// 
    /// The alignment determines how any leftover unused space in the range is distributed.
    /// A value of 0.5 indicates that the leftover space should be equally distributed before the first band and after the last band;
    /// i.e., the bands should be centered within the range. A value of 0 or 1 may be used to shift the bands to one side, say to position them adjacent to an axis.</summary>
    /// <param name="align">Value for alignment setting in [0, 1] interval.</param>
    abstract align: align: float -> ScaleBand<'Domain>
    /// Returns the width of each band.
    abstract bandwidth: unit -> float
    /// Returns the distance between the starts of adjacent bands.
    abstract step: unit -> float
    /// Returns an exact copy of this scale. Changes to this scale will not affect the returned scale, and vice versa.
    abstract copy: unit -> ScaleBand<'Domain>

/// Point scales are a variant of band scales with the bandwidth fixed to zero.
/// Point scales are typically used for scatterplots with an ordinal or categorical dimension.
/// The unknown value of a point scale is always undefined: they do not allow implicit domain construction.
/// 
/// The generic corresponds to the data type of domain elements.
and [<AllowNullLiteral>] ScalePoint<'Domain> =
    /// <summary>Given a value in the input domain, returns the corresponding point derived from the output range.
    /// If the given value is not in the scale’s domain, returns undefined.</summary>
    /// <param name="x">A value from the domain.</param>
    [<Emit "$0($1...)">] abstract Invoke: x: 'Domain -> float option
    /// Returns the scale's current domain.
    abstract domain: unit -> Array<'Domain>
    /// <summary>Sets the domain to the specified array of values. The first element in domain will be mapped to the first point, the second domain value to the second point, and so on.
    /// Domain values are stored internally in a map from stringified value to index; the resulting index is then used to determine the point.
    /// Thus, a point scale’s values must be coercible to a string, and the stringified version of the domain value uniquely identifies the corresponding point.</summary>
    /// <param name="domain">Array of domain values.</param>
    abstract domain: domain: Array<'Domain> -> ScalePoint<'Domain>
    /// Returns the scale’s current range, which defaults to [0, 1].
    abstract range: unit -> float * float
    /// <summary>Sets the scale’s range to the specified two-element array of numbers.
    /// If the elements in the given array are not numbers, they will be coerced to numbers.
    /// The default range is [0, 1].</summary>
    /// <param name="range">A two-element array of numeric values.</param>
    abstract range: range: U2<float, ScaleContinuousNumericInvoke> * U2<float, ScaleContinuousNumericInvoke> -> ScalePoint<'Domain>
    /// <summary>Sets the scale’s range to the specified two-element array of numbers while also enabling rounding.
    /// If the elements in the given array are not numbers, they will be coerced to numbers.
    /// 
    /// Rounding is sometimes useful for avoiding antialiasing artifacts, though also consider the shape-rendering “crispEdges” styles.</summary>
    /// <param name="range">A two-element array of numeric values.</param>
    abstract rangeRound: range: U2<float, ScaleContinuousNumericInvoke> * U2<float, ScaleContinuousNumericInvoke> -> ScalePoint<'Domain>
    /// Returns the current rounding status for the scale: enabled (= true) or disabled (= false).
    abstract round: unit -> bool
    /// <summary>Enables or disables rounding accordingly. If rounding is enabled, the position of each point will be integers.
    /// Rounding is sometimes useful for avoiding antialiasing artifacts, though also consider the shape-rendering “crispEdges” styles.
    /// Note that if the width of the domain is not a multiple of the cardinality of the range, there may be leftover unused space, even without padding!
    /// Use point.align to specify how the leftover space is distributed.</summary>
    /// <param name="round">Enable rounding (= true), disable rounding (= false).</param>
    abstract round: round: bool -> ScalePoint<'Domain>
    /// Returns the current outer padding which defaults to 0.
    /// The outer padding determines the ratio of the range that is reserved for blank space
    /// before the first point and after the last point.
    abstract padding: unit -> float
    /// <summary>Sets the outer padding to the specified value which must be in the range [0, 1].
    /// The outer padding determines the ratio of the range that is reserved for blank space
    /// before the first point and after the last point.
    /// 
    /// The default is 0.</summary>
    /// <param name="padding">Value for outer padding in [0, 1] interval.</param>
    abstract padding: padding: float -> ScalePoint<'Domain>
    /// Returns the current alignment which defaults to 0.5.
    abstract align: unit -> float
    /// <summary>Sets the alignment to the specified value which must be in the range [0, 1].
    /// 
    /// The alignment determines how any leftover unused space in the range is distributed.
    /// A value of 0.5 indicates that the leftover space should be equally distributed before the first point and after the last point;
    /// i.e., the points should be centered within the range. A value of 0 or 1 may be used to shift the points to one side, say to position them adjacent to an axis.
    /// 
    /// The default value is 0.5.</summary>
    /// <param name="align">Value for alignment setting in [0, 1] interval.</param>
    abstract align: align: float -> ScalePoint<'Domain>
    /// Return 0.
    abstract bandwidth: unit -> float
    /// Returns the distance between the starts of adjacent points.
    abstract step: unit -> float
    /// Returns an exact copy of this scale. Changes to this scale will not affect the returned scale, and vice versa.
    abstract copy: unit -> ScalePoint<'Domain>

