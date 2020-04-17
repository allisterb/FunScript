namespace FunScript.Bindings.JXG

open FunScript

[<AutoOpen;JS>]
module Constants =
    // coords
    [<Literal>] 
    let COORDS_BY_USER= 0x0001
    [<Literal>] 
    let COORDS_BY_SCREEN= 0x0002

    // object types
    [<Literal>] 
    let OBJECT_TYPE_ARC= 1
    [<Literal>] 
    let OBJECT_TYPE_ARROW= 2
    [<Literal>] 
    let OBJECT_TYPE_AXIS= 3
    [<Literal>] 
    let OBJECT_TYPE_AXISPOINT= 4
    [<Literal>] 
    let OBJECT_TYPE_TICKS= 5
    [<Literal>] 
    let OBJECT_TYPE_CIRCLE= 6
    [<Literal>] 
    let OBJECT_TYPE_CONIC= 7
    [<Literal>] 
    let OBJECT_TYPE_CURVE= 8
    [<Literal>] 
    let OBJECT_TYPE_GLIDER= 9
    [<Literal>] 
    let OBJECT_TYPE_IMAGE= 10
    [<Literal>] 
    let OBJECT_TYPE_LINE= 11
    [<Literal>] 
    let OBJECT_TYPE_POINT= 12
    [<Literal>] 
    let OBJECT_TYPE_SLIDER= 13
    [<Literal>] 
    let OBJECT_TYPE_CAS= 14
    [<Literal>] 
    let OBJECT_TYPE_GXTCAS= 15
    [<Literal>] 
    let OBJECT_TYPE_POLYGON= 16
    [<Literal>] 
    let OBJECT_TYPE_SECTOR= 17
    [<Literal>] 
    let OBJECT_TYPE_TEXT= 18
    [<Literal>] 
    let OBJECT_TYPE_ANGLE= 19
    [<Literal>] 
    let OBJECT_TYPE_INTERSECTION= 20
    [<Literal>] 
    let OBJECT_TYPE_TURTLE= 21
    [<Literal>] 
    let OBJECT_TYPE_VECTOR= 22
    [<Literal>] 
    let OBJECT_TYPE_OPROJECT= 23
    [<Literal>] 
    let OBJECT_TYPE_GRID= 24
    [<Literal>] 
    let OBJECT_TYPE_TANGENT= 25
    [<Literal>] 
    let OBJECT_TYPE_HTMLSLIDER= 26
    [<Literal>] 
    let OBJECT_TYPE_CHECKBOX= 27
    [<Literal>] 
    let OBJECT_TYPE_INPUT= 28
    [<Literal>] 
    let OBJECT_TYPE_BUTTON= 29
    [<Literal>] 
    let OBJECT_TYPE_TRANSFORMATION= 30

    // object classes
    [<Literal>] 
    let OBJECT_CLASS_POINT= 1
    [<Literal>] 
    let OBJECT_CLASS_LINE= 2
    [<Literal>] 
    let OBJECT_CLASS_CIRCLE= 3
    [<Literal>] 
    let OBJECT_CLASS_CURVE= 4
    [<Literal>] 
    let OBJECT_CLASS_AREA= 5
    [<Literal>] 
    let OBJECT_CLASS_OTHER= 6
    [<Literal>] 
    let OBJECT_CLASS_TEXT= 7

    // SketchReader constants
    [<Literal>] 
    let GENTYPE_ABC= 1 // unused
    [<Literal>] 
    let GENTYPE_AXIS= 2
    [<Literal>] 
    let GENTYPE_MID= 3
    [<Literal>] 
    let GENTYPE_REFLECTION= 4
    [<Literal>] 
    let GENTYPE_MIRRORELEMENT= 5
    [<Literal>] 
    let GENTYPE_TANGENT= 6
    [<Literal>] 
    let GENTYPE_PARALLEL= 7
    [<Literal>] 
    let GENTYPE_BISECTORLINES= 8
    [<Literal>] 
    let GENTYPE_BOARDIMG= 9
    [<Literal>] 
    let GENTYPE_BISECTOR= 10
    [<Literal>] 
    let GENTYPE_NORMAL= 11
    [<Literal>] 
    let GENTYPE_POINT= 12
    [<Literal>] 
    let GENTYPE_GLIDER= 13
    [<Literal>] 
    let GENTYPE_INTERSECTION= 14
    [<Literal>] 
    let GENTYPE_CIRCLE= 15
    [<Literal>] 
    let GENTYPE_CIRCLE2POINTS= 16
    [<Literal>] 
    let GENTYPE_LINE= 17
    [<Literal>] 
    let GENTYPE_TRIANGLE= 18
    [<Literal>] 
    let GENTYPE_QUADRILATERAL= 19
    [<Literal>] 
    let GENTYPE_TEXT= 20
    [<Literal>] 
    let GENTYPE_POLYGON= 21
    [<Literal>] 
    let GENTYPE_REGULARPOLYGON= 22
    [<Literal>] 
    let GENTYPE_SECTOR= 23
    [<Literal>] 
    let GENTYPE_ANGLE= 24
    [<Literal>] 
    let GENTYPE_PLOT= 25
    [<Literal>] 
    let GENTYPE_SLIDER= 26
    [<Literal>] 
    let GENTYPE_TRUNCATE= 27
    [<Literal>] 
    let GENTYPE_JCODE= 28
    [<Literal>] 
    let GENTYPE_MOVEMENT= 29
    [<Literal>] 
    let GENTYPE_COMBINED= 30
    [<Literal>] 
    let GENTYPE_RULER= 31
    [<Literal>] 
    let GENTYPE_SLOPETRIANGLE= 32
    [<Literal>] 
    let GENTYPE_PERPSEGMENT= 33
    [<Literal>] 
    let GENTYPE_LABELMOVEMENT= 34
    [<Literal>] 
    let GENTYPE_VECTOR= 35
    [<Literal>] 
    let GENTYPE_NONREFLEXANGLE= 36
    [<Literal>] 
    let GENTYPE_REFLEXANGLE= 37
    [<Literal>] 
    let GENTYPE_PATH= 38
    [<Literal>] 
    let GENTYPE_DERIVATIVE= 39
    // 40 // unused ...
    [<Literal>] 
    let GENTYPE_DELETE= 41
    [<Literal>] 
    let GENTYPE_COPY= 42
    [<Literal>] 
    let GENTYPE_MIRROR= 43
    [<Literal>] 
    let GENTYPE_ROTATE= 44
    [<Literal>] 
    let GENTYPE_ABLATION= 45
    [<Literal>] 
    let GENTYPE_MIGRATE= 46
    [<Literal>] 
    let GENTYPE_VECTORCOPY= 47
    [<Literal>] 
    let GENTYPE_POLYGONCOPY= 48
