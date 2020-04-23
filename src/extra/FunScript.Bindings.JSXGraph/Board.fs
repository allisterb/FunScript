namespace FunScript.Bindings.JXG

open System

open FunScript
open FunScript.Bindings

type CoordsMethod = COORDS_BY_USER= 0x0001 | COORDS_BY_SCREEN= 0x0002

/// Constructs a new Board object.
type [<AllowNullLiteral>] Board =
    /// Board is in no special mode, objects are highlighted on mouse over and objects may be
    /// clicked to start drag&drop.
    abstract BOARD_MODE_NONE: float
    /// Board is in drag mode, objects aren't highlighted on mouse over and the object referenced in
    /// {Board#mouse} is updated on mouse movement.
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
    abstract renderer: Renderer with get, set
    /// Grids keeps track of all grids attached to this board.
    abstract grids: obj option with get, set
    /// Some standard options
    abstract options: BoardOptions with get, set
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
    /// <li>Board.BOARD_MODE_NONE</li>
    /// <li>Board.BOARD_MODE_DRAG</li>
    /// <li>Board.BOARD_MODE_MOVE_ORIGIN</li>
    /// </ul>
    abstract mode: float with get, set
    /// The update quality of the board. In most cases this is set to {@link Board#BOARD_QUALITY_HIGH}.
    /// If {@link Board#mode} equals {@link Board#BOARD_MODE_DRAG} this is set to
    /// {@link Board#BOARD_QUALITY_LOW} to speed up the update process by e.g. reducing the number of
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
    /// Keeps track on touched elements, like {@link Board#mouse} does for mouse events.
    abstract touches: ResizeArray<obj option> with get, set
    /// A string containing the XML text of the construction.
    /// This is set in {@link FileReader.parseString}.
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
    /// This is set in {@link GeonextReader.readGeonext}.
    abstract geonextCompatibilityMode: bool with get, set
    /// A flag which tells if the board registers mouse events.
    abstract hasMouseHandlers: bool with get, set
    /// A flag which tells if the board registers touch events.
    abstract hasTouchHandlers: bool with get, set
    /// A flag which stores if the board registered pointer events.
    abstract hasPointerHandlers: bool with get, set
    /// A flag which tells if the board the Board#mouseUpListener is currently registered.
    abstract hasMouseUp: bool with get, set
    /// A flag which tells if the board the Board#touchEndListener is currently registered.
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
    /// object is a {@link Point}, capital characters are used, if it is of type {@link Line}
    /// only lower case characters are used. If object is of type {@link Polygon}, a bunch of lower
    /// case characters prefixed with P_ are used. If object is of type {@link Circle} the name is
    /// generated using lower case characters. prefixed with k_ is used. In any other case, lower case
    /// chars prefixed with s_ is used.</summary>
    /// <param name="object">- Reference of an GeometryElement that is to be named.</param>
    abstract generateName: ``object``: obj option -> string
    /// Generates unique id for a board. The result is randomly generated and prefixed with 'jxgBoard'.
    abstract generateId: unit -> string
    /// <summary>Composes an id for an element. If the ID is empty ('' or null) a new ID is generated, depending on the
    /// object type. As a side effect {@link Board#numObjects}
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
    /// <param name="o">- The touch object that is dragged: {Board#mouse} or {Board#touches}.</param>
    /// <param name="evt">- The event object.</param>
    /// <param name="type">- Mouse or touch event?</param>
    abstract moveObject: x: float * y: float * o: obj option * evt: obj option * ``type``: string -> unit
    /// <summary>Moves elements in multitouch mode.</summary>
    /// <param name="p1">- x,y coordinates of first touch</param>
    /// <param name="p2">- x,y coordinates of second touch</param>
    /// <param name="o">- The touch object that is dragged: {Board#touches}.</param>
    /// <param name="evt">- The event object that lead to this movement.</param>
    abstract twoFingerMove: p1: ResizeArray<obj option> * p2: ResizeArray<obj option> * o: obj option * evt: obj option -> unit
    /// <summary>Moves, rotates and scales a line or polygon with two fingers.</summary>
    /// <param name="np1c">- x,y coordinates of first touch</param>
    /// <param name="np2c">- x,y coordinates of second touch</param>
    /// <param name="o">- The touch object that is dragged: {Board#touches}.</param>
    /// <param name="drag">- The object that is dragged:</param>
    /// <param name="evt">- The event object that lead to this movement.</param>
    abstract twoFingerTouchObject: np1c: Coords * np2c: Coords * o: obj option * drag: obj option * evt: obj option -> unit
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
    abstract clickLeftArrow: unit -> Board
    /// Handler for click on right arrow in the navigation bar
    abstract clickRightArrow: unit -> Board
    /// Handler for click on up arrow in the navigation bar
    abstract clickUpArrow: unit -> Board
    /// Handler for click on down arrow in the navigation bar
    abstract clickDownArrow: unit -> Board
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
    abstract initInfobox: unit -> Board
    /// <summary>Updates and displays a little info box to show coordinates of current selected points.</summary>
    /// <param name="el">- A GeometryElement</param>
    abstract updateInfobox: el: GeometryElement -> Board
    /// <summary>Set infobox visible / invisible.
    /// 
    /// It uses its property hiddenByParent to memorize its status.
    /// In this way, many DOM access can be avoided.</summary>
    /// <param name="val">- true for visible, false for invisible</param>
    abstract showInfobox: ``val``: bool -> Board
    /// <summary>Changes the text of the info box to show the given coordinates.</summary>
    /// <param name="el">- The element the mouse is pointing at</param>
    abstract highlightInfobox: x: float * y: float * ?el: GeometryElement -> Board
    /// Changes the text of the info box to what is provided via text.
    abstract highlightCustomInfobox: text: string * ?el: GeometryElement -> Board
    /// Remove highlighting of all elements.
    abstract dehighlightAll: unit -> Board
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
    abstract updateCoords: unit -> Board
    /// Moves the origin and initializes an update of all elements.
    abstract moveOrigin: x: float * y: float * ?diff: bool -> Board
    /// <summary>Add conditional updates to the elements.</summary>
    /// <param name="str">- String containing coniditional update in geonext syntax</param>
    abstract addConditions: str: string -> unit
    /// Calculates adequate snap sizes.
    abstract calculateSnapSizes: unit -> Board
    /// Apply update on all objects with the new zoom-factors. Clears all traces.
    abstract applyZoom: unit -> Board
    /// Zooms into the board by the factors board.attr.zoom.factorX and board.attr.zoom.factorY and applies the zoom.
    /// The zoom operation is centered at x, y.
    abstract zoomIn: ?x: float * ?y: float -> Board
    /// Zooms out of the board by the factors board.attr.zoom.factorX and board.attr.zoom.factorY and applies the zoom.
    /// The zoom operation is centered at x, y.
    abstract zoomOut: ?x: float * ?y: float -> Board
    /// Resets zoom factor to 100%.
    abstract zoom100: unit -> Board
    /// Zooms the board so every visible point is shown. Keeps aspect ratio.
    abstract zoomAllPoints: unit -> Board
    /// <summary>Reset the bounding box and the zoom level to 100% such that a given set of elements is
    /// within the board's viewport.</summary>
    /// <param name="elements">- A set of elements given by id, reference, or name.</param>
    abstract zoomElements: elements: ResizeArray<obj option> -> Board
    /// Sets the zoom level to <tt>fX</tt> resp <tt>fY</tt>.
    abstract setZoom: fX: float * fY: float -> Board
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
    abstract removeObject: ``object``: U2<GeometryElement, ResizeArray<obj option>> * saveMethod: bool -> Board
    /// <summary>Removes the ancestors of an object an the object itself from board and renderer.</summary>
    /// <param name="object">- The object to remove.</param>
    abstract removeAncestors: ``object``: GeometryElement -> Board
    /// Initialize some objects which are contained in every GEONExT construction by default,
    /// but are not contained in the gxt files.
    abstract initGeonextBoard: unit -> Board
    /// <summary>Change the height and width of the board's container.
    /// After doing so, {@link JSXGraph.setBoundingBox} is called using
    /// the actual size of the bounding box and the actual value of keepaspectratio.
    /// If setBoundingbox() should not be called automatically,
    /// call resizeContainer with dontSetBoundingBox == true.</summary>
    /// <param name="canvasWidth">- New width of the container.</param>
    /// <param name="canvasHeight">- New height of the container.</param>
    /// <param name="dontset">- If true do not set the CSS width and height of the DOM element.</param>
    /// <param name="dontSetBoundingBox">- If true do not call setBoundingBox().</param>
    abstract resizeContainer: canvasWidth: float * canvasHeight: float * ?dontset: bool * ?dontSetBoundingBox: bool -> Board
    /// Lists the dependencies graph in a new HTML-window.
    abstract showDependencies: unit -> Board
    /// Lists the XML code of the construction in a new HTML-window.
    abstract showXML: unit -> Board
    /// Sets for all objects the needsUpdate flag to "true".
    abstract prepareUpdate: unit -> Board
    /// <summary>Runs through all elements and calls their update() method.</summary>
    /// <param name="drag">- Element that caused the update.</param>
    abstract updateElements: drag: GeometryElement -> Board
    /// Runs through all elements and calls their update() method.
    abstract updateRenderer: unit -> Board
    /// Runs through all elements and calls their update() method.
    /// This is a special version for the CanvasRenderer.
    /// Here, we have to do our own layer handling.
    abstract updateRendererCanvas: unit -> Board
    /// <summary>Please use {@link Board.on} instead.</summary>
    /// <param name="hook">- A function to be called by the board after an update occurred.</param>
    /// <param name="m">- When the hook is to be called. Possible values are <i>mouseup</i>, <i>mousedown</i> and <i>update</i>.</param>
    /// <param name="context">- Determines the execution context the hook is called. This parameter is optional, default is the
    /// board object the hook is attached to.</param>
    abstract addHook: hook: (ResizeArray<obj option> -> obj option) * ?m: string * ?context: obj -> float
    /// Alias of {@link Board.on}.
    abstract addEvent: obj option with get, set
    /// <summary>Please use {@link Board.off} instead.</summary>
    /// <param name="id">- The number you got when you added the hook or a reference to the event handler.</param>
    abstract removeHook: id: U2<float, (ResizeArray<obj option> -> obj option)> -> Board
    /// Alias of {@link Board.off}.
    abstract removeEvent: obj option with get, set
    /// Runs through all hooked functions and calls them.
    abstract updateHooks: unit -> Board
    /// <summary>Adds a dependent board to this board.</summary>
    /// <param name="board">- A reference to board which will be updated after an update of this board occurred.</param>
    abstract addChild: board: Board -> Board
    /// <summary>Deletes a board from the list of dependent boards.</summary>
    /// <param name="board">- Reference to the board which will be removed.</param>
    abstract removeChild: board: Board -> Board
    /// <summary>Runs through most elements and calls their update() method and update the conditions.</summary>
    /// <param name="drag">- Element that caused the update.</param>
    abstract update: ?drag: GeometryElement -> Board
    /// Runs through all elements and calls their update() method and update the conditions.
    /// This is necessary after zooming and changing the bounding box.
    abstract fullUpdate: unit -> Board
    /// Adds a grid to the board according to the settings given in board.options.
    abstract addGrid: unit -> Board
    /// Removes all grids assigned to this board. Warning: This method also removes all objects depending on one or
    /// more of the grids.
    abstract removeGrids: unit -> Board
    /// <summary>Creates a new geometric element of type elementType.</summary>
    /// <param name="elementType">- Type of the element to be constructed given as a string e.g. 'point' or 'circle'.</param>
    /// <param name="parents">- Array of parent elements needed to construct the element e.g. coordinates for a point or two
    /// points to construct a line. This highly depends on the elementType that is constructed. See the corresponding create*
    /// methods for a list of possible parameters.</param>
    /// <param name="attributes">- An object containing the attributes to be set. This also depends on the elementType.
    /// Common attributes are name, visible, strokeColor.</param>
    abstract create: elementType: string * parents: ResizeArray<obj option> * ?attributes: obj -> obj option
    /// Deprecated name for {@link Board.create}.
    abstract createElement: unit -> unit
    /// Delete the elements drawn as part of a trace of an element.
    abstract clearTraces: unit -> Board
    /// Stop updates of the board.
    abstract suspendUpdate: unit -> Board
    /// Enable updates of the board.
    abstract unsuspendUpdate: unit -> Board
    /// <summary>Set the bounding box of the board.</summary>
    /// <param name="bbox">- New bounding box [x1,y1,x2,y2]</param>
    /// <param name="keepaspectratio">- If set to true, the aspect ratio will be 1:1, but
    /// the resulting viewport may be larger.</param>
    abstract setBoundingBox: bbox: ResizeArray<obj option> * ?keepaspectratio: bool -> Board
    /// Get the bounding box of the board.
    abstract getBoundingBox: unit -> ResizeArray<obj option>
    /// <summary>Adds an animation. Animations are controlled by the boards, so the boards need to be aware of the
    /// animated elements. This function tells the board about new elements to animate.</summary>
    /// <param name="element">- The element which is to be animated.</param>
    abstract addAnimation: element: GeometryElement -> Board
    /// Cancels all running animations.
    abstract stopAllAnimation: unit -> Board
    /// General purpose animation function. This currently only supports moving points from one place to another. This
    /// is faster than managing the animation per point, especially if there is more than one animated point at the same time.
    abstract animate: unit -> Board
    /// <summary>Migrate the dependency properties of the point src
    /// to the point dest and  delete the point src.
    /// For example, a circle around the point src
    /// receives the new center dest. The old center src
    /// will be deleted.</summary>
    /// <param name="src">- Original point which will be deleted</param>
    /// <param name="dest">- New point with the dependencies of src.</param>
    /// <param name="copyName">- Flag which decides if the name of the src element is copied to the
    /// dest element.</param>
    abstract migratePoint: src: Point * dest: Point * copyName: bool -> Board
    /// <summary>Initializes color blindness simulation.</summary>
    /// <param name="deficiency">- Describes the color blindness deficiency which is simulated. Accepted values are 'protanopia', 'deuteranopia', and 'tritanopia'.</param>
    abstract emulateColorblindness: deficiency: string -> Board
    /// <summary>Select a single or multiple elements at once.</summary>
    /// <param name="str">- The name, id or a reference to a JSXGraph element on this board. An object will
    /// be used as a filter to return multiple elements at once filtered by the properties of the object.</param>
    /// <param name="onlyByIdOrName">- If true (default:false) elements are only filtered by their id, name or groupId.
    /// The advanced filters consisting of objects or functions are ignored.</param>
    abstract select: str: U3<string, obj option, (ResizeArray<obj option> -> obj option)> * onlyByIdOrName: bool -> U2<GeometryElement, Composition>
    /// <summary>Checks if the given point is inside the boundingbox.</summary>
    /// <param name="x">- User coordinate or {@link Coords} object.</param>
    /// <param name="y">- User coordinate. May be omitted in case <tt>x</tt> is a {@link Coords} object.</param>
    abstract hasPoint: x: U2<float, Coords> * ?y: float -> bool
    /// Update CSS transformations of sclaing type. It is used to correct the mouse position
    /// in {@link Board.getMousePosition}.
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
    /// required keys are pressed. If yes, {@link Board.startSelectionMode} is called.</summary>
    /// <param name="evt">- Event object</param>
    abstract _testForSelection: evt: obj option -> unit
    /// Expand the JSXGraph construction to fullscreen.
    /// In order to preserve the proportions of the JSXGraph element,
    /// a wrapper div is created which is set to fullscreen.
    /// <p>
    /// The wrapping div has the CSS class 'jxgbox_wrap_private' which is
    /// defined in the file 'jsxgraph.css'
    abstract toFullscreen: unit -> Board
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
    /// Additional zoom factor multiplied to {@link Board#zoomX} and {@link Board#zoomY}.
    abstract zoomFactor: float with get, set
    /// Show copyright string in canvas.
    abstract showCopyright: bool with get, set
    /// Show default axis.
    /// If shown, the horizontal axis can be accessed via Board.defaultAxes.x, the
    /// vertical axis can be accessed via Board.defaultAxes.y.
    /// Both axes have a sub-element "defaultTicks".
    /// 
    /// Value can be Boolean or an object containing axis attributes.
    abstract axis: bool with get, set
    /// Attributes for the default axes in case of the attribute
    /// axis:true in {@link JSXGraph#initBoard}.
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
    abstract ignoreLabels: bool with get, set
    /// Maximum number of digits in automatic label generation.
    /// For example, if set to 1 automatic point labels end at "Z".
    /// If set to 2, point labels end at "ZZ".
    abstract maxNameLength: float with get, set
    /// Supply the document object. Defaults to window.document
    abstract document: obj option with get, set
    /// If true the first element of the set board.objects having hasPoint==true is taken as drag element.
    abstract takeFirst: bool with get, set
    /// If true, when read from a file or string - the size of the div can be changed by the construction text.
    abstract takeSizeFromFile: bool with get, set
    
    /// Time (in msec) between two animation steps. Used in
    /// {@link CoordsElement#moveAlong}, {@link CoordsElement#moveTo} and
    /// {@link CoordsElement#visit}.
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
    /// calculations in {@link Board#getCoordsTopLeftCorner}.
    abstract offsetX: float with get, set
    /// A number that will be added to the absolute position of the board used in mouse coordinate
    /// calculations in {@link Board#getCoordsTopLeftCorner}.
    abstract offsetY: float with get, set
    /// Control the possibilities for zoom interaction.
    /// 
    /// Possible sub-attributes with default values are:
    /// <pre>
    /// zoom: {
    /// factorX: 1.25,  // horizontal zoom factor (multiplied to {@link Board#zoomX})
    /// factorY: 1.25,  // vertical zoom factor (multiplied to {@link Board#zoomY})
    /// wheel: true,     // allow zooming by mouse wheel or
    ///                  // by pinch-to-toom gesture on touch devices
    /// needShift: true, // mouse wheel zooming needs pressing of the shift key
    /// min: 0.001        // minimal values of {@link Board#zoomX} and {@link Board#zoomY}, limits zoomOut
    /// max: 1000.0       // maximal values of {@link Board#zoomX} and {@link Board#zoomY}, limits zoomIn
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
    /// <tt>&lt;macro-name&gt; = Macro(A, B, C) { <Command in JSXGraph Construction syntax>; ...<Command in Construct syntax>; }</tt><br />
    /// and adds it as a macro so it can be used in the JSXGraph Construction Syntax.</summary>
    /// <param name="string">- A string like the one in the methods description.</param>
    abstract addMacro: string: string -> unit

