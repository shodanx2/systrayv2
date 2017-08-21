Imports System
Namespace My.Res

    Friend Module Res

        Private resourceMan As Global.System.Resources.ResourceManager
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("Res", GetType(Res).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        Friend ReadOnly Property TrayIcon() As System.Drawing.Icon
            Get
                Dim obj As Object = ResourceManager.GetObject("ApertureIcon", resourceCulture)
                Return CType(obj,System.Drawing.Icon)
            End Get
        End Property

        Friend ReadOnly Property ApertureIcon() As System.Drawing.Icon
            Get
                Dim obj As Object = ResourceManager.GetObject("ApertureIcon", resourceCulture)
                Return CType(obj,System.Drawing.Icon)
            End Get
        End Property

        Friend ReadOnly Property AudioIcon() As System.Drawing.Icon
            Get
                Dim obj As Object = ResourceManager.GetObject("audioIcon", resourceCulture)
                Return CType(obj, System.Drawing.Icon)
            End Get
        End Property

        Friend ReadOnly Property BeakerIcon() As System.Drawing.Icon
            Get
                Dim obj As Object = ResourceManager.GetObject("beakerIcon", resourceCulture)
                Return CType(obj, System.Drawing.Icon)
            End Get
        End Property

        Friend ReadOnly Property CogIcon() As System.Drawing.Icon
            Get
                Dim obj As Object = ResourceManager.GetObject("cogIcon", resourceCulture)
                Return CType(obj, System.Drawing.Icon)
            End Get
        End Property

        Friend ReadOnly Property CommandIcon() As System.Drawing.Icon
            Get
                Dim obj As Object = ResourceManager.GetObject("commandIcon", resourceCulture)
                Return CType(obj, System.Drawing.Icon)
            End Get
        End Property

        Friend ReadOnly Property DollarIcon() As System.Drawing.Icon
            Get
                Dim obj As Object = ResourceManager.GetObject("dollarIcon", resourceCulture)
                Return CType(obj, System.Drawing.Icon)
            End Get
        End Property

        Friend ReadOnly Property FireIcon() As System.Drawing.Icon
            Get
                Dim obj As Object = ResourceManager.GetObject("fireIcon", resourceCulture)
                Return CType(obj, System.Drawing.Icon)
            End Get
        End Property

        Friend ReadOnly Property FlagIcon() As System.Drawing.Icon
            Get
                Dim obj As Object = ResourceManager.GetObject("flagIcon", resourceCulture)
                Return CType(obj, System.Drawing.Icon)
            End Get
        End Property

        Friend ReadOnly Property HomeIcon() As System.Drawing.Icon
            Get
                Dim obj As Object = ResourceManager.GetObject("homeIcon", resourceCulture)
                Return CType(obj, System.Drawing.Icon)
            End Get
        End Property

        Friend ReadOnly Property LocklockedIcon() As System.Drawing.Icon
            Get
                Dim obj As Object = ResourceManager.GetObject("locklockedIcon", resourceCulture)
                Return CType(obj, System.Drawing.Icon)
            End Get
        End Property

        Friend ReadOnly Property LockunlockedIcon() As System.Drawing.Icon
            Get
                Dim obj As Object = ResourceManager.GetObject("lockunlockedIcon", resourceCulture)
                Return CType(obj, System.Drawing.Icon)
            End Get
        End Property

    End Module
End Namespace
