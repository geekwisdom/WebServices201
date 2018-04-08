import java.util.*;
import org.travelmanagementsystem.hotelreservationinterface.*;

public class HotelReservationClient {

	public static void main(String[] args) {
	
	Scanner Systemin = new Scanner(System.in);
		
          String CheckInDate="";
	  String CheckOutDate="";
	  String ReservationName="";
	  System.out.print("Enter Check In Date: ");
	  CheckInDate = Systemin.nextLine();

	  System.out.print("Enter Check Out Date: ");
	  CheckOutDate = Systemin.nextLine();

	  System.out.print("Enter Reservation Name: ");
	  ReservationName = Systemin.nextLine();
	
	String ReservationLine = CheckInDate + " " + CheckOutDate + " " + ReservationName;

	HotelReservationInterface HotelReservation = new HotelReservationInterface();
	HotelReservationInterfaceSoap ResReq = HotelReservation.getHotelReservationInterfaceSoap();
	String response = ResReq.makeReservation(ReservationLine);
	System.out.println("Sent Reservation to Hotel Server");

	}

}