/// Constructs a new Coordinates object.
and [<AllowNullLiteral;AbstractClass>] Coords =
    /// Stores the board the object is used on.
    abstract board: Board with get, set
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
    abstract distance: coord_type: float * coordinates: Coords -> float
    /// <summary>Set coordinates by either user coordinates or screen coordinates and recalculate the other one.</summary>
    /// <param name="coord_type">- The type of coordinates used here. Possible values are <b>COORDS_BY_USER</b> and <b>COORDS_BY_SCREEN</b>.</param>
    /// <param name="coordinates">- An array of affine coordinates the Coords object is set to.</param>
    /// <param name="doRound">- flag If true or null round the coordinates in usr2screen. This is used in smooth curve plotting.
    /// The IE needs rounded coordinates. Id doRound==false we have to round in updatePathString.</param>
    abstract setCoordinates: coord_type: float * coordinates: ResizeArray<obj option> * ?doRound: bool * ?noevent: bool -> Coords
    /// Test if one of the usrCoords is NaN or the coordinates are infinite.
    abstract isReal: unit -> bool
    /// Constructs a new Coordinates object.
    [<Emit "new $0($1...)">] 
    static member create: ``method``: CoordsMethod * coordinates: ResizeArray<float option> * board: Board * emitter: bool -> Coords = stub

