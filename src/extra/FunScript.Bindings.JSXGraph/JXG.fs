namespace FunScript.Bindings.JXG

open System

open FunScript
open FunScript.Bindings

type [<AllowNullLiteral>] JXG =
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

