Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel
Imports TravelManagementSystem

<System.Web.Services.WebService(Namespace:="http://travelmanagementsystem.org/hotelreservationinterface/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class HotelReservationInterface
    Inherits System.Web.Services.WebService

    <WebMethod()> _
    Public Function MakeReservation(ReservationLine As String) As String
        Dim ResReq As HotelReservationRequest = New HotelReservationRequest
        ResReq.MakeReservation(ReservationLine, "c:\training\reservations.txt")
        Return ""
    End Function

End Class