/// A transformation consists of a 3x3 matrix, i.e. it is a projective transformation.
and [<AllowNullLiteral;AbstractClass>] Transformation =
    /// Updates the numerical data for the transformation, i.e. the entry of the subobject matrix.
    abstract update: unit -> Transformation
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
    //abstract setMatrix: board: JXG.Board * ``type``: string * ``params``: ResizeArray<obj option> * x: obj * y: ResizeArray<obj option> * scale_x: obj * scale_y: ResizeArray<obj option> * line: obj * : obj * point_pair: obj * : obj * : obj * apply: obj -> unit
    [<Emit "new $0($1...)">] static member Create: board: Board * ``type``: string * ``params``: obj option -> Transformation = stub

/// A composition is a simple container that manages none or more {@link JXG.GeometryElement}s.
and [<AllowNullLiteral;AbstractClass>] Composition =
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
    abstract add: what: string * element: U2<GeometryElement, Composition> -> bool
    /// <summary>Remove an element from the composition container.</summary>
    /// <param name="what">- The name used to access the element.</param>
    abstract remove: what: string -> bool

    /// A composition is a simple container that manages none or more {@link JXG.GeometryElement}s.
    [<Emit "new $0($1...)">] static member Create: elements: obj option -> Composition = stub

/// Constructs a new GeometryElement object.
and [<AllowNullLiteral>] GeometryElement =
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
    abstract board: Board with get, set
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
    abstract addChild: obj: GeometryElement -> unit
    /// <summary>Adds ids of elements to the array this.parents. This method needs to be called if some dependencies
    /// can not be detected automatically by JSXGraph. For example if a function graph is given by a function
    /// which referes to coordinates of a point, calling addParents() is necessary.</summary>
    /// <param name="parents">- Array of elements or ids of elements.
    /// Alternatively, one can give a list of objects as parameters.</param>
    abstract addParents: parents: ResizeArray<obj option> -> obj
    /// <summary>Sets ids of elements to the array this.parents.
    /// First, this.parents is cleared. See {@link JXG.GeometryElement#addParents}.</summary>
    /// <param name="parents">- Array of elements or ids of elements.
    /// Alternatively, one can give a list of objects as parameters.</param>
    abstract setParents: parents: ResizeArray<obj option> -> obj
    /// <summary>Remove an element as a child from the current element.</summary>
    /// <param name="obj">- The dependent object.</param>
    abstract removeChild: obj: GeometryElement -> unit
    /// Returns the elements name, Used in JessieCode.
    abstract getName: unit -> string
    /// <summary>Add transformations to this element.</summary>
    /// <param name="transform">- Either one {@link JXG.Transformation}
    /// or an array of {@link JXG.Transformation}s.</param>
    abstract addTransform: transform: U2<Transformation, ResizeArray<obj option>> -> GeometryElement
    /// <summary>Translates the object by <tt>(x, y)</tt>. In case the element is defined by points, the defining points are
    /// translated, e.g. a circle constructed by a center point and a point on the circle line.</summary>
    /// <param name="method">- The type of coordinates used here.
    /// Possible values are {@link JXG.COORDS_BY_USER} and {@link JXG.COORDS_BY_SCREEN}.</param>
    /// <param name="coords">- array of translation vector.</param>
    abstract setPosition: ``method``: float * coords: ResizeArray<obj option> -> GeometryElement
    /// <summary>Moves an element by the difference of two coordinates.</summary>
    /// <param name="method">- The type of coordinates used here.
    /// Possible values are {@link JXG.COORDS_BY_USER} and {@link JXG.COORDS_BY_SCREEN}.</param>
    /// <param name="coords">- coordinates in screen/user units</param>
    /// <param name="oldcoords">- previous coordinates in screen/user units</param>
    abstract setPositionDirectly: ``method``: float * coords: ResizeArray<obj option> * oldcoords: ResizeArray<obj option> -> GeometryElement
    /// Array of strings containing the polynomials defining the element.
    /// Used for determining geometric loci the groebner way.
    abstract generatePolynomial: unit -> ResizeArray<obj option>
    /// <summary>Animates properties for that object like stroke or fill color, opacity and maybe
    /// even more later.</summary>
    /// <param name="hash">- Object containing properties with target values for the animation.</param>
    /// <param name="time">- Number of milliseconds to complete the animation.</param>
    /// <param name="options">- Optional settings for the animation:<ul><li>callback: A function that is called as soon as the animation is finished.</li></ul></param>
    abstract animate: hash: obj option * time: float * ?options: obj -> GeometryElement
    /// General update method. Should be overwritten by the element itself.
    /// Can be used sometimes to commit changes to the object.
    abstract update: unit -> GeometryElement
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
    abstract setAttribute: attributes: obj option -> GeometryElement
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
    abstract getTextAnchor: unit -> Coords
    /// Returns the coords object where the label of the element shall be drawn.
    /// Differs in some cases from the values that getTextAnchor returns.
    abstract getLabelAnchor: unit -> Coords
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
    abstract highlight: ?force: bool -> Board
    /// Uses the "normal" properties of the element.
    abstract noHighlight: unit -> Board
    /// Removes all objects generated by the trace function.
    abstract clearTrace: unit -> unit
    /// Copy the element to background. This is used for tracing elements.
    abstract cloneToBackground: unit -> GeometryElement
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
    abstract snapToGrid: unit -> GeometryElement
    /// Snaps the element to points. Only works for points. Points will snap to the next point
    /// as defined in their properties {@link JXG.Point#attractorDistance} and {@link JXG.Point#attractorUnit}.
    /// Lines and circles
    /// will snap their parent points to points.
    abstract snapToPoints: unit -> GeometryElement
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
    abstract handleSnapToGrid: force: bool * fromParent: bool -> GeometryElement
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
    /// If true the element will be drawn in grey scale colors to visualize that it's only a draft.
    abstract draft: bool with get, set

