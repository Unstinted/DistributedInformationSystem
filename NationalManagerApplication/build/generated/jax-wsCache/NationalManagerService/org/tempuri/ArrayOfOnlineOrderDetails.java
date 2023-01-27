
package org.tempuri;

import java.util.ArrayList;
import java.util.List;
import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Java class for ArrayOfOnlineOrderDetails complex type.
 * 
 * <p>The following schema fragment specifies the expected content contained within this class.
 * 
 * <pre>
 * &lt;complexType name="ArrayOfOnlineOrderDetails">
 *   &lt;complexContent>
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType">
 *       &lt;sequence>
 *         &lt;element name="OnlineOrderDetails" type="{http://tempuri.org/}OnlineOrderDetails" maxOccurs="unbounded" minOccurs="0"/>
 *       &lt;/sequence>
 *     &lt;/restriction>
 *   &lt;/complexContent>
 * &lt;/complexType>
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "ArrayOfOnlineOrderDetails", propOrder = {
    "onlineOrderDetails"
})
public class ArrayOfOnlineOrderDetails {

    @XmlElement(name = "OnlineOrderDetails", nillable = true)
    protected List<OnlineOrderDetails> onlineOrderDetails;

    /**
     * Gets the value of the onlineOrderDetails property.
     * 
     * <p>
     * This accessor method returns a reference to the live list,
     * not a snapshot. Therefore any modification you make to the
     * returned list will be present inside the JAXB object.
     * This is why there is not a <CODE>set</CODE> method for the onlineOrderDetails property.
     * 
     * <p>
     * For example, to add a new item, do as follows:
     * <pre>
     *    getOnlineOrderDetails().add(newItem);
     * </pre>
     * 
     * 
     * <p>
     * Objects of the following type(s) are allowed in the list
     * {@link OnlineOrderDetails }
     * 
     * 
     */
    public List<OnlineOrderDetails> getOnlineOrderDetails() {
        if (onlineOrderDetails == null) {
            onlineOrderDetails = new ArrayList<OnlineOrderDetails>();
        }
        return this.onlineOrderDetails;
    }

}
