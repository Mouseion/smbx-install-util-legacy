﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
<<<<<<< HEAD
'     Runtime Version:4.0.30319.18052
=======
'     Runtime Version:4.0.30319.1008
>>>>>>> 1.4.1.0 Update
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
<<<<<<< HEAD
    Friend Module Resources
=======
    Public Module Resources
>>>>>>> 1.4.1.0 Update
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
<<<<<<< HEAD
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
=======
        Public ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
>>>>>>> 1.4.1.0 Update
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("SMBXInstaller.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
<<<<<<< HEAD
        Friend Property Culture() As Global.System.Globalization.CultureInfo
=======
        Public Property Culture() As Global.System.Globalization.CultureInfo
>>>>>>> 1.4.1.0 Update
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        Public ReadOnly Property AnotherBlock() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("AnotherBlock", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Public ReadOnly Property background_1() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("background_1", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Public ReadOnly Property background_2() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("background_2", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Public ReadOnly Property background_3() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("background_3", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Public ReadOnly Property background_4() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("background_4", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Public ReadOnly Property background_5() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("background_5", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Public ReadOnly Property Background_Main_Full() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Background_Main_Full", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Public ReadOnly Property Background_Snow() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Background_Snow", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Public ReadOnly Property exclamation_mark() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("exclamation mark", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Public ReadOnly Property Frame() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Frame", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Public ReadOnly Property SomeBlock() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("SomeBlock", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Public ReadOnly Property StatusStrip_Full() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("StatusStrip_Full", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Public ReadOnly Property StatusStrip_Snow() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("StatusStrip_Snow", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
    End Module
End Namespace
