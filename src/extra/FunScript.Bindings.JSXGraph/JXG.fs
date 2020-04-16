namespace FunScript.Bindings.D3

open System

open FunScript
open FunScript.Bindings

// ts2fable 0.8.0
//module rec moduleName
//open System
//open Fable.Core
//open Fable.Core.JS

//let [<Import("Math","module")>] math: Math.IExports = jsNative
//let [<Import("Options","module")>] options: Options.IExports = jsNative
//let [<Import("GeonextParser","module")>] geonextParser: GeonextParser.IExports = jsNative
//let [<Import("Dump","module")>] dump: Dump.IExports = jsNative
//let [<Import("EventEmitter","module")>] eventEmitter: EventEmitter.IExports = jsNative
//let [<Import("Util","module")>] util: Util.IExports = jsNative
//let [<Import("XML","module")>] xml: XML.IExports = jsNative


type [<AllowNullLiteral>] IExports =
    abstract Chart: ChartStatic
    abstract Legend: LegendStatic
    abstract Circle: CircleStatic
    abstract Curve: CurveStatic
    abstract Functiongraph: FunctiongraphStatic
    abstract Spline: SplineStatic
    abstract Cardinalspline: CardinalsplineStatic
    abstract Riemannsum: RiemannsumStatic
    abstract Tracecurve: TracecurveStatic
    abstract Stepfunction: StepfunctionStatic
    abstract Derivative: DerivativeStatic
    abstract Group: GroupStatic
    abstract Image: ImageStatic
    abstract Line: LineStatic
    abstract Segment: SegmentStatic
    abstract Arrow: ArrowStatic
    abstract Axis: AxisStatic
    abstract Tangent: TangentStatic
    abstract RadicalAxis: RadicalAxisStatic
    abstract PolarLine: PolarLineStatic
    abstract Point: PointStatic
    abstract Glider: GliderStatic
    abstract Intersection: IntersectionStatic
    abstract OtherIntersection: OtherIntersectionStatic
    abstract PolePoint: PolePointStatic
    abstract Polygon: PolygonStatic
    abstract RegularPolygon: RegularPolygonStatic
    abstract Text: TextStatic
    abstract Label: LabelStatic
    abstract Ticks: TicksStatic
    abstract Hatch: HatchStatic
    abstract Transformation: TransformationStatic
    abstract Turtle: TurtleStatic
    abstract Arc: ArcStatic
    abstract Semicircle: SemicircleStatic
    abstract CircumcircleArc: CircumcircleArcStatic
    abstract MinorArc: MinorArcStatic
    abstract MajorArc: MajorArcStatic
    abstract Button: ButtonStatic
    abstract Checkbox: CheckboxStatic
    abstract Comb: CombStatic
    abstract Orthogonalprojection: OrthogonalprojectionStatic
    abstract Perpendicular: PerpendicularStatic
    abstract PerpendicularPoint: PerpendicularPointStatic
    abstract PerpendicularSegment: PerpendicularSegmentStatic
    abstract Midpoint: MidpointStatic
    abstract Parallelpoint: ParallelpointStatic
    abstract Parallel: ParallelStatic
    abstract Arrowparallel: ArrowparallelStatic
    abstract Normal: NormalStatic
    abstract Bisector: BisectorStatic
    abstract Bisectorlines: BisectorlinesStatic
    abstract Circumcenter: CircumcenterStatic
    abstract Incenter: IncenterStatic
    abstract Circumcircle: CircumcircleStatic
    abstract Incircle: IncircleStatic
    abstract Reflection: ReflectionStatic
    abstract Mirrorelement: MirrorelementStatic
    abstract Mirrorpoint: MirrorpointStatic
    abstract Integral: IntegralStatic
    abstract Grid: GridStatic
    abstract Inequality: InequalityStatic
    abstract Ellipse: EllipseStatic
    abstract Hyperbola: HyperbolaStatic
    abstract Parabola: ParabolaStatic
    abstract Conic: ConicStatic
    abstract Input: InputStatic
    abstract Locus: LocusStatic
    abstract Tapemeasure: TapemeasureStatic
    abstract Sector: SectorStatic
    abstract CircumcircleSector: CircumcircleSectorStatic
    abstract MinorSector: MinorSectorStatic
    abstract MajorSector: MajorSectorStatic
    abstract Angle: AngleStatic
    abstract NonReflexAngle: NonReflexAngleStatic
    abstract ReflexAngle: ReflexAngleStatic
    abstract Slider: SliderStatic
    abstract Slopetriangle: SlopetriangleStatic
    abstract JSXGraph: JSXGraphStatic
    abstract boards: obj option
    abstract readers: obj option
    abstract elements: obj option
    /// <summary>This registers a new construction element to JSXGraph for the construction via the {@link JXG.Board.create}
    /// interface.</summary>
    /// <param name="element">- The elements name. This is case-insensitive, existing elements with the same name
    /// will be overwritten.</param>
    /// <param name="creator">- A reference to a function taking three parameters: First the board, the element is
    /// to be created on, a parent element array, and an attributes object. See {@link JXG.createPoint} or any other
    /// <tt>JXG.create...</tt> function for an example.</param>
    abstract registerElement: element: string * creator: (ResizeArray<obj option> -> obj option) -> unit
    /// <summary>Register a file reader.</summary>
    /// <param name="reader">- A file reader. This object has to provide two methods: <tt>prepareString()</tt>
    /// and <tt>read()</tt>.</param>
    abstract registerReader: reader: (ResizeArray<obj option> -> obj option) * ext: ResizeArray<obj option> -> unit
    /// <summary>Creates a shortcut to a method, e.g. {@link JXG.Board#createElement} is a shortcut to {@link JXG.Board#create}.
    /// Sometimes the target is undefined by the time you want to define the shortcut so we need this little helper.</summary>
    /// <param name="object">- The object the method we want to create a shortcut for belongs to.</param>
    /// <param name="fun">- The method we want to create a shortcut for.</param>
    abstract shortcut: ``object``: obj option * ``fun``: string -> (ResizeArray<obj option> -> obj option)
    /// <summary>s may be a string containing the name or id of an element or even a reference
    /// to the element itself. This function returns a reference to the element. Search order: id, name.</summary>
    /// <param name="board">- Reference to the board the element belongs to.</param>
    /// <param name="s">- String or reference to a JSXGraph element.</param>
    abstract getRef: board: JXG.Board * s: string -> obj option
    /// This is just a shortcut to {@link JXG.getRef}.
    abstract getReference: unit -> unit
    /// <summary>s may be the string containing the id of an HTML tag that hosts a JSXGraph board.
    /// This function returns the reference to the board.</summary>
    /// <param name="s">- String of an HTML tag that hosts a JSXGraph board</param>
    abstract getBoardByContainerId: s: string -> obj option
    /// <summary>This method issues a warning to the developer that the given function is deprecated
    /// and, if available, offers an alternative to the deprecated function.</summary>
    /// <param name="what">- Describes the function that is deprecated</param>
    /// <param name="replacement">- The replacement that should be used instead.</param>
    abstract deprecated: what: string * ?replacement: string -> unit
    /// <summary>Outputs a warning via console.warn(), if available. If console.warn() is
    /// unavailable this function will look for an HTML element with the id 'warning'
    /// and append the warning to this element's innerHTML.</summary>
    /// <param name="warning">- The warning text</param>
    abstract warn: warning: string -> unit
    /// <summary>Add something to the debug log. If available a JavaScript debug console is used. Otherwise
    /// we're looking for a HTML div with id "debug". If this doesn't exist, too, the output is omitted.</summary>
    /// <param name="s">- An arbitrary number of parameters.</param>
    abstract debugInt: s: obj option -> unit
    /// <summary>Add something to the debug log. If available a JavaScript debug console is used. Otherwise
    /// we're looking for a HTML div with id "debug". If this doesn't exist, too, the output is omitted.
    /// This method adds a stack trace (if available).</summary>
    /// <param name="s">- An arbitrary number of parameters.</param>
    abstract debugWST: s: obj option -> unit
    /// <summary>Add something to the debug log. If available a JavaScript debug console is used. Otherwise
    /// we're looking for a HTML div with id "debug". If this doesn't exist, too, the output is omitted.
    /// This method adds a line of the stack trace (if available).</summary>
    /// <param name="s">- An arbitrary number of parameters.</param>
    abstract debugLine: s: obj option -> unit
    /// <summary>Add something to the debug log. If available a JavaScript debug console is used. Otherwise
    /// we're looking for a HTML div with id "debug". If this doesn't exist, too, the output is omitted.</summary>
    /// <param name="s">- An arbitrary number of parameters.</param>
    abstract debug: s: obj option -> unit
    abstract Complex: ComplexStatic
    abstract Validator: obj option
    /// <summary>All point faces can be defined with more than one name, e.g. a cross faced point can be given
    /// by face equal to 'cross' or equal to 'x'. This method maps all possible values to fixed ones to
    /// simplify if- and switch-clauses regarding point faces. The translation table is as follows:
    /// <table>
    /// <tr><th>Input</th><th>Output</th></tr>
    /// <tr><td>cross, x</td><td>x</td></tr>
    /// <tr><td>circle, o</td><td>o</td></tr>
    /// <tr><td>square, []</td><td>[]</td></tr>
    /// <tr><td>plus, +</td><td>+</td></tr>
    /// <tr><td>diamond, &lt;&gt;</td><td>&lt;&gt;</td></tr>
    /// <tr><td>triangleup, a, ^</td><td>A</td></tr>
    /// <tr><td>triangledown, v</td><td>v</td></tr>
    /// <tr><td>triangleleft, &lt;</td><td>&lt;</td></tr>
    /// <tr><td>triangleright, &gt;</td><td>&gt;</td></tr>
    /// </table></summary>
    /// <param name="s">- A string which should determine a valid point face.</param>
    abstract normalizePointFace: s: string -> string
    /// <summary>Apply the options stored in this object to all objects on the given board.</summary>
    /// <param name="board">- The board to which objects the options will be applied.</param>
    abstract useStandardOptions: board: JXG.Board -> unit
    /// <summary>Converts all color values to greyscale and calls useStandardOption to put them onto the board.</summary>
    /// <param name="board">- The board to which objects the options will be applied.</param>
    abstract useBlackWhiteOptions: board: JXG.Board -> unit
    abstract CA: CAStatic
    abstract JessieCode: JessieCodeStatic
    abstract FileReader: obj option
    abstract AbstractRenderer: AbstractRendererStatic
    /// Converts a valid HTML/CSS color string into a rgb value array. This is the base
    /// function for the following wrapper functions which only adjust the output to
    /// different flavors like an object, string or hex values.
    abstract rgbParser: color: obj option * ag: float * ab: float -> ResizeArray<obj option>
    /// Converts a valid HTML/CSS color string into a string of the 'rgb(r, g, b)' format.
    abstract rgb2css: color: obj option * ag: float * ab: float -> string
    /// Converts a valid HTML/CSS color string into a HTML rgb string.
    abstract rgb2hex: color: obj option * ag: float * ab: float -> string
    /// <summary>Converts a valid HTML/CSS color string from the '#rrggbb' format into the 'rgb(r, g, b)' format.</summary>
    /// <param name="hex">- A valid HTML or CSS styled color value, e.g. '#12ab21', '#abc', or 'black'</param>
    abstract hex2rgb: hex: string -> string
    /// <summary>Converts HSV color to RGB color.
    /// Based on C Code in "Computer Graphics -- Principles and Practice,"
    /// Foley et al, 1996, p. 593.
    /// See also http://www.efg2.com/Lab/Graphics/Colors/HSV.htm</summary>
    /// <param name="H">- value between 0 and 360</param>
    /// <param name="S">- value between 0.0 (shade of gray) to 1.0 (pure color)</param>
    /// <param name="V">- value between 0.0 (black) to 1.0 (white)</param>
    abstract hsv2rgb: H: float * S: float * V: float -> string
    /// Converts a color from the RGB color space into the HSV space. Input can be any valid HTML/CSS color definition.
    abstract rgb2hsv: color: obj option * ag: float * ab: float -> ResizeArray<obj option>
    /// Converts a color from the RGB color space into the LMS space. Input can be any valid HTML/CSS color definition.
    abstract rgb2LMS: color: obj option * ag: float * ab: float -> ResizeArray<obj option>
    /// Convert color information from LMS to RGB color space.
    abstract LMS2rgb: l: float * m: float * s: float -> ResizeArray<obj option>
    /// <summary>Splits a RGBA color value like #112233AA into it's RGB and opacity parts.</summary>
    /// <param name="rgba">- A RGBA color value</param>
    abstract rgba2rgbo: rgba: string -> ResizeArray<obj option>
    /// <summary>Generates a RGBA color value like #112233AA from it's RGB and opacity parts.</summary>
    /// <param name="rgb">- A RGB color value.</param>
    /// <param name="o">- The desired opacity >=0, <=1.</param>
    abstract rgbo2rgba: rgb: string * o: float -> string
    /// <summary>Decolorizes the given color.</summary>
    /// <param name="color">- HTML string containing the HTML color code.</param>
    abstract rgb2bw: color: string -> string
    /// <summary>Converts a color into how a colorblind human approximately would see it.</summary>
    /// <param name="color">- HTML string containing the HTML color code.</param>
    /// <param name="deficiency">- The type of color blindness. Possible
    /// options are <i>protanopia</i>, <i>deuteranopia</i>, and <i>tritanopia</i>.</param>
    abstract rgb2cb: color: string * deficiency: string -> string
    /// <summary>Determines highlight color to a given color. Done by reducing (or increasing) the opacity,</summary>
    /// <param name="color">- HTML RGBA string containing the HTML color code.</param>
    abstract autoHighlight: color: string -> string
    abstract touchProperty: string
    abstract isBrowser: bool
    /// Detect browser support for VML.
    abstract supportsVML: unit -> bool
    /// Detect browser support for SVG.
    abstract supportsSVG: unit -> bool
    /// Detect browser support for Canvas.
    abstract supportsCanvas: unit -> bool
    /// True, if run inside a node.js environment.
    abstract isNode: unit -> bool
    /// True if run inside a webworker environment.
    abstract isWebWorker: unit -> bool
    /// Checks if the environments supports the W3C Pointer Events API {@link http://www.w3.org/Submission/pointer-events/}
    abstract supportsPointerEvents: unit -> bool
    /// Determine if the current browser supports touch events
    abstract isTouchDevice: unit -> bool
    /// Detects if the user is using an Android powered device.
    abstract isAndroid: unit -> bool
    /// Detects if the user is using the default Webkit browser on an Android powered device.
    abstract isWebkitAndroid: unit -> bool
    /// Detects if the user is using a Apple iPad / iPhone.
    abstract isApple: unit -> bool
    /// Detects if the user is using Safari on an Apple device.
    abstract isWebkitApple: unit -> bool
    /// Returns true if the run inside a Windows 8 "Metro" App.
    abstract isMetroApp: unit -> bool
    /// Detects if the user is using a Mozilla browser
    abstract isMozilla: unit -> bool
    /// Detects if the user is using a firefoxOS powered device.
    abstract isFirefoxOS: unit -> bool
    abstract ieVersion: float
    /// <summary>Reads the width and height of an HTML element.</summary>
    /// <param name="elementId">- The HTML id of an HTML DOM node.</param>
    abstract getDimensions: elementId: string -> obj option
    /// <summary>Adds an event listener to a DOM element.</summary>
    /// <param name="obj">- Reference to a DOM node.</param>
    /// <param name="type">- The event to catch, without leading 'on', e.g. 'mousemove' instead of 'onmousemove'.</param>
    /// <param name="fn">- The function to call when the event is triggered.</param>
    /// <param name="owner">- The scope in which the event trigger is called.</param>
    abstract addEvent: obj: obj option * ``type``: string * fn: (ResizeArray<obj option> -> obj option) * owner: obj option -> unit
    /// <summary>Removes an event listener from a DOM element.</summary>
    /// <param name="obj">- Reference to a DOM node.</param>
    /// <param name="type">- The event to catch, without leading 'on', e.g. 'mousemove' instead of 'onmousemove'.</param>
    /// <param name="fn">- The function to call when the event is triggered.</param>
    /// <param name="owner">- The scope in which the event trigger is called.</param>
    abstract removeEvent: obj: obj option * ``type``: string * fn: (ResizeArray<obj option> -> obj option) * owner: obj option -> unit
    /// <summary>Removes all events of the given type from a given DOM node; Use with caution and do not use it on a container div
    /// of a {@link JXG.Board} because this might corrupt the event handling system.</summary>
    /// <param name="obj">- Reference to a DOM node.</param>
    /// <param name="type">- The event to catch, without leading 'on', e.g. 'mousemove' instead of 'onmousemove'.</param>
    /// <param name="owner">- The scope in which the event trigger is called.</param>
    abstract removeAllEvents: obj: obj option * ``type``: string * owner: obj option -> unit
    /// <summary>Cross browser mouse / touch coordinates retrieval relative to the board's top left corner.</summary>
    /// <param name="e">- The browsers event object. If omitted, <tt>window.event</tt> will be used.</param>
    /// <param name="index">- If <tt>e</tt> is a touch event, this provides the index of the touch coordinates, i.e. it determines which finger.</param>
    /// <param name="doc">- The document object.</param>
    abstract getPosition: ?e: obj * ?index: float * ?doc: obj -> ResizeArray<obj option>
    /// <summary>Calculates recursively the offset of the DOM element in which the board is stored.</summary>
    /// <param name="obj">- A DOM element</param>
    abstract getOffset: obj: obj option -> ResizeArray<obj option>
    /// <summary>Access CSS style sheets.</summary>
    /// <param name="obj">- A DOM element</param>
    /// <param name="stylename">- The CSS property to read.</param>
    abstract getStyle: obj: obj option * stylename: string -> obj option
    /// Reads css style sheets of a given element. This method is a getStyle wrapper and
    /// defaults the read value to <tt>0</tt> if it can't be parsed as an integer value.
    abstract getProp: el: DOMElement * css: string -> float
    /// <summary>Correct position of upper left corner in case of
    /// a CSS transformation. Here, only translations are
    /// extracted. All scaling transformations are corrected
    /// in {@link JXG.Board#getMousePosition}.</summary>
    /// <param name="cPos">- Previously determined position</param>
    /// <param name="obj">- A DOM element</param>
    abstract getCSSTransform: cPos: ResizeArray<obj option> * obj: obj option -> ResizeArray<obj option>
    /// Scaling CSS transformations applied to the div element containing the JSXGraph constructions
    /// are determined. In IE prior to 9, 'rotate', 'skew', 'skewX', 'skewY' are not supported.
    abstract getCSSTransformMatrix: unit -> ResizeArray<obj option>
    /// <summary>Process data in timed chunks. Data which takes long to process, either because it is such
    /// a huge amount of data or the processing takes some time, causes warnings in browsers about
    /// irresponsive scripts. To prevent these warnings, the processing is split into smaller pieces
    /// called chunks which will be processed in serial order.
    /// Copyright 2009 Nicholas C. Zakas. All rights reserved. MIT Licensed</summary>
    /// <param name="items">- to do</param>
    /// <param name="process">- Function that is applied for every array item</param>
    /// <param name="context">- The scope of function process</param>
    /// <param name="callback">- This function is called after the last array element has been processed.</param>
    abstract timedChunk: items: ResizeArray<obj option> * ``process``: (ResizeArray<obj option> -> obj option) * context: obj option * callback: (ResizeArray<obj option> -> obj option) -> unit
    /// <summary>Set the DOM element with id='wrap_id' containing the the JSXGraph div
    /// element into fullscreen mode.
    /// By default, the JSXGraph element is scaled as large as possible while
    /// retaining its proportions.</summary>
    /// <param name="wrap_id">- id of DOM element containing the JSXGraph
    /// div element.</param>
    /// <param name="jsxgraph_id">- ID of the JSXGraph div element.</param>
    abstract toFullscreen: wrap_id: string * jsxgraph_id: string -> unit
    /// Checks if the given string is an id within the given board.
    abstract isId: board: JXG.Board * s: string -> bool
    /// Checks if the given string is a name within the given board.
    abstract isName: board: JXG.Board * s: string -> bool
    /// Checks if the given string is a group id within the given board.
    abstract isGroup: board: JXG.Board * s: string -> bool
    /// <summary>Checks if the value of a given variable is of type string.</summary>
    /// <param name="v">- A variable of any type.</param>
    abstract isString: v: obj option -> bool
    /// <summary>Checks if the value of a given variable is of type number.</summary>
    /// <param name="v">- A variable of any type.</param>
    abstract isNumber: v: obj option -> bool
    /// <summary>Checks if a given variable references a function.</summary>
    /// <param name="v">- A variable of any type.</param>
    abstract isFunction: v: obj option -> bool
    /// <summary>Checks if a given variable references an array.</summary>
    /// <param name="v">- A variable of any type.</param>
    abstract isArray: v: obj option -> bool
    /// Tests if the input variable is an Object
    abstract isObject: v: obj option -> unit
    /// <summary>Checks if a given variable is a reference of a JSXGraph Point element.</summary>
    /// <param name="v">- A variable of any type.</param>
    abstract isPoint: v: obj option -> bool
    /// <summary>Checks if a given variable is a reference of a JSXGraph Point element or an array of length at least two or
    /// a function returning an array of length two or three.</summary>
    /// <param name="v">- A variable of any type.</param>
    abstract isPointType: board: JXG.Board * v: obj option -> bool
    /// <summary>Checks if a given variable is a reference of a JSXGraph transformation element or an array
    /// of JSXGraph transformation elements.</summary>
    /// <param name="v">- A variable of any type.</param>
    abstract isTransformationOrArray: v: obj option -> bool
    abstract exists: obj option
    /// <summary>Handle default parameters.</summary>
    /// <param name="v">- Given value</param>
    /// <param name="d">- Default value</param>
    abstract def: v: obj option * d: obj option -> obj option
    /// <summary>Converts a string containing either <strong>true</strong> or <strong>false</strong> into a boolean value.</summary>
    /// <param name="s">- String containing either <strong>true</strong> or <strong>false</strong>.</param>
    abstract str2Bool: s: string -> bool
    /// <summary>Convert a String, a number or a function into a function. This method is used in Transformation.js</summary>
    /// <param name="board">- Reference to a JSXGraph board. It is required to resolve dependencies given
    /// by a GEONE<sub>X</sub>T string, thus it must be a valid reference only in case one of the param
    /// values is of type string.</param>
    /// <param name="param">- An array containing strings, numbers, or functions.</param>
    /// <param name="n">- Length of <tt>param</tt>.</param>
    abstract createEvalFunction: board: JXG.Board * param: ResizeArray<obj option> * n: float -> (ResizeArray<obj option> -> obj option)
    /// <summary>Convert a String, number or function into a function.</summary>
    /// <param name="term">- A variable of type string, function or number.</param>
    /// <param name="board">- Reference to a JSXGraph board. It is required to resolve dependencies given
    /// by a GEONE<sub>X</sub>T string, thus it must be a valid reference only in case one of the param
    /// values is of type string.</param>
    /// <param name="variableName">- Only required if evalGeonext is set to true. Describes the variable name
    /// of the variable in a GEONE<sub>X</sub>T string given as term.</param>
    /// <param name="evalGeonext">- Set this true, if term should be treated as a GEONE<sub>X</sub>T string.</param>
    abstract createFunction: term: U3<string, float, (ResizeArray<obj option> -> obj option)> * board: JXG.Board * variableName: string * ?evalGeonext: bool -> (ResizeArray<obj option> -> obj option)
    /// <summary>Test if the parents array contains existing points. If instead parents contains coordinate arrays or function returning coordinate arrays
    /// free points with these coordinates are created.</summary>
    /// <param name="board">- Board object</param>
    /// <param name="parents">- Array containing parent elements for a new object. This array may contain
    /// <ul>
    /// <li> {@link JXG.Point} objects
    /// <li> {@link JXG.Element#name} of {@link JXG.Point} objects
    /// <li> {@link JXG.Element#id} of {@link JXG.Point} objects
    /// <li> Coordinates of points given as array of numbers of length two or three, e.g. [2, 3].
    /// <li> Coordinates of points given as array of functions of length two or three. Each function returns one coordinate, e.g.
    /// [function(){ return 2; }, function(){ return 3; }]
    /// <li> Function returning coordinates, e.g. function() { return [2, 3]; }
    /// </ul>
    /// In the last three cases a new point will be created.</param>
    /// <param name="attrClass">- Main attribute class of newly created points, see {@link JXG</param>
    /// <param name="attrArray">- List of subtype attributes for the newly created points. The list of subtypes is mapped to the list of new points.</param>
    abstract providePoints: board: JXG.Board * parents: ResizeArray<obj option> * attrClass: string * attrArray: ResizeArray<obj option> -> ResizeArray<obj option>
    /// <summary>Generates a function which calls the function fn in the scope of owner.</summary>
    /// <param name="fn">- Function to call.</param>
    /// <param name="owner">- Scope in which fn is executed.</param>
    abstract bind: fn: (ResizeArray<obj option> -> obj option) * owner: obj option -> (ResizeArray<obj option> -> obj option)
    /// <summary>If <tt>val</tt> is a function, it will be evaluated without giving any parameters, else the input value
    /// is just returned.</summary>
    /// <param name="val">- Could be anything. Preferably a number or a function.</param>
    abstract evaluate: ``val``: obj option -> obj option
    /// <summary>Search an array for a given value.</summary>
    /// <param name="sub">- Use this property if the elements of the array are objects.</param>
    abstract indexOf: array: ResizeArray<obj option> * value: obj option * ?sub: string -> float
    /// <summary>Eliminates duplicate entries in an array consisting of numbers and strings.</summary>
    /// <param name="a">- An array of numbers and/or strings.</param>
    abstract eliminateDuplicates: a: ResizeArray<obj option> -> ResizeArray<obj option>
    /// Swaps to array elements.
    abstract swap: arr: ResizeArray<obj option> * i: float * j: float -> ResizeArray<obj option>
    /// Generates a copy of an array and removes the duplicate entries. The original
    /// Array will be altered.
    abstract uniqueArray: arr: ResizeArray<obj option> -> ResizeArray<obj option>
    /// Checks if an array contains an element equal to <tt>val</tt> but does not check the type!
    abstract isInArray: arr: ResizeArray<obj option> * ``val``: obj option -> bool
    /// Converts an array of {@link JXG.Coords} objects into a coordinate matrix.
    abstract coordsArrayToMatrix: coords: ResizeArray<obj option> * split: bool -> ResizeArray<obj option>
    /// Compare two arrays.
    abstract cmpArrays: a1: ResizeArray<obj option> * a2: ResizeArray<obj option> -> bool
    /// Removes an element from the given array
    abstract removeElementFromArray: ar: ResizeArray<obj option> * el: obj option -> ResizeArray<obj option>
    /// Truncate a number <tt>n</tt> after <tt>p</tt> decimals.
    abstract trunc: n: float * p: float -> float
    /// <summary>Replacement of the default toFixed() method.
    /// It does a correct rounding (independent of the browser) and
    /// returns "0.00" for toFixed(-0.000001, 2) instead of "-0.00" which
    /// is returned by JavaScript's toFixed()</summary>
    /// <param name="num">- Number tp be rounded</param>
    /// <param name="precision">- Decimal digits</param>
    abstract toFixed: num: float * precision: float -> string
    /// Truncate a number <tt>val</tt> automatically.
    abstract autoDigits: ``val``: obj option -> float
    /// <summary>Extracts the keys of a given object.</summary>
    /// <param name="object">- The object the keys are to be extracted</param>
    /// <param name="onlyOwn">- If true, hasOwnProperty() is used to verify that only keys are collected
    /// the object owns itself and not some other object in the prototype chain.</param>
    abstract keys: ``object``: obj option * onlyOwn: obj option -> ResizeArray<obj option>
    /// <summary>This outputs an object with a base class reference to the given object. This is useful if
    /// you need a copy of an e.g. attributes object and want to overwrite some of the attributes
    /// without changing the original object.</summary>
    /// <param name="obj">- Object to be embedded.</param>
    abstract clone: obj: obj option -> obj option
    /// <summary>Embeds an existing object into another one just like {@link #clone} and copies the contents of the second object
    /// to the new one. Warning: The copied properties of obj2 are just flat copies.</summary>
    /// <param name="obj">- Object to be copied.</param>
    /// <param name="obj2">- Object with data that is to be copied to the new one as well.</param>
    abstract cloneAndCopy: obj: obj option * obj2: obj option -> obj option
    /// Recursively merges obj2 into obj1. Contrary to {@link JXG#deepCopy} this won't create a new object
    /// but instead will overwrite obj1.
    abstract merge: obj1: obj option * obj2: obj option -> obj option
    /// <summary>Creates a deep copy of an existing object, i.e. arrays or sub-objects are copied component resp.
    /// element-wise instead of just copying the reference. If a second object is supplied, the two objects
    /// are merged into one object. The properties of the second object have priority.</summary>
    /// <param name="obj">- This object will be copied.</param>
    /// <param name="obj2">- This object will merged into the newly created object</param>
    /// <param name="toLower">- If true the keys are convert to lower case. This is needed for visProp, see JXG#copyAttributes</param>
    abstract deepCopy: obj: obj option * obj2: obj option * ?toLower: bool -> obj option
    /// <summary>Generates an attributes object that is filled with default values from the Options object
    /// and overwritten by the user specified attributes.</summary>
    /// <param name="attributes">- user specified attributes</param>
    /// <param name="options">- defaults options</param>
    /// <param name="s">- variable number of strings, e.g. 'slider', subtype 'point1'.</param>
    abstract copyAttributes: attributes: obj option * options: obj option * s: string -> obj option
    /// <summary>Converts a JavaScript object into a JSON string.</summary>
    /// <param name="obj">- A JavaScript object, functions will be ignored.</param>
    /// <param name="noquote">- No quotes around the name of a property.</param>
    abstract toJSON: obj: obj option * ?noquote: bool -> string
    /// Resets visPropOld.
    abstract clearVisPropOld: el: JXG.GeometryElement -> GeometryElement
    /// Checks if an object contains a key, whose value equals to val.
    abstract isInObject: obj: obj option * ``val``: obj option -> bool
    /// Replaces all occurences of &amp; by &amp;amp;, &gt; by &amp;gt;, and &lt; by &amp;lt;.
    abstract escapeHTML: str: string -> string
    /// Eliminates all substrings enclosed by &lt; and &gt; and replaces all occurences of
    /// &amp;amp; by &amp;, &amp;gt; by &gt;, and &amp;lt; by &lt;.
    abstract unescapeHTML: str: string -> string
    /// <summary>Makes a string lower case except for the first character which will be upper case.</summary>
    /// <param name="str">- Arbitrary string</param>
    abstract capitalize: str: string -> string
    /// Make numbers given as strings nicer by removing all unnecessary leading and trailing zeroes.
    abstract trimNumber: str: string -> string
    /// Filter an array of elements.
    abstract filterElements: list: ResizeArray<obj option> * filter: U2<obj option, (ResizeArray<obj option> -> obj option)> -> ResizeArray<obj option>
    /// Remove all leading and trailing whitespaces from a given string.
    abstract trim: str: string -> string
    /// Convert HTML tags to entities or use html_sanitize if the google caja html sanitizer is available.
    abstract sanitizeHTML: str: string * caja: bool -> string
    /// If <tt>s</tt> is a slider, it returns the sliders value, otherwise it just returns the given value.
    abstract evalSlider: s: obj option -> obj option

/// Constructor for a chart.
type [<AllowNullLiteral>] Chart =
    inherit JXG.Chart

/// Constructor for a chart.
type [<AllowNullLiteral>] ChartStatic =
    [<Emit "new $0($1...)">] abstract Create: x: ResizeArray<obj option> * y: ResizeArray<obj option> -> Chart

/// This element is used to provide a constructor for a chart legend.
/// Parameter is a pair of coordinates. The label names and  the label colors are
/// supplied in the attributes:
/// <ul>
/// <li> labels (Array): array of strings containing label names
/// <li> labelArray (Array): alternative array for label names (has precedence over 'labels')
/// <li> colors (Array): array of color values
/// <li> colorArray (Array): alternative array for color values (has precedence over 'colors')
/// <li> legendStyle or style: at the time being only 'vertical' is supported.
/// <li> rowHeight.
/// </ul>
type [<AllowNullLiteral>] Legend =
    inherit JXG.Legend

/// This element is used to provide a constructor for a chart legend.
/// Parameter is a pair of coordinates. The label names and  the label colors are
/// supplied in the attributes:
/// <ul>
/// <li> labels (Array): array of strings containing label names
/// <li> labelArray (Array): alternative array for label names (has precedence over 'labels')
/// <li> colors (Array): array of color values
/// <li> colorArray (Array): alternative array for color values (has precedence over 'colors')
/// <li> legendStyle or style: at the time being only 'vertical' is supported.
/// <li> rowHeight.
/// </ul>
type [<AllowNullLiteral>] LegendStatic =
    [<Emit "new $0($1...)">] abstract Create: x: float * y: float -> Legend

/// A circle consists of all points with a given distance from one point. This point is called center, the distance is called radius.
/// A circle can be constructed by providing a center and a point on the circle or a center and a radius (given as a number, function,
/// line, or circle).
type [<AllowNullLiteral>] Circle =
    inherit JXG.Circle
    /// If <tt>true</tt>, moving the mouse over inner points triggers hasPoint.
    abstract hasInnerPoints: bool with get, set
    /// Attributes for center point.
    abstract center: Point with get, set
    /// Attributes for circle label.
    /// Attributes for circle label.
    abstract label: Label with get, set
    /// Attributes for center point.
    abstract point: Point with get, set
    /// Attributes for circle label.
    /// Attributes for circle label.
    abstract label: Label with get, set

/// A circle consists of all points with a given distance from one point. This point is called center, the distance is called radius.
/// A circle can be constructed by providing a center and a point on the circle or a center and a radius (given as a number, function,
/// line, or circle).
type [<AllowNullLiteral>] CircleStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Circle

/// This element is used to provide a constructor for curve, which is just a wrapper for element {@link Curve}.
/// A curve is a mapping from R to R^2. t mapsto (x(t),y(t)). The graph is drawn for t in the interval [a,b].
/// <p>
/// The following types of curves can be plotted:
/// <ul>
/// <li> parametric curves: t mapsto (x(t),y(t)), where x() and y() are univariate functions.
/// <li> polar curves: curves commonly written with polar equations like spirals and cardioids.
/// <li> data plots: plot line segments through a given list of coordinates.
/// </ul>
type [<AllowNullLiteral>] Curve =
    inherit JXG.Curve
    /// The data points of the curve are not connected with straight lines but with bezier curves.
    abstract handDrawing: bool with get, set
    /// The curveType is set in {@link JXG.Curve#generateTerm} and used in {@link JXG.Curve#updateCurve}.
    /// Possible values are <ul>
    /// <li>'none'</li>
    /// <li>'plot': Data plot</li>
    /// <li>'parameter': we can not distinguish function graphs and parameter curves</li>
    /// <li>'functiongraph': function graph</li>
    /// <li>'polar'</li>
    /// <li>'implicit' (not yet)</li></ul>
    /// Only parameter and plot are set directly. Polar is set with {@link JXG.GeometryElement#setAttribute} only.
    abstract curveType: string with get, set
    /// Apply Ramer-Douglas-Peuker smoothing.
    abstract RDPsmoothing: bool with get, set
    /// Number of points used for plotting triggered by up events
    /// (i.e. high quality plotting) in case
    /// {@link Curve#doAdvancedPlot} is false.
    abstract numberPointsHigh: float with get, set
    /// Number of points used for plotting triggered by move events
    /// (i.e. lower quality plotting but fast) in case
    /// {@link Curve#doAdvancedPlot} is false.
    abstract numberPointsLow: float with get, set
    /// If true use a recursive bisection algorithm.
    /// It is slower, but usually the result is better. It tries to detect jumps
    /// and singularities.
    abstract doAdvancedPlot: bool with get, set
    /// Recursion depth used for plotting triggered by up events
    /// (i.e. high quality plotting) in case
    /// {@link Curve#doAdvancedPlot} is true.
    abstract recursionDepthHigh: float with get, set
    /// Number of points used for plotting triggered by move events in case
    /// (i.e. lower quality plotting but fast)
    /// {@link Curve#doAdvancedPlot} is true.
    abstract recursionDepthLow: float with get, set
    /// If true use the algorithm by Gillam and Hohenwarter, which was default until version 0.98.
    abstract doAdvancedPlotOld: bool with get, set

/// This element is used to provide a constructor for curve, which is just a wrapper for element {@link Curve}.
/// A curve is a mapping from R to R^2. t mapsto (x(t),y(t)). The graph is drawn for t in the interval [a,b].
/// <p>
/// The following types of curves can be plotted:
/// <ul>
/// <li> parametric curves: t mapsto (x(t),y(t)), where x() and y() are univariate functions.
/// <li> polar curves: curves commonly written with polar equations like spirals and cardioids.
/// <li> data plots: plot line segments through a given list of coordinates.
/// </ul>
type [<AllowNullLiteral>] CurveStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Curve

/// This element is used to provide a constructor for functiongraph,
/// which is just a wrapper for element {@link Curve} with {@link JXG.Curve#X}()
/// set to x. The graph is drawn for x in the interval [a,b].
type [<AllowNullLiteral>] Functiongraph =
    inherit JXG.Curve

/// This element is used to provide a constructor for functiongraph,
/// which is just a wrapper for element {@link Curve} with {@link JXG.Curve#X}()
/// set to x. The graph is drawn for x in the interval [a,b].
type [<AllowNullLiteral>] FunctiongraphStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Functiongraph

/// This element is used to provide a constructor for (natural) cubic spline curves.
/// Create a dynamic spline interpolated curve given by sample points p_1 to p_n.
type [<AllowNullLiteral>] Spline =
    inherit JXG.Curve

/// This element is used to provide a constructor for (natural) cubic spline curves.
/// Create a dynamic spline interpolated curve given by sample points p_1 to p_n.
type [<AllowNullLiteral>] SplineStatic =
    [<Emit "new $0($1...)">] abstract Create: board: JXG.Board * parents: ResizeArray<obj option> * attributes: obj option -> Spline

/// This element is used to provide a constructor for cardinal spline curves.
/// Create a dynamic cardinal spline interpolated curve given by sample points p_1 to p_n.
type [<AllowNullLiteral>] Cardinalspline =
    inherit JXG.Curve
    /// Controls if the data points of the cardinal spline when given as
    /// arrays should be converted into {@link JXG.Points}.
    abstract createPoints: bool with get, set
    /// If set to true, the supplied coordinates are interpreted as
    /// [[x_0, y_0], [x_1, y_1], p, ...].
    /// Otherwise, if the data consists of two arrays of equal length,
    /// it is interpreted as
    /// [[x_o x_1, ..., x_n], [y_0, y_1, ..., y_n]]
    abstract isArrayOfCoordinates: bool with get, set
    /// Attributes for the points generated by Cardinalspline in cases
    /// {@link createPoints} is set to true
    abstract points: obj option with get, set

/// This element is used to provide a constructor for cardinal spline curves.
/// Create a dynamic cardinal spline interpolated curve given by sample points p_1 to p_n.
type [<AllowNullLiteral>] CardinalsplineStatic =
    [<Emit "new $0($1...)">] abstract Create: board: JXG.Board * parents: ResizeArray<obj option> * attributes: obj option -> Cardinalspline

/// This element is used to provide a constructor for Riemann sums, which is realized as a special curve.
/// The returned element has the method Value() which returns the sum of the areas of the bars.
type [<AllowNullLiteral>] Riemannsum =
    inherit JXG.Curve

/// This element is used to provide a constructor for Riemann sums, which is realized as a special curve.
/// The returned element has the method Value() which returns the sum of the areas of the bars.
type [<AllowNullLiteral>] RiemannsumStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Riemannsum

/// This element is used to provide a constructor for trace curve (simple locus curve), which is realized as a special curve.
type [<AllowNullLiteral>] Tracecurve =
    inherit JXG.Curve
    /// The number of evaluated data points.
    abstract numberPoints: float with get, set

/// This element is used to provide a constructor for trace curve (simple locus curve), which is realized as a special curve.
type [<AllowNullLiteral>] TracecurveStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Tracecurve

/// This element is used to provide a constructor for step function, which is realized as a special curve.
/// 
/// In case the data points should be updated after creation time, they can be accessed by curve.xterm and curve.yterm.
type [<AllowNullLiteral>] Stepfunction =
    inherit JXG.Curve

/// This element is used to provide a constructor for step function, which is realized as a special curve.
/// 
/// In case the data points should be updated after creation time, they can be accessed by curve.xterm and curve.yterm.
type [<AllowNullLiteral>] StepfunctionStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Stepfunction

/// This element is used to provide a constructor for the graph showing
/// the (numerical) derivative of a given curve.
type [<AllowNullLiteral>] Derivative =
    inherit JXG.Curve

/// This element is used to provide a constructor for the graph showing
/// the (numerical) derivative of a given curve.
type [<AllowNullLiteral>] DerivativeStatic =
    [<Emit "new $0($1...)">] abstract Create: Parent: JXG.Curve -> Derivative

/// This element combines a given set of {@link JXG.Point} elements to a
/// group. The elements of the group and dependent elements can be translated, rotated and scaled by
/// dragging one of the group elements.
type [<AllowNullLiteral>] Group =
    inherit JXG.Group

/// This element combines a given set of {@link JXG.Point} elements to a
/// group. The elements of the group and dependent elements can be translated, rotated and scaled by
/// dragging one of the group elements.
type [<AllowNullLiteral>] GroupStatic =
    [<Emit "new $0($1...)">] abstract Create: board: JXG.Board * parents: ResizeArray<obj option> * attributes: obj option -> Group

/// Displays an image.
type [<AllowNullLiteral>] Image =
    inherit JXG.Image
    /// Defines the CSS class used by the image. CSS attributes defined in
    /// this class will overwrite the corresponding JSXGraph attributes, e.g.
    /// opacity.
    /// The default CSS class is defined in jsxgraph.css.
    abstract cssClass: string with get, set
    /// Defines the CSS class used by the image when highlighted.
    /// CSS attributes defined in this class will overwrite the
    /// corresponding JSXGraph attributes, e.g. highlightFillOpacity.
    /// The default CSS class is defined in jsxgraph.css.
    abstract highlightCssClass: string with get, set
    /// Image rotation in degrees.
    abstract rotate: float with get, set
    /// Defines together with {@link Image#snapSizeY} the grid the image snaps on to.
    /// The image will only snap on integer multiples to snapSizeX in x and snapSizeY in y direction.
    /// If this value is equal to or less than <tt>0</tt>, it will use the grid displayed by the major ticks
    /// of the default ticks of the default x axes of the board.
    abstract snapSizeX: float with get, set
    /// Defines together with {@link Image#snapSizeX} the grid the image snaps on to.
    /// The image will only snap on integer multiples to snapSizeX in x and snapSizeY in y direction.
    /// If this value is equal to or less than <tt>0</tt>, it will use the grid displayed by the major ticks
    /// of the default ticks of the default y axes of the board.
    abstract snapSizeY: float with get, set
    /// List of attractor elements. If the distance of the image is less than
    /// attractorDistance the image is made to glider of this element.
    abstract attractors: ResizeArray<obj option> with get, set

/// Displays an image.
type [<AllowNullLiteral>] ImageStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Image

/// This element is used to provide a constructor for a general line. A general line is given by two points. By setting additional properties
/// a line can be used as an arrow and/or axis.
type [<AllowNullLiteral>] Line =
    inherit JXG.Line
    /// Line has an arrow head at the position of its first point or the corresponding
    /// intersection with the canvas border
    /// 
    /// In case firstArrow is an object it has the sub-attributes:
    /// <pre>
    /// {
    ///    type: 1, // possible values are 1, 2, 3
    ///    size: 3,  // size of the arrow head.
    ///             //This value is multiplied with the strokeWidth of the line
    ///    highlightSize: 3, // size of the arrow head in case the element is highlighted
    /// }
    /// </pre>
    abstract firstArrow: obj option with get, set
    /// Line has an arrow head at the position of its second point or the corresponding
    /// intersection with the canvas border.
    /// 
    /// In case firstArrow is an object it has the sub-attributes:
    /// <pre>
    abstract lastArrow: obj option with get, set
    /// If true, line stretches infinitely in direction of its first point.
    /// Otherwise it ends at point1.
    abstract straightFirst: bool with get, set
    /// If true, line stretches infinitely in direction of its second point.
    /// Otherwise it ends at point2.
    abstract straightLast: bool with get, set
    /// Attributes for first defining point of the line.
    abstract point1: Point with get, set
    /// Attributes for second defining point of the line.
    abstract point2: Point with get, set
    /// Attributes for ticks of the line.
    abstract ticks: Ticks with get, set
    /// Attributes for the line label.
    abstract label: Label with get, set
    /// If set to true, the point will snap to a grid defined by
    /// {@link JXG.Point#snapSizeX} and {@link JXG.Point#snapSizeY}.
    abstract snapToGrid: bool with get, set
    /// Defines together with {@link JXG.Point#snapSizeY} the grid the point snaps on to.
    /// The point will only snap on integer multiples to snapSizeX in x and snapSizeY in y direction.
    /// If this value is equal to or less than <tt>0</tt>, it will use the grid displayed by the major ticks
    /// of the default ticks of the default x axes of the board.
    abstract snapSizeX: float with get, set
    /// Defines together with {@link JXG.Point#snapSizeX} the grid the point snaps on to.
    /// The point will only snap on integer multiples to snapSizeX in x and snapSizeY in y direction.
    /// If this value is equal to or less than <tt>0</tt>, it will use the grid displayed by the major ticks
    /// of the default ticks of the default y axes of the board.
    abstract snapSizeY: float with get, set
    /// If set to true and {@link Line#firstArrow} is set to true, the arrow head will just touch
    /// the circle line of the start point of the line.
    abstract touchFirstPoint: bool with get, set
    /// If set to true and {@link Line#lastArrow} is set to true, the arrow head will just touch
    /// the circle line of the start point of the line.
    abstract touchLastPoint: bool with get, set
    /// Line endings (linecap) of a straight line.
    /// Possible values are:
    /// <ul>
    /// <li> 'butt',
    /// <li> 'round',
    /// <li> 'square'.
    /// </ul>
    /// Not available for VML renderer.
    /// [lineCap description]
    abstract lineCap: string with get, set

/// This element is used to provide a constructor for a general line. A general line is given by two points. By setting additional properties
/// a line can be used as an arrow and/or axis.
type [<AllowNullLiteral>] LineStatic =
    [<Emit "new $0($1...)">] abstract Create: f: (ResizeArray<obj option> -> obj option) -> Line

/// This element is used to provide a constructor for a segment.
/// It's strictly spoken just a wrapper for element {@link Line} with {@link JXG.Line#straightFirst}
/// and {@link JXG.Line#straightLast} properties set to false. If there is a third variable then the
/// segment has a fixed length (which may be a function, too).
type [<AllowNullLiteral>] Segment =
    inherit JXG.Line

/// This element is used to provide a constructor for a segment.
/// It's strictly spoken just a wrapper for element {@link Line} with {@link JXG.Line#straightFirst}
/// and {@link JXG.Line#straightLast} properties set to false. If there is a third variable then the
/// segment has a fixed length (which may be a function, too).
type [<AllowNullLiteral>] SegmentStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Segment

/// This element is used to provide a constructor for arrow, which is just a wrapper for element {@link Line} with {@link JXG.Line#straightFirst}
/// and {@link JXG.Line#straightLast} properties set to false and {@link JXG.Line#lastArrow} set to true.
type [<AllowNullLiteral>] Arrow =
    inherit JXG.Line

/// This element is used to provide a constructor for arrow, which is just a wrapper for element {@link Line} with {@link JXG.Line#straightFirst}
/// and {@link JXG.Line#straightLast} properties set to false and {@link JXG.Line#lastArrow} set to true.
type [<AllowNullLiteral>] ArrowStatic =
    [<Emit "new $0($1...)">] abstract Create: a: obj * b: obj * c: Number_Number_Number -> Arrow

/// This element is used to provide a constructor for an axis. It's strictly spoken just a wrapper for element {@link Line} with {@link JXG.Line#straightFirst}
/// and {@link JXG.Line#straightLast} properties set to true. Additionally {@link JXG.Line#lastArrow} is set to true and default {@link Ticks} will be created.
type [<AllowNullLiteral>] Axis =
    inherit JXG.Line
    /// The ticks attached to the axis.
    abstract defaultTicks: JXG.Ticks with get, set
    /// Show / hide ticks.
    /// 
    /// Deprecated. Suggested alternative is "ticks: {visible: false}"
    abstract withTicks: bool with get, set
    /// Attributes for ticks of the axis.
    abstract ticks: Ticks with get, set
    /// Attributes for first point the axis.
    abstract point1: Point with get, set
    /// Attributes for second point the axis.
    abstract point2: Point with get, set
    /// Attributes for the axis label.
    abstract label: Label with get, set

/// This element is used to provide a constructor for an axis. It's strictly spoken just a wrapper for element {@link Line} with {@link JXG.Line#straightFirst}
/// and {@link JXG.Line#straightLast} properties set to true. Additionally {@link JXG.Line#lastArrow} is set to true and default {@link Ticks} will be created.
type [<AllowNullLiteral>] AxisStatic =
    [<Emit "new $0($1...)">] abstract Create: a: obj * b: obj * c: Number_Number_Number -> Axis

/// With the element tangent the slope of a line, circle, or curve in a certain point can be visualized. A tangent is always constructed
/// by a glider on a line, circle, or curve and describes the tangent in the glider point on that line, circle, or curve.
type [<AllowNullLiteral>] Tangent =
    inherit JXG.Line

/// With the element tangent the slope of a line, circle, or curve in a certain point can be visualized. A tangent is always constructed
/// by a glider on a line, circle, or curve and describes the tangent in the glider point on that line, circle, or curve.
type [<AllowNullLiteral>] TangentStatic =
    [<Emit "new $0($1...)">] abstract Create: g: Glider -> Tangent

/// This element is used to provide a constructor for the radical axis with respect to two circles with distinct centers.
/// The angular bisector of the polar lines of the circle centers with respect to the other circle is always the radical axis.
/// The radical axis passes through the intersection points when the circles intersect.
/// When a circle about the midpoint of circle centers, passing through the circle centers, intersects the circles, the polar lines pass through those intersection points.
type [<AllowNullLiteral>] RadicalAxis =
    inherit JXG.Line

/// This element is used to provide a constructor for the radical axis with respect to two circles with distinct centers.
/// The angular bisector of the polar lines of the circle centers with respect to the other circle is always the radical axis.
/// The radical axis passes through the intersection points when the circles intersect.
/// When a circle about the midpoint of circle centers, passing through the circle centers, intersects the circles, the polar lines pass through those intersection points.
type [<AllowNullLiteral>] RadicalAxisStatic =
    [<Emit "new $0($1...)">] abstract Create: circle: JXG.Circle * circle: JXG.Circle -> RadicalAxis

/// The polar line is the unique reciprocal relationship of a point with respect to a conic.
/// The lines through the intersections of a conic and the polar line of a point with respect to that conic and through that point are tangent to the conic.
/// A point on a conic has the polar line of that point with respect to that conic as the tangent line to that conic at that point.
/// See {@link http://en.wikipedia.org/wiki/Pole_and_polar} for more information on pole and polar.
type [<AllowNullLiteral>] PolarLine =
    inherit JXG.Line

/// The polar line is the unique reciprocal relationship of a point with respect to a conic.
/// The lines through the intersections of a conic and the polar line of a point with respect to that conic and through that point are tangent to the conic.
/// A point on a conic has the polar line of that point with respect to that conic as the tangent line to that conic at that point.
/// See {@link http://en.wikipedia.org/wiki/Pole_and_polar} for more information on pole and polar.
type [<AllowNullLiteral>] PolarLineStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> PolarLine

/// This element is used to provide a constructor for a general point. A free point is created if the given parent elements are all numbers
/// and the property fixed is not set or set to false. If one or more parent elements is not a number but a string containing a GEONE<sub>x</sub>T
/// constraint or a function the point will be considered as constrained). That means that the user won't be able to change the point's
/// position directly.
type [<AllowNullLiteral>] Point =
    inherit JXG.Point
    /// This attribute was used to determined the point layout. It was derived from GEONExT and was
    /// replaced by {@link Point#face} and {@link Point#size}.
    abstract style: float with get, set
    /// There are different point styles which differ in appearance.
    /// Posssible values are
    /// <table><tr><th>Value</th></tr>
    /// <tr><td>cross</td></tr>
    /// <tr><td>circle</td></tr>
    /// <tr><td>square</td></tr>
    /// <tr><td>plus</td></tr>
    /// <tr><td>diamond</td></tr>
    /// <tr><td>triangleUp</td></tr>
    /// <tr><td>triangleDown</td></tr>
    /// <tr><td>triangleLeft</td></tr>
    /// <tr><td>triangleRight</td></tr>
    /// </table>
    abstract face: string with get, set
    /// Size of a point, either in pixel or user coordinates.
    /// Means radius resp. half the width of a point (depending on the face).
    abstract size: float with get, set
    /// Unit for size.
    /// Possible values are 'screen' and 'user.
    abstract sizeUnit: string with get, set
    /// If true, the point size changes on zoom events.
    abstract zoom: bool with get, set
    /// If true, the infobox is shown on mouse over, else not.
    abstract showInfobox: bool with get, set
    /// Truncating rule for the digits in the infobox.
    /// <ul>
    /// <li>'auto': done automatically by JXG#autoDigits
    /// <li>'none': no truncation
    /// <li>number: truncate after "number digits" with JXG.toFixed();
    /// </ul>
    abstract infoboxDigits: obj option with get, set
    /// List of attractor elements. If the distance of the point is less than
    /// attractorDistance the point is made to glider of this element.
    abstract attractors: ResizeArray<obj option> with get, set
    /// Unit for attractorDistance and snatchDistance, used for magnetized points and for snapToPoints.
    /// Possible values are 'screen' and 'user.
    abstract attractorUnit: string with get, set
    /// If the distance of the point to one of its attractors is less
    /// than this number the point will be a glider on this
    /// attracting element.
    /// If set to zero nothing happens.
    abstract attractorDistance: float with get, set
    /// If the distance of the point to one of its attractors is at least
    /// this number the point will be released from being a glider on the
    /// attracting element.
    /// If set to zero nothing happens.
    abstract snatchDistance: float with get, set
    /// If set to true, the point will snap to a grid defined by
    /// {@link Point#snapSizeX} and {@link Point#snapSizeY}.
    abstract snapToGrid: bool with get, set
    /// Defines together with {@link Point#snapSizeY} the grid the point snaps on to.
    /// The point will only snap on integer multiples to snapSizeX in x and snapSizeY in y direction.
    /// If this value is equal to or less than <tt>0</tt>, it will use the grid displayed by the major ticks
    /// of the default ticks of the default x axes of the board.
    abstract snapSizeX: float with get, set
    /// Defines together with {@link Point#snapSizeX} the grid the point snaps on to.
    /// The point will only snap on integer multiples to snapSizeX in x and snapSizeY in y direction.
    /// If this value is equal to or less than <tt>0</tt>, it will use the grid displayed by the major ticks
    /// of the default ticks of the default y axes of the board.
    abstract snapSizeY: float with get, set
    /// If set to true, the point will snap to the nearest point in distance of
    /// {@link Point#attractorDistance}.
    abstract snapToPoints: bool with get, set
    /// List of elements which are ignored by snapToPoints.
    abstract ignoredSnapToPoints: ResizeArray<obj option> with get, set

/// This element is used to provide a constructor for a general point. A free point is created if the given parent elements are all numbers
/// and the property fixed is not set or set to false. If one or more parent elements is not a number but a string containing a GEONE<sub>x</sub>T
/// constraint or a function the point will be considered as constrained). That means that the user won't be able to change the point's
/// position directly.
type [<AllowNullLiteral>] PointStatic =
    [<Emit "new $0($1...)">] abstract Create: Point: obj * Transformation: JXG.Point_JXG.Transformation_Array -> Point

/// A glider is a point which lives on another geometric element like a line, circle, curve, turtle.
type [<AllowNullLiteral>] Glider =
    inherit JXG.Point
    /// <summary>Animate the point.</summary>
    /// <param name="direction">- The direction the glider is animated. Can be +1 or -1.</param>
    /// <param name="stepCount">- The number of steps in which the parent element is divided.
    /// Must be at least 1.</param>
    /// <param name="delay">- Time in msec between two animation steps. Default is 250.</param>
    abstract startAnimation: direction: float * stepCount: float * delay: float -> JXG.CoordsElement
    /// Stop animation.
    abstract stopAnimation: unit -> JXG.CoordsElement

/// A glider is a point which lives on another geometric element like a line, circle, curve, turtle.
type [<AllowNullLiteral>] GliderStatic =
    [<Emit "new $0($1...)">] abstract Create: z_: obj * x_: obj * y_: obj * GlideObject: Number_Number_Number_JXG.GeometryElement -> Glider

/// An intersection point is a point which lives on two Lines or Circles or one Line and one Circle at the same time, i.e.
/// an intersection point of the two elements.
type [<AllowNullLiteral>] Intersection =
    inherit JXG.Point

/// An intersection point is a point which lives on two Lines or Circles or one Line and one Circle at the same time, i.e.
/// an intersection point of the two elements.
type [<AllowNullLiteral>] IntersectionStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Intersection
    /// Used in {@link JXG.Intersection}.
    /// This flag sets the behaviour of intersection points of e.g.
    /// two segments. If true, the intersection is treated as intersection of lines. If false
    /// the intersection point exists if the segments intersect setwise.
    abstract alwaysIntersect: bool with get, set

/// An intersection point is a point which lives on two Lines or Circles or one Line and one Circle at the same time, i.e.
/// an intersection point of the two elements. Additionally, one intersection point is provided. The function returns the other intersection point.
type [<AllowNullLiteral>] OtherIntersection =
    inherit JXG.Point

/// An intersection point is a point which lives on two Lines or Circles or one Line and one Circle at the same time, i.e.
/// an intersection point of the two elements. Additionally, one intersection point is provided. The function returns the other intersection point.
type [<AllowNullLiteral>] OtherIntersectionStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> OtherIntersection

/// The pole point is the unique reciprocal relationship of a line with respect to a conic.
/// The lines tangent to the intersections of a conic and a line intersect at the pole point of that line with respect to that conic.
/// A line tangent to a conic has the pole point of that line with respect to that conic as the tangent point.
/// See {@link http://en.wikipedia.org/wiki/Pole_and_polar} for more information on pole and polar.
type [<AllowNullLiteral>] PolePoint =
    inherit JXG.Point

/// The pole point is the unique reciprocal relationship of a line with respect to a conic.
/// The lines tangent to the intersections of a conic and a line intersect at the pole point of that line with respect to that conic.
/// A line tangent to a conic has the pole point of that line with respect to that conic as the tangent point.
/// See {@link http://en.wikipedia.org/wiki/Pole_and_polar} for more information on pole and polar.
type [<AllowNullLiteral>] PolePointStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> PolePoint

/// A polygon is an area enclosed by a set of border lines which are determined by
/// <ul>
/// <li> a list of points or
/// <li> a list of coordinate arrays or
/// <li> a function returning a list of coordinate arrays.
/// </ul>
/// Each two consecutive points of the list define a line.
type [<AllowNullLiteral>] Polygon =
    inherit JXG.Polygon
    /// If <tt>true</tt>, moving the mouse over inner points triggers hasPoint.
    abstract hasInnerPoints: bool with get, set
    /// Is the polygon bordered by lines?
    abstract withLines: bool with get, set
    /// Attributes for the polygon border lines.
    abstract borders: Line with get, set
    /// Attributes for the polygon vertices.
    abstract vertices: Point with get, set
    /// Attributes for the polygon label.
    /// Attributes for the polygon label.
    abstract label: Label with get, set
    /// Attributes for the polygon label.
    /// Attributes for the polygon label.
    abstract label: Label with get, set

/// A polygon is an area enclosed by a set of border lines which are determined by
/// <ul>
/// <li> a list of points or
/// <li> a list of coordinate arrays or
/// <li> a function returning a list of coordinate arrays.
/// </ul>
/// Each two consecutive points of the list define a line.
type [<AllowNullLiteral>] PolygonStatic =
    [<Emit "new $0($1...)">] abstract Create: vertices: ResizeArray<obj option> -> Polygon

/// Constructs a regular polygon. It needs two points which define the base line and the number of vertices, or a set of points.
type [<AllowNullLiteral>] RegularPolygon =
    inherit Polygon
    /// If <tt>true</tt>, moving the mouse over inner points triggers hasPoint.
    abstract hasInnerPoints: bool with get, set
    /// Is the polygon bordered by lines?
    abstract withLines: bool with get, set
    /// Attributes for the polygon border lines.
    abstract borders: Line with get, set
    /// Attributes for the polygon vertices.
    abstract vertices: Point with get, set
    /// Attributes for the polygon label.
    abstract label: Label with get, set

/// Constructs a regular polygon. It needs two points which define the base line and the number of vertices, or a set of points.
type [<AllowNullLiteral>] RegularPolygonStatic =
    [<Emit "new $0($1...)">] abstract Create: p1: obj * p2: obj * n: JXG.Point_JXG.Point_Number -> RegularPolygon

/// Construct and handle texts.
/// 
/// The coordinates can be relative to the coordinates of an element
/// given in {@link JXG.Options#text.anchor}.
/// 
/// MathJaX, HTML and GEONExT syntax can be handled.
type [<AllowNullLiteral>] Text =
    inherit JXG.Text
    /// The font size in pixels.
    abstract fontSize: float with get, set
    /// Used to round texts given by a number.
    abstract digits: float with get, set
    /// If set to true, the text is parsed and evaluated.
    /// For labels parse==true results in converting names of the form k_a to subscripts.
    /// If the text is given by string and parse==true, the string is parsed as
    /// JessieCode expression.
    abstract parse: bool with get, set
    /// If set to true and caja's sanitizeHTML function can be found it
    /// will be used to sanitize text output.
    abstract useCaja: bool with get, set
    /// If enabled, the text will be handled as label. Intended for internal use.
    abstract isLabel: bool with get, set
    /// Default CSS properties of the HTML text element.
    /// <p>
    /// The CSS properties which are set here, are handed over to the style property
    /// of the HTML text element. That means, they have higher property than any
    /// CSS class.
    /// <p>
    /// If a property which is set here should be overruled by a CSS class
    /// then this property should be removed here.
    /// <p>
    /// The reason, why this attribute should be kept to its default value at all,
    /// is that screen dumps of SVG boards with <tt>board.renderer.dumpToCanvas()</tt>
    /// will ignore the font-family if it is set in a CSS class.
    /// It has to be set explicitly as style attribute.
    /// <p>
    /// In summary, the order of priorities from high to low is
    /// <ol>
    /// <li> JXG.Options.text.cssStyle
    /// <li> JXG.Options.text.cssDefaultStyle
    /// <li> JXG.Options.text.cssClass
    /// </ol>
    abstract cssDefaultStyle: string with get, set
    /// Default CSS properties of the HTML text element in case of highlighting.
    /// <p>
    /// The CSS properties which are set here, are haded over to the style property
    /// of the HTML text element. That means, they have higher property than any
    /// CSS class.
    abstract highlightCssDefaultStyle: string with get, set
    /// CSS properties of the HTML text element.
    /// <p>
    /// The CSS properties which are set here, are haded over to the style property
    /// of the HTML text element. That means, they have higher property than any
    /// CSS class.
    abstract cssStyle: string with get, set
    /// CSS properties of the HTML text element in case of highlighting.
    /// <p>
    /// The CSS properties which are set here, are haded over to the style property
    /// of the HTML text element. That means, they have higher property than any
    /// CSS class.
    abstract highlightCssStyle: string with get, set
    /// If true the input will be given to ASCIIMathML before rendering.
    abstract useASCIIMathML: bool with get, set
    /// If true MathJax will be used to render the input string.
    abstract useMathJax: bool with get, set
    /// Determines the rendering method of the text. Possible values
    /// include <tt>'html'</tt> and <tt>'internal</tt>.
    abstract display: string with get, set
    /// Anchor element {@link Point}, {@link Text} or {@link Image} of the text. If it exists, the coordinates of the text are relative
    /// to this anchor element.
    abstract anchor: obj option with get, set
    /// The horizontal alignment of the text. Possible values include <tt>'auto</tt>, <tt>'left'</tt>, <tt>'middle'</tt>, and
    /// <tt>'right'</tt>.
    abstract anchorX: string with get, set
    /// The vertical alignment of the text. Possible values include <tt>'auto</tt>, <tt>'top'</tt>, <tt>'middle'</tt>, and
    /// <tt>'bottom'</tt>.
    abstract anchorY: string with get, set
    /// CSS class of the text in non-highlighted view.
    abstract cssClass: string with get, set
    /// CSS class of the text in highlighted view.
    abstract highlightCssClass: string with get, set
    /// Sensitive area for dragging the text.
    /// Possible values are 'all', or something else.
    /// If set to 'small', a sensitivity margin at the right and left border is taken.
    /// This may be extended to left, right, ... in the future.
    abstract dragArea: string with get, set
    /// Text rotation in degrees.
    /// Works for non-zero values only in combination with display=='internal'.
    abstract rotate: float with get, set
    /// Defines together with {@link Text#snapSizeY} the grid the text snaps on to.
    /// The text will only snap on integer multiples to snapSizeX in x and snapSizeY in y direction.
    /// If this value is equal to or less than <tt>0</tt>, it will use the grid displayed by the major ticks
    /// of the default ticks of the default x axes of the board.
    abstract snapSizeX: float with get, set
    /// Defines together with {@link Text#snapSizeX} the grid the text snaps on to.
    /// The text will only snap on integer multiples to snapSizeX in x and snapSizeY in y direction.
    /// If this value is equal to or less than <tt>0</tt>, it will use the grid displayed by the major ticks
    /// of the default ticks of the default y axes of the board.
    abstract snapSizeY: float with get, set
    /// List of attractor elements. If the distance of the text is less than
    /// attractorDistance the text is made to glider of this element.
    abstract attractors: ResizeArray<obj option> with get, set

/// Construct and handle texts.
/// 
/// The coordinates can be relative to the coordinates of an element
/// given in {@link JXG.Options#text.anchor}.
/// 
/// MathJaX, HTML and GEONExT syntax can be handled.
type [<AllowNullLiteral>] TextStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Text

/// Labels are text objects tied to other elements like points, lines and curves.
/// Labels are handled internally by JSXGraph, only. There is NO constructor "board.create('label', ...)".
type [<AllowNullLiteral>] Label =
    inherit JXG.Text
    /// Possible string values for the position of a label for
    /// label anchor points are:
    /// <ul>
    /// <li> 'lft'
    /// <li> 'rt'
    /// <li> 'top'
    /// <li> 'bot'
    /// <li> 'ulft'
    /// <li> 'urt'
    /// <li> 'llft'
    /// <li> 'lrt'
    /// </ul>
    /// This is relevant for non-points: line, circle, curve.
    /// 
    /// The names have been borrowed from <a href="https://www.tug.org/metapost.html">MetaPost</a>.
    abstract position: string with get, set
    /// Label offset from label anchor
    /// The label anchor is determined by JXG.GeometryElement#label.position
    abstract offset: ResizeArray<obj option> with get, set
    /// Automatic position of label text. When called first, the positioning algorithm
    /// starts at the position defined by offset.
    /// The algorithm tries to find a position with the least number of
    /// overlappings with other elements, while retaining the distance
    /// to the anchor element.
    abstract autoPosition: bool with get, set

/// Labels are text objects tied to other elements like points, lines and curves.
/// Labels are handled internally by JSXGraph, only. There is NO constructor "board.create('label', ...)".
type [<AllowNullLiteral>] LabelStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Label

/// Ticks are used as distance markers on a line.
type [<AllowNullLiteral>] Ticks =
    inherit JXG.Ticks
    /// A function that expects two {@link JXG.Coords}, the first one representing the coordinates of the
    /// tick that is to be labeled, the second one the coordinates of the center (the tick with position 0).
    abstract generateLabelText: (ResizeArray<obj option> -> obj option) with get, set
    /// A function that expects two {@link JXG.Coords}, the first one representing the coordinates of the
    /// tick that is to be labeled, the second one the coordinates of the center (the tick with position 0).
    abstract generateLabelValue: (ResizeArray<obj option> -> obj option) with get, set
    /// Draw labels yes/no
    abstract drawLabels: bool with get, set
    /// Use the unicode character 0x2212, i.e. the HTML entity &amp;minus; as minus sign.
    /// That is &minus;1 instead of -1.
    abstract useUnicodeMinus: bool with get, set
    /// Determine the position of the tick with value 0. 'left' means point1 of the line, 'right' means point2,
    /// and 'middle' is equivalent to the midpoint of the defining points. This attribute is ignored if the parent
    /// line is of type axis and is parallel to either the x (i.e. y = 0) or the y (i.e. x = 0) axis.
    abstract anchor: string with get, set
    /// Draw the zero tick, that lies at line.point1?
    abstract drawZero: bool with get, set
    /// If the distance between two ticks is too big we could insert new ticks. If insertTicks
    /// is <tt>true</tt>, we'll do so, otherwise we leave the distance as is.
    /// This option is ignored if equidistant is false. In the example below the distance between
    /// two ticks is given as <tt>1</tt> but because insertTicks is set to true many ticks will
    /// be omitted in the rendering process to keep the display clear.
    abstract insertTicks: bool with get, set
    /// Total height of a minor tick. If negative the full height of the board is taken.
    abstract minorHeight: float with get, set
    /// Total height of a major tick. If negative the full height of the board is taken.
    abstract majorHeight: float with get, set
    /// Decides in which direction finite ticks are visible. Possible values are either the constants
    /// 0=false or 1=true or a function returning 0 or 1.
    /// 
    /// In case of [0,1] the tick is only visible to the right of the line. In case of
    /// [1,0] the tick is only visible to the left of the line.
    abstract tickEndings: ResizeArray<obj option> with get, set
    /// The number of minor ticks between two major ticks.
    abstract minorTicks: float with get, set
    /// Scale the ticks but not the tick labels.
    abstract scale: float with get, set
    /// A string that is appended to every tick, used to represent the scale
    /// factor given in {@link JXG.Ticks#scaleSymbol}.
    abstract scaleSymbol: string with get, set
    /// User defined labels for special ticks. Instead of the i-th tick's position, the i-th string stored in this array
    /// is shown. If the number of strings in this array is less than the number of special ticks, the tick's position is
    /// shown as a fallback.
    abstract labels: ResizeArray<obj option> with get, set
    /// The maximum number of characters a tick label can use.
    abstract maxLabelLength: float with get, set
    /// If a label exceeds {@link JXG.Ticks#maxLabelLength} this determines the precision used to shorten the tick label.
    abstract precision: float with get, set
    /// The default distance between two ticks. Please be aware that this value does not have
    /// to be used if {@link JXG.Ticks#insertTicks} is set to true.
    abstract ticksDistance: float with get, set
    /// Whether line boundaries should be counted or not in the lower and upper bounds when
    /// creating ticks.
    abstract includeBoundaries: bool with get, set

/// Ticks are used as distance markers on a line.
type [<AllowNullLiteral>] TicksStatic =
    [<Emit "new $0($1...)">] abstract Create: line: JXG.Line * distance: float -> Ticks

/// Hatches can be used to mark congruent lines.
type [<AllowNullLiteral>] Hatch =
    inherit JXG.Ticks

/// Hatches can be used to mark congruent lines.
type [<AllowNullLiteral>] HatchStatic =
    [<Emit "new $0($1...)">] abstract Create: line: JXG.Line * numberofhashes: float -> Hatch

/// A transformation consists of a 3x3 matrix, i.e. it is a projective transformation.
type [<AllowNullLiteral>] Transformation =
    inherit JXG.Transformation

/// A transformation consists of a 3x3 matrix, i.e. it is a projective transformation.
type [<AllowNullLiteral>] TransformationStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Transformation

/// Creates a new turtle
type [<AllowNullLiteral>] Turtle =
    inherit JXG.Turtle
    /// Attributes for the turtle arrow.
    abstract arrow: Curve with get, set
    /// <summary>Move the turtle forward.</summary>
    /// <param name="len">- of forward move in user coordinates</param>
    abstract forward: len: float -> JXG.Turtle
    /// <summary>Move the turtle backwards.</summary>
    /// <param name="len">- of backwards move in user coordinates</param>
    abstract back: len: float -> JXG.Turtle
    /// <summary>Rotate the turtle direction to the right</summary>
    /// <param name="angle">- of the rotation in degrees</param>
    abstract right: angle: float -> JXG.Turtle
    /// <summary>Rotate the turtle direction to the right.</summary>
    /// <param name="angle">- of the rotation in degrees</param>
    abstract left: angle: float -> JXG.Turtle
    /// Pen up, stops visible drawing
    abstract penUp: unit -> JXG.Turtle
    /// Pen down, continues visible drawing
    abstract penDown: unit -> JXG.Turtle
    /// Removes the turtle curve from the board. The turtle stays in its position.
    abstract clean: unit -> JXG.Turtle
    /// Removes the turtle completely and resets it to its initial position and direction.
    abstract clearScreen: unit -> JXG.Turtle
    /// <summary>Moves the turtle without drawing to a new position</summary>
    /// <param name="x">- new x- coordinate</param>
    /// <param name="y">- new y- coordinate</param>
    abstract setPos: x: float * y: float -> JXG.Turtle
    /// Sets the pen size. Equivalent to setAttribute({strokeWidth:size})
    /// but affects only the future turtle.
    abstract setPenSize: size: float -> JXG.Turtle
    /// Sets the pen color. Equivalent to setAttribute({strokeColor:color})
    /// but affects only the future turtle.
    abstract setPenColor: color: string -> JXG.Turtle
    /// Sets the highlight pen color. Equivalent to setAttribute({highlightStrokeColor:color})
    /// but affects only the future turtle.
    abstract setHighlightPenColor: color: string -> JXG.Turtle
    /// <summary>Sets properties of the turtle, see also {@link JXG.GeometryElement#setAttribute}.
    /// Sets the property for all curves of the turtle in the past and in the future.</summary>
    /// <param name="attributes">- key:value pairs</param>
    abstract setAttribute: attributes: obj option -> JXG.Turtle
    /// Sets the visibility of the turtle head to true,
    abstract showTurtle: unit -> JXG.Turtle
    /// Sets the visibility of the turtle head to false,
    abstract hideTurtle: unit -> JXG.Turtle
    /// Moves the turtle to position [0,0].
    abstract home: unit -> JXG.Turtle
    /// Pushes the position of the turtle on the stack.
    abstract pushTurtle: unit -> JXG.Turtle
    /// Gets the last position of the turtle on the stack, sets the turtle to this position and removes this
    /// position from the stack.
    abstract popTurtle: unit -> JXG.Turtle
    /// <summary>Rotates the turtle into a new direction.
    /// There are two possibilities:</summary>
    /// <param name="target">- If a number is given, it is interpreted as the new direction to look to; If an array
    /// consisting of two Numbers is given targeted is used as a pair coordinates.</param>
    abstract lookTo: target: U2<float, ResizeArray<obj option>> -> JXG.Turtle
    /// <summary>Moves the turtle to a given coordinate pair.
    /// The direction is not changed.</summary>
    /// <param name="target">- Coordinates of the point where the turtle looks to.</param>
    abstract moveTo: target: ResizeArray<obj option> -> JXG.Turtle
    /// Alias for {@link JXG.Turtle#forward}
    abstract fd: unit -> unit
    /// Alias for {@link JXG.Turtle#back}
    abstract bk: unit -> unit
    /// Alias for {@link JXG.Turtle#left}
    abstract lt: unit -> unit
    /// Alias for {@link JXG.Turtle#right}
    abstract rt: unit -> unit
    /// Alias for {@link JXG.Turtle#penUp}
    abstract pu: unit -> unit
    /// Alias for {@link JXG.Turtle#penDown}
    abstract pd: unit -> unit
    /// Alias for {@link JXG.Turtle#hideTurtle}
    abstract ht: unit -> unit
    /// Alias for {@link JXG.Turtle#showTurtle}
    abstract st: unit -> unit
    /// Alias for {@link JXG.Turtle#clearScreen}
    abstract cs: unit -> unit
    /// Alias for {@link JXG.Turtle#pushTurtle}
    abstract push: unit -> unit
    /// Alias for {@link JXG.Turtle#popTurtle}
    abstract pop: unit -> unit
    /// <summary>The "co"-coordinate of the turtle curve at position t is returned.</summary>
    /// <param name="t">- parameter</param>
    abstract evalAt: t: float -> float
    /// <summary>if t is not supplied the x-coordinate of the turtle is returned. Otherwise
    /// the x-coordinate of the turtle curve at position t is returned.</summary>
    /// <param name="t">- parameter</param>
    abstract X: t: float -> float
    /// <summary>if t is not supplied the y-coordinate of the turtle is returned. Otherwise
    /// the y-coordinate of the turtle curve at position t is returned.</summary>
    /// <param name="t">- parameter</param>
    abstract Y: t: float -> float
    abstract Z: unit -> float
    /// Gives the lower bound of the parameter if the the turtle is treated as parametric curve.
    abstract minX: unit -> unit
    /// Gives the upper bound of the parameter if the the turtle is treated as parametric curve.
    /// May be overwritten in @see generateTerm.
    abstract maxX: unit -> unit
    /// <summary>Checks whether (x,y) is near the curve.</summary>
    /// <param name="x">- Coordinate in x direction, screen coordinates.</param>
    /// <param name="y">- Coordinate in y direction, screen coordinates.</param>
    abstract hasPoint: x: float * y: float -> bool

/// Creates a new turtle
type [<AllowNullLiteral>] TurtleStatic =
    [<Emit "new $0($1...)">] abstract Create: board: JXG.Board * parents: ResizeArray<obj option> * attributes: obj option -> Turtle

/// An arc is a segment of the circumference of a circle. It is defined by a center, one point that
/// defines the radius, and a third point that defines the angle of the arc.
type [<AllowNullLiteral>] Arc =
    inherit Curve
    /// Center of the arc.
    /// Center of the arc.
    abstract center: JXG.Point with get, set
    /// Point defining the arc's radius.
    /// Point defining the arc's radius.
    abstract radiuspoint: JXG.Point with get, set
    /// The point defining the arc's angle.
    abstract anglepoint: JXG.Point with get, set
    /// Determines the arc's current radius. I.e. the distance between {@link Arc#center} and {@link Arc#radiuspoint}.
    abstract Radius: unit -> float
    abstract getRadius: unit -> float
    /// Returns the length of the arc.
    abstract Value: unit -> float
    /// <summary>Checks whether (x,y) is within the sector defined by the arc.</summary>
    /// <param name="x">- Coordinate in x direction, screen coordinates.</param>
    /// <param name="y">- Coordinate in y direction, screen coordinates.</param>
    abstract hasPointSector: x: float * y: float -> bool
    /// Type of arc. Possible values are 'minor', 'major', and 'auto'.
    abstract selection: string with get, set
    /// If <tt>true</tt>, moving the mouse over inner points triggers hasPoint.
    abstract hasInnerPoints: bool with get, set
    /// Center of the arc.
    /// Center of the arc.
    abstract center: JXG.Point with get, set
    /// Point defining the arc's radius.
    /// Point defining the arc's radius.
    abstract radiuspoint: JXG.Point with get, set
    /// Attributes for angle point.
    abstract anglePoint: Point with get, set

/// An arc is a segment of the circumference of a circle. It is defined by a center, one point that
/// defines the radius, and a third point that defines the angle of the arc.
type [<AllowNullLiteral>] ArcStatic =
    [<Emit "new $0($1...)">] abstract Create: p1: obj * p2: obj * p3: JXG.Point_JXG.Point_JXG.Point -> Arc

/// A semicircle is a special arc defined by two points. The arc hits both points.
type [<AllowNullLiteral>] Semicircle =
    inherit Arc
    /// The midpoint of the two defining points.
    abstract midpoint: Midpoint with get, set
    /// Attributes for center point of the semicircle.
    abstract center: Point with get, set
    /// Point defining the arc's radius.
    abstract radiuspoint: JXG.Point with get, set

/// A semicircle is a special arc defined by two points. The arc hits both points.
type [<AllowNullLiteral>] SemicircleStatic =
    [<Emit "new $0($1...)">] abstract Create: p1: obj * p2: JXG.Point_JXG.Point -> Semicircle

/// A circumcircle arc is an {@link Arc} defined by three points. All three points lie on the arc.
type [<AllowNullLiteral>] CircumcircleArc =
    inherit Arc
    /// The midpoint of the circumcircle of the three points defining the circumcircle arc.
    /// The midpoint of the circumcircle of the three points defining the circumcircle arc.
    abstract center: Circumcenter with get, set
    /// The midpoint of the circumcircle of the three points defining the circumcircle arc.
    /// The midpoint of the circumcircle of the three points defining the circumcircle arc.
    abstract center: Circumcenter with get, set
    /// Point defining the arc's radius.
    abstract radiuspoint: JXG.Point with get, set

/// A circumcircle arc is an {@link Arc} defined by three points. All three points lie on the arc.
type [<AllowNullLiteral>] CircumcircleArcStatic =
    [<Emit "new $0($1...)">] abstract Create: p1: obj * p2: obj * p3: JXG.Point_JXG.Point_JXG.Point -> CircumcircleArc

/// A minor arc is a segment of the circumference of a circle having measure less than or equal to
/// 180 degrees (pi radians). It is defined by a center, one point that
/// defines the radius, and a third point that defines the angle of the arc.
type [<AllowNullLiteral>] MinorArc =
    inherit Curve

/// A minor arc is a segment of the circumference of a circle having measure less than or equal to
/// 180 degrees (pi radians). It is defined by a center, one point that
/// defines the radius, and a third point that defines the angle of the arc.
type [<AllowNullLiteral>] MinorArcStatic =
    [<Emit "new $0($1...)">] abstract Create: p1: obj * p2: obj * p3: JXG.Point_JXG.Point_JXG.Point -> MinorArc

/// A major arc is a segment of the circumference of a circle having measure greater than or equal to
/// 180 degrees (pi radians). It is defined by a center, one point that
/// defines the radius, and a third point that defines the angle of the arc.
type [<AllowNullLiteral>] MajorArc =
    inherit Curve

/// A major arc is a segment of the circumference of a circle having measure greater than or equal to
/// 180 degrees (pi radians). It is defined by a center, one point that
/// defines the radius, and a third point that defines the angle of the arc.
type [<AllowNullLiteral>] MajorArcStatic =
    [<Emit "new $0($1...)">] abstract Create: p1: obj * p2: obj * p3: JXG.Point_JXG.Point_JXG.Point -> MajorArc

/// This element is used to provide a constructor for special texts containing a
/// form button element.
/// <p>
/// For this element, the attribute "display" has to have the value 'html' (which is the default).
type [<AllowNullLiteral>] Button =
    inherit Text
    /// Control the attribute "disabled" of the HTML button.
    abstract disabled: bool with get, set

/// This element is used to provide a constructor for special texts containing a
/// form button element.
/// <p>
/// For this element, the attribute "display" has to have the value 'html' (which is the default).
type [<AllowNullLiteral>] ButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Button

/// This element is used to provide a constructor for special texts containing a
/// form checkbox element.
/// <p>
/// For this element, the attribute "display" has to have the value 'html' (which is the default).
type [<AllowNullLiteral>] Checkbox =
    inherit Text
    /// Control the attribute "disabled" of the HTML checkbox.
    abstract disabled: bool with get, set
    /// Control the attribute "checked" of the HTML checkbox.
    abstract ``checked``: bool with get, set

/// This element is used to provide a constructor for special texts containing a
/// form checkbox element.
/// <p>
/// For this element, the attribute "display" has to have the value 'html' (which is the default).
type [<AllowNullLiteral>] CheckboxStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Checkbox

/// A comb to display domains of inequalities.
type [<AllowNullLiteral>] Comb =
    inherit JXG.Curve
    /// Frequency of comb elements.
    abstract frequency: float with get, set
    /// Width of the comb.
    abstract width: float with get, set
    /// Angle under which comb elements are positioned.
    abstract angle: float with get, set
    /// Should the comb go right to left instead of left to right.
    abstract reverse: bool with get, set
    /// Attributes for first defining point of the comb.
    abstract point1: Point with get, set
    /// Attributes for second defining point of the comb.
    abstract point2: Point with get, set
    /// Attributes for the curve displaying the comb.
    abstract curve: Curve with get, set

/// A comb to display domains of inequalities.
type [<AllowNullLiteral>] CombStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Comb

/// An orthogonal projection is given by a point and a line. It is determined by projecting the given point
/// orthogonal onto the given line.
type [<AllowNullLiteral>] Orthogonalprojection =
    inherit JXG.Point

/// An orthogonal projection is given by a point and a line. It is determined by projecting the given point
/// orthogonal onto the given line.
type [<AllowNullLiteral>] OrthogonalprojectionStatic =
    [<Emit "new $0($1...)">] abstract Create: p: obj * l: JXG.Line_JXG.Point -> Orthogonalprojection

/// A perpendicular is a composition of two elements: a line and a point. The line is orthogonal
/// to a given line and contains a given point.
type [<AllowNullLiteral>] Perpendicular =
    inherit Segment

/// A perpendicular is a composition of two elements: a line and a point. The line is orthogonal
/// to a given line and contains a given point.
type [<AllowNullLiteral>] PerpendicularStatic =
    [<Emit "new $0($1...)">] abstract Create: l: obj * p: JXG.Line_JXG.Point -> Perpendicular

/// A perpendicular point is given by a point and a line. It is determined by projecting the given point
/// orthogonal onto the given line. This element should be used in GEONExTReader only. All other applications should
/// use orthogonal projection {@link Orthogonalprojection}.
type [<AllowNullLiteral>] PerpendicularPoint =
    inherit JXG.Point

/// A perpendicular point is given by a point and a line. It is determined by projecting the given point
/// orthogonal onto the given line. This element should be used in GEONExTReader only. All other applications should
/// use orthogonal projection {@link Orthogonalprojection}.
type [<AllowNullLiteral>] PerpendicularPointStatic =
    [<Emit "new $0($1...)">] abstract Create: p: obj * l: JXG.Line_JXG.Point -> PerpendicularPoint

/// A perpendicular is a composition of two elements: a line segment and a point. The line segment is orthogonal
/// to a given line and contains a given point and meets the given line in the perpendicular point.
type [<AllowNullLiteral>] PerpendicularSegment =
    inherit Segment
    /// Helper point
    abstract point: PerpendicularPoint with get, set

/// A perpendicular is a composition of two elements: a line segment and a point. The line segment is orthogonal
/// to a given line and contains a given point and meets the given line in the perpendicular point.
type [<AllowNullLiteral>] PerpendicularSegmentStatic =
    [<Emit "new $0($1...)">] abstract Create: l: obj * p: JXG.Line_JXG.Point -> PerpendicularSegment

/// A midpoint is given by two points. It is collinear to the given points and the distance
/// is the same to each of the given points, i.e. it is in the middle of the given points.
type [<AllowNullLiteral>] Midpoint =
    inherit JXG.Point

/// A midpoint is given by two points. It is collinear to the given points and the distance
/// is the same to each of the given points, i.e. it is in the middle of the given points.
type [<AllowNullLiteral>] MidpointStatic =
    [<Emit "new $0($1...)">] abstract Create: p1: obj * p2: JXG.Point_JXG.Point * l: JXG.Line -> Midpoint

/// A parallel point is given by three points. Taking the Euclidean vector from the first to the
/// second point, the parallel point is determined by adding that vector to the third point.
/// The line determined by the first two points is parallel to the line determined by the third point and the constructed point.
type [<AllowNullLiteral>] Parallelpoint =
    inherit JXG.Point

/// A parallel point is given by three points. Taking the Euclidean vector from the first to the
/// second point, the parallel point is determined by adding that vector to the third point.
/// The line determined by the first two points is parallel to the line determined by the third point and the constructed point.
type [<AllowNullLiteral>] ParallelpointStatic =
    [<Emit "new $0($1...)">] abstract Create: p1: obj * p2: obj * p3: JXG.Point_JXG.Point_JXG.Point * l: obj * p: JXG.Line_JXG.Point -> Parallelpoint

/// A parallel is a line through a given point with the same slope as a given line.
type [<AllowNullLiteral>] Parallel =
    inherit Line
    /// Helper point used to create the parallel line. This point lies on the line at infinity, hence it's not visible,
    /// not even with visible set to <tt>true</tt>. Creating another line through this point would make that other line
    /// parallel to the create parallel.
    /// Helper point used to create the parallel line. This point lies on the line at infinity, hence it's not visible,
    /// not even with visible set to <tt>true</tt>. Creating another line through this point would make that other line
    /// parallel to the create parallel.
    abstract point: JXG.Point with get, set
    /// Helper point used to create the parallel line. This point lies on the line at infinity, hence it's not visible,
    /// not even with visible set to <tt>true</tt>. Creating another line through this point would make that other line
    /// parallel to the create parallel.
    /// Helper point used to create the parallel line. This point lies on the line at infinity, hence it's not visible,
    /// not even with visible set to <tt>true</tt>. Creating another line through this point would make that other line
    /// parallel to the create parallel.
    abstract point: JXG.Point with get, set

/// A parallel is a line through a given point with the same slope as a given line.
type [<AllowNullLiteral>] ParallelStatic =
    [<Emit "new $0($1...)">] abstract Create: l: obj * p: JXG.Line_JXG.Point -> Parallel

/// An arrow parallel is a parallel segment with an arrow attached.
type [<AllowNullLiteral>] Arrowparallel =
    inherit Parallel
    /// Helper point used to create the parallel line. This point lies on the line at infinity, hence it's not visible,
    /// not even with visible set to <tt>true</tt>. Creating another line through this point would make that other line
    /// parallel to the create parallel.
    abstract point: JXG.Point with get, set

/// An arrow parallel is a parallel segment with an arrow attached.
type [<AllowNullLiteral>] ArrowparallelStatic =
    [<Emit "new $0($1...)">] abstract Create: l: obj * p: JXG.Line_JXG.Point -> Arrowparallel

/// A normal is a line through a given point on a element of type line, circle, curve, or turtle and orthogonal to that object.
type [<AllowNullLiteral>] Normal =
    inherit JXG.Line
    /// A helper point used to create a normal to a {@link JXG.Line} object. For normals to circles or curves this
    /// element is <tt>undefined</tt>.
    /// A helper point used to create a normal to a {@link JXG.Line} object. For normals to circles or curves this
    /// element is <tt>undefined</tt>.
    abstract point: JXG.Point with get, set
    /// A helper point used to create a normal to a {@link JXG.Line} object. For normals to circles or curves this
    /// element is <tt>undefined</tt>.
    /// A helper point used to create a normal to a {@link JXG.Line} object. For normals to circles or curves this
    /// element is <tt>undefined</tt>.
    abstract point: JXG.Point with get, set

/// A normal is a line through a given point on a element of type line, circle, curve, or turtle and orthogonal to that object.
type [<AllowNullLiteral>] NormalStatic =
    [<Emit "new $0($1...)">] abstract Create: p: Glider -> Normal

/// A bisector is a line which divides an angle into two equal angles. It is given by three points A, B, and
/// C and divides the angle ABC into two equal sized parts.
type [<AllowNullLiteral>] Bisector =
    inherit JXG.Line
    /// Helper point
    /// Helper point
    abstract point: Point with get, set
    /// Helper point
    /// Helper point
    abstract point: Point with get, set

/// A bisector is a line which divides an angle into two equal angles. It is given by three points A, B, and
/// C and divides the angle ABC into two equal sized parts.
type [<AllowNullLiteral>] BisectorStatic =
    [<Emit "new $0($1...)">] abstract Create: p1: obj * p2: obj * p3: JXG.Point_JXG.Point_JXG.Point -> Bisector

/// Bisector lines are similar to {@link Bisector} but takes two lines as parent elements. The resulting element is
/// a composition of two lines.
type [<AllowNullLiteral>] Bisectorlines =
    inherit JXG.Composition
    /// First line.
    /// First line.
    abstract line1: Line with get, set
    /// Second line.
    /// Second line.
    abstract line2: Line with get, set
    /// First line.
    /// First line.
    abstract line1: Line with get, set
    /// Second line.
    /// Second line.
    abstract line2: Line with get, set

/// Bisector lines are similar to {@link Bisector} but takes two lines as parent elements. The resulting element is
/// a composition of two lines.
type [<AllowNullLiteral>] BisectorlinesStatic =
    [<Emit "new $0($1...)">] abstract Create: l1: obj * l2: JXG.Line_JXG.Line -> Bisectorlines

/// A circumcenter is given by three points which are all lying on the circle with the
/// constructed circumcenter as the midpoint.
type [<AllowNullLiteral>] Circumcenter =
    inherit JXG.Point

/// A circumcenter is given by three points which are all lying on the circle with the
/// constructed circumcenter as the midpoint.
type [<AllowNullLiteral>] CircumcenterStatic =
    [<Emit "new $0($1...)">] abstract Create: p1: obj * p2: obj * p3: JXG.Point_JXG.Point_JXG.Point -> Circumcenter

/// Constructs the incenter of the triangle described by the three given points.{@link http://mathworld.wolfram.com/Incenter.html}
type [<AllowNullLiteral>] Incenter =
    inherit JXG.Point

/// Constructs the incenter of the triangle described by the three given points.{@link http://mathworld.wolfram.com/Incenter.html}
type [<AllowNullLiteral>] IncenterStatic =
    [<Emit "new $0($1...)">] abstract Create: p1: obj * p2: obj * p3: JXG.Point_JXG.Point_JXG.Point -> Incenter

/// A circumcircle is given by three points which are all lying on the circle.
type [<AllowNullLiteral>] Circumcircle =
    inherit JXG.Circle
    /// Attributes for center point.
    abstract center: Point with get, set

/// A circumcircle is given by three points which are all lying on the circle.
type [<AllowNullLiteral>] CircumcircleStatic =
    [<Emit "new $0($1...)">] abstract Create: p1: obj * p2: obj * p3: JXG.Point_JXG.Point_JXG.Point -> Circumcircle

/// An incircle is given by three points.
type [<AllowNullLiteral>] Incircle =
    inherit JXG.Circle
    /// The center of the incircle
    /// The center of the incircle
    abstract center: Incenter with get, set
    /// The center of the incircle
    /// The center of the incircle
    abstract center: Incenter with get, set

/// An incircle is given by three points.
type [<AllowNullLiteral>] IncircleStatic =
    [<Emit "new $0($1...)">] abstract Create: p1: obj * p2: obj * p3: JXG.Point_JXG.Point_JXG.Point -> Incircle

/// A reflected element (point, line or curve) is given by a given
/// object of the same type and a line of reflection.
/// It is determined by the reflection of the given element
/// across the given line.
type [<AllowNullLiteral>] Reflection =
    inherit JXG.GeometryElement
    /// <summary>Highlights the element.</summary>
    /// <param name="force">- Force the highlighting</param>
    abstract highlight: ?force: bool -> JXG.Board
    /// <summary>Set the highlightStrokeColor of an element</summary>
    /// <param name="sColor">- String which determines the stroke color of an object when its highlighted.</param>
    abstract highlightStrokeColor: sColor: string -> unit
    /// <summary>Set the strokeColor of an element</summary>
    /// <param name="sColor">- String which determines the stroke color of an object.</param>
    abstract strokeColor: sColor: string -> unit
    /// <summary>Set the strokeWidth of an element</summary>
    /// <param name="width">- Integer which determines the stroke width of an outline.</param>
    abstract strokeWidth: width: float -> unit
    /// <summary>Set the fillColor of an element</summary>
    /// <param name="fColor">- String which determines the fill color of an object.</param>
    abstract fillColor: fColor: string -> unit
    /// <summary>Set the highlightFillColor of an element</summary>
    /// <param name="fColor">- String which determines the fill color of an object when its highlighted.</param>
    abstract highlightFillColor: fColor: string -> unit
    /// <summary>Set the dash type of an element</summary>
    /// <param name="d">- Integer which determines the way of dashing an element's outline.</param>
    abstract dash: d: float -> unit
    /// <summary>Set the visibility of an element</summary>
    /// <param name="v">- Boolean which determines whether the element is drawn.</param>
    abstract visible: v: bool -> unit
    /// <summary>Set the shadow of an element</summary>
    /// <param name="s">- Boolean which determines whether the element has a shadow or not.</param>
    abstract shadow: s: bool -> unit
    /// Snaps the element to the grid. Only works for points, lines and circles. Points will snap to the grid
    /// as defined in their properties {@link JXG.Point#snapSizeX} and {@link JXG.Point#snapSizeY}. Lines and circles
    /// will snap their parent points to the grid, if they have {@link JXG.Point#snapToGrid} set to true.
    abstract snapToGrid: unit -> JXG.GeometryElement
    /// Determines whether two-finger manipulation of this object may change its size.
    /// If set to false, the object is only rotated and translated.
    /// <p>
    /// In case the element is a horizontal or vertical line having ticks, "scalable:true"
    /// enables zooming of the board by dragging ticks lines. This feature is enabled,
    /// for the ticks element of the line element the attribute "fixed" has to be false
    /// and the line element's scalable attribute has to be true.
    /// <p>
    /// In case the element is a polygon or line and it has the attribute "scalable:false",
    /// moving the element with two fingers results in a rotation or translation.
    abstract scalable: bool with get, set

/// A reflected element (point, line or curve) is given by a given
/// object of the same type and a line of reflection.
/// It is determined by the reflection of the given element
/// across the given line.
type [<AllowNullLiteral>] ReflectionStatic =
    [<Emit "new $0($1...)">] abstract Create: p: obj * l: U4<JXG.Point, JXG.Line, JXG.Curve, JXG.Polygon_JXG.Line> -> Reflection

/// A mirror element is determined by the reflection of a given point across another given point.
type [<AllowNullLiteral>] Mirrorelement =
    inherit JXG.GeometryElement
    /// <summary>Highlights the element.</summary>
    /// <param name="force">- Force the highlighting</param>
    abstract highlight: ?force: bool -> JXG.Board
    /// <summary>Set the highlightStrokeColor of an element</summary>
    /// <param name="sColor">- String which determines the stroke color of an object when its highlighted.</param>
    abstract highlightStrokeColor: sColor: string -> unit
    /// <summary>Set the strokeColor of an element</summary>
    /// <param name="sColor">- String which determines the stroke color of an object.</param>
    abstract strokeColor: sColor: string -> unit
    /// <summary>Set the strokeWidth of an element</summary>
    /// <param name="width">- Integer which determines the stroke width of an outline.</param>
    abstract strokeWidth: width: float -> unit
    /// <summary>Set the fillColor of an element</summary>
    /// <param name="fColor">- String which determines the fill color of an object.</param>
    abstract fillColor: fColor: string -> unit
    /// <summary>Set the highlightFillColor of an element</summary>
    /// <param name="fColor">- String which determines the fill color of an object when its highlighted.</param>
    abstract highlightFillColor: fColor: string -> unit
    /// <summary>Set the dash type of an element</summary>
    /// <param name="d">- Integer which determines the way of dashing an element's outline.</param>
    abstract dash: d: float -> unit
    /// <summary>Set the visibility of an element</summary>
    /// <param name="v">- Boolean which determines whether the element is drawn.</param>
    abstract visible: v: bool -> unit
    /// <summary>Set the shadow of an element</summary>
    /// <param name="s">- Boolean which determines whether the element has a shadow or not.</param>
    abstract shadow: s: bool -> unit
    /// Snaps the element to the grid. Only works for points, lines and circles. Points will snap to the grid
    /// as defined in their properties {@link JXG.Point#snapSizeX} and {@link JXG.Point#snapSizeY}. Lines and circles
    /// will snap their parent points to the grid, if they have {@link JXG.Point#snapToGrid} set to true.
    abstract snapToGrid: unit -> JXG.GeometryElement
    /// Determines whether two-finger manipulation of this object may change its size.
    /// If set to false, the object is only rotated and translated.
    /// <p>
    /// In case the element is a horizontal or vertical line having ticks, "scalable:true"
    /// enables zooming of the board by dragging ticks lines. This feature is enabled,
    /// for the ticks element of the line element the attribute "fixed" has to be false
    /// and the line element's scalable attribute has to be true.
    /// <p>
    /// In case the element is a polygon or line and it has the attribute "scalable:false",
    /// moving the element with two fingers results in a rotation or translation.
    abstract scalable: bool with get, set

/// A mirror element is determined by the reflection of a given point across another given point.
type [<AllowNullLiteral>] MirrorelementStatic =
    [<Emit "new $0($1...)">] abstract Create: p1: obj * p2: U4<JXG.Point, JXG.Line, JXG.Curve, JXG.Ppolygon_JXG.Point> -> Mirrorelement

/// A mirror point is determined by the reflection of a given point against another given point.
type [<AllowNullLiteral>] Mirrorpoint =
    inherit JXG.Point

/// A mirror point is determined by the reflection of a given point against another given point.
type [<AllowNullLiteral>] MirrorpointStatic =
    [<Emit "new $0($1...)">] abstract Create: p1: obj * p2: JXG.Point_JXG.Point -> Mirrorpoint

/// The Integral element is used to visualize the area under a given curve over a given interval
/// and to calculate the area's value. For that a polygon and gliders are used. The polygon displays the area,
/// the gliders are used to change the interval dynamically.
type [<AllowNullLiteral>] Integral =
    inherit JXG.Curve
    /// Attributes of the (left) starting point of the integral.
    abstract curveLeft: Point with get, set
    /// Attributes of the (left) base point of the integral.
    abstract baseLeft: Point with get, set
    /// Attributes of the (right) end point of the integral.
    abstract curveRight: Point with get, set
    /// Attributes of the (right) base point of the integral.
    abstract baseRight: Point with get, set
    /// Attributes for integral label.
    abstract label: Label with get, set

/// The Integral element is used to visualize the area under a given curve over a given interval
/// and to calculate the area's value. For that a polygon and gliders are used. The polygon displays the area,
/// the gliders are used to change the interval dynamically.
type [<AllowNullLiteral>] IntegralStatic =
    [<Emit "new $0($1...)">] abstract Create: i: obj * c: Array_JXG.Curve -> Integral
    /// The point on the axis initially corresponding to the lower value of the interval.
    abstract baseLeft: JXG.Point with get, set
    /// The point on the axis initially corresponding to the higher value of the interval.
    abstract baseRight: JXG.Point with get, set
    /// The glider on the curve corresponding to the lower value of the interval.
    abstract curveLeft: Glider with get, set
    /// The glider on the axis corresponding to the higher value of the interval.
    abstract curveRight: Glider with get, set

/// A grid is a set of vertical and horizontal lines to support the user with element placement. This method
/// draws such a grid on the given board. It uses options given in {@link JXG.Options#grid}. This method does not
/// take any parent elements. It is usually instantiated on the board's creation via the attribute <tt>grid</tt> set
/// to true.
type [<AllowNullLiteral>] Grid =
    inherit JXG.Curve

/// A grid is a set of vertical and horizontal lines to support the user with element placement. This method
/// draws such a grid on the given board. It uses options given in {@link JXG.Options#grid}. This method does not
/// take any parent elements. It is usually instantiated on the board's creation via the attribute <tt>grid</tt> set
/// to true.
type [<AllowNullLiteral>] GridStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Grid

/// Display the solution set of a linear inequality (less than or equal to).
/// To be precise, the solution set of the inequality <i>y <= b/a * x + c/a</i> is shown.
/// In case <i>a = 0</i>, that is if the equation of the line is <i>bx + c = 0</i>,
/// the area of the inequality <i>bx + c <= 0</i> is shown.
/// <p>
/// For function graphs the area below the function graph is filled, i.e. the
/// area of the inequality y <= f(x).
/// With the attribute inverse:true the area of the inequality y >= f(x) is filled.
type [<AllowNullLiteral>] Inequality =
    inherit JXG.Curve
    /// By default an inequality is less (or equal) than. Set inverse to <tt>true</tt> will consider the inequality
    /// greater (or equal) than.
    abstract inverse: bool with get, set

/// Display the solution set of a linear inequality (less than or equal to).
/// To be precise, the solution set of the inequality <i>y <= b/a * x + c/a</i> is shown.
/// In case <i>a = 0</i>, that is if the equation of the line is <i>bx + c = 0</i>,
/// the area of the inequality <i>bx + c <= 0</i> is shown.
/// <p>
/// For function graphs the area below the function graph is filled, i.e. the
/// area of the inequality y <= f(x).
/// With the attribute inverse:true the area of the inequality y >= f(x) is filled.
type [<AllowNullLiteral>] InequalityStatic =
    [<Emit "new $0($1...)">] abstract Create: l: JXG.Line -> Inequality

/// This element is used to provide a constructor for an ellipse. An ellipse is given by two points (the foci) and a third point on the the ellipse or
/// the length of the major axis.
type [<AllowNullLiteral>] Ellipse =
    inherit Conic

/// This element is used to provide a constructor for an ellipse. An ellipse is given by two points (the foci) and a third point on the the ellipse or
/// the length of the major axis.
type [<AllowNullLiteral>] EllipseStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Ellipse

/// This element is used to provide a constructor for an hyperbola. An hyperbola is given by two points (the foci) and a third point on the the hyperbola or
/// the length of the major axis.
type [<AllowNullLiteral>] Hyperbola =
    inherit Conic

/// This element is used to provide a constructor for an hyperbola. An hyperbola is given by two points (the foci) and a third point on the the hyperbola or
/// the length of the major axis.
type [<AllowNullLiteral>] HyperbolaStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Hyperbola

/// This element is used to provide a constructor for a parabola. A parabola is given by one point (the focus) and a line (the directrix).
type [<AllowNullLiteral>] Parabola =
    inherit Conic

/// This element is used to provide a constructor for a parabola. A parabola is given by one point (the focus) and a line (the directrix).
type [<AllowNullLiteral>] ParabolaStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Parabola

/// This element is used to provide a constructor for a generic conic section uniquely defined by five points or
/// a conic defined by the coefficients of the equation
/// <p><i>Ax<sup>2</sup>+ Bxy+Cy<sup>2</sup> + Dx + Ey + F = 0</i></p>.
/// Then the parameters are as follows:
/// <pre>
///   board.create('conic', [A, C, F, B/2, D/2, E/2]);
/// </pre>
type [<AllowNullLiteral>] Conic =
    inherit JXG.Curve
    /// Attributes for foci points.
    abstract foci: Point with get, set
    /// Attributes for center point.
    abstract center: Point with get, set
    /// Attributes for five points defining the conic, if some of them are given as coordinates.
    abstract point: Point with get, set
    /// Attributes for parabola line incase the line is given by two
    /// points or coordinate pairs.
    abstract line: Line with get, set

/// This element is used to provide a constructor for a generic conic section uniquely defined by five points or
/// a conic defined by the coefficients of the equation
/// <p><i>Ax<sup>2</sup>+ Bxy+Cy<sup>2</sup> + Dx + Ey + F = 0</i></p>.
/// Then the parameters are as follows:
/// <pre>
///   board.create('conic', [A, C, F, B/2, D/2, E/2]);
/// </pre>
type [<AllowNullLiteral>] ConicStatic =
    [<Emit "new $0($1...)">] abstract Create: a_00: obj * a_11: obj * a_22: obj * a_01: obj * a_02: obj * a_12: Number_Number_Number_Number_Number_Number -> Conic

/// This element is used to provide a constructor for special texts containing a
/// HTML form input element.
/// <p>
/// If the width of element is set with the attribute "cssStyle", the width of the
/// label must be added.
/// <p>
/// For this element, the attribute "display" has to have the value 'html' (which is the default).
type [<AllowNullLiteral>] Input =
    inherit Text
    /// Control the attribute "disabled" of the HTML input field.
    abstract disabled: bool with get, set
    /// Control the attribute "maxlength" of the HTML input field.
    abstract maxlength: float with get, set

/// This element is used to provide a constructor for special texts containing a
/// HTML form input element.
/// <p>
/// If the width of element is set with the attribute "cssStyle", the width of the
/// label must be added.
/// <p>
/// For this element, the attribute "display" has to have the value 'html' (which is the default).
type [<AllowNullLiteral>] InputStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Input

/// The locus element is used to visualize the curve a given point describes.
type [<AllowNullLiteral>] Locus =
    inherit JXG.Curve
    /// The implicit definition of the locus.
    abstract eq: string with get, set
    /// The time it took to calculate the locus
    abstract ctime: float with get, set

/// The locus element is used to visualize the curve a given point describes.
type [<AllowNullLiteral>] LocusStatic =
    [<Emit "new $0($1...)">] abstract Create: p: JXG.Point -> Locus

/// A tape measure can be used to measure distances between points.
type [<AllowNullLiteral>] Tapemeasure =
    inherit Segment
    /// Show tape measure ticks.
    abstract withTicks: bool with get, set
    /// Show tape measure label.
    abstract withLabel: bool with get, set
    /// The precision of the tape measure value displayed in the optional text.
    abstract precision: float with get, set
    /// Attributes for first helper point defining the tape measure position.
    abstract point1: Point with get, set
    /// Attributes for second helper point defining the tape measure position.
    abstract point2: Point with get, set
    /// Attributes for the ticks of the tape measure.
    abstract ticks: Ticks with get, set
    /// Attributes for the tape measure label.
    abstract label: Label with get, set

/// A tape measure can be used to measure distances between points.
type [<AllowNullLiteral>] TapemeasureStatic =
    [<Emit "new $0($1...)">] abstract Create: start: obj * ``end``: obj * Array_Array: obj -> Tapemeasure

/// A circular sector is a subarea of the area enclosed by a circle. It is enclosed by two radii and an arc.
type [<AllowNullLiteral>] Sector =
    inherit JXG.Curve
    /// Midpoint of the sector.
    abstract point1: JXG.Point with get, set
    /// This point together with {@link Sector#point1} defines the radius..
    abstract point2: JXG.Point with get, set
    /// Defines the sector's angle.
    abstract point3: JXG.Point with get, set
    /// Defines the sectors orientation in case of circumCircleSectors.
    abstract point4: JXG.Point with get, set
    /// Returns the radius of the sector.
    abstract Radius: unit -> float
    /// <summary>Checks whether (x,y) is within the area defined by the sector.</summary>
    /// <param name="x">- Coordinate in x direction, screen coordinates.</param>
    /// <param name="y">- Coordinate in y direction, screen coordinates.</param>
    abstract hasPointSector: x: float * y: float -> bool
    /// Type of sector. Possible values are 'minor', 'major', and 'auto'.
    abstract selection: string with get, set
    /// Attributes for sub-element arc. It is only available, if the sector is defined by three points.
    abstract arc: Arc with get, set
    /// Attributes for helper point radiuspoint in case it is provided by coordinates.
    abstract radiuspoint: Point with get, set
    /// Attributes for helper point center in case it is provided by coordinates.
    abstract center: Point with get, set
    /// Attributes for helper point anglepoint in case it is provided by coordinates.
    abstract anglePoint: Point with get, set
    /// Attributes for the sector label.
    abstract label: Label with get, set

/// A circular sector is a subarea of the area enclosed by a circle. It is enclosed by two radii and an arc.
type [<AllowNullLiteral>] SectorStatic =
    [<Emit "new $0($1...)">] abstract Create: p1: obj * p2: obj * p1: JXG.Point_JXG.Point_JXG.Point -> Sector

/// A circumcircle sector is different from a {@link Sector} mostly in the way the parent elements are interpreted.
/// At first, the circum centre is determined from the three given points. Then the sector is drawn from <tt>p1</tt> through
/// <tt>p2</tt> to <tt>p3</tt>.
type [<AllowNullLiteral>] CircumcircleSector =
    inherit Sector
    /// Center of the circumcirclesector
    abstract center: Circumcenter with get, set

/// A circumcircle sector is different from a {@link Sector} mostly in the way the parent elements are interpreted.
/// At first, the circum centre is determined from the three given points. Then the sector is drawn from <tt>p1</tt> through
/// <tt>p2</tt> to <tt>p3</tt>.
type [<AllowNullLiteral>] CircumcircleSectorStatic =
    [<Emit "new $0($1...)">] abstract Create: p1: obj * p2: obj * p1: JXG.Point_JXG.Point_JXG.Point -> CircumcircleSector

/// A minor sector is a sector of a circle having measure less than or equal to
/// 180 degrees (pi radians). It is defined by a center, one point that
/// defines the radius, and a third point that defines the angle of the sector.
type [<AllowNullLiteral>] MinorSector =
    inherit Curve

/// A minor sector is a sector of a circle having measure less than or equal to
/// 180 degrees (pi radians). It is defined by a center, one point that
/// defines the radius, and a third point that defines the angle of the sector.
type [<AllowNullLiteral>] MinorSectorStatic =
    [<Emit "new $0($1...)">] abstract Create: p1: obj * p2: obj * p3: JXG.Point_JXG.Point_JXG.Point -> MinorSector

/// A major sector is a sector of a circle having measure greater than or equal to
/// 180 degrees (pi radians). It is defined by a center, one point that
/// defines the radius, and a third point that defines the angle of the sector.
type [<AllowNullLiteral>] MajorSector =
    inherit Curve

/// A major sector is a sector of a circle having measure greater than or equal to
/// 180 degrees (pi radians). It is defined by a center, one point that
/// defines the radius, and a third point that defines the angle of the sector.
type [<AllowNullLiteral>] MajorSectorStatic =
    [<Emit "new $0($1...)">] abstract Create: p1: obj * p2: obj * p3: JXG.Point_JXG.Point_JXG.Point -> MajorSector

/// The angle element is used to denote an angle defined by three points. Visually it is just a {@link Sector}
/// element with a radius not defined by the parent elements but by an attribute <tt>radius</tt>. As opposed to the sector,
/// an angle has two angle points and no radius point.
/// Sector is displayed if type=="sector".
/// If type=="square", instead of a sector a parallelogram is displayed.
/// In case of type=="auto", a square is displayed if the angle is near orthogonal.
/// If no name is provided the angle label is automatically set to a lower greek letter.
type [<AllowNullLiteral>] Angle =
    inherit Sector
    /// The point defining the radius of the angle element. Alias for {@link Angle.prototype#radiuspoint}.
    abstract point: JXG.Point with get, set
    /// Helper point for angles of type 'square'.
    abstract pointsquare: JXG.Point with get, set
    /// <summary>Set an angle to a prescribed value given in radians. This is only possible if the third point of the angle, i.e.
    /// the anglepoint is a free point.</summary>
    /// <param name="val">- Number or Function which returns the size of the angle in Radians</param>
    abstract setAngle: ``val``: U2<float, (ResizeArray<obj option> -> obj option)> -> obj option
    /// Frees an angle from a prescribed value. This is only relevant if the angle size has been set by
    /// setAngle() previously. The anglepoint is set to a free point.
    abstract free: unit -> obj option
    /// Indicates a right angle. Invisible by default, use <tt>dot.visible: true</tt> to show.
    /// Though this dot indicates a right angle, it can be visible even if the angle is not a right
    /// one.
    abstract dot: JXG.Point with get, set
    /// Returns the value of the angle in Radians.
    abstract Value: unit -> float
    /// Radius of the sector, displaying the angle.
    abstract radius: float with get, set
    /// Display type of the angle field. Possible values are
    /// 'sector' or 'sectordot' or 'square' or 'none'.
    abstract ``type``: string with get, set
    /// Display type of the angle field in case of a right angle. Possible values are
    /// 'sector' or 'sectordot' or 'square' or 'none'.
    abstract orthoType: string with get, set
    /// Sensitivity (in degrees) to declare an angle as right angle.
    /// If the angle measure is inside this distance from a rigth angle, the orthoType
    /// of the angle is used for display.
    abstract orthoSensitivity: float with get, set

/// The angle element is used to denote an angle defined by three points. Visually it is just a {@link Sector}
/// element with a radius not defined by the parent elements but by an attribute <tt>radius</tt>. As opposed to the sector,
/// an angle has two angle points and no radius point.
/// Sector is displayed if type=="sector".
/// If type=="square", instead of a sector a parallelogram is displayed.
/// In case of type=="auto", a square is displayed if the angle is near orthogonal.
/// If no name is provided the angle label is automatically set to a lower greek letter.
type [<AllowNullLiteral>] AngleStatic =
    [<Emit "new $0($1...)">] abstract Create: p1: obj * p2: obj * p1: JXG.Point_JXG.Point_JXG.Point * line: obj * JXG: obj * Line_JXG: obj * Line_array: obj * : obj * number_array: obj * : obj * number: obj -> Angle

/// A non-reflex angle is the acute or obtuse instance of an angle.
/// It is defined by a center, one point that
/// defines the radius, and a third point that defines the angle of the sector.
type [<AllowNullLiteral>] NonReflexAngle =
    inherit Angle

/// A non-reflex angle is the acute or obtuse instance of an angle.
/// It is defined by a center, one point that
/// defines the radius, and a third point that defines the angle of the sector.
type [<AllowNullLiteral>] NonReflexAngleStatic =
    [<Emit "new $0($1...)">] abstract Create: p1: obj * p2: obj * p3: JXG.Point_JXG.Point_JXG.Point -> NonReflexAngle

/// A reflex angle is the neither acute nor obtuse instance of an angle.
/// It is defined by a center, one point that
/// defines the radius, and a third point that defines the angle of the sector.
type [<AllowNullLiteral>] ReflexAngle =
    inherit Angle

/// A reflex angle is the neither acute nor obtuse instance of an angle.
/// It is defined by a center, one point that
/// defines the radius, and a third point that defines the angle of the sector.
type [<AllowNullLiteral>] ReflexAngleStatic =
    [<Emit "new $0($1...)">] abstract Create: p1: obj * p2: obj * p3: JXG.Point_JXG.Point_JXG.Point -> ReflexAngle

/// A slider can be used to choose values from a given range of numbers.
type [<AllowNullLiteral>] Slider =
    inherit Glider
    /// Returns the current slider value.
    abstract Value: obj option with get, set
    /// End value of the slider range.
    abstract _smax: float with get, set
    /// Start value of the slider range.
    abstract _smin: float with get, set
    /// Sets the maximum value of the slider.
    abstract setMax: obj option with get, set
    /// Sets the value of the slider. This call must be followed
    /// by a board update call.
    abstract setValue: obj option with get, set
    /// Sets the minimum value of the slider.
    abstract setMin: obj option with get, set
    /// The text element to the right of the slider, indicating its current value.
    /// The text element to the right of the slider, indicating its current value.
    abstract label: JXG.Text with get, set
    /// Start point of the base line.
    /// Start point of the base line.
    abstract point1: JXG.Point with get, set
    /// End point of the base line.
    /// End point of the base line.
    abstract point2: JXG.Point with get, set
    /// The baseline the glider is bound to.
    /// The baseline the glider is bound to.
    abstract baseline: JXG.Line with get, set
    /// A line on top of the baseline, indicating the slider's progress.
    /// A line on top of the baseline, indicating the slider's progress.
    abstract highline: JXG.Line with get, set
    /// Ticks give a rough indication about the slider's current value.
    /// Ticks give a rough indication about the slider's current value.
    abstract ticks: JXG.Ticks with get, set
    /// The slider only returns integer multiples of this value, e.g. for discrete values set this property to <tt>1</tt>. For
    /// continuous results set this to <tt>-1</tt>.
    abstract snapWidth: float with get, set
    /// The precision of the slider value displayed in the optional text.
    abstract precision: float with get, set
    /// Show slider ticks.
    abstract withTicks: bool with get, set
    /// Show slider label.
    abstract withLabel: bool with get, set
    /// If not null, this replaces the part "name = " in the slider label.
    /// Possible types: string, number or function.
    abstract suffixLabel: string with get, set
    /// If not null, this is appended to the value in the slider label.
    /// Possible types: string, number or function.
    abstract unitLabel: string with get, set
    /// If not null, this is appended to the value and to unitLabel in the slider label.
    /// Possible types: string, number or function.
    abstract postLabel: string with get, set
    /// Size of slider point.
    abstract size: float with get, set
    /// Start point of the base line.
    /// Start point of the base line.
    abstract point1: JXG.Point with get, set
    /// End point of the base line.
    /// End point of the base line.
    abstract point2: JXG.Point with get, set
    /// The baseline the glider is bound to.
    /// The baseline the glider is bound to.
    abstract baseline: JXG.Line with get, set
    /// Ticks give a rough indication about the slider's current value.
    /// Ticks give a rough indication about the slider's current value.
    abstract ticks: JXG.Ticks with get, set
    /// A line on top of the baseline, indicating the slider's progress.
    /// A line on top of the baseline, indicating the slider's progress.
    abstract highline: JXG.Line with get, set
    /// The text element to the right of the slider, indicating its current value.
    /// The text element to the right of the slider, indicating its current value.
    abstract label: JXG.Text with get, set

/// A slider can be used to choose values from a given range of numbers.
type [<AllowNullLiteral>] SliderStatic =
    [<Emit "new $0($1...)">] abstract Create: start: obj * ``end``: obj * data: Array_Array_Array -> Slider

/// Slope triangle for a point on a line.
type [<AllowNullLiteral>] Slopetriangle =
    inherit JXG.Line
    /// Attributes for the gliding helper point.
    abstract glider: Point with get, set
    /// Attributes for the base line.
    abstract baseline: Line with get, set
    /// Attributes for the base point.
    abstract basepoint: Point with get, set
    /// Attributes for the tangent.
    /// The tangent is constructed by slop triangle if the construction
    /// is based on a glider, solely.
    abstract tangent: Line with get, set
    /// Attributes for the top point.
    abstract topPoint: Point with get, set
    /// Attributes for the slope triangle label.
    abstract label: Label with get, set

/// Slope triangle for a point on a line.
type [<AllowNullLiteral>] SlopetriangleStatic =
    [<Emit "new $0($1...)">] abstract Create: t: JXG.Line * li: obj * JXG: obj * Line_JXG: obj * Point: obj -> Slopetriangle

module JXG =

    type [<AllowNullLiteral>] IExports =
        abstract Board: BoardStatic
        abstract Chart: ChartStatic
        abstract Legend: LegendStatic
        abstract Circle: CircleStatic
        abstract Composition: CompositionStatic
        abstract version: string
        abstract licenseText: string
        abstract Coords: CoordsStatic
        abstract Curve: CurveStatic
        abstract GeometryElement: GeometryElementStatic
        abstract Group: GroupStatic
        abstract Image: ImageStatic
        abstract Line: LineStatic
        abstract Point: PointStatic
        abstract Polygon: PolygonStatic
        abstract Text: TextStatic
        /// [[x,y], [w px, h px], [range]
        abstract createHTMLSlider: unit -> unit
        abstract Ticks: TicksStatic
        abstract Transformation: TransformationStatic

    /// Constructs a new Board object.
    type [<AllowNullLiteral>] Board =
        /// Board is in no special mode, objects are highlighted on mouse over and objects may be
        /// clicked to start drag&drop.
        abstract BOARD_MODE_NONE: float
        /// Board is in drag mode, objects aren't highlighted on mouse over and the object referenced in
        /// {JXG.Board#mouse} is updated on mouse movement.
        abstract BOARD_MODE_DRAG: float
        /// In this mode a mouse move changes the origin's screen coordinates.
        abstract BOARD_MODE_MOVE_ORIGIN: float
        /// Update is made with low quality, e.g. graphs are evaluated at a lesser amount of points.
        abstract BOARD_QUALITY_LOW: float
        /// Update is made with high quality, e.g. graphs are evaluated at much more points.
        abstract BOARD_QUALITY_HIGH: float
        /// Update is made with high quality, e.g. graphs are evaluated at much more points.
        abstract BOARD_MODE_ZOOM: float
        /// The html-id of the html element containing the board.
        abstract container: string with get, set
        /// Pointer to the html element containing the board.
        abstract containerObj: obj option with get, set
        /// A reference to this boards renderer.
        /// A reference to this boards renderer.
        abstract renderer: JXG.AbstractRenderer with get, set
        /// Grids keeps track of all grids attached to this board.
        abstract grids: obj option with get, set
        /// Some standard options
        abstract options: JXG.Options with get, set
        /// Dimension of the board.
        abstract dimension: float with get, set
        /// Coordinates of the boards origin. This a object with the two properties
        /// usrCoords and scrCoords. usrCoords always equals [1, 0, 0] and scrCoords
        /// stores the boards origin in homogeneous screen coordinates.
        abstract origin: obj option with get, set
        /// Zoom factor in X direction. It only stores the zoom factor to be able
        /// to get back to 100% in zoom100().
        /// Zoom factor in X direction. It only stores the zoom factor to be able
        /// to get back to 100% in zoom100().
        abstract zoomX: float with get, set
        /// Zoom factor in Y direction. It only stores the zoom factor to be able
        /// to get back to 100% in zoom100().
        /// Zoom factor in Y direction. It only stores the zoom factor to be able
        /// to get back to 100% in zoom100().
        abstract zoomY: float with get, set
        /// The number of pixels which represent one unit in user-coordinates in x direction.
        abstract unitX: float with get, set
        /// The number of pixels which represent one unit in user-coordinates in y direction.
        abstract unitY: float with get, set
        /// Keep aspect ratio if bounding box is set and the width/height ratio differs from the
        /// width/height ratio of the canvas.
        abstract keepaspectratio: obj option with get, set
        /// Canvas width.
        abstract canvasWidth: float with get, set
        /// Canvas Height
        abstract canvasHeight: float with get, set
        /// An array containing all other boards that are updated after this board has been updated.
        abstract dependentBoards: ResizeArray<obj option> with get, set
        /// During the update process this is set to false to prevent an endless loop.
        abstract inUpdate: bool with get, set
        /// An associative array containing all geometric objects belonging to the board. Key is the id of the object and value is a reference to the object.
        abstract objects: obj option with get, set
        /// An array containing all geometric objects on the board in the order of construction.
        abstract objectsList: ResizeArray<obj option> with get, set
        /// An associative array containing all groups belonging to the board. Key is the id of the group and value is a reference to the object.
        abstract groups: obj option with get, set
        /// Stores all the objects that are currently running an animation.
        abstract animationObjects: obj option with get, set
        /// An associative array containing all highlighted elements belonging to the board.
        abstract highlightedObjects: obj option with get, set
        /// Number of objects ever created on this board. This includes every object, even invisible and deleted ones.
        abstract numObjects: float with get, set
        /// An associative array to store the objects of the board by name. the name of the object is the key and value is a reference to the object.
        abstract elementsByName: obj option with get, set
        /// The board mode the board is currently in. Possible values are
        /// <ul>
        /// <li>JXG.Board.BOARD_MODE_NONE</li>
        /// <li>JXG.Board.BOARD_MODE_DRAG</li>
        /// <li>JXG.Board.BOARD_MODE_MOVE_ORIGIN</li>
        /// </ul>
        abstract mode: float with get, set
        /// The update quality of the board. In most cases this is set to {@link JXG.Board#BOARD_QUALITY_HIGH}.
        /// If {@link JXG.Board#mode} equals {@link JXG.Board#BOARD_MODE_DRAG} this is set to
        /// {@link JXG.Board#BOARD_QUALITY_LOW} to speed up the update process by e.g. reducing the number of
        /// evaluation points when plotting functions. Possible values are
        /// <ul>
        /// <li>BOARD_QUALITY_LOW</li>
        /// <li>BOARD_QUALITY_HIGH</li>
        /// </ul>
        abstract updateQuality: float with get, set
        /// If true updates are skipped.
        abstract isSuspendedRedraw: bool with get, set
        /// The distance from the mouse to the dragged object in x direction when the user clicked the mouse button.
        abstract drag_dx: float with get, set
        /// The distance from the mouse to the dragged object in y direction when the user clicked the mouse button.
        abstract drag_dy: float with get, set
        /// The last position where a drag event has been fired.
        abstract drag_position: ResizeArray<obj option> with get, set
        /// References to the object that is dragged with the mouse on the board.
        abstract mouse: obj option with get, set
        /// Keeps track on touched elements, like {@link JXG.Board#mouse} does for mouse events.
        abstract touches: ResizeArray<obj option> with get, set
        /// A string containing the XML text of the construction.
        /// This is set in {@link JXG.FileReader.parseString}.
        /// Only useful if a construction is read from a GEONExT-, Intergeo-, Geogebra-, or Cinderella-File.
        abstract xmlString: string with get, set
        /// Cached result of getCoordsTopLeftCorner for touch/mouseMove-Events to save some DOM operations.
        abstract cPos: ResizeArray<obj option> with get, set
        /// Contains the last time (epoch, msec) since the last getCoordsTopLeftCorner call which was not thrown away.
        abstract positionAccessLast: float with get, set
        /// Collects all elements that triggered a mouse down event.
        abstract downObjects: ResizeArray<obj option> with get, set
        /// Full updates are needed after zoom and axis translates. This saves some time during an update.
        abstract needsFullUpdate: bool with get, set
        /// If reducedUpdate is set to true then only the dragged element and few (e.g. 2) following
        /// elements are updated during mouse move. On mouse up the whole construction is
        /// updated. This enables us to be fast even on very slow devices.
        abstract reducedUpdate: bool with get, set
        /// The current color blindness deficiency is stored in this property. If color blindness is not emulated
        /// at the moment, it's value is 'none'.
        abstract currentCBDef: obj option with get, set
        /// If GEONExT constructions are displayed, then this property should be set to true.
        /// At the moment there should be no difference. But this may change.
        /// This is set in {@link JXG.GeonextReader.readGeonext}.
        abstract geonextCompatibilityMode: bool with get, set
        /// A flag which tells if the board registers mouse events.
        abstract hasMouseHandlers: bool with get, set
        /// A flag which tells if the board registers touch events.
        abstract hasTouchHandlers: bool with get, set
        /// A flag which stores if the board registered pointer events.
        abstract hasPointerHandlers: bool with get, set
        /// A flag which tells if the board the JXG.Board#mouseUpListener is currently registered.
        abstract hasMouseUp: bool with get, set
        /// A flag which tells if the board the JXG.Board#touchEndListener is currently registered.
        abstract hasTouchEnd: bool with get, set
        /// A flag which tells us if the board has a pointerUp event registered at the moment.
        abstract hasPointerUp: bool with get, set
        /// A flag which tells us if the board is in the selecting mode
        abstract selectingMode: bool with get, set
        /// A flag which tells us if the user is selecting
        abstract isSelecting: bool with get, set
        /// A bounding box for the selection
        abstract selectingBox: ResizeArray<obj option> with get, set
        /// <summary>Generates an unique name for the given object. The result depends on the objects type, if the
        /// object is a {@link JXG.Point}, capital characters are used, if it is of type {@link JXG.Line}
        /// only lower case characters are used. If object is of type {@link JXG.Polygon}, a bunch of lower
        /// case characters prefixed with P_ are used. If object is of type {@link JXG.Circle} the name is
        /// generated using lower case characters. prefixed with k_ is used. In any other case, lower case
        /// chars prefixed with s_ is used.</summary>
        /// <param name="object">- Reference of an JXG.GeometryElement that is to be named.</param>
        abstract generateName: ``object``: obj option -> string
        /// Generates unique id for a board. The result is randomly generated and prefixed with 'jxgBoard'.
        abstract generateId: unit -> string
        /// <summary>Composes an id for an element. If the ID is empty ('' or null) a new ID is generated, depending on the
        /// object type. As a side effect {@link JXG.Board#numObjects}
        /// is updated.</summary>
        /// <param name="obj">- Reference of an geometry object that needs an id.</param>
        /// <param name="type">- Type of the object.</param>
        abstract setId: obj: obj option * ``type``: float -> string
        /// <summary>After construction of the object the visibility is set
        /// and the label is constructed if necessary.</summary>
        /// <param name="obj">- The object to add.</param>
        abstract finalizeAdding: obj: obj option -> unit
        /// Calculates mouse coordinates relative to the boards container.
        abstract getCoordsTopLeftCorner: unit -> ResizeArray<obj option>
        /// <summary>Get the position of the mouse in screen coordinates, relative to the upper left corner
        /// of the host tag.</summary>
        /// <param name="e">- Event object given by the browser.</param>
        /// <param name="i">- Only use in case of touch events. This determines which finger to use and should not be set
        /// for mouseevents.</param>
        abstract getMousePosition: e: Event * ?i: float -> ResizeArray<obj option>
        /// <summary>Initiate moving the origin. This is used in mouseDown and touchStart listeners.</summary>
        /// <param name="x">- Current mouse/touch coordinates</param>
        /// <param name="y">- Current mouse/touch coordinates</param>
        abstract initMoveOrigin: x: float * y: float -> unit
        /// <summary>Collects all elements below the current mouse pointer and fulfilling the following constraints:
        /// <ul><li>isDraggable</li><li>visible</li><li>not fixed</li><li>not frozen</li></ul></summary>
        /// <param name="x">- Current mouse/touch coordinates</param>
        /// <param name="y">- current mouse/touch coordinates</param>
        /// <param name="evt">- An event object</param>
        /// <param name="type">- What type of event? 'touch', 'mouse' or 'pen'.</param>
        abstract initMoveObject: x: float * y: float * evt: obj option * ``type``: string -> ResizeArray<obj option>
        /// <summary>Moves an object.</summary>
        /// <param name="x">- Coordinate</param>
        /// <param name="y">- Coordinate</param>
        /// <param name="o">- The touch object that is dragged: {JXG.Board#mouse} or {JXG.Board#touches}.</param>
        /// <param name="evt">- The event object.</param>
        /// <param name="type">- Mouse or touch event?</param>
        abstract moveObject: x: float * y: float * o: obj option * evt: obj option * ``type``: string -> unit
        /// <summary>Moves elements in multitouch mode.</summary>
        /// <param name="p1">- x,y coordinates of first touch</param>
        /// <param name="p2">- x,y coordinates of second touch</param>
        /// <param name="o">- The touch object that is dragged: {JXG.Board#touches}.</param>
        /// <param name="evt">- The event object that lead to this movement.</param>
        abstract twoFingerMove: p1: ResizeArray<obj option> * p2: ResizeArray<obj option> * o: obj option * evt: obj option -> unit
        /// <summary>Moves, rotates and scales a line or polygon with two fingers.</summary>
        /// <param name="np1c">- x,y coordinates of first touch</param>
        /// <param name="np2c">- x,y coordinates of second touch</param>
        /// <param name="o">- The touch object that is dragged: {JXG.Board#touches}.</param>
        /// <param name="drag">- The object that is dragged:</param>
        /// <param name="evt">- The event object that lead to this movement.</param>
        abstract twoFingerTouchObject: np1c: JXG.Coords * np2c: JXG.Coords * o: obj option * drag: obj option * evt: obj option -> unit
        /// Add all possible event handlers to the board object
        abstract addEventHandlers: unit -> unit
        /// Registers the MSPointer* event handlers.
        abstract addPointerEventHandlers: unit -> unit
        /// Registers mouse move, down and wheel event handlers.
        abstract addMouseEventHandlers: unit -> unit
        /// <summary>Register touch start and move and gesture start and change event handlers.</summary>
        /// <param name="appleGestures">- If set to false the gesturestart and gesturechange event handlers
        /// will not be registered.
        /// Since iOS 13, touch events were abandoned in favour of pointer events</param>
        abstract addTouchEventHandlers: appleGestures: bool -> unit
        /// Add fullscreen events which update the CSS transformation matrix to correct
        /// the mouse/touch/pointer positions in case of CSS transformations.
        abstract addFullscreenEventHandlers: unit -> unit
        /// Remove all registered event handlers regarding fullscreen mode.
        abstract removeFullscreenEventHandlers: unit -> unit
        /// Remove MSPointer* Event handlers.
        abstract removePointerEventHandlers: unit -> unit
        /// De-register mouse event handlers.
        abstract removeMouseEventHandlers: unit -> unit
        /// Remove all registered touch event handlers.
        abstract removeTouchEventHandlers: unit -> unit
        /// Remove all event handlers from the board object
        abstract removeEventHandlers: unit -> unit
        /// Handler for click on left arrow in the navigation bar
        abstract clickLeftArrow: unit -> JXG.Board
        /// Handler for click on right arrow in the navigation bar
        abstract clickRightArrow: unit -> JXG.Board
        /// Handler for click on up arrow in the navigation bar
        abstract clickUpArrow: unit -> JXG.Board
        /// Handler for click on down arrow in the navigation bar
        abstract clickDownArrow: unit -> JXG.Board
        /// <summary>Triggered on iOS/Safari while the user inputs a gesture (e.g. pinch) and is used to zoom into the board.
        /// Works on iOS/Safari and Android.</summary>
        /// <param name="evt">- Browser event object</param>
        abstract gestureChangeListener: evt: Event -> bool
        /// Called by iOS/Safari as soon as the user starts a gesture. Works natively on iOS/Safari,
        /// on Android we emulate it.
        abstract gestureStartListener: evt: Event -> bool
        /// pointer-Events
        abstract _pointerIsTouchRegistered: unit -> unit
        /// <summary>This method is called by the browser when a pointing device is pressed on the screen.</summary>
        /// <param name="evt">- The browsers event object.</param>
        /// <param name="object">- If the object to be dragged is already known, it can be submitted via this parameter</param>
        abstract pointerDownListener: evt: Event * ``object``: obj option -> bool
        /// Called if pointer leaves an HTML tag. Is called by the inner-most tag.
        /// That means, if a JSXGraph text, i.e. an HTML div, is placed close
        /// to the border of the board, this pointerout event will be ignored.
        abstract pointerOutListener: evt: Event -> bool
        /// Called periodically by the browser while the user moves a pointing device across the screen.
        abstract pointerMoveListener: evt: Event -> bool
        /// Triggered as soon as the user stops touching the device with at least one finger.
        abstract pointerUpListener: evt: Event -> bool
        /// <summary>This method is called by the browser when a finger touches the surface of the touch-device.</summary>
        /// <param name="evt">- The browsers event object.</param>
        abstract touchStartListener: evt: Event -> bool
        /// Called periodically by the browser while the user moves his fingers across the device.
        abstract touchMoveListener: evt: Event -> bool
        /// Triggered as soon as the user stops touching the device with at least one finger.
        abstract touchEndListener: evt: Event -> bool
        /// <summary>This method is called by the browser when the mouse button is clicked.</summary>
        /// <param name="evt">- The browsers event object.</param>
        abstract mouseDownListener: evt: Event -> bool
        /// <summary>This method is called by the browser when the mouse is moved.</summary>
        /// <param name="evt">- The browsers event object.</param>
        abstract mouseMoveListener: evt: Event -> unit
        /// This method is called by the browser when the mouse button is released.
        abstract mouseUpListener: evt: Event -> unit
        /// Handler for mouse wheel events. Used to zoom in and out of the board.
        abstract mouseWheelListener: evt: Event -> bool
        /// Initialize the info box object which is used to display
        /// the coordinates of points near the mouse pointer,
        abstract initInfobox: unit -> JXG.Board
        /// <summary>Updates and displays a little info box to show coordinates of current selected points.</summary>
        /// <param name="el">- A GeometryElement</param>
        abstract updateInfobox: el: JXG.GeometryElement -> JXG.Board
        /// <summary>Set infobox visible / invisible.
        /// 
        /// It uses its property hiddenByParent to memorize its status.
        /// In this way, many DOM access can be avoided.</summary>
        /// <param name="val">- true for visible, false for invisible</param>
        abstract showInfobox: ``val``: bool -> JXG.Board
        /// <summary>Changes the text of the info box to show the given coordinates.</summary>
        /// <param name="el">- The element the mouse is pointing at</param>
        abstract highlightInfobox: x: float * y: float * ?el: JXG.GeometryElement -> JXG.Board
        /// Changes the text of the info box to what is provided via text.
        abstract highlightCustomInfobox: text: string * ?el: JXG.GeometryElement -> JXG.Board
        /// Remove highlighting of all elements.
        abstract dehighlightAll: unit -> JXG.Board
        /// <summary>Returns the input parameters in an array. This method looks pointless and it really is, but it had a purpose
        /// once.</summary>
        /// <param name="x">- X coordinate in screen coordinates</param>
        /// <param name="y">- Y coordinate in screen coordinates</param>
        abstract getScrCoordsOfMouse: x: float * y: float -> ResizeArray<obj option>
        /// <summary>This method calculates the user coords of the current mouse coordinates.</summary>
        /// <param name="evt">- Event object containing the mouse coordinates.</param>
        abstract getUsrCoordsOfMouse: evt: Event -> ResizeArray<obj option>
        /// <summary>Collects all elements under current mouse position plus current user coordinates of mouse cursor.</summary>
        /// <param name="evt">- Event object containing the mouse coordinates.</param>
        abstract getAllUnderMouse: evt: Event -> ResizeArray<obj option>
        /// <summary>Collects all elements under current mouse position.</summary>
        /// <param name="evt">- Event object containing the mouse coordinates.</param>
        abstract getAllObjectsUnderMouse: evt: Event -> ResizeArray<obj option>
        /// Update the coords object of all elements which possess this
        /// property. This is necessary after changing the viewport.
        abstract updateCoords: unit -> JXG.Board
        /// Moves the origin and initializes an update of all elements.
        abstract moveOrigin: x: float * y: float * ?diff: bool -> JXG.Board
        /// <summary>Add conditional updates to the elements.</summary>
        /// <param name="str">- String containing coniditional update in geonext syntax</param>
        abstract addConditions: str: string -> unit
        /// Calculates adequate snap sizes.
        abstract calculateSnapSizes: unit -> JXG.Board
        /// Apply update on all objects with the new zoom-factors. Clears all traces.
        abstract applyZoom: unit -> JXG.Board
        /// Zooms into the board by the factors board.attr.zoom.factorX and board.attr.zoom.factorY and applies the zoom.
        /// The zoom operation is centered at x, y.
        abstract zoomIn: ?x: float * ?y: float -> JXG.Board
        /// Zooms out of the board by the factors board.attr.zoom.factorX and board.attr.zoom.factorY and applies the zoom.
        /// The zoom operation is centered at x, y.
        abstract zoomOut: ?x: float * ?y: float -> JXG.Board
        /// Resets zoom factor to 100%.
        abstract zoom100: unit -> JXG.Board
        /// Zooms the board so every visible point is shown. Keeps aspect ratio.
        abstract zoomAllPoints: unit -> JXG.Board
        /// <summary>Reset the bounding box and the zoom level to 100% such that a given set of elements is
        /// within the board's viewport.</summary>
        /// <param name="elements">- A set of elements given by id, reference, or name.</param>
        abstract zoomElements: elements: ResizeArray<obj option> -> JXG.Board
        /// Sets the zoom level to <tt>fX</tt> resp <tt>fY</tt>.
        abstract setZoom: fX: float * fY: float -> JXG.Board
        /// <summary>Removes object from board and renderer.
        /// <p>
        /// <b>Performance hints:</b> It is recommended to use the object's id.
        /// If many elements are removed, it is best to call board.suspendUpdate()
        /// before looping through the elements to be removed and call
        /// board.unsuspendUpdate() after the loop. Further, it is advisable to loop
        /// in reverse order, i.e. remove the object in reverse order of their creation time.</summary>
        /// <param name="object">- The object to remove or array of objects to be removed.
        /// The element(s) is/are given by name, id or a reference.</param>
        /// <param name="saveMethod">- If true, the algorithm runs through all elements
        /// and tests if the element to be deleted is a child element. If yes, it will be
        /// removed from the list of child elements. If false (default), the element
        /// is removed from the lists of child elements of all its ancestors.
        /// This should be much faster.</param>
        abstract removeObject: ``object``: U2<JXG.GeometryElement, ResizeArray<obj option>> * saveMethod: bool -> JXG.Board
        /// <summary>Removes the ancestors of an object an the object itself from board and renderer.</summary>
        /// <param name="object">- The object to remove.</param>
        abstract removeAncestors: ``object``: JXG.GeometryElement -> JXG.Board
        /// Initialize some objects which are contained in every GEONExT construction by default,
        /// but are not contained in the gxt files.
        abstract initGeonextBoard: unit -> JXG.Board
        /// <summary>Change the height and width of the board's container.
        /// After doing so, {@link JXG.JSXGraph.setBoundingBox} is called using
        /// the actual size of the bounding box and the actual value of keepaspectratio.
        /// If setBoundingbox() should not be called automatically,
        /// call resizeContainer with dontSetBoundingBox == true.</summary>
        /// <param name="canvasWidth">- New width of the container.</param>
        /// <param name="canvasHeight">- New height of the container.</param>
        /// <param name="dontset">- If true do not set the CSS width and height of the DOM element.</param>
        /// <param name="dontSetBoundingBox">- If true do not call setBoundingBox().</param>
        abstract resizeContainer: canvasWidth: float * canvasHeight: float * ?dontset: bool * ?dontSetBoundingBox: bool -> JXG.Board
        /// Lists the dependencies graph in a new HTML-window.
        abstract showDependencies: unit -> JXG.Board
        /// Lists the XML code of the construction in a new HTML-window.
        abstract showXML: unit -> JXG.Board
        /// Sets for all objects the needsUpdate flag to "true".
        abstract prepareUpdate: unit -> JXG.Board
        /// <summary>Runs through all elements and calls their update() method.</summary>
        /// <param name="drag">- Element that caused the update.</param>
        abstract updateElements: drag: JXG.GeometryElement -> JXG.Board
        /// Runs through all elements and calls their update() method.
        abstract updateRenderer: unit -> JXG.Board
        /// Runs through all elements and calls their update() method.
        /// This is a special version for the CanvasRenderer.
        /// Here, we have to do our own layer handling.
        abstract updateRendererCanvas: unit -> JXG.Board
        /// <summary>Please use {@link JXG.Board.on} instead.</summary>
        /// <param name="hook">- A function to be called by the board after an update occurred.</param>
        /// <param name="m">- When the hook is to be called. Possible values are <i>mouseup</i>, <i>mousedown</i> and <i>update</i>.</param>
        /// <param name="context">- Determines the execution context the hook is called. This parameter is optional, default is the
        /// board object the hook is attached to.</param>
        abstract addHook: hook: (ResizeArray<obj option> -> obj option) * ?m: string * ?context: obj -> float
        /// Alias of {@link JXG.Board.on}.
        abstract addEvent: obj option with get, set
        /// <summary>Please use {@link JXG.Board.off} instead.</summary>
        /// <param name="id">- The number you got when you added the hook or a reference to the event handler.</param>
        abstract removeHook: id: U2<float, (ResizeArray<obj option> -> obj option)> -> JXG.Board
        /// Alias of {@link JXG.Board.off}.
        abstract removeEvent: obj option with get, set
        /// Runs through all hooked functions and calls them.
        abstract updateHooks: unit -> JXG.Board
        /// <summary>Adds a dependent board to this board.</summary>
        /// <param name="board">- A reference to board which will be updated after an update of this board occurred.</param>
        abstract addChild: board: JXG.Board -> JXG.Board
        /// <summary>Deletes a board from the list of dependent boards.</summary>
        /// <param name="board">- Reference to the board which will be removed.</param>
        abstract removeChild: board: JXG.Board -> JXG.Board
        /// <summary>Runs through most elements and calls their update() method and update the conditions.</summary>
        /// <param name="drag">- Element that caused the update.</param>
        abstract update: ?drag: JXG.GeometryElement -> JXG.Board
        /// Runs through all elements and calls their update() method and update the conditions.
        /// This is necessary after zooming and changing the bounding box.
        abstract fullUpdate: unit -> JXG.Board
        /// Adds a grid to the board according to the settings given in board.options.
        abstract addGrid: unit -> JXG.Board
        /// Removes all grids assigned to this board. Warning: This method also removes all objects depending on one or
        /// more of the grids.
        abstract removeGrids: unit -> JXG.Board
        /// <summary>Creates a new geometric element of type elementType.</summary>
        /// <param name="elementType">- Type of the element to be constructed given as a string e.g. 'point' or 'circle'.</param>
        /// <param name="parents">- Array of parent elements needed to construct the element e.g. coordinates for a point or two
        /// points to construct a line. This highly depends on the elementType that is constructed. See the corresponding JXG.create*
        /// methods for a list of possible parameters.</param>
        /// <param name="attributes">- An object containing the attributes to be set. This also depends on the elementType.
        /// Common attributes are name, visible, strokeColor.</param>
        abstract create: elementType: string * parents: ResizeArray<obj option> * ?attributes: obj -> obj option
        /// Deprecated name for {@link JXG.Board.create}.
        abstract createElement: unit -> unit
        /// Delete the elements drawn as part of a trace of an element.
        abstract clearTraces: unit -> JXG.Board
        /// Stop updates of the board.
        abstract suspendUpdate: unit -> JXG.Board
        /// Enable updates of the board.
        abstract unsuspendUpdate: unit -> JXG.Board
        /// <summary>Set the bounding box of the board.</summary>
        /// <param name="bbox">- New bounding box [x1,y1,x2,y2]</param>
        /// <param name="keepaspectratio">- If set to true, the aspect ratio will be 1:1, but
        /// the resulting viewport may be larger.</param>
        abstract setBoundingBox: bbox: ResizeArray<obj option> * ?keepaspectratio: bool -> JXG.Board
        /// Get the bounding box of the board.
        abstract getBoundingBox: unit -> ResizeArray<obj option>
        /// <summary>Adds an animation. Animations are controlled by the boards, so the boards need to be aware of the
        /// animated elements. This function tells the board about new elements to animate.</summary>
        /// <param name="element">- The element which is to be animated.</param>
        abstract addAnimation: element: JXG.GeometryElement -> JXG.Board
        /// Cancels all running animations.
        abstract stopAllAnimation: unit -> JXG.Board
        /// General purpose animation function. This currently only supports moving points from one place to another. This
        /// is faster than managing the animation per point, especially if there is more than one animated point at the same time.
        abstract animate: unit -> JXG.Board
        /// <summary>Migrate the dependency properties of the point src
        /// to the point dest and  delete the point src.
        /// For example, a circle around the point src
        /// receives the new center dest. The old center src
        /// will be deleted.</summary>
        /// <param name="src">- Original point which will be deleted</param>
        /// <param name="dest">- New point with the dependencies of src.</param>
        /// <param name="copyName">- Flag which decides if the name of the src element is copied to the
        /// dest element.</param>
        abstract migratePoint: src: JXG.Point * dest: JXG.Point * copyName: bool -> JXG.Board
        /// <summary>Initializes color blindness simulation.</summary>
        /// <param name="deficiency">- Describes the color blindness deficiency which is simulated. Accepted values are 'protanopia', 'deuteranopia', and 'tritanopia'.</param>
        abstract emulateColorblindness: deficiency: string -> JXG.Board
        /// <summary>Select a single or multiple elements at once.</summary>
        /// <param name="str">- The name, id or a reference to a JSXGraph element on this board. An object will
        /// be used as a filter to return multiple elements at once filtered by the properties of the object.</param>
        /// <param name="onlyByIdOrName">- If true (default:false) elements are only filtered by their id, name or groupId.
        /// The advanced filters consisting of objects or functions are ignored.</param>
        abstract select: str: U3<string, obj option, (ResizeArray<obj option> -> obj option)> * onlyByIdOrName: bool -> U2<JXG.GeometryElement, JXG.Composition>
        /// <summary>Checks if the given point is inside the boundingbox.</summary>
        /// <param name="x">- User coordinate or {@link JXG.Coords} object.</param>
        /// <param name="y">- User coordinate. May be omitted in case <tt>x</tt> is a {@link JXG.Coords} object.</param>
        abstract hasPoint: x: U2<float, JXG.Coords> * ?y: float -> bool
        /// Update CSS transformations of sclaing type. It is used to correct the mouse position
        /// in {@link JXG.Board.getMousePosition}.
        /// The inverse transformation matrix is updated on each mouseDown and touchStart event.
        /// 
        /// It is up to the user to call this method after an update of the CSS transformation
        /// in the DOM.
        abstract updateCSSTransforms: unit -> unit
        /// Start selection mode. This function can either be triggered from outside or by
        /// a down event together with correct key pressing. The default keys are
        /// shift+ctrl. But this can be changed in the options.
        /// 
        /// Starting from out side can be realized for example with a button like this:
        /// <pre>
        ///   &lt;button onclick="board.startSelectionMode()"&gt;Start&lt;/button&gt;
        /// </pre>
        abstract startSelectionMode: unit -> unit
        /// Finalize the selection: disable selection mode and return the coordinates
        /// of the selection rectangle.
        abstract stopSelectionMode: unit -> ResizeArray<obj option>
        /// <summary>Test if a down event should start a selection. Test if the
        /// required keys are pressed. If yes, {@link JXG.Board.startSelectionMode} is called.</summary>
        /// <param name="evt">- Event object</param>
        abstract _testForSelection: evt: obj option -> unit
        /// Expand the JSXGraph construction to fullscreen.
        /// In order to preserve the proportions of the JSXGraph element,
        /// a wrapper div is created which is set to fullscreen.
        /// <p>
        /// The wrapping div has the CSS class 'jxgbox_wrap_private' which is
        /// defined in the file 'jsxgraph.css'
        abstract toFullscreen: unit -> JXG.Board
        /// <summary>If fullscreen mode is toggled, the possible CSS transformations
        /// which are applied to the JSXGraph canvas have to be reread.
        /// Otherwise the position of upper left corner is wrongly interpreted.</summary>
        /// <param name="evt">- fullscreen event object</param>
        abstract fullscreenListener: evt: obj option -> unit
        /// <summary>Function to animate a curve rolling on another curve.</summary>
        /// <param name="c1">- JSXGraph curve building the floor where c2 rolls</param>
        /// <param name="c2">- JSXGraph curve which rolls on c1.</param>
        /// <param name="start_c1">- The parameter t such that c1(t) touches c2. This is the start position of the
        ///       rolling process</param>
        /// <param name="stepsize">- Increase in t in each step for the curve c1</param>
        /// <param name="time">- Delay time for setInterval()</param>
        /// <param name="pointlist">- Array of points which are rolled in each step. This list should contain
        /// all points which define c2 and gliders on c2.</param>
        abstract createRoulette: c1: Curve * c2: Curve * start_c1: float * stepsize: float * direction: float * time: float * pointlist: ResizeArray<obj option> -> unit
        /// Bounding box of the visible area in user coordinates.
        /// It is an array consisting of four values:
        /// [x<sub>1</sub>, y<sub>1</sub>, x<sub>2</sub>, y<sub>2</sub>]
        /// 
        /// The canvas will be spanned from the upper left corner (<sub>1</sub>, y<sub>1</sub>)
        /// to the lower right corner (x<sub>2</sub>, y<sub>2</sub>).
        abstract boundingbox: ResizeArray<obj option> with get, set
        /// Maximal bounding box of the visible area in user coordinates.
        /// It is an array consisting of four values:
        /// [x<sub>1</sub>, y<sub>1</sub>, x<sub>2</sub>, y<sub>2</sub>]
        /// 
        /// The bounding box of the canvas must be inside of this maximal
        /// boundings box.
        abstract maxboundingbox: ResizeArray<obj option> with get, set
        /// Additional zoom factor multiplied to {@link JXG.Board#zoomX} and {@link JXG.Board#zoomY}.
        abstract zoomFactor: float with get, set
        /// Zoom factor in X direction. It only stores the zoom factor to be able
        /// to get back to 100% in zoom100().
        /// Zoom factor in X direction. It only stores the zoom factor to be able
        /// to get back to 100% in zoom100().
        abstract zoomX: float with get, set
        /// Zoom factor in Y direction. It only stores the zoom factor to be able
        /// to get back to 100% in zoom100().
        /// Zoom factor in Y direction. It only stores the zoom factor to be able
        /// to get back to 100% in zoom100().
        abstract zoomY: float with get, set
        /// Show copyright string in canvas.
        abstract showCopyright: bool with get, set
        /// Show default axis.
        /// If shown, the horizontal axis can be accessed via JXG.Board.defaultAxes.x, the
        /// vertical axis can be accessed via JXG.Board.defaultAxes.y.
        /// Both axes have a sub-element "defaultTicks".
        /// 
        /// Value can be Boolean or an object containing axis attributes.
        abstract axis: bool with get, set
        /// Attributes for the default axes in case of the attribute
        /// axis:true in {@link JXG.JSXGraph#initBoard}.
        abstract defaultAxes: obj option with get, set
        /// Display of navigation arrows and zoom buttons in the navigation bar.
        abstract showNavigation: bool with get, set
        /// Display of zoom buttons in the navigation bar. To show zoom buttons, additionally
        /// showNavigation has to be set to true.
        abstract showZoom: bool with get, set
        /// Show a button in the navigation bar to force reload of a construction.
        /// Works only with the JessieCode tag.
        abstract showReload: bool with get, set
        /// Show a button in the navigation bar to enable screenshots.
        abstract showScreenshot: bool with get, set
        /// Attributes to control the screenshot function.
        /// The following attributes can be set:
        /// <ul>
        /// <li>scale: scaling factor (default=0)
        /// <li>type: format of the screenshot image. Default: png
        /// <li>symbol: Unicode symbol which is shown in the navigation bar. Default: '\u2318'
        /// <li>css: CSS rules to format the div element containing the screen shot image
        /// <li>cssButton: CSS rules to format the close button of the div element containing the screen shot image
        /// </ul>
        abstract screenshot: obj option with get, set
        /// Show a button in the navigation bar to start fullscreen mode.
        abstract showFullscreen: bool with get, set
        /// Attribute(s) to control the fullscreen icon. The attribute "showFullscreen"
        /// controls if the icon is shown.
        /// The following attribute(s) can be set:
        /// <ul>
        /// <li>symbol: Unicode symbol which is shown in the navigation bar. Default: '\u25a1'
        /// </ul>
        abstract fullscreen: obj option with get, set
        /// Show a button which allows to clear all traces of a board.
        abstract showClearTraces: bool with get, set
        /// If set to true the bounding box might be changed such that
        /// the ratio of width and height of the hosting HTML div is equal
        /// to the ratio of wifth and height of the bounding box.
        /// 
        /// This is necessary if circles should look like circles and not
        /// like ellipses. It is recommended to set keepAspectRatio = true
        /// for geometric applets. For function plotting keepAspectRatio = false
        /// might be the better choice.
        abstract keepAspectRatio: bool with get, set
        /// If set true and
        /// hasPoint() is true for both an element and it's label,
        /// the element (and not the label) is taken as drag element.
        /// 
        /// If set false and hasPoint() is true for both an element and it's label,
        /// the label is taken (if it is on a higher layer than the element)
        abstract ignoreLabels: Booelan with get, set
        /// Maximum number of digits in automatic label generation.
        /// For example, if set to 1 automatic point labels end at "Z".
        /// If set to 2, point labels end at "ZZ".
        abstract maxNameLength: float with get, set
        /// Supply the document object. Defaults to window.document
        abstract document: obj option with get, set
        /// If true the first element of the set JXG.board.objects having hasPoint==true is taken as drag element.
        abstract takeFirst: bool with get, set
        /// If true, when read from a file or string - the size of the div can be changed by the construction text.
        abstract takeSizeFromFile: bool with get, set
        /// A reference to this boards renderer.
        /// A reference to this boards renderer.
        abstract renderer: JXG.AbstractRenderer with get, set
        /// Time (in msec) between two animation steps. Used in
        /// {@link JXG.CoordsElement#moveAlong}, {@link JXG.CoordsElement#moveTo} and
        /// {@link JXG.CoordsElement#visit}.
        abstract animationDelay: float with get, set
        /// Allow user interaction by registering mouse and touch events.
        abstract registerEvents: bool with get, set
        /// Change redraw strategy in SVG rendering engine.
        /// 
        /// If set to 'svg', before every redrawing of the JSXGraph construction
        /// the SVG sub-tree of the DOM tree is taken out of the DOM.
        /// 
        /// If set to 'all', before every redrawing of the JSXGraph construction the
        /// complete DOM tree is taken out of the DOM.
        /// If set to 'none' the redrawing is done in-place.
        /// 
        /// Using 'svg' or 'all' speeds up the update process considerably. The risk
        /// is that if there is an exception, only a white div or window is left.
        abstract minimizeReflow: string with get, set
        /// A number that will be added to the absolute position of the board used in mouse coordinate
        /// calculations in {@link JXG.Board#getCoordsTopLeftCorner}.
        abstract offsetX: float with get, set
        /// A number that will be added to the absolute position of the board used in mouse coordinate
        /// calculations in {@link JXG.Board#getCoordsTopLeftCorner}.
        abstract offsetY: float with get, set
        /// Control the possibilities for zoom interaction.
        /// 
        /// Possible sub-attributes with default values are:
        /// <pre>
        /// zoom: {
        /// factorX: 1.25,  // horizontal zoom factor (multiplied to {@link JXG.Board#zoomX})
        /// factorY: 1.25,  // vertical zoom factor (multiplied to {@link JXG.Board#zoomY})
        /// wheel: true,     // allow zooming by mouse wheel or
        ///                  // by pinch-to-toom gesture on touch devices
        /// needShift: true, // mouse wheel zooming needs pressing of the shift key
        /// min: 0.001        // minimal values of {@link JXG.Board#zoomX} and {@link JXG.Board#zoomY}, limits zoomOut
        /// max: 1000.0       // maximal values of {@link JXG.Board#zoomX} and {@link JXG.Board#zoomY}, limits zoomIn
        /// 
        /// pinchHorizontal: true // Allow pinch-to-zoom to zoom only horizontal axis
        /// pinchVertical: true   // Allow pinch-to-zoom to zoom only vertical axis
        /// pinchSensitivity: 7   // Sensitivity (in degrees) for recognizing horizontal or vertical pinch-to-zoom gestures.
        /// }
        /// </pre>
        /// 
        /// Deprecated: zoom.eps which is superseded by zoom.min
        abstract zoom: obj option with get, set
        /// Control the possibilities for panning interaction (i.e. moving the origin).
        /// 
        /// Possible sub-attributes with default values are:
        /// <pre>
        /// pan: {
        /// enabled: true   // Allow panning
        /// needTwoFingers: true, // panning is done with two fingers on touch devices
        /// needShift: true, // mouse panning needs pressing of the shift key
        /// }
        /// </pre>
        abstract pan: obj option with get, set
        /// Control the possibilities for a selection rectangle.
        /// Starting a selection event triggers the "startselecting" event.
        /// When the mouse pointer is released, the "stopselecting" event is fired.
        /// The "stopselecting" event must be supplied by the user.
        /// <p>
        /// Possible sub-attributes with default values are:
        /// <pre>
        /// selection: {
        /// enabled: false,
        /// name: 'selectionPolygon',
        /// needShift: false,  // mouse selection needs pressing of the shift key
        /// needCtrl: true,    // mouse selection needs pressing of the shift key
        /// withLines: false,  // Selection polygon has border lines
        /// vertices: {
        ///     visible: false
        /// },
        /// fillColor: '#ffff00',
        /// visible: false      // Initial visibility. Should be set to false always
        /// }
        /// </pre>
        abstract selection: obj option with get, set
        /// <param name="string">- A string containing construction(s) in JSXGraph Construction Syntax.</param>
        /// <param name="mode">- Possible values seem are "normal" or "macro"</param>
        /// <param name="params">- Parameters, only used in macro mode</param>
        /// <param name="paraIn">- Parameters, only used in macro mode</param>
        /// <param name="macroName">- Name of the macro, only used in macro mode</param>
        abstract construct: string: string * mode: string * ``params``: ResizeArray<obj option> * paraIn: ResizeArray<obj option> * macroName: string -> obj option
        /// <summary>Parses a string like<br />
        /// <tt>&lt;macro-name&gt; = Macro(A, B, C) { <Command in JSXGraph Construction syntax>; ...<Command in JXG-Construct syntax>; }</tt><br />
        /// and adds it as a macro so it can be used in the JSXGraph Construction Syntax.</summary>
        /// <param name="string">- A string like the one in the methods description.</param>
        abstract addMacro: string: string -> unit

    /// Constructs a new Board object.
    type [<AllowNullLiteral>] BoardStatic =
        [<Emit "new $0($1...)">] abstract Create: container: string * renderer: JXG.AbstractRenderer * id: string * origin: JXG.Coords * zoomX: float * zoomY: float * unitX: float * unitY: float * canvasWidth: float * canvasHeight: float * attributes: obj option -> Board

    /// The Chart class is a basic class for the chart object.
    type [<AllowNullLiteral>] Chart =
        inherit JXG.GeometryElement
        /// Contains pointers to the various subelements of the chart.
        abstract elements: obj option with get, set
        /// <summary>Create line chart defined by two data arrays.</summary>
        /// <param name="x">- Array of x-coordinates</param>
        /// <param name="y">- Array of y-coordinates</param>
        /// <param name="attributes">- Javascript object containing attributes like colors</param>
        abstract drawLine: x: ResizeArray<obj option> * y: ResizeArray<obj option> * attributes: obj option -> JXG.Curve
        /// <summary>Create line chart that consists of a natural spline curve
        /// defined by two data arrays.</summary>
        /// <param name="x">- Array of x-coordinates</param>
        /// <param name="y">- Array of y-coordinates</param>
        /// <param name="attributes">- Javascript object containing attributes like colors</param>
        abstract drawSpline: x: ResizeArray<obj option> * y: ResizeArray<obj option> * attributes: obj option -> JXG.Curve
        /// <summary>Create line chart where the curve is given by a regression polynomial
        /// defined by two data arrays. The degree of the polynomial is supplied
        /// through the attribute "degree" in attributes.</summary>
        /// <param name="x">- Array of x-coordinates</param>
        /// <param name="y">- Array of y-coordinates</param>
        /// <param name="attributes">- Javascript object containing attributes like colors</param>
        abstract drawFit: x: ResizeArray<obj option> * y: ResizeArray<obj option> * attributes: obj option -> JXG.Curve
        /// <summary>Create bar chart defined by two data arrays.
        /// Attributes to change the layout of the bar chart are:
        /// <ul>
        /// <li> width (optional)
        /// <li> dir: 'horizontal' or 'vertical'
        /// <li> colors: array of colors
        /// <li> labels: array of labels
        /// </ul></summary>
        /// <param name="x">- Array of x-coordinates</param>
        /// <param name="y">- Array of y-coordinates</param>
        /// <param name="attributes">- Javascript object containing attributes like colors</param>
        abstract drawBar: x: ResizeArray<obj option> * y: ResizeArray<obj option> * attributes: obj option -> ResizeArray<obj option>
        /// <summary>Create chart consisting of JSXGraph points.
        /// Attributes to change the layout of the point chart are:
        /// <ul>
        /// <li> fixed (Boolean)
        /// <li> infoboxArray (Array): Texts for the infobox
        /// </ul></summary>
        /// <param name="x">- Array of x-coordinates</param>
        /// <param name="y">- Array of y-coordinates</param>
        /// <param name="attributes">- Javascript object containing attributes like colors</param>
        abstract drawPoints: x: ResizeArray<obj option> * y: ResizeArray<obj option> * attributes: obj option -> ResizeArray<obj option>
        /// <summary>Create pie chart.
        /// Attributes to change the layout of the pie chart are:
        /// <ul>
        /// <li> labels: array of labels
        /// <li> colors: (Array)
        /// <li> highlightColors (Array)
        /// <li> radius
        /// <li> center (coordinate array)
        /// <li> highlightOnSector (Boolean)
        /// </ul></summary>
        /// <param name="y">- Array of x-coordinates</param>
        /// <param name="attributes">- Javascript object containing attributes like colors</param>
        abstract drawPie: y: ResizeArray<obj option> * attributes: obj option -> obj option
        /// <summary>Create radar chart.
        /// Attributes to change the layout of the pie chart are:
        /// <ul>
        /// <li> paramArray: labels for axes, [ paramx, paramy, paramz ]
        /// <li> startShiftRatio: 0 <= offset from chart center <=1
        /// <li> endShiftRatio:  0 <= offset from chart radius <=1
        /// <li> startShiftArray: Adjust offsets per each axis
        /// <li> endShiftArray: Adjust offsets per each axis
        /// <li> startArray: Values for inner circle. Default values: minimums
        /// <li> start: one value to overwrite all startArray values
        /// <li> endArray: Values for outer circle, maximums by default
        /// <li> end: one value to overwrite all endArray values
        /// <li> labelArray
        /// <li> polyStrokeWidth
        /// <li> colors
        /// <li> highlightcolors
        /// <li> labelArray: [ row1, row2, row3 ]
        /// <li> radius
        /// <li> legendPosition
        /// <li> showCircles
        /// <li> circleLabelArray
        /// <li> circleStrokeWidth
        /// </ul></summary>
        /// <param name="parents">- Array of coordinates, e.g. [[x1, y1, z1], [x2, y2, z2], [x3, y3, z3]]</param>
        /// <param name="attributes">- Javascript object containing attributes like colors</param>
        abstract drawRadar: parents: ResizeArray<obj option> * attributes: obj option -> obj option
        /// Template for dynamic charts update.
        /// This method is used to compute new entries
        /// for the arrays this.dataX and
        /// this.dataY. It is used in update.
        /// Default is an empty method, can be overwritten
        /// by the user.
        abstract updateDataArray: unit -> JXG.Chart
        /// Stores the SVG (or VML) rendering node for the element. This enables low-level
        /// access to SVG nodes. The properties of such an SVG node can then be changed
        /// by calling setAttribute(). Note that there are a few elements which consist
        /// of more than one SVG nodes:
        /// <ul>
        /// <li> Elements with arrow tail or head: rendNodeTriangleStart, rendNodeTriangleEnd
        /// <li> SVG (or VML) texts: rendNodeText
        /// <li> Button: rendNodeForm, rendNodeButton, rendNodeTag
        /// <li> Checkbox: rendNodeForm, rendNodeCheckbox, rendNodeLabel, rendNodeTag
        /// <li> Input: rendNodeForm, rendNodeInput, rendNodeLabel, rendNodeTag
        /// </ul>
        /// 
        /// Here is are two examples: The first example shows how to access the SVG node,
        /// the second example demonstrates how to change SVG attributes.
        abstract rendNode: obj option with get, set
        /// Unique identifier for the element. Equivalent to id-attribute of renderer element.
        abstract id: string with get, set
        /// General update method. Should be overwritten by the element itself.
        /// Can be used sometimes to commit changes to the object.
        abstract update: unit -> JXG.GeometryElement
        /// <summary>Highlights the element.</summary>
        /// <param name="force">- Force the highlighting</param>
        abstract highlight: ?force: bool -> JXG.Board
        /// <summary>Set the highlightStrokeColor of an element</summary>
        /// <param name="sColor">- String which determines the stroke color of an object when its highlighted.</param>
        abstract highlightStrokeColor: sColor: string -> unit
        /// <summary>Set the strokeColor of an element</summary>
        /// <param name="sColor">- String which determines the stroke color of an object.</param>
        abstract strokeColor: sColor: string -> unit
        /// <summary>Set the strokeWidth of an element</summary>
        /// <param name="width">- Integer which determines the stroke width of an outline.</param>
        abstract strokeWidth: width: float -> unit
        /// <summary>Set the fillColor of an element</summary>
        /// <param name="fColor">- String which determines the fill color of an object.</param>
        abstract fillColor: fColor: string -> unit
        /// <summary>Set the highlightFillColor of an element</summary>
        /// <param name="fColor">- String which determines the fill color of an object when its highlighted.</param>
        abstract highlightFillColor: fColor: string -> unit
        /// <summary>Set the dash type of an element</summary>
        /// <param name="d">- Integer which determines the way of dashing an element's outline.</param>
        abstract dash: d: float -> unit
        /// <summary>Set the visibility of an element</summary>
        /// <param name="v">- Boolean which determines whether the element is drawn.</param>
        abstract visible: v: bool -> unit
        /// <summary>Set the shadow of an element</summary>
        /// <param name="s">- Boolean which determines whether the element has a shadow or not.</param>
        abstract shadow: s: bool -> unit
        /// Snaps the element to the grid. Only works for points, lines and circles. Points will snap to the grid
        /// as defined in their properties {@link JXG.Point#snapSizeX} and {@link JXG.Point#snapSizeY}. Lines and circles
        /// will snap their parent points to the grid, if they have {@link JXG.Point#snapToGrid} set to true.
        abstract snapToGrid: unit -> JXG.GeometryElement
        /// Determines whether two-finger manipulation of this object may change its size.
        /// If set to false, the object is only rotated and translated.
        /// <p>
        /// In case the element is a horizontal or vertical line having ticks, "scalable:true"
        /// enables zooming of the board by dragging ticks lines. This feature is enabled,
        /// for the ticks element of the line element the attribute "fixed" has to be false
        /// and the line element's scalable attribute has to be true.
        /// <p>
        /// In case the element is a polygon or line and it has the attribute "scalable:false",
        /// moving the element with two fingers results in a rotation or translation.
        abstract scalable: bool with get, set

    /// The Chart class is a basic class for the chart object.
    type [<AllowNullLiteral>] ChartStatic =
        [<Emit "new $0($1...)">] abstract Create: board: obj option * parent: ResizeArray<obj option> * attributes: obj option -> Chart

    /// Legend for chart
    /// TODO
    /// 
    /// The Legend class is a basic class for legends.
    type [<AllowNullLiteral>] Legend =
        inherit JXG.GeometryElement
        /// Reference to the board associated with the element.
        abstract board: JXG.Board with get, set
        /// <summary>Highlights the element.</summary>
        /// <param name="force">- Force the highlighting</param>
        abstract highlight: ?force: bool -> JXG.Board
        /// <summary>Set the highlightStrokeColor of an element</summary>
        /// <param name="sColor">- String which determines the stroke color of an object when its highlighted.</param>
        abstract highlightStrokeColor: sColor: string -> unit
        /// <summary>Set the strokeColor of an element</summary>
        /// <param name="sColor">- String which determines the stroke color of an object.</param>
        abstract strokeColor: sColor: string -> unit
        /// <summary>Set the strokeWidth of an element</summary>
        /// <param name="width">- Integer which determines the stroke width of an outline.</param>
        abstract strokeWidth: width: float -> unit
        /// <summary>Set the fillColor of an element</summary>
        /// <param name="fColor">- String which determines the fill color of an object.</param>
        abstract fillColor: fColor: string -> unit
        /// <summary>Set the highlightFillColor of an element</summary>
        /// <param name="fColor">- String which determines the fill color of an object when its highlighted.</param>
        abstract highlightFillColor: fColor: string -> unit
        /// <summary>Set the dash type of an element</summary>
        /// <param name="d">- Integer which determines the way of dashing an element's outline.</param>
        abstract dash: d: float -> unit
        /// <summary>Set the visibility of an element</summary>
        /// <param name="v">- Boolean which determines whether the element is drawn.</param>
        abstract visible: v: bool -> unit
        /// <summary>Set the shadow of an element</summary>
        /// <param name="s">- Boolean which determines whether the element has a shadow or not.</param>
        abstract shadow: s: bool -> unit
        /// Snaps the element to the grid. Only works for points, lines and circles. Points will snap to the grid
        /// as defined in their properties {@link JXG.Point#snapSizeX} and {@link JXG.Point#snapSizeY}. Lines and circles
        /// will snap their parent points to the grid, if they have {@link JXG.Point#snapToGrid} set to true.
        abstract snapToGrid: unit -> JXG.GeometryElement
        /// Determines whether two-finger manipulation of this object may change its size.
        /// If set to false, the object is only rotated and translated.
        /// <p>
        /// In case the element is a horizontal or vertical line having ticks, "scalable:true"
        /// enables zooming of the board by dragging ticks lines. This feature is enabled,
        /// for the ticks element of the line element the attribute "fixed" has to be false
        /// and the line element's scalable attribute has to be true.
        /// <p>
        /// In case the element is a polygon or line and it has the attribute "scalable:false",
        /// moving the element with two fingers results in a rotation or translation.
        abstract scalable: bool with get, set

    /// Legend for chart
    /// TODO
    /// 
    /// The Legend class is a basic class for legends.
    type [<AllowNullLiteral>] LegendStatic =
        [<Emit "new $0($1...)">] abstract Create: board: obj option * coords: ResizeArray<obj option> * attributes: obj option -> Legend

    /// A circle consists of all points with a given distance from one point. This point is called center, the distance is called radius.
    /// A circle can be constructed by providing a center and a point on the circle or a center and a radius (given as a number, function,
    /// line, or circle).
    type [<AllowNullLiteral>] Circle =
        inherit JXG.GeometryElement
        /// Stores the given method.
        /// Can be
        /// <ul><li><b>'twoPoints'</b> which means the circle is defined by its center and a point on the circle.</li>
        /// <li><b>'pointRadius'</b> which means the circle is defined by its center and its radius given in user units or as term.</li>
        /// <li><b>'pointLine'</b> which means the circle is defined by its center and its radius given by the distance from the startpoint and the endpoint of the line.</li>
        /// <li><b>'pointCircle'</b> which means the circle is defined by its center and its radius given by the radius of another circle.</li></ul>
        abstract ``method``: string with get, set
        /// The circles center. Do not set this parameter directly as it will break JSXGraph's update system.
        abstract center: JXG.Point with get, set
        /// Point on the circle only set if method equals 'twoPoints'. Do not set this parameter directly as it will break JSXGraph's update system.
        abstract point2: JXG.Point with get, set
        /// Radius of the circle
        /// only set if method equals 'pointRadius'
        abstract radius: float with get, set
        /// Line defining the radius of the circle given by the distance from the startpoint and the endpoint of the line
        /// only set if method equals 'pointLine'. Do not set this parameter directly as it will break JSXGraph's update system.
        abstract line: JXG.Line with get, set
        /// Circle defining the radius of the circle given by the radius of the other circle
        /// only set if method equals 'pointLine'. Do not set this parameter directly as it will break JSXGraph's update system.
        abstract circle: JXG.Circle with get, set
        /// Uses the boards renderer to update the circle.
        abstract update: unit -> unit
        /// <summary>Set a new radius, then update the board.</summary>
        /// <param name="r">- A string, function or number describing the new radius.</param>
        abstract setRadius: r: U3<string, float, (ResizeArray<obj option> -> obj option)> -> JXG.Circle
        /// <summary>Calculates the radius of the circle.</summary>
        /// <param name="value">- Set new radius</param>
        abstract Radius: ?value: U3<string, float, (ResizeArray<obj option> -> obj option)> -> float
        /// Use {@link JXG.Circle#Radius}.
        abstract getRadius: unit -> unit
        /// <summary>Add transformations to this circle.</summary>
        /// <param name="transform">- Either one {@link JXG.Transformation} or an array of {@link JXG.Transformation}s.</param>
        abstract addTransform: transform: U2<JXG.Transformation, ResizeArray<obj option>> -> JXG.Circle
        /// <summary>Treats the circle as parametric curve and calculates its X coordinate.</summary>
        /// <param name="t">- Number between 0 and 1.</param>
        abstract X: t: float -> float
        /// <summary>Treats the circle as parametric curve and calculates its Y coordinate.</summary>
        /// <param name="t">- Number between 0 and 1.</param>
        abstract Y: t: float -> float
        /// <summary>Treat the circle as parametric curve and calculates its Z coordinate.</summary>
        /// <param name="t">- ignored</param>
        abstract Z: t: float -> float
        /// Circle area
        abstract Area: unit -> float
        /// Get bounding box of the circle.
        abstract bounds: unit -> ResizeArray<obj option>
        /// Get data to construct this element. Data consists of the parent elements
        /// and static data like radius.
        abstract getParents: unit -> ResizeArray<obj option>
        /// Controls if updates are necessary
        abstract needsUpdate: bool with get, set
        /// If element is in two dimensional real space this is true, else false.
        abstract isReal: bool with get, set
        /// The string used with {@link JXG.Board#create}
        abstract elType: string with get, set
        /// The methodMap determines which methods can be called from within JessieCode and under which name it
        /// can be used. The map is saved in an object, the name of a property is the name of the method used in JessieCode,
        /// the value of a property is the name of the method in JavaScript.
        abstract methodMap: obj option with get, set
        /// Quadratic form representation of circles (and conics)
        abstract quadraticform: ResizeArray<obj option> with get, set
        /// Unique identifier for the element. Equivalent to id-attribute of renderer element.
        abstract id: string with get, set
        /// Returns the coords object where a text that is bound to the element shall be drawn.
        /// Differs in some cases from the values that getLabelAnchor returns.
        abstract getTextAnchor: unit -> JXG.Coords
        /// Returns the coords object where the label of the element shall be drawn.
        /// Differs in some cases from the values that getTextAnchor returns.
        abstract getLabelAnchor: unit -> JXG.Coords
        /// <summary>Highlights the element.</summary>
        /// <param name="force">- Force the highlighting</param>
        abstract highlight: ?force: bool -> JXG.Board
        /// Copy the element to background. This is used for tracing elements.
        abstract cloneToBackground: unit -> JXG.GeometryElement
        /// <summary>Set the highlightStrokeColor of an element</summary>
        /// <param name="sColor">- String which determines the stroke color of an object when its highlighted.</param>
        abstract highlightStrokeColor: sColor: string -> unit
        /// <summary>Set the strokeColor of an element</summary>
        /// <param name="sColor">- String which determines the stroke color of an object.</param>
        abstract strokeColor: sColor: string -> unit
        /// <summary>Set the strokeWidth of an element</summary>
        /// <param name="width">- Integer which determines the stroke width of an outline.</param>
        abstract strokeWidth: width: float -> unit
        /// <summary>Set the fillColor of an element</summary>
        /// <param name="fColor">- String which determines the fill color of an object.</param>
        abstract fillColor: fColor: string -> unit
        /// <summary>Set the highlightFillColor of an element</summary>
        /// <param name="fColor">- String which determines the fill color of an object when its highlighted.</param>
        abstract highlightFillColor: fColor: string -> unit
        /// <summary>Set the dash type of an element</summary>
        /// <param name="d">- Integer which determines the way of dashing an element's outline.</param>
        abstract dash: d: float -> unit
        /// <summary>Set the visibility of an element</summary>
        /// <param name="v">- Boolean which determines whether the element is drawn.</param>
        abstract visible: v: bool -> unit
        /// <summary>Set the shadow of an element</summary>
        /// <param name="s">- Boolean which determines whether the element has a shadow or not.</param>
        abstract shadow: s: bool -> unit
        /// Snaps the element to the grid. Only works for points, lines and circles. Points will snap to the grid
        /// as defined in their properties {@link JXG.Point#snapSizeX} and {@link JXG.Point#snapSizeY}. Lines and circles
        /// will snap their parent points to the grid, if they have {@link JXG.Point#snapToGrid} set to true.
        abstract snapToGrid: unit -> JXG.GeometryElement
        /// Snaps the element to points. Only works for points. Points will snap to the next point
        /// as defined in their properties {@link JXG.Point#attractorDistance} and {@link JXG.Point#attractorUnit}.
        /// Lines and circles
        /// will snap their parent points to points.
        abstract snapToPoints: unit -> JXG.GeometryElement
        /// Determines whether two-finger manipulation of this object may change its size.
        /// If set to false, the object is only rotated and translated.
        /// <p>
        /// In case the element is a horizontal or vertical line having ticks, "scalable:true"
        /// enables zooming of the board by dragging ticks lines. This feature is enabled,
        /// for the ticks element of the line element the attribute "fixed" has to be false
        /// and the line element's scalable attribute has to be true.
        /// <p>
        /// In case the element is a polygon or line and it has the attribute "scalable:false",
        /// moving the element with two fingers results in a rotation or translation.
        abstract scalable: bool with get, set

    /// A circle consists of all points with a given distance from one point. This point is called center, the distance is called radius.
    /// A circle can be constructed by providing a center and a point on the circle or a center and a radius (given as a number, function,
    /// line, or circle).
    type [<AllowNullLiteral>] CircleStatic =
        [<Emit "new $0($1...)">] abstract Create: board: JXG.Board * ``method``: string * par1: JXG.Point * par2: U3<JXG.Point, JXG.Line, JXG.Circle> * attributes: obj option -> Circle

    /// A composition is a simple container that manages none or more {@link JXG.GeometryElement}s.
    type [<AllowNullLiteral>] Composition =
        /// Invokes setAttribute for every stored element with a setAttribute method and hands over the given arguments.
        /// See {@link JXG.GeometryElement#setAttribute} for further description, valid parameters and return values.
        abstract setAttribute: unit -> unit
        /// Invokes setParents for every stored element with a setParents method and hands over the given arguments.
        /// See {@link JXG.GeometryElement#setParents} for further description, valid parameters and return values.
        abstract setParents: unit -> unit
        /// Invokes prepareUpdate for every stored element with a prepareUpdate method and hands over the given arguments.
        /// See {@link JXG.GeometryElement#prepareUpdate} for further description, valid parameters and return values.
        abstract prepareUpdate: unit -> unit
        /// Invokes updateRenderer for every stored element with a updateRenderer method and hands over the given arguments.
        /// See {@link JXG.GeometryElement#updateRenderer} for further description, valid parameters and return values.
        abstract updateRenderer: unit -> unit
        /// Invokes update for every stored element with a update method and hands over the given arguments.
        /// See {@link JXG.GeometryElement#update} for further description, valid parameters and return values.
        abstract update: unit -> unit
        /// Invokes fullUpdate for every stored element with a fullUpdate method and hands over the given arguments.
        /// See {@link JXG.GeometryElement#fullUpdate} for further description, valid parameters and return values.
        abstract fullUpdate: unit -> unit
        /// Invokes highlight for every stored element with a highlight method and hands over the given arguments.
        /// See {@link JXG.GeometryElement#highlight} for further description, valid parameters and return values.
        abstract highlight: unit -> unit
        /// Invokes noHighlight for every stored element with a noHighlight method and hands over the given arguments.
        /// See {@link JXG.GeometryElement#noHighlight} for further description, valid parameters and return values.
        abstract noHighlight: unit -> unit
        /// <summary>Adds an element to the composition container.</summary>
        /// <param name="what">- Descriptive name for the element, e.g. <em>startpoint</em> or <em>area</em>. This is used to
        /// access the element later on. There are some reserved names: <em>elements, add, remove, update, prepareUpdate,
        /// updateRenderer, highlight, noHighlight</em>, and all names that would form invalid object property names in
        /// JavaScript.</param>
        /// <param name="element">- A reference to the element that is to be added. This can be
        /// another composition, too.</param>
        abstract add: what: string * element: U2<JXG.GeometryElement, JXG.Composition> -> bool
        /// <summary>Remove an element from the composition container.</summary>
        /// <param name="what">- The name used to access the element.</param>
        abstract remove: what: string -> bool

    /// A composition is a simple container that manages none or more {@link JXG.GeometryElement}s.
    type [<AllowNullLiteral>] CompositionStatic =
        [<Emit "new $0($1...)">] abstract Create: elements: obj option -> Composition

    /// Constructs a new Coordinates object.
    type [<AllowNullLiteral>] Coords =
        /// Stores the board the object is used on.
        abstract board: JXG.Board with get, set
        /// Stores coordinates for user view as homogeneous coordinates.
        abstract usrCoords: ResizeArray<obj option> with get, set
        /// Stores coordinates for screen view as homogeneous coordinates.
        abstract scrCoords: ResizeArray<obj option> with get, set
        /// If true, this coordinates object will emit update events every time
        /// the coordinates are set.
        abstract emitter: bool with get, set
        /// <summary>Calculate distance of one point to another.</summary>
        /// <param name="coord_type">- The type of coordinates used here. Possible values are <b>JXG.COORDS_BY_USER</b> and <b>JXG.COORDS_BY_SCREEN</b>.</param>
        /// <param name="coordinates">- The Coords object to which the distance is calculated.</param>
        abstract distance: coord_type: float * coordinates: JXG.Coords -> float
        /// <summary>Set coordinates by either user coordinates or screen coordinates and recalculate the other one.</summary>
        /// <param name="coord_type">- The type of coordinates used here. Possible values are <b>COORDS_BY_USER</b> and <b>COORDS_BY_SCREEN</b>.</param>
        /// <param name="coordinates">- An array of affine coordinates the Coords object is set to.</param>
        /// <param name="doRound">- flag If true or null round the coordinates in usr2screen. This is used in smooth curve plotting.
        /// The IE needs rounded coordinates. Id doRound==false we have to round in updatePathString.</param>
        abstract setCoordinates: coord_type: float * coordinates: ResizeArray<obj option> * ?doRound: bool * ?noevent: bool -> JXG.Coords
        /// Test if one of the usrCoords is NaN or the coordinates are infinite.
        abstract isReal: unit -> bool

    /// Constructs a new Coordinates object.
    type [<AllowNullLiteral>] CoordsStatic =
        [<Emit "new $0($1...)">] abstract Create: ``method``: float * coordinates: ResizeArray<obj option> * board: JXG.Board -> Coords

    /// Curves are the common object for function graphs, parametric curves, polar curves, and data plots.
    type [<AllowNullLiteral>] Curve =
        inherit JXG.GeometryElement
        /// Number of points on curves. This value changes
        /// between numberPointsLow and numberPointsHigh.
        /// It is set in {@link JXG.Curve#updateCurve}.
        abstract numberPoints: obj option with get, set
        /// Array holding the x-coordinates of a data plot.
        /// This array can be updated during run time by overwriting
        /// the method {@link JXG.Curve#updateDataArray}.
        abstract dataX: ResizeArray<obj option> with get, set
        /// Array holding the y-coordinates of a data plot.
        /// This array can be updated during run time by overwriting
        /// the method {@link JXG.Curve#updateDataArray}.
        abstract dataY: ResizeArray<obj option> with get, set
        /// Stores a quad tree if it is required. The quad tree is generated in the curve
        /// updates and can be used to speed up the hasPoint method.
        abstract qdt: JXG.Math.Quadtree with get, set
        /// Gives the default value of the left bound for the curve.
        /// May be overwritten in {@link JXG.Curve#generateTerm}.
        abstract minX: unit -> float
        /// Gives the default value of the right bound for the curve.
        /// May be overwritten in {@link JXG.Curve#generateTerm}.
        abstract maxX: unit -> float
        /// <summary>The parametric function which defines the x-coordinate of the curve.</summary>
        /// <param name="t">- A number between {@link JXG.Curve#minX} and {@link JXG.Curve#maxX}.</param>
        /// <param name="suspendUpdate">- A boolean flag which is false for the
        /// first call of the function during a fresh plot of the curve and true
        /// for all subsequent calls of the function. This may be used to speed up the
        /// plotting of the curve, if the e.g. the curve depends on some input elements.</param>
        abstract X: t: float * suspendUpdate: bool -> float
        /// <summary>The parametric function which defines the y-coordinate of the curve.</summary>
        /// <param name="t">- A number between {@link JXG.Curve#minX} and {@link JXG.Curve#maxX}.</param>
        /// <param name="suspendUpdate">- A boolean flag which is false for the
        /// first call of the function during a fresh plot of the curve and true
        /// for all subsequent calls of the function. This may be used to speed up the
        /// plotting of the curve, if the e.g. the curve depends on some input elements.</param>
        abstract Y: t: float * suspendUpdate: bool -> float
        /// <summary>Treat the curve as curve with homogeneous coordinates.</summary>
        /// <param name="t">- A number between {@link JXG.Curve#minX} and {@link JXG.Curve#maxX}.</param>
        abstract Z: t: float -> float
        /// <summary>Checks whether (x,y) is near the curve.</summary>
        /// <param name="x">- Coordinate in x direction, screen coordinates.</param>
        /// <param name="y">- Coordinate in y direction, screen coordinates.</param>
        /// <param name="start">- Optional start index for search on data plots.</param>
        abstract hasPoint: x: float * y: float * start: float -> bool
        /// Allocate points in the Coords array this.points
        abstract allocatePoints: unit -> unit
        /// Computes for equidistant points on the x-axis the values of the function
        abstract update: unit -> JXG.Curve
        /// Updates the visual contents of the curve.
        abstract updateRenderer: unit -> JXG.Curve
        /// For dynamic dataplots updateCurve can be used to compute new entries
        /// for the arrays {@link JXG.Curve#dataX} and {@link JXG.Curve#dataY}. It
        /// is used in {@link JXG.Curve#updateCurve}. Default is an empty method, can
        /// be overwritten by the user.
        abstract updateDataArray: unit -> unit
        /// Computes for equidistant points on the x-axis the values
        /// of the function.
        /// If the mousemove event triggers this update, we use only few
        /// points. Otherwise, e.g. on mouseup, many points are used.
        abstract updateCurve: unit -> JXG.Curve
        /// Check if at least one point on the curve is finite and real.
        abstract checkReal: unit -> unit
        /// <summary>Updates the data points of a parametric curve. This version is used if {@link JXG.Curve#doadvancedplot} is <tt>false</tt>.</summary>
        /// <param name="mi">- Left bound of curve</param>
        /// <param name="ma">- Right bound of curve</param>
        /// <param name="len">- Number of data points</param>
        abstract updateParametricCurveNaive: mi: float * ma: float * len: float -> JXG.Curve
        /// <summary>Updates the data points of a parametric curve. This version is used if {@link JXG.Curve#doadvancedplot} is <tt>true</tt>.
        /// Since 0.99 this algorithm is deprecated. It still can be used if {@link JXG.Curve#doadvancedplotold} is <tt>true</tt>.</summary>
        /// <param name="mi">- Left bound of curve</param>
        /// <param name="ma">- Right bound of curve</param>
        abstract updateParametricCurveOld: mi: float * ma: float -> JXG.Curve
        /// <summary>Updates the data points of a parametric curve. This version is used if {@link JXG.Curve#doadvancedplot} is <tt>true</tt>.</summary>
        /// <param name="mi">- Left bound of curve</param>
        /// <param name="ma">- Right bound of curve</param>
        abstract updateParametricCurve: mi: float * ma: float -> JXG.Curve
        /// Applies the transformations of the curve to the given point <tt>p</tt>.
        /// Before using it, {@link JXG.Curve#updateTransformMatrix} has to be called.
        abstract updateTransform: p: JXG.Point -> JXG.Point
        /// <summary>Add transformations to this curve.</summary>
        /// <param name="transform">- Either one {@link JXG.Transformation} or an array of {@link JXG.Transformation}s.</param>
        abstract addTransform: transform: U2<JXG.Transformation, ResizeArray<obj option>> -> JXG.Curve
        /// Converts the JavaScript/JessieCode/GEONExT syntax of the defining function term into JavaScript.
        /// New methods X() and Y() for the Curve object are generated, further
        /// new methods for minX() and maxX().
        abstract generateTerm: unit -> unit
        /// <summary>Finds dependencies in a given term and notifies the parents by adding the
        /// dependent object to the found objects child elements.</summary>
        /// <param name="contentStr">- String containing dependencies for the given object.</param>
        abstract notifyParents: contentStr: string -> unit
        /// <summary>Shift the curve by the vector 'where'.</summary>
        /// <param name="where">- Array containing the x and y coordinate of the target location.</param>
        abstract moveTo: where: ResizeArray<obj option> -> JXG.Curve
        /// Controls if updates are necessary
        abstract needsUpdate: bool with get, set
        /// Controls if this element can be dragged. In GEONExT only
        /// free points and gliders can be dragged.
        abstract isDraggable: bool with get, set
        /// If element is in two dimensional real space this is true, else false.
        abstract isReal: bool with get, set
        /// The string used with {@link JXG.Board#create}
        abstract elType: string with get, set
        /// The methodMap determines which methods can be called from within JessieCode and under which name it
        /// can be used. The map is saved in an object, the name of a property is the name of the method used in JessieCode,
        /// the value of a property is the name of the method in JavaScript.
        abstract methodMap: obj option with get, set
        /// Unique identifier for the element. Equivalent to id-attribute of renderer element.
        abstract id: string with get, set
        /// Returns the coords object where the label of the element shall be drawn.
        /// Differs in some cases from the values that getTextAnchor returns.
        abstract getLabelAnchor: unit -> JXG.Coords
        /// <summary>Highlights the element.</summary>
        /// <param name="force">- Force the highlighting</param>
        abstract highlight: ?force: bool -> JXG.Board
        /// Copy the element to background. This is used for tracing elements.
        abstract cloneToBackground: unit -> JXG.GeometryElement
        /// Dimensions of the smallest rectangle enclosing the element.
        abstract bounds: unit -> ResizeArray<obj option>
        /// <summary>Set the highlightStrokeColor of an element</summary>
        /// <param name="sColor">- String which determines the stroke color of an object when its highlighted.</param>
        abstract highlightStrokeColor: sColor: string -> unit
        /// <summary>Set the strokeColor of an element</summary>
        /// <param name="sColor">- String which determines the stroke color of an object.</param>
        abstract strokeColor: sColor: string -> unit
        /// <summary>Set the strokeWidth of an element</summary>
        /// <param name="width">- Integer which determines the stroke width of an outline.</param>
        abstract strokeWidth: width: float -> unit
        /// <summary>Set the fillColor of an element</summary>
        /// <param name="fColor">- String which determines the fill color of an object.</param>
        abstract fillColor: fColor: string -> unit
        /// <summary>Set the highlightFillColor of an element</summary>
        /// <param name="fColor">- String which determines the fill color of an object when its highlighted.</param>
        abstract highlightFillColor: fColor: string -> unit
        /// <summary>Set the dash type of an element</summary>
        /// <param name="d">- Integer which determines the way of dashing an element's outline.</param>
        abstract dash: d: float -> unit
        /// <summary>Set the visibility of an element</summary>
        /// <param name="v">- Boolean which determines whether the element is drawn.</param>
        abstract visible: v: bool -> unit
        /// <summary>Set the shadow of an element</summary>
        /// <param name="s">- Boolean which determines whether the element has a shadow or not.</param>
        abstract shadow: s: bool -> unit
        /// List of the element ids resp. values used as parents in {@link JXG.Board#create}.
        abstract getParents: unit -> ResizeArray<obj option>
        /// Snaps the element to the grid. Only works for points, lines and circles. Points will snap to the grid
        /// as defined in their properties {@link JXG.Point#snapSizeX} and {@link JXG.Point#snapSizeY}. Lines and circles
        /// will snap their parent points to the grid, if they have {@link JXG.Point#snapToGrid} set to true.
        abstract snapToGrid: unit -> JXG.GeometryElement
        /// Determines whether two-finger manipulation of this object may change its size.
        /// If set to false, the object is only rotated and translated.
        /// <p>
        /// In case the element is a horizontal or vertical line having ticks, "scalable:true"
        /// enables zooming of the board by dragging ticks lines. This feature is enabled,
        /// for the ticks element of the line element the attribute "fixed" has to be false
        /// and the line element's scalable attribute has to be true.
        /// <p>
        /// In case the element is a polygon or line and it has the attribute "scalable:false",
        /// moving the element with two fingers results in a rotation or translation.
        abstract scalable: bool with get, set

    /// Curves are the common object for function graphs, parametric curves, polar curves, and data plots.
    type [<AllowNullLiteral>] CurveStatic =
        [<Emit "new $0($1...)">] abstract Create: board: U2<string, JXG.Board> * parents: ResizeArray<obj option> * attributes: obj option -> Curve

    /// Constructs a new GeometryElement object.
    type [<AllowNullLiteral>] GeometryElement =
        /// Controls if updates are necessary
        abstract needsUpdate: bool with get, set
        /// Controls if this element can be dragged. In GEONExT only
        /// free points and gliders can be dragged.
        abstract isDraggable: bool with get, set
        /// If element is in two dimensional real space this is true, else false.
        abstract isReal: bool with get, set
        /// Stores all dependent objects to be updated when this point is moved.
        abstract childElements: obj option with get, set
        /// If element has a label subelement then this property will be set to true.
        abstract hasLabel: bool with get, set
        /// True, if the element is currently highlighted.
        abstract highlighted: bool with get, set
        /// Stores all Intersection Objects which in this moment are not real and
        /// so hide this element.
        abstract notExistingParents: obj option with get, set
        /// Keeps track of all objects drawn as part of the trace of the element.
        abstract traces: obj option with get, set
        /// Counts the number of objects drawn as part of the trace of the element.
        abstract numTraces: float with get, set
        /// Stores the  transformations which are applied during update in an array
        abstract transformations: ResizeArray<obj option> with get, set
        /// Elements depending on this element are stored here.
        abstract descendants: obj option with get, set
        /// Elements on which this element depends on are stored here.
        abstract ancestors: obj option with get, set
        /// Ids of elements on which this element depends directly are stored here.
        abstract parents: obj option with get, set
        /// Stores variables for symbolic computations
        abstract symbolic: obj option with get, set
        /// Stores the SVG (or VML) rendering node for the element. This enables low-level
        /// access to SVG nodes. The properties of such an SVG node can then be changed
        /// by calling setAttribute(). Note that there are a few elements which consist
        /// of more than one SVG nodes:
        /// <ul>
        /// <li> Elements with arrow tail or head: rendNodeTriangleStart, rendNodeTriangleEnd
        /// <li> SVG (or VML) texts: rendNodeText
        /// <li> Button: rendNodeForm, rendNodeButton, rendNodeTag
        /// <li> Checkbox: rendNodeForm, rendNodeCheckbox, rendNodeLabel, rendNodeTag
        /// <li> Input: rendNodeForm, rendNodeInput, rendNodeLabel, rendNodeTag
        /// </ul>
        /// 
        /// Here is are two examples: The first example shows how to access the SVG node,
        /// the second example demonstrates how to change SVG attributes.
        abstract rendNode: obj option with get, set
        /// The string used with {@link JXG.Board#create}
        abstract elType: string with get, set
        /// The element is saved with an explicit entry in the file (<tt>true</tt>) or implicitly
        /// via a composition.
        abstract dump: bool with get, set
        /// Subs contains the subelements, created during the create method.
        abstract subs: obj option with get, set
        /// Inherits contains the subelements, which may have an attribute
        /// (in partuclar the attribute "visible") having value 'inherit'.
        abstract inherits: obj option with get, set
        /// [c,b0,b1,a,k,r,q0,q1]
        /// 
        /// See
        /// A.E. Middleditch, T.W. Stacey, and S.B. Tor:
        /// "Intersection Algorithms for Lines and Circles",
        /// ACM Transactions on Graphics, Vol. 8, 1, 1989, pp 25-40.
        /// 
        /// The meaning of the parameters is:
        /// Circle: points p=[p0,p1] on the circle fulfill
        /// a&lt;p,p&gt; + &lt;b,p&gt; + c = 0
        /// For convenience we also store
        /// r: radius
        /// k: discriminant = sqrt(&lt;b,b&gt;-4ac)
        /// q=[q0,q1] center
        /// 
        /// Points have radius = 0.
        /// Lines have radius = infinity.
        /// b: normalized vector, representing the direction of the line.
        /// 
        /// Should be put into Coords, when all elements possess Coords.
        abstract stdform: ResizeArray<obj option> with get, set
        /// The methodMap determines which methods can be called from within JessieCode and under which name it
        /// can be used. The map is saved in an object, the name of a property is the name of the method used in JessieCode,
        /// the value of a property is the name of the method in JavaScript.
        abstract methodMap: obj option with get, set
        /// Quadratic form representation of circles (and conics)
        abstract quadraticform: ResizeArray<obj option> with get, set
        /// An associative array containing all visual properties.
        abstract visProp: obj option with get, set
        /// An associative array containing visual properties which are calculated from
        /// the attribute values (i.e. visProp) and from other constraints.
        /// An example: if an intersection point does not have real coordinates,
        /// visPropCalc.visible is set to false.
        /// Additionally, the user can control visibility with the attribute "visible",
        /// even by supplying a functions as value.
        abstract visPropCalc: obj option with get, set
        /// Is the mouse over this element?
        abstract mouseover: bool with get, set
        /// Time stamp containing the last time this element has been dragged.
        abstract lastDragTime: DateTime with get, set
        /// Reference to the board associated with the element.
        abstract board: JXG.Board with get, set
        /// Type of the element.
        abstract ``type``: float
        /// Original type of the element at construction time. Used for removing glider property.
        abstract _org_type: float
        /// The element's class.
        abstract elementClass: float
        /// Unique identifier for the element. Equivalent to id-attribute of renderer element.
        abstract id: string with get, set
        /// Not necessarily unique name for the element.
        abstract name: string with get, set
        /// <summary>Add an element as a child to the current element. Can be used to model dependencies between geometry elements.</summary>
        /// <param name="obj">- The dependent object.</param>
        abstract addChild: obj: JXG.GeometryElement -> unit
        /// <summary>Adds ids of elements to the array this.parents. This method needs to be called if some dependencies
        /// can not be detected automatically by JSXGraph. For example if a function graph is given by a function
        /// which referes to coordinates of a point, calling addParents() is necessary.</summary>
        /// <param name="parents">- Array of elements or ids of elements.
        /// Alternatively, one can give a list of objects as parameters.</param>
        abstract addParents: parents: ResizeArray<obj option> -> JXG.Object
        /// <summary>Sets ids of elements to the array this.parents.
        /// First, this.parents is cleared. See {@link JXG.GeometryElement#addParents}.</summary>
        /// <param name="parents">- Array of elements or ids of elements.
        /// Alternatively, one can give a list of objects as parameters.</param>
        abstract setParents: parents: ResizeArray<obj option> -> JXG.Object
        /// <summary>Remove an element as a child from the current element.</summary>
        /// <param name="obj">- The dependent object.</param>
        abstract removeChild: obj: JXG.GeometryElement -> unit
        /// Returns the elements name, Used in JessieCode.
        abstract getName: unit -> string
        /// <summary>Add transformations to this element.</summary>
        /// <param name="transform">- Either one {@link JXG.Transformation}
        /// or an array of {@link JXG.Transformation}s.</param>
        abstract addTransform: transform: U2<JXG.Transformation, ResizeArray<obj option>> -> JXG.GeometryElement
        /// <summary>Translates the object by <tt>(x, y)</tt>. In case the element is defined by points, the defining points are
        /// translated, e.g. a circle constructed by a center point and a point on the circle line.</summary>
        /// <param name="method">- The type of coordinates used here.
        /// Possible values are {@link JXG.COORDS_BY_USER} and {@link JXG.COORDS_BY_SCREEN}.</param>
        /// <param name="coords">- array of translation vector.</param>
        abstract setPosition: ``method``: float * coords: ResizeArray<obj option> -> JXG.GeometryElement
        /// <summary>Moves an element by the difference of two coordinates.</summary>
        /// <param name="method">- The type of coordinates used here.
        /// Possible values are {@link JXG.COORDS_BY_USER} and {@link JXG.COORDS_BY_SCREEN}.</param>
        /// <param name="coords">- coordinates in screen/user units</param>
        /// <param name="oldcoords">- previous coordinates in screen/user units</param>
        abstract setPositionDirectly: ``method``: float * coords: ResizeArray<obj option> * oldcoords: ResizeArray<obj option> -> JXG.GeometryElement
        /// Array of strings containing the polynomials defining the element.
        /// Used for determining geometric loci the groebner way.
        abstract generatePolynomial: unit -> ResizeArray<obj option>
        /// <summary>Animates properties for that object like stroke or fill color, opacity and maybe
        /// even more later.</summary>
        /// <param name="hash">- Object containing properties with target values for the animation.</param>
        /// <param name="time">- Number of milliseconds to complete the animation.</param>
        /// <param name="options">- Optional settings for the animation:<ul><li>callback: A function that is called as soon as the animation is finished.</li></ul></param>
        abstract animate: hash: obj option * time: float * ?options: obj -> JXG.GeometryElement
        /// General update method. Should be overwritten by the element itself.
        /// Can be used sometimes to commit changes to the object.
        abstract update: unit -> JXG.GeometryElement
        /// Resolves property shortcuts like <tt>color</tt> and expands them, e.g. <tt>strokeColor</tt> and <tt>fillColor</tt>.
        /// Writes the expanded properties back to the given <tt>properties</tt>.
        abstract resolveShortcuts: properties: obj option -> obj option
        /// Sets a label and its text
        /// If label doesn't exist, it creates one
        abstract setLabel: str: string -> unit
        /// Updates the element's label text, strips all html.
        abstract setLabelText: str: string -> unit
        /// Updates the element's label text and the element's attribute "name", strips all html.
        abstract setName: str: string -> unit
        /// Deprecated alias for {@link JXG.GeometryElement#setAttribute}.
        abstract setProperty: unit -> unit
        /// <summary>Sets an arbitrary number of attributes. This method has one or more
        /// parameters of the following types:
        /// <ul>
        /// <li> object: {key1:value1,key2:value2,...}
        /// <li> string: "key1:value"
        /// <li> array: [key, value]
        /// </ul></summary>
        /// <param name="attributes">- An object with attributes.</param>
        abstract setAttribute: attributes: obj option -> JXG.GeometryElement
        /// Deprecated alias for {@link JXG.GeometryElement#getAttribute}.
        abstract getProperty: unit -> unit
        /// <summary>Get the value of the property <tt>key</tt>.</summary>
        /// <param name="key">- The name of the property you are looking for</param>
        abstract getAttribute: key: string -> obj option
        /// Removes the element from the construction.  This only removes the SVG or VML node of the element and its label (if available) from
        /// the renderer, to remove the element completely you should use {@link JXG.Board#removeObject}.
        abstract remove: unit -> unit
        /// Returns the coords object where a text that is bound to the element shall be drawn.
        /// Differs in some cases from the values that getLabelAnchor returns.
        abstract getTextAnchor: unit -> JXG.Coords
        /// Returns the coords object where the label of the element shall be drawn.
        /// Differs in some cases from the values that getTextAnchor returns.
        abstract getLabelAnchor: unit -> JXG.Coords
        /// <summary>Determines whether the element has arrows at start or end of the arc.
        /// If it is set to be a "typical" vector, ie lastArrow == true,
        /// then the element.type is set to VECTOR.</summary>
        /// <param name="firstArrow">- True if there is an arrow at the start of the arc, false otherwise.</param>
        /// <param name="lastArrow">- True if there is an arrow at the end of the arc, false otherwise.</param>
        abstract setArrow: firstArrow: bool * lastArrow: bool -> unit
        /// Creates a label element for this geometry element.
        abstract createLabel: unit -> unit
        /// <summary>Highlights the element.</summary>
        /// <param name="force">- Force the highlighting</param>
        abstract highlight: ?force: bool -> JXG.Board
        /// Uses the "normal" properties of the element.
        abstract noHighlight: unit -> JXG.Board
        /// Removes all objects generated by the trace function.
        abstract clearTrace: unit -> unit
        /// Copy the element to background. This is used for tracing elements.
        abstract cloneToBackground: unit -> JXG.GeometryElement
        /// Dimensions of the smallest rectangle enclosing the element.
        abstract bounds: unit -> ResizeArray<obj option>
        /// <summary>Rotate texts or images by a given degree. Works only for texts where JXG.Text#display equal to "internal".</summary>
        /// <param name="angle">- The degree of the rotation (90 means vertical text).</param>
        abstract addRotation: angle: float -> unit
        /// <summary>Set the highlightStrokeColor of an element</summary>
        /// <param name="sColor">- String which determines the stroke color of an object when its highlighted.</param>
        abstract highlightStrokeColor: sColor: string -> unit
        /// <summary>Set the strokeColor of an element</summary>
        /// <param name="sColor">- String which determines the stroke color of an object.</param>
        abstract strokeColor: sColor: string -> unit
        /// <summary>Set the strokeWidth of an element</summary>
        /// <param name="width">- Integer which determines the stroke width of an outline.</param>
        abstract strokeWidth: width: float -> unit
        /// <summary>Set the fillColor of an element</summary>
        /// <param name="fColor">- String which determines the fill color of an object.</param>
        abstract fillColor: fColor: string -> unit
        /// <summary>Set the highlightFillColor of an element</summary>
        /// <param name="fColor">- String which determines the fill color of an object when its highlighted.</param>
        abstract highlightFillColor: fColor: string -> unit
        /// <summary>Set the labelColor of an element</summary>
        /// <param name="lColor">- String which determines the text color of an object's label.</param>
        abstract labelColor: lColor: string -> unit
        /// <summary>Set the dash type of an element</summary>
        /// <param name="d">- Integer which determines the way of dashing an element's outline.</param>
        abstract dash: d: float -> unit
        /// <summary>Set the visibility of an element</summary>
        /// <param name="v">- Boolean which determines whether the element is drawn.</param>
        abstract visible: v: bool -> unit
        /// <summary>Set the shadow of an element</summary>
        /// <param name="s">- Boolean which determines whether the element has a shadow or not.</param>
        abstract shadow: s: bool -> unit
        /// The type of the element as used in {@link JXG.Board#create}.
        abstract getType: unit -> string
        /// List of the element ids resp. values used as parents in {@link JXG.Board#create}.
        abstract getParents: unit -> ResizeArray<obj option>
        /// Snaps the element to the grid. Only works for points, lines and circles. Points will snap to the grid
        /// as defined in their properties {@link JXG.Point#snapSizeX} and {@link JXG.Point#snapSizeY}. Lines and circles
        /// will snap their parent points to the grid, if they have {@link JXG.Point#snapToGrid} set to true.
        abstract snapToGrid: unit -> JXG.GeometryElement
        /// Snaps the element to points. Only works for points. Points will snap to the next point
        /// as defined in their properties {@link JXG.Point#attractorDistance} and {@link JXG.Point#attractorUnit}.
        /// Lines and circles
        /// will snap their parent points to points.
        abstract snapToPoints: unit -> JXG.GeometryElement
        /// Retrieve a copy of the current visProp.
        abstract getAttributes: unit -> obj option
        /// <summary>Checks whether (x,y) is near the element.</summary>
        /// <param name="x">- Coordinate in x direction, screen coordinates.</param>
        /// <param name="y">- Coordinate in y direction, screen coordinates.</param>
        abstract hasPoint: x: float * y: float -> bool
        /// <summary>Move an element to its nearest grid point.
        /// The function uses the coords object of the element as
        /// its actual position. If there is no coords object, nothing is done.</summary>
        /// <param name="force">- force snapping independent from what the snaptogrid attribute says</param>
        /// <param name="fromParent">- True if the drag comes from a child element. This is the case if a line
        /// through two points is dragged. In this case we do not try to force the points to stay inside of
        /// the visible board, but the distance between the two points stays constant.</param>
        abstract handleSnapToGrid: force: bool * fromParent: bool -> JXG.GeometryElement
        /// Opacity for element's stroke color.
        abstract strokeOpacity: float with get, set
        /// Opacity for stroke color when the object is highlighted.
        abstract highlightStrokeOpacity: float with get, set
        /// Opacity for fill color.
        abstract fillOpacity: float with get, set
        /// Opacity for fill color when the object is highlighted.
        abstract highlightFillOpacity: float with get, set
        /// Transition duration (in milliseconds) for color and opacity
        /// changes. Works in SVG renderer, only.
        abstract transitionDuration: float with get, set
        /// Width of the element's stroke when the mouse is pointed over it.
        abstract highlightStrokeWidth: float with get, set
        /// If true the element is fixed and can not be dragged around. The element
        /// will be repositioned on zoom and moveOrigin events.
        abstract ``fixed``: bool with get, set
        /// If true the element is fixed and can not be dragged around. The element
        /// will even stay at its position on zoom and moveOrigin events.
        /// Only free elements like points, texts, curves can be frozen.
        abstract frozen: bool with get, set
        /// If true a label will display the element's name.
        abstract withLabel: bool with get, set
        /// If true the element will be traced, i.e. on every movement the element will be copied
        /// to the background. Use {@link JXG.GeometryElement#clearTrace} to delete the trace elements.
        /// 
        /// The calling of element.setAttribute({trace:false}) additionally
        /// deletes all traces of this element. By calling
        /// element.setAttribute({trace:'pause'})
        /// the removal of already existing traces can be prevented.
        abstract trace: U2<bool, string> with get, set
        /// Extra visual properties for traces of an element
        abstract traceAttributes: obj option with get, set
        /// If this is set to true, the element is updated in every update
        /// call of the board. If set to false, the element is updated only after
        /// zoom events or more generally, when the bounding box has been changed.
        /// Examples for the latter behaviour should be axes.
        abstract needsRegularUpdate: bool with get, set
        /// Determines whether two-finger manipulation of this object may change its size.
        /// If set to false, the object is only rotated and translated.
        /// <p>
        /// In case the element is a horizontal or vertical line having ticks, "scalable:true"
        /// enables zooming of the board by dragging ticks lines. This feature is enabled,
        /// for the ticks element of the line element the attribute "fixed" has to be false
        /// and the line element's scalable attribute has to be true.
        /// <p>
        /// In case the element is a polygon or line and it has the attribute "scalable:false",
        /// moving the element with two fingers results in a rotation or translation.
        /// Determines whether two-finger manipulation of this object may change its size.
        /// If set to false, the object is only rotated and translated.
        /// <p>
        /// In case the element is a horizontal or vertical line having ticks, "scalable:true"
        /// enables zooming of the board by dragging ticks lines. This feature is enabled,
        /// for the ticks element of the line element the attribute "fixed" has to be false
        /// and the line element's scalable attribute has to be true.
        /// <p>
        /// In case the element is a polygon or line and it has the attribute "scalable:false",
        /// moving the element with two fingers results in a rotation or translation.
        abstract scalable: bool with get, set
        /// Determines whether two-finger manipulation of this object may change its size.
        /// If set to false, the object is only rotated and translated.
        /// <p>
        /// In case the element is a horizontal or vertical line having ticks, "scalable:true"
        /// enables zooming of the board by dragging ticks lines. This feature is enabled,
        /// for the ticks element of the line element the attribute "fixed" has to be false
        /// and the line element's scalable attribute has to be true.
        /// <p>
        /// In case the element is a polygon or line and it has the attribute "scalable:false",
        /// moving the element with two fingers results in a rotation or translation.
        /// Determines whether two-finger manipulation of this object may change its size.
        /// If set to false, the object is only rotated and translated.
        /// <p>
        /// In case the element is a horizontal or vertical line having ticks, "scalable:true"
        /// enables zooming of the board by dragging ticks lines. This feature is enabled,
        /// for the ticks element of the line element the attribute "fixed" has to be false
        /// and the line element's scalable attribute has to be true.
        /// <p>
        /// In case the element is a polygon or line and it has the attribute "scalable:false",
        /// moving the element with two fingers results in a rotation or translation.
        abstract scalable: bool with get, set
        /// If true the element will be drawn in grey scale colors to visualize that it's only a draft.
        abstract draft: bool with get, set

    /// Constructs a new GeometryElement object.
    type [<AllowNullLiteral>] GeometryElementStatic =
        [<Emit "new $0($1...)">] abstract Create: board: JXG.Board * attributes: obj option * ``type``: float * oclass: float -> GeometryElement
        /// Alias of {@link JXG.EventEmitter.on}.
        abstract addEvent: unit -> unit
        /// Alias of {@link JXG.EventEmitter.off}.
        abstract removeEvent: unit -> unit

    /// Creates a new instance of Group.
    type [<AllowNullLiteral>] Group =
        /// Releases all elements of this group.
        abstract ungroup: unit -> JXG.Group
        /// <summary>Adds ids of elements to the array this.parents. This is a copy
        /// of {@link Element.addParents}.</summary>
        /// <param name="parents">- Array of elements or ids of elements.
        /// Alternatively, one can give a list of objects as parameters.</param>
        abstract addParents: parents: ResizeArray<obj option> -> JXG.Object
        /// <summary>Sets ids of elements to the array this.parents. This is a copy
        /// of {@link Element.setParents}
        /// First, this.parents is cleared. See {@link Group#addParents}.</summary>
        /// <param name="parents">- Array of elements or ids of elements.
        /// Alternatively, one can give a list of objects as parameters.</param>
        abstract setParents: parents: ResizeArray<obj option> -> JXG.Object
        /// List of the element ids resp. values used as parents in {@link JXG.Board#create}.
        abstract getParents: unit -> ResizeArray<obj option>
        /// <summary>Update the cached coordinates of a group element.</summary>
        /// <param name="el">- element id of the group element whose cached coordinates
        /// are going to be updated.</param>
        abstract _updateCoordsCache: el: string -> obj option
        /// Sends an update to all group members.
        /// This method is called from the points' coords object event listeners
        /// and not by the board.
        abstract update: unit -> JXG.Group
        /// <summary>Adds an Point to this group.</summary>
        /// <param name="object">- The point added to the group.</param>
        abstract addPoint: ``object``: JXG.Point -> JXG.Group
        /// <summary>Adds multiple points to this group.</summary>
        /// <param name="objects">- An array of points to add to the group.</param>
        abstract addPoints: objects: ResizeArray<obj option> -> JXG.Group
        /// <summary>Adds all points in a group to this group.</summary>
        /// <param name="group">- The group added to this group.</param>
        abstract addGroup: group: JXG.Group -> JXG.Group
        /// Removes a point from the group.
        abstract removePoint: point: JXG.Point -> JXG.Group
        /// <summary>Sets the center of rotation for the group. This is either a point or the centroid of the group.</summary>
        /// <param name="object">- A point which will be the center of rotation, the string "centroid", or
        /// an array of length two, or a function returning an array of length two.</param>
        abstract setRotationCenter: ``object``: U2<JXG.Point, string> -> JXG.Group
        /// <summary>Sets the rotation points of the group. Dragging at one of these points results into a rotation of the whole group around
        /// the rotation center of the group {@see JXG.Group#setRotationCenter}.</summary>
        /// <param name="objects">- Array of {@link JXG.Point} or arbitrary number of {@link JXG.Point} elements.</param>
        abstract setRotationPoints: objects: U2<ResizeArray<obj option>, JXG.Point> -> JXG.Group
        /// <summary>Adds a point to the set of rotation points of the group. Dragging at one of these points results into a rotation of the whole group around
        /// the rotation center of the group {@see JXG.Group#setRotationCenter}.</summary>
        /// <param name="point">- {@link JXG.Point} element.</param>
        abstract addRotationPoint: point: JXG.Point -> JXG.Group
        /// <summary>Removes the rotation property from a point of the group.</summary>
        /// <param name="point">- {@link JXG.Point} element.</param>
        abstract removeRotationPoint: point: JXG.Point -> JXG.Group
        /// <summary>Sets the translation points of the group. Dragging at one of these points results into a translation of the whole group.</summary>
        /// <param name="objects">- Array of {@link JXG.Point} or arbitrary number of {@link JXG.Point} elements.
        /// By default, all points of the group are translation points.</param>
        abstract setTranslationPoints: objects: U2<ResizeArray<obj option>, JXG.Point> -> JXG.Group
        /// <summary>Adds a point to the set of the translation points of the group.
        /// Dragging one of these points results into a translation of the whole group.</summary>
        /// <param name="point">- {@link JXG.Point} element.</param>
        abstract addTranslationPoint: point: JXG.Point -> JXG.Group
        /// <summary>Removes the translation property from a point of the group.</summary>
        /// <param name="point">- {@link JXG.Point} element.</param>
        abstract removeTranslationPoint: point: JXG.Point -> JXG.Group
        /// <summary>Sets the center of scaling for the group. This is either a point or the centroid of the group.</summary>
        /// <param name="object">- A point which will be the center of scaling, the string "centroid", or
        /// an array of length two, or a function returning an array of length two.</param>
        abstract setScaleCenter: ``object``: U2<JXG.Point, string> -> JXG.Group
        /// <summary>Sets the scale points of the group. Dragging at one of these points results into a scaling of the whole group.</summary>
        /// <param name="objects">- Array of {@link JXG.Point} or arbitrary number of {@link JXG.Point} elements.</param>
        /// <param name="direction">- Restricts the directions to be scaled. Possible values are 'x', 'y', 'xy'. Default value is 'xy'.
        /// By default, all points of the group are translation points.</param>
        abstract setScalePoints: objects: U2<ResizeArray<obj option>, JXG.Point> * direction: string -> JXG.Group
        /// <summary>Adds a point to the set of the scale points of the group. Dragging at one of these points results into a scaling of the whole group.</summary>
        /// <param name="point">- {@link JXG.Point} element.</param>
        /// <param name="direction">- Restricts the directions to be scaled. Possible values are 'x', 'y', 'xy'. Default value is 'xy'.</param>
        abstract addScalePoint: point: JXG.Point * direction: string -> JXG.Group
        /// <summary>Removes the scaling property from a point of the group.</summary>
        /// <param name="point">- {@link JXG.Point} element.</param>
        abstract removeScalePoint: point: JXG.Point -> JXG.Group
        abstract setProperty: unit -> unit

    /// Creates a new instance of Group.
    type [<AllowNullLiteral>] GroupStatic =
        [<Emit "new $0($1...)">] abstract Create: board: JXG.Board * id: string * name: string * objects: ResizeArray<obj option> * attributes: obj option -> Group

    /// Construct and handle images
    /// The coordinates can be relative to the coordinates of an element
    /// given in {@link JXG.Options#text.anchor}.
    /// 
    /// The image can be supplied as an URL or an base64 encoded inline image
    /// like "data:image/png;base64, /9j/4AAQSkZJRgA..." or a function returning
    /// an URL: function(){ return 'xxx.png; }.
    type [<AllowNullLiteral>] Image =
        inherit JXG.GeometryElement
        inherit JXG.CoordsElement
        /// Array of length two containing [width, height] of the image in pixel.
        abstract size: ResizeArray<obj option> with get, set
        /// 'href' of the image. This might be an URL, but also a data-uri is allowed.
        abstract url: string with get, set
        /// <summary>Checks whether (x,y) is over or near the image;</summary>
        /// <param name="x">- Coordinate in x direction, screen coordinates.</param>
        /// <param name="y">- Coordinate in y direction, screen coordinates.</param>
        abstract hasPoint: x: float * y: float -> bool
        /// Set the width and height of the image. After setting a new size,
        /// board.update() or image.fullUpdate()
        /// has to be called to make the change visible.
        abstract setSize: unit -> JXG.GeometryElement
        /// Returns the width of the image in user coordinates.
        abstract W: unit -> float
        /// Returns the height of the image in user coordinates.
        abstract H: unit -> float
        /// Controls if updates are necessary
        abstract needsUpdate: bool with get, set
        /// Controls if this element can be dragged. In GEONExT only
        /// free points and gliders can be dragged.
        abstract isDraggable: bool with get, set
        /// If element is in two dimensional real space this is true, else false.
        abstract isReal: bool with get, set
        /// Stores all dependent objects to be updated when this point is moved.
        abstract childElements: obj option with get, set
        /// If element has a label subelement then this property will be set to true.
        abstract hasLabel: bool with get, set
        /// True, if the element is currently highlighted.
        abstract highlighted: bool with get, set
        /// Stores all Intersection Objects which in this moment are not real and
        /// so hide this element.
        abstract notExistingParents: obj option with get, set
        /// Keeps track of all objects drawn as part of the trace of the element.
        abstract traces: obj option with get, set
        /// Counts the number of objects drawn as part of the trace of the element.
        abstract numTraces: float with get, set
        /// Stores the  transformations which are applied during update in an array
        abstract transformations: ResizeArray<obj option> with get, set
        /// Elements depending on this element are stored here.
        abstract descendants: obj option with get, set
        /// Elements on which this element depends on are stored here.
        abstract ancestors: obj option with get, set
        /// Ids of elements on which this element depends directly are stored here.
        abstract parents: obj option with get, set
        /// Stores variables for symbolic computations
        abstract symbolic: obj option with get, set
        /// Stores the SVG (or VML) rendering node for the element. This enables low-level
        /// access to SVG nodes. The properties of such an SVG node can then be changed
        /// by calling setAttribute(). Note that there are a few elements which consist
        /// of more than one SVG nodes:
        /// <ul>
        /// <li> Elements with arrow tail or head: rendNodeTriangleStart, rendNodeTriangleEnd
        /// <li> SVG (or VML) texts: rendNodeText
        /// <li> Button: rendNodeForm, rendNodeButton, rendNodeTag
        /// <li> Checkbox: rendNodeForm, rendNodeCheckbox, rendNodeLabel, rendNodeTag
        /// <li> Input: rendNodeForm, rendNodeInput, rendNodeLabel, rendNodeTag
        /// </ul>
        /// 
        /// Here is are two examples: The first example shows how to access the SVG node,
        /// the second example demonstrates how to change SVG attributes.
        abstract rendNode: obj option with get, set
        /// The string used with {@link JXG.Board#create}
        abstract elType: string with get, set
        /// The element is saved with an explicit entry in the file (<tt>true</tt>) or implicitly
        /// via a composition.
        abstract dump: bool with get, set
        /// Subs contains the subelements, created during the create method.
        abstract subs: obj option with get, set
        /// Inherits contains the subelements, which may have an attribute
        /// (in partuclar the attribute "visible") having value 'inherit'.
        abstract inherits: obj option with get, set
        /// [c,b0,b1,a,k,r,q0,q1]
        /// 
        /// See
        /// A.E. Middleditch, T.W. Stacey, and S.B. Tor:
        /// "Intersection Algorithms for Lines and Circles",
        /// ACM Transactions on Graphics, Vol. 8, 1, 1989, pp 25-40.
        /// 
        /// The meaning of the parameters is:
        /// Circle: points p=[p0,p1] on the circle fulfill
        /// a&lt;p,p&gt; + &lt;b,p&gt; + c = 0
        /// For convenience we also store
        /// r: radius
        /// k: discriminant = sqrt(&lt;b,b&gt;-4ac)
        /// q=[q0,q1] center
        /// 
        /// Points have radius = 0.
        /// Lines have radius = infinity.
        /// b: normalized vector, representing the direction of the line.
        /// 
        /// Should be put into Coords, when all elements possess Coords.
        abstract stdform: ResizeArray<obj option> with get, set
        /// The methodMap determines which methods can be called from within JessieCode and under which name it
        /// can be used. The map is saved in an object, the name of a property is the name of the method used in JessieCode,
        /// the value of a property is the name of the method in JavaScript.
        abstract methodMap: obj option with get, set
        /// Quadratic form representation of circles (and conics)
        abstract quadraticform: ResizeArray<obj option> with get, set
        /// An associative array containing all visual properties.
        abstract visProp: obj option with get, set
        /// An associative array containing visual properties which are calculated from
        /// the attribute values (i.e. visProp) and from other constraints.
        /// An example: if an intersection point does not have real coordinates,
        /// visPropCalc.visible is set to false.
        /// Additionally, the user can control visibility with the attribute "visible",
        /// even by supplying a functions as value.
        abstract visPropCalc: obj option with get, set
        /// Is the mouse over this element?
        abstract mouseover: bool with get, set
        /// Time stamp containing the last time this element has been dragged.
        abstract lastDragTime: DateTime with get, set
        /// Reference to the board associated with the element.
        abstract board: JXG.Board with get, set
        /// Type of the element.
        abstract ``type``: float
        /// Original type of the element at construction time. Used for removing glider property.
        abstract _org_type: float
        /// The element's class.
        abstract elementClass: float
        /// Unique identifier for the element. Equivalent to id-attribute of renderer element.
        abstract id: string with get, set
        /// Not necessarily unique name for the element.
        abstract name: string with get, set
        /// <summary>Add an element as a child to the current element. Can be used to model dependencies between geometry elements.</summary>
        /// <param name="obj">- The dependent object.</param>
        abstract addChild: obj: JXG.GeometryElement -> unit
        /// <summary>Adds ids of elements to the array this.parents. This method needs to be called if some dependencies
        /// can not be detected automatically by JSXGraph. For example if a function graph is given by a function
        /// which referes to coordinates of a point, calling addParents() is necessary.</summary>
        /// <param name="parents">- Array of elements or ids of elements.
        /// Alternatively, one can give a list of objects as parameters.</param>
        abstract addParents: parents: ResizeArray<obj option> -> JXG.Object
        /// <summary>Sets ids of elements to the array this.parents.
        /// First, this.parents is cleared. See {@link JXG.GeometryElement#addParents}.</summary>
        /// <param name="parents">- Array of elements or ids of elements.
        /// Alternatively, one can give a list of objects as parameters.</param>
        abstract setParents: parents: ResizeArray<obj option> -> JXG.Object
        /// <summary>Remove an element as a child from the current element.</summary>
        /// <param name="obj">- The dependent object.</param>
        abstract removeChild: obj: JXG.GeometryElement -> unit
        /// Returns the elements name, Used in JessieCode.
        abstract getName: unit -> string
        /// <summary>Add transformations to this element.</summary>
        /// <param name="transform">- Either one {@link JXG.Transformation}
        /// or an array of {@link JXG.Transformation}s.</param>
        abstract addTransform: transform: U2<JXG.Transformation, ResizeArray<obj option>> -> JXG.GeometryElement
        /// <summary>Translates the object by <tt>(x, y)</tt>. In case the element is defined by points, the defining points are
        /// translated, e.g. a circle constructed by a center point and a point on the circle line.</summary>
        /// <param name="method">- The type of coordinates used here.
        /// Possible values are {@link JXG.COORDS_BY_USER} and {@link JXG.COORDS_BY_SCREEN}.</param>
        /// <param name="coords">- array of translation vector.</param>
        abstract setPosition: ``method``: float * coords: ResizeArray<obj option> -> JXG.GeometryElement
        /// <summary>Moves an element by the difference of two coordinates.</summary>
        /// <param name="method">- The type of coordinates used here.
        /// Possible values are {@link JXG.COORDS_BY_USER} and {@link JXG.COORDS_BY_SCREEN}.</param>
        /// <param name="coords">- coordinates in screen/user units</param>
        /// <param name="oldcoords">- previous coordinates in screen/user units</param>
        abstract setPositionDirectly: ``method``: float * coords: ResizeArray<obj option> * oldcoords: ResizeArray<obj option> -> JXG.GeometryElement
        /// Array of strings containing the polynomials defining the element.
        /// Used for determining geometric loci the groebner way.
        abstract generatePolynomial: unit -> ResizeArray<obj option>
        /// <summary>Animates properties for that object like stroke or fill color, opacity and maybe
        /// even more later.</summary>
        /// <param name="hash">- Object containing properties with target values for the animation.</param>
        /// <param name="time">- Number of milliseconds to complete the animation.</param>
        /// <param name="options">- Optional settings for the animation:<ul><li>callback: A function that is called as soon as the animation is finished.</li></ul></param>
        abstract animate: hash: obj option * time: float * ?options: obj -> JXG.GeometryElement
        /// Resolves property shortcuts like <tt>color</tt> and expands them, e.g. <tt>strokeColor</tt> and <tt>fillColor</tt>.
        /// Writes the expanded properties back to the given <tt>properties</tt>.
        abstract resolveShortcuts: properties: obj option -> obj option
        /// Sets a label and its text
        /// If label doesn't exist, it creates one
        abstract setLabel: str: string -> unit
        /// Updates the element's label text, strips all html.
        abstract setLabelText: str: string -> unit
        /// Updates the element's label text and the element's attribute "name", strips all html.
        abstract setName: str: string -> unit
        /// Deprecated alias for {@link JXG.GeometryElement#setAttribute}.
        abstract setProperty: unit -> unit
        /// <summary>Sets an arbitrary number of attributes. This method has one or more
        /// parameters of the following types:
        /// <ul>
        /// <li> object: {key1:value1,key2:value2,...}
        /// <li> string: "key1:value"
        /// <li> array: [key, value]
        /// </ul></summary>
        /// <param name="attributes">- An object with attributes.</param>
        abstract setAttribute: attributes: obj option -> JXG.GeometryElement
        /// Deprecated alias for {@link JXG.GeometryElement#getAttribute}.
        abstract getProperty: unit -> unit
        /// <summary>Get the value of the property <tt>key</tt>.</summary>
        /// <param name="key">- The name of the property you are looking for</param>
        abstract getAttribute: key: string -> obj option
        /// Removes the element from the construction.  This only removes the SVG or VML node of the element and its label (if available) from
        /// the renderer, to remove the element completely you should use {@link JXG.Board#removeObject}.
        abstract remove: unit -> unit
        /// Returns the coords object where a text that is bound to the element shall be drawn.
        /// Differs in some cases from the values that getLabelAnchor returns.
        abstract getTextAnchor: unit -> JXG.Coords
        /// Returns the coords object where the label of the element shall be drawn.
        /// Differs in some cases from the values that getTextAnchor returns.
        abstract getLabelAnchor: unit -> JXG.Coords
        /// <summary>Determines whether the element has arrows at start or end of the arc.
        /// If it is set to be a "typical" vector, ie lastArrow == true,
        /// then the element.type is set to VECTOR.</summary>
        /// <param name="firstArrow">- True if there is an arrow at the start of the arc, false otherwise.</param>
        /// <param name="lastArrow">- True if there is an arrow at the end of the arc, false otherwise.</param>
        abstract setArrow: firstArrow: bool * lastArrow: bool -> unit
        /// Creates a label element for this geometry element.
        abstract createLabel: unit -> unit
        /// <summary>Highlights the element.</summary>
        /// <param name="force">- Force the highlighting</param>
        abstract highlight: ?force: bool -> JXG.Board
        /// Uses the "normal" properties of the element.
        abstract noHighlight: unit -> JXG.Board
        /// Removes all objects generated by the trace function.
        abstract clearTrace: unit -> unit
        /// Copy the element to background. This is used for tracing elements.
        abstract cloneToBackground: unit -> JXG.GeometryElement
        /// Dimensions of the smallest rectangle enclosing the element.
        abstract bounds: unit -> ResizeArray<obj option>
        /// <summary>Rotate texts or images by a given degree. Works only for texts where JXG.Text#display equal to "internal".</summary>
        /// <param name="angle">- The degree of the rotation (90 means vertical text).</param>
        abstract addRotation: angle: float -> unit
        /// <summary>Set the highlightStrokeColor of an element</summary>
        /// <param name="sColor">- String which determines the stroke color of an object when its highlighted.</param>
        abstract highlightStrokeColor: sColor: string -> unit
        /// <summary>Set the strokeColor of an element</summary>
        /// <param name="sColor">- String which determines the stroke color of an object.</param>
        abstract strokeColor: sColor: string -> unit
        /// <summary>Set the strokeWidth of an element</summary>
        /// <param name="width">- Integer which determines the stroke width of an outline.</param>
        abstract strokeWidth: width: float -> unit
        /// <summary>Set the fillColor of an element</summary>
        /// <param name="fColor">- String which determines the fill color of an object.</param>
        abstract fillColor: fColor: string -> unit
        /// <summary>Set the highlightFillColor of an element</summary>
        /// <param name="fColor">- String which determines the fill color of an object when its highlighted.</param>
        abstract highlightFillColor: fColor: string -> unit
        /// <summary>Set the labelColor of an element</summary>
        /// <param name="lColor">- String which determines the text color of an object's label.</param>
        abstract labelColor: lColor: string -> unit
        /// <summary>Set the dash type of an element</summary>
        /// <param name="d">- Integer which determines the way of dashing an element's outline.</param>
        abstract dash: d: float -> unit
        /// <summary>Set the visibility of an element</summary>
        /// <param name="v">- Boolean which determines whether the element is drawn.</param>
        abstract visible: v: bool -> unit
        /// <summary>Set the shadow of an element</summary>
        /// <param name="s">- Boolean which determines whether the element has a shadow or not.</param>
        abstract shadow: s: bool -> unit
        /// The type of the element as used in {@link JXG.Board#create}.
        abstract getType: unit -> string
        /// List of the element ids resp. values used as parents in {@link JXG.Board#create}.
        abstract getParents: unit -> ResizeArray<obj option>
        /// Snaps the element to the grid. Only works for points, lines and circles. Points will snap to the grid
        /// as defined in their properties {@link JXG.Point#snapSizeX} and {@link JXG.Point#snapSizeY}. Lines and circles
        /// will snap their parent points to the grid, if they have {@link JXG.Point#snapToGrid} set to true.
        abstract snapToGrid: unit -> JXG.GeometryElement
        /// Snaps the element to points. Only works for points. Points will snap to the next point
        /// as defined in their properties {@link JXG.Point#attractorDistance} and {@link JXG.Point#attractorUnit}.
        /// Lines and circles
        /// will snap their parent points to points.
        abstract snapToPoints: unit -> JXG.GeometryElement
        /// Retrieve a copy of the current visProp.
        abstract getAttributes: unit -> obj option
        /// <summary>Move an element to its nearest grid point.
        /// The function uses the coords object of the element as
        /// its actual position. If there is no coords object, nothing is done.</summary>
        /// <param name="force">- force snapping independent from what the snaptogrid attribute says</param>
        /// <param name="fromParent">- True if the drag comes from a child element. This is the case if a line
        /// through two points is dragged. In this case we do not try to force the points to stay inside of
        /// the visible board, but the distance between the two points stays constant.</param>
        abstract handleSnapToGrid: force: bool * fromParent: bool -> JXG.GeometryElement
        /// Opacity for element's stroke color.
        abstract strokeOpacity: float with get, set
        /// Opacity for stroke color when the object is highlighted.
        abstract highlightStrokeOpacity: float with get, set
        /// Opacity for fill color.
        abstract fillOpacity: float with get, set
        /// Opacity for fill color when the object is highlighted.
        abstract highlightFillOpacity: float with get, set
        /// Transition duration (in milliseconds) for color and opacity
        /// changes. Works in SVG renderer, only.
        abstract transitionDuration: float with get, set
        /// Width of the element's stroke when the mouse is pointed over it.
        abstract highlightStrokeWidth: float with get, set
        /// If true the element is fixed and can not be dragged around. The element
        /// will be repositioned on zoom and moveOrigin events.
        abstract ``fixed``: bool with get, set
        /// If true the element is fixed and can not be dragged around. The element
        /// will even stay at its position on zoom and moveOrigin events.
        /// Only free elements like points, texts, curves can be frozen.
        abstract frozen: bool with get, set
        /// If true a label will display the element's name.
        abstract withLabel: bool with get, set
        /// If true the element will be traced, i.e. on every movement the element will be copied
        /// to the background. Use {@link JXG.GeometryElement#clearTrace} to delete the trace elements.
        /// 
        /// The calling of element.setAttribute({trace:false}) additionally
        /// deletes all traces of this element. By calling
        /// element.setAttribute({trace:'pause'})
        /// the removal of already existing traces can be prevented.
        abstract trace: U2<bool, string> with get, set
        /// Extra visual properties for traces of an element
        abstract traceAttributes: obj option with get, set
        /// If this is set to true, the element is updated in every update
        /// call of the board. If set to false, the element is updated only after
        /// zoom events or more generally, when the bounding box has been changed.
        /// Examples for the latter behaviour should be axes.
        abstract needsRegularUpdate: bool with get, set
        /// Determines whether two-finger manipulation of this object may change its size.
        /// If set to false, the object is only rotated and translated.
        /// <p>
        /// In case the element is a horizontal or vertical line having ticks, "scalable:true"
        /// enables zooming of the board by dragging ticks lines. This feature is enabled,
        /// for the ticks element of the line element the attribute "fixed" has to be false
        /// and the line element's scalable attribute has to be true.
        /// <p>
        /// In case the element is a polygon or line and it has the attribute "scalable:false",
        /// moving the element with two fingers results in a rotation or translation.
        abstract scalable: bool with get, set
        /// If true the element will be drawn in grey scale colors to visualize that it's only a draft.
        abstract draft: bool with get, set

    /// Construct and handle images
    /// The coordinates can be relative to the coordinates of an element
    /// given in {@link JXG.Options#text.anchor}.
    /// 
    /// The image can be supplied as an URL or an base64 encoded inline image
    /// like "data:image/png;base64, /9j/4AAQSkZJRgA..." or a function returning
    /// an URL: function(){ return 'xxx.png; }.
    type [<AllowNullLiteral>] ImageStatic =
        [<Emit "new $0($1...)">] abstract Create: board: U2<string, JXG.Board> * coordinates: ResizeArray<obj option> * attributes: obj option * url: U2<string, (ResizeArray<obj option> -> obj option)> * size: ResizeArray<obj option> -> Image

    /// The Line class is a basic class for all kind of line objects, e.g. line, arrow, and axis. It is usually defined by two points and can
    /// be intersected with some other geometry elements.
    type [<AllowNullLiteral>] Line =
        inherit JXG.GeometryElement
        /// Startpoint of the line. You really should not set this field directly as it may break JSXGraph's
        /// update system so your construction won't be updated properly.
        abstract point1: JXG.Point with get, set
        /// Endpoint of the line. Just like {@link JXG.Line.point1} you shouldn't write this field directly.
        abstract point2: JXG.Point with get, set
        /// Array of ticks storing all the ticks on this line. Do not set this field directly and use
        /// {@link JXG.Line#addTicks} and {@link JXG.Line#removeTicks} to add and remove ticks to and from the line.
        abstract ticks: ResizeArray<obj option> with get, set
        /// Reference of the ticks created automatically when constructing an axis.
        abstract defaultTicks: JXG.Ticks with get, set
        /// <summary>Checks whether (x,y) is near the line.</summary>
        /// <param name="x">- Coordinate in x direction, screen coordinates.</param>
        /// <param name="y">- Coordinate in y direction, screen coordinates.</param>
        abstract hasPoint: x: float * y: float -> bool
        /// Calculates the y intersect of the line.
        abstract getRise: unit -> float
        /// Calculates the slope of the line.
        abstract getSlope: unit -> float
        /// Determines the angle between the positive x axis and the line.
        abstract getAngle: unit -> float
        /// <summary>Add transformations to this line.</summary>
        /// <param name="transform">- Either one {@link JXG.Transformation} or an array of
        /// {@link JXG.Transformation}s.</param>
        abstract addTransform: transform: U2<JXG.Transformation, ResizeArray<obj option>> -> JXG.Line
        /// <summary>Treat the line as parametric curve in homogeneous coordinates, where the parameter t runs from 0 to 1.
        /// First we transform the interval [0,1] to [-1,1].
        /// If the line has homogeneous coordinates [c,a,b] = stdform[] then the direction of the line is [b,-a].
        /// Now, we take one finite point that defines the line, i.e. we take either point1 or point2 (in case the line is not the ideal line).
        /// Let the coordinates of that point be [z, x, y].
        /// Then, the curve runs linearly from
        /// [0, b, -a] (t=-1) to [z, x, y] (t=0)
        /// and
        /// [z, x, y] (t=0) to [0, -b, a] (t=1)</summary>
        /// <param name="t">- Parameter running from 0 to 1.</param>
        abstract X: t: float -> float
        /// <summary>Treat the line as parametric curve in homogeneous coordinates.
        /// See {@link JXG.Line#X} for a detailed description.</summary>
        /// <param name="t">- Parameter running from 0 to 1.</param>
        abstract Y: t: float -> float
        /// <summary>Treat the line as parametric curve in homogeneous coordinates.
        /// See {@link JXG.Line#X} for a detailed description.</summary>
        /// <param name="t">- Parameter running from 0 to 1.</param>
        abstract Z: t: float -> float
        /// The distance between the two points defining the line.
        abstract L: unit -> float
        /// <summary>Adds ticks to this line. Ticks can be added to any kind of line: line, arrow, and axis.</summary>
        /// <param name="ticks">- Reference to a ticks object which is describing the ticks (color, distance, how many, etc.).</param>
        abstract addTicks: ticks: JXG.Ticks -> string
        /// Removes all ticks from a line.
        abstract removeAllTicks: unit -> unit
        /// <summary>Removes ticks identified by parameter named tick from this line.</summary>
        /// <param name="tick">- Reference to tick object to remove.</param>
        abstract removeTicks: tick: JXG.Ticks -> unit
        /// Controls if updates are necessary
        abstract needsUpdate: bool with get, set
        /// If element is in two dimensional real space this is true, else false.
        abstract isReal: bool with get, set
        /// The string used with {@link JXG.Board#create}
        abstract elType: string with get, set
        /// The methodMap determines which methods can be called from within JessieCode and under which name it
        /// can be used. The map is saved in an object, the name of a property is the name of the method used in JessieCode,
        /// the value of a property is the name of the method in JavaScript.
        abstract methodMap: obj option with get, set
        /// Unique identifier for the element. Equivalent to id-attribute of renderer element.
        abstract id: string with get, set
        /// General update method. Should be overwritten by the element itself.
        /// Can be used sometimes to commit changes to the object.
        abstract update: unit -> JXG.GeometryElement
        /// Removes the element from the construction.  This only removes the SVG or VML node of the element and its label (if available) from
        /// the renderer, to remove the element completely you should use {@link JXG.Board#removeObject}.
        abstract remove: unit -> unit
        /// Returns the coords object where a text that is bound to the element shall be drawn.
        /// Differs in some cases from the values that getLabelAnchor returns.
        abstract getTextAnchor: unit -> JXG.Coords
        /// Returns the coords object where the label of the element shall be drawn.
        /// Differs in some cases from the values that getTextAnchor returns.
        abstract getLabelAnchor: unit -> JXG.Coords
        /// <summary>Highlights the element.</summary>
        /// <param name="force">- Force the highlighting</param>
        abstract highlight: ?force: bool -> JXG.Board
        /// Copy the element to background. This is used for tracing elements.
        abstract cloneToBackground: unit -> JXG.GeometryElement
        /// Dimensions of the smallest rectangle enclosing the element.
        abstract bounds: unit -> ResizeArray<obj option>
        /// <summary>Set the highlightStrokeColor of an element</summary>
        /// <param name="sColor">- String which determines the stroke color of an object when its highlighted.</param>
        abstract highlightStrokeColor: sColor: string -> unit
        /// <summary>Set the strokeColor of an element</summary>
        /// <param name="sColor">- String which determines the stroke color of an object.</param>
        abstract strokeColor: sColor: string -> unit
        /// <summary>Set the strokeWidth of an element</summary>
        /// <param name="width">- Integer which determines the stroke width of an outline.</param>
        abstract strokeWidth: width: float -> unit
        /// <summary>Set the fillColor of an element</summary>
        /// <param name="fColor">- String which determines the fill color of an object.</param>
        abstract fillColor: fColor: string -> unit
        /// <summary>Set the highlightFillColor of an element</summary>
        /// <param name="fColor">- String which determines the fill color of an object when its highlighted.</param>
        abstract highlightFillColor: fColor: string -> unit
        /// <summary>Set the dash type of an element</summary>
        /// <param name="d">- Integer which determines the way of dashing an element's outline.</param>
        abstract dash: d: float -> unit
        /// <summary>Set the visibility of an element</summary>
        /// <param name="v">- Boolean which determines whether the element is drawn.</param>
        abstract visible: v: bool -> unit
        /// <summary>Set the shadow of an element</summary>
        /// <param name="s">- Boolean which determines whether the element has a shadow or not.</param>
        abstract shadow: s: bool -> unit
        /// Snaps the element to the grid. Only works for points, lines and circles. Points will snap to the grid
        /// as defined in their properties {@link JXG.Point#snapSizeX} and {@link JXG.Point#snapSizeY}. Lines and circles
        /// will snap their parent points to the grid, if they have {@link JXG.Point#snapToGrid} set to true.
        abstract snapToGrid: unit -> JXG.GeometryElement
        /// Snaps the element to points. Only works for points. Points will snap to the next point
        /// as defined in their properties {@link JXG.Point#attractorDistance} and {@link JXG.Point#attractorUnit}.
        /// Lines and circles
        /// will snap their parent points to points.
        abstract snapToPoints: unit -> JXG.GeometryElement
        /// Determines whether two-finger manipulation of this object may change its size.
        /// If set to false, the object is only rotated and translated.
        /// <p>
        /// In case the element is a horizontal or vertical line having ticks, "scalable:true"
        /// enables zooming of the board by dragging ticks lines. This feature is enabled,
        /// for the ticks element of the line element the attribute "fixed" has to be false
        /// and the line element's scalable attribute has to be true.
        /// <p>
        /// In case the element is a polygon or line and it has the attribute "scalable:false",
        /// moving the element with two fingers results in a rotation or translation.
        abstract scalable: bool with get, set

    /// The Line class is a basic class for all kind of line objects, e.g. line, arrow, and axis. It is usually defined by two points and can
    /// be intersected with some other geometry elements.
    type [<AllowNullLiteral>] LineStatic =
        [<Emit "new $0($1...)">] abstract Create: board: obj option * p1: Point * p2: Point * attributes: obj option -> Line

    /// A point is the basic geometric element. Based on points lines and circles can be constructed which can be intersected
    /// which in turn are points again which can be used to construct new lines, circles, polygons, etc. This class holds methods for
    /// all kind of points like free points, gliders, and intersection points.
    type [<AllowNullLiteral>] Point =
        inherit JXG.GeometryElement
        inherit JXG.CoordsElement
        /// Updates the position of the point.
        abstract update: unit -> unit
        /// Applies the transformations of the element to {@link JXG.Point#baseElement}.
        /// Point transformations are relative to a base element.
        abstract updateTransform: unit -> JXG.CoordsElement
        /// <summary>Convert the point to intersection point and update the construction.
        /// To move the point visual onto the intersection, a call of board update is necessary.
        /// TODO docu.</summary>
        /// <param name="el1">, - el2, i, j The intersecting objects and the numbers.</param>
        abstract makeIntersection: el1: obj * string: obj * : obj * any: obj -> unit
        abstract normalizeFace: s: obj option -> obj option
        /// <summary>Set the face of a point element.</summary>
        /// <param name="f">- String which determines the face of the point. See {@link JXG.GeometryElement#face} for a list of available faces.</param>
        abstract face: f: string -> unit
        /// <summary>Set the size of a point element</summary>
        /// <param name="s">- Integer which determines the size of the point.</param>
        abstract size: s: float -> unit
        /// Controls if updates are necessary
        abstract needsUpdate: bool with get, set
        /// Controls if this element can be dragged. In GEONExT only
        /// free points and gliders can be dragged.
        abstract isDraggable: bool with get, set
        /// If element is in two dimensional real space this is true, else false.
        abstract isReal: bool with get, set
        /// Stores all dependent objects to be updated when this point is moved.
        abstract childElements: obj option with get, set
        /// If element has a label subelement then this property will be set to true.
        abstract hasLabel: bool with get, set
        /// True, if the element is currently highlighted.
        abstract highlighted: bool with get, set
        /// Stores all Intersection Objects which in this moment are not real and
        /// so hide this element.
        abstract notExistingParents: obj option with get, set
        /// Keeps track of all objects drawn as part of the trace of the element.
        abstract traces: obj option with get, set
        /// Counts the number of objects drawn as part of the trace of the element.
        abstract numTraces: float with get, set
        /// Stores the  transformations which are applied during update in an array
        abstract transformations: ResizeArray<obj option> with get, set
        /// Elements depending on this element are stored here.
        abstract descendants: obj option with get, set
        /// Elements on which this element depends on are stored here.
        abstract ancestors: obj option with get, set
        /// Ids of elements on which this element depends directly are stored here.
        abstract parents: obj option with get, set
        /// Stores variables for symbolic computations
        abstract symbolic: obj option with get, set
        /// Stores the SVG (or VML) rendering node for the element. This enables low-level
        /// access to SVG nodes. The properties of such an SVG node can then be changed
        /// by calling setAttribute(). Note that there are a few elements which consist
        /// of more than one SVG nodes:
        /// <ul>
        /// <li> Elements with arrow tail or head: rendNodeTriangleStart, rendNodeTriangleEnd
        /// <li> SVG (or VML) texts: rendNodeText
        /// <li> Button: rendNodeForm, rendNodeButton, rendNodeTag
        /// <li> Checkbox: rendNodeForm, rendNodeCheckbox, rendNodeLabel, rendNodeTag
        /// <li> Input: rendNodeForm, rendNodeInput, rendNodeLabel, rendNodeTag
        /// </ul>
        /// 
        /// Here is are two examples: The first example shows how to access the SVG node,
        /// the second example demonstrates how to change SVG attributes.
        abstract rendNode: obj option with get, set
        /// The string used with {@link JXG.Board#create}
        abstract elType: string with get, set
        /// The element is saved with an explicit entry in the file (<tt>true</tt>) or implicitly
        /// via a composition.
        abstract dump: bool with get, set
        /// Subs contains the subelements, created during the create method.
        abstract subs: obj option with get, set
        /// Inherits contains the subelements, which may have an attribute
        /// (in partuclar the attribute "visible") having value 'inherit'.
        abstract inherits: obj option with get, set
        /// [c,b0,b1,a,k,r,q0,q1]
        /// 
        /// See
        /// A.E. Middleditch, T.W. Stacey, and S.B. Tor:
        /// "Intersection Algorithms for Lines and Circles",
        /// ACM Transactions on Graphics, Vol. 8, 1, 1989, pp 25-40.
        /// 
        /// The meaning of the parameters is:
        /// Circle: points p=[p0,p1] on the circle fulfill
        /// a&lt;p,p&gt; + &lt;b,p&gt; + c = 0
        /// For convenience we also store
        /// r: radius
        /// k: discriminant = sqrt(&lt;b,b&gt;-4ac)
        /// q=[q0,q1] center
        /// 
        /// Points have radius = 0.
        /// Lines have radius = infinity.
        /// b: normalized vector, representing the direction of the line.
        /// 
        /// Should be put into Coords, when all elements possess Coords.
        abstract stdform: ResizeArray<obj option> with get, set
        /// The methodMap determines which methods can be called from within JessieCode and under which name it
        /// can be used. The map is saved in an object, the name of a property is the name of the method used in JessieCode,
        /// the value of a property is the name of the method in JavaScript.
        abstract methodMap: obj option with get, set
        /// Quadratic form representation of circles (and conics)
        abstract quadraticform: ResizeArray<obj option> with get, set
        /// An associative array containing all visual properties.
        abstract visProp: obj option with get, set
        /// An associative array containing visual properties which are calculated from
        /// the attribute values (i.e. visProp) and from other constraints.
        /// An example: if an intersection point does not have real coordinates,
        /// visPropCalc.visible is set to false.
        /// Additionally, the user can control visibility with the attribute "visible",
        /// even by supplying a functions as value.
        abstract visPropCalc: obj option with get, set
        /// Is the mouse over this element?
        abstract mouseover: bool with get, set
        /// Time stamp containing the last time this element has been dragged.
        abstract lastDragTime: DateTime with get, set
        /// Reference to the board associated with the element.
        abstract board: JXG.Board with get, set
        /// Type of the element.
        abstract ``type``: float
        /// Original type of the element at construction time. Used for removing glider property.
        abstract _org_type: float
        /// The element's class.
        abstract elementClass: float
        /// Unique identifier for the element. Equivalent to id-attribute of renderer element.
        abstract id: string with get, set
        /// Not necessarily unique name for the element.
        abstract name: string with get, set
        /// <summary>Add an element as a child to the current element. Can be used to model dependencies between geometry elements.</summary>
        /// <param name="obj">- The dependent object.</param>
        abstract addChild: obj: JXG.GeometryElement -> unit
        /// <summary>Adds ids of elements to the array this.parents. This method needs to be called if some dependencies
        /// can not be detected automatically by JSXGraph. For example if a function graph is given by a function
        /// which referes to coordinates of a point, calling addParents() is necessary.</summary>
        /// <param name="parents">- Array of elements or ids of elements.
        /// Alternatively, one can give a list of objects as parameters.</param>
        abstract addParents: parents: ResizeArray<obj option> -> JXG.Object
        /// <summary>Sets ids of elements to the array this.parents.
        /// First, this.parents is cleared. See {@link JXG.GeometryElement#addParents}.</summary>
        /// <param name="parents">- Array of elements or ids of elements.
        /// Alternatively, one can give a list of objects as parameters.</param>
        abstract setParents: parents: ResizeArray<obj option> -> JXG.Object
        /// <summary>Remove an element as a child from the current element.</summary>
        /// <param name="obj">- The dependent object.</param>
        abstract removeChild: obj: JXG.GeometryElement -> unit
        /// Returns the elements name, Used in JessieCode.
        abstract getName: unit -> string
        /// <summary>Add transformations to this element.</summary>
        /// <param name="transform">- Either one {@link JXG.Transformation}
        /// or an array of {@link JXG.Transformation}s.</param>
        abstract addTransform: transform: U2<JXG.Transformation, ResizeArray<obj option>> -> JXG.GeometryElement
        /// <summary>Translates the object by <tt>(x, y)</tt>. In case the element is defined by points, the defining points are
        /// translated, e.g. a circle constructed by a center point and a point on the circle line.</summary>
        /// <param name="method">- The type of coordinates used here.
        /// Possible values are {@link JXG.COORDS_BY_USER} and {@link JXG.COORDS_BY_SCREEN}.</param>
        /// <param name="coords">- array of translation vector.</param>
        abstract setPosition: ``method``: float * coords: ResizeArray<obj option> -> JXG.GeometryElement
        /// <summary>Moves an element by the difference of two coordinates.</summary>
        /// <param name="method">- The type of coordinates used here.
        /// Possible values are {@link JXG.COORDS_BY_USER} and {@link JXG.COORDS_BY_SCREEN}.</param>
        /// <param name="coords">- coordinates in screen/user units</param>
        /// <param name="oldcoords">- previous coordinates in screen/user units</param>
        abstract setPositionDirectly: ``method``: float * coords: ResizeArray<obj option> * oldcoords: ResizeArray<obj option> -> JXG.GeometryElement
        /// Array of strings containing the polynomials defining the element.
        /// Used for determining geometric loci the groebner way.
        abstract generatePolynomial: unit -> ResizeArray<obj option>
        /// <summary>Animates properties for that object like stroke or fill color, opacity and maybe
        /// even more later.</summary>
        /// <param name="hash">- Object containing properties with target values for the animation.</param>
        /// <param name="time">- Number of milliseconds to complete the animation.</param>
        /// <param name="options">- Optional settings for the animation:<ul><li>callback: A function that is called as soon as the animation is finished.</li></ul></param>
        abstract animate: hash: obj option * time: float * ?options: obj -> JXG.GeometryElement
        /// Resolves property shortcuts like <tt>color</tt> and expands them, e.g. <tt>strokeColor</tt> and <tt>fillColor</tt>.
        /// Writes the expanded properties back to the given <tt>properties</tt>.
        abstract resolveShortcuts: properties: obj option -> obj option
        /// Sets a label and its text
        /// If label doesn't exist, it creates one
        abstract setLabel: str: string -> unit
        /// Updates the element's label text, strips all html.
        abstract setLabelText: str: string -> unit
        /// Updates the element's label text and the element's attribute "name", strips all html.
        abstract setName: str: string -> unit
        /// Deprecated alias for {@link JXG.GeometryElement#setAttribute}.
        abstract setProperty: unit -> unit
        /// <summary>Sets an arbitrary number of attributes. This method has one or more
        /// parameters of the following types:
        /// <ul>
        /// <li> object: {key1:value1,key2:value2,...}
        /// <li> string: "key1:value"
        /// <li> array: [key, value]
        /// </ul></summary>
        /// <param name="attributes">- An object with attributes.</param>
        abstract setAttribute: attributes: obj option -> JXG.GeometryElement
        /// Deprecated alias for {@link JXG.GeometryElement#getAttribute}.
        abstract getProperty: unit -> unit
        /// <summary>Get the value of the property <tt>key</tt>.</summary>
        /// <param name="key">- The name of the property you are looking for</param>
        abstract getAttribute: key: string -> obj option
        /// Removes the element from the construction.  This only removes the SVG or VML node of the element and its label (if available) from
        /// the renderer, to remove the element completely you should use {@link JXG.Board#removeObject}.
        abstract remove: unit -> unit
        /// Returns the coords object where a text that is bound to the element shall be drawn.
        /// Differs in some cases from the values that getLabelAnchor returns.
        abstract getTextAnchor: unit -> JXG.Coords
        /// Returns the coords object where the label of the element shall be drawn.
        /// Differs in some cases from the values that getTextAnchor returns.
        abstract getLabelAnchor: unit -> JXG.Coords
        /// <summary>Determines whether the element has arrows at start or end of the arc.
        /// If it is set to be a "typical" vector, ie lastArrow == true,
        /// then the element.type is set to VECTOR.</summary>
        /// <param name="firstArrow">- True if there is an arrow at the start of the arc, false otherwise.</param>
        /// <param name="lastArrow">- True if there is an arrow at the end of the arc, false otherwise.</param>
        abstract setArrow: firstArrow: bool * lastArrow: bool -> unit
        /// Creates a label element for this geometry element.
        abstract createLabel: unit -> unit
        /// <summary>Highlights the element.</summary>
        /// <param name="force">- Force the highlighting</param>
        abstract highlight: ?force: bool -> JXG.Board
        /// Uses the "normal" properties of the element.
        abstract noHighlight: unit -> JXG.Board
        /// Removes all objects generated by the trace function.
        abstract clearTrace: unit -> unit
        /// Copy the element to background. This is used for tracing elements.
        abstract cloneToBackground: unit -> JXG.GeometryElement
        /// Dimensions of the smallest rectangle enclosing the element.
        abstract bounds: unit -> ResizeArray<obj option>
        /// <summary>Rotate texts or images by a given degree. Works only for texts where JXG.Text#display equal to "internal".</summary>
        /// <param name="angle">- The degree of the rotation (90 means vertical text).</param>
        abstract addRotation: angle: float -> unit
        /// <summary>Set the highlightStrokeColor of an element</summary>
        /// <param name="sColor">- String which determines the stroke color of an object when its highlighted.</param>
        abstract highlightStrokeColor: sColor: string -> unit
        /// <summary>Set the strokeColor of an element</summary>
        /// <param name="sColor">- String which determines the stroke color of an object.</param>
        abstract strokeColor: sColor: string -> unit
        /// <summary>Set the strokeWidth of an element</summary>
        /// <param name="width">- Integer which determines the stroke width of an outline.</param>
        abstract strokeWidth: width: float -> unit
        /// <summary>Set the fillColor of an element</summary>
        /// <param name="fColor">- String which determines the fill color of an object.</param>
        abstract fillColor: fColor: string -> unit
        /// <summary>Set the highlightFillColor of an element</summary>
        /// <param name="fColor">- String which determines the fill color of an object when its highlighted.</param>
        abstract highlightFillColor: fColor: string -> unit
        /// <summary>Set the labelColor of an element</summary>
        /// <param name="lColor">- String which determines the text color of an object's label.</param>
        abstract labelColor: lColor: string -> unit
        /// <summary>Set the dash type of an element</summary>
        /// <param name="d">- Integer which determines the way of dashing an element's outline.</param>
        abstract dash: d: float -> unit
        /// <summary>Set the visibility of an element</summary>
        /// <param name="v">- Boolean which determines whether the element is drawn.</param>
        abstract visible: v: bool -> unit
        /// <summary>Set the shadow of an element</summary>
        /// <param name="s">- Boolean which determines whether the element has a shadow or not.</param>
        abstract shadow: s: bool -> unit
        /// The type of the element as used in {@link JXG.Board#create}.
        abstract getType: unit -> string
        /// List of the element ids resp. values used as parents in {@link JXG.Board#create}.
        abstract getParents: unit -> ResizeArray<obj option>
        /// Snaps the element to the grid. Only works for points, lines and circles. Points will snap to the grid
        /// as defined in their properties {@link JXG.Point#snapSizeX} and {@link JXG.Point#snapSizeY}. Lines and circles
        /// will snap their parent points to the grid, if they have {@link JXG.Point#snapToGrid} set to true.
        abstract snapToGrid: unit -> JXG.GeometryElement
        /// Snaps the element to points. Only works for points. Points will snap to the next point
        /// as defined in their properties {@link JXG.Point#attractorDistance} and {@link JXG.Point#attractorUnit}.
        /// Lines and circles
        /// will snap their parent points to points.
        abstract snapToPoints: unit -> JXG.GeometryElement
        /// Retrieve a copy of the current visProp.
        abstract getAttributes: unit -> obj option
        /// <summary>Move an element to its nearest grid point.
        /// The function uses the coords object of the element as
        /// its actual position. If there is no coords object, nothing is done.</summary>
        /// <param name="force">- force snapping independent from what the snaptogrid attribute says</param>
        /// <param name="fromParent">- True if the drag comes from a child element. This is the case if a line
        /// through two points is dragged. In this case we do not try to force the points to stay inside of
        /// the visible board, but the distance between the two points stays constant.</param>
        abstract handleSnapToGrid: force: bool * fromParent: bool -> JXG.GeometryElement
        /// Opacity for element's stroke color.
        abstract strokeOpacity: float with get, set
        /// Opacity for stroke color when the object is highlighted.
        abstract highlightStrokeOpacity: float with get, set
        /// Opacity for fill color.
        abstract fillOpacity: float with get, set
        /// Opacity for fill color when the object is highlighted.
        abstract highlightFillOpacity: float with get, set
        /// Transition duration (in milliseconds) for color and opacity
        /// changes. Works in SVG renderer, only.
        abstract transitionDuration: float with get, set
        /// Width of the element's stroke when the mouse is pointed over it.
        abstract highlightStrokeWidth: float with get, set
        /// If true the element is fixed and can not be dragged around. The element
        /// will be repositioned on zoom and moveOrigin events.
        abstract ``fixed``: bool with get, set
        /// If true the element is fixed and can not be dragged around. The element
        /// will even stay at its position on zoom and moveOrigin events.
        /// Only free elements like points, texts, curves can be frozen.
        abstract frozen: bool with get, set
        /// If true a label will display the element's name.
        abstract withLabel: bool with get, set
        /// If true the element will be traced, i.e. on every movement the element will be copied
        /// to the background. Use {@link JXG.GeometryElement#clearTrace} to delete the trace elements.
        /// 
        /// The calling of element.setAttribute({trace:false}) additionally
        /// deletes all traces of this element. By calling
        /// element.setAttribute({trace:'pause'})
        /// the removal of already existing traces can be prevented.
        abstract trace: U2<bool, string> with get, set
        /// Extra visual properties for traces of an element
        abstract traceAttributes: obj option with get, set
        /// If this is set to true, the element is updated in every update
        /// call of the board. If set to false, the element is updated only after
        /// zoom events or more generally, when the bounding box has been changed.
        /// Examples for the latter behaviour should be axes.
        abstract needsRegularUpdate: bool with get, set
        /// Determines whether two-finger manipulation of this object may change its size.
        /// If set to false, the object is only rotated and translated.
        /// <p>
        /// In case the element is a horizontal or vertical line having ticks, "scalable:true"
        /// enables zooming of the board by dragging ticks lines. This feature is enabled,
        /// for the ticks element of the line element the attribute "fixed" has to be false
        /// and the line element's scalable attribute has to be true.
        /// <p>
        /// In case the element is a polygon or line and it has the attribute "scalable:false",
        /// moving the element with two fingers results in a rotation or translation.
        abstract scalable: bool with get, set
        /// If true the element will be drawn in grey scale colors to visualize that it's only a draft.
        abstract draft: bool with get, set

    /// A point is the basic geometric element. Based on points lines and circles can be constructed which can be intersected
    /// which in turn are points again which can be used to construct new lines, circles, polygons, etc. This class holds methods for
    /// all kind of points like free points, gliders, and intersection points.
    type [<AllowNullLiteral>] PointStatic =
        [<Emit "new $0($1...)">] abstract Create: board: U2<string, JXG.Board> * coordinates: ResizeArray<obj option> * attributes: obj option -> Point

    /// Creates a new instance of JXG.Polygon.
    type [<AllowNullLiteral>] Polygon =
        inherit JXG.GeometryElement
        /// References to the points defining the polygon. The last vertex is the same as the first vertex.
        abstract vertices: ResizeArray<obj option> with get, set
        /// References to the border lines of the polygon.
        abstract borders: ResizeArray<obj option> with get, set
        /// <summary>Checks whether (x,y) is near the polygon.</summary>
        /// <param name="x">- Coordinate in x direction, screen coordinates.</param>
        /// <param name="y">- Coordinate in y direction, screen coordinates.</param>
        abstract hasPoint: x: float * y: float -> bool
        /// Uses the boards renderer to update the polygon.
        abstract updateRenderer: unit -> unit
        /// return TextAnchor
        abstract getTextAnchor: unit -> unit
        /// <summary>Hide the polygon including its border lines. It will still exist but not visible on the board.</summary>
        /// <param name="borderless">- If set to true, the polygon is treated as a polygon without
        /// borders, i.e. the borders will not be hidden.</param>
        abstract hideElement: ?borderless: bool -> unit
        /// <summary>Make the element visible.</summary>
        /// <param name="borderless">- If set to true, the polygon is treated as a polygon without
        /// borders, i.e. the borders will not be shown.</param>
        abstract showElement: ?borderless: bool -> unit
        /// Area of (not self-intersecting) polygon
        abstract Area: unit -> float
        /// Perimeter of polygon.
        abstract Perimeter: unit -> float
        /// Bounding box of a polygon. The bounding box is an array of four numbers: the first two numbers
        /// determine the upper left corner, the last two number determine the lower right corner of the bounding box.
        /// 
        /// The width and height of a polygon can then determined like this:
        abstract boundingBox: unit -> ResizeArray<obj option>
        /// This method removes the SVG or VML nodes of the lines and the filled area from the renderer, to remove
        /// the object completely you should use {@link JXG.Board#removeObject}.
        abstract remove: unit -> unit
        /// <summary>Finds the index to a given point reference.</summary>
        /// <param name="p">- Reference to an element of type {@link JXG.Point}</param>
        abstract findPoint: p: JXG.Point -> unit
        /// <summary>Add more points to the polygon. The new points will be inserted at the end.</summary>
        /// <param name="p">- Arbitrary number of points</param>
        abstract addPoints: p: JXG.Point -> JXG.Polygon
        /// <summary>Adds more points to the vertex list of the polygon, starting with index <tt><i</tt></summary>
        /// <param name="idx">- The position where the new vertices are inserted, starting with 0.</param>
        /// <param name="p">- Arbitrary number of points to insert.</param>
        abstract insertPoints: idx: float * p: JXG.Point -> JXG.Polygon
        /// <summary>Removes given set of vertices from the polygon</summary>
        /// <param name="p">- Arbitrary number of vertices as {@link JXG.Point} elements or index numbers</param>
        abstract removePoints: p: JXG.Point -> JXG.Polygon
        /// <summary>Moves the polygon by the difference of two coordinates.</summary>
        /// <param name="method">- The type of coordinates used here. Possible values are {@link JXG.COORDS_BY_USER} and {@link JXG.COORDS_BY_SCREEN}.</param>
        /// <param name="coords">- coordinates in screen/user units</param>
        /// <param name="oldcoords">- previous coordinates in screen/user units</param>
        abstract setPositionDirectly: ``method``: float * coords: ResizeArray<obj option> * oldcoords: ResizeArray<obj option> -> JXG.Polygon
        /// <summary>Generic method for the intersection of this polygon with another polygon.
        /// The parent object is the clipping polygon, it expects as parameter a polygon to be clipped.
        /// Both polygons have to be convex.
        /// Calls {@link JXG.Polygon#sutherlandHodgman}.</summary>
        /// <param name="polygon">- Polygon which will be clipped.</param>
        abstract intersect: polygon: JXG.Polygon -> ResizeArray<obj option>
        /// Controls if updates are necessary
        abstract needsUpdate: bool with get, set
        /// If element is in two dimensional real space this is true, else false.
        abstract isReal: bool with get, set
        /// The string used with {@link JXG.Board#create}
        abstract elType: string with get, set
        /// The methodMap determines which methods can be called from within JessieCode and under which name it
        /// can be used. The map is saved in an object, the name of a property is the name of the method used in JessieCode,
        /// the value of a property is the name of the method in JavaScript.
        abstract methodMap: obj option with get, set
        /// Unique identifier for the element. Equivalent to id-attribute of renderer element.
        abstract id: string with get, set
        /// Returns the coords object where the label of the element shall be drawn.
        /// Differs in some cases from the values that getTextAnchor returns.
        abstract getLabelAnchor: unit -> JXG.Coords
        /// <summary>Highlights the element.</summary>
        /// <param name="force">- Force the highlighting</param>
        abstract highlight: ?force: bool -> JXG.Board
        /// Copy the element to background. This is used for tracing elements.
        abstract cloneToBackground: unit -> JXG.GeometryElement
        /// Dimensions of the smallest rectangle enclosing the element.
        abstract bounds: unit -> ResizeArray<obj option>
        /// <summary>Set the highlightStrokeColor of an element</summary>
        /// <param name="sColor">- String which determines the stroke color of an object when its highlighted.</param>
        abstract highlightStrokeColor: sColor: string -> unit
        /// <summary>Set the strokeColor of an element</summary>
        /// <param name="sColor">- String which determines the stroke color of an object.</param>
        abstract strokeColor: sColor: string -> unit
        /// <summary>Set the strokeWidth of an element</summary>
        /// <param name="width">- Integer which determines the stroke width of an outline.</param>
        abstract strokeWidth: width: float -> unit
        /// <summary>Set the fillColor of an element</summary>
        /// <param name="fColor">- String which determines the fill color of an object.</param>
        abstract fillColor: fColor: string -> unit
        /// <summary>Set the highlightFillColor of an element</summary>
        /// <param name="fColor">- String which determines the fill color of an object when its highlighted.</param>
        abstract highlightFillColor: fColor: string -> unit
        /// <summary>Set the dash type of an element</summary>
        /// <param name="d">- Integer which determines the way of dashing an element's outline.</param>
        abstract dash: d: float -> unit
        /// <summary>Set the visibility of an element</summary>
        /// <param name="v">- Boolean which determines whether the element is drawn.</param>
        abstract visible: v: bool -> unit
        /// <summary>Set the shadow of an element</summary>
        /// <param name="s">- Boolean which determines whether the element has a shadow or not.</param>
        abstract shadow: s: bool -> unit
        /// List of the element ids resp. values used as parents in {@link JXG.Board#create}.
        abstract getParents: unit -> ResizeArray<obj option>
        /// Snaps the element to the grid. Only works for points, lines and circles. Points will snap to the grid
        /// as defined in their properties {@link JXG.Point#snapSizeX} and {@link JXG.Point#snapSizeY}. Lines and circles
        /// will snap their parent points to the grid, if they have {@link JXG.Point#snapToGrid} set to true.
        abstract snapToGrid: unit -> JXG.GeometryElement
        /// Retrieve a copy of the current visProp.
        abstract getAttributes: unit -> obj option
        /// Determines whether two-finger manipulation of this object may change its size.
        /// If set to false, the object is only rotated and translated.
        /// <p>
        /// In case the element is a horizontal or vertical line having ticks, "scalable:true"
        /// enables zooming of the board by dragging ticks lines. This feature is enabled,
        /// for the ticks element of the line element the attribute "fixed" has to be false
        /// and the line element's scalable attribute has to be true.
        /// <p>
        /// In case the element is a polygon or line and it has the attribute "scalable:false",
        /// moving the element with two fingers results in a rotation or translation.
        abstract scalable: bool with get, set

    /// Creates a new instance of JXG.Polygon.
    type [<AllowNullLiteral>] PolygonStatic =
        [<Emit "new $0($1...)">] abstract Create: board: JXG.Board * vertices: ResizeArray<obj option> * attributes: obj option -> Polygon

    /// Construct and handle texts.
    /// 
    /// The coordinates can be relative to the coordinates of an element
    /// given in {@link JXG.Options#text.anchor}.
    /// 
    /// MathJax, HTML and GEONExT syntax can be handled.
    type [<AllowNullLiteral>] Text =
        inherit JXG.GeometryElement
        inherit JXG.CoordsElement
        /// Defines new content but converts &lt; and &gt; to HTML entities before updating the DOM.
        abstract setTextJessieCode: text: U2<string, (ResizeArray<obj option> -> obj option)> -> unit
        /// Defines new content.
        abstract setText: text: U2<string, (ResizeArray<obj option> -> obj option)> -> JXG.Text
        /// Recompute the width and the height of the text box.
        /// Updates the array {@link JXG.Text#size} with pixel values.
        /// The result may differ from browser to browser
        /// by some pixels.
        /// In canvas an old IEs we use a very crude estimation of the dimensions of
        /// the textbox.
        /// JSXGraph needs {@link JXG.Text#size} for applying rotations in IE and
        /// for aligning text.
        abstract updateSize: unit -> obj option
        /// A very crude estimation of the dimensions of the textbox in case nothing else is available.
        abstract crudeSizeEstimate: unit -> ResizeArray<obj option>
        /// Decode unicode entities into characters.
        abstract utf8_decode: string: string -> string
        /// <summary>Replace _{} by &lt;sub&gt;</summary>
        /// <param name="te">- String containing _{}.</param>
        abstract replaceSub: te: string -> string
        /// <summary>Replace ^{} by &lt;sup&gt;</summary>
        /// <param name="te">- String containing ^{}.</param>
        abstract replaceSup: te: string -> string
        /// Return the width of the text element.
        abstract getSize: unit -> ResizeArray<obj option>
        /// Move the text to new coordinates.
        abstract setCoords: x: float * y: float -> obj option
        /// Evaluates the text.
        /// Then, the update function of the renderer
        /// is called.
        abstract update: unit -> unit
        /// Sets the offset of a label element to the position with the least number
        /// of overlaps with other elements, while retaining the distance to its
        /// anchor element. Twelve different angles are possible.
        abstract setAutoPosition: unit -> JXG.Text
        /// Controls if updates are necessary
        abstract needsUpdate: bool with get, set
        /// Controls if this element can be dragged. In GEONExT only
        /// free points and gliders can be dragged.
        abstract isDraggable: bool with get, set
        /// If element is in two dimensional real space this is true, else false.
        abstract isReal: bool with get, set
        /// Stores all dependent objects to be updated when this point is moved.
        abstract childElements: obj option with get, set
        /// If element has a label subelement then this property will be set to true.
        abstract hasLabel: bool with get, set
        /// True, if the element is currently highlighted.
        abstract highlighted: bool with get, set
        /// Stores all Intersection Objects which in this moment are not real and
        /// so hide this element.
        abstract notExistingParents: obj option with get, set
        /// Keeps track of all objects drawn as part of the trace of the element.
        abstract traces: obj option with get, set
        /// Counts the number of objects drawn as part of the trace of the element.
        abstract numTraces: float with get, set
        /// Stores the  transformations which are applied during update in an array
        abstract transformations: ResizeArray<obj option> with get, set
        /// Elements depending on this element are stored here.
        abstract descendants: obj option with get, set
        /// Elements on which this element depends on are stored here.
        abstract ancestors: obj option with get, set
        /// Ids of elements on which this element depends directly are stored here.
        abstract parents: obj option with get, set
        /// Stores variables for symbolic computations
        abstract symbolic: obj option with get, set
        /// Stores the SVG (or VML) rendering node for the element. This enables low-level
        /// access to SVG nodes. The properties of such an SVG node can then be changed
        /// by calling setAttribute(). Note that there are a few elements which consist
        /// of more than one SVG nodes:
        /// <ul>
        /// <li> Elements with arrow tail or head: rendNodeTriangleStart, rendNodeTriangleEnd
        /// <li> SVG (or VML) texts: rendNodeText
        /// <li> Button: rendNodeForm, rendNodeButton, rendNodeTag
        /// <li> Checkbox: rendNodeForm, rendNodeCheckbox, rendNodeLabel, rendNodeTag
        /// <li> Input: rendNodeForm, rendNodeInput, rendNodeLabel, rendNodeTag
        /// </ul>
        /// 
        /// Here is are two examples: The first example shows how to access the SVG node,
        /// the second example demonstrates how to change SVG attributes.
        abstract rendNode: obj option with get, set
        /// The string used with {@link JXG.Board#create}
        abstract elType: string with get, set
        /// The element is saved with an explicit entry in the file (<tt>true</tt>) or implicitly
        /// via a composition.
        abstract dump: bool with get, set
        /// Subs contains the subelements, created during the create method.
        abstract subs: obj option with get, set
        /// Inherits contains the subelements, which may have an attribute
        /// (in partuclar the attribute "visible") having value 'inherit'.
        abstract inherits: obj option with get, set
        /// [c,b0,b1,a,k,r,q0,q1]
        /// 
        /// See
        /// A.E. Middleditch, T.W. Stacey, and S.B. Tor:
        /// "Intersection Algorithms for Lines and Circles",
        /// ACM Transactions on Graphics, Vol. 8, 1, 1989, pp 25-40.
        /// 
        /// The meaning of the parameters is:
        /// Circle: points p=[p0,p1] on the circle fulfill
        /// a&lt;p,p&gt; + &lt;b,p&gt; + c = 0
        /// For convenience we also store
        /// r: radius
        /// k: discriminant = sqrt(&lt;b,b&gt;-4ac)
        /// q=[q0,q1] center
        /// 
        /// Points have radius = 0.
        /// Lines have radius = infinity.
        /// b: normalized vector, representing the direction of the line.
        /// 
        /// Should be put into Coords, when all elements possess Coords.
        abstract stdform: ResizeArray<obj option> with get, set
        /// The methodMap determines which methods can be called from within JessieCode and under which name it
        /// can be used. The map is saved in an object, the name of a property is the name of the method used in JessieCode,
        /// the value of a property is the name of the method in JavaScript.
        abstract methodMap: obj option with get, set
        /// Quadratic form representation of circles (and conics)
        abstract quadraticform: ResizeArray<obj option> with get, set
        /// An associative array containing all visual properties.
        abstract visProp: obj option with get, set
        /// An associative array containing visual properties which are calculated from
        /// the attribute values (i.e. visProp) and from other constraints.
        /// An example: if an intersection point does not have real coordinates,
        /// visPropCalc.visible is set to false.
        /// Additionally, the user can control visibility with the attribute "visible",
        /// even by supplying a functions as value.
        abstract visPropCalc: obj option with get, set
        /// Is the mouse over this element?
        abstract mouseover: bool with get, set
        /// Time stamp containing the last time this element has been dragged.
        abstract lastDragTime: DateTime with get, set
        /// Reference to the board associated with the element.
        abstract board: JXG.Board with get, set
        /// Type of the element.
        abstract ``type``: float
        /// Original type of the element at construction time. Used for removing glider property.
        abstract _org_type: float
        /// The element's class.
        abstract elementClass: float
        /// Unique identifier for the element. Equivalent to id-attribute of renderer element.
        abstract id: string with get, set
        /// Not necessarily unique name for the element.
        abstract name: string with get, set
        /// <summary>Add an element as a child to the current element. Can be used to model dependencies between geometry elements.</summary>
        /// <param name="obj">- The dependent object.</param>
        abstract addChild: obj: JXG.GeometryElement -> unit
        /// <summary>Adds ids of elements to the array this.parents. This method needs to be called if some dependencies
        /// can not be detected automatically by JSXGraph. For example if a function graph is given by a function
        /// which referes to coordinates of a point, calling addParents() is necessary.</summary>
        /// <param name="parents">- Array of elements or ids of elements.
        /// Alternatively, one can give a list of objects as parameters.</param>
        abstract addParents: parents: ResizeArray<obj option> -> JXG.Object
        /// <summary>Sets ids of elements to the array this.parents.
        /// First, this.parents is cleared. See {@link JXG.GeometryElement#addParents}.</summary>
        /// <param name="parents">- Array of elements or ids of elements.
        /// Alternatively, one can give a list of objects as parameters.</param>
        abstract setParents: parents: ResizeArray<obj option> -> JXG.Object
        /// <summary>Remove an element as a child from the current element.</summary>
        /// <param name="obj">- The dependent object.</param>
        abstract removeChild: obj: JXG.GeometryElement -> unit
        /// Returns the elements name, Used in JessieCode.
        abstract getName: unit -> string
        /// <summary>Add transformations to this element.</summary>
        /// <param name="transform">- Either one {@link JXG.Transformation}
        /// or an array of {@link JXG.Transformation}s.</param>
        abstract addTransform: transform: U2<JXG.Transformation, ResizeArray<obj option>> -> JXG.GeometryElement
        /// <summary>Translates the object by <tt>(x, y)</tt>. In case the element is defined by points, the defining points are
        /// translated, e.g. a circle constructed by a center point and a point on the circle line.</summary>
        /// <param name="method">- The type of coordinates used here.
        /// Possible values are {@link JXG.COORDS_BY_USER} and {@link JXG.COORDS_BY_SCREEN}.</param>
        /// <param name="coords">- array of translation vector.</param>
        abstract setPosition: ``method``: float * coords: ResizeArray<obj option> -> JXG.GeometryElement
        /// <summary>Moves an element by the difference of two coordinates.</summary>
        /// <param name="method">- The type of coordinates used here.
        /// Possible values are {@link JXG.COORDS_BY_USER} and {@link JXG.COORDS_BY_SCREEN}.</param>
        /// <param name="coords">- coordinates in screen/user units</param>
        /// <param name="oldcoords">- previous coordinates in screen/user units</param>
        abstract setPositionDirectly: ``method``: float * coords: ResizeArray<obj option> * oldcoords: ResizeArray<obj option> -> JXG.GeometryElement
        /// Array of strings containing the polynomials defining the element.
        /// Used for determining geometric loci the groebner way.
        abstract generatePolynomial: unit -> ResizeArray<obj option>
        /// <summary>Animates properties for that object like stroke or fill color, opacity and maybe
        /// even more later.</summary>
        /// <param name="hash">- Object containing properties with target values for the animation.</param>
        /// <param name="time">- Number of milliseconds to complete the animation.</param>
        /// <param name="options">- Optional settings for the animation:<ul><li>callback: A function that is called as soon as the animation is finished.</li></ul></param>
        abstract animate: hash: obj option * time: float * ?options: obj -> JXG.GeometryElement
        /// Resolves property shortcuts like <tt>color</tt> and expands them, e.g. <tt>strokeColor</tt> and <tt>fillColor</tt>.
        /// Writes the expanded properties back to the given <tt>properties</tt>.
        abstract resolveShortcuts: properties: obj option -> obj option
        /// Sets a label and its text
        /// If label doesn't exist, it creates one
        abstract setLabel: str: string -> unit
        /// Updates the element's label text, strips all html.
        abstract setLabelText: str: string -> unit
        /// Updates the element's label text and the element's attribute "name", strips all html.
        abstract setName: str: string -> unit
        /// Deprecated alias for {@link JXG.GeometryElement#setAttribute}.
        abstract setProperty: unit -> unit
        /// <summary>Sets an arbitrary number of attributes. This method has one or more
        /// parameters of the following types:
        /// <ul>
        /// <li> object: {key1:value1,key2:value2,...}
        /// <li> string: "key1:value"
        /// <li> array: [key, value]
        /// </ul></summary>
        /// <param name="attributes">- An object with attributes.</param>
        abstract setAttribute: attributes: obj option -> JXG.GeometryElement
        /// Deprecated alias for {@link JXG.GeometryElement#getAttribute}.
        abstract getProperty: unit -> unit
        /// <summary>Get the value of the property <tt>key</tt>.</summary>
        /// <param name="key">- The name of the property you are looking for</param>
        abstract getAttribute: key: string -> obj option
        /// Removes the element from the construction.  This only removes the SVG or VML node of the element and its label (if available) from
        /// the renderer, to remove the element completely you should use {@link JXG.Board#removeObject}.
        abstract remove: unit -> unit
        /// Returns the coords object where a text that is bound to the element shall be drawn.
        /// Differs in some cases from the values that getLabelAnchor returns.
        abstract getTextAnchor: unit -> JXG.Coords
        /// Returns the coords object where the label of the element shall be drawn.
        /// Differs in some cases from the values that getTextAnchor returns.
        abstract getLabelAnchor: unit -> JXG.Coords
        /// <summary>Determines whether the element has arrows at start or end of the arc.
        /// If it is set to be a "typical" vector, ie lastArrow == true,
        /// then the element.type is set to VECTOR.</summary>
        /// <param name="firstArrow">- True if there is an arrow at the start of the arc, false otherwise.</param>
        /// <param name="lastArrow">- True if there is an arrow at the end of the arc, false otherwise.</param>
        abstract setArrow: firstArrow: bool * lastArrow: bool -> unit
        /// Creates a label element for this geometry element.
        abstract createLabel: unit -> unit
        /// <summary>Highlights the element.</summary>
        /// <param name="force">- Force the highlighting</param>
        abstract highlight: ?force: bool -> JXG.Board
        /// Uses the "normal" properties of the element.
        abstract noHighlight: unit -> JXG.Board
        /// Removes all objects generated by the trace function.
        abstract clearTrace: unit -> unit
        /// Copy the element to background. This is used for tracing elements.
        abstract cloneToBackground: unit -> JXG.GeometryElement
        /// Dimensions of the smallest rectangle enclosing the element.
        abstract bounds: unit -> ResizeArray<obj option>
        /// <summary>Rotate texts or images by a given degree. Works only for texts where JXG.Text#display equal to "internal".</summary>
        /// <param name="angle">- The degree of the rotation (90 means vertical text).</param>
        abstract addRotation: angle: float -> unit
        /// <summary>Set the highlightStrokeColor of an element</summary>
        /// <param name="sColor">- String which determines the stroke color of an object when its highlighted.</param>
        abstract highlightStrokeColor: sColor: string -> unit
        /// <summary>Set the strokeColor of an element</summary>
        /// <param name="sColor">- String which determines the stroke color of an object.</param>
        abstract strokeColor: sColor: string -> unit
        /// <summary>Set the strokeWidth of an element</summary>
        /// <param name="width">- Integer which determines the stroke width of an outline.</param>
        abstract strokeWidth: width: float -> unit
        /// <summary>Set the fillColor of an element</summary>
        /// <param name="fColor">- String which determines the fill color of an object.</param>
        abstract fillColor: fColor: string -> unit
        /// <summary>Set the highlightFillColor of an element</summary>
        /// <param name="fColor">- String which determines the fill color of an object when its highlighted.</param>
        abstract highlightFillColor: fColor: string -> unit
        /// <summary>Set the labelColor of an element</summary>
        /// <param name="lColor">- String which determines the text color of an object's label.</param>
        abstract labelColor: lColor: string -> unit
        /// <summary>Set the dash type of an element</summary>
        /// <param name="d">- Integer which determines the way of dashing an element's outline.</param>
        abstract dash: d: float -> unit
        /// <summary>Set the visibility of an element</summary>
        /// <param name="v">- Boolean which determines whether the element is drawn.</param>
        abstract visible: v: bool -> unit
        /// <summary>Set the shadow of an element</summary>
        /// <param name="s">- Boolean which determines whether the element has a shadow or not.</param>
        abstract shadow: s: bool -> unit
        /// The type of the element as used in {@link JXG.Board#create}.
        abstract getType: unit -> string
        /// List of the element ids resp. values used as parents in {@link JXG.Board#create}.
        abstract getParents: unit -> ResizeArray<obj option>
        /// Snaps the element to the grid. Only works for points, lines and circles. Points will snap to the grid
        /// as defined in their properties {@link JXG.Point#snapSizeX} and {@link JXG.Point#snapSizeY}. Lines and circles
        /// will snap their parent points to the grid, if they have {@link JXG.Point#snapToGrid} set to true.
        abstract snapToGrid: unit -> JXG.GeometryElement
        /// Snaps the element to points. Only works for points. Points will snap to the next point
        /// as defined in their properties {@link JXG.Point#attractorDistance} and {@link JXG.Point#attractorUnit}.
        /// Lines and circles
        /// will snap their parent points to points.
        abstract snapToPoints: unit -> JXG.GeometryElement
        /// Retrieve a copy of the current visProp.
        abstract getAttributes: unit -> obj option
        /// <summary>Move an element to its nearest grid point.
        /// The function uses the coords object of the element as
        /// its actual position. If there is no coords object, nothing is done.</summary>
        /// <param name="force">- force snapping independent from what the snaptogrid attribute says</param>
        /// <param name="fromParent">- True if the drag comes from a child element. This is the case if a line
        /// through two points is dragged. In this case we do not try to force the points to stay inside of
        /// the visible board, but the distance between the two points stays constant.</param>
        abstract handleSnapToGrid: force: bool * fromParent: bool -> JXG.GeometryElement
        /// Opacity for element's stroke color.
        abstract strokeOpacity: float with get, set
        /// Opacity for stroke color when the object is highlighted.
        abstract highlightStrokeOpacity: float with get, set
        /// Opacity for fill color.
        abstract fillOpacity: float with get, set
        /// Opacity for fill color when the object is highlighted.
        abstract highlightFillOpacity: float with get, set
        /// Transition duration (in milliseconds) for color and opacity
        /// changes. Works in SVG renderer, only.
        abstract transitionDuration: float with get, set
        /// Width of the element's stroke when the mouse is pointed over it.
        abstract highlightStrokeWidth: float with get, set
        /// If true the element is fixed and can not be dragged around. The element
        /// will be repositioned on zoom and moveOrigin events.
        abstract ``fixed``: bool with get, set
        /// If true the element is fixed and can not be dragged around. The element
        /// will even stay at its position on zoom and moveOrigin events.
        /// Only free elements like points, texts, curves can be frozen.
        abstract frozen: bool with get, set
        /// If true a label will display the element's name.
        abstract withLabel: bool with get, set
        /// If true the element will be traced, i.e. on every movement the element will be copied
        /// to the background. Use {@link JXG.GeometryElement#clearTrace} to delete the trace elements.
        /// 
        /// The calling of element.setAttribute({trace:false}) additionally
        /// deletes all traces of this element. By calling
        /// element.setAttribute({trace:'pause'})
        /// the removal of already existing traces can be prevented.
        abstract trace: U2<bool, string> with get, set
        /// Extra visual properties for traces of an element
        abstract traceAttributes: obj option with get, set
        /// If this is set to true, the element is updated in every update
        /// call of the board. If set to false, the element is updated only after
        /// zoom events or more generally, when the bounding box has been changed.
        /// Examples for the latter behaviour should be axes.
        abstract needsRegularUpdate: bool with get, set
        /// Determines whether two-finger manipulation of this object may change its size.
        /// If set to false, the object is only rotated and translated.
        /// <p>
        /// In case the element is a horizontal or vertical line having ticks, "scalable:true"
        /// enables zooming of the board by dragging ticks lines. This feature is enabled,
        /// for the ticks element of the line element the attribute "fixed" has to be false
        /// and the line element's scalable attribute has to be true.
        /// <p>
        /// In case the element is a polygon or line and it has the attribute "scalable:false",
        /// moving the element with two fingers results in a rotation or translation.
        abstract scalable: bool with get, set
        /// If true the element will be drawn in grey scale colors to visualize that it's only a draft.
        abstract draft: bool with get, set

    /// Construct and handle texts.
    /// 
    /// The coordinates can be relative to the coordinates of an element
    /// given in {@link JXG.Options#text.anchor}.
    /// 
    /// MathJax, HTML and GEONExT syntax can be handled.
    type [<AllowNullLiteral>] TextStatic =
        [<Emit "new $0($1...)">] abstract Create: board: U2<string, JXG.Board> * coordinates: ResizeArray<obj option> * attributes: obj option * content: U2<string, (ResizeArray<obj option> -> obj option)> -> Text

    /// Creates ticks for an axis.
    type [<AllowNullLiteral>] Ticks =
        inherit JXG.GeometryElement
        /// The line the ticks belong to.
        abstract line: JXG.Line with get, set
        /// The board the ticks line is drawn on.
        abstract board: JXG.Board with get, set
        /// A function calculating ticks delta depending on the ticks number.
        abstract ticksFunction: (ResizeArray<obj option> -> obj option) with get, set
        /// Array of fixed ticks.
        abstract fixedTicks: ResizeArray<obj option> with get, set
        /// Equidistant ticks. Distance is defined by ticksFunction
        abstract equidistant: bool with get, set
        /// Least distance between two ticks, measured in pixels.
        abstract minTicksDistance: int with get, set
        /// Stores the ticks coordinates
        abstract ticks: ResizeArray<obj option> with get, set
        /// Distance between two major ticks in user coordinates
        abstract ticksDelta: float with get, set
        /// Array where the labels are saved. There is an array element for every tick,
        /// even for minor ticks which don't have labels. In this case the array element
        /// contains just <tt>null</tt>.
        abstract labels: ResizeArray<obj option> with get, set
        /// A list of labels which have to be displayed in updateRenderer.
        abstract labelData: ResizeArray<obj option> with get, set
        /// To ensure the uniqueness of label ids this counter is used.
        abstract labelCounter: float with get, set
        /// <summary>Checks whether (x,y) is near the line.</summary>
        /// <param name="x">- Coordinate in x direction, screen coordinates.</param>
        /// <param name="y">- Coordinate in y direction, screen coordinates.</param>
        abstract hasPoint: x: float * y: float -> bool
        /// <summary>Sets x and y coordinate of the tick.</summary>
        /// <param name="method">- The type of coordinates used here. Possible values are {@link JXG.COORDS_BY_USER} and {@link JXG.COORDS_BY_SCREEN}.</param>
        /// <param name="coords">- coordinates in screen/user units</param>
        /// <param name="oldcoords">- previous coordinates in screen/user units</param>
        abstract setPositionDirectly: ``method``: float * coords: ResizeArray<obj option> * oldcoords: ResizeArray<obj option> -> JXG.Ticks
        /// <summary>Check if (parts of) the tick is inside the canvas. The tick intersects the boundary
        /// at two positions: [x[0], y[0]] and [x[1], y[1]] in screen coordinates.</summary>
        /// <param name="x">- Array of length two</param>
        /// <param name="y">- Array of length two</param>
        abstract _isInsideCanvas: x: ResizeArray<obj option> * y: ResizeArray<obj option> -> bool
        /// Recalculate the tick positions and the labels.
        abstract update: unit -> JXG.Ticks
        /// Uses the boards renderer to update the arc.
        abstract updateRenderer: unit -> JXG.Ticks
        /// Controls if updates are necessary
        abstract needsUpdate: bool with get, set
        /// The string used with {@link JXG.Board#create}
        abstract elType: string with get, set
        /// Unique identifier for the element. Equivalent to id-attribute of renderer element.
        abstract id: string with get, set
        /// <summary>Highlights the element.</summary>
        /// <param name="force">- Force the highlighting</param>
        abstract highlight: ?force: bool -> JXG.Board
        /// <summary>Set the highlightStrokeColor of an element</summary>
        /// <param name="sColor">- String which determines the stroke color of an object when its highlighted.</param>
        abstract highlightStrokeColor: sColor: string -> unit
        /// <summary>Set the strokeColor of an element</summary>
        /// <param name="sColor">- String which determines the stroke color of an object.</param>
        abstract strokeColor: sColor: string -> unit
        /// <summary>Set the strokeWidth of an element</summary>
        /// <param name="width">- Integer which determines the stroke width of an outline.</param>
        abstract strokeWidth: width: float -> unit
        /// <summary>Set the fillColor of an element</summary>
        /// <param name="fColor">- String which determines the fill color of an object.</param>
        abstract fillColor: fColor: string -> unit
        /// <summary>Set the highlightFillColor of an element</summary>
        /// <param name="fColor">- String which determines the fill color of an object when its highlighted.</param>
        abstract highlightFillColor: fColor: string -> unit
        /// <summary>Set the dash type of an element</summary>
        /// <param name="d">- Integer which determines the way of dashing an element's outline.</param>
        abstract dash: d: float -> unit
        /// <summary>Set the visibility of an element</summary>
        /// <param name="v">- Boolean which determines whether the element is drawn.</param>
        abstract visible: v: bool -> unit
        /// <summary>Set the shadow of an element</summary>
        /// <param name="s">- Boolean which determines whether the element has a shadow or not.</param>
        abstract shadow: s: bool -> unit
        /// Snaps the element to the grid. Only works for points, lines and circles. Points will snap to the grid
        /// as defined in their properties {@link JXG.Point#snapSizeX} and {@link JXG.Point#snapSizeY}. Lines and circles
        /// will snap their parent points to the grid, if they have {@link JXG.Point#snapToGrid} set to true.
        abstract snapToGrid: unit -> JXG.GeometryElement
        /// Determines whether two-finger manipulation of this object may change its size.
        /// If set to false, the object is only rotated and translated.
        /// <p>
        /// In case the element is a horizontal or vertical line having ticks, "scalable:true"
        /// enables zooming of the board by dragging ticks lines. This feature is enabled,
        /// for the ticks element of the line element the attribute "fixed" has to be false
        /// and the line element's scalable attribute has to be true.
        /// <p>
        /// In case the element is a polygon or line and it has the attribute "scalable:false",
        /// moving the element with two fingers results in a rotation or translation.
        abstract scalable: bool with get, set

    /// Creates ticks for an axis.
    type [<AllowNullLiteral>] TicksStatic =
        [<Emit "new $0($1...)">] abstract Create: line: JXG.Line * ticks: U2<float, ResizeArray<obj option>> * attributes: obj option -> Ticks

    /// A transformation consists of a 3x3 matrix, i.e. it is a projective transformation.
    type [<AllowNullLiteral>] Transformation =
        /// Updates the numerical data for the transformation, i.e. the entry of the subobject matrix.
        abstract update: unit -> JXG.Transform
        /// <summary>Set the transformation matrix for different types of standard transforms.</summary>
        /// <param name="type">- Transformation type, possible values are
        ///         'translate', 'scale', 'reflect', 'rotate',
        ///         'shear', 'generic'.</param>
        /// <param name="params">- Parameters for the various transformation types.
        /// <p>These are</param>
        /// <param name="x">,y - Shift vector (number or function) in case of 'translate'.</param>
        /// <param name="scale_x">,scale_y - Scale vector (number or function) in case of 'scale'.</param>
        /// <param name="line">|point_pair|"four - coordinates" In case of 'reflect' the parameters could
        ///  be a line, a pair of points or four number (or functions) p_x, p_y, q_x, q_y,
        ///  determining a line through points (p_x, p_y) and (q_x, q_y).</param>
        /// <param name="apply">- element which is transformed</param>
        abstract setMatrix: board: JXG.Board * ``type``: string * ``params``: ResizeArray<obj option> * x: obj * y: ResizeArray<obj option> * scale_x: obj * scale_y: ResizeArray<obj option> * line: obj * : obj * point_pair: obj * : obj * : obj * apply: obj -> unit

    /// A transformation consists of a 3x3 matrix, i.e. it is a projective transformation.
    type [<AllowNullLiteral>] TransformationStatic =
        [<Emit "new $0($1...)">] abstract Create: board: JXG.Board * ``type``: string * ``params``: obj option -> Transformation

/// Constructs a new JSXGraph singleton object.
type [<AllowNullLiteral>] JSXGraph =
    interface end

/// Constructs a new JSXGraph singleton object.
type [<AllowNullLiteral>] JSXGraphStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> JSXGraph
    /// Stores the renderer that is used to draw the boards.
    abstract rendererType: string with get, set
    /// <summary>Initialise a new board.</summary>
    /// <param name="box">- Html-ID to the Html-element in which the board is painted.</param>
    /// <param name="attributes">- An object that sets some of the board properties. Most of these properties can be set via JXG.Options.</param>
    abstract initBoard: box: string * attributes: JSXGraphStaticInitBoardAttributes -> JXG.Board
    /// <summary>Load a board from a file containing a construction made with either GEONExT,
    /// Intergeo, Geogebra, or Cinderella.</summary>
    /// <param name="box">- HTML-ID to the HTML-element in which the board is painted.</param>
    /// <param name="file">- base64 encoded string.</param>
    /// <param name="format">- containing the file format: 'Geonext' or 'Intergeo'.</param>
    abstract loadBoardFromFile: box: string * file: string * format: string * ?attributes: obj -> JXG.Board
    /// <summary>Load a board from a base64 encoded string containing a construction made with either GEONExT,
    /// Intergeo, Geogebra, or Cinderella.</summary>
    /// <param name="box">- HTML-ID to the HTML-element in which the board is painted.</param>
    /// <param name="string">- base64 encoded string.</param>
    /// <param name="format">- containing the file format: 'Geonext' or 'Intergeo'.</param>
    abstract loadBoardFromString: box: string * string: string * format: string * ?attributes: obj -> JXG.Board
    /// Delete a board and all its contents.
    abstract freeBoard: unit -> unit
    abstract registerElement: element: obj option * creator: obj option -> unit

type [<AllowNullLiteral>] JSXGraphStaticInitBoardAttributes =
    abstract boundingbox: ResizeArray<obj option> option with get, set
    abstract keepaspectratio: bool option with get, set
    abstract showCopyright: bool option with get, set
    abstract showNavigation: bool option with get, set
    abstract zoom: obj option with get, set
    abstract pan: obj option with get, set
    abstract axis: bool option with get, set
    abstract grid: U2<bool, obj option> option with get, set
    abstract registerEvents: bool option with get, set

/// Creates a new complex number.
type [<AllowNullLiteral>] Complex =
    /// Real part of the complex number.
    abstract real: float with get, set
    /// Imaginary part of the complex number.
    abstract imaginary: float with get, set
    /// Absolute value in the polar form of the complex number. Currently unused.
    abstract absval: float with get, set
    /// Angle value in the polar form of the complex number. Currently unused.
    abstract angle: float with get, set
    /// Converts a complex number into a string.
    abstract toString: unit -> string
    /// Add another complex number to this complex number.
    abstract add: unit -> JXG.Complex
    /// Subtract another complex number from this complex number.
    abstract sub: unit -> JXG.Complex
    /// Multiply another complex number to this complex number.
    abstract mult: unit -> JXG.Complex
    /// Divide this complex number by the given complex number.
    abstract div: unit -> JXG.Complex
    /// Conjugate a complex number in place.
    abstract conj: unit -> JXG.Complex

/// Creates a new complex number.
type [<AllowNullLiteral>] ComplexStatic =
    [<Emit "new $0($1...)">] abstract Create: ?x: float * ?y: float -> Complex

module Math =
    let [<Import("Geometry","module/Math")>] geometry: Geometry.IExports = jsNative
    let [<Import("Numerics","module/Math")>] numerics: Numerics.IExports = jsNative
    let [<Import("Poly","module/Math")>] poly: Poly.IExports = jsNative
    let [<Import("Statistics","module/Math")>] statistics: Statistics.IExports = jsNative
    let [<Import("Symbolic","module/Math")>] symbolic: Symbolic.IExports = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract eps: float
        /// <summary>Determine the relative difference between two numbers.</summary>
        /// <param name="a">- First number</param>
        /// <param name="b">- Second number</param>
        abstract relDif: a: float * b: float -> float
        /// The JavaScript implementation of the % operator returns the symmetric modulo.
        /// They are both identical if a >= 0 and m >= 0 but the results differ if a or m < 0.
        abstract ``mod``: a: float * m: float -> float
        /// <summary>Initializes a vector as an array with the coefficients set to the given value resp. zero.</summary>
        /// <param name="n">- Length of the vector</param>
        /// <param name="init">- Initial value for each coefficient</param>
        abstract vector: n: float * ?init: float -> ResizeArray<obj option>
        /// <summary>Initializes a matrix as an array of rows with the given value.</summary>
        /// <param name="n">- Number of rows</param>
        /// <param name="m">- Number of columns</param>
        /// <param name="init">- Initial value for each coefficient</param>
        abstract matrix: n: float * ?m: float * ?init: float -> ResizeArray<obj option>
        /// <summary>Generates an identity matrix. If n is a number and m is undefined or not a number, a square matrix is generated,
        /// if n and m are both numbers, an nxm matrix is generated.</summary>
        /// <param name="n">- Number of rows</param>
        /// <param name="m">- Number of columns</param>
        abstract identity: n: float * ?m: float -> ResizeArray<obj option>
        /// <summary>Generates a 4x4 matrix for 3D to 2D projections.</summary>
        /// <param name="l">- Left</param>
        /// <param name="r">- Right</param>
        /// <param name="t">- Top</param>
        /// <param name="b">- Bottom</param>
        /// <param name="n">- Near</param>
        /// <param name="f">- Far</param>
        abstract frustum: l: float * r: float * t: float * b: float * n: float * f: float -> ResizeArray<obj option>
        /// <summary>Generates a 4x4 matrix for 3D to 2D projections.</summary>
        /// <param name="fov">- Field of view in vertical direction, given in rad.</param>
        /// <param name="ratio">- Aspect ratio of the projection plane.</param>
        /// <param name="n">- Near</param>
        /// <param name="f">- Far</param>
        abstract projection: fov: float * ratio: float * n: float * f: float -> ResizeArray<obj option>
        /// <summary>Multiplies a vector vec to a matrix mat: mat * vec. The matrix is interpreted by this function as an array of rows. Please note: This
        /// function does not check if the dimensions match.</summary>
        /// <param name="mat">- Two dimensional array of numbers. The inner arrays describe the columns, the outer ones the matrix' rows.</param>
        /// <param name="vec">- Array of numbers</param>
        abstract matVecMult: mat: ResizeArray<obj option> * vec: ResizeArray<obj option> -> ResizeArray<obj option>
        /// <summary>Computes the product of the two matrices mat1*mat2.</summary>
        /// <param name="mat1">- Two dimensional array of numbers</param>
        /// <param name="mat2">- Two dimensional array of numbers</param>
        abstract matMatMult: mat1: ResizeArray<obj option> * mat2: ResizeArray<obj option> -> ResizeArray<obj option>
        /// <summary>Transposes a matrix given as a two dimensional array.</summary>
        /// <param name="M">- The matrix to be transposed</param>
        abstract transpose: M: ResizeArray<obj option> -> ResizeArray<obj option>
        /// Compute the inverse of an nxn matrix with Gauss elimination.
        abstract inverse: Ain: ResizeArray<obj option> -> ResizeArray<obj option>
        /// <summary>Inner product of two vectors a and b. n is the length of the vectors.</summary>
        /// <param name="a">- Vector</param>
        /// <param name="b">- Vector</param>
        /// <param name="n">- Length of the Vectors. If not given the length of the first vector is taken.</param>
        abstract innerProduct: a: ResizeArray<obj option> * b: ResizeArray<obj option> * ?n: float -> float
        /// <summary>Calculates the cross product of two vectors both of length three.
        /// In case of homogeneous coordinates this is either
        /// <ul>
        /// <li>the intersection of two lines</li>
        /// <li>the line through two points</li>
        /// </ul></summary>
        /// <param name="c1">- Homogeneous coordinates of line or point 1</param>
        /// <param name="c2">- Homogeneous coordinates of line or point 2</param>
        abstract crossProduct: c1: ResizeArray<obj option> * c2: ResizeArray<obj option> -> ResizeArray<obj option>
        /// <summary>Euclidean norm of a vector.</summary>
        /// <param name="a">- Array containing a vector.</param>
        /// <param name="n">- (Optional) length of the array.</param>
        abstract norm: a: ResizeArray<obj option> * n: float -> float
        /// Compute the factorial of a positive integer. If a non-integer value
        /// is given, the fraction will be ignored.
        abstract factorial: n: float -> float
        /// <summary>Computes the binomial coefficient n over k.</summary>
        /// <param name="n">- Fraction will be ignored</param>
        /// <param name="k">- Fraction will be ignored</param>
        abstract binomial: n: float * k: float -> float
        abstract cosh: obj option
        abstract sinh: obj option
        /// <summary>Computes the cotangent of x.</summary>
        /// <param name="x">- The number the cotangent will be calculated of.</param>
        abstract cot: x: float -> float
        /// <summary>Computes the inverse cotangent of x.</summary>
        /// <param name="x">- The number the inverse cotangent will be calculated of.</param>
        abstract acot: x: float -> float
        /// <summary>Compute n-th real root of a real number. n must be strictly positive integer.
        /// If n is odd, the real n-th root exists and is negative.
        /// For n even, for negative valuees of x NaN is returned</summary>
        /// <param name="x">- radicand. Must be non-negative, if n even.</param>
        /// <param name="n">- index of the root. must be strictly positive integer.</param>
        abstract nthroot: x: float * n: float -> float
        abstract cbrt: obj option
        /// Compute base to the power of exponent.
        abstract pow: ``base``: float * exponent: float -> float
        /// Logarithm to base 10.
        abstract log10: x: float -> float
        /// Logarithm to base 2.
        abstract log2: x: float -> float
        /// <summary>Logarithm to arbitrary base b. If b is not given, natural log is taken, i.e. b = e.</summary>
        /// <param name="b">- base</param>
        abstract log: x: float * b: float -> float
        abstract sign: obj option
        /// A square & multiply algorithm to compute base to the power of exponent.
        /// Implementated by Wolfgang Riedl.
        abstract squampow: ``base``: float * exponent: float -> float
        /// <summary>Greatest common divisor (gcd) of two numbers.</summary>
        /// <param name="a">- First number</param>
        /// <param name="b">- Second number</param>
        abstract gcd: a: float * b: float -> float
        /// <summary>Least common multiple (lcm) of two numbers.</summary>
        /// <param name="a">- First number</param>
        /// <param name="b">- Second number</param>
        abstract lcm: a: float * b: float -> float
        /// <summary>Converts a two dimensional array to a one dimensional Float32Array that can be processed by WebGL.</summary>
        /// <param name="m">- A matrix in a two dimensional array.</param>
        abstract toGL: m: ResizeArray<obj option> -> Float32Array

    module Geometry =

        type [<AllowNullLiteral>] IExports =
            /// Calculates the angle defined by the points A, B, C.
            abstract angle: unit -> float
            /// Calculates the angle defined by the three points A, B, C if you're going from A to C around B counterclockwise.
            abstract trueAngle: unit -> float
            /// Calculates the internal angle defined by the three points A, B, C if you're going from A to C around B counterclockwise.
            abstract rad: unit -> float
            /// <summary>Calculates a point on the bisection line between the three points A, B, C.
            /// As a result, the bisection line is defined by two points:
            /// Parameter B and the point with the coordinates calculated in this function.
            /// Does not work for ideal points.</summary>
            /// <param name="A">- Point</param>
            /// <param name="B">- Point</param>
            /// <param name="C">- Point</param>
            /// <param name="board">- Reference to the board</param>
            abstract angleBisector: A: JXG.Point * B: JXG.Point * C: JXG.Point * ?board: obj -> JXG.Coords
            /// <summary>Reflects the point along the line.</summary>
            /// <param name="line">- Axis of reflection.</param>
            /// <param name="point">- Point to reflect.</param>
            /// <param name="board">- Reference to the board</param>
            abstract reflection: line: JXG.Line * point: JXG.Point * ?board: obj -> JXG.Coords
            /// <summary>Computes the new position of a point which is rotated
            /// around a second point (called rotpoint) by the angle phi.</summary>
            /// <param name="rotpoint">- Center of the rotation</param>
            /// <param name="point">- point to be rotated</param>
            /// <param name="phi">- rotation angle in arc length</param>
            /// <param name="board">- Reference to the board</param>
            abstract rotation: rotpoint: JXG.Point * point: JXG.Point * phi: float * ?board: JXG.Board -> JXG.Coords
            /// <summary>Calculates the coordinates of a point on the perpendicular to the given line through
            /// the given point.</summary>
            /// <param name="line">- A line.</param>
            /// <param name="point">- Point which is projected to the line.</param>
            /// <param name="board">- Reference to the board</param>
            abstract perpendicular: line: JXG.Line * point: JXG.Point * ?board: JXG.Board -> ResizeArray<obj option>
            abstract circumcenterMidpoint: unit -> unit
            /// <summary>Calculates the center of the circumcircle of the three given points.</summary>
            /// <param name="point1">- Point</param>
            /// <param name="point2">- Point</param>
            /// <param name="point3">- Point</param>
            /// <param name="board">- Reference to the board</param>
            abstract circumcenter: point1: JXG.Point * point2: JXG.Point * point3: JXG.Point * ?board: JXG.Board -> JXG.Coords
            /// <summary>Calculates the Euclidean distance for two given arrays of the same length.</summary>
            /// <param name="array1">- Array of Number</param>
            /// <param name="array2">- Array of Number</param>
            /// <param name="n">- Length of the arrays. Default is the minimum length of the given arrays.</param>
            abstract distance: array1: ResizeArray<obj option> * array2: ResizeArray<obj option> * ?n: float -> float
            /// <summary>Calculates Euclidean distance for two given arrays of the same length.
            /// If one of the arrays contains a zero in the first coordinate, and the Euclidean distance
            /// is different from zero it is a point at infinity and we return Infinity.</summary>
            /// <param name="array1">- Array containing elements of type number.</param>
            /// <param name="array2">- Array containing elements of type number.</param>
            /// <param name="n">- Length of the arrays. Default is the minimum length of the given arrays.</param>
            abstract affineDistance: array1: ResizeArray<obj option> * array2: ResizeArray<obj option> * ?n: float -> float
            /// <summary>Sort vertices counter clockwise starting with the point with the lowest y coordinate.</summary>
            /// <param name="p">- An array containing {@link JXG.Point}, {@link JXG.Coords}, and/or arrays.</param>
            abstract sortVertices: p: ResizeArray<obj option> -> ResizeArray<obj option>
            /// Signed triangle area of the three points given.
            abstract signedTriangle: p1: U3<JXG.Point, JXG.Coords, ResizeArray<obj option>> * p2: U3<JXG.Point, JXG.Coords, ResizeArray<obj option>> * p3: U3<JXG.Point, JXG.Coords, ResizeArray<obj option>> -> float
            /// <summary>Determine the signed area of a non-intersecting polygon.
            /// Surveyor's Formula</summary>
            /// <param name="p">- An array containing {@link JXG.Point}, {@link JXG.Coords}, and/or arrays.</param>
            abstract signedPolygon: p: ResizeArray<obj option> * ?sort: bool -> float
            /// <summary>Calculate the complex hull of a point cloud.</summary>
            /// <param name="points">- An array containing {@link JXG.Point}, {@link JXG.Coords}, and/or arrays.</param>
            abstract GrahamScan: points: ResizeArray<obj option> -> ResizeArray<obj option>
            /// <summary>A line can be a segment, a straight, or a ray. so it is not always delimited by point1 and point2
            /// calcStraight determines the visual start point and end point of the line. A segment is only drawn
            /// from start to end point, a straight line is drawn until it meets the boards boundaries.</summary>
            /// <param name="el">- Reference to a line object, that needs calculation of start and end point.</param>
            /// <param name="point1">- Coordinates of the point where line drawing begins. This value is calculated and
            /// set by this method.</param>
            /// <param name="point2">- Coordinates of the point where line drawing ends. This value is calculated and set
            /// by this method.</param>
            /// <param name="margin">- Optional margin, to avoid the display of the small sides of lines.</param>
            abstract calcStraight: el: JXG.Line * point1: JXG.Coords * point2: JXG.Coords * margin: float -> obj option
            /// <summary>A line can be a segment, a straight, or a ray. so it is not always delimited by point1 and point2.
            /// 
            /// This method adjusts the line's delimiting points taking into account its nature, the viewport defined
            /// by the board.
            /// 
            /// A segment is delimited by start and end point, a straight line or ray is delimited until it meets the
            /// boards boundaries. However, if the line has infinite ticks, it will be delimited by the projection of
            /// the boards vertices onto itself.</summary>
            /// <param name="el">- Reference to a line object, that needs calculation of start and end point.</param>
            /// <param name="point1">- Coordinates of the point where line drawing begins. This value is calculated and
            /// set by this method.</param>
            /// <param name="point2">- Coordinates of the point where line drawing ends. This value is calculated and set
            /// by this method.</param>
            abstract calcLineDelimitingPoints: el: JXG.Line * point1: JXG.Coords * point2: JXG.Coords -> unit
            /// <summary>Calculates the visProp.position corresponding to a given angle.</summary>
            /// <param name="angle">- angle in radians. Must be in range (-2pi,2pi).</param>
            abstract calcLabelQuadrant: angle: float -> unit
            /// The vectors <tt>p2-p1</tt> and <tt>i2-i1</tt> are supposed to be collinear. If their cosine is positive
            /// they point into the same direction otherwise they point in opposite direction.
            abstract isSameDir: p1: JXG.Coords * p2: JXG.Coords * i1: JXG.Coords * i2: JXG.Coords -> bool
            /// <summary>If you're looking from point "start" towards point "s" and can see the point "p", true is returned.
            /// Otherwise return false.</summary>
            /// <param name="start">- The point you're standing on.</param>
            /// <param name="p">- The point in which direction you're looking.</param>
            /// <param name="s">- The point that should be visible.</param>
            abstract isSameDirection: start: JXG.Coords * p: JXG.Coords * s: JXG.Coords -> bool
            /// <summary>Generate the function which computes the coordinates of the intersection point.
            /// Primarily used in {@link JXG.Point#createIntersectionPoint}.</summary>
            /// <param name="board">- object</param>
            abstract intersectionFunction: board: JXG.Board -> (ResizeArray<obj option> -> obj option)
            /// <summary>Computes the intersection of a pair of lines, circles or both.
            /// It uses the internal data array stdform of these elements.</summary>
            /// <param name="el1">- stdform of the first element (line or circle)</param>
            /// <param name="el2">- stdform of the second element (line or circle)</param>
            /// <param name="i">- Index of the intersection point that should be returned.</param>
            /// <param name="board">- Reference to the board.</param>
            abstract meet: el1: ResizeArray<obj option> * el2: ResizeArray<obj option> * i: float * board: obj option -> JXG.Coords
            /// <summary>Intersection of the line with the board</summary>
            /// <param name="line">- stdform of the line in screen coordinates</param>
            /// <param name="board">- reference to a board.</param>
            /// <param name="margin">- optional margin, to avoid the display of the small sides of lines.</param>
            abstract meetLineBoard: line: ResizeArray<obj option> * board: JXG.Board * margin: float -> ResizeArray<obj option>
            /// <summary>Intersection of two lines.</summary>
            /// <param name="l1">- stdform of the first line</param>
            /// <param name="l2">- stdform of the second line</param>
            /// <param name="i">- unused</param>
            /// <param name="board">- Reference to the board.</param>
            abstract meetLineLine: l1: ResizeArray<obj option> * l2: ResizeArray<obj option> * i: float * board: JXG.Board -> JXG.Coords
            /// <summary>Intersection of line and circle.</summary>
            /// <param name="lin">- stdform of the line</param>
            /// <param name="circ">- stdform of the circle</param>
            /// <param name="i">- number of the returned intersection point.
            /// i==0: use the positive square root,
            /// i==1: use the negative square root.</param>
            /// <param name="board">- Reference to a board.</param>
            abstract meetLineCircle: lin: ResizeArray<obj option> * circ: ResizeArray<obj option> * i: float * board: JXG.Board -> JXG.Coords
            /// <summary>Intersection of two circles.</summary>
            /// <param name="circ1">- stdform of the first circle</param>
            /// <param name="circ2">- stdform of the second circle</param>
            /// <param name="i">- number of the returned intersection point.
            /// i==0: use the positive square root,
            /// i==1: use the negative square root.</param>
            /// <param name="board">- Reference to the board.</param>
            abstract meetCircleCircle: circ1: ResizeArray<obj option> * circ2: ResizeArray<obj option> * i: float * board: JXG.Board -> JXG.Coords
            /// <summary>Compute an intersection of the curves c1 and c2.
            /// We want to find values t1, t2 such that
            /// c1(t1) = c2(t2), i.e. (c1_x(t1)-c2_x(t2),c1_y(t1)-c2_y(t2)) = (0,0).
            /// 
            /// Methods: segment-wise intersections (default) or generalized Newton method.</summary>
            /// <param name="c1">- Curve, Line or Circle</param>
            /// <param name="c2">- Curve, Line or Circle</param>
            /// <param name="nr">- the nr-th intersection point will be returned.</param>
            /// <param name="t2ini">- not longer used.</param>
            /// <param name="board">- Reference to a board object.</param>
            /// <param name="method">- Intersection method, possible values are 'newton' and 'segment'.</param>
            abstract meetCurveCurve: c1: JXG.Curve * c2: JXG.Curve * nr: float * t2ini: float * ?board: JXG.Board * ?``method``: string -> JXG.Coords
            /// <summary>Intersection of curve with line,
            /// Order of input does not matter for el1 and el2.
            /// From version 0.99.7 on this method calls
            /// {@link JXG.Math.Geometry.meetCurveLineDiscrete}.
            /// If higher precision is needed, {@link JXG.Math.Geometry.meetCurveLineContinuous}
            /// has to be used.</summary>
            /// <param name="nr">- the nr-th intersection point will be returned.</param>
            /// <param name="board">- Reference to a board object.</param>
            /// <param name="alwaysIntersect">- If false just the segment between the two defining points are tested for intersection</param>
            abstract meetCurveLine: nr: float * ?board: JXG.Board * alwaysIntersect: bool -> JXG.Coords
            /// <summary>Intersection of line and curve, continuous case.
            /// Finds the nr-the intersection point
            /// Uses {@link JXG.Math.Geometry.meetCurveLineDiscrete} as a first approximation.
            /// A more exact solution is then found with {@link JXG.Math.Numerics.root}.</summary>
            /// <param name="cu">- Curve</param>
            /// <param name="li">- Line</param>
            /// <param name="nr">- Will return the nr-th intersection point.</param>
            abstract meetCurveLineContinuous: cu: JXG.Curve * li: JXG.Line * nr: float * board: JXG.Board -> JXG.Coords
            /// <summary>Intersection of line and curve, discrete case.
            /// Segments are treated as lines.
            /// Finding the nr-th intersection point should work for all nr.</summary>
            /// <param name="testSegment">- Test if intersection has to be inside of the segment or somewhere on the
            /// line defined by the segment</param>
            abstract meetCurveLineDiscrete: cu: JXG.Curve * li: JXG.Line * nr: float * board: JXG.Board * testSegment: bool -> JXG.Coords
            /// Find the n-th intersection point of two curves named red (first parameter) and blue (second parameter).
            /// We go through each segment of the red curve and search if there is an intersection with a segemnt of the blue curve.
            /// This double loop, i.e. the outer loop runs along the red curve and the inner loop runs along the blue curve, defines
            /// the n-th intersection point. The segments are either line segments or Bezier curves of degree 3. This depends on
            /// the property bezierDegree of the curves.
            /// <p>
            /// This method works also for transformed curves, since only the already
            /// transformed points are used.
            abstract meetCurveRedBlueSegments: red: JXG.Curve * blue: JXG.Curve * nr: float -> unit
            /// <summary>Intersection of two segments.</summary>
            /// <param name="p1">- First point of segment 1 using homogeneous coordinates [z,x,y]</param>
            /// <param name="p2">- Second point of segment 1 using homogeneous coordinates [z,x,y]</param>
            /// <param name="q1">- First point of segment 2 using homogeneous coordinates [z,x,y]</param>
            /// <param name="q2">- Second point of segment 2 using homogeneous coordinates [z,x,y]</param>
            abstract meetSegmentSegment: p1: ResizeArray<obj option> * p2: ResizeArray<obj option> * q1: ResizeArray<obj option> * q2: ResizeArray<obj option> -> ResizeArray<obj option>
            /// <summary>Splits a Bezier curve segment defined by four points into
            /// two Bezier curve segments. Dissection point is t=1/2.</summary>
            /// <param name="curve">- Array of four coordinate arrays of length 2 defining a
            /// Bezier curve segment, i.e. [[x0,y0], [x1,y1], [x2,y2], [x3,y3]].</param>
            abstract _bezierSplit: curve: ResizeArray<obj option> -> ResizeArray<obj option>
            /// <summary>Computes the bounding box [minX, maxY, maxX, minY] of a Bezier curve segment
            /// from its control points.</summary>
            /// <param name="curve">- Array of four coordinate arrays of length 2 defining a
            /// Bezier curve segment, i.e. [[x0,y0], [x1,y1], [x2,y2], [x3,y3]].</param>
            abstract _bezierBbox: curve: ResizeArray<obj option> -> ResizeArray<obj option>
            /// <summary>Decide if two Bezier curve segments overlap by comparing their bounding boxes.</summary>
            /// <param name="bb1">- Bounding box of the first Bezier curve segment</param>
            /// <param name="bb2">- Bounding box of the second Bezier curve segment</param>
            abstract _bezierOverlap: bb1: ResizeArray<obj option> * bb2: ResizeArray<obj option> -> bool
            /// <summary>Find intersections of two Bezier curve segments by recursive subdivision.
            /// Below maxlevel determine intersections by intersection line segments.</summary>
            /// <param name="red">- Array of four coordinate arrays of length 2 defining the first
            /// Bezier curve segment, i.e. [[x0,y0], [x1,y1], [x2,y2], [x3,y3]].</param>
            /// <param name="blue">- Array of four coordinate arrays of length 2 defining the second
            /// Bezier curve segment, i.e. [[x0,y0], [x1,y1], [x2,y2], [x3,y3]].</param>
            /// <param name="level">- Recursion level</param>
            abstract _bezierMeetSubdivision: red: ResizeArray<obj option> * blue: ResizeArray<obj option> * level: float -> ResizeArray<obj option>
            /// <param name="testSegment">- Test if intersection has to be inside of the segment or somewhere on the line defined by the segment</param>
            abstract _bezierLineMeetSubdivision: testSegment: bool -> unit
            /// <summary>Find the nr-th intersection point of two Bezier curve segments.</summary>
            /// <param name="red">- Array of four coordinate arrays of length 2 defining the first
            /// Bezier curve segment, i.e. [[x0,y0], [x1,y1], [x2,y2], [x3,y3]].</param>
            /// <param name="blue">- Array of four coordinate arrays of length 2 defining the second
            /// Bezier curve segment, i.e. [[x0,y0], [x1,y1], [x2,y2], [x3,y3]].</param>
            /// <param name="testSegment">- Test if intersection has to be inside of the segment or somewhere on the line defined by the segment</param>
            abstract meetBeziersegmentBeziersegment: red: ResizeArray<obj option> * blue: ResizeArray<obj option> * testSegment: bool -> ResizeArray<obj option>
            /// <summary>Find the nr-th intersection point of two Bezier curves, i.e. curves with bezierDegree == 3.</summary>
            /// <param name="red">- Curve with bezierDegree == 3</param>
            /// <param name="blue">- Curve with bezierDegree == 3</param>
            /// <param name="nr">- The number of the intersection point which should be returned.</param>
            abstract meetBezierCurveRedBlueSegments: red: JXG.Curve * blue: JXG.Curve * nr: float -> ResizeArray<obj option>
            /// <summary>Generate the defining points of a 3rd degree bezier curve that approximates
            /// a circle sector defined by three arrays A, B,C, each of length three.
            /// The coordinate arrays are given in homogeneous coordinates.</summary>
            /// <param name="A">- First point</param>
            /// <param name="B">- Second point (intersection point)</param>
            /// <param name="C">- Third point</param>
            /// <param name="withLegs">- Flag. If true the legs to the intersection point are part of the curve.</param>
            /// <param name="sgn">- Wither 1 or -1. Needed for minor and major arcs. In case of doubt, use 1.</param>
            abstract bezierArc: A: ResizeArray<obj option> * B: ResizeArray<obj option> * C: ResizeArray<obj option> * withLegs: bool * sgn: float -> unit
            /// <summary>Calculates the coordinates of the projection of a given point on a given circle. I.o.w. the
            /// nearest one of the two intersection points of the line through the given point and the circles
            /// center.</summary>
            /// <param name="circle">- Circle on that the point is projected.</param>
            /// <param name="board">- Reference to the board</param>
            abstract projectPointToCircle: circle: JXG.Circle * ?board: JXG.Board -> JXG.Coords
            /// <summary>Calculates the coordinates of the orthogonal projection of a given point on a given line. I.o.w. the
            /// intersection point of the given line and its perpendicular through the given point.</summary>
            /// <param name="point">- Point to project.</param>
            /// <param name="line">- Line on that the point is projected.</param>
            /// <param name="board">- Reference to a board.</param>
            abstract projectPointToLine: point: JXG.Point * line: JXG.Line * ?board: JXG.Board -> JXG.Coords
            /// <summary>Calculates the coordinates of the orthogonal projection of a given coordinate array on a given line
            /// segment defined by two coordinate arrays.</summary>
            /// <param name="p">- Point to project.</param>
            /// <param name="q1">- Start point of the line segment on that the point is projected.</param>
            /// <param name="q2">- End point of the line segment on that the point is projected.</param>
            abstract projectCoordsToSegment: p: ResizeArray<obj option> * q1: ResizeArray<obj option> * q2: ResizeArray<obj option> -> ResizeArray<obj option>
            /// <summary>Finds the coordinates of the closest point on a Bezier segment of a
            /// {@link JXG.Curve} to a given coordinate array.</summary>
            /// <param name="pos">- Point to project in homogeneous coordinates.</param>
            /// <param name="curve">- Curve of type "plot" having Bezier degree 3.</param>
            /// <param name="start">- Number of the Bezier segment of the curve.</param>
            abstract projectCoordsToBeziersegment: pos: ResizeArray<obj option> * curve: JXG.Curve * start: float -> ResizeArray<obj option>
            /// <summary>Calculates the coordinates of the projection of a given point on a given curve.
            /// Uses {@link JXG.Math.Geometry.projectCoordsToCurve}.</summary>
            /// <param name="point">- Point to project.</param>
            /// <param name="curve">- Curve on that the point is projected.</param>
            /// <param name="board">- Reference to a board.</param>
            abstract projectPointToCurve: point: JXG.Point * curve: JXG.Curve * ?board: JXG.Board -> JXG.Coords
            /// <summary>Calculates the coordinates of the projection of a coordinates pair on a given curve. In case of
            /// function graphs this is the
            /// intersection point of the curve and the parallel to y-axis through the given point.</summary>
            /// <param name="x">- coordinate to project.</param>
            /// <param name="y">- coordinate to project.</param>
            /// <param name="t">- start value for newtons method</param>
            /// <param name="curve">- Curve on that the point is projected.</param>
            /// <param name="board">- Reference to a board.</param>
            abstract projectCoordsToCurve: x: float * y: float * t: float * curve: JXG.Curve * ?board: JXG.Board -> JXG.Coords
            /// <summary>Calculates the coordinates of the closest orthogonal projection of a given coordinate array onto the
            /// border of a polygon.</summary>
            /// <param name="p">- Point to project.</param>
            /// <param name="pol">- Polygon element</param>
            abstract projectCoordsToPolygon: p: ResizeArray<obj option> * pol: JXG.Polygon -> ResizeArray<obj option>
            /// <summary>Calculates the coordinates of the projection of a given point on a given turtle. A turtle consists of
            /// one or more curves of curveType 'plot'. Uses {@link JXG.Math.Geometry.projectPointToCurve}.</summary>
            /// <param name="point">- Point to project.</param>
            /// <param name="turtle">- on that the point is projected.</param>
            /// <param name="board">- Reference to a board.</param>
            abstract projectPointToTurtle: point: JXG.Point * turtle: JXG.Turtle * ?board: JXG.Board -> JXG.Coords
            /// <summary>Trivial projection of a point to another point.</summary>
            /// <param name="point">- Point to project (not used).</param>
            /// <param name="dest">- Point on that the point is projected.</param>
            abstract projectPointToPoint: point: JXG.Point * dest: JXG.Point -> JXG.Coords
            abstract projectPointToBoard: point: U2<JXG.Point, JXG.Coords> * ?board: JXG.Board -> unit
            /// <summary>Calculates the distance of a point to a line. The point and the line are given by homogeneous
            /// coordinates. For lines this can be line.stdform.</summary>
            /// <param name="point">- Homogeneous coordinates of a point.</param>
            /// <param name="line">- Homogeneous coordinates of a line ([C,A,B] where A*x+B*y+C*z=0).</param>
            abstract distPointLine: point: ResizeArray<obj option> * line: ResizeArray<obj option> -> float
            /// <summary>Helper function to create curve which displays a Reuleaux polygons.</summary>
            /// <param name="points">- Array of points which should be the vertices of the Reuleaux polygon. Typically,
            /// these point list is the array vertices of a regular polygon.</param>
            /// <param name="nr">- Number of vertices</param>
            abstract reuleauxPolygon: points: ResizeArray<obj option> * nr: float -> ResizeArray<obj option>

    module Numerics =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Solves a system of linear equations given by A and b using the Gauss-Jordan-elimination.
            /// The algorithm runs in-place. I.e. the entries of A and b are changed.</summary>
            /// <param name="A">- Square matrix represented by an array of rows, containing the coefficients of the lineare equation system.</param>
            /// <param name="b">- A vector containing the linear equation system's right hand side.</param>
            abstract Gauss: A: ResizeArray<obj option> * b: ResizeArray<obj option> -> ResizeArray<obj option>
            /// <summary>Solves a system of linear equations given by the right triangular matrix R and vector b.</summary>
            /// <param name="R">- Right triangular matrix represented by an array of rows. All entries a_(i,j) with i &lt; j are ignored.</param>
            /// <param name="b">- Right hand side of the linear equation system.</param>
            /// <param name="canModify">- If true, the right hand side vector is allowed to be changed by this method.</param>
            abstract backwardSolve: R: ResizeArray<obj option> * b: ResizeArray<obj option> * ?canModify: bool -> ResizeArray<obj option>
            /// <summary>Computes the determinant of a square nxn matrix with the
            /// Gauss-Bareiss algorithm.</summary>
            /// <param name="mat">- Matrix.</param>
            abstract det: mat: ResizeArray<obj option> -> float
            /// <summary>Compute the Eigenvalues and Eigenvectors of a symmetric 3x3 matrix with the Jacobi method
            /// Adaption of a FORTRAN program by Ed Wilson, Dec. 25, 1990</summary>
            /// <param name="Ain">- A symmetric 3x3 matrix.</param>
            abstract Jacobi: Ain: ResizeArray<obj option> -> ResizeArray<obj option>
            /// <summary>Calculates the integral of function f over interval using Newton-Cotes-algorithm.</summary>
            /// <param name="interval">- The integration interval, e.g. [0, 3].</param>
            /// <param name="f">- A function which takes one argument of type number and returns a number.</param>
            /// <param name="config">- The algorithm setup. Accepted properties are number_of_nodes of type number and integration_type
            /// with value being either 'trapez', 'simpson', or 'milne'.</param>
            abstract NewtonCotes: interval: ResizeArray<obj option> * f: (ResizeArray<obj option> -> obj option) * ?config: NewtonCotesConfig -> float
            /// <summary>Calculates the integral of function f over interval using Romberg iteration.</summary>
            /// <param name="interval">- The integration interval, e.g. [0, 3].</param>
            /// <param name="f">- A function which takes one argument of type number and returns a number.</param>
            /// <param name="config">- The algorithm setup. Accepted properties are max_iterations of type number and precision eps.</param>
            abstract Romberg: interval: ResizeArray<obj option> * f: (ResizeArray<obj option> -> obj option) * ?config: RombergConfig -> float
            /// <summary>Calculates the integral of function f over interval using Gauss-Legendre quadrature.</summary>
            /// <param name="interval">- The integration interval, e.g. [0, 3].</param>
            /// <param name="f">- A function which takes one argument of type number and returns a number.</param>
            /// <param name="config">- The algorithm setup. Accepted property is the order n of type number. n is allowed to take
            /// values between 2 and 18, default value is 12.</param>
            abstract GaussLegendre: interval: ResizeArray<obj option> * f: (ResizeArray<obj option> -> obj option) * ?config: GaussLegendreConfig -> float
            /// <summary>15 point Gauss-Kronrod quadrature algorithm, see the library QUADPACK</summary>
            /// <param name="interval">- The integration interval, e.g. [0, 3].</param>
            /// <param name="f">- A function which takes one argument of type number and returns a number.</param>
            /// <param name="resultObj">- Object returning resultObj.abserr, resultObj.resabs, resultObj.resasc. See the library
            /// QUADPACK for an explanation.</param>
            abstract GaussKronrod15: interval: ResizeArray<obj option> * f: (ResizeArray<obj option> -> obj option) * resultObj: obj option -> float
            /// <summary>21 point Gauss-Kronrod quadrature algorithm, see the library QUADPACK</summary>
            /// <param name="interval">- The integration interval, e.g. [0, 3].</param>
            /// <param name="f">- A function which takes one argument of type number and returns a number.</param>
            /// <param name="resultObj">- Object returning resultObj.abserr, resultObj.resabs, resultObj.resasc. See the library
            /// QUADPACK for an explanation.</param>
            abstract GaussKronrod21: interval: ResizeArray<obj option> * f: (ResizeArray<obj option> -> obj option) * resultObj: obj option -> float
            /// <summary>31 point Gauss-Kronrod quadrature algorithm, see the library QUADPACK</summary>
            /// <param name="interval">- The integration interval, e.g. [0, 3].</param>
            /// <param name="f">- A function which takes one argument of type number and returns a number.</param>
            /// <param name="resultObj">- Object returning resultObj.abserr, resultObj.resabs, resultObj.resasc. See the library
            /// QUADPACK for an explanation.</param>
            abstract GaussKronrod31: interval: ResizeArray<obj option> * f: (ResizeArray<obj option> -> obj option) * resultObj: obj option -> float
            /// <summary>Quadrature algorithm qag from QUADPACK.
            /// Internal method used in {@link JXG.Math.Numerics.GaussKronrod15},
            /// {@link JXG.Math.Numerics.GaussKronrod21},
            /// {@link JXG.Math.Numerics.GaussKronrod31}.</summary>
            /// <param name="interval">- The integration interval, e.g. [0, 3].</param>
            /// <param name="f">- A function which takes one argument of type number and returns a number.</param>
            /// <param name="config">- The algorithm setup. Accepted propert are max. recursion limit of type number,
            /// and epsrel and epsabs, the relative and absolute required precision of type number. Further,
            /// q the internal quadrature sub-algorithm of type function.</param>
            abstract Qag: interval: ResizeArray<obj option> * f: (ResizeArray<obj option> -> obj option) * ?config: QagConfig -> float
            /// <summary>Integral of function f over interval.</summary>
            /// <param name="interval">- The integration interval, e.g. [0, 3].</param>
            /// <param name="f">- A function which takes one argument of type number and returns a number.</param>
            abstract I: interval: ResizeArray<obj option> * f: (ResizeArray<obj option> -> obj option) -> float
            /// <summary>Newton's method to find roots of a funtion in one variable.</summary>
            /// <param name="f">- We search for a solution of f(x)=0.</param>
            /// <param name="x">- initial guess for the root, i.e. start value.</param>
            /// <param name="context">- optional object that is treated as "this" in the function body. This is useful if
            /// the function is a method of an object and contains a reference to its parent object via "this".</param>
            abstract Newton: f: (ResizeArray<obj option> -> obj option) * x: float * context: obj option -> float
            /// <summary>Abstract method to find roots of univariate functions, which - for the time being -
            /// is an alias for {@link JXG.Math.Numerics.fzero}</summary>
            /// <param name="f">- We search for a solution of f(x)=0.</param>
            /// <param name="x">- initial guess for the root, i.e. starting value, or start interval enclosing the root.</param>
            /// <param name="context">- optional object that is treated as "this" in the function body. This is useful if
            /// the function is a method of an object and contains a reference to its parent object via "this".</param>
            abstract root: f: (ResizeArray<obj option> -> obj option) * x: float * context: obj option -> float
            /// <summary>Compute an intersection of the curves c1 and c2
            /// with a generalized Newton method.
            /// We want to find values t1, t2 such that
            /// c1(t1) = c2(t2), i.e.
            /// (c1_x(t1)-c2_x(t2),c1_y(t1)-c2_y(t2)) = (0,0).
            /// We set
            /// (e,f) := (c1_x(t1)-c2_x(t2),c1_y(t1)-c2_y(t2))
            /// 
            /// The Jacobian J is defined by
            /// J = (a, b)
            ///   (c, d)
            /// where
            /// a = c1_x'(t1)
            /// b = -c2_x'(t2)
            /// c = c1_y'(t1)
            /// d = -c2_y'(t2)
            /// 
            /// The inverse J^(-1) of J is equal to
            /// (d, -b)/
            /// (-c, a) / (ad-bc)
            /// 
            /// Then, (t1new, t2new) := (t1,t2) - J^(-1)*(e,f).
            /// If the function meetCurveCurve possesses the properties
            /// t1memo and t2memo then these are taken as start values
            /// for the Newton algorithm.
            /// After stopping of the Newton algorithm the values of t1 and t2 are stored in
            /// t1memo and t2memo.</summary>
            /// <param name="c1">- Curve, Line or Circle</param>
            /// <param name="c2">- Curve, Line or Circle</param>
            /// <param name="t1ini">- start value for t1</param>
            /// <param name="t2ini">- start value for t2</param>
            abstract generalizedNewton: c1: JXG.Curve * c2: JXG.Curve * t1ini: float * t2ini: float -> JXG.Coords
            /// <summary>Returns the Lagrange polynomials for curves with equidistant nodes, see
            /// Jean-Paul Berrut, Lloyd N. Trefethen: Barycentric Lagrange Interpolation,
            /// SIAM Review, Vol 46, No 3, (2004) 501-517.
            /// The graph of the parametric curve [x(t),y(t)] runs through the given points.</summary>
            /// <param name="p">- Array of JXG.Points</param>
            abstract Neville: p: ResizeArray<obj option> -> ResizeArray<obj option>
            /// <summary>Calculates second derivatives at the given knots.</summary>
            /// <param name="x">- x values of knots</param>
            /// <param name="y">- y values of knots</param>
            abstract splineDef: x: ResizeArray<obj option> * y: ResizeArray<obj option> -> ResizeArray<obj option>
            /// <summary>Evaluate points on spline.</summary>
            /// <param name="x">- x values of knots</param>
            /// <param name="y">- y values of knots</param>
            /// <param name="F">- Second derivatives at knots, calculated by {@link JXG.Math.Numerics.splineDef}</param>
            abstract splineEval: x: ResizeArray<obj option> * y: ResizeArray<obj option> * F: ResizeArray<obj option> -> obj option
            /// <summary>Generate a string containing the function term of a polynomial.</summary>
            /// <param name="coeffs">- Coefficients of the polynomial. The position i belongs to x^i.</param>
            /// <param name="deg">- Degree of the polynomial</param>
            /// <param name="varname">- Name of the variable (usually 'x')</param>
            /// <param name="prec">- Precision</param>
            abstract generatePolynomialTerm: coeffs: ResizeArray<obj option> * deg: float * varname: string * prec: float -> string
            /// <summary>Computes the polynomial through a given set of coordinates in Lagrange form.
            /// Returns the Lagrange polynomials, see
            /// Jean-Paul Berrut, Lloyd N. Trefethen: Barycentric Lagrange Interpolation,
            /// SIAM Review, Vol 46, No 3, (2004) 501-517.</summary>
            /// <param name="p">- Array of JXG.Points</param>
            abstract lagrangePolynomial: p: ResizeArray<obj option> -> (ResizeArray<obj option> -> obj option)
            /// <summary>Computes the cubic cardinal spline curve through a given set of points. The curve
            /// is uniformly parametrized.
            /// Two artificial control points at the beginning and the end are added.
            /// 
            /// The implementation (especially  the centripetal parametrization) is from
            /// http://stackoverflow.com/questions/9489736/catmull-rom-curve-with-no-cusps-and-no-self-intersections .</summary>
            /// <param name="points">- Array consisting of JXG.Points.</param>
            /// <param name="tau">- The tension parameter, either a constant number or a function returning a number. This number is between 0 and 1.
            /// tau=1/2 give Catmull-Rom splines.</param>
            /// <param name="type">- (Optional) parameter which allows to choose between "uniform" (default) and
            /// "centripetal" parameterization. Thus the two possible values are "uniform" or "centripetal".</param>
            abstract CardinalSpline: points: ResizeArray<obj option> * tau: U2<float, (ResizeArray<obj option> -> obj option)> * ``type``: string -> ResizeArray<obj option>
            /// <summary>Computes the cubic Catmull-Rom spline curve through a given set of points. The curve
            /// is uniformly parametrized. The curve is the cardinal spline curve for tau=0.5.
            /// Two artificial control points at the beginning and the end are added.</summary>
            /// <param name="points">- Array consisting of JXG.Points.</param>
            /// <param name="type">- (Optional) parameter which allows to choose between "uniform" (default) and
            /// "centripetal" parameterization. Thus the two possible values are "uniform" or "centripetal".</param>
            abstract CatmullRomSpline: points: ResizeArray<obj option> * ``type``: string -> ResizeArray<obj option>
            /// <summary>Computes the regression polynomial of a given degree through a given set of coordinates.
            /// Returns the regression polynomial function.</summary>
            /// <param name="dataX">- Array containing either the x-coordinates of the data set or both coordinates in
            /// an array of {@link JXG.Point}s or {@link JXG.Coords}.
            /// In the latter case, the <tt>dataY</tt> parameter will be ignored.</param>
            /// <param name="dataY">- Array containing the y-coordinates of the data set,</param>
            abstract regressionPolynomial: dataX: ResizeArray<obj option> * dataY: ResizeArray<obj option> -> (ResizeArray<obj option> -> obj option)
            /// <summary>Computes the cubic Bezier curve through a given set of points.</summary>
            /// <param name="points">- Array consisting of 3*k+1 {@link JXG.Points}.
            /// The points at position k with k mod 3 = 0 are the data points,
            /// points at position k with k mod 3 = 1 or 2 are the control points.</param>
            abstract bezier: points: ResizeArray<obj option> -> ResizeArray<obj option>
            /// <summary>Computes the B-spline curve of order k (order = degree+1) through a given set of points.</summary>
            /// <param name="points">- Array consisting of JXG.Points.</param>
            /// <param name="order">- Order of the B-spline curve.</param>
            abstract bspline: points: ResizeArray<obj option> * order: float -> ResizeArray<obj option>
            /// <summary>Numerical (symmetric) approximation of derivative. suspendUpdate is piped through,
            /// see {@link JXG.Curve#updateCurve}
            /// and {@link JXG.Curve#hasPoint}.</summary>
            /// <param name="f">- Function in one variable to be differentiated.</param>
            /// <param name="obj">- Optional object that is treated as "this" in the function body. This is useful, if the function is a
            /// method of an object and contains a reference to its parent object via "this".</param>
            abstract D: f: (ResizeArray<obj option> -> obj option) * ?obj: obj -> (ResizeArray<obj option> -> obj option)
            /// <summary>Helper function to create curve which displays Riemann sums.
            /// Compute coordinates for the rectangles showing the Riemann sum.</summary>
            /// <param name="n">- number of rectangles.</param>
            /// <param name="type">- Type of approximation. Possible values are: 'left', 'right', 'middle', 'lower', 'upper', 'random', 'simpson', or 'trapezoidal'.</param>
            /// <param name="start">- Left border of the approximation interval</param>
            /// <param name="end">- Right border of the approximation interval</param>
            abstract riemann: n: float * ``type``: string * start: float * ``end``: float -> ResizeArray<obj option>
            /// <summary>Approximate the integral by Riemann sums.
            /// Compute the area described by the riemann sum rectangles.
            /// 
            /// If there is an element of type {@link Riemannsum}, then it is more efficient
            /// to use the method JXG.Curve.Value() of this element instead.</summary>
            /// <param name="f">- Function or array of two functions.
            /// If f is a function the integral of this function is approximated by the Riemann sum.
            /// If f is an array consisting of two functions the area between the two functions is approximated
            /// by the Riemann sum.</param>
            /// <param name="n">- number of rectangles.</param>
            /// <param name="type">- Type of approximation. Possible values are: 'left', 'right', 'middle', 'lower', 'upper', 'random', 'simpson' or 'trapezoidal'.</param>
            /// <param name="start">- Left border of the approximation interval</param>
            /// <param name="end">- Right border of the approximation interval</param>
            abstract riemannsum: f: Function_Array * n: float * ``type``: string * start: float * ``end``: float -> float
            /// <summary>Solve initial value problems numerically using Runge-Kutta-methods.
            /// See {@link http://en.wikipedia.org/wiki/Runge-Kutta_methods} for more information on the algorithm.</summary>
            /// <param name="x0">- Initial value vector. If the problem is of one-dimensional, the initial value also has to be given in an array.</param>
            /// <param name="I">- Interval on which to integrate.</param>
            /// <param name="N">- Number of evaluation points.</param>
            /// <param name="f">- Function describing the right hand side of the first order ordinary differential equation, i.e. if the ode
            /// is given by the equation <pre>dx/dt = f(t, x(t)).</pre> So f has to take two parameters, a number <tt>t</tt> and a
            /// vector <tt>x</tt>, and has to return a vector of the same dimension as <tt>x</tt> has.</param>
            abstract rungeKutta: x0: ResizeArray<obj option> * I: ResizeArray<obj option> * N: float * f: (ResizeArray<obj option> -> obj option) -> ResizeArray<obj option>
            abstract maxIterationsRoot: float
            abstract maxIterationsMinimize: float
            /// <summary>Find zero of an univariate function f.</summary>
            /// <param name="f">- Function, whose root is to be found</param>
            /// <param name="object">- Parent object in case f is method of it</param>
            abstract fzero: f: (ResizeArray<obj option> -> obj option) * ``object``: obj option -> float
            /// <summary>Find minimum of an univariate function f.
            /// <p>
            /// Algorithm:
            /// G.Forsythe, M.Malcolm, C.Moler, Computer methods for mathematical
            /// computations. M., Mir, 1980, p.180 of the Russian edition</summary>
            /// <param name="f">- Function, whose minimum is to be found</param>
            /// <param name="x0">- Start interval enclosing the minimum</param>
            /// <param name="context">- Parent object in case f is method of it</param>
            abstract fminbr: f: (ResizeArray<obj option> -> obj option) * x0: ResizeArray<obj option> * context: obj option -> float
            /// <summary>Implements the Ramer-Douglas-Peucker algorithm.
            /// It discards points which are not necessary from the polygonal line defined by the point array
            /// pts. The computation is done in screen coordinates.
            /// Average runtime is O(nlog(n)), worst case runtime is O(n^2), where n is the number of points.</summary>
            /// <param name="pts">- Array of {@link JXG.Coords}</param>
            /// <param name="eps">- If the absolute value of a given number <tt>x</tt> is smaller than <tt>eps</tt> it is considered to be equal <tt>0</tt>.</param>
            abstract RamerDouglasPeucker: pts: ResizeArray<obj option> * eps: float -> ResizeArray<obj option>
            /// Old name for the implementation of the Ramer-Douglas-Peucker algorithm.
            abstract RamerDouglasPeuker: unit -> unit
            /// <summary>Implements the Visvalingam-Whyatt algorithm.
            /// See M. Visvalingam, J. D. Whyatt:
            /// "Line generalisation by repeated elimination of the smallest area", C.I.S.R.G Discussion paper 10, July 1992
            /// 
            /// The algorithm discards points which are not necessary from the polygonal line defined by the point array
            /// pts (consisting of type JXG.Coords).</summary>
            /// <param name="pts">- Array of {@link JXG.Coords}</param>
            /// <param name="numPoints">- Number of remaining intermediate points. The first and the last point of the original points will
            /// be taken in any case.</param>
            abstract Visvalingam: pts: ResizeArray<obj option> * numPoints: float -> ResizeArray<obj option>

        type [<AllowNullLiteral>] NewtonCotesConfig =
            abstract number_of_nodes: float option with get, set
            abstract integration_type: string option with get, set

        type [<AllowNullLiteral>] RombergConfig =
            abstract max_iterations: float option with get, set
            abstract eps: float option with get, set

        type [<AllowNullLiteral>] GaussLegendreConfig =
            abstract n: float option with get, set

        type [<AllowNullLiteral>] QagConfig =
            abstract limit: float option with get, set
            abstract epsrel: float option with get, set
            abstract epsabs: float option with get, set
            abstract q: float option with get, set

    module Poly =

        type [<AllowNullLiteral>] IExports =
            abstract Ring: RingStatic
            abstract Monomial: MonomialStatic
            abstract Polynomial: PolynomialStatic

        /// Define a polynomial ring over R.
        type [<AllowNullLiteral>] Ring =
            interface end

        /// Define a polynomial ring over R.
        type [<AllowNullLiteral>] RingStatic =
            [<Emit "new $0($1...)">] abstract Create: variables: ResizeArray<obj option> -> Ring

        /// Define a monomial over the polynomial ring <tt>ring</tt>.
        type [<AllowNullLiteral>] Monomial =
            interface end

        /// Define a monomial over the polynomial ring <tt>ring</tt>.
        type [<AllowNullLiteral>] MonomialStatic =
            [<Emit "new $0($1...)">] abstract Create: ring: JXG.Math.Poly.Ring * coefficient: float * exponents: ResizeArray<obj option> -> Monomial
            /// Creates a deep copy of the monomial.
            abstract copy: unit -> JXG.Math.Poly.Monomial
            /// Print the monomial.
            abstract print: unit -> string

        /// A polynomial is a sum of monomials.
        type [<AllowNullLiteral>] Polynomial =
            interface end

        /// A polynomial is a sum of monomials.
        type [<AllowNullLiteral>] PolynomialStatic =
            [<Emit "new $0($1...)">] abstract Create: ring: JXG.Math.Poly.Ring * str: string -> Polynomial
            /// <summary>Find a monomial with the given signature, i.e. exponent vector.</summary>
            /// <param name="sig">- An array of numbers</param>
            abstract findSignature: ``sig``: ResizeArray<obj option> -> float
            /// <summary>Adds a monomial to the polynomial. Checks the existing monomials for the added
            /// monomial's signature and just adds the coefficient if one is found.</summary>
            /// <param name="factor">- Either <tt>1</tt> or <tt>-1</tt>.</param>
            abstract addSubMonomial: m: JXG.Math.Poly.Monomial * factor: float -> unit
            /// Adds another polynomial or monomial to this one and merges them by checking for the
            /// signature of each new monomial in the existing monomials.
            abstract add: mp: U2<JXG.Math.Poly.Polynomial, JXG.Math.Poly.Monomial> -> unit
            /// Subtracts another polynomial or monomial from this one and merges them by checking for the
            /// signature of each new monomial in the existing monomials.
            abstract sub: mp: U2<JXG.Math.Poly.Polynomial, JXG.Math.Poly.Monomial> -> unit
            /// Creates a deep copy of the polynomial.
            abstract copy: unit -> JXG.Math.Poly.Polynomial
            /// Prints the polynomial.
            abstract print: unit -> string

    module Statistics =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Sums up all elements of the given array.</summary>
            /// <param name="arr">- An array of numbers.</param>
            abstract sum: arr: ResizeArray<obj option> -> float
            /// <summary>Multiplies all elements of the given array.</summary>
            /// <param name="arr">- An array of numbers.</param>
            abstract prod: arr: ResizeArray<obj option> -> float
            /// Determines the mean value of the values given in an array.
            abstract mean: arr: ResizeArray<obj option> -> float
            /// <summary>The median of a finite set of values is the value that divides the set
            /// into two equal sized subsets.</summary>
            /// <param name="arr">- The set of values.</param>
            abstract median: arr: ResizeArray<obj option> -> float
            /// Bias-corrected sample variance. A variance is a measure of how far a
            /// set of numbers are spread out from each other.
            abstract variance: arr: ResizeArray<obj option> -> float
            /// Determines the <strong>s</strong>tandard <strong>d</strong>eviation which shows how much
            /// variation there is from the average value of a set of numbers.
            abstract sd: arr: ResizeArray<obj option> -> float
            /// <summary>Weighted mean value is basically the same as {@link JXG.Math.Statistics.mean} but here the values
            /// are weighted, i.e. multiplied with another value called <em>weight</em>. The weight values are given
            /// as a second array with the same length as the value array..</summary>
            /// <param name="arr">- Set of alues.</param>
            /// <param name="w">- Weight values.</param>
            abstract weightedMean: arr: ResizeArray<obj option> * w: ResizeArray<obj option> -> float
            /// Extracts the maximum value from the array.
            abstract max: arr: ResizeArray<obj option> -> float
            /// Extracts the minimum value from the array.
            abstract min: arr: ResizeArray<obj option> -> float
            /// Determines the lowest and the highest value from the given array.
            abstract range: arr: ResizeArray<obj option> -> ResizeArray<obj option>
            /// Determines the absolute value of every given value.
            abstract abs: arr: U2<ResizeArray<obj option>, float> -> U2<ResizeArray<obj option>, float>
            /// Adds up two (sequences of) values. If one value is an array and the other one is a number the number
            /// is added to every element of the array. If two arrays are given and the lengths don't match the shortest
            /// length is taken.
            abstract add: arr1: U2<ResizeArray<obj option>, float> * arr2: U2<ResizeArray<obj option>, float> -> U2<ResizeArray<obj option>, float>
            /// <summary>Divides two (sequences of) values. If two arrays are given and the lengths don't match the shortest length
            /// is taken.</summary>
            /// <param name="arr1">- Dividend</param>
            /// <param name="arr2">- Divisor</param>
            abstract div: arr1: U2<ResizeArray<obj option>, float> * arr2: U2<ResizeArray<obj option>, float> -> U2<ResizeArray<obj option>, float>
            abstract divide: unit -> unit
            /// <summary>Divides two (sequences of) values and returns the remainder. If two arrays are given and the lengths don't
            /// match the shortest length is taken.</summary>
            /// <param name="arr1">- Dividend</param>
            /// <param name="arr2">- Divisor</param>
            /// <param name="math">- Mathematical mod or symmetric mod? Default is symmetric, the JavaScript <tt>%</tt> operator.</param>
            abstract ``mod``: arr1: U2<ResizeArray<obj option>, float> * arr2: U2<ResizeArray<obj option>, float> * ?math: bool -> U2<ResizeArray<obj option>, float>
            /// Multiplies two (sequences of) values. If one value is an array and the other one is a number the number
            /// is multiplied to every element of the array. If two arrays are given and the lengths don't match the shortest
            /// length is taken.
            abstract multiply: arr1: U2<ResizeArray<obj option>, float> * arr2: U2<ResizeArray<obj option>, float> -> U2<ResizeArray<obj option>, float>
            /// <summary>Subtracts two (sequences of) values. If two arrays are given and the lengths don't match the shortest
            /// length is taken.</summary>
            /// <param name="arr1">- Minuend</param>
            /// <param name="arr2">- Subtrahend</param>
            abstract subtract: arr1: U2<ResizeArray<obj option>, float> * arr2: U2<ResizeArray<obj option>, float> -> U2<ResizeArray<obj option>, float>
            /// <summary>The Theil-Sen estimator can be used to determine a more robust linear regression of a set of sample
            /// points than least squares regression in {@link JXG.Math.Numerics.regressionPolynomial}.</summary>
            /// <param name="coords">- Array of {@link JXG.Coords}.</param>
            abstract TheilSenRegression: coords: ResizeArray<obj option> -> ResizeArray<obj option>

    module Symbolic =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Generates symbolic coordinates for the part of a construction including all the elements from that
            /// a specific element depends of. These coordinates will be stored in GeometryElement.symbolic.</summary>
            /// <param name="board">- The board that's element get some symbolic coordinates.</param>
            /// <param name="element">- All ancestor of this element get symbolic coordinates.</param>
            /// <param name="variable">- Name for the coordinates, e.g. x or u.</param>
            /// <param name="append">- Method for how to append the number of the coordinates. Possible values are
            ///       'underscore' (e.g. x_2), 'none' (e.g. x2), 'brace' (e.g. x[2]).</param>
            abstract generateSymbolicCoordinatesPartial: board: JXG.Board * element: JXG.GeometryElement * variable: string * append: string -> float
            /// <summary>Clears all .symbolic.x and .symbolic.y members on every point of a given board.</summary>
            /// <param name="board">- The board that's points get cleared their symbolic coordinates.</param>
            abstract clearSymbolicCoordinates: board: JXG.Board -> unit
            /// <summary>Generates polynomials for a part of the construction including all the points from that
            /// a specific element depends of.</summary>
            /// <param name="board">- The board that's points polynomials will be generated.</param>
            /// <param name="element">- All points in the set of ancestors of this element are used to generate the set of polynomials.</param>
            abstract generatePolynomials: board: JXG.Board * element: JXG.GeometryElement * generateCoords: bool -> ResizeArray<obj option>
            /// <summary>Calculate geometric locus of a point given on a board. Invokes python script on server.</summary>
            /// <param name="board">- The board on which the point lies.</param>
            /// <param name="point">- The point that will be traced.</param>
            abstract geometricLocusByGroebnerBase: board: JXG.Board * point: JXG.Point -> ResizeArray<obj option>

module Options =

    type [<AllowNullLiteral>] IExports =
        abstract navbar: obj option
        abstract precision: obj option
        abstract layer: obj option
        abstract shortcuts: obj option

/// A JessieCode object provides an interface to the parser and stores all variables and objects used within a JessieCode script.
/// The optional argument <tt>code</tt> is interpreted after initializing. To evaluate more code after initializing a JessieCode instance
/// please use {@link JXG.JessieCode#parse}. For code snippets like single expressions use {@link JXG.JessieCode#snippet}.
type [<AllowNullLiteral>] CA =
    /// Declare all subnodes as math nodes,
    /// i.e recursively set node.isMath = true;
    abstract setMath: unit -> unit
    /// f = map (x) -> x*sin(x);
    /// Usages:
    /// h = D(f, x);
    /// h = map (x) -> D(f, x);
    abstract expandDerivatives: unit -> unit

/// A JessieCode object provides an interface to the parser and stores all variables and objects used within a JessieCode script.
/// The optional argument <tt>code</tt> is interpreted after initializing. To evaluate more code after initializing a JessieCode instance
/// please use {@link JXG.JessieCode#parse}. For code snippets like single expressions use {@link JXG.JessieCode#snippet}.
type [<AllowNullLiteral>] CAStatic =
    [<Emit "new $0($1...)">] abstract Create: ?code: string * ?geonext: bool -> CA

module GeonextParser =

    type [<AllowNullLiteral>] IExports =
        /// <summary>Converts expression of the form <i>leftop^rightop</i> into <i>Math.pow(leftop,rightop)</i>.</summary>
        /// <param name="te">- Expression of the form <i>leftop^rightop</i></param>
        abstract replacePow: te: string -> string
        /// <summary>Converts expression of the form <i>If(a,b,c)</i> into <i>(a)?(b):(c)/i>.</summary>
        /// <param name="te">- Expression of the form <i>If(a,b,c)</i></param>
        abstract replaceIf: te: string -> string
        /// <summary>Replace an element's name in terms by an element's id.</summary>
        /// <param name="term">- Term containing names of elements.</param>
        /// <param name="board">- Reference to the board the elements are on.</param>
        /// <param name="jc">- If true, all id's will be surrounded by <tt>$('</tt> and <tt>')</tt>.</param>
        abstract replaceNameById: term: string * board: JXG.Board * ?jc: bool -> string
        /// <summary>Replaces element ids in terms by element this.board.objects['id'].</summary>
        /// <param name="term">- A GEONE<sub>x</sub>T function string with JSXGraph ids in it.</param>
        abstract replaceIdByObj: term: string -> string
        /// <summary>Converts the given algebraic expression in GEONE<sub>x</sub>T syntax into an equivalent expression in JavaScript syntax.</summary>
        /// <param name="term">- Expression in GEONExT syntax</param>
        abstract geonext2JS: term: string * board: JXG.Board -> string
        /// <summary>Finds dependencies in a given term and resolves them by adding the
        /// dependent object to the found objects child elements.</summary>
        /// <param name="me">- Object depending on objects in given term.</param>
        /// <param name="term">- String containing dependencies for the given object.</param>
        /// <param name="board">- Reference to a board</param>
        abstract findDependencies: me: JXG.GeometryElement * term: string * ?board: JXG.Board -> unit
        /// <summary>Converts the given algebraic expression in GEONE<sub>x</sub>T syntax into an equivalent expression in JessieCode syntax.</summary>
        /// <param name="term">- Expression in GEONExT syntax</param>
        abstract gxt2jc: term: string * board: JXG.Board -> string

/// A JessieCode object provides an interface to the parser and stores all variables and objects used within a JessieCode script.
/// The optional argument <tt>code</tt> is interpreted after initializing. To evaluate more code after initializing a JessieCode instance
/// please use {@link JXG.JessieCode#parse}. For code snippets like single expressions use {@link JXG.JessieCode#snippet}.
type [<AllowNullLiteral>] JessieCode =
    /// The global scope.
    abstract scope: obj option with get, set
    /// Keeps track of all possible scopes every required.
    abstract scopes: ResizeArray<obj option> with get, set
    /// lhs flag, used by JXG.JessieCode#replaceNames
    abstract isLHS: bool with get, set
    /// The id of an HTML node in which innerHTML all warnings are stored (if no <tt>console</tt> object is available).
    abstract warnLog: string with get, set
    /// Store $log messages in case there's no console.
    abstract ``$log``: ResizeArray<obj option> with get, set
    /// Built-in functions and constants
    abstract builtIn: obj option with get, set
    /// The board which currently is used to create and look up elements.
    abstract board: JXG.Board with get, set
    /// Keep track of which element is created in which line.
    abstract lineToElement: obj option with get, set
    /// <summary>Create a new parse tree node.</summary>
    /// <param name="type">- Type of node, e.g. node_op, node_var, or node_const</param>
    /// <param name="value">- The nodes value, e.g. a variables value or a functions body.</param>
    /// <param name="children">- Arbitrary number of child nodes.</param>
    abstract node: ``type``: string * value: obj option * children: ResizeArray<obj option> -> unit
    /// <summary>Create a new parse tree node. Basically the same as node(), but this builds
    /// the children part out of an arbitrary number of parameters, instead of one
    /// array parameter.</summary>
    /// <param name="type">- Type of node, e.g. node_op, node_var, or node_const</param>
    /// <param name="value">- The nodes value, e.g. a variables value or a functions body.</param>
    /// <param name="children">- Arbitrary number of parameters; define the child nodes.</param>
    abstract createNode: ``type``: string * value: obj option * children: obj option -> unit
    /// Create a new scope.
    abstract pushScope: args: ResizeArray<obj option> -> obj option
    /// Remove the current scope and reinstate the previous scope
    abstract popScope: unit -> obj option
    /// Looks up an {@link JXG.GeometryElement} by its id.
    abstract getElementById: id: string -> JXG.GeometryElement
    /// Returns a element creator function which takes two parameters: the parents array and the attributes object.
    abstract creator: obj option with get, set
    /// <summary>Assigns a value to a variable in the current scope.</summary>
    /// <param name="vname">- Variable name</param>
    /// <param name="value">- Anything</param>
    abstract letvar: vname: string * value: obj option -> unit
    /// Checks if the given variable name can be found in the current scope chain.
    abstract isLocalVariable: vname: string -> obj option
    /// Checks if the given variable name is a parameter in any scope from the current to the global scope.
    abstract isParameter: vname: string -> obj option
    /// Checks if the given variable name is a valid creator method.
    abstract isCreator: vname: string -> bool
    /// Checks if the given variable identifier is a valid member of the JavaScript Math Object.
    abstract isMathMethod: vname: string -> bool
    /// Returns true if the given identifier is a builtIn variable/function.
    abstract isBuiltIn: vname: string -> bool
    /// <summary>Looks up the value of the given variable.</summary>
    /// <param name="vname">- Name of the variable</param>
    /// <param name="local">- Only look up the internal symbol table and don't look for
    /// the <tt>vname</tt> in Math or the element list.</param>
    abstract getvar: vname: string * ?local: bool -> unit
    /// Look up the value of a local variable.
    abstract resolve: vname: string -> obj option
    /// <summary>TODO this needs to be called from JS and should not generate JS code
    /// Looks up a variable identifier in various tables and generates JavaScript code that could be eval'd to get the value.</summary>
    /// <param name="vname">- Identifier</param>
    /// <param name="local">- Don't resolve ids and names of elements</param>
    abstract getvarJS: vname: string * ?local: bool * ?withProps: bool -> unit
    /// Adds the property <tt>isMap</tt> to a function and sets it to true.
    abstract makeMap: f: (ResizeArray<obj option> -> obj option) -> (ResizeArray<obj option> -> obj option)
    /// Converts a node type <tt>node_op</tt> and value <tt>op_map</tt> or <tt>op_function</tt> into a executable
    /// function.
    abstract defineFunction: node: obj option -> (ResizeArray<obj option> -> obj option)
    /// <summary>Merge all attribute values given with an element creator into one object.</summary>
    /// <param name="o">- An arbitrary number of objects</param>
    abstract mergeAttributes: o: obj option -> obj option
    /// Sets the property <tt>what</tt> of <tt>o</tt> to <tt>value</tt>
    abstract setProp: o: U2<JXG.Point, JXG.Text> * what: string * value: obj option -> unit
    /// <summary>Generic method to parse JessieCode.
    /// This consists of generating an AST with parser.parse,
    /// apply simplifying rules from CA and
    /// manipulate the AST according to the second parameter "cmd".</summary>
    /// <param name="code">- JessieCode code to be parsed</param>
    /// <param name="cmd">- Type of manipulation to be done with AST</param>
    /// <param name="geonext">- Geonext compatibility mode.</param>
    /// <param name="dontstore">- If false, the code string is stored in this.code.</param>
    abstract _genericParse: code: string * cmd: string * ?geonext: bool * dontstore: bool -> obj option
    /// <summary>Parses JessieCode.
    /// This consists of generating an AST with parser.parse, apply simplifying rules
    /// from CA and executing the ast by calling this.execute(ast).</summary>
    /// <param name="code">- JessieCode code to be parsed</param>
    /// <param name="geonext">- Geonext compatibility mode.</param>
    /// <param name="dontstore">- If false, the code string is stored in this.code.</param>
    abstract parse: code: string * ?geonext: bool * dontstore: bool -> obj option
    /// <summary>Manipulate JessieCode.
    /// This consists of generating an AST with parser.parse,
    /// apply simlifying rules from CA
    /// and compile the AST back to JessieCode.</summary>
    /// <param name="code">- JessieCode code to be parsed</param>
    /// <param name="geonext">- Geonext compatibility mode.</param>
    /// <param name="dontstore">- If false, the code string is stored in this.code.</param>
    abstract manipulate: code: string * ?geonext: bool * dontstore: bool -> string
    /// <summary>Get abstract syntax tree (AST) from JessieCode code.
    /// This consists of generating an AST with parser.parse.</summary>
    /// <param name="geonext">- Geonext compatibility mode.</param>
    abstract getAST: code: string * ?geonext: bool * dontstore: bool -> Node
    /// <summary>Parses a JessieCode snippet, e.g. "3+4", and wraps it into a function, if desired.</summary>
    /// <param name="code">- A small snippet of JessieCode. Must not be an assignment.</param>
    /// <param name="funwrap">- If true, the code is wrapped in a function.</param>
    /// <param name="varname">- Name of the parameter(s)</param>
    /// <param name="geonext">- Geonext compatibility mode.</param>
    abstract snippet: code: string * funwrap: bool * varname: string * ?geonext: bool -> unit
    /// Traverses through the given subtree and changes all values of nodes with the replaced flag set by
    /// {@link JXG.JessieCode#replaceNames} to the name of the element (if not empty).
    abstract replaceIDs: node: obj option -> unit
    /// Traverses through the given subtree and changes all elements referenced by names through referencing them by ID.
    /// An identifier is only replaced if it is not found in all scopes above the current scope and if it
    /// has not been blacklisted within the codeblock determined by the given subtree.
    abstract replaceNames: node: obj option -> unit
    /// Replaces node_var nodes with node_op&gt;op_execfun nodes, calling the internal $() function with the id of the
    /// element accessed by the node_var node.
    abstract createReplacementNode: node: obj option -> obj option
    /// <summary>Search the parse tree below <tt>node</tt> for <em>stationary</em> dependencies, i.e. dependencies hard coded into
    /// the function.</summary>
    /// <param name="result">- An object where the referenced elements will be stored. Access key is their id.</param>
    abstract collectDependencies: node: obj option * result: obj option -> unit
    /// Resolves the lefthand side of an assignment operation
    abstract getLHS: node: obj option -> obj option
    /// This is used as the global X() function.
    abstract X: e: U2<JXG.Point, JXG.Text> -> float
    /// This is used as the global Y() function.
    abstract Y: e: U2<JXG.Point, JXG.Text> -> float
    /// This is used as the global V() function.
    abstract V: e: U2<Glider, Slider> -> float
    /// This is used as the global L() function.
    abstract L: e: JXG.Line -> float
    /// This is used as the global dist() function.
    abstract dist: p1: JXG.Point * p2: JXG.Point -> float
    /// + operator implementation
    abstract add: a: U3<float, ResizeArray<obj option>, JXG.Point> * b: U3<float, ResizeArray<obj option>, JXG.Point> -> U2<float, ResizeArray<obj option>>
    /// - operator implementation
    abstract sub: a: U3<float, ResizeArray<obj option>, JXG.Point> * b: U3<float, ResizeArray<obj option>, JXG.Point> -> U2<float, ResizeArray<obj option>>
    /// unary - operator implementation
    abstract neg: a: U3<float, ResizeArray<obj option>, JXG.Point> -> U2<float, ResizeArray<obj option>>
    /// Multiplication of vectors and numbers
    abstract mul: a: U2<float, ResizeArray<obj option>> * b: U2<float, ResizeArray<obj option>> -> U2<float, ResizeArray<obj option>>
    /// Implementation of the / operator.
    abstract div: a: U2<float, ResizeArray<obj option>> * b: float -> U2<float, ResizeArray<obj option>>
    /// Implementation of the % operator.
    abstract ``mod``: a: U2<float, ResizeArray<obj option>> * b: float -> U2<float, ResizeArray<obj option>>
    /// Pow function wrapper to allow direct usage of sliders.
    abstract pow: a: U2<float, Slider> * b: U2<float, Slider> -> float
    /// <summary>Implementation of the ?: operator</summary>
    /// <param name="cond">- Condition</param>
    abstract ifthen: cond: bool * v1: obj option * v2: obj option -> obj option
    /// Implementation of the delete() builtin function
    abstract del: element: JXG.GeometryElement -> unit
    /// Implementation of the use() builtin function
    abstract ``use``: board: string -> unit
    /// <summary>Find the first symbol to the given value from the given scope upwards.</summary>
    /// <param name="v">- Value</param>
    /// <param name="scope">- The scope, default is to start with current scope (-1).</param>
    abstract findSymbol: v: obj option * ?scope: float -> ResizeArray<obj option>
    /// Import modules into a JessieCode script.
    abstract importModule: ``module``: string -> unit
    /// Defines built in methods and constants.
    abstract defineBuiltIn: unit -> obj option
    /// <summary>Throws an exception with the given error message.</summary>
    /// <param name="msg">- Error message</param>
    abstract _error: msg: string -> unit
    /// Output a warning message using {@link JXG#debug} and precedes the message with "Warning: ".
    abstract _warn: msg: string -> unit

/// A JessieCode object provides an interface to the parser and stores all variables and objects used within a JessieCode script.
/// The optional argument <tt>code</tt> is interpreted after initializing. To evaluate more code after initializing a JessieCode instance
/// please use {@link JXG.JessieCode#parse}. For code snippets like single expressions use {@link JXG.JessieCode#snippet}.
type [<AllowNullLiteral>] JessieCodeStatic =
    [<Emit "new $0($1...)">] abstract Create: ?code: string * ?geonext: bool -> JessieCode

/// <p>This class defines the interface to the graphics part of JSXGraph. This class is an abstract class, it
/// actually does not render anything. This is up to the {@link JXG.SVGRenderer}, {@link JXG.VMLRenderer},
/// and {@link JXG.CanvasRenderer} classes. We strongly discourage you from using the methods in these classes
/// directly. Only the methods which are defined in this class and are not marked as private are guaranteed
/// to exist in any renderer instance you can access via {@link JXG.Board#renderer}. But not all methods may
/// work as expected.</p>
/// <p>The methods of this renderer can be divided into different categories:
/// <dl>
///   <dt>Draw basic elements</dt>
///   <dd>In this category we find methods to draw basic elements like {@link JXG.Point}, {@link JXG.Line},
///   and {@link JXG.Curve} as well as assisting methods tightly bound to these basic painters. You do not
///   need to implement these methods in a descendant renderer but instead implement the primitive drawing
///   methods described below. This approach is encouraged when you're using a XML based rendering engine
///   like VML and SVG. If you want to use a bitmap based rendering technique you are supposed to override
///   these methods instead of the primitive drawing methods.</dd>
///   <dt>Draw primitives</dt>
///   <dd>This category summarizes methods to handle primitive nodes. As creation and management of these nodes
///   is different among different the rendering techniques most of these methods are purely virtual and need
///   proper implementation if you choose to not overwrite the basic element drawing methods.</dd>
///   <dt>Attribute manipulation</dt>
///   <dd>In XML based renders you have to manipulate XML nodes and their attributes to change the graphics.
///   For that purpose attribute manipulation methods are defined to set the color, opacity, and other things.
///   Please note that some of these methods are required in bitmap based renderers, too, because some elements
///   like {@link JXG.Text} can be HTML nodes floating over the construction.</dd>
///   <dt>Renderer control</dt>
///   <dd>Methods to clear the drawing board or to stop and to resume the rendering engine.</dd>
/// </dl></p>
type [<AllowNullLiteral>] AbstractRenderer =
    /// The vertical offset for {@link Text} elements. Every {@link Text} element will
    /// be placed this amount of pixels below the user given coordinates.
    abstract vOffsetText: float with get, set
    /// If this property is set to <tt>true</tt> the visual properties of the elements are updated
    /// on every update. Visual properties means: All the stuff stored in the
    /// {@link JXG.GeometryElement#visProp} property won't be set if enhancedRendering is <tt>false</tt>
    abstract enhancedRendering: bool with get, set
    /// The HTML element that stores the JSXGraph board in it.
    abstract container: Node with get, set
    /// This is used to easily determine which renderer we are using
    abstract ``type``: string with get, set
    /// <summary>Draws a point on the {@link JXG.Board}.</summary>
    /// <param name="el">- Reference to a {@link JXG.Point} object that has to be drawn.</param>
    abstract drawPoint: el: JXG.Point -> unit
    /// <summary>Updates visual appearance of the renderer element assigned to the given {@link JXG.Point}.</summary>
    /// <param name="el">- Reference to a {@link JXG.Point} object, that has to be updated.</param>
    abstract updatePoint: el: JXG.Point -> unit
    /// <summary>Changes the style of a {@link JXG.Point}. This is required because the point styles differ in what
    /// elements have to be drawn, e.g. if the point is marked by a "x" or a "+" two lines are drawn, if
    /// it's marked by spot a circle is drawn. This method removes the old renderer element(s) and creates
    /// the new one(s).</summary>
    /// <param name="el">- Reference to a {@link JXG.Point} object, that's style is changed.</param>
    abstract changePointStyle: el: JXG.Point -> unit
    /// <summary>Draws a line on the {@link JXG.Board}.</summary>
    /// <param name="el">- Reference to a line object, that has to be drawn.</param>
    abstract drawLine: el: JXG.Line -> unit
    /// <summary>Updates visual appearance of the renderer element assigned to the given {@link JXG.Line}.</summary>
    /// <param name="el">- Reference to the {@link JXG.Line} object that has to be updated.</param>
    abstract updateLine: el: JXG.Line -> unit
    /// <summary>Shorten the line length such that the arrow head touches
    /// the start or end point and such that the arrow head ends exactly
    /// at the start / end position of the line.</summary>
    /// <param name="el">- Reference to the line object that gets arrow heads.</param>
    /// <param name="c1">- Coords of the first point of the line (after {@link JXG.Geometry#calcStraight}).</param>
    /// <param name="c2">- Coords of the second point of the line (after {@link JXG.Geometry#calcStraight}).</param>
    /// <param name="doHighlight">- true if the object is to be highlighted, false otherwise. This parameter
    /// is necessary for the attribute highlightSize of the arrow heads.</param>
    abstract getPositionArrowHead: el: JXG.Line * c1: JXG.Coords * c2: JXG.Coords * doHighlight: bool -> obj option
    /// <summary>Update the line endings (linecap) of a straight line from its attribute
    /// 'linecap'.
    /// Possible values for the attribute 'linecap' are: 'butt', 'round', 'square'.
    /// The default value is 'butt'. Not available for VML renderer.</summary>
    /// <param name="element">- A arbitrary line.</param>
    abstract setLineCap: element: JXG.Line -> unit
    /// <summary>Creates a rendering node for ticks added to a line.</summary>
    /// <param name="el">- A arbitrary line.</param>
    abstract drawTicks: el: JXG.Line -> unit
    /// <summary>Update {@link Ticks} on a {@link JXG.Line}. This method is only a stub and has to be implemented
    /// in any descendant renderer class.</summary>
    /// <param name="element">- Reference of a ticks object that has to be updated.</param>
    abstract updateTicks: element: JXG.Ticks -> unit
    /// <summary>Draws a {@link JXG.Curve} on the {@link JXG.Board}.</summary>
    /// <param name="el">- Reference to a graph object, that has to be plotted.</param>
    abstract drawCurve: el: JXG.Curve -> unit
    /// <summary>Updates visual appearance of the renderer element assigned to the given {@link JXG.Curve}.</summary>
    /// <param name="el">- Reference to a {@link JXG.Curve} object, that has to be updated.</param>
    abstract updateCurve: el: JXG.Curve -> unit
    /// <summary>Draws a {@link JXG.Circle}</summary>
    /// <param name="el">- Reference to a {@link JXG.Circle} object that has to be drawn.</param>
    abstract drawEllipse: el: JXG.Circle -> unit
    /// <summary>Updates visual appearance of a given {@link JXG.Circle} on the {@link JXG.Board}.</summary>
    /// <param name="el">- Reference to a {@link JXG.Circle} object, that has to be updated.</param>
    abstract updateEllipse: el: JXG.Circle -> unit
    /// <summary>Draws a {@link JXG.Polygon} on the {@link JXG.Board}.</summary>
    /// <param name="el">- Reference to a Polygon object, that is to be drawn.</param>
    abstract drawPolygon: el: JXG.Polygon -> unit
    /// <summary>Updates properties of a {@link JXG.Polygon}'s rendering node.</summary>
    /// <param name="el">- Reference to a {@link JXG.Polygon} object, that has to be updated.</param>
    abstract updatePolygon: el: JXG.Polygon -> unit
    /// <summary>Shows a small copyright notice in the top left corner of the board.</summary>
    /// <param name="str">- The copyright notice itself</param>
    /// <param name="fontsize">- Size of the font the copyright notice is written in</param>
    abstract displayCopyright: str: string * fontsize: float -> unit
    /// <summary>An internal text is a {@link JXG.Text} element which is drawn using only
    /// the given renderer but no HTML. This method is only a stub, the drawing
    /// is done in the special renderers.</summary>
    /// <param name="element">- Reference to a {@link JXG.Text} object</param>
    abstract drawInternalText: element: JXG.Text -> unit
    /// <summary>Updates visual properties of an already existing {@link JXG.Text} element.</summary>
    /// <param name="element">- Reference to an {@link JXG.Text} object, that has to be updated.</param>
    abstract updateInternalText: element: JXG.Text -> unit
    /// <summary>Displays a {@link JXG.Text} on the {@link JXG.Board} by putting a HTML div over it.</summary>
    /// <param name="el">- Reference to an {@link JXG.Text} object, that has to be displayed</param>
    abstract drawText: el: JXG.Text -> unit
    /// <summary>Updates visual properties of an already existing {@link JXG.Text} element.</summary>
    /// <param name="el">- Reference to an {@link JXG.Text} object, that has to be updated.</param>
    abstract updateText: el: JXG.Text -> unit
    /// <summary>Converts string containing CSS properties into
    /// array with key-value pair objects.</summary>
    /// <param name="cssString">- String containing CSS properties</param>
    abstract _css2js: cssString: string -> ResizeArray<obj option>
    /// <summary>Updates font-size, color and opacity propertiey and CSS style properties of a {@link JXG.Text} node.
    /// This function is also called by highlight() and nohighlight().</summary>
    /// <param name="el">- Reference to the {@link JXG.Text} object, that has to be updated.</param>
    abstract updateTextStyle: el: JXG.Text * doHighlight: bool -> unit
    /// <summary>Draws an {@link JXG.Image} on a board; This is just a template that has to be implemented by special
    /// renderers.</summary>
    /// <param name="element">- Reference to the image object that is to be drawn</param>
    abstract drawImage: element: JXG.Image -> unit
    /// <summary>Updates the properties of an {@link JXG.Image} element.</summary>
    /// <param name="el">- Reference to an {@link JXG.Image} object, that has to be updated.</param>
    abstract updateImage: el: JXG.Image -> unit
    /// <summary>Multiplication of transformations without updating. That means, at that point it is expected that the
    /// matrices contain numbers only. First, the origin in user coords is translated to <tt>(0,0)</tt> in screen
    /// coords. Then, the stretch factors are divided out. After the transformations in user coords, the stretch
    /// factors are multiplied in again, and the origin in user coords is translated back to its position. This
    /// method does not have to be implemented in a new renderer.</summary>
    /// <param name="el">- A JSXGraph element. We only need its board property.</param>
    /// <param name="transformations">- An array of JXG.Transformations.</param>
    abstract joinTransforms: el: JXG.GeometryElement * transformations: ResizeArray<obj option> -> ResizeArray<obj option>
    /// <summary>Applies transformations on images and text elements. This method is just a stub and has to be implemented in
    /// all descendant classes where text and image transformations are to be supported.</summary>
    /// <param name="element">- A {@link JXG.Image} or {@link JXG.Text} object.</param>
    /// <param name="transformations">- An array of {@link JXG.Transformation} objects. This is usually the
    /// transformations property of the given element <tt>el</tt>.</param>
    abstract transformImage: element: U2<JXG.Image, JXG.Text> * transformations: ResizeArray<obj option> -> unit
    /// <summary>If the URL of the image is provided by a function the URL has to be updated during updateImage()</summary>
    /// <param name="element">- Reference to an image object.</param>
    abstract updateImageURL: element: JXG.Image -> unit
    /// <summary>Updates CSS style properties of a {@link JXG.Image} node.
    /// In SVGRenderer opacity is the only available style element.
    /// This function is called by highlight() and nohighlight().
    /// This function works for VML.
    /// It does not work for Canvas.
    /// SVGRenderer overwrites this method.</summary>
    /// <param name="el">- Reference to the {@link JXG.Image} object, that has to be updated.</param>
    abstract updateImageStyle: el: JXG.Text * doHighlight: bool -> unit
    /// <summary>Appends a node to a specific layer level. This is just an abstract method and has to be implemented
    /// in all renderers that want to use the <tt>createPrim</tt> model to draw.</summary>
    /// <param name="node">- A DOM tree node.</param>
    /// <param name="level">- The layer the node is attached to. This is the index of the layer in
    /// {@link JXG.SVGRenderer#layer} or the <tt>z-index</tt> style property of the node in VMLRenderer.</param>
    abstract appendChildPrim: node: Node * level: float -> unit
    /// <summary>Stores the rendering nodes. This is an abstract method which has to be implemented in all renderers that use
    /// the <tt>createPrim</tt> method.</summary>
    /// <param name="element">- A JSXGraph element.</param>
    /// <param name="type">- The XML node name. Only used in VMLRenderer.</param>
    abstract appendNodesToElement: element: JXG.GeometryElement * ``type``: string -> unit
    /// <summary>Creates a node of a given type with a given id.</summary>
    /// <param name="type">- The type of the node to create.</param>
    /// <param name="id">- Set the id attribute to this.</param>
    abstract createPrim: ``type``: string * id: string -> Node
    /// <summary>Removes an element node. Just a stub.</summary>
    /// <param name="node">- The node to remove.</param>
    abstract remove: node: Node -> unit
    /// <summary>Can be used to create the nodes to display arrows. This is an abstract method which has to be implemented
    /// in any descendant renderer.</summary>
    /// <param name="element">- The element the arrows are to be attached to.</param>
    abstract makeArrows: element: JXG.GeometryElement -> unit
    /// <summary>Updates width of an arrow DOM node. Used in</summary>
    /// <param name="node">- The arrow node.</param>
    /// <param name="parentNode">- Used in IE only</param>
    abstract _setArrowWidth: node: Node * width: float * parentNode: Node -> unit
    /// <summary>Updates an ellipse node primitive. This is an abstract method which has to be implemented in all renderers
    /// that use the <tt>createPrim</tt> method.</summary>
    /// <param name="node">- Reference to the node.</param>
    /// <param name="x">- Centre X coordinate</param>
    /// <param name="y">- Centre Y coordinate</param>
    /// <param name="rx">- The x-axis radius.</param>
    /// <param name="ry">- The y-axis radius.</param>
    abstract updateEllipsePrim: node: Node * x: float * y: float * rx: float * ry: float -> unit
    /// <summary>Refreshes a line node. This is an abstract method which has to be implemented in all renderers that use
    /// the <tt>createPrim</tt> method.</summary>
    /// <param name="node">- The node to be refreshed.</param>
    /// <param name="p1x">- The first point's x coordinate.</param>
    /// <param name="p1y">- The first point's y coordinate.</param>
    /// <param name="p2x">- The second point's x coordinate.</param>
    /// <param name="p2y">- The second point's y coordinate.</param>
    abstract updateLinePrim: node: Node * p1x: float * p1y: float * p2x: float * p2y: float * board: JXG.Board -> unit
    /// <summary>Updates a path element. This is an abstract method which has to be implemented in all renderers that use
    /// the <tt>createPrim</tt> method.</summary>
    /// <param name="node">- The path node.</param>
    /// <param name="pathString">- A string formatted like e.g. <em>'M 1,2 L 3,1 L5,5'</em>. The format of the string
    /// depends on the rendering engine.</param>
    /// <param name="board">- Reference to the element's board.</param>
    abstract updatePathPrim: node: Node * pathString: string * board: JXG.Board -> unit
    /// <summary>Builds a path data string to draw a point with a face other than <em>rect</em> and <em>circle</em>. Since
    /// the format of such a string usually depends on the renderer this method
    /// is only an abstract method. Therefore, it has to be implemented in the descendant renderer itself unless
    /// the renderer does not use the createPrim interface but the draw* interfaces to paint.</summary>
    /// <param name="element">- The point element</param>
    /// <param name="size">- A positive number describing the size. Usually the half of the width and height of
    /// the drawn point.</param>
    /// <param name="type">- A string describing the point's face. This method only accepts the shortcut version of
    /// each possible face: <tt>x, +, <>, ^, v, >, <</param>
    abstract updatePathStringPoint: element: JXG.Point * size: float * ``type``: string -> unit
    /// Builds a path data string from a {@link JXG.Curve} element. Since the path data strings heavily depend on the
    /// underlying rendering technique this method is just a stub. Although such a path string is of no use for the
    /// CanvasRenderer, this method is used there to draw a path directly.
    abstract updatePathStringPrim: element: obj option -> unit
    /// Builds a path data string from a {@link JXG.Curve} element such that the curve looks like hand drawn. Since
    /// the path data strings heavily depend on the underlying rendering technique this method is just a stub.
    /// Although such a path string is of no use for the CanvasRenderer, this method is used there to draw a path
    /// directly.
    abstract updatePathStringBezierPrim: element: obj option -> unit
    /// <summary>Update a polygon primitive.</summary>
    /// <param name="element">- A JSXGraph element of type {@link JXG.Polygon}</param>
    abstract updatePolygonPrim: node: Node * element: JXG.Polygon -> unit
    /// <summary>Update a rectangle primitive. This is used only for points with face of type 'rect'.</summary>
    /// <param name="node">- The node yearning to be updated.</param>
    /// <param name="x">- x coordinate of the top left vertex.</param>
    /// <param name="y">- y coordinate of the top left vertex.</param>
    /// <param name="w">- Width of the rectangle.</param>
    /// <param name="h">- The rectangle's height.</param>
    abstract updateRectPrim: node: Node * x: float * y: float * w: float * h: float -> unit
    /// <summary>Sets a node's attribute.</summary>
    /// <param name="node">- The node that is to be updated.</param>
    /// <param name="key">- Name of the attribute.</param>
    /// <param name="val">- New value for the attribute.</param>
    abstract setPropertyPrim: node: Node * key: string * ``val``: string -> unit
    /// <summary>Shows or hides an element on the canvas; Only a stub, requires implementation in the derived renderer.</summary>
    /// <param name="element">- Reference to the object that has to appear.</param>
    /// <param name="value">- true to show the element, false to hide the element.</param>
    abstract display: element: JXG.GeometryElement * value: bool -> unit
    /// <summary>Shows a hidden element on the canvas; Only a stub, requires implementation in the derived renderer.
    /// 
    /// Please use JXG.AbstractRenderer#display instead</summary>
    /// <param name="element">- Reference to the object that has to appear.</param>
    abstract show: element: JXG.GeometryElement -> unit
    /// <summary>Hides an element on the canvas; Only a stub, requires implementation in the derived renderer.
    /// 
    /// Please use JXG.AbstractRenderer#display instead</summary>
    /// <param name="element">- Reference to the geometry element that has to disappear.</param>
    abstract hide: element: JXG.GeometryElement -> unit
    /// <summary>Sets the buffering as recommended by SVGWG. Until now only Opera supports this and will be ignored by other
    /// browsers. Although this feature is only supported by SVG we have this method in {@link JXG.AbstractRenderer}
    /// because it is called from outside the renderer.</summary>
    /// <param name="node">- The SVG DOM Node which buffering type to update.</param>
    /// <param name="type">- Either 'auto', 'dynamic', or 'static'. For an explanation see
    /// {@link http://www.w3.org/TR/SVGTiny12/painting.html#BufferedRenderingProperty}.</param>
    abstract setBuffering: node: Node * ``type``: string -> unit
    /// <summary>Sets an element's dash style.</summary>
    /// <param name="element">- An JSXGraph element.</param>
    abstract setDashStyle: element: JXG.GeometryElement -> unit
    /// <summary>Puts an object into draft mode, i.e. it's visual appearance will be changed. For GEONE<sub>x</sub>T backwards
    /// compatibility.</summary>
    /// <param name="el">- Reference of the object that is in draft mode.</param>
    abstract setDraft: el: JXG.GeometryElement -> unit
    /// <summary>Puts an object from draft mode back into normal mode.</summary>
    /// <param name="el">- Reference of the object that no longer is in draft mode.</param>
    abstract removeDraft: el: JXG.GeometryElement -> unit
    /// Sets up nodes for rendering a gradient fill.
    abstract setGradient: element: obj option -> unit
    /// <summary>Updates the gradient fill.</summary>
    /// <param name="element">- An JSXGraph element with an area that can be filled.</param>
    abstract updateGradient: element: JXG.GeometryElement -> unit
    /// <summary>Sets the transition duration (in milliseconds) for fill color and stroke
    /// color and opacity.</summary>
    /// <param name="element">- Reference of the object that wants a
    /// new transition duration.</param>
    /// <param name="duration">- (Optional) duration in milliseconds. If not given,
    /// element.visProp.transitionDuration is taken. This is the default.</param>
    abstract setObjectTransition: element: JXG.GeometryElement * duration: float -> unit
    /// <summary>Sets an objects fill color.</summary>
    /// <param name="element">- Reference of the object that wants a new fill color.</param>
    /// <param name="color">- Color in a HTML/CSS compatible format. If you don't want any fill color at all, choose
    /// 'none'.</param>
    /// <param name="opacity">- Opacity of the fill color. Must be between 0 and 1.</param>
    abstract setObjectFillColor: element: JXG.GeometryElement * color: string * opacity: float -> unit
    /// <summary>Changes an objects stroke color to the given color.</summary>
    /// <param name="element">- Reference of the {@link JXG.GeometryElement} that gets a new stroke
    /// color.</param>
    /// <param name="color">- Color value in a HTML compatible format, e.g. <strong>#00ff00</strong> or
    /// <strong>green</strong> for green.</param>
    /// <param name="opacity">- Opacity of the fill color. Must be between 0 and 1.</param>
    abstract setObjectStrokeColor: element: JXG.GeometryElement * color: string * opacity: float -> unit
    /// <summary>Sets an element's stroke width.</summary>
    /// <param name="element">- Reference to the geometry element.</param>
    /// <param name="width">- The new stroke width to be assigned to the element.</param>
    abstract setObjectStrokeWidth: element: JXG.GeometryElement * width: float -> unit
    /// <summary>Sets the shadow properties to a geometry element. This method is only a stub, it is implemented in the actual
    /// renderers.</summary>
    /// <param name="element">- Reference to a geometry object, that should get a shadow</param>
    abstract setShadow: element: JXG.GeometryElement -> unit
    /// <summary>Highlights an object, i.e. changes the current colors of the object to its highlighting colors
    /// and highlighting stroke width.</summary>
    /// <param name="el">- Reference of the object that will be highlighted.</param>
    abstract highlight: el: JXG.GeometryElement -> JXG.AbstractRenderer
    /// <summary>Uses the normal colors of an object, i.e. the opposite of {@link JXG.AbstractRenderer#highlight}.</summary>
    /// <param name="el">- Reference of the object that will get its normal colors.</param>
    abstract noHighlight: el: JXG.GeometryElement -> JXG.AbstractRenderer
    /// Stop redraw. This method is called before every update, so a non-vector-graphics based renderer can use this
    /// method to delete the contents of the drawing panel. This is an abstract method every descendant renderer
    /// should implement, if appropriate.
    abstract suspendRedraw: unit -> unit
    /// Restart redraw. This method is called after updating all the rendering node attributes.
    abstract unsuspendRedraw: unit -> unit
    /// <summary>The tiny zoom bar shown on the bottom of a board (if showNavigation on board creation is true).</summary>
    /// <param name="board">- Reference to a JSXGraph board.</param>
    /// <param name="attr">- Attributes of the navigation bar</param>
    abstract drawZoomBar: board: JXG.Board * attr: obj option -> unit
    /// <summary>Wrapper for getElementById for maybe other renderers which elements are not directly accessible by DOM
    /// methods like document.getElementById().</summary>
    /// <param name="id">- Unique identifier for element.</param>
    abstract getElementById: id: string -> obj option
    /// <summary>Remove an element and provide a function that inserts it into its original position. This method
    /// is taken from this article {@link https://developers.google.com/speed/articles/javascript-dom}.</summary>
    /// <param name="el">- The element to be temporarily removed</param>
    abstract removeToInsertLater: el: Element -> (ResizeArray<obj option> -> obj option)
    /// <summary>Resizes the rendering element</summary>
    /// <param name="w">- New width</param>
    /// <param name="h">- New height</param>
    abstract resize: w: float * h: float -> unit
    /// <summary>Create crosshair elements (Fadenkreuz) for presentations.</summary>
    /// <param name="n">- Number of crosshairs.</param>
    abstract createTouchpoints: n: float -> unit
    /// <summary>Show a specific crosshair.</summary>
    /// <param name="i">- Number of the crosshair to show</param>
    abstract showTouchpoint: i: float -> unit
    /// <summary>Hide a specific crosshair.</summary>
    /// <param name="i">- Number of the crosshair to show</param>
    abstract hideTouchpoint: i: float -> unit
    /// <summary>Move a specific crosshair.</summary>
    /// <param name="i">- Number of the crosshair to show</param>
    /// <param name="pos">- New positon in screen coordinates</param>
    abstract updateTouchpoint: i: float * pos: ResizeArray<obj option> -> unit
    /// Convert SVG construction to base64 encoded SVG data URL.
    /// Only available on SVGRenderer.
    abstract dumpToDataURI: unit -> unit
    /// Convert SVG construction to canvas.
    /// Only available on SVGRenderer.
    abstract dumpToCanvas: unit -> unit
    /// Display SVG image in html img-tag which enables
    /// easy download for the user.
    /// 
    /// See JXG.SVGRenderer#screenshot
    abstract screenshot: unit -> unit
    /// The vertical offset for {@link Text} elements. Every {@link Text} element will
    /// be placed this amount of pixels below the user given coordinates.
    abstract vOffsetText: float with get, set
    /// If this property is set to <tt>true</tt> the visual properties of the elements are updated
    /// on every update. Visual properties means: All the stuff stored in the
    /// {@link JXG.GeometryElement#visProp} property won't be set if enhancedRendering is <tt>false</tt>
    abstract enhancedRendering: bool with get, set
    /// The HTML element that stores the JSXGraph board in it.
    abstract container: Node with get, set
    /// This is used to easily determine which renderer we are using
    abstract ``type``: string with get, set
    /// The vertical offset for {@link Text} elements. Every {@link Text} element will
    /// be placed this amount of pixels below the user given coordinates.
    abstract vOffsetText: float with get, set
    /// If this property is set to <tt>true</tt> the visual properties of the elements are updated
    /// on every update. Visual properties means: All the stuff stored in the
    /// {@link JXG.GeometryElement#visProp} property won't be set if enhancedRendering is <tt>false</tt>
    abstract enhancedRendering: bool with get, set
    /// The HTML element that stores the JSXGraph board in it.
    abstract container: Node with get, set
    /// This is used to easily determine which renderer we are using
    abstract ``type``: string with get, set
    /// The vertical offset for {@link Text} elements. Every {@link Text} element will
    /// be placed this amount of pixels below the user given coordinates.
    abstract vOffsetText: float with get, set
    /// If this property is set to <tt>true</tt> the visual properties of the elements are updated
    /// on every update. Visual properties means: All the stuff stored in the
    /// {@link JXG.GeometryElement#visProp} property won't be set if enhancedRendering is <tt>false</tt>
    abstract enhancedRendering: bool with get, set
    /// The HTML element that stores the JSXGraph board in it.
    abstract container: Node with get, set
    /// This is used to easily determine which renderer we are using
    abstract ``type``: string with get, set
    /// The vertical offset for {@link Text} elements. Every {@link Text} element will
    /// be placed this amount of pixels below the user given coordinates.
    abstract vOffsetText: float with get, set
    /// If this property is set to <tt>true</tt> the visual properties of the elements are updated
    /// on every update. Visual properties means: All the stuff stored in the
    /// {@link JXG.GeometryElement#visProp} property won't be set if enhancedRendering is <tt>false</tt>
    abstract enhancedRendering: bool with get, set
    /// The HTML element that stores the JSXGraph board in it.
    abstract container: Node with get, set
    /// This is used to easily determine which renderer we are using
    abstract ``type``: string with get, set

/// <p>This class defines the interface to the graphics part of JSXGraph. This class is an abstract class, it
/// actually does not render anything. This is up to the {@link JXG.SVGRenderer}, {@link JXG.VMLRenderer},
/// and {@link JXG.CanvasRenderer} classes. We strongly discourage you from using the methods in these classes
/// directly. Only the methods which are defined in this class and are not marked as private are guaranteed
/// to exist in any renderer instance you can access via {@link JXG.Board#renderer}. But not all methods may
/// work as expected.</p>
/// <p>The methods of this renderer can be divided into different categories:
/// <dl>
///   <dt>Draw basic elements</dt>
///   <dd>In this category we find methods to draw basic elements like {@link JXG.Point}, {@link JXG.Line},
///   and {@link JXG.Curve} as well as assisting methods tightly bound to these basic painters. You do not
///   need to implement these methods in a descendant renderer but instead implement the primitive drawing
///   methods described below. This approach is encouraged when you're using a XML based rendering engine
///   like VML and SVG. If you want to use a bitmap based rendering technique you are supposed to override
///   these methods instead of the primitive drawing methods.</dd>
///   <dt>Draw primitives</dt>
///   <dd>This category summarizes methods to handle primitive nodes. As creation and management of these nodes
///   is different among different the rendering techniques most of these methods are purely virtual and need
///   proper implementation if you choose to not overwrite the basic element drawing methods.</dd>
///   <dt>Attribute manipulation</dt>
///   <dd>In XML based renders you have to manipulate XML nodes and their attributes to change the graphics.
///   For that purpose attribute manipulation methods are defined to set the color, opacity, and other things.
///   Please note that some of these methods are required in bitmap based renderers, too, because some elements
///   like {@link JXG.Text} can be HTML nodes floating over the construction.</dd>
///   <dt>Renderer control</dt>
///   <dd>Methods to clear the drawing board or to stop and to resume the rendering engine.</dd>
/// </dl></p>
type [<AllowNullLiteral>] AbstractRendererStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> AbstractRenderer

module Dump =

    type [<AllowNullLiteral>] IExports =
        /// Adds markers to every element of the board
        abstract addMarkers: board: JXG.Board * markers: U2<ResizeArray<obj option>, string> * values: ResizeArray<obj option> -> unit
        /// Removes markers from every element on the board.
        abstract deleteMarkers: board: JXG.Board * markers: U2<ResizeArray<obj option>, string> -> unit
        /// Stringifies a string, i.e. puts some quotation marks around <tt>s</tt> if it is of type string.
        abstract str: s: obj option -> string
        /// <summary>Eliminate default values given by {@link JXG.Options} from the attributes object.</summary>
        /// <param name="instance">- Attribute object of the element</param>
        /// <param name="s">- Arbitrary number of objects <tt>instance</tt> will be compared to. Usually these are
        /// sub-objects of the {@link JXG.Board#options} structure.</param>
        abstract minimizeObject: instance: obj option * s: obj option -> obj option
        /// <summary>Prepare the attributes object for an element to be dumped as JavaScript or JessieCode code.</summary>
        /// <param name="obj">- Geometry element which attributes object is generated</param>
        abstract prepareAttributes: board: JXG.Board * obj: JXG.GeometryElement -> obj option
        /// Generate a save-able structure with all elements. This is used by {@link JXG.Dump#toJessie} and
        /// {@link JXG.Dump#toJavaScript} to generate the script.
        abstract dump: board: JXG.Board -> ResizeArray<obj option>
        /// <summary>Converts an array of different values into a parameter string that can be used by the code generators.</summary>
        /// <param name="converter">- A function that is used to transform the elements of <tt>a</tt>. Usually
        /// {@link JXG.toJSON} or {@link JXG.Dump.toJCAN} are used.</param>
        abstract arrayToParamStr: a: ResizeArray<obj option> * converter: (ResizeArray<obj option> -> obj option) -> string
        /// <summary>Converts a JavaScript object into a JCAN (JessieCode Attribute Notation) string.</summary>
        /// <param name="obj">- A JavaScript object, functions will be ignored.</param>
        abstract toJCAN: obj: obj option -> string
        /// Saves the construction in <tt>board</tt> to JessieCode.
        abstract toJessie: board: JXG.Board -> string
        /// Saves the construction in <tt>board</tt> to JavaScript.
        abstract toJavaScript: board: JXG.Board -> string

module EventEmitter =

    type [<AllowNullLiteral>] IExports =
        abstract eventHandlers: obj option
        abstract suspended: obj option
        /// <summary>Triggers all event handlers of this element for a given event.</summary>
        /// <param name="args">- The arguments passed onto the event handler</param>
        abstract trigger: ``event``: ResizeArray<obj option> * args: ResizeArray<obj option> -> obj option
        /// <summary>Register a new event handler. For a list of possible events see documentation
        /// of the elements and objects implementing
        /// the {@link EventEmitter} interface.</summary>
        /// <param name="context">- The context the handler will be called in, default is the element itself.</param>
        abstract on: ``event``: string * handler: (ResizeArray<obj option> -> obj option) * ?context: obj -> obj option
        /// Unregister an event handler.
        abstract off: ``event``: string * ?handler: (ResizeArray<obj option> -> obj option) -> obj option
        /// Implements the functionality from this interface in the given object.
        /// All objects getting their event handling
        /// capabilities from this method should document it by adding
        /// the <tt>on, off, triggerEventHandlers</tt> via the
        /// borrows tag as methods to their documentation:
        /// <pre>@borrows JXG.EventEmitter#on as this.on</pre>
        abstract eventify: o: obj option -> unit

module Util =
    let [<Import("Base64","module/Util")>] base64: Base64.IExports = jsNative
    let [<Import("UTF8","module/Util")>] uTF8: UTF8.IExports = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract Unzip: UnzipStatic

    module Base64 =

        type [<AllowNullLiteral>] IExports =
            /// Encode the given string.
            abstract encode: input: string -> string
            /// <summary>Decode from Base64</summary>
            /// <param name="input">- Base64 encoded data</param>
            /// <param name="utf8">- In case this parameter is true {@link JXG.Util.UTF8.decode} will be applied to
            /// the result of the base64 decoder.</param>
            abstract decode: input: string * utf8: bool -> string
            /// Decode the base64 input data as an array
            abstract decodeAsArray: input: string -> ResizeArray<obj option>

    module UTF8 =

        type [<AllowNullLiteral>] IExports =
            /// Encode a string to utf-8.
            abstract encode: string: string -> string
            /// <summary>Decode a string from utf-8.</summary>
            /// <param name="utftext">- to decode</param>
            abstract decode: utftext: string -> string
            /// <summary>Extends the standard charCodeAt() method of the String class to find the ASCII char code of
            /// a character at a given position in a UTF8 encoded string.</summary>
            /// <param name="i">- position of the character</param>
            abstract asciiCharCodeAt: str: string * i: float -> float

    /// Unzip class
    /// Class for gunzipping, unzipping and base64 decoding of files.
    /// It is used for reading GEONExT, Geogebra and Intergeo files.
    /// 
    /// Only Huffman codes are decoded in gunzip.
    /// The code is based on the source code for gunzip.c by Pasi Ojala
    type [<AllowNullLiteral>] Unzip =
        /// nextFile:
        /// Extract the next file from the compressed archive.
        /// Calls skipdir() to proceed recursively.
        abstract nextFile: unit -> bool

    /// Unzip class
    /// Class for gunzipping, unzipping and base64 decoding of files.
    /// It is used for reading GEONExT, Geogebra and Intergeo files.
    /// 
    /// Only Huffman codes are decoded in gunzip.
    /// The code is based on the source code for gunzip.c by Pasi Ojala
    type [<AllowNullLiteral>] UnzipStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Unzip

module XML =

    type [<AllowNullLiteral>] IExports =
        /// Cleans out unneccessary whitespaces in a chunk of xml.
        abstract cleanWhitespace: el: obj option -> unit
        /// Converts a given string into a XML tree.
        abstract parse: str: string -> obj option