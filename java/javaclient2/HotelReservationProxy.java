import org.tempuri.*;

public class HotelReservationProxy {

	public static void main(String[] args) {



		String ReservationLine=args[0].replace("%20"," ");
		HotelReservationService HotelReservation = new HotelReservationService();
		HotelReservationInterface ResReq = HotelReservation.getBasicHttpBindingHotelReservationInterface();

		String response = ResReq.makeReservation(ReservationLine);
		System.out.println("Sent Reservation to Hotel Server");

	}

}