//        [<Literal>] let GENTYPE_TRANSFORM= 48 // unused
    // 49 ... 50 // unused ...

    // IMPORTANT=
    // ----------
    // For being able to differentiate between the (GUI-specific) CTX and
    // (CORE-specific) non-CTX steps the non-CTX steps MUST NOT be changed
    // to values > 50.

    [<Literal>] 
    let GENTYPE_CTX_TYPE_G= 51
    [<Literal>] 
    let GENTYPE_CTX_TYPE_P= 52
    [<Literal>] 
    let GENTYPE_CTX_TRACE= 53
    [<Literal>] 
    let GENTYPE_CTX_VISIBILITY= 54
    [<Literal>] 
    let GENTYPE_CTX_CCVISIBILITY= 55 // unused
    [<Literal>] 
    let GENTYPE_CTX_MPVISIBILITY= 56
    [<Literal>] 
    let GENTYPE_CTX_WITHLABEL= 57
    [<Literal>] 
    let GENTYPE_CTX_LABEL= 58
    [<Literal>] 
    let GENTYPE_CTX_FIXED= 59
    [<Literal>] 
    let GENTYPE_CTX_STROKEWIDTH= 60
    [<Literal>] 
    let GENTYPE_CTX_LABELSIZE= 61
    [<Literal>] 
    let GENTYPE_CTX_SIZE= 62
    [<Literal>] 
    let GENTYPE_CTX_FACE= 63
    [<Literal>] 
    let GENTYPE_CTX_STRAIGHT= 64
    [<Literal>] 
    let GENTYPE_CTX_ARROW= 65
    [<Literal>] 
    let GENTYPE_CTX_COLOR= 66
    [<Literal>] 
    let GENTYPE_CTX_RADIUS= 67
    [<Literal>] 
    let GENTYPE_CTX_COORDS= 68
    [<Literal>] 
    let GENTYPE_CTX_TEXT= 69
    [<Literal>] 
    let GENTYPE_CTX_ANGLERADIUS= 70
    [<Literal>] 
    let GENTYPE_CTX_DOTVISIBILITY= 71
    [<Literal>] 
    let GENTYPE_CTX_FILLOPACITY= 72
    [<Literal>] 
    let GENTYPE_CTX_PLOT= 73
    [<Literal>] 
    let GENTYPE_CTX_SCALE= 74
    [<Literal>] 
    let GENTYPE_CTX_INTVAL= 75
    [<Literal>] 
    let GENTYPE_CTX_POINT1= 76
    [<Literal>] 
    let GENTYPE_CTX_POINT2= 77
    [<Literal>] 
    let GENTYPE_CTX_LABELSTICKY= 78
    [<Literal>] 
    let GENTYPE_CTX_TYPE_I= 79
    [<Literal>] 
    let GENTYPE_CTX_HASINNERPOINTS= 80
    [<Literal>] 
    let GENTYPE_CTX_SNAPWIDTH= 81
    [<Literal>] 
    let GENTYPE_CTX_SNAPTOGRID= 82