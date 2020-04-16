namespace FunScript.Bindings.D3

open System

open FunScript.Bindings

type [<AllowNullLiteral>] D3 =
    
    (* Selection *)
    
    /// <summary>Select the first element that matches the specified selector string. If no elements match the selector, returns an empty selection.
    /// If multiple elements match the selector, only the first matching element (in document order) will be selected.
    /// 
    /// The first generic  "GElement" refers to the type of element to be selected. The second generic "OldDatum" refers to the type of the
    /// datum, on the selected element. This is useful when re-selecting an element with a previously set, know datum type.</summary>
    /// <param name="selector">CSS selector string</param>
    abstract select: selector: string -> Selection<'GElement, 'OldDatum, HTMLElement, obj option>
    /// <summary>Select the specified node element.
    /// 
    /// The first generic  "GElement" refers to the type of element to be selected. The second generic "OldDatum" refers to the type of the
    /// datum, on the selected element. This is useful when re-selecting an element with a previously set, know datum type.</summary>
    /// <param name="node">An element to be selected</param>
    abstract select: node: 'GElement -> Selection<'GElement, 'OldDatum, obj, obj>
    /// Create an empty selection.
    abstract selectAll: unit -> Selection<obj, obj, obj, obj>
    /// Create an empty selection.
   
    /// The first generic "GElement" refers to the type of element to be selected. The second generic "OldDatum" refers to the type of the
    /// datum, of a selected element. This is useful when re-selecting elements with a previously set, know datum type.</summary>
    /// <param name="selector">CSS selector string</param>
    abstract selectAll: selector: string -> Selection<'GElement, 'OldDatum, HTMLElement, obj option>
    /// <summary>Select the specified array of nodes.
    /// 
    /// The first generic "GElement" refers to the type of element to be selected. The second generic "OldDatum" refers to the type of the
    /// datum, of a selected element. This is useful when re-selecting elements with a previously set, know datum type.</summary>
    /// <param name="nodes">An Array of nodes</param>
    abstract selectAll: nodes: ResizeArray<'GElement> -> Selection<'GElement, 'OldDatum, obj, obj>
    /// <summary>Select the specified nodes. This signature allows the selection of nodes contained in a NodeList, HTMLCollection or similar data structure.
    /// 
    /// The first generic "GElement" refers to the type of element to be selected. The second generic "OldDatum" refers to the type of the
    /// datum, of a selected element. This is useful when re-selecting elements with a previously set, know datum type.</summary>
    /// <param name="nodes">An Array-like collection of nodes</param>
    abstract selectAll: nodes: ArrayLike<'GElement> -> Selection<'GElement, 'OldDatum, obj, obj>
    /// <summary>Invokes the specified listener, using the specified "that" as "this" context and passing the specified arguments, if any.
    /// During the invocation, d3.event is set to the specified event; after the listener returns (or throws an error),
    /// d3.event is restored to its previous value.
    /// In addition, sets event.sourceEvent to the prior value of d3.event, allowing custom events to retain a reference to the originating native event.
    /// Returns the value returned by the listener.
    /// 
    /// The first generic "Context" refers to the "this" context type in which the listener will be invoked.
    /// The second generic "Result" specifies the return type of the listener.</summary>
    /// <param name="event">The event to which d3.event will be set during the listener invocation.</param>
    /// <param name="listener">The event listener function to be invoked. This function will be invoked with the "this" context, provided
    /// by the "that" argument of customEvent(...). It will be passed all optional arguments passed to customEvent(...). The function returns
    /// a value corresponding to the type of the second generic type.</param>
    /// <param name="that">The "this"" context which will be used for the invocation of listener.</param>
    /// <param name="args">A list of optional arguments, which will be passed to listener.</param>
    abstract customEvent: ``event``: BaseEvent * listener: ('Context -> ResizeArray<obj option> -> 'Result) * that: 'Context * [<ParamArray>] args: ResizeArray<obj option> -> 'Result
    /// <summary>Get (x, y)-coordinates of the current event relative to the specified container element.
    /// The container may be an HTML or SVG container element, such as a G element or an SVG element.
    /// The coordinates are returned as a two-element array of numbers [x, y].</summary>
    /// <param name="container">Container element relative to which coordinates are calculated.</param>
    abstract mouse: container: ContainerElement -> float * float
    /// <summary>Returns the x and y coordinates of the touch with the specified identifier associated
    /// with the current event relative to the specified container.
    /// The container may be an HTML or SVG container element, such as a G element or an SVG element.
    /// The coordinates are returned as a two-element array of numbers [x, y] or null if there is no touch with
    /// the specified identifier in touches, returns null; this can be useful for ignoring touchmove events
    /// where the only some touches have moved.
    /// 
    /// If touches is not specified, it defaults to the current event’s changedTouches property.</summary>
    /// <param name="container">Container element relative to which coordinates are calculated.</param>
    /// <param name="identifier">Touch Identifier associated with the current event.</param>
    abstract touch: container: ContainerElement * identifier: float -> float * float option
    /// <summary>Return the x and y coordinates of the touch with the specified identifier associated
    /// with the current event relative to the specified container.
    /// The container may be an HTML or SVG container element, such as a G element or an SVG element.
    /// The coordinates are returned as a two-element array of numbers [x, y] or null if there is no touch with
    /// the specified identifier in touches, returns null; this can be useful for ignoring touchmove events
    /// where the only some touches have moved.
    /// 
    /// If touches is not specified, it defaults to the current event’s changedTouches property.</summary>
    /// <param name="container">Container element relative to which coordinates are calculated.</param>
    /// <param name="touches">TouchList to be used when identifying the touch.</param>
    /// <param name="identifier">Touch Identifier associated with the current event.</param>
    abstract touch: container: ContainerElement * touches: TouchList * identifier: float -> float * float option
    /// <summary>Return the x and y coordinates of the touches associated with the current event relative to the specified container.
    /// The container may be an HTML or SVG container element, such as a G element or an SVG element.
    /// The coordinates are returned as an array of two-element arrays of numbers [[x1, y1], [x2, y2], …].
    /// 
    /// If touches is not specified, it defaults to the current event’s touches property.</summary>
    /// <param name="container">Container element relative to which coordinates are calculated.</param>
    /// <param name="touches">TouchList to be used.</param>
    abstract touches: container: ContainerElement * ?touches: TouchList -> Array<float * float>
    /// <summary>Returns the x and y coordinates of the specified event relative to the specified container.
    /// (The event may also be a touch.) The container may be an HTML or SVG container element, such as a G element or an SVG element.
    /// The coordinates are returned as a two-element array of numbers [x, y].</summary>
    /// <param name="container">Container element relative to which coordinates are calculated.</param>
    /// <param name="event">A User interface event (e.g. mouse event, touch or MSGestureEvent) with captured clientX and clientY properties.</param>
    abstract clientPoint: container: ContainerElement * ``event``: ClientPointEvent -> float * float
    /// <summary>Returns the value of the style property with the specified name for the specified node.
    /// If the node has an inline style with the specified name, its value is returned; otherwise, the computed property value is returned.
    /// See also selection.style.</summary>
    /// <param name="node">A DOM node (e.g. HTMLElement, SVGElement) for which to retrieve the style property.</param>
    /// <param name="name">Style property name.</param>
    abstract style: node: Element * name: string -> string
    /// Obtain a new local variable
    /// 
    /// The generic refers to the type of the variable to store locally.
    abstract local: unit -> Local<'T>
    /// <summary>Obtain an object with properties of fully qualified namespace string and
    /// name of local by parsing a shorthand string "prefix:local". If the prefix
    /// does not exist in the "namespaces" object provided by d3-selection, then
    /// the local name is returned as a simple string.</summary>
    /// <param name="prefixedLocal">A string composed of the namespace prefix and local
    /// name separated by colon, e.g. "svg:text".</param>
    abstract ``namespace``: prefixedLocal: string -> U2<NamespaceLocalObject, string>
    /// <summary>Returns the owner window for the specified node. If node is a node, returns the owner document’s default view;
    /// if node is a document, returns its default view; otherwise returns the node.</summary>
    /// <param name="DOMNode">A DOM element</param>
    abstract window: DOMNode: U3<Window, Document, Element> -> Window
    /// <summary>Given the specified element name, returns a single-element selection containing
    /// a detached element of the given name in the current document.</summary>
    /// <param name="name">tag name of the element to be added.</param>
    abstract create: name: 'K -> Selection<ElementTagNameMap, obj, obj, obj>
    /// <summary>Given the specified element name, returns a single-element selection containing
    /// a detached element of the given name in the current document.</summary>
    /// <param name="name">Tag name of the element to be added. See "namespace" for details on supported namespace prefixes,
    /// such as for SVG elements.</param>
    abstract create: name: string -> Selection<'NewGElement, obj, obj, obj>
    /// <summary>Given the specified element name, returns a function which creates an element of the given name,
    /// assuming that "this" is the parent element.</summary>
    /// <param name="name">Tag name of the element to be added.</param>
    abstract creator: name: 'K -> (BaseType -> ElementTagNameMap)
    /// <summary>Given the specified element name, returns a function which creates an element of the given name,
    /// assuming that "this" is the parent element.
    /// 
    /// The generic refers to the type of the new element to be returned by the creator function.</summary>
    /// <param name="name">Tag name of the element to be added. See "namespace" for details on supported namespace prefixes,
    /// such as for SVG elements.</param>
    abstract creator: name: string -> (BaseType -> 'NewGElement)
    /// <summary>Given the specified selector, returns a function which returns true if "this" element matches the specified selector.</summary>
    /// <param name="selector">A CSS selector string.</param>
    abstract matcher: selector: string -> (BaseType -> bool)
    /// <summary>Given the specified selector, returns a function which returns the first descendant of "this" element
    /// that matches the specified selector.
    /// 
    /// The generic refers to the type of the returned descendant element.</summary>
    /// <param name="selector">A CSS selector string.</param>
    abstract selector: selector: string -> (BaseType -> 'DescElement)
    /// <summary>Given the specified selector, returns a function which returns all descendants of "this" element that match the specified selector.
    /// 
    /// The generic refers to the type of the returned descendant element.</summary>
    /// <param name="selector">A CSS selector string.</param>
    abstract selectorAll: selector: string -> (BaseType -> NodeListOf<'DescElement>)

    (* Transition *)

    /// <summary>Return the active transition on the specified node with the specified name, if any.
    /// If no name is specified, null is used. Returns null if there is no such active transition on the specified node.
    /// This method is useful for creating chained transitions.
    /// 
    /// The first generic "GElement" refers to the type of element on which the returned active transition was defined. The second generic "Datum" refers to the type of the
    /// datum, of a selected element on which the transition is defined. The third generic refers to the type of the parent elements in the returned Transition.
    /// The fourth generic refers to the type of the datum defined on the parent elements in the returned Transition.</summary>
    /// <param name="node">Element for which the active transition should be returned.</param>
    /// <param name="name">Name of the transition.</param>
    abstract active: node: 'GElement * ?name: string -> Transition<'GElement, 'Datum, 'PElement, 'PDatum> option
    /// <summary>Interrupts the active transition of the specified name on the specified node, and cancels any pending transitions with the specified name, if any.
    /// If a name is not specified, null is used.</summary>
    /// <param name="node">Element for which the transition should be interrupted.</param>
    /// <param name="name">Name of the transition to be interrupted. If a name is not specified, null is used.</param>
    abstract interrupt: node: BaseType * ?name: string -> unit
    /// <summary>Returns a new transition with the specified name. If a name is not specified, null is used.
    /// The new transition is only exclusive with other transitions of the same name.
    /// 
    /// The generic "OldDatum" refers to the type of a previously-set datum of the selected HTML element in the Transition.</summary>
    /// <param name="name">Name of the transition.</param>
    abstract transition: ?name: string -> Transition<HTMLElement, 'OldDatum, obj, obj>
    /// <summary>Returns a new transition from an existing transition.
    /// 
    /// When using a transition instance, the returned transition has the same id and name as the specified transition.
    /// 
    /// The generic "OldDatum" refers to the type of a previously-set datum of the selected HTML element in the Transition.</summary>
    /// <param name="transition">A transition instance.</param>
    abstract transition: transition: Transition<BaseType, obj option, BaseType, obj option> -> Transition<HTMLElement, 'OldDatum, obj, obj>

    (* Axis *)
    
    /// <summary>Constructs a new top-oriented axis generator for the given scale, with empty tick arguments,
    /// a tick size of 6 and padding of 3. In this orientation, ticks are drawn above the horizontal domain path.</summary>
    /// <param name="scale">The scale to be used for axis generation.</param>
    abstract axisTop: scale: AxisScale<'Domain> -> Axis<'Domain>
    /// <summary>Constructs a new right-oriented axis generator for the given scale, with empty tick arguments,
    /// a tick size of 6 and padding of 3. In this orientation, ticks are drawn to the right of the vertical domain path.</summary>
    /// <param name="scale">The scale to be used for axis generation.</param>
    abstract axisRight: scale: AxisScale<'Domain> -> Axis<'Domain>
    /// <summary>Constructs a new bottom-oriented axis generator for the given scale, with empty tick arguments,
    /// a tick size of 6 and padding of 3. In this orientation, ticks are drawn below the horizontal domain path.</summary>
    /// <param name="scale">The scale to be used for axis generation.</param>
    abstract axisBottom: scale: AxisScale<'Domain> -> Axis<'Domain>
    /// <summary>Constructs a new left-oriented axis generator for the given scale, with empty tick arguments,
    /// a tick size of 6 and padding of 3. In this orientation, ticks are drawn to the left of the vertical domain path.</summary>
    /// <param name="scale">The scale to be used for axis generation.</param>
    abstract axisLeft: scale: AxisScale<'Domain> -> Axis<'Domain>

    (* Time *)

    /// <summary>Constructs a new custom interval given the specified floor and offset functions.
    /// 
    /// The returned custom interval is not countable, i.e. does not expose the methods "count(..)" and "every(...)".</summary>
    /// <param name="floor">A floor function which takes a single date as an argument and rounds it down to the nearest interval boundary.</param>
    /// <param name="offset">An offset function which takes a date and an integer step as arguments and advances
    /// the specified date by the specified number of boundaries; the step may be positive, negative or zero.</param>
    abstract timeInterval: floor: (DateTime -> unit) * offset: (DateTime -> float -> unit) -> TimeInterval
    /// <summary>Constructs a new custom interval given the specified floor, offset and count functions.
    /// 
    /// The returned custom interval is countable and exposes the methods "count(..)" and "every(...)".
    /// 
    /// Note: due to an internal optimization, the specified count function must not invoke interval.count on other time intervals.</summary>
    /// <param name="floor">A floor function which takes a single date as an argument and rounds it down to the nearest interval boundary.</param>
    /// <param name="offset">An offset function which takes a date and an integer step as arguments and advances
    /// the specified date by the specified number of boundaries; the step may be positive, negative or zero.</param>
    /// <param name="count">A count function which takes a start date and an end date, already floored to the current interval,
    /// and returns the number of boundaries between the start (exclusive) and end (inclusive).
    /// Note: due to an internal optimization, the specified count function must not invoke interval.count on other time intervals.</param>
    /// <param name="field">An optional field function which takes a date, already floored to the current interval,
    /// and returns the field value of the specified date,
    /// corresponding to the number of boundaries between this date (exclusive) and the latest previous parent boundary.
    /// For example, for the timeDay interval, this returns the number of days since the start of the month.
    /// If a field function is not specified, it defaults to counting the number of interval boundaries since
    /// the UNIX epoch of January 1, 1970 UTC. The field function defines the behavior of interval.every.</param>
    abstract timeInterval: floor: (DateTime -> unit) * offset: (DateTime -> float -> unit) * count: (DateTime -> DateTime -> float) * ?field: (DateTime -> float) -> CountableTimeInterval
    /// <summary>This is a convenience alias for timeMillisecond.range(...).</summary>
    /// <param name="start">A start date object for the range.</param>
    /// <param name="stop">A stop date object for the range.</param>
    /// <param name="step">An optional number of steps to apply when calculating the dates in the range.</param>
    abstract timeMilliseconds: start: DateTime * stop: DateTime * ?step: float -> ResizeArray<DateTime>
    /// <summary>This is a convenience alias for timeSecond.range(...).</summary>
    /// <param name="start">A start date object for the range.</param>
    /// <param name="stop">A stop date object for the range.</param>
    /// <param name="step">An optional number of steps to apply when calculating the dates in the range.</param>
    abstract timeSeconds: start: DateTime * stop: DateTime * ?step: float -> ResizeArray<DateTime>
    /// <summary>This is a convenience alias for timeMinute.range(...).</summary>
    /// <param name="start">A start date object for the range.</param>
    /// <param name="stop">A stop date object for the range.</param>
    /// <param name="step">An optional number of steps to apply when calculating the dates in the range.</param>
    abstract timeMinutes: start: DateTime * stop: DateTime * ?step: float -> ResizeArray<DateTime>
    /// <summary>This is a convenience alias for timeHour.range(...).</summary>
    /// <param name="start">A start date object for the range.</param>
    /// <param name="stop">A stop date object for the range.</param>
    /// <param name="step">An optional number of steps to apply when calculating the dates in the range.</param>
    abstract timeHours: start: DateTime * stop: DateTime * ?step: float -> ResizeArray<DateTime>
    /// <summary>This is a convenience alias for timeDay.range(...).</summary>
    /// <param name="start">A start date object for the range.</param>
    /// <param name="stop">A stop date object for the range.</param>
    /// <param name="step">An optional number of steps to apply when calculating the dates in the range.</param>
    abstract timeDays: start: DateTime * stop: DateTime * ?step: float -> ResizeArray<DateTime>
    /// <summary>This is a convenience alias for timeWeek.range(...).</summary>
    /// <param name="start">A start date object for the range.</param>
    /// <param name="stop">A stop date object for the range.</param>
    /// <param name="step">An optional number of steps to apply when calculating the dates in the range.</param>
    abstract timeWeeks: start: DateTime * stop: DateTime * ?step: float -> ResizeArray<DateTime>
    /// <summary>This is a convenience alias for timeSunday.range(...).</summary>
    /// <param name="start">A start date object for the range.</param>
    /// <param name="stop">A stop date object for the range.</param>
    /// <param name="step">An optional number of steps to apply when calculating the dates in the range.</param>
    abstract timeSundays: start: DateTime * stop: DateTime * ?step: float -> ResizeArray<DateTime>
    /// <summary>This is a convenience alias for timeMonday.range(...).</summary>
    /// <param name="start">A start date object for the range.</param>
    /// <param name="stop">A stop date object for the range.</param>
    /// <param name="step">An optional number of steps to apply when calculating the dates in the range.</param>
    abstract timeMondays: start: DateTime * stop: DateTime * ?step: float -> ResizeArray<DateTime>
    /// <summary>This is a convenience alias for timeTuesday.range(...).</summary>
    /// <param name="start">A start date object for the range.</param>
    /// <param name="stop">A stop date object for the range.</param>
    /// <param name="step">An optional number of steps to apply when calculating the dates in the range.</param>
    abstract timeTuesdays: start: DateTime * stop: DateTime * ?step: float -> ResizeArray<DateTime>
    /// <summary>This is a convenience alias for timeWednesday.range(...).</summary>
    /// <param name="start">A start date object for the range.</param>
    /// <param name="stop">A stop date object for the range.</param>
    /// <param name="step">An optional number of steps to apply when calculating the dates in the range.</param>
    abstract timeWednesdays: start: DateTime * stop: DateTime * ?step: float -> ResizeArray<DateTime>
    /// <summary>This is a convenience alias for timeThursday.range(...).</summary>
    /// <param name="start">A start date object for the range.</param>
    /// <param name="stop">A stop date object for the range.</param>
    /// <param name="step">An optional number of steps to apply when calculating the dates in the range.</param>
    abstract timeThursdays: start: DateTime * stop: DateTime * ?step: float -> ResizeArray<DateTime>
    /// <summary>This is a convenience alias for timeFriday.range(...).</summary>
    /// <param name="start">A start date object for the range.</param>
    /// <param name="stop">A stop date object for the range.</param>
    /// <param name="step">An optional number of steps to apply when calculating the dates in the range.</param>
    abstract timeFridays: start: DateTime * stop: DateTime * ?step: float -> ResizeArray<DateTime>
    /// <summary>This is a convenience alias for timeSaturday.range(...).</summary>
    /// <param name="start">A start date object for the range.</param>
    /// <param name="stop">A stop date object for the range.</param>
    /// <param name="step">An optional number of steps to apply when calculating the dates in the range.</param>
    abstract timeSaturdays: start: DateTime * stop: DateTime * ?step: float -> ResizeArray<DateTime>
    /// <summary>This is a convenience alias for timeMonth.range(...).</summary>
    /// <param name="start">A start date object for the range.</param>
    /// <param name="stop">A stop date object for the range.</param>
    /// <param name="step">An optional number of steps to apply when calculating the dates in the range.</param>
    abstract timeMonths: start: DateTime * stop: DateTime * ?step: float -> ResizeArray<DateTime>
    /// <summary>This is a convenience alias for timeYear.range(...).</summary>
    /// <param name="start">A start date object for the range.</param>
    /// <param name="stop">A stop date object for the range.</param>
    /// <param name="step">An optional number of steps to apply when calculating the dates in the range.</param>
    abstract timeYears: start: DateTime * stop: DateTime * ?step: float -> ResizeArray<DateTime>
    /// <summary>This is a convenience alias for utcMillisecond.range(...).</summary>
    /// <param name="start">A start date object for the range.</param>
    /// <param name="stop">A stop date object for the range.</param>
    /// <param name="step">An optional number of steps to apply when calculating the dates in the range.</param>
    abstract utcMilliseconds: start: DateTime * stop: DateTime * ?step: float -> ResizeArray<DateTime>
    /// <summary>This is a convenience alias for utcSecond.range(...).</summary>
    /// <param name="start">A start date object for the range.</param>
    /// <param name="stop">A stop date object for the range.</param>
    /// <param name="step">An optional number of steps to apply when calculating the dates in the range.</param>
    abstract utcSeconds: start: DateTime * stop: DateTime * ?step: float -> ResizeArray<DateTime>
    /// <summary>This is a convenience alias for utcMinute.range(...).</summary>
    /// <param name="start">A start date object for the range.</param>
    /// <param name="stop">A stop date object for the range.</param>
    /// <param name="step">An optional number of steps to apply when calculating the dates in the range.</param>
    abstract utcMinutes: start: DateTime * stop: DateTime * ?step: float -> ResizeArray<DateTime>
    /// <summary>This is a convenience alias for utcHour.range(...).</summary>
    /// <param name="start">A start date object for the range.</param>
    /// <param name="stop">A stop date object for the range.</param>
    /// <param name="step">An optional number of steps to apply when calculating the dates in the range.</param>
    abstract utcHours: start: DateTime * stop: DateTime * ?step: float -> ResizeArray<DateTime>
    /// <summary>This is a convenience alias for utcDay.range(...).</summary>
    /// <param name="start">A start date object for the range.</param>
    /// <param name="stop">A stop date object for the range.</param>
    /// <param name="step">An optional number of steps to apply when calculating the dates in the range.</param>
    abstract utcDays: start: DateTime * stop: DateTime * ?step: float -> ResizeArray<DateTime>
    /// <summary>This is a convenience alias for utcWeek.range(...).</summary>
    /// <param name="start">A start date object for the range.</param>
    /// <param name="stop">A stop date object for the range.</param>
    /// <param name="step">An optional number of steps to apply when calculating the dates in the range.</param>
    abstract utcWeeks: start: DateTime * stop: DateTime * ?step: float -> ResizeArray<DateTime>
    /// <summary>This is a convenience alias for utcSunday.range(...).</summary>
    /// <param name="start">A start date object for the range.</param>
    /// <param name="stop">A stop date object for the range.</param>
    /// <param name="step">An optional number of steps to apply when calculating the dates in the range.</param>
    abstract utcSundays: start: DateTime * stop: DateTime * ?step: float -> ResizeArray<DateTime>
    /// <summary>This is a convenience alias for utcMonday.range(...).</summary>
    /// <param name="start">A start date object for the range.</param>
    /// <param name="stop">A stop date object for the range.</param>
    /// <param name="step">An optional number of steps to apply when calculating the dates in the range.</param>
    abstract utcMondays: start: DateTime * stop: DateTime * ?step: float -> ResizeArray<DateTime>
    /// <summary>This is a convenience alias for utcTuesday.range(...).</summary>
    /// <param name="start">A start date object for the range.</param>
    /// <param name="stop">A stop date object for the range.</param>
    /// <param name="step">An optional number of steps to apply when calculating the dates in the range.</param>
    abstract utcTuesdays: start: DateTime * stop: DateTime * ?step: float -> ResizeArray<DateTime>
    /// <summary>This is a convenience alias for utcWednesday.range(...).</summary>
    /// <param name="start">A start date object for the range.</param>
    /// <param name="stop">A stop date object for the range.</param>
    /// <param name="step">An optional number of steps to apply when calculating the dates in the range.</param>
    abstract utcWednesdays: start: DateTime * stop: DateTime * ?step: float -> ResizeArray<DateTime>
    /// <summary>This is a convenience alias for utcThursday.range(...).</summary>
    /// <param name="start">A start date object for the range.</param>
    /// <param name="stop">A stop date object for the range.</param>
    /// <param name="step">An optional number of steps to apply when calculating the dates in the range.</param>
    abstract utcThursdays: start: DateTime * stop: DateTime * ?step: float -> ResizeArray<DateTime>
    /// <summary>This is a convenience alias for utcFriday.range(...).</summary>
    /// <param name="start">A start date object for the range.</param>
    /// <param name="stop">A stop date object for the range.</param>
    /// <param name="step">An optional number of steps to apply when calculating the dates in the range.</param>
    abstract utcFridays: start: DateTime * stop: DateTime * ?step: float -> ResizeArray<DateTime>
    /// <summary>This is a convenience alias for utcSaturday.range(...).</summary>
    /// <param name="start">A start date object for the range.</param>
    /// <param name="stop">A stop date object for the range.</param>
    /// <param name="step">An optional number of steps to apply when calculating the dates in the range.</param>
    abstract utcSaturdays: start: DateTime * stop: DateTime * ?step: float -> ResizeArray<DateTime>
    /// <summary>This is a convenience alias for utcMonth.range(...).</summary>
    /// <param name="start">A start date object for the range.</param>
    /// <param name="stop">A stop date object for the range.</param>
    /// <param name="step">An optional number of steps to apply when calculating the dates in the range.</param>
    abstract utcMonths: start: DateTime * stop: DateTime * ?step: float -> ResizeArray<DateTime>
    /// <summary>This is a convenience alias for utcYear.range(...).</summary>
    /// <param name="start">A start date object for the range.</param>
    /// <param name="stop">A stop date object for the range.</param>
    /// <param name="step">An optional number of steps to apply when calculating the dates in the range.</param>
    abstract utcYears: start: DateTime * stop: DateTime * ?step: float -> ResizeArray<DateTime>

    (* Scale *)

    /// Constructs a new continuous linear scale with the unit domain [0, 1], the unit range [0, 1], the default interpolator and clamping disabled.
    /// 
    /// The scale will have range and output of data type number.
    abstract scaleLinear: unit -> ScaleLinear<float, float>
    /// Constructs a new continuous linear scale with the unit domain [0, 1], the default interpolator and clamping disabled.
    /// 
    /// The generic corresponds to the data type of the range and output elements to be used.
    /// 
    /// As range type and output type are the same, the interpolator factory used with the scale must match this behavior.
    /// The range must be set in accordance with the range element type.
    /// 
    /// The interpolator factory may be set using the interpolate(...) method of the scale.
    abstract scaleLinear: unit -> ScaleLinear<'Output, 'Output>
    /// Constructs a new continuous linear scale with the unit domain [0, 1], the default interpolator and clamping disabled.
    /// 
    /// The first generic corresponds to the data type of the range elements.
    /// The second generic corresponds to the data type of the output elements generated by the scale.
    /// 
    /// If range element and output element type differ, the interpolator factory used with the scale must match this behavior and
    /// convert the interpolated range element to a corresponding output element.
    /// 
    /// The range must be set in accordance with the range element type.
    /// 
    /// The interpolator factory may be set using the interpolate(...) method of the scale.
    abstract scaleLinear: unit -> ScaleLinear<'Range, 'Output>
    /// Constructs a new continuous power scale with the unit domain [0, 1], the unit range [0, 1], the exponent 1, the default interpolator and clamping disabled.
    /// (Note that this is effectively a linear scale until you set a different exponent.)
    /// 
    /// The scale will have range and output of data type number.
    abstract scalePow: unit -> ScalePower<float, float>
    /// Constructs a new continuous power scale with the unit domain [0, 1], the exponent 1, the default interpolator and clamping disabled.
    /// (Note that this is effectively a linear scale until you set a different exponent.)
    /// 
    /// The generic corresponds to the data type of the range and output elements to be used.
    /// 
    /// As range type and output type are the same, the interpolator factory used with the scale must match this behavior.
    /// 
    /// The range must be set in accordance with the range element type.
    /// 
    /// The interpolator factory may be set using the interpolate(...) method of the scale.
    abstract scalePow: unit -> ScalePower<'Output, 'Output>
    /// Constructs a new continuous power scale with the unit domain [0, 1], the exponent 1, the default interpolator and clamping disabled.
    /// (Note that this is effectively a linear scale until you set a different exponent.)
    /// 
    /// The first generic corresponds to the data type of the range elements.
    /// The second generic corresponds to the data type of the output elements generated by the scale.
    /// 
    /// If range element and output element type differ, the interpolator factory used with the scale must match this behavior and
    /// convert the interpolated range element to a corresponding output element.
    /// 
    /// The range must be set in accordance with the range element type.
    /// 
    /// The interpolator factory may be set using the interpolate(...) method of the scale.
    abstract scalePow: unit -> ScalePower<'Range, 'Output>
    /// Constructs a new continuous power scale with the unit domain [0, 1], the unit range [0, 1], the exponent 0.5, the default interpolator and clamping disabled.
    /// This is a convenience method equivalent to d3.scalePow().exponent(0.5).
    /// 
    /// The scale will have range and output of data type number.
    abstract scaleSqrt: unit -> ScalePower<float, float>
    /// Constructs a new continuous power scale with the unit domain [0, 1], the exponent 0.5, the default interpolator and clamping disabled.
    /// This is a convenience method equivalent to d3.scalePow().exponent(0.5).
    /// 
    /// The generic corresponds to the data type of the range and output elements to be used.
    /// 
    /// As range type and output type are the same, the interpolator factory used with the scale must match this behavior.
    /// 
    /// The range must be set in accordance with the range element type.
    /// 
    /// The interpolator factory may be set using the interpolate(...) method of the scale.
    abstract scaleSqrt: unit -> ScalePower<'Output, 'Output>
    /// Constructs a new continuous power scale with the unit domain [0, 1], the exponent 0.5, the default interpolator and clamping disabled.
    /// This is a convenience method equivalent to d3.scalePow().exponent(0.5).
    /// 
    /// The first generic corresponds to the data type of the range elements.
    /// The second generic corresponds to the data type of the output elements generated by the scale.
    /// 
    /// If range element and output element type differ, the interpolator factory used with the scale must match this behavior and
    /// convert the interpolated range element to a corresponding output element.
    /// 
    /// The range must be set in accordance with the range element type.
    /// 
    /// The interpolator factory may be set using the interpolate(...) method of the scale.
    abstract scaleSqrt: unit -> ScalePower<'Range, 'Output>
    /// Constructs a new continuous logarithmic scale with the domain [1, 10], the unit range [0, 1], the base 10, the default interpolator and clamping disabled.
    /// 
    /// The scale will have range and output of data type number.
    abstract scaleLog: unit -> ScaleLogarithmic<float, float>
    /// Constructs a new continuous logarithmic scale with the domain [1, 10], the base 10, the default interpolator and clamping disabled.
    /// 
    /// The generic corresponds to the data type of the range and output elements to be used.
    /// 
    /// As range type and output type are the same, the interpolator factory used with the scale must match this behavior.
    /// 
    /// The range must be set in accordance with the range element type.
    /// 
    /// The interpolator factory may be set using the interpolate(...) method of the scale.
    abstract scaleLog: unit -> ScaleLogarithmic<'Output, 'Output>
    /// Constructs a new continuous logarithmic scale with the domain [1, 10], the base 10, the default interpolator and clamping disabled.
    /// 
    /// The first generic corresponds to the data type of the range elements.
    /// The second generic corresponds to the data type of the output elements generated by the scale.
    /// 
    /// If range element and output element type differ, the interpolator factory used with the scale must match this behavior and
    /// convert the interpolated range element to a corresponding output element.
    /// 
    /// The range must be set in accordance with the range element type.
    /// 
    /// The interpolator factory may be set using the interpolate(...) method of the scale.
    abstract scaleLog: unit -> ScaleLogarithmic<'Range, 'Output>
    /// Constructs a new continuous bi-symmetric logarithmic scale with the specified domain, the specified range, the constant 1, the default interpolator and clamping disabled.
    /// 
    /// The scale will have range and output of data type number.
    abstract scaleSymlog: unit -> ScaleSymLog<float, float>
    /// Constructs a new continuous bi-symmetric logarithmic scale with the specified domain, the constant 1, the default interpolator and clamping disabled.
    /// 
    /// The generic corresponds to the data type of the range and output elements to be used.
    /// 
    /// As range type and output type are the same, the interpolator factory used with the scale must match this behavior.
    /// 
    /// The range must be set in accordance with the range element type.
    /// 
    /// The interpolator factory may be set using the interpolate(...) method of the scale.
    abstract scaleSymlog: unit -> ScaleSymLog<'Output, 'Output>
    /// Constructs a new continuous bi-symmetric logarithmic scale with the specified domain, the constant 1, the default interpolator and clamping disabled.
    /// 
    /// The first generic corresponds to the data type of the range elements.
    /// The second generic corresponds to the data type of the output elements generated by the scale.
    /// 
    /// If range element and output element type differ, the interpolator factory used with the scale must match this behavior and
    /// convert the interpolated range element to a corresponding output element.
    /// 
    /// The range must be set in accordance with the range element type.
    /// 
    /// The interpolator factory may be set using the interpolate(...) method of the scale.
    abstract scaleSymlog: unit -> ScaleSymLog<'Range, 'Output>
    /// Constructs a new identity scale with the unit domain [0, 1] and the unit range [0, 1].
    abstract scaleIdentity: unit -> ScaleIdentity
    /// Constructs a new time scale using local time with the domain [2000-01-01, 2000-01-02], the unit range [0, 1], the default interpolator and clamping disabled.
    /// 
    /// The scale will have range and output of data type number.
    abstract scaleTime: unit -> ScaleTime<float, float>
    /// Constructs a new time scale using local time with the domain [2000-01-01, 2000-01-02], the default interpolator and clamping disabled.
    /// 
    /// The generic corresponds to the data type of the range and output elements to be used.
    /// 
    /// As range type and output type are the same, the interpolator factory used with the scale must match this behavior.
    /// 
    /// The range must be set in accordance with the range element type.
    /// 
    /// The interpolator factory may be set using the interpolate(...) method of the scale.
    abstract scaleTime: unit -> ScaleTime<'Output, 'Output>
    /// Constructs a new time scale using local time with the domain [2000-01-01, 2000-01-02], the default interpolator and clamping disabled.
    /// 
    /// The first generic corresponds to the data type of the range elements.
    /// The second generic corresponds to the data type of the output elements generated by the scale.
    /// 
    /// If range element and output element type differ, the interpolator factory used with the scale must match this behavior and
    /// convert the interpolated range element to a corresponding output element.
    /// 
    /// The range must be set in accordance with the range element type.
    /// 
    /// The interpolator factory may be set using the interpolate(...) method of the scale.
    abstract scaleTime: unit -> ScaleTime<'Range, 'Output>
    /// Constructs a new time scale using Coordinated Universal Time (UTC) with the domain [2000-01-01, 2000-01-02], the unit range [0, 1], the default interpolator and clamping disabled.
    /// 
    /// The scale will have range and output of data type number.
    abstract scaleUtc: unit -> ScaleTime<float, float>
    /// Constructs a new time scale using Coordinated Universal Time (UTC) with the domain [2000-01-01, 2000-01-02], the default interpolator and clamping disabled.
    /// 
    /// The generic corresponds to the data type of the range and output elements to be used.
    /// 
    /// As range type and output type are the same, the interpolator factory used with the scale must match this behavior.
    /// 
    /// The range must be set in accordance with the range element type.
    /// 
    /// The interpolator factory may be set using the interpolate(...) method of the scale.
    abstract scaleUtc: unit -> ScaleTime<'Output, 'Output>
    /// Constructs a new time scale using Coordinated Universal Time (UTC) with the domain [2000-01-01, 2000-01-02], the default interpolator and clamping disabled.
    /// 
    /// The first generic corresponds to the data type of the range elements.
    /// The second generic corresponds to the data type of the output elements generated by the scale.
    /// 
    /// If range element and output element type differ, the interpolator factory used with the scale must match this behavior and
    /// convert the interpolated range element to a corresponding output element.
    /// 
    /// The range must be set in accordance with the range element type.
    /// 
    /// The interpolator factory may be set using the interpolate(...) method of the scale.
    abstract scaleUtc: unit -> ScaleTime<'Range, 'Output>
    /// <summary>Constructs a new sequential scale with the given interpolator function. When the scale is applied, the interpolator will be invoked with a value typically in the range [0, 1],
    /// where 0 represents the start of the domain, and 1 represents the end of the domain.
    /// 
    /// The generic corresponds to the data type of the output of the interpolator underlying the scale.</summary>
    /// <param name="interpolator">The interpolator function to be used with the scale.</param>
    abstract scaleSequential: interpolator: (float -> 'Output) -> ScaleSequential<'Output>
    /// <summary>Constructs a new diverging scale with the given interpolator function.
    /// When the scale is applied, the interpolator will be invoked with a value typically in the range [0, 1],
    /// where 0 represents the extreme negative value, 0.5 represents the neutral value, and 1 represents the extreme positive value.
    /// 
    /// The generic corresponds to the data type of the interpolator return type.</summary>
    /// <param name="interpolator">The scale’s interpolator.</param>
    abstract scaleDiverging: interpolator: (float -> 'T) -> ScaleDiverging<'T>
    /// Constructs a new quantize scale with the unit domain [0, 1] and the unit range [0, 1].
    /// Thus, the default quantize scale is equivalent to the Math.round function.
    abstract scaleQuantize: unit -> ScaleQuantize<float>
    /// Constructs a new quantize scale with the unit domain [0, 1].
    /// 
    /// The range must be set corresponding to the type of the range elements.
    /// 
    /// The generic corresponds to the data type of the range elements.
    abstract scaleQuantize: unit -> ScaleQuantize<'Range>
    /// Constructs a new quantile scale with an empty domain and an empty range.
    /// The quantile scale is invalid until both a domain and range are specified.
    abstract scaleQuantile: unit -> ScaleQuantile<float>
    /// Constructs a new quantile scale with an empty domain and an empty range.
    /// The quantile scale is invalid until both a domain and range are specified.
    /// 
    /// The generic corresponds to the data type of range elements.
    abstract scaleQuantile: unit -> ScaleQuantile<'Range>
    /// Constructs a new threshold scale with the default domain [0.5] and the default range [0, 1].
    /// Thus, the default threshold scale is equivalent to the Math.round function for numbers; for example threshold(0.49) returns 0, and threshold(0.51) returns 1.
    abstract scaleThreshold: unit -> ScaleThreshold<float, float>
    /// Constructs a new threshold scale. The domain and range must be set corresponding to the type of the corresponding generic.
    /// 
    /// The first generic corresponds to the data type of domain values.
    /// The second generic corresponds to the data type of range values.
    abstract scaleThreshold: unit -> ScaleThreshold<'Domain, 'Range>
    /// Constructs a new ordinal scale with an empty domain and the specified range.
    /// If a range is not specified, it defaults to the empty array; an ordinal scale always returns undefined until a non-empty range is defined.
    /// 
    /// By default, the domain is configured to generate implicitly, if the scale is invoked with an unknown value.
    /// See the "unknown(...)" method of the scale to change this behavior.
    /// 
    /// The generic corresponds to the data type of range elements.
    abstract scaleOrdinal: ?range: ResizeArray<'Range> -> ScaleOrdinal<string, 'Range>
    /// Constructs a new ordinal scale with an empty domain and the specified range.
    /// If a range is not specified, it defaults to the empty array; an ordinal scale always returns undefined until a non-empty range is defined.
    /// 
    /// By default, the domain is configured to generate implicitly, if the scale is invoked with an unknown value.
    /// See the "unknown(...)" method of the scale to change this behavior.
    /// 
    /// The first generic corresponds to the data type of domain elements.
    /// The second generic corresponds to the data type of range elements.
    abstract scaleOrdinal: ?range: ResizeArray<'Range> -> ScaleOrdinal<'Domain, 'Range>
    /// Constructs a new band scale with the empty domain, the unit range [0, 1], no padding, no rounding and center alignment.
    abstract scaleBand: unit -> ScaleBand<string>
    /// Constructs a new band scale with the empty domain, the unit range [0, 1], no padding, no rounding and center alignment.
    /// 
    /// The generic corresponds to the data type of domain elements.
    abstract scaleBand: unit -> ScaleBand<'Domain>
    /// Constructs a new point scale with the empty domain, the unit range [0, 1], no padding, no rounding and center alignment.
    abstract scalePoint: unit -> ScalePoint<string>
    /// Constructs a new point scale with the empty domain, the unit range [0, 1], no padding, no rounding and center alignment.
    /// 
    /// The generic corresponds to the data type of domain elements.
    abstract scalePoint: unit -> ScalePoint<'Domain>


[<AutoOpen>]
module Globals =
    //do Glob
    let d3 = Unchecked.defaultof<D3>
