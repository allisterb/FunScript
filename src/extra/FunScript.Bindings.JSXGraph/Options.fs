namespace FunScript.Bindings.JXG

open FunScript
open FunScript.Bindings

[<AutoOpen;JS>]
module Options = 
    type BoardOptions = {
        boundingbox: int array 
        maxBoundingBox: int array
        zoomFactor: float
        zoomX: float
        zoomY: float
        showCopyright: bool
        axis: U2<bool, AxisOptions>
        defaultAxes: XYAxesOptions
        showNavigation:bool
        showZoom: bool
        showReload: bool
        showScreenshot: bool
        screenshot: ScreenshotOptions
        showFullscreen: bool
        fullscreen: FullscreenOptions
        showClearTraces: bool
        keepAspectRatio: bool
        ignoreLabels: bool
        maxNameLength: int
        document: bool
        takeFirst: bool
        takeSizeFromFile: bool
        renderer: Renderer
        animationDelay: int
        registerEvents: bool
        minimizeReflow: string
        offsetX: int 
        offsetY: int
        zoom: ZoomOptions
        pan: PanOptions
        selection: SelectionOptions
    }

    and XYAxesOptions = {
        x: AxisOptions
        y: AxisOptions
    }

    and AxisOptions = {
        name: string
        ticks: TickOptions
    }

    and TickOptions = {
        label: LabelOptions
        tickEndings: int array
        drawZero: bool
        visible: Visibility
    }

    and LabelOptions = {
        visible: Visibility
        anchorX: Anchor
        anchorY: Anchor
        fontSize: int
        offset: int array    
    }

    and [<StringEnum>] Visibility = Inherit
    
    and [<StringEnum>] Anchor = Top | Middle | Bottom | Right | Left
    
    and ScreenshotOptions = {
        scale: float
        ``type``: string
        symbol: string
        css: string
        cssButton: string
    }

    and FullscreenOptions = {
        symbol: string
    }

    and [<StringEnum>] Renderer = Auto | Svg
    
    and ZoomOptions = {
        enabled: bool
        factorX: float
        factorY: float
        wheel: bool
        needShift: bool
        min: float
        max: float
        pinchHorizontal: bool
        pinchVertical: bool
        pinchSensitivity: int
    }

    and PanOptions = {
        needShift: bool
        needTwoFingers: bool
        enabled: bool
    }

    and SelectionOptions = {
        enabled: bool
        name: string
        needShift: bool
        needCtrl: bool
        withLines: bool
        vertices: VerticesOptions
        fillColor: string
        visible: bool
    }

    and VerticesOptions = {
        visible: bool
    }

    type ElementOptions = {
        strokeColor: string
        highlightStrokeColor: string
        fillColor:  string
        highlightFillColor: string
        strokeOpacity: int
        highlightStrokeOpacity: int
        fillOpacity: int
        highlightFillOpacity: int
        transitionDuration: int
        strokeWidth: int
        highlightStrokeWidth: int
        ``fixed``: bool
        frozen: bool
        withLabel: bool
        visible: bool
        priv: bool
        layer: int
        shadow: bool
    }