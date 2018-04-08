Public Class Form1

    Private Sub MakeReservation_Click(sender As Object, e As EventArgs) Handles MakeReservation.Click
        Dim ReservationLine As String
        ReservationLine = CheckInDate.Text & " " + CheckOutDate.Text & " " & ReservationName.Text
        Dim ResReq As HotelReservation.HotelReservationInterfaceClient = New HotelReservation.HotelReservationInterfaceClient

        ResReq.MakeReservation(ReservationLine)
        MsgBox("Reservation Request has been submitted to Hotel.")


    End Sub
End Class
