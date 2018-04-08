' NOTE: You can use the "Rename" command on the context menu to change the interface name "IService1" in both code and config file together.
<ServiceContract()>
Public Interface HotelReservationInterface

    <OperationContract()>
    Function MakeReservation(ByVal ReservationLine As String) As String


  

End Interface

' Use a data contract as illustrated in the sample below to add composite types to service operations.
