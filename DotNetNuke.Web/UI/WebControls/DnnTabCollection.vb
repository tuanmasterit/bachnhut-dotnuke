﻿'
' DotNetNuke - http://www.dotnetnuke.com
' Copyright (c) 2002-2010
' by DotNetNuke Corporation
'
' Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated 
' documentation files (the "Software"), to deal in the Software without restriction, including without limitation 
' the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and 
' to permit persons to whom the Software is furnished to do so, subject to the following conditions:
'
' The above copyright notice and this permission notice shall be included in all copies or substantial portions 
' of the Software.
'
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED 
' TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL 
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF 
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
' DEALINGS IN THE SOFTWARE.
'

Imports System
Imports System.Web.UI

Namespace DotNetNuke.Web.UI.WebControls

    Public Class DnnTabCollection
        Inherits System.Web.UI.ControlCollection
        Public Sub New(ByVal owner As Control)
            MyBase.New(owner)
        End Sub

        Public Overloads Overrides Sub Add(ByVal child As Control)
            If TypeOf child Is DnnTab Then
                MyBase.Add(child)
            Else
                Throw New ArgumentException("DnnTabCollection must contain controls of type DnnTab")
            End If
        End Sub

        Public Overloads Overrides Sub AddAt(ByVal index As Integer, ByVal child As Control)
            If TypeOf child Is DnnTab Then
                MyBase.AddAt(index, child)
            Else
                Throw New ArgumentException("DnnTabCollection must contain controls of type DnnTab")
            End If
        End Sub

        Default Public Shadows ReadOnly Property Item(ByVal index As Integer) As DnnTab
            Get
                Return DirectCast(MyBase.Item(index), DnnTab)
            End Get
        End Property
    End Class

End Namespace
