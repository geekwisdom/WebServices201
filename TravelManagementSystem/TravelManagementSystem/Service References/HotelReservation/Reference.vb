﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace HotelReservation
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="HotelReservation.HotelReservationInterface")>  _
    Public Interface HotelReservationInterface
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/HotelReservationInterface/MakeReservation", ReplyAction:="http://tempuri.org/HotelReservationInterface/MakeReservationResponse")>  _
        Function MakeReservation(ByVal ReservationLine As String) As String
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/HotelReservationInterface/MakeReservation", ReplyAction:="http://tempuri.org/HotelReservationInterface/MakeReservationResponse")>  _
        Function MakeReservationAsync(ByVal ReservationLine As String) As System.Threading.Tasks.Task(Of String)
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface HotelReservationInterfaceChannel
        Inherits HotelReservation.HotelReservationInterface, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class HotelReservationInterfaceClient
        Inherits System.ServiceModel.ClientBase(Of HotelReservation.HotelReservationInterface)
        Implements HotelReservation.HotelReservationInterface
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        Public Function MakeReservation(ByVal ReservationLine As String) As String Implements HotelReservation.HotelReservationInterface.MakeReservation
            Return MyBase.Channel.MakeReservation(ReservationLine)
        End Function
        
        Public Function MakeReservationAsync(ByVal ReservationLine As String) As System.Threading.Tasks.Task(Of String) Implements HotelReservation.HotelReservationInterface.MakeReservationAsync
            Return MyBase.Channel.MakeReservationAsync(ReservationLine)
        End Function
    End Class
End Namespace
