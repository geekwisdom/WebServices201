
package org.tempuri;

import javax.xml.bind.JAXBElement;
import javax.xml.bind.annotation.XmlElementDecl;
import javax.xml.bind.annotation.XmlRegistry;
import javax.xml.namespace.QName;


/**
 * This object contains factory methods for each 
 * Java content interface and Java element interface 
 * generated in the org.tempuri package. 
 * <p>An ObjectFactory allows you to programatically 
 * construct new instances of the Java representation 
 * for XML content. The Java representation of XML 
 * content can consist of schema derived interfaces 
 * and classes representing the binding of schema 
 * type definitions, element declarations and model 
 * groups.  Factory methods for each of these are 
 * provided in this class.
 * 
 */
@XmlRegistry
public class ObjectFactory {

    private final static QName _MakeReservationReservationLine_QNAME = new QName("http://tempuri.org/", "ReservationLine");
    private final static QName _MakeReservationResponseMakeReservationResult_QNAME = new QName("http://tempuri.org/", "MakeReservationResult");

    /**
     * Create a new ObjectFactory that can be used to create new instances of schema derived classes for package: org.tempuri
     * 
     */
    public ObjectFactory() {
    }

    /**
     * Create an instance of {@link MakeReservation }
     * 
     */
    public MakeReservation createMakeReservation() {
        return new MakeReservation();
    }

    /**
     * Create an instance of {@link MakeReservationResponse }
     * 
     */
    public MakeReservationResponse createMakeReservationResponse() {
        return new MakeReservationResponse();
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://tempuri.org/", name = "ReservationLine", scope = MakeReservation.class)
    public JAXBElement<String> createMakeReservationReservationLine(String value) {
        return new JAXBElement<String>(_MakeReservationReservationLine_QNAME, String.class, MakeReservation.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://tempuri.org/", name = "MakeReservationResult", scope = MakeReservationResponse.class)
    public JAXBElement<String> createMakeReservationResponseMakeReservationResult(String value) {
        return new JAXBElement<String>(_MakeReservationResponseMakeReservationResult_QNAME, String.class, MakeReservationResponse.class, value);
    }

}
