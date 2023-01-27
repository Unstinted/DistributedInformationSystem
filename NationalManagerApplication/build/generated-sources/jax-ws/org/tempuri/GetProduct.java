
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
 *         &lt;element name="productid" type="{http://microsoft.com/wsdl/types/}guid"/>
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
    "productid"
})
@XmlRootElement(name = "GetProduct")
public class GetProduct {

    @XmlElement(required = true)
    protected String productid;

    /**
     * Gets the value of the productid property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getProductid() {
        return productid;
    }

    /**
     * Sets the value of the productid property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setProductid(String value) {
        this.productid = value;
    }

}
