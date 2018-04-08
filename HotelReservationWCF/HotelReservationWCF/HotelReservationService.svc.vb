' NOTE: You can use the "Rename" command on the context menu to change the class name "Service1" in code, svc and config file together.
' NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.vb at the Solution Explorer and start debugging.
Public Class HotelReservationService
    Implements HotelReservationInterface

    Public Sub New()
    End Sub

    Public Function MakeReservation(ByVal ReservationLine As String) As String Implements HotelReservationInterface.MakeReservation
        Dim ResReq As TravelManagementSystem.HotelReservationRequest = New TravelManagementSystem.HotelReservationRequest
        ResReq.MakeReservation(ReservationLine, "c:\training\reservations.txt")
        Return ""
    End Function



End Class
