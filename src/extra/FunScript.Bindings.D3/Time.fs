namespace FunScript.Bindings.D3

open System

open FunScript
open FunScript.Bindings

/// A D3 Time Interval
/// A D3 Time Interval
type [<AllowNullLiteral>] TimeInterval =
    /// <summary>Returns a new date representing the latest interval boundary date before or equal to date.
    /// This function is an alias for "TimeInterval.floor(date)". For example, timeYear(date) and timeYear.floor(date) are equivalent.
    /// 
    /// For example, timeDay(date) typically returns 12:00 AM local time on the given date.
    /// 
    /// This function is idempotent: if the specified date is already floored to the current interval,
    /// a new date with an identical time is returned.
    /// Furthermore, the returned date is the minimum expressible value of the associated interval,
    /// such that interval.floor(interval.floor(date) - 1) returns the preceding interval boundary date.
    /// 
    /// Note that the == and === operators do not compare by value with Date objects,
    /// and thus you cannot use them to tell whether the specified date has already been floored.
    /// Instead, coerce to a number and then compare.
    /// 
    /// This is more reliable than testing whether the time is 12:00 AM, as in some time zones midnight may not exist due to daylight saving.</summary>
    /// <param name="date">A date object.</param>
    [<Emit "$0($1...)">] abstract Invoke: date: DateTime -> DateTime
    /// <summary>Returns a new date representing the latest interval boundary date before or equal to date.
    /// 
    /// For example, timeDay.floor(date) typically returns 12:00 AM local time on the given date.
    /// 
    /// This method is idempotent: if the specified date is already floored to the current interval,
    /// a new date with an identical time is returned.
    /// Furthermore, the returned date is the minimum expressible value of the associated interval,
    /// such that interval.floor(interval.floor(date) - 1) returns the preceding interval boundary date.
    /// 
    /// Note that the == and === operators do not compare by value with Date objects,
    /// and thus you cannot use them to tell whether the specified date has already been floored.
    /// Instead, coerce to a number and then compare.
    /// 
    /// This is more reliable than testing whether the time is 12:00 AM, as in some time zones midnight may not exist due to daylight saving.</summary>
    /// <param name="date">A date object.</param>
    abstract floor: date: DateTime -> DateTime
    /// <summary>Returns a new date representing the closest interval boundary date to date.
    /// 
    /// For example, timeDay.round(date) typically returns 12:00 AM local time on the given date if it is on or before noon,
    /// and 12:00 AM of the following day if it is after noon.
    /// 
    /// This method is idempotent: if the specified date is already rounded to the current interval, a new date with an identical time is returned.</summary>
    /// <param name="date">A date object.</param>
    abstract round: date: DateTime -> DateTime
    /// <summary>Returns a new date representing the earliest interval boundary date after or equal to date.
    /// 
    /// For example, timeDay.ceil(date) typically returns 12:00 AM local time on the date following the given date.
    /// 
    /// This method is idempotent: if the specified date is already ceilinged to the current interval,
    /// a new date with an identical time is returned. Furthermore,
    /// the returned date is the maximum expressible value of the associated interval,
    /// such that interval.ceil(interval.ceil(date) + 1) returns the following interval boundary date.</summary>
    /// <param name="date">A date object.</param>
    abstract ceil: date: DateTime -> DateTime
    /// <summary>Returns a new date equal to date plus step intervals.
    /// 
    /// If step is not specified it defaults to 1.
    /// 
    /// This method does not round the specified date to the interval. For example, if date is today at 5:34 PM,
    /// then timeDay.offset(date, 1) returns 5:34 PM tomorrow (even if daylight saving changes!).</summary>
    /// <param name="date">A date object.</param>
    /// <param name="step">An optional number of steps to apply when calculating the offset date.
    /// If step is negative, then the returned date will be before the specified date;
    /// if step is zero, then a copy of the specified date is returned; if step is not an integer, it is floored.</param>
    abstract offset: date: DateTime * ?step: float -> DateTime
    /// <summary>Returns an array of dates representing every interval boundary after or equal to start (inclusive) and before stop (exclusive).
    /// 
    /// If step is specified, then every step-th boundary will be returned; for example,
    /// for the timeDay interval a step of 2 will return every other day.
    /// If step is not an integer, it is floored.
    /// 
    /// The first date in the returned array is the earliest boundary after or equal to start;
    /// subsequent dates are offset by step intervals and floored.
    /// Thus, two overlapping ranges may be inconsistent.
    /// 
    /// To make ranges consistent when a step is specified, use CountableInterval.every instead.</summary>
    /// <param name="start">A start date object for the range.</param>
    /// <param name="stop">A stop date object for the range.</param>
    /// <param name="step">An optional number of steps to apply when calculating the dates in the range.</param>
    abstract range: start: DateTime * stop: DateTime * ?step: float -> ResizeArray<DateTime>
    /// <summary>Returns a new interval that is a filtered subset of this interval using the specified test function.</summary>
    /// <param name="test">A test function which is passed a date and should return true if and only if
    /// the specified date should be considered part of the interval.</param>
    abstract filter: test: (DateTime -> bool) -> TimeInterval

/// A D3 Countable Time Interval
/// A D3 Countable Time Interval
type [<AllowNullLiteral>] CountableTimeInterval =
    inherit TimeInterval
    /// <summary>Returns the number of interval boundaries after start (exclusive) and before or equal to end (inclusive).
    /// 
    /// Note that this behavior is slightly different than interval.range,
    /// because its purpose is to return the zero-based number of the specified end date relative to the specified start date.</summary>
    /// <param name="start">A start date object.</param>
    /// <param name="end">An end date object.</param>
    abstract count: start: DateTime * ``end``: DateTime -> float
    /// <summary>Returns a filtered view of this interval representing every stepth date.
    /// 
    /// The meaning of step is dependent on this interval’s parent interval as defined by the field function.
    /// 
    /// For example, timeMinute.every(15) returns an interval representing every fifteen minutes,
    /// starting on the hour: :00, :15, :30, :45, etc. Note that for some intervals,
    /// the resulting dates may not be uniformly-spaced;
    /// timeDay’s parent interval is timeMonth, and thus the interval number resets at the start of each month.
    /// 
    /// If step is not valid, returns null. If step is one, returns this interval.
    /// 
    /// This method can be used in conjunction with interval.range to ensure that two overlapping ranges are consistent.
    /// 
    /// The returned filtered interval does not support interval.count. See also interval.filter.</summary>
    /// <param name="step">Number of steps.</param>
    abstract every: step: float -> TimeInterval option