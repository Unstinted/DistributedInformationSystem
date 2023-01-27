
package org.tempuri;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Java class for anonymous complex type.
 * 
 * <p>The following schema fragment specifies the expected content contained within this class.
 * 
 * <pre>
 * &lt;complexType>
 *   &lt;complexContent>
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType">
 *       &lt;sequence>
 *         &lt;element name="GetListOfStoreResult" type="{http://tempuri.org/}ArrayOfStore" minOccurs="0"/>
 *       &lt;/sequence>
 *     &lt;/restriction>
 *   &lt;/complexContent>
 * &lt;/complexType>
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "", propOrder = {
    "getListOfStoreResult"
})
@XmlRootElement(name = "GetListOfStoreResponse")
public class GetListOfStoreResponse {

    @XmlElement(name = "GetListOfStoreResult")
    protected ArrayOfStore getListOfStoreResult;

    /**
     * Gets the value of the getListOfStoreResult property.
     * 
     * @return
     *     possible object is
     *     {@link ArrayOfStore }
     *     
     */
    public ArrayOfStore getGetListOfStoreResult() {
        return getListOfStoreResult;
    }

    /**
     * Sets the value of the getListOfStoreResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link ArrayOfStore }
     *     
     */
    public void setGetListOfStoreResult(ArrayOfStore value) {
        this.getListOfStoreResult = value;
    }

}
