
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
 *         &lt;element name="GetProductResult" type="{http://tempuri.org/}Product" minOccurs="0"/>
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
    "getProductResult"
})
@XmlRootElement(name = "GetProductResponse")
public class GetProductResponse {

    @XmlElement(name = "GetProductResult")
    protected Product getProductResult;

    /**
     * Gets the value of the getProductResult property.
     * 
     * @return
     *     possible object is
     *     {@link Product }
     *     
     */
    public Product getGetProductResult() {
        return getProductResult;
    }

    /**
     * Sets the value of the getProductResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link Product }
     *     
     */
    public void setGetProductResult(Product value) {
        this.getProductResult = value;
    }

}
