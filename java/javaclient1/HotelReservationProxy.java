
import org.travelmanagementsystem.hotelreservationinterface.*;

public class HotelReservationProxy {

	public static void main(String[] args) {

 		String text=args[0].replace("%20"," ");
		HotelReservationInterface HotelReservation = new HotelReservationInterface();
		HotelReservationInterfaceSoap ResReq = HotelReservation.getHotelReservationInterfaceSoap();
		String response = ResReq.makeReservation(text);
		//System.out.println(response);
		System.out.println("Sent Reservation to Hotel Server");

	}

}