/// This element is used to provide a constructor for a general point. A free point is created if the given parent elements are all numbers
/// and the property fixed is not set or set to false. If one or more parent elements is not a number but a string containing a GEONE<sub>x</sub>T
/// constraint or a function the point will be considered as constrained). That means that the user won't be able to change the point's
/// position directly.
and [<AllowNullLiteral>] Point =
    inherit GeometryElement 
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

/// Curves are the common object for function graphs, parametric curves, polar curves, and data plots.
and [<AllowNullLiteral>] Curve =
    inherit GeometryElement
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
    abstract qdt: obj with get, set
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
    abstract update: unit -> Curve
    /// Updates the visual contents of the curve.
    abstract updateRenderer: unit -> Curve
    /// For dynamic dataplots updateCurve can be used to compute new entries
    /// for the arrays {@link JXG.Curve#dataX} and {@link JXG.Curve#dataY}. It
    /// is used in {@link JXG.Curve#updateCurve}. Default is an empty method, can
    /// be overwritten by the user.
    abstract updateDataArray: unit -> unit
    /// Computes for equidistant points on the x-axis the values
    /// of the function.
    /// If the mousemove event triggers this update, we use only few
    /// points. Otherwise, e.g. on mouseup, many points are used.
    abstract updateCurve: unit -> Curve
    /// Check if at least one point on the curve is finite and real.
    abstract checkReal: unit -> unit
    /// <summary>Updates the data points of a parametric curve. This version is used if {@link JXG.Curve#doadvancedplot} is <tt>false</tt>.</summary>
    /// <param name="mi">- Left bound of curve</param>
    /// <param name="ma">- Right bound of curve</param>
    /// <param name="len">- Number of data points</param>
    abstract updateParametricCurveNaive: mi: float * ma: float * len: float -> Curve
    /// <summary>Updates the data points of a parametric curve. This version is used if {@link JXG.Curve#doadvancedplot} is <tt>true</tt>.
    /// Since 0.99 this algorithm is deprecated. It still can be used if {@link JXG.Curve#doadvancedplotold} is <tt>true</tt>.</summary>
    /// <param name="mi">- Left bound of curve</param>
    /// <param name="ma">- Right bound of curve</param>
    abstract updateParametricCurveOld: mi: float * ma: float -> Curve
    /// <summary>Updates the data points of a parametric curve. This version is used if {@link JXG.Curve#doadvancedplot} is <tt>true</tt>.</summary>
    /// <param name="mi">- Left bound of curve</param>
    /// <param name="ma">- Right bound of curve</param>
    abstract updateParametricCurve: mi: float * ma: float -> Curve
    /// Applies the transformations of the curve to the given point <tt>p</tt>.
    /// Before using it, {@link JXG.Curve#updateTransformMatrix} has to be called.
    abstract updateTransform: p: Point -> Point
    /// <summary>Add transformations to this curve.</summary>
    /// <param name="transform">- Either one {@link JXG.Transformation} or an array of {@link JXG.Transformation}s.</param>
    abstract addTransform: transform: U2<Transformation, ResizeArray<obj option>> -> Curve
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
    abstract moveTo: where: ResizeArray<obj option> -> Curve
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
    abstract getLabelAnchor: unit -> Coords
    /// <summary>Highlights the element.</summary>
    /// <param name="force">- Force the highlighting</param>
    abstract highlight: ?force: bool -> Board
    /// Copy the element to background. This is used for tracing elements.
    abstract cloneToBackground: unit -> GeometryElement
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
    abstract snapToGrid: unit -> GeometryElement
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

