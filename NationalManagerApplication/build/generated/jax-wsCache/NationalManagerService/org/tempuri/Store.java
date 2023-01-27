
package org.tempuri;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Java class for Store complex type.
 * 
 * <p>The following schema fragment specifies the expected content contained within this class.
 * 
 * <pre>
 * &lt;complexType name="Store">
 *   &lt;complexContent>
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType">
 *       &lt;sequence>
 *         &lt;element name="StoreId" type="{http://www.w3.org/2001/XMLSchema}int"/>
 *         &lt;element name="storeAddress" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/>
 *       &lt;/sequence>
 *     &lt;/restriction>
 *   &lt;/complexContent>
 * &lt;/complexType>
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "Store", propOrder = {
    "storeId",
    "storeAddress"
})
public class Store {

    @XmlElement(name = "StoreId")
    protected int storeId;
    protected String storeAddress;

    /**
     * Gets the value of the storeId property.
     * 
     */
    public int getStoreId() {
        return storeId;
    }

    /**
     * Sets the value of the storeId property.
     * 
     */
    public void setStoreId(int value) {
        this.storeId = value;
    }

    /**
     * Gets the value of the storeAddress property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getStoreAddress() {
        return storeAddress;
    }

    /**
     * Sets the value of the storeAddress property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setStoreAddress(String value) {
        this.storeAddress = value;
    }

}
