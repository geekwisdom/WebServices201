Imports HotelRequestClient.localhost
Module Module1

    Sub Main()
        Dim CheckInDate As String
        Dim CheckOutDate As String
        Dim ReservationName As String
        Dim ReservationLine As String

        Console.Write("Check In Date: ")
        CheckInDate = Console.ReadLine()
        Console.Write("Check Out Date: ")
        CheckOutDate = Console.ReadLine()
        Console.Write("Reservation Name: ")
        ReservationName = Console.ReadLine()
        ReservationLine = CheckInDate + " " + CheckOutDate + " " + ReservationName
        Dim ResRequest As localhost.HotelReservationInterface = New localhost.HotelReservationInterface
        ResRequest.MakeReservation(ReservationLine)
        Console.WriteLine("Reservation Request sent to Hotel Server")

        Console.ReadLine()

    End Sub

End Module